using System.Drawing.Printing;
using Entidades;
using Negocios;
using Presentacion.Reportes;

namespace Presentacion.Forms.SubForms.Reportes;

public partial class FrmConstanciaLaboral : Form
{
    private SesionUsuario? sesion;
    private uint empleado;
    private string textoImpresion = "";
    private string tituloImpresion = "";
    public FrmConstanciaLaboral()
    {
        InitializeComponent();
        dlgGuardarConstancia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Load += Constancia_Load;
        btnCerrar.Click += Cerrar_Click;
        btnExportarPdf.Click += Pdf_Click;
        btnImprimir.Click += Imprimir_Click;
        docConstancia.PrintPage += Constancia_PrintPage;
    }
    public void Configurar(SesionUsuario sesion, uint empleado = 0)
    {
        this.sesion = sesion;
        this.empleado = empleado;
    }
    private async void Constancia_Load(object? sender, EventArgs e)
    {
        try
        {
            AyudaFormulario.CargarCombo(cboEmpleado, await new ServicioCatalogos().OpcionesAsync("empleados", 0, true));
            if (IsDisposed)
                return;
            if (empleado != 0)
                cboEmpleado.SelectedValue = empleado;
            dtpFechaEmision.Value = DateTime.Today;
            txtLugarEmision.Text = "Cobán, Alta Verapaz";
            txtFirmante.Text = sesion?.Nombre ?? "";
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async Task<Empresa> PrepararAsync()
    {
        if (sesion is null)
            throw new InvalidOperationException("Inicia sesión para emitir una constancia.");
        if (string.IsNullOrWhiteSpace(txtLugarEmision.Text) || string.IsNullOrWhiteSpace(txtFirmante.Text) || string.IsNullOrWhiteSpace(txtCargoFirmante.Text))
            throw new ArgumentException("Completa lugar de emisión, firmante y cargo.");
        var empresa = await new ServicioCatalogos().LeerEmpresaAsync();
        if (string.IsNullOrWhiteSpace(empresa.Nombre))
            throw new InvalidOperationException("Configura primero el nombre de la empresa.");
        uint id = AyudaFormulario.IdSeleccionado(cboEmpleado);
        var persona = await new ServicioEmpleados().BuscarAsync(id, sesion);
        var historial = await new ServicioEmpleados().HistorialAsync(id, sesion);
        HistorialEmpleado? condicion = null;
        foreach (var registro in historial)
            if (registro.Inicio.Date <= dtpFechaEmision.Value.Date && (registro.Fin is null || registro.Fin.Value.Date > dtpFechaEmision.Value.Date))
            {
                condicion = registro;
                break;
            }
        if (condicion is null)
            throw new InvalidOperationException("El empleado no tiene condición laboral vigente para la fecha de emisión.");
        tituloImpresion = empresa.Nombre;
        string situacion = persona.FechaBaja is not null && persona.FechaBaja.Value.Date <= dtpFechaEmision.Value.Date ? "laboró" : "labora";
        textoImpresion = "Por medio de la presente, " + empresa.Nombre + " hace constar que " + persona.Nombres + " " + persona.Apellidos +
            ", identificado(a) con DPI " + persona.Dpi + " y código " + persona.Codigo + ", " + situacion + " en esta entidad desde el " +
            persona.FechaContratacion.ToString("dd/MM/yyyy") + ", en el puesto de " + condicion.Puesto + ", departamento de " + condicion.Departamento + ".";
        if (chkIncluirSalario.Checked)
            textoImpresion += " Su salario mensual es de Q " + condicion.Salario.ToString("N2") + ".";
        textoImpresion += "\n\nSe extiende la presente a solicitud de la persona interesada en " + txtLugarEmision.Text.Trim() + ", el " + dtpFechaEmision.Value.ToString("dd/MM/yyyy") + ".";
        return empresa;
    }
    private async void Pdf_Click(object? sender, EventArgs e)
    {
        btnExportarPdf.Enabled = false;
        try
        {
            var empresa = await PrepararAsync();
            if (IsDisposed)
                return;
            dlgGuardarConstancia.Filter = "Documento PDF|*.pdf";
            dlgGuardarConstancia.FileName = "Constancia.pdf";
            if (dlgGuardarConstancia.ShowDialog(this) != DialogResult.OK)
                return;
            ExportadorReportes.Constancia(empresa, textoImpresion, txtFirmante.Text.Trim(), txtCargoFirmante.Text.Trim(), dlgGuardarConstancia.FileName);
            notificador.Show("Constancia", "Documento guardado.", KovaqsUI.Components.KToastKind.Success);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnExportarPdf.Enabled = true; }
    }
    private async void Imprimir_Click(object? sender, EventArgs e)
    {
        btnImprimir.Enabled = false;
        try
        {
            await PrepararAsync();
            if (IsDisposed)
                return;
            dlgImprimir.Document = docConstancia;
            if (dlgImprimir.ShowDialog(this) == DialogResult.OK)
                docConstancia.Print();
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnImprimir.Enabled = true; }
    }
    private void Constancia_PrintPage(object? sender, PrintPageEventArgs e)
    {
        if (e.Graphics is null)
            return;
        using var titulo = new Font("Arial", 18, FontStyle.Bold);
        using var normal = new Font("Arial", 11);
        e.Graphics.DrawString(tituloImpresion, titulo, Brushes.Black, new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, 60));
        e.Graphics.DrawString("CONSTANCIA LABORAL", normal, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top + 70);
        e.Graphics.DrawString(textoImpresion, normal, Brushes.Black, new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top + 110, e.MarginBounds.Width, e.MarginBounds.Height - 250));
        e.Graphics.DrawString("_______________________________\n" + txtFirmante.Text + "\n" + txtCargoFirmante.Text, normal, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom - 100);
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
