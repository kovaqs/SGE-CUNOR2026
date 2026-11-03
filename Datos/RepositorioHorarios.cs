using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioHorarios
{
    public async Task<List<Horariolistado>> ListarAsync()
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            SELECT id_horario, nombre, descripcion, activo
            FROM horarios ORDER BY nombre;
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        await using var lector = await comando.ExecuteReaderAsync();
        var horarios = new List<Horariolistado>();
        while (await lector.ReadAsync())
        {
            horarios.Add(new Horariolistado
            {
                IdHorario = lector.GetUInt32("id_horario"),
                Nombre = lector.GetString("nombre"),
                Descripcion = lector.IsDBNull(2) ? "" : lector.GetString(2),
                Activo = lector.GetBoolean("activo")
            });
        }
        return horarios;
    }
}
