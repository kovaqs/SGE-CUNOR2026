using System.Data;
using ClosedXML.Excel;

namespace Presentacion.Reportes;

public static partial class ExportadorReportes
{
    public static void Excel(DataTable tabla, string archivo, string titulo = "Reporte", string filtros = "")
    {
        using var libro = new XLWorkbook();
        var hoja = libro.Worksheets.Add("Reporte");
        hoja.Cell(1, 1).Value = titulo;
        hoja.Range(1, 1, 1, tabla.Columns.Count).Merge().Style.Font.SetBold().Font.SetFontSize(16);
        hoja.Cell(2, 1).Value = "Generado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        hoja.Range(2, 1, 2, tabla.Columns.Count).Merge();
        hoja.Cell(3, 1).Value = filtros;
        hoja.Range(3, 1, 3, tabla.Columns.Count).Merge().Style.Alignment.WrapText = true;
        hoja.Row(1).Height = 26;
        hoja.Row(3).Height = 30;
        hoja.Cell(4, 1).Value = "Registros: " + tabla.Rows.Count;
        hoja.Cell(5, 1).InsertTable(tabla);
        hoja.SheetView.FreezeRows(5);
        foreach (DataColumn columna in tabla.Columns)
        {
            if (columna.DataType == typeof(DateTime))
                hoja.Column(columna.Ordinal + 1).Style.DateFormat.Format = "dd/MM/yyyy hh:mm";
            if (columna.DataType == typeof(decimal))
                hoja.Column(columna.Ordinal + 1).Style.NumberFormat.Format = "#,##0.00";
        }
        var resumen = ResumenNomina(tabla);
        if (resumen is not null)
        {
            int fila = tabla.Rows.Count + 8;
            hoja.Cell(fila, 1).Value = "Totales por departamento";
            hoja.Cell(fila, 1).Style.Font.Bold = true;
            hoja.Cell(fila + 1, 1).InsertTable(resumen);
            hoja.Range(fila + 2, 2, fila + 1 + resumen.Rows.Count, 4).Style.NumberFormat.Format = "#,##0.00";
            hoja.Row(fila + 1 + resumen.Rows.Count).Style.Font.Bold = true;
        }
        hoja.Columns().AdjustToContents(8, 45);
        libro.SaveAs(archivo);
    }

    private static DataTable? ResumenNomina(DataTable datos)
    {
        if (!datos.Columns.Contains("Departamento") || !datos.Columns.Contains("Ingresos")
            || !datos.Columns.Contains("Deducciones") || !datos.Columns.Contains("Neto"))
            return null;
        var resumen = new DataTable();
        resumen.Columns.Add("Departamento");
        string[] columnas = { "Ingresos", "Deducciones", "Neto" };
        foreach (string columna in columnas)
            resumen.Columns.Add(columna, typeof(decimal));
        var departamentos = new Dictionary<string, DataRow>();
        var totales = new decimal[3];
        foreach (DataRow registro in datos.Rows)
        {
            string departamento = Convert.ToString(registro["Departamento"]) ?? "Sin departamento";
            if (!departamentos.TryGetValue(departamento, out var fila))
            {
                fila = resumen.Rows.Add(departamento, 0m, 0m, 0m);
                departamentos.Add(departamento, fila);
            }
            for (int i = 0; i < columnas.Length; i++)
            {
                decimal importe = Convert.ToDecimal(registro[columnas[i]]);
                fila[columnas[i]] = (decimal)fila[columnas[i]] + importe;
                totales[i] += importe;
            }
        }
        resumen.Rows.Add("TOTAL GENERAL", totales[0], totales[1], totales[2]);
        return resumen;
    }
}
