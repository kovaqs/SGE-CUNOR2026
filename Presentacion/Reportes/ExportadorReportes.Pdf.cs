using System.Data;
using Entidades;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace Presentacion.Reportes;

public static partial class ExportadorReportes
{
    private static Document CrearDocumento(string titulo)
    {
        var documento = new Document();
        documento.Info.Title = titulo;
        var normal = documento.Styles[StyleNames.Normal]!;
        normal.Font.Name = "Arial";
        normal.Font.Size = 10;
        normal.ParagraphFormat.SpaceAfter = 6;
        documento.Styles[StyleNames.Heading1]!.Font.Size = 18;
        documento.Styles[StyleNames.Heading1]!.Font.Color = new MigraDoc.DocumentObjectModel.Color(49, 81, 107);
        return documento;
    }
    private static void GuardarDocumento(Document documento, string archivo)
    {
        var renderizador = new PdfDocumentRenderer { Document = documento };
        renderizador.RenderDocument();
        renderizador.Save(archivo);
        renderizador.PdfDocument.Dispose();
    }
    public static void Pdf(DataTable datos, string titulo, string archivo)
    {
        var documento = CrearDocumento(titulo);
        var seccion = documento.AddSection();
        seccion.PageSetup.PageFormat = PageFormat.A4;
        seccion.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;
        seccion.PageSetup.LeftMargin = seccion.PageSetup.RightMargin = Unit.FromCentimeter(1.5);
        seccion.AddParagraph(titulo, StyleNames.Heading1);
        seccion.AddParagraph("Generado: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
        var tabla = seccion.AddTable();
        tabla.Borders.Width = 0.3;
        tabla.Format.Font.Size = 8;
        foreach (DataColumn columna in datos.Columns)
            tabla.AddColumn(Unit.FromCentimeter(26.7 / datos.Columns.Count));
        var encabezado = tabla.AddRow();
        encabezado.HeadingFormat = true;
        encabezado.Format.Font.Bold = true;
        encabezado.Shading.Color = new MigraDoc.DocumentObjectModel.Color(231, 238, 245);
        for (int i = 0; i < datos.Columns.Count; i++)
            encabezado.Cells[i].AddParagraph(datos.Columns[i].ColumnName);
        foreach (DataRow registro in datos.Rows)
        {
            var fila = tabla.AddRow();
            for (int i = 0; i < datos.Columns.Count; i++)
            {
                object valor = registro[i];
                string texto = valor is DateTime fecha ? fecha.ToString("dd/MM/yyyy HH:mm") : valor is decimal numero ? numero.ToString("N2") : Convert.ToString(valor) ?? "";
                fila.Cells[i].AddParagraph(texto);
            }
        }
        GuardarDocumento(documento, archivo);
    }
    public static void Boletas(Empresa empresa, List<PagoEmpleado> pagos, string archivo)
    {
        if (pagos.Count == 0)
            throw new ArgumentException("No hay boletas para generar.");
        var documento = CrearDocumento("Boletas de pago");
        foreach (var pago in pagos)
        {
            var seccion = documento.AddSection();
            seccion.PageSetup.PageFormat = PageFormat.A4;
            seccion.AddParagraph(string.IsNullOrWhiteSpace(empresa.Nombre) ? "Sistema de Gestión de Empleados" : empresa.Nombre, StyleNames.Heading1);
            seccion.AddParagraph("BOLETA DE PAGO").Format.Font.Bold = true;
            seccion.AddParagraph(pago.Periodo + " | Estado: " + pago.EstadoPeriodo);
            seccion.AddParagraph(pago.Codigo + " - " + pago.Empleado);
            seccion.AddParagraph("Departamento: " + pago.Departamento + " | Puesto: " + pago.Puesto);
            seccion.AddParagraph("Contrato: " + pago.Contrato + " | Días del período: " + pago.Dias.ToString("0.##"));
            var tabla = seccion.AddTable();
            tabla.Borders.Width = 0.4;
            tabla.AddColumn(Unit.FromCentimeter(3));
            tabla.AddColumn(Unit.FromCentimeter(8));
            tabla.AddColumn(Unit.FromCentimeter(3));
            var cabecera = tabla.AddRow();
            cabecera.HeadingFormat = true;
            cabecera.Format.Font.Bold = true;
            cabecera.Shading.Color = new MigraDoc.DocumentObjectModel.Color(231, 238, 245);
            cabecera.Cells[0].AddParagraph("Tipo");
            cabecera.Cells[1].AddParagraph("Concepto");
            cabecera.Cells[2].AddParagraph("Importe (Q)");
            var baseSueldo = tabla.AddRow();
            baseSueldo.Cells[0].AddParagraph("Ingreso");
            baseSueldo.Cells[1].AddParagraph("Sueldo mensual");
            baseSueldo.Cells[2].AddParagraph(pago.SalarioBase.ToString("N2"));
            foreach (var movimiento in pago.Movimientos)
            {
                var fila = tabla.AddRow();
                fila.Cells[0].AddParagraph(movimiento.Tipo == "Deduccion" ? "Deducción" : "Ingreso");
                fila.Cells[1].AddParagraph(movimiento.Concepto + " (" + movimiento.Cantidad.ToString("0.##") + " x " + movimiento.Importe.ToString("N2") + ")");
                fila.Cells[2].AddParagraph(movimiento.Total.ToString("N2"));
            }
            seccion.AddParagraph("Total de ingresos: Q " + pago.Ingresos.ToString("N2"));
            seccion.AddParagraph("Total de deducciones: Q " + pago.Deducciones.ToString("N2"));
            seccion.AddParagraph("Neto a recibir: Q " + pago.Neto.ToString("N2")).Format.Font.Bold = true;
            seccion.AddParagraph("Firma de recibido: __________________________");
        }
        GuardarDocumento(documento, archivo);
    }
    public static void Constancia(Empresa empresa, string texto, string firmante, string cargo, string archivo)
    {
        var documento = CrearDocumento("Constancia laboral");
        var seccion = documento.AddSection();
        seccion.PageSetup.PageFormat = PageFormat.A4;
        seccion.AddParagraph(empresa.Nombre, StyleNames.Heading1);
        seccion.AddParagraph("CONSTANCIA LABORAL").Format.Font.Bold = true;
        seccion.AddParagraph(texto).Format.Alignment = ParagraphAlignment.Justify;
        seccion.AddParagraph("\n\n________________________________");
        seccion.AddParagraph(firmante);
        seccion.AddParagraph(cargo);
        GuardarDocumento(documento, archivo);
    }
}
