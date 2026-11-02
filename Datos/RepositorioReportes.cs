using System.Data;
using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioReportes
{
    public async Task<DataTable> ConsultarAsync(int tipo, DateTime desde, DateTime hasta, uint departamento, string estado, SesionUsuario autor)
    {
        string sql = tipo switch
        {
            0 or 1 => """
                SELECT e.codigo AS Código,CONCAT(e.nombres,' ',e.apellidos) AS Empleado,
                    COALESCE(d.nombre,'') AS Departamento,COALESCE(p.nombre,'') AS Puesto,
                    COALESCE(t.nombre,'') AS Contrato,e.estado AS Estado
                FROM empleados e LEFT JOIN historial_laboral h ON h.id_empleado=e.id_empleado
                    AND h.fecha_inicio<=@hasta AND (h.fecha_fin IS NULL OR h.fecha_fin>@hasta)
                LEFT JOIN puestos p ON p.id_puesto=h.id_puesto LEFT JOIN departamentos d ON d.id_departamento=p.id_departamento
                LEFT JOIN tipos_contrato t ON t.id_tipo_contrato=h.id_tipo_contrato
                WHERE (@departamento=0 OR p.id_departamento=@departamento) AND (@estado='Todos' OR e.estado=@estado)
                    AND (@filtrar=FALSE OR e.fecha_contratacion BETWEEN @desde AND @hasta)
                ORDER BY e.apellidos,e.nombres,e.id_empleado;
                """,
            2 => """
                SELECT COALESCE(d.nombre,'Sin asignar') AS Departamento,e.estado AS Estado,COUNT(*) AS Empleados
                FROM empleados e LEFT JOIN historial_laboral h ON h.id_empleado=e.id_empleado
                    AND h.fecha_inicio<=@hasta AND (h.fecha_fin IS NULL OR h.fecha_fin>@hasta)
                LEFT JOIN puestos p ON p.id_puesto=h.id_puesto LEFT JOIN departamentos d ON d.id_departamento=p.id_departamento
                WHERE e.fecha_contratacion<=@hasta AND (@departamento=0 OR p.id_departamento=@departamento)
                    AND (@estado='Todos' OR e.estado=@estado)
                GROUP BY d.id_departamento,d.nombre,e.estado ORDER BY Empleados DESC,Departamento,Estado;
                """,
            3 => """
                SELECT a.fecha AS Fecha,CONCAT(e.codigo,' - ',e.nombres,' ',e.apellidos) AS Empleado,
                    COALESCE(d.nombre,'') AS Departamento,DATE_SUB(a.entrada,INTERVAL 6 HOUR) AS Entrada,
                    DATE_SUB(a.salida,INTERVAL 6 HOUR) AS Salida,a.estado AS Estado,
                    GREATEST(0,COALESCE(TIMESTAMPDIFF(MINUTE,a.entrada_prevista,a.entrada),0)-CAST(a.tolerancia_minutos AS SIGNED)) AS Tardanza
                FROM asistencias a JOIN empleados e ON e.id_empleado=a.id_empleado
                LEFT JOIN historial_laboral h ON h.id_empleado=e.id_empleado
                    AND h.fecha_inicio<=a.fecha AND (h.fecha_fin IS NULL OR h.fecha_fin>a.fecha)
                LEFT JOIN puestos p ON p.id_puesto=h.id_puesto LEFT JOIN departamentos d ON d.id_departamento=p.id_departamento
                WHERE a.fecha BETWEEN @desde AND @hasta AND (@departamento=0 OR p.id_departamento=@departamento)
                    AND (@estado='Todos' OR e.estado=@estado)
                ORDER BY a.fecha,e.apellidos,e.nombres,a.id_asistencia;
                """,
            _ => throw new ArgumentException("Selecciona un tipo de reporte.")
        };
        await using var conexion = await ConexionMySql.AbrirAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, null, autor, "reportes");
        await using var comando = new MySqlCommand(sql, conexion);
        comando.Parameters.AddWithValue("@desde", DateOnly.FromDateTime(desde));
        comando.Parameters.AddWithValue("@hasta", DateOnly.FromDateTime(hasta));
        comando.Parameters.AddWithValue("@departamento", departamento);
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@filtrar", tipo == 1);
        await using var lector = await comando.ExecuteReaderAsync();
        var tabla = new DataTable();
        for (int i = 0; i < lector.FieldCount; i++)
            tabla.Columns.Add(lector.GetName(i), lector.GetFieldType(i));
        while (await lector.ReadAsync())
        {
            var valores = new object[lector.FieldCount];
            lector.GetValues(valores);
            tabla.Rows.Add(valores);
        }
        return tabla;
    }
}
