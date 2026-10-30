using Datos.Seguridad;
using Entidades;
using MySqlConnector;

namespace Datos;

internal static class SeguridadDatos
{
    public static async Task<byte[]> LeerClaveAsync(MySqlConnection conexion, MySqlTransaction? transaccion, SesionUsuario sesion)
    {
        await using var permiso = new MySqlCommand("""
            SELECT EXISTS(SELECT 1 FROM usuarios u JOIN roles r ON r.id_rol = u.id_rol
                WHERE u.id_usuario = @id AND u.activo = TRUE AND r.activo = TRUE AND r.nombre = 'Administrador');
            """, conexion, transaccion);
        permiso.Parameters.Add("@id", MySqlDbType.UInt32).Value = sesion.IdUsuario;
        if (!Convert.ToBoolean(await permiso.ExecuteScalarAsync()))
            throw new InvalidOperationException("El usuario no tiene permiso para consultar o modificar datos sensibles.");

        var configuracion = AlmacenConexionWindows.Leer()
            ?? throw new InvalidOperationException("Configura primero la conexión a MySQL.");
        try
        {
            return await Task.Run(() => CifradoDatos.DerivarClave(configuracion.Contrasena));
        }
        finally { configuracion.Contrasena = ""; }
    }

    public static async Task RegistrarOperacionAsync(MySqlConnection conexion, MySqlTransaction transaccion,
        SesionUsuario sesion, string operacion, string entidad, uint registro, string descripcion)
    {
        await using var comando = new MySqlCommand("""
            INSERT INTO bitacora (id_usuario, nombre_usuario, operacion, entidad, registro_afectado, descripcion)
            SELECT id_usuario, nombre_usuario, @operacion, @entidad, @registro, @descripcion
            FROM usuarios WHERE id_usuario = @usuario;
            """, conexion, transaccion);
        comando.Parameters.Add("@usuario", MySqlDbType.UInt32).Value = sesion.IdUsuario;
        comando.Parameters.Add("@operacion", MySqlDbType.VarChar, 20).Value = operacion;
        comando.Parameters.Add("@entidad", MySqlDbType.VarChar, 64).Value = entidad;
        comando.Parameters.Add("@registro", MySqlDbType.VarChar, 150).Value = registro.ToString(System.Globalization.CultureInfo.InvariantCulture);
        comando.Parameters.Add("@descripcion", MySqlDbType.VarChar, 1000).Value = descripcion;
        await comando.ExecuteNonQueryAsync();
    }
}
