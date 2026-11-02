using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioBitacora
{
    public async Task<List<RegistroBitacora>> ListarAsync(
        DateTime desde, DateTime hasta, string usuario,
        string operacion, string entidad)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            SELECT fecha_operacion, nombre_usuario, operacion,
            entidad, registro_afectado, descripcion
            FROM bitacora
            WHERE fecha_operacion >= @desde
            AND fecha_operacion < @hasta
            AND (@usuario = '' OR nombre_usuario LIKE @usuarioFiltro)
            AND (@operacion = '' OR operacion = @operacion)
            AND (@entidad = '' OR entidad = @entidad)
            ORDER BY fecha_operacion DESC, id_bitacora DESC;
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        comando.Parameters.AddWithValue("@desde", DateTime.SpecifyKind(desde, DateTimeKind.Utc));
        comando.Parameters.AddWithValue("@hasta", DateTime.SpecifyKind(hasta, DateTimeKind.Utc));
        comando.Parameters.AddWithValue("@usuario", usuario);
        comando.Parameters.AddWithValue("@usuarioFiltro", "%" + usuario + "%");
        comando.Parameters.AddWithValue("@operacion", operacion);
        comando.Parameters.AddWithValue("@entidad", entidad);
        await using var lector = await comando.ExecuteReaderAsync();
        var registros = new List<RegistroBitacora>();
        while (await lector.ReadAsync())
        {
            registros.Add(new RegistroBitacora
            {
                Fecha = lector.GetDateTime("fecha_operacion").AddHours(-6),
                Usuario = lector.IsDBNull(1) ? "" : lector.GetString(1),
                Operacion = lector.GetString("operacion"),
                Entidad = lector.GetString("entidad"),
                Registro = lector.IsDBNull(4) ? "" : lector.GetString(4),
                Descripcion = lector.GetString("descripcion")
            });
        }
        return registros;
    }
}
