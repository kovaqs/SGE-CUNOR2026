using System.Globalization;
using System.Security.Cryptography;
using Datos.Seguridad;
using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioIndicadores
{
    public async Task<ResumenInicio> ConsultarAsync(DateTime mes, uint departamento, SesionUsuario autor)
    {
        var inicio = new DateTime(mes.Year, mes.Month, 1);
        var fin = inicio.AddMonths(1).AddDays(-1);
        var primerMes = inicio.AddMonths(-5);
        var resumen = new ResumenInicio();
        for (int i = 0; i < 6; i++)
            resumen.Meses[i] = primerMes.AddMonths(i).ToString("MMM yy", new CultureInfo("es-GT"));
        await using var conexion = await ConexionMySql.AbrirAsync();
        var clave = await SeguridadDatos.LeerClaveAsync(conexion, null, autor, "reportes");
        try
        {
            await using (var contar = new MySqlCommand("""
                SELECT COUNT(*) FROM empleados e LEFT JOIN historial_laboral h ON h.id_empleado=e.id_empleado
                    AND h.fecha_inicio<=@fin AND (h.fecha_fin IS NULL OR h.fecha_fin>@fin)
                LEFT JOIN puestos p ON p.id_puesto=h.id_puesto
                WHERE e.estado='Activo' AND e.fecha_contratacion<=@fin AND (@departamento=0 OR p.id_departamento=@departamento);
                """, conexion))
            {
                contar.Parameters.AddWithValue("@fin", fin);
                contar.Parameters.AddWithValue("@departamento", departamento);
                resumen.EmpleadosActivos = Convert.ToInt32(await contar.ExecuteScalarAsync());
            }
            await using (var salarios = new MySqlCommand("""
                SELECT e.id_empleado,d.nombre,h.salario_cifrado,h.fecha_inicio FROM empleados e
                JOIN historial_laboral h ON h.id_empleado=e.id_empleado AND h.fecha_inicio<=@fin AND (h.fecha_fin IS NULL OR h.fecha_fin>@fin)
                JOIN puestos p ON p.id_puesto=h.id_puesto JOIN departamentos d ON d.id_departamento=p.id_departamento
                WHERE e.estado='Activo' AND e.fecha_contratacion<=@fin AND (@departamento=0 OR d.id_departamento=@departamento)
                ORDER BY d.nombre,e.id_empleado;
                """, conexion))
            {
                salarios.Parameters.AddWithValue("@fin", fin);
                salarios.Parameters.AddWithValue("@departamento", departamento);
                await using var lector = await salarios.ExecuteReaderAsync();
                while (await lector.ReadAsync())
                {
                    string nombre = lector.GetString(1);
                    decimal importe = CifradoDatos.DescifrarImporte((byte[])lector.GetValue(2), clave, "salario:" + lector.GetUInt32(0) + ":" + lector.GetDateTime(3).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    SalarioDepartamento? grupo = null;
                    foreach (var salario in resumen.Salarios)
                        if (salario.Nombre == nombre)
                        {
                            grupo = salario;
                            break;
                        }
                    if (grupo is null)
                    {
                        grupo = new SalarioDepartamento { Nombre = nombre };
                        resumen.Salarios.Add(grupo);
                    }
                    grupo.Importe += importe;
                }
            }
            await using var incidencias = new MySqlCommand("""
                SELECT YEAR(a.fecha),MONTH(a.fecha),SUM(a.estado='Falta'),
                    SUM(CASE WHEN a.entrada IS NOT NULL AND a.entrada_prevista IS NOT NULL
                        AND TIMESTAMPDIFF(MINUTE,a.entrada_prevista,a.entrada)>a.tolerancia_minutos THEN 1 ELSE 0 END)
                FROM asistencias a JOIN empleados e ON e.id_empleado=a.id_empleado
                LEFT JOIN historial_laboral h ON h.id_empleado=e.id_empleado
                    AND h.fecha_inicio<=a.fecha AND (h.fecha_fin IS NULL OR h.fecha_fin>a.fecha)
                LEFT JOIN puestos p ON p.id_puesto=h.id_puesto
                WHERE a.fecha BETWEEN @desde AND @hasta AND (@departamento=0 OR p.id_departamento=@departamento)
                GROUP BY YEAR(a.fecha),MONTH(a.fecha) ORDER BY YEAR(a.fecha),MONTH(a.fecha);
                """, conexion);
            incidencias.Parameters.AddWithValue("@desde", primerMes);
            incidencias.Parameters.AddWithValue("@hasta", fin);
            incidencias.Parameters.AddWithValue("@departamento", departamento);
            await using var filas = await incidencias.ExecuteReaderAsync();
            while (await filas.ReadAsync())
            {
                int indice = (filas.GetInt32(0) - primerMes.Year) * 12 + filas.GetInt32(1) - primerMes.Month;
                if (indice >= 0 && indice < 6)
                {
                    resumen.Faltas[indice] = Convert.ToInt32(filas.GetValue(2));
                    resumen.Tardanzas[indice] = Convert.ToInt32(filas.GetValue(3));
                }
            }
            return resumen;
        }
        finally { CryptographicOperations.ZeroMemory(clave); }
    }
}
