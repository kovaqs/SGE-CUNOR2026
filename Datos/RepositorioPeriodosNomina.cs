using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioPeriodosNomina
{
    public async Task<List<PeriodoNominaListado>> ListarAsync(
        DateTime desde, DateTime hasta, string estado, int pagina, int tamano)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            SELECT p.id_periodo_nomina,p.nombre,p.fecha_inicio,p.fecha_fin,
                p.estado,u.nombre_usuario,p.fecha_cierre
            FROM periodos_nomina p
            JOIN usuarios u ON u.id_usuario=p.id_usuario_genera
            WHERE p.fecha_inicio<=@hasta AND p.fecha_fin>=@desde
                AND (@estado='' OR p.estado=@estado)
            ORDER BY p.fecha_inicio DESC,p.id_periodo_nomina DESC
            LIMIT @limite OFFSET @inicio;
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        comando.Parameters.AddWithValue("@desde", desde);
        comando.Parameters.AddWithValue("@hasta", hasta);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@limite", tamano + 1);
        comando.Parameters.AddWithValue("@inicio", pagina * tamano);
        await using var lector = await comando.ExecuteReaderAsync();
        var periodos = new List<PeriodoNominaListado>();
        while (await lector.ReadAsync())
        {
            periodos.Add(new PeriodoNominaListado
            {
                IdPeriodo = lector.GetUInt32(0),
                Nombre = lector.GetString(1),
                Desde = lector.GetDateTime(2),
                Hasta = lector.GetDateTime(3),
                Estado = lector.GetString(4),
                GeneradoPor = lector.GetString(5),
                FechaCierre = lector.IsDBNull(6) ? null : lector.GetDateTime(6).AddHours(-6)
            });
        }
        return periodos;
    }
}
