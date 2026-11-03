using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioRoles
{
    public async Task<List<RolAdministracion>> ListarAsync()
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        var roles = new List<RolAdministracion>();
        await using (var comando = new MySqlCommand("SELECT id_rol,nombre,descripcion,activo FROM roles ORDER BY nombre;", conexion))
        {
            await using var lector = await comando.ExecuteReaderAsync();
            while (await lector.ReadAsync())
                roles.Add(new RolAdministracion { IdRol = lector.GetUInt32(0), Nombre = lector.GetString(1), Descripcion = lector.IsDBNull(2) ? null : lector.GetString(2), Activo = lector.GetBoolean(3) });
        }
        await using var permisos = new MySqlCommand("SELECT id_rol,id_permiso_sistema FROM rol_permisos;", conexion);
        await using var filas = await permisos.ExecuteReaderAsync();
        while (await filas.ReadAsync())
            foreach (var rol in roles)
                if (rol.IdRol == filas.GetUInt32(0))
                    rol.Permisos.Add(filas.GetUInt32(1));
        return roles;
    }
    public async Task<List<PermisoSistema>> PermisosAsync(SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "configuracion");
        await using (var crear = new MySqlCommand("""
            INSERT IGNORE INTO permisos_sistema (codigo,nombre) VALUES
                ('empleados','Gestionar empleados y datos sensibles'),('catalogos','Gestionar departamentos, puestos y horarios'),
                ('asistencias','Gestionar asistencias y permisos'),('nomina','Gestionar nómina'),
                ('usuarios','Administrar usuarios'),('configuracion','Administrar configuración y roles'),('reportes','Consultar reportes');
            """, conexion, transaccion))
        {
            if (await crear.ExecuteNonQueryAsync() > 0)
                await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, "INSERT", "permisos_sistema", 0, "Preparación del catálogo de permisos por módulo.");
        }
        await transaccion.CommitAsync();
        await using var comando = new MySqlCommand("SELECT id_permiso_sistema,nombre FROM permisos_sistema WHERE activo=TRUE ORDER BY nombre;", conexion);
        await using var lector = await comando.ExecuteReaderAsync();
        var permisos = new List<PermisoSistema>();
        while (await lector.ReadAsync())
            permisos.Add(new PermisoSistema { Id = lector.GetUInt32(0), Nombre = lector.GetString(1) });
        return permisos;
    }
    public async Task GuardarAsync(RolAdministracion rol, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "configuracion");
        await using (var comprobar = new MySqlCommand("SELECT nombre FROM roles WHERE id_rol=@id FOR UPDATE;", conexion, transaccion))
        {
            comprobar.Parameters.AddWithValue("@id", rol.IdRol);
            var nombre = await comprobar.ExecuteScalarAsync();
            if (nombre is string actual && actual == "Administrador" && (rol.Nombre != "Administrador" || !rol.Activo))
                throw new InvalidOperationException("El rol Administrador debe conservar su nombre y permanecer activo.");
        }
        bool nuevo = rol.IdRol == 0;
        await using var guardar = new MySqlCommand(nuevo ? "INSERT INTO roles (nombre,descripcion,activo) VALUES (@nombre,@descripcion,@activo);"
            : "UPDATE roles SET nombre=@nombre,descripcion=@descripcion,activo=@activo WHERE id_rol=@id;", conexion, transaccion);
        guardar.Parameters.AddWithValue("@id", rol.IdRol);
        guardar.Parameters.AddWithValue("@nombre", rol.Nombre);
        guardar.Parameters.AddWithValue("@descripcion", (object?)rol.Descripcion ?? DBNull.Value);
        guardar.Parameters.AddWithValue("@activo", rol.Activo);
        try
        {
            if (await guardar.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("El rol ya no existe.");
            uint id = nuevo ? checked((uint)guardar.LastInsertedId) : rol.IdRol;
            await using var borrar = new MySqlCommand("DELETE FROM rol_permisos WHERE id_rol=@id;", conexion, transaccion);
            borrar.Parameters.AddWithValue("@id", id);
            await borrar.ExecuteNonQueryAsync();
            foreach (uint permiso in rol.Permisos)
            {
                await using var insertar = new MySqlCommand("INSERT INTO rol_permisos (id_rol,id_permiso_sistema) VALUES (@rol,@permiso);", conexion, transaccion);
                insertar.Parameters.AddWithValue("@rol", id);
                insertar.Parameters.AddWithValue("@permiso", permiso);
                await insertar.ExecuteNonQueryAsync();
            }
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, nuevo ? "INSERT" : "UPDATE", "roles", id, "Configuración del rol y sus permisos.");
            await transaccion.CommitAsync();
        }
        catch (MySqlException ex) when (ex.Number == 1062) { throw new InvalidOperationException("El nombre del rol ya existe."); }
    }
}
