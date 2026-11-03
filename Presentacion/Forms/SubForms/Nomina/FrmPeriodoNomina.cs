using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Nomina;

public partial class FrmPeriodoNomina : Form
{
    private SesionUsuario? sesion;
    public uint IdCreado
    {
        get; private set;
    }
    public FrmPeriodoNomina()
    {
        InitializeComponent();
        Load += Periodo_Load;
        btnGuardar.Click += Guardar_Click;
        btnCerrar.Click += Cerrar_Click;
        btnCancelar.Click += Cerrar_Click;
    }
    public void Configurar(SesionUsuario sesion)
    {
        this.sesion = sesion;
    }
    private void Periodo_Load(object? sender, EventArgs e)
    {
        dtpFechaInicio.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        dtpFechaFin.Value = dtpFechaInicio.Value.AddMonths(1).AddDays(-1);
        txtNombre.Text = "Nómina " + dtpFechaInicio.Value.ToString("MMMM yyyy", new System.Globalization.CultureInfo("es-GT"));
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            IdCreado = await new ServicioNomina().CrearPeriodoAsync(new PeriodoPago
            {
                Nombre = txtNombre.Text,
                Inicio = dtpFechaInicio.Value.Date,
                Fin = dtpFechaFin.Value.Date,
                Observaciones = txtObservaciones.Text
            }, sesion);
            if (!IsDisposed)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnGuardar.Enabled = true; }
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
