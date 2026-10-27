using System.Data;
using Entidades;
using MySqlConnector;

namespace Datos;

public sealed class RepositorioUsuarios
{
    public async Task<List<UsuarioListado>> ListarAsync(CancellationToken cancellationToken = default)
    {
        await using var conexion = await ConexionMySql.AbrirAsync(cancellationToken);
        await using var comando = new MySqlCommand("""
            SELECT u.id_usuario, u.nombre_usuario, CONCAT(e.nombres, ' ', e.apellidos) AS nombre_empleado,
                   r.nombre AS rol, u.activo, u.ultimo_acceso
            FROM usuarios u
            INNER JOIN roles r ON r.id_rol = u.id_rol
            LEFT JOIN empleados e ON e.id_empleado = u.id_empleado
            ORDER BY u.nombre_usuario, u.id_usuario;
            """, conexion);
        await using var lector = await comando.ExecuteReaderAsync(cancellationToken);
        var usuarios = new List<UsuarioListado>();
        var empleado = lector.GetOrdinal("nombre_empleado");
        var ultimoAcceso = lector.GetOrdinal("ultimo_acceso");
        while (await lector.ReadAsync(cancellationToken))
        {
            usuarios.Add(new UsuarioListado(
                lector.GetUInt32("id_usuario"), lector.GetString("nombre_usuario"),
                lector.IsDBNull(empleado) ? null : lector.GetString(empleado),
                lector.GetString("rol"), lector.GetBoolean("activo"),
                lector.IsDBNull(ultimoAcceso) ? null : lector.GetDateTime(ultimoAcceso)));
        }
        return usuarios;
    }

    public async Task<bool> HayUsuariosAsync(CancellationToken cancellationToken = default)
    {
        await using var conexion = await ConexionMySql.AbrirAsync(cancellationToken);
        await using var comando = new MySqlCommand("SELECT EXISTS(SELECT 1 FROM usuarios);", conexion);
        return Convert.ToBoolean(await comando.ExecuteScalarAsync(cancellationToken));
    }

    public async Task<List<Rol>> ListarRolesAsync(CancellationToken cancellationToken = default)
    {
        await using var conexion = await ConexionMySql.AbrirAsync(cancellationToken);
        await using var comando = new MySqlCommand("SELECT id_rol, nombre FROM roles WHERE activo = TRUE ORDER BY nombre;", conexion);
        await using var lector = await comando.ExecuteReaderAsync(cancellationToken);
        var roles = new List<Rol>();
        while (await lector.ReadAsync(cancellationToken))
            roles.Add(new Rol(lector.GetUInt32("id_rol"), lector.GetString("nombre")));
        return roles;
    }

    public async Task<List<EmpleadoSeleccion>> ListarEmpleadosDisponiblesAsync(CancellationToken cancellationToken = default)
    {
        await using var conexion = await ConexionMySql.AbrirAsync(cancellationToken);
        await using var comando = new MySqlCommand("""
            SELECT e.id_empleado, CONCAT(e.codigo, ' - ', e.nombres, ' ', e.apellidos) AS nombre
            FROM empleados e
            WHERE NOT EXISTS (SELECT 1 FROM usuarios u WHERE u.id_empleado = e.id_empleado)
            ORDER BY e.apellidos, e.nombres, e.id_empleado;
            """, conexion);
        await using var lector = await comando.ExecuteReaderAsync(cancellationToken);
        var empleados = new List<EmpleadoSeleccion>();
        while (await lector.ReadAsync(cancellationToken))
            empleados.Add(new EmpleadoSeleccion(lector.GetUInt32("id_empleado"), lector.GetString("nombre")));
        return empleados;
    }

