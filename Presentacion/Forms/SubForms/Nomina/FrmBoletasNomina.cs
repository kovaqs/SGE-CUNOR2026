using Entidades;
using Negocios;
using Presentacion.Reportes;

namespace Presentacion.Forms.SubForms.Nomina;

public partial class FrmBoletasNomina : Form
{
    private SesionUsuario? sesion;
    public FrmBoletasNomina()
    {
        InitializeComponent();
        dlgGuardarPdf.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Load += Boletas_Load;
        btnCerrar.Click += Cerrar_Click;
        btnSeleccionarDestino.Click += Destino_Click;
        btnGenerarPdf.Click += Generar_Click;
    }
    public void Configurar(SesionUsuario sesion)
    {
        this.sesion = sesion;
    }
    private async void Boletas_Load(object? sender, EventArgs e)
    {
        try
        {
            var catalogos = new ServicioCatalogos();
            AyudaFormulario.CargarCombo(cboPeriodo, await catalogos.OpcionesAsync("periodos"));
            AyudaFormulario.CargarCombo(cboDepartamento, await catalogos.OpcionesAsync("departamentos", 0, true), "Todos");
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private void Destino_Click(object? sender, EventArgs e)
    {
        dlgGuardarPdf.Filter = "Documento PDF|*.pdf";
        dlgGuardarPdf.FileName = "Boletas.pdf";
        if (dlgGuardarPdf.ShowDialog(this) == DialogResult.OK)
            txtDestino.Text = dlgGuardarPdf.FileName;
    }
    private async void Generar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGenerarPdf.Enabled)
            return;
        if (AyudaFormulario.IdSeleccionado(cboPeriodo) == 0 || string.IsNullOrWhiteSpace(txtDestino.Text))
        {
            notificador.Show("Boletas", "Selecciona período y archivo de destino.", KovaqsUI.Components.KToastKind.Warning);
            return;
        }
        btnGenerarPdf.Enabled = false;
        try
        {
            var servicio = new ServicioNomina();
            var pagos = await servicio.BoletasAsync(AyudaFormulario.IdSeleccionado(cboPeriodo), AyudaFormulario.IdSeleccionado(cboDepartamento), sesion);
            if (pagos.Count == 0)
                throw new InvalidOperationException("No hay pagos calculados para esa selección.");
            var empresa = await new ServicioCatalogos().LeerEmpresaAsync();
            string destino = txtDestino.Text;
            await Task.Run(() => ExportadorReportes.Boletas(empresa, pagos, destino));
            if (!IsDisposed)
                notificador.Show("Boletas", "PDF generado con las boletas de la selección.", KovaqsUI.Components.KToastKind.Success);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnGenerarPdf.Enabled = true; }
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
