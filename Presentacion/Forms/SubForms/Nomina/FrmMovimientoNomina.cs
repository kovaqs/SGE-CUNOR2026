using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Nomina;

public partial class FrmMovimientoNomina : Form
{
    private SesionUsuario? sesion;
    private uint detalle;
    private MovimientoPago? movimiento;
    public FrmMovimientoNomina()
    {
        InitializeComponent();
        btnGuardar.Click += Guardar_Click;
        btnCerrar.Click += Cerrar_Click;
        btnCancelar.Click += Cerrar_Click;
        numCantidad.Maximum = 99999999.99m;
        numImporte.Maximum = 999999999999.99m;
        numCantidad.DecimalPlaces = numImporte.DecimalPlaces = 2;
    }
    public void Configurar(SesionUsuario sesion, uint detalle, MovimientoPago? movimiento = null)
    {
        this.sesion = sesion;
        this.detalle = detalle;
        this.movimiento = movimiento;
        cboTipo.SelectedIndex = movimiento?.Tipo == "Deduccion" ? 1 : 0;
        txtConcepto.Text = movimiento?.Concepto ?? "";
        numCantidad.Value = movimiento?.Cantidad ?? 1;
        numImporte.Value = movimiento?.Importe ?? 0;
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            await new ServicioNomina().GuardarMovimientoAsync(new MovimientoPago
            {
                IdDetalle = detalle,
                IdMovimiento = movimiento?.IdMovimiento ?? 0,
                Tipo = cboTipo.Text,
                Concepto = txtConcepto.Text,
                Cantidad = numCantidad.Value,
                Importe = numImporte.Value
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
