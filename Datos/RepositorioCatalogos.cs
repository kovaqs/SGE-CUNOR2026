using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioCatalogos
{
    public async Task<List<OpcionCatalogo>> OpcionesAsync(string catalogo, uint departamento = 0, bool incluirInactivos = false)
    {
        string sql = catalogo switch
        {
            "departamentos" => "SELECT id_departamento, nombre FROM departamentos WHERE activo = TRUE OR @inactivos=TRUE ORDER BY nombre;",
            "puestos" => "SELECT p.id_puesto, p.nombre FROM puestos p JOIN departamentos d ON d.id_departamento=p.id_departamento WHERE ((p.activo=TRUE AND d.activo=TRUE) OR @inactivos=TRUE) AND (@departamento=0 OR p.id_departamento=@departamento) ORDER BY p.nombre;",
            "contratos" => "SELECT id_tipo_contrato, nombre FROM tipos_contrato WHERE activo=TRUE OR @inactivos=TRUE ORDER BY nombre;",
            "horarios" => "SELECT id_horario, nombre FROM horarios WHERE activo=TRUE OR @inactivos=TRUE ORDER BY nombre;",
            "empleados" => "SELECT id_empleado, CONCAT(codigo,' - ',nombres,' ',apellidos) FROM empleados WHERE estado <> 'Inactivo' OR @inactivos=TRUE ORDER BY apellidos,nombres;",
            "periodos" => "SELECT id_periodo_nomina, nombre FROM periodos_nomina ORDER BY fecha_inicio DESC;",
            _ => throw new ArgumentException("El catálogo no está disponible.")
        };
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var comando = new MySqlCommand(sql, conexion);
        if (catalogo == "puestos")
            comando.Parameters.AddWithValue("@departamento", departamento);
        if (catalogo is "departamentos" or "puestos" or "contratos" or "horarios" or "empleados")
            comando.Parameters.AddWithValue("@inactivos", incluirInactivos);
        await using var lector = await comando.ExecuteReaderAsync();
        var opciones = new List<OpcionCatalogo>();
        while (await lector.ReadAsync())
            opciones.Add(new OpcionCatalogo { Id = lector.GetUInt32(0), Nombre = lector.GetString(1) });
        return opciones;
    }

    public async Task<List<Puesto>> ListarPuestosAsync(string buscar, uint departamento,
        string estado, int pagina, int tamano)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var comando = new MySqlCommand("""
            SELECT p.id_puesto,p.id_departamento,d.nombre AS departamento,p.nombre,p.descripcion,p.activo
            FROM puestos p JOIN departamentos d ON d.id_departamento=p.id_departamento
            WHERE p.nombre LIKE @buscar AND (@departamento=0 OR p.id_departamento=@departamento)
                AND (@estado='Todos' OR p.activo=(@estado='Activos'))
            ORDER BY p.nombre,p.id_puesto LIMIT @limite OFFSET @inicio;
            """, conexion);
        comando.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
        comando.Parameters.AddWithValue("@departamento", departamento);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@limite", tamano + 1);
        comando.Parameters.AddWithValue("@inicio", pagina * tamano);
        await using var lector = await comando.ExecuteReaderAsync();
        var puestos = new List<Puesto>();
        while (await lector.ReadAsync())
            puestos.Add(new Puesto
            {
                IdPuesto = lector.GetUInt32(0),
                IdDepartamento = lector.GetUInt32(1),
                Departamento = lector.GetString(2),
                Nombre = lector.GetString(3),
                Descripcion = lector.IsDBNull(4) ? null : lector.GetString(4),
                Activo = lector.GetBoolean(5)
            });
        return puestos;
    }

    public async Task GuardarPuestoAsync(Puesto puesto, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "catalogos");
        await using (var validar = new MySqlCommand("SELECT activo FROM departamentos WHERE id_departamento=@id FOR UPDATE;", conexion, transaccion))
        {
            validar.Parameters.AddWithValue("@id", puesto.IdDepartamento);
            var activo = await validar.ExecuteScalarAsync();
            if (activo is null || (puesto.Activo && !Convert.ToBoolean(activo)))
                throw new InvalidOperationException("Selecciona un departamento activo.");
        }
        bool nuevo = puesto.IdPuesto == 0;
        await using var comando = new MySqlCommand(nuevo
            ? "INSERT INTO puestos (id_departamento,nombre,descripcion,activo) VALUES (@departamento,@nombre,@descripcion,@activo);"
            : "UPDATE puestos SET id_departamento=@departamento,nombre=@nombre,descripcion=@descripcion,activo=@activo WHERE id_puesto=@id AND (id_departamento=@departamento OR NOT EXISTS(SELECT 1 FROM historial_laboral WHERE id_puesto=@id));", conexion, transaccion);
        comando.Parameters.AddWithValue("@id", puesto.IdPuesto);
        comando.Parameters.AddWithValue("@departamento", puesto.IdDepartamento);
        comando.Parameters.AddWithValue("@nombre", puesto.Nombre);
        comando.Parameters.AddWithValue("@descripcion", (object?)puesto.Descripcion ?? DBNull.Value);
        comando.Parameters.AddWithValue("@activo", puesto.Activo);
        try
        {
            if (await comando.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("El puesto ya no existe o tiene historial laboral y no se puede cambiar de departamento.");
            uint id = nuevo ? checked((uint)comando.LastInsertedId) : puesto.IdPuesto;
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, nuevo ? "INSERT" : "UPDATE", "puestos", id, "Registro de puesto de trabajo.");
            await transaccion.CommitAsync();
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            throw new InvalidOperationException("Ya existe ese puesto en el departamento.");
        }
        catch (MySqlException ex) when (ex.Number == 1451)
        {
            throw new InvalidOperationException("El puesto tiene nóminas relacionadas y debe conservar su departamento.");
        }
    }

    public async Task EliminarAsync(string catalogo, uint id, SesionUsuario autor)
    {
        string sql = catalogo switch
        {
            "puestos" => "DELETE FROM puestos WHERE id_puesto=@id;",
            "departamentos" => "DELETE FROM departamentos WHERE id_departamento=@id;",
            "horarios" => "DELETE FROM horarios WHERE id_horario=@id;",
            "tipos_contrato" => "DELETE FROM tipos_contrato WHERE id_tipo_contrato=@id;",
            _ => throw new ArgumentException("El catálogo no se puede eliminar.")
        };
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "catalogos");
        try
        {
            if (catalogo == "horarios")
            {
                await using var dias = new MySqlCommand("DELETE FROM horario_dias WHERE id_horario=@id;", conexion, transaccion);
                dias.Parameters.AddWithValue("@id", id);
                await dias.ExecuteNonQueryAsync();
            }
            await using var comando = new MySqlCommand(sql, conexion, transaccion);
            comando.Parameters.AddWithValue("@id", id);
            if (await comando.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("El registro ya no existe.");
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, "DELETE", catalogo, id, "Eliminación de registro del catálogo.");
            await transaccion.CommitAsync();
        }
        catch (MySqlException ex) when (ex.Number == 1451)
        {
            throw new InvalidOperationException("Tiene información relacionada. Puedes dejarlo inactivo en lugar de eliminarlo.");
        }
    }

    public async Task<HorarioTrabajo> LeerHorarioAsync(uint id)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var horario = new HorarioTrabajo { IdHorario = id };
        await using (var comando = new MySqlCommand("SELECT nombre,activo FROM horarios WHERE id_horario=@id;", conexion))
        {
            comando.Parameters.AddWithValue("@id", id);
            await using var lector = await comando.ExecuteReaderAsync();
            if (!await lector.ReadAsync())
                throw new InvalidOperationException("El horario ya no existe.");
            horario.Nombre = lector.GetString(0);
            horario.Activo = lector.GetBoolean(1);
        }
        await using var dias = new MySqlCommand("SELECT dia_semana,hora_entrada,hora_salida,salida_dia_siguiente,tolerancia_minutos FROM horario_dias WHERE id_horario=@id ORDER BY dia_semana;", conexion);
        dias.Parameters.AddWithValue("@id", id);
        await using var filas = await dias.ExecuteReaderAsync();
        while (await filas.ReadAsync())
            horario.Dias.Add(new DiaHorario
            {
                DiaSemana = filas.GetInt32(0),
                Entrada = filas.GetTimeSpan(1),
                Salida = filas.GetTimeSpan(2),
                DiaSiguiente = filas.GetBoolean(3),
                Tolerancia = filas.GetInt32(4)
            });
        return horario;
    }

    public async Task GuardarHorarioAsync(HorarioTrabajo horario, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "catalogos");
        bool nuevo = horario.IdHorario == 0;
        await using var guardar = new MySqlCommand(nuevo
            ? "INSERT INTO horarios (nombre,activo) VALUES (@nombre,@activo);"
            : "UPDATE horarios SET nombre=@nombre,activo=@activo WHERE id_horario=@id;", conexion, transaccion);
        guardar.Parameters.AddWithValue("@id", horario.IdHorario);
        guardar.Parameters.AddWithValue("@nombre", horario.Nombre);
        guardar.Parameters.AddWithValue("@activo", horario.Activo);
        try
        {
            if (await guardar.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("El horario ya no existe.");
            uint id = nuevo ? checked((uint)guardar.LastInsertedId) : horario.IdHorario;
            await using var borrar = new MySqlCommand("DELETE FROM horario_dias WHERE id_horario=@id;", conexion, transaccion);
            borrar.Parameters.AddWithValue("@id", id);
            await borrar.ExecuteNonQueryAsync();
            foreach (var dia in horario.Dias)
            {
                await using var insertar = new MySqlCommand("""
                    INSERT INTO horario_dias (id_horario,dia_semana,hora_entrada,hora_salida,salida_dia_siguiente,tolerancia_minutos)
                    VALUES (@horario,@dia,@entrada,@salida,@siguiente,@tolerancia);
                    """, conexion, transaccion);
                insertar.Parameters.AddWithValue("@horario", id);
                insertar.Parameters.AddWithValue("@dia", dia.DiaSemana);
                insertar.Parameters.AddWithValue("@entrada", dia.Entrada);
                insertar.Parameters.AddWithValue("@salida", dia.Salida);
                insertar.Parameters.AddWithValue("@siguiente", dia.DiaSiguiente);
                insertar.Parameters.AddWithValue("@tolerancia", dia.Tolerancia);
                await insertar.ExecuteNonQueryAsync();
            }
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, nuevo ? "INSERT" : "UPDATE", "horarios", id, "Configuración del horario semanal.");
            await transaccion.CommitAsync();
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            throw new InvalidOperationException("El nombre del horario ya existe o hay un día repetido.");
        }
    }

    public async Task<Empresa> LeerEmpresaAsync()
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var comando = new MySqlCommand("SELECT nombre_empresa,nit,direccion,telefono,correo,moneda,zona_horaria FROM configuracion_sistema WHERE id_configuracion=1;", conexion);
        await using var lector = await comando.ExecuteReaderAsync();
        if (!await lector.ReadAsync())
            return new Empresa();
        return new Empresa
        {
            Nombre = lector.GetString(0),
            Nit = lector.IsDBNull(1) ? null : lector.GetString(1),
            Direccion = lector.IsDBNull(2) ? null : lector.GetString(2),
            Telefono = lector.IsDBNull(3) ? null : lector.GetString(3),
            Correo = lector.IsDBNull(4) ? null : lector.GetString(4),
            Moneda = lector.GetString(5),
            ZonaHoraria = lector.GetString(6)
        };
    }

    public async Task GuardarEmpresaAsync(Empresa empresa, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "configuracion");
        await using var comando = new MySqlCommand("""
            INSERT INTO configuracion_sistema (id_configuracion,nombre_empresa,nit,direccion,telefono,correo,moneda,zona_horaria)
            VALUES (1,@nombre,@nit,@direccion,@telefono,@correo,'GTQ','America/Guatemala')
            ON DUPLICATE KEY UPDATE nombre_empresa=@nombre,nit=@nit,direccion=@direccion,telefono=@telefono,correo=@correo;
            """, conexion, transaccion);
        comando.Parameters.AddWithValue("@nombre", empresa.Nombre);
        comando.Parameters.AddWithValue("@nit", (object?)empresa.Nit ?? DBNull.Value);
        comando.Parameters.AddWithValue("@direccion", (object?)empresa.Direccion ?? DBNull.Value);
        comando.Parameters.AddWithValue("@telefono", (object?)empresa.Telefono ?? DBNull.Value);
        comando.Parameters.AddWithValue("@correo", (object?)empresa.Correo ?? DBNull.Value);
        await comando.ExecuteNonQueryAsync();
        await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, "UPDATE", "configuracion_sistema", 1, "Actualización de los datos de la empresa.");
        await transaccion.CommitAsync();
    }
}