    public async Task CrearAsync(string nombreUsuario, string hash, uint idRol, uint? idEmpleado, bool activo,
        SesionUsuario autor, CancellationToken cancellationToken = default)
    {
        await using var conexion = await ConexionMySql.AbrirAsync(cancellationToken);
        await using var transaccion = await conexion.BeginTransactionAsync(cancellationToken);
        try
        {
            await using var permiso = new MySqlCommand("""
                SELECT u.nombre_usuario FROM usuarios u
                INNER JOIN roles r ON r.id_rol = u.id_rol
                WHERE u.id_usuario = @autor AND u.activo = TRUE AND r.activo = TRUE
                  AND r.nombre = 'Administrador';
                """, conexion, transaccion);
            permiso.Parameters.Add("@autor", MySqlDbType.UInt32).Value = autor.IdUsuario;
            if (await permiso.ExecuteScalarAsync(cancellationToken) is not string nombreAutor)
                throw new InvalidOperationException("Solo un administrador activo puede crear usuarios.");

            await using var comando = new MySqlCommand("""
                INSERT INTO usuarios (id_rol, id_empleado, nombre_usuario, contrasena_hash, activo)
                SELECT id_rol, @empleado, @usuario, @hash, @activo
                FROM roles WHERE id_rol = @rol AND activo = TRUE;
                """, conexion, transaccion);
            comando.Parameters.Add("@rol", MySqlDbType.UInt32).Value = idRol;
            comando.Parameters.Add("@empleado", MySqlDbType.UInt32).Value = (object?)idEmpleado ?? DBNull.Value;
            comando.Parameters.Add("@usuario", MySqlDbType.VarChar, 50).Value = nombreUsuario;
            comando.Parameters.Add("@hash", MySqlDbType.VarChar, 255).Value = hash;
            comando.Parameters.Add("@activo", MySqlDbType.Bool).Value = activo;
            if (await comando.ExecuteNonQueryAsync(cancellationToken) != 1)
                throw new InvalidOperationException("Selecciona un rol activo.");

            var idUsuario = checked((uint)comando.LastInsertedId);
            await EscribirBitacoraAsync(conexion, transaccion, autor.IdUsuario, nombreAutor, "INSERT",
                "Creación de usuario.", cancellationToken, idUsuario);
            await transaccion.CommitAsync(cancellationToken);
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            throw new InvalidOperationException("El usuario o el empleado ya tiene una cuenta.");
        }
        catch (MySqlException ex) when (ex.Number == 1452)
        {
            throw new InvalidOperationException("El empleado o el rol ya no está disponible.");
        }
    }

    public async Task<CredencialUsuario?> BuscarAsync(string nombreUsuario, CancellationToken cancellationToken = default)
    {
        await using var conexion = await ConexionMySql.AbrirAsync(cancellationToken);
        await using var comando = new MySqlCommand("""
            SELECT u.id_usuario, u.nombre_usuario, u.contrasena_hash, u.activo, r.activo AS rol_activo,
                   r.nombre AS rol, COALESCE(CONCAT(e.nombres, ' ', e.apellidos), u.nombre_usuario) AS nombre
            FROM usuarios u
            INNER JOIN roles r ON r.id_rol = u.id_rol
            LEFT JOIN empleados e ON e.id_empleado = u.id_empleado
            WHERE u.nombre_usuario = @usuario LIMIT 1;
            """, conexion);
        comando.Parameters.Add("@usuario", MySqlDbType.VarChar, 50).Value = nombreUsuario;
        await using var lector = await comando.ExecuteReaderAsync(cancellationToken);
        if (!await lector.ReadAsync(cancellationToken))
            return null;
        return new CredencialUsuario(
            new SesionUsuario(lector.GetUInt32("id_usuario"), lector.GetString("nombre_usuario"),
                lector.GetString("nombre"), lector.GetString("rol")),
            lector.GetString("contrasena_hash"), lector.GetBoolean("activo") && lector.GetBoolean("rol_activo"));
    }

