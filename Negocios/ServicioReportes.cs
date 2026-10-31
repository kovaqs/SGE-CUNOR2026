using System.Data;
using Datos;
using Entidades;

namespace Negocios;

public class ServicioReportes
{
    public async Task<DataTable> ConsultarAsync(int tipo, DateTime desde, DateTime hasta, uint departamento, string estado, uint periodo, SesionUsuario autor)
    {
        if (desde.Date > hasta.Date)
            throw new ArgumentException("Revisa el intervalo de fechas.");
        if (tipo != 4)
            return await new RepositorioReportes().ConsultarAsync(tipo, desde, hasta, departamento, estado, autor);
        if (periodo == 0)
            throw new ArgumentException("Selecciona el período de nómina.");
        var pagos = await new RepositorioNomina().PagosAsync(periodo, departamento, "", 0, int.MaxValue - 1, autor);
        var tabla = new DataTable();
        tabla.Columns.Add("Código");
        tabla.Columns.Add("Empleado");
        tabla.Columns.Add("Departamento");
        tabla.Columns.Add("Puesto");
        tabla.Columns.Add("Ingresos", typeof(decimal));
        tabla.Columns.Add("Deducciones", typeof(decimal));
        tabla.Columns.Add("Neto", typeof(decimal));
        foreach (var pago in pagos)
            tabla.Rows.Add(pago.Codigo, pago.Empleado, pago.Departamento, pago.Puesto, pago.Ingresos, pago.Deducciones, pago.Neto);
        return tabla;
    }
}
