using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioPermisosTrabajo
{
    public async Task<PermisoTrabajo> BuscarAsync(string empleado, DateTime inicio)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var comando = new MySqlCommand("""
            SELECT p.id_permiso_laboral,p.id_empleado,CONCAT(e.codigo,' - ',e.nombres,' ',e.apellidos),
                p.fecha_inicio,p.fecha_fin,p.motivo,p.con_goce,p.estado,p.observaciones
            FROM permisos_laborales p JOIN empleados e ON e.id_empleado=p.id_empleado
            WHERE CONCAT(e.codigo,' - ',e.nombres,' ',e.apellidos)=@empleado AND p.fecha_inicio=@inicio;
            """, conexion);
        comando.Parameters.AddWithValue("@empleado", empleado);
        comando.Parameters.AddWithValue("@inicio", inicio.AddHours(6));
        await using var lector = await comando.ExecuteReaderAsync();
        if (!await lector.ReadAsync())
            throw new InvalidOperationException("El permiso ya no existe.");
        return new PermisoTrabajo
        {
            IdPermiso = lector.GetUInt32(0),
            IdEmpleado = lector.GetUInt32(1),
            Empleado = lector.GetString(2),
            Inicio = lector.GetDateTime(3).AddHours(-6),
            Fin = lector.GetDateTime(4).AddHours(-6),
            Motivo = lector.GetString(5),
            ConGoce = lector.GetBoolean(6),
            Estado = lector.GetString(7),
            Observaciones = lector.IsDBNull(8) ? null : lector.GetString(8)
        };
    }
    public async Task GuardarAsync(PermisoTrabajo permiso, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "asistencias");
        await using (var bloquear = new MySqlCommand("SELECT id_empleado FROM empleados WHERE id_empleado=@id FOR UPDATE;", conexion, transaccion))
        {
            bloquear.Parameters.AddWithValue("@id", permiso.IdEmpleado);
            if (await bloquear.ExecuteScalarAsync() is null)
                throw new InvalidOperationException("El empleado ya no existe.");
        }
        await using (var solapados = new MySqlCommand("""
            SELECT COUNT(*) FROM permisos_laborales WHERE id_empleado=@empleado AND id_permiso_laboral<>@id
                AND estado IN ('Pendiente','Aprobado') AND fecha_inicio<@fin AND fecha_fin>@inicio;
            """, conexion, transaccion))
        {
            solapados.Parameters.AddWithValue("@empleado", permiso.IdEmpleado);
            solapados.Parameters.AddWithValue("@id", permiso.IdPermiso);
            solapados.Parameters.AddWithValue("@inicio", permiso.Inicio.AddHours(6));
            solapados.Parameters.AddWithValue("@fin", permiso.Fin.AddHours(6));
            if (Convert.ToInt32(await solapados.ExecuteScalarAsync()) > 0)
                throw new InvalidOperationException("El empleado ya tiene un permiso pendiente o aprobado en ese intervalo.");
        }
        bool nuevo = permiso.IdPermiso == 0;
        await using var guardar = new MySqlCommand(nuevo ? """
            INSERT INTO permisos_laborales (id_empleado,fecha_inicio,fecha_fin,motivo,con_goce,id_usuario_registra)
            VALUES (@empleado,@inicio,@fin,@motivo,@goce,@autor);
            """ : """
            UPDATE permisos_laborales SET id_empleado=@empleado,fecha_inicio=@inicio,fecha_fin=@fin,motivo=@motivo,con_goce=@goce
            WHERE id_permiso_laboral=@id AND estado='Pendiente';
            """, conexion, transaccion);
        guardar.Parameters.AddWithValue("@id", permiso.IdPermiso);
        guardar.Parameters.AddWithValue("@empleado", permiso.IdEmpleado);
        guardar.Parameters.AddWithValue("@inicio", permiso.Inicio.AddHours(6));
        guardar.Parameters.AddWithValue("@fin", permiso.Fin.AddHours(6));
        guardar.Parameters.AddWithValue("@motivo", permiso.Motivo);
        guardar.Parameters.AddWithValue("@goce", permiso.ConGoce);
        guardar.Parameters.AddWithValue("@autor", autor.IdUsuario);
        if (await guardar.ExecuteNonQueryAsync() != 1)
            throw new InvalidOperationException("Solo se puede editar un permiso pendiente.");
        uint id = nuevo ? checked((uint)guardar.LastInsertedId) : permiso.IdPermiso;
        await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, nuevo ? "INSERT" : "UPDATE", "permisos_laborales", id, "Registro de solicitud de permiso.");
        await transaccion.CommitAsync();
    }
    public async Task ResolverAsync(uint id, string estado, string observaciones, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "asistencias");
        await using var comando = new MySqlCommand("""
            UPDATE permisos_laborales SET estado=@estado,id_usuario_resuelve=@autor,fecha_resolucion=UTC_TIMESTAMP(),observaciones=@observaciones
            WHERE id_permiso_laboral=@id AND (estado='Pendiente' OR (@estado='Cancelado' AND estado='Aprobado'));
            """, conexion, transaccion);
        comando.Parameters.AddWithValue("@id", id);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@autor", autor.IdUsuario);
        comando.Parameters.AddWithValue("@observaciones", observaciones);
        if (await comando.ExecuteNonQueryAsync() != 1)
            throw new InvalidOperationException("El permiso ya fue resuelto o cancelado.");
        await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, "UPDATE", "permisos_laborales", id, "Resolución del permiso: " + estado + ".");
        await transaccion.CommitAsync();
    }
}
