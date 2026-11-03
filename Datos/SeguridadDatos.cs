using Datos.Seguridad;
using Entidades;
using MySqlConnector;

namespace Datos;

internal static class SeguridadDatos
{

    public static async Task ValidarPermisoAsync(MySqlConnection conexion,
        MySqlTransaction? transaccion, SesionUsuario sesion, string permiso)
    {
        await using var comando = new MySqlCommand("""
            SELECT EXISTS(SELECT 1 FROM usuarios u JOIN roles r ON r.id_rol=u.id_rol
                WHERE u.id_usuario=@id AND u.activo=TRUE AND r.activo=TRUE
                AND (r.nombre='Administrador' OR EXISTS(SELECT 1 FROM rol_permisos rp
                    JOIN permisos_sistema p ON p.id_permiso_sistema=rp.id_permiso_sistema
                    WHERE rp.id_rol=r.id_rol AND p.codigo=@permiso AND p.activo=TRUE)));
            """, conexion, transaccion);
        comando.Parameters.AddWithValue("@id", sesion.IdUsuario);
        comando.Parameters.AddWithValue("@permiso", permiso);
        if (!Convert.ToBoolean(await comando.ExecuteScalarAsync()))
            throw new InvalidOperationException("Tu usuario no tiene permiso para realizar esta operación.");
    }

    public static async Task<byte[]> LeerClaveAsync(MySqlConnection conexion,
        MySqlTransaction? transaccion, SesionUsuario sesion, string permiso = "empleados")
    {
        await ValidarPermisoAsync(conexion, transaccion, sesion, permiso);
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
            FROM usuarios u JOIN roles r ON r.id_rol = u.id_rol
            WHERE u.id_usuario = @usuario AND u.activo = TRUE AND r.activo = TRUE;
            """, conexion, transaccion);
        comando.Parameters.Add("@usuario", MySqlDbType.UInt32).Value = sesion.IdUsuario;
        comando.Parameters.Add("@operacion", MySqlDbType.VarChar, 20).Value = operacion;
        comando.Parameters.Add("@entidad", MySqlDbType.VarChar, 64).Value = entidad;
        comando.Parameters.Add("@registro", MySqlDbType.VarChar, 150).Value = registro.ToString(System.Globalization.CultureInfo.InvariantCulture);
        comando.Parameters.Add("@descripcion", MySqlDbType.VarChar, 1000).Value = descripcion;
        if (await comando.ExecuteNonQueryAsync() != 1)
            throw new InvalidOperationException("No se pudo registrar la operación. Revisa que tu usuario siga activo.");
    }
}
