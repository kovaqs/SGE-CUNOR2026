using System.Security.Cryptography;
using System.Globalization;
using Datos.Seguridad;
using Entidades;
using MySqlConnector;

namespace Datos;

public sealed class RepositorioDatosSensibles
{
    public async Task<DatosBancarios> LeerCuentaAsync(uint empleado, SesionUsuario sesion)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, null, sesion);
        try
        {
            await using var comando = new MySqlCommand("SELECT banco, cuenta_bancaria_cifrada FROM empleados WHERE id_empleado = @id;", conexion);
            comando.Parameters.Add("@id", MySqlDbType.UInt32).Value = empleado;
            await using var lector = await comando.ExecuteReaderAsync();
            if (!await lector.ReadAsync())
                throw new InvalidOperationException("El empleado ya no existe.");
            return new DatosBancarios
            {
                Banco = lector.IsDBNull(0) ? null : lector.GetString(0),
                Cuenta = lector.IsDBNull(1) ? null : CifradoDatos.Descifrar((byte[])lector.GetValue(1), clave, $"cuenta:{empleado}")
            };
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }

    public async Task GuardarCuentaAsync(uint empleado, DatosBancarios datos, SesionUsuario sesion)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, transaccion, sesion);
        try
        {
            await using var comando = new MySqlCommand("""
                UPDATE empleados SET banco = @banco, cuenta_bancaria_cifrada = @cuenta WHERE id_empleado = @id;
                """, conexion, transaccion);
            comando.Parameters.Add("@id", MySqlDbType.UInt32).Value = empleado;
            comando.Parameters.Add("@banco", MySqlDbType.VarChar, 100).Value = (object?)datos.Banco ?? DBNull.Value;
            comando.Parameters.Add("@cuenta", MySqlDbType.VarBinary, 512).Value = datos.Cuenta is null
                ? DBNull.Value : CifradoDatos.Cifrar(datos.Cuenta, clave, $"cuenta:{empleado}");
            if (await comando.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("El empleado ya no existe.");
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, sesion, "UPDATE", "empleados", empleado, "Actualización de datos bancarios.");
            await transaccion.CommitAsync();
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }

    public async Task<decimal> LeerSalarioAsync(uint historial, SesionUsuario sesion)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, null, sesion);
        try
        {
            await using var comando = new MySqlCommand("SELECT id_empleado, fecha_inicio, salario_cifrado FROM historial_laboral WHERE id_historial_laboral = @id;", conexion);
            comando.Parameters.Add("@id", MySqlDbType.UInt32).Value = historial;
            await using var lector = await comando.ExecuteReaderAsync();
            if (!await lector.ReadAsync())
                throw new InvalidOperationException("La condición laboral ya no existe.");
            var contexto = ContextoSalario(lector.GetUInt32(0), lector.GetDateTime(1));
            return CifradoDatos.DescifrarImporte((byte[])lector.GetValue(2), clave, contexto);
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }

    public async Task<uint> RegistrarCondicionAsync(CondicionLaboral condicion, SesionUsuario sesion)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, transaccion, sesion);
        try
        {
            await using (var empleado = new MySqlCommand("SELECT fecha_contratacion, estado FROM empleados WHERE id_empleado = @id FOR UPDATE;", conexion, transaccion))
            {
                empleado.Parameters.Add("@id", MySqlDbType.UInt32).Value = condicion.IdEmpleado;
                await using var lector = await empleado.ExecuteReaderAsync();
                if (!await lector.ReadAsync() || condicion.FechaInicio.Date < lector.GetDateTime(0).Date || lector.GetString(1) == "Inactivo")
                    throw new InvalidOperationException("Revisa el empleado y la fecha de inicio de la condición laboral.");
            }
            await using (var fechas = new MySqlCommand("""
                SELECT COUNT(*) FROM historial_laboral WHERE id_empleado = @empleado
                    AND (fecha_inicio >= @inicio OR (fecha_fin IS NOT NULL AND fecha_fin > @inicio));
                """, conexion, transaccion))
            {
                fechas.Parameters.Add("@empleado", MySqlDbType.UInt32).Value = condicion.IdEmpleado;
                fechas.Parameters.Add("@inicio", MySqlDbType.Date).Value = condicion.FechaInicio.Date;
                if (Convert.ToInt32(await fechas.ExecuteScalarAsync()) > 0)
                    throw new InvalidOperationException("La nueva condición debe comenzar después de las condiciones ya registradas.");
            }
            await using (var cerrar = new MySqlCommand("""
                UPDATE historial_laboral SET fecha_fin = @inicio WHERE id_empleado = @empleado AND fecha_fin IS NULL;
                """, conexion, transaccion))
            {
                cerrar.Parameters.Add("@empleado", MySqlDbType.UInt32).Value = condicion.IdEmpleado;
                cerrar.Parameters.Add("@inicio", MySqlDbType.Date).Value = condicion.FechaInicio.Date;
                await cerrar.ExecuteNonQueryAsync();
            }
            await using var guardar = new MySqlCommand("""
                INSERT INTO historial_laboral (id_empleado, id_puesto, id_tipo_contrato, id_horario,
                    fecha_inicio, salario_cifrado, motivo, id_usuario_autoriza)
                SELECT @empleado, p.id_puesto, t.id_tipo_contrato, h.id_horario, @inicio, @salario, @motivo, @autor
                FROM puestos p JOIN departamentos d ON d.id_departamento = p.id_departamento
                    JOIN tipos_contrato t ON t.id_tipo_contrato = @contrato JOIN horarios h ON h.id_horario = @horario
                WHERE p.id_puesto = @puesto AND p.activo = TRUE AND d.activo = TRUE AND t.activo = TRUE AND h.activo = TRUE;
                """, conexion, transaccion);
            guardar.Parameters.Add("@empleado", MySqlDbType.UInt32).Value = condicion.IdEmpleado;
            guardar.Parameters.Add("@puesto", MySqlDbType.UInt32).Value = condicion.IdPuesto;
            guardar.Parameters.Add("@contrato", MySqlDbType.UInt32).Value = condicion.IdTipoContrato;
            guardar.Parameters.Add("@horario", MySqlDbType.UInt32).Value = condicion.IdHorario;
            guardar.Parameters.Add("@inicio", MySqlDbType.Date).Value = condicion.FechaInicio.Date;
            guardar.Parameters.Add("@salario", MySqlDbType.VarBinary, 256).Value = CifradoDatos.CifrarImporte(condicion.Salario, clave,
                ContextoSalario(condicion.IdEmpleado, condicion.FechaInicio));
            guardar.Parameters.Add("@motivo", MySqlDbType.VarChar, 500).Value = condicion.Motivo;
            guardar.Parameters.Add("@autor", MySqlDbType.UInt32).Value = sesion.IdUsuario;
            if (await guardar.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("Selecciona un puesto, contrato y horario activos.");
            var id = checked((uint)guardar.LastInsertedId);
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, sesion, "AUTORIZACION", "historial_laboral", id, $"Cambio de condición laboral del empleado {condicion.IdEmpleado}.");
            await transaccion.CommitAsync();
            return id;
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }

    private static string ContextoSalario(uint empleado, DateTime fecha) =>
        $"salario:{empleado}:{fecha.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}";
}