    public async Task CrearAdministradorAsync(string hash, CancellationToken cancellationToken = default)
    {
        await using var conexion = await ConexionMySql.AbrirAsync(cancellationToken);
        await using var transaccion = await conexion.BeginTransactionAsync(IsolationLevel.Serializable, cancellationToken);
        await using (var comprobar = new MySqlCommand("SELECT id_usuario FROM usuarios ORDER BY id_usuario LIMIT 1 FOR UPDATE;", conexion, transaccion))
        {
            if (await comprobar.ExecuteScalarAsync(cancellationToken) is not null)
                throw new InvalidOperationException("Ya existe un usuario. Inicia sesión con una cuenta existente.");
        }

        await using var rol = new MySqlCommand("""
            INSERT INTO roles (nombre, descripcion, activo) VALUES ('Administrador', 'Administración del sistema', TRUE)
            ON DUPLICATE KEY UPDATE id_rol = LAST_INSERT_ID(id_rol), activo = TRUE;
            """, conexion, transaccion);
        await rol.ExecuteNonQueryAsync(cancellationToken);
        var idRol = rol.LastInsertedId;
        await using var usuario = new MySqlCommand("""
            INSERT INTO usuarios (id_rol, nombre_usuario, contrasena_hash) VALUES (@rol, 'admin', @hash);
            """, conexion, transaccion);
        usuario.Parameters.Add("@rol", MySqlDbType.UInt32).Value = idRol;
        usuario.Parameters.Add("@hash", MySqlDbType.VarChar, 255).Value = hash;
        await usuario.ExecuteNonQueryAsync(cancellationToken);
        await EscribirBitacoraAsync(conexion, transaccion, (uint)usuario.LastInsertedId, "admin", "INSERT",
            "Creación del administrador inicial.", cancellationToken);
        await transaccion.CommitAsync(cancellationToken);
    }

    public async Task<bool> RegistrarAccesoAsync(SesionUsuario sesion, CancellationToken cancellationToken = default)
    {
        await using var conexion = await ConexionMySql.AbrirAsync(cancellationToken);
        await using var transaccion = await conexion.BeginTransactionAsync(cancellationToken);
        await using var comando = new MySqlCommand("""
            UPDATE usuarios u INNER JOIN roles r ON r.id_rol = u.id_rol
            SET u.ultimo_acceso = UTC_TIMESTAMP()
            WHERE u.id_usuario = @id AND u.activo = TRUE AND r.activo = TRUE;
            """, conexion, transaccion);
        comando.Parameters.Add("@id", MySqlDbType.UInt32).Value = sesion.IdUsuario;
        if (await comando.ExecuteNonQueryAsync(cancellationToken) != 1)
            return false;
        await EscribirBitacoraAsync(conexion, transaccion, sesion.IdUsuario, sesion.NombreUsuario,
            "LOGIN", "Inicio de sesión.", cancellationToken);
        await transaccion.CommitAsync(cancellationToken);
        return true;
    }

    public async Task RegistrarSalidaAsync(SesionUsuario sesion, CancellationToken cancellationToken = default)
    {
        await using var conexion = await ConexionMySql.AbrirAsync(cancellationToken);
        await EscribirBitacoraAsync(conexion, null, sesion.IdUsuario, sesion.NombreUsuario,
            "LOGOUT", "Cierre de sesión.", cancellationToken);
    }

    private static async Task EscribirBitacoraAsync(MySqlConnection conexion, MySqlTransaction? transaccion,
        uint id, string nombre, string operacion, string descripcion, CancellationToken cancellationToken,
        uint? idRegistro = null)
    {
        await using var comando = new MySqlCommand("""
            INSERT INTO bitacora (id_usuario, nombre_usuario, fecha_operacion, operacion, entidad, registro_afectado, descripcion)
            VALUES (@id, @nombre, UTC_TIMESTAMP(), @operacion, 'usuarios', @registro, @descripcion);
            """, conexion, transaccion);
        comando.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = nombre;
        comando.Parameters.Add("@operacion", MySqlDbType.VarChar, 20).Value = operacion;
        comando.Parameters.Add("@registro", MySqlDbType.VarChar, 150).Value = (idRegistro ?? id).ToString(System.Globalization.CultureInfo.InvariantCulture);
        comando.Parameters.Add("@descripcion", MySqlDbType.VarChar, 1000).Value = descripcion;
        await comando.ExecuteNonQueryAsync(cancellationToken);
    }
}

public sealed class CredencialUsuario(SesionUsuario sesion, string hash, bool activo)
{
    public SesionUsuario Sesion { get; } = sesion;
    public string Hash { get; } = hash;
    public bool Activo { get; } = activo;
}
