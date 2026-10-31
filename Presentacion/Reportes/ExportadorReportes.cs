using System.Data;
using ClosedXML.Excel;

namespace Presentacion.Reportes;

public static partial class ExportadorReportes
{
    public static void Excel(DataTable tabla, string archivo)
    {
        using var libro = new XLWorkbook();
        var hoja = libro.Worksheets.Add(tabla, "Reporte");
        hoja.SheetView.FreezeRows(1);
        hoja.Columns().AdjustToContents(8, 45);
        foreach (DataColumn columna in tabla.Columns)
        {
            if (columna.DataType == typeof(DateTime))
                hoja.Column(columna.Ordinal + 1).Style.DateFormat.Format = "dd/MM/yyyy hh:mm";
            if (columna.DataType == typeof(decimal))
                hoja.Column(columna.Ordinal + 1).Style.NumberFormat.Format = "#,##0.00";
        }
        libro.SaveAs(archivo);
    }
}
