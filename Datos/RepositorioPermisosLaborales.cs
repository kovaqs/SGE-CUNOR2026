using Entidades;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioPermisosLaborales
    {
        public async Task<List<PermisoLaboralListado>> ListarAsync(
        DateTime desde, DateTime hasta, string estado,
        string buscar, int pagina, int tamano)
        {
            await using var conexion = await ConexionMySql.AbrirAsync();
            const string sql = """
            SELECT p.id_permiso_laboral,
            CONCAT(e.codigo, ' - ', e.nombres, ' ', e.apellidos) AS empleado,
            p.fecha_inicio, p.fecha_fin, p.motivo, p.con_goce, p.estado
            FROM permisos_laborales p
            JOIN empleados e ON e.id_empleado = p.id_empleado
            WHERE p.fecha_inicio < @hasta AND p.fecha_fin >= @desde
            AND (@estado = '' OR p.estado = @estado)
            AND (@buscar = '' 
            OR e.codigo LIKE @texto 
            OR CONCAT(e.nombres, ' ', e.apellidos) LIKE @texto)
            ORDER BY p.fecha_inicio DESC, p.id_permiso_laboral DESC
            LIMIT @limite OFFSET @inicio;
            """;

            await using var comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@desde", desde);
            comando.Parameters.AddWithValue("@hasta", hasta);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@buscar", buscar);
            comando.Parameters.AddWithValue("@texto", "%" + buscar + "%");
            comando.Parameters.AddWithValue("@limite", tamano + 1);
            comando.Parameters.AddWithValue("@inicio", pagina * tamano);

            await using var lector = await comando.ExecuteReaderAsync();
            var registros = new List<PermisoLaboralListado>();

            while (await lector.ReadAsync())
            {
                registros.Add(new PermisoLaboralListado
                {
                    IdPermiso = lector.GetUInt32("id_permiso_laboral"),
                    Empleado = lector.GetString("empleado"),
                    Inicio = lector.GetDateTime("fecha_inicio").AddHours(-6),
                    Fin = lector.GetDateTime("fecha_fin").AddHours(-6),
                    Motivo = lector.GetString("motivo"),
                    ConGoce = lector.GetBoolean("con_goce"),
                    Estado = lector.GetString("estado")
                });
            }
            return registros;
        }
    }
}
