using System.Globalization;
using System.Security.Cryptography;
using Datos.Seguridad;
using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioEmpleados
{
    public async Task<List<EmpleadoListado>> ListarAsync(string buscar, uint departamento,
        uint contrato, string estado, int pagina, int tamano)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var comando = new MySqlCommand("""
            SELECT e.id_empleado,e.codigo,e.dpi,CONCAT(e.nombres,' ',e.apellidos),
                COALESCE(d.nombre,''),COALESCE(p.nombre,''),e.estado
            FROM empleados e
            LEFT JOIN historial_laboral h ON h.id_empleado=e.id_empleado
                AND h.fecha_inicio<=@fecha AND (h.fecha_fin IS NULL OR h.fecha_fin>@fecha)
            LEFT JOIN puestos p ON p.id_puesto=h.id_puesto
            LEFT JOIN departamentos d ON d.id_departamento=p.id_departamento
            WHERE (e.codigo LIKE @texto OR e.dpi LIKE @texto OR CONCAT(e.nombres,' ',e.apellidos) LIKE @texto)
                AND (@departamento=0 OR d.id_departamento=@departamento)
                AND (@contrato=0 OR h.id_tipo_contrato=@contrato)
                AND (@estado='Todos' OR e.estado=@estado)
            ORDER BY e.apellidos,e.nombres,e.id_empleado LIMIT @limite OFFSET @inicio;
            """, conexion);
        comando.Parameters.AddWithValue("@fecha", DateTime.UtcNow.AddHours(-6).Date);
        comando.Parameters.AddWithValue("@texto", "%" + buscar + "%");
        comando.Parameters.AddWithValue("@departamento", departamento);
        comando.Parameters.AddWithValue("@contrato", contrato);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@limite", tamano + 1);
        comando.Parameters.AddWithValue("@inicio", pagina * tamano);
        await using var lector = await comando.ExecuteReaderAsync();
        var empleados = new List<EmpleadoListado>();
        while (await lector.ReadAsync())
            empleados.Add(new EmpleadoListado
            {
                IdEmpleado = lector.GetUInt32(0),
                Codigo = lector.GetString(1),
                Dpi = lector.GetString(2),
                Nombre = lector.GetString(3),
                Departamento = lector.GetString(4),
                Puesto = lector.GetString(5),
                Estado = lector.GetString(6)
            });
        return empleados;
    }

    public async Task<Empleado> BuscarAsync(uint id, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, null, autor);
        try
        {
            Empleado empleado;
            await using (var comando = new MySqlCommand("""
                SELECT codigo,dpi,nombres,apellidos,fecha_nacimiento,telefono,correo,direccion,
                    fotografia,fotografia_tipo,fecha_contratacion,fecha_baja,estado,banco,cuenta_bancaria_cifrada
                FROM empleados WHERE id_empleado=@id;
                """, conexion))
            {
                comando.Parameters.AddWithValue("@id", id);
                await using var lector = await comando.ExecuteReaderAsync();
                if (!await lector.ReadAsync())
                    throw new InvalidOperationException("El empleado ya no existe.");
                empleado = new Empleado
                {
                    IdEmpleado = id,
                    Codigo = lector.GetString(0),
                    Dpi = lector.GetString(1),
                    Nombres = lector.GetString(2),
                    Apellidos = lector.GetString(3),
                    FechaNacimiento = lector.IsDBNull(4) ? null : lector.GetDateTime(4),
                    Telefono = lector.IsDBNull(5) ? null : lector.GetString(5),
                    Correo = lector.IsDBNull(6) ? null : lector.GetString(6),
                    Direccion = lector.IsDBNull(7) ? null : lector.GetString(7),
                    Fotografia = lector.IsDBNull(8) ? null : (byte[])lector.GetValue(8),
                    FotografiaTipo = lector.IsDBNull(9) ? null : lector.GetString(9),
                    FechaContratacion = lector.GetDateTime(10),
                    FechaBaja = lector.IsDBNull(11) ? null : lector.GetDateTime(11),
                    Estado = lector.GetString(12),
                    DatosBancarios = new DatosBancarios
                    {
                        Banco = lector.IsDBNull(13) ? null : lector.GetString(13),
                        Cuenta = lector.IsDBNull(14) ? null : CifradoDatos.Descifrar((byte[])lector.GetValue(14), clave, $"cuenta:{id}")
                    }
                };
            }
            empleado.Condicion = new CondicionLaboral
            {
                IdEmpleado = id,
                FechaInicio = empleado.FechaContratacion
            };
            await using var laboral = new MySqlCommand("""
                SELECT h.id_puesto,h.id_tipo_contrato,h.id_horario,h.fecha_inicio,h.salario_cifrado,h.motivo,p.id_departamento
                FROM historial_laboral h JOIN puestos p ON p.id_puesto=h.id_puesto
                WHERE h.id_empleado=@id ORDER BY h.fecha_inicio DESC LIMIT 1;
                """, conexion);
            laboral.Parameters.AddWithValue("@id", id);
            await using var fila = await laboral.ExecuteReaderAsync();
            if (await fila.ReadAsync())
                empleado.Condicion = new CondicionLaboral
                {
                    IdEmpleado = id,
                    IdPuesto = fila.GetUInt32(0),
                    IdTipoContrato = fila.GetUInt32(1),
                    IdHorario = fila.GetUInt32(2),
                    FechaInicio = fila.GetDateTime(3),
                    Motivo = fila.GetString(5),
                    IdDepartamento = fila.GetUInt32(6),
                    Salario = CifradoDatos.DescifrarImporte((byte[])fila.GetValue(4), clave, Contexto(id, fila.GetDateTime(3)))
                };
            return empleado;
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }

    public async Task<uint> GuardarAsync(Empleado empleado, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, transaccion, autor);
        try
        {
            bool nuevo = empleado.IdEmpleado == 0;
            if (!nuevo)
            {
                await using (var bloquear = new MySqlCommand("SELECT fecha_baja FROM empleados WHERE id_empleado=@id FOR UPDATE;", conexion, transaccion))
                {
                    bloquear.Parameters.AddWithValue("@id", empleado.IdEmpleado);
                    var baja = await bloquear.ExecuteScalarAsync();
                    if (baja is DateTime fechaBaja && empleado.FechaContratacion.Date > fechaBaja.Date)
                        throw new ArgumentException("La contratación no puede ser posterior a la fecha de baja.");
                }
                await using var primera = new MySqlCommand("SELECT MIN(fecha_inicio) FROM historial_laboral WHERE id_empleado=@id;", conexion, transaccion);
                primera.Parameters.AddWithValue("@id", empleado.IdEmpleado);
                if (await primera.ExecuteScalarAsync() is DateTime inicio && empleado.FechaContratacion.Date > inicio.Date)
                    throw new ArgumentException("La contratación no puede ser posterior al inicio del historial laboral.");
            }
            await using var guardar = new MySqlCommand(nuevo ? """
                INSERT INTO empleados (codigo,dpi,nombres,apellidos,fecha_nacimiento,telefono,correo,direccion,fotografia,fotografia_tipo,fecha_contratacion)
                VALUES (@codigo,@dpi,@nombres,@apellidos,@nacimiento,@telefono,@correo,@direccion,@foto,@tipo,@contratacion);
                """ : """
                UPDATE empleados SET codigo=@codigo,dpi=@dpi,nombres=@nombres,apellidos=@apellidos,
                    fecha_nacimiento=@nacimiento,telefono=@telefono,correo=@correo,direccion=@direccion,
                    fotografia=@foto,fotografia_tipo=@tipo,fecha_contratacion=@contratacion WHERE id_empleado=@id;
                """, conexion, transaccion);
            guardar.Parameters.AddWithValue("@id", empleado.IdEmpleado);
            guardar.Parameters.AddWithValue("@codigo", empleado.Codigo);
            guardar.Parameters.AddWithValue("@dpi", empleado.Dpi);
            guardar.Parameters.AddWithValue("@nombres", empleado.Nombres);
            guardar.Parameters.AddWithValue("@apellidos", empleado.Apellidos);
            guardar.Parameters.AddWithValue("@nacimiento", (object?)empleado.FechaNacimiento?.Date ?? DBNull.Value);
            guardar.Parameters.AddWithValue("@telefono", (object?)empleado.Telefono ?? DBNull.Value);
            guardar.Parameters.AddWithValue("@correo", (object?)empleado.Correo ?? DBNull.Value);
            guardar.Parameters.AddWithValue("@direccion", (object?)empleado.Direccion ?? DBNull.Value);
            guardar.Parameters.AddWithValue("@foto", (object?)empleado.Fotografia ?? DBNull.Value);
            guardar.Parameters.AddWithValue("@tipo", (object?)empleado.FotografiaTipo ?? DBNull.Value);
            guardar.Parameters.AddWithValue("@contratacion", empleado.FechaContratacion.Date);
            if (await guardar.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("El empleado ya no existe.");
            uint id = nuevo ? checked((uint)guardar.LastInsertedId) : empleado.IdEmpleado;
            await using var banco = new MySqlCommand("UPDATE empleados SET banco=@banco,cuenta_bancaria_cifrada=@cuenta WHERE id_empleado=@id;", conexion, transaccion);
            banco.Parameters.AddWithValue("@id", id);
            banco.Parameters.AddWithValue("@banco", (object?)empleado.DatosBancarios.Banco ?? DBNull.Value);
            banco.Parameters.AddWithValue("@cuenta", empleado.DatosBancarios.Cuenta is null ? DBNull.Value
                : CifradoDatos.Cifrar(empleado.DatosBancarios.Cuenta, clave, $"cuenta:{id}"));
            await banco.ExecuteNonQueryAsync();
            if (nuevo)
            {
                var condicion = empleado.Condicion;
                await using var insertar = new MySqlCommand("""
                    INSERT INTO historial_laboral (id_empleado,id_puesto,id_tipo_contrato,id_horario,fecha_inicio,salario_cifrado,motivo,id_usuario_autoriza)
                    SELECT @empleado,p.id_puesto,t.id_tipo_contrato,h.id_horario,@inicio,@salario,@motivo,@autor
                    FROM puestos p JOIN departamentos d ON d.id_departamento=p.id_departamento
                        JOIN tipos_contrato t ON t.id_tipo_contrato=@contrato JOIN horarios h ON h.id_horario=@horario
                    WHERE p.id_puesto=@puesto AND p.activo=TRUE AND d.activo=TRUE AND t.activo=TRUE AND h.activo=TRUE;
                    """, conexion, transaccion);
                insertar.Parameters.AddWithValue("@empleado", id);
                insertar.Parameters.AddWithValue("@puesto", condicion.IdPuesto);
                insertar.Parameters.AddWithValue("@contrato", condicion.IdTipoContrato);
                insertar.Parameters.AddWithValue("@horario", condicion.IdHorario);
                insertar.Parameters.AddWithValue("@inicio", condicion.FechaInicio.Date);
                insertar.Parameters.AddWithValue("@salario", CifradoDatos.CifrarImporte(condicion.Salario, clave, Contexto(id, condicion.FechaInicio)));
                insertar.Parameters.AddWithValue("@motivo", condicion.Motivo);
                insertar.Parameters.AddWithValue("@autor", autor.IdUsuario);
                if (await insertar.ExecuteNonQueryAsync() != 1)
                    throw new InvalidOperationException("Selecciona un puesto, contrato y horario activos.");
            }
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, nuevo ? "INSERT" : "UPDATE", "empleados", id,
                nuevo ? "Creación del expediente y condición laboral inicial." : "Actualización del expediente y datos bancarios.");
            await transaccion.CommitAsync();
            return id;
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            throw new InvalidOperationException("El código o DPI ya pertenece a otro empleado.");
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }

    public async Task<List<HistorialEmpleado>> HistorialAsync(uint empleado, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, null, autor);
        try
        {
            await using var comando = new MySqlCommand("""
                SELECT h.id_historial_laboral,h.fecha_inicio,h.fecha_fin,d.nombre,p.nombre,t.nombre,
                    o.nombre,h.salario_cifrado,h.motivo FROM historial_laboral h
                JOIN puestos p ON p.id_puesto=h.id_puesto JOIN departamentos d ON d.id_departamento=p.id_departamento
                JOIN tipos_contrato t ON t.id_tipo_contrato=h.id_tipo_contrato JOIN horarios o ON o.id_horario=h.id_horario
                WHERE h.id_empleado=@id ORDER BY h.fecha_inicio DESC;
                """, conexion);
            comando.Parameters.AddWithValue("@id", empleado);
            await using var lector = await comando.ExecuteReaderAsync();
            var historial = new List<HistorialEmpleado>();
            while (await lector.ReadAsync())
                historial.Add(new HistorialEmpleado
                {
                    IdHistorial = lector.GetUInt32(0),
                    Inicio = lector.GetDateTime(1),
                    Fin = lector.IsDBNull(2) ? null : lector.GetDateTime(2),
                    Departamento = lector.GetString(3),
                    Puesto = lector.GetString(4),
                    Contrato = lector.GetString(5),
                    Horario = lector.GetString(6),
                    Salario = CifradoDatos.DescifrarImporte((byte[])lector.GetValue(7), clave, Contexto(empleado, lector.GetDateTime(1))),
                    Motivo = lector.GetString(8)
                });
            return historial;
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }

    public async Task CambiarEstadoAsync(uint empleado, string estado, DateTime? baja, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "empleados");
        await using var comando = new MySqlCommand("""
            UPDATE empleados SET estado=@estado,fecha_baja=@baja
            WHERE id_empleado=@id AND (@baja IS NULL OR fecha_contratacion<=@baja);
            """, conexion, transaccion);
        comando.Parameters.AddWithValue("@id", empleado);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@baja", (object?)baja?.Date ?? DBNull.Value);
        if (await comando.ExecuteNonQueryAsync() != 1)
            throw new InvalidOperationException("Revisa el empleado y su fecha de baja.");
        await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, "UPDATE", "empleados", empleado, "Cambio de estado a " + estado + ".");
        await transaccion.CommitAsync();
    }

    public async Task EliminarAsync(uint empleado, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "empleados");
        try
        {
            await using var historial = new MySqlCommand("DELETE FROM historial_laboral WHERE id_empleado=@id;", conexion, transaccion);
            historial.Parameters.AddWithValue("@id", empleado);
            await historial.ExecuteNonQueryAsync();
            await using var borrar = new MySqlCommand("DELETE FROM empleados WHERE id_empleado=@id;", conexion, transaccion);
            borrar.Parameters.AddWithValue("@id", empleado);
            if (await borrar.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("El empleado ya no existe.");
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, "DELETE", "empleados", empleado, "Eliminación del expediente y su historial laboral.");
            await transaccion.CommitAsync();
        }
        catch (MySqlException ex) when (ex.Number == 1451)
        {
            throw new InvalidOperationException("El empleado tiene usuarios, asistencias, permisos o nóminas relacionados. Usa Cambiar estado para dejarlo inactivo.");
        }
    }

    private static string Contexto(uint id, DateTime fecha) =>
        "salario:" + id + ":" + fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
}
