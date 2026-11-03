using Entidades;
using Negocios;
using Presentacion.Reportes;
namespace Presentacion.Forms.SubForms.Nomina;

public partial class FrmDetalleNomina : Form
{
    public FrmDetalleNomina()
    {
        InitializeComponent();
        dlgGuardarBoleta.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Load += Detalle_Load;
        btnCerrar.Click += Cerrar_Click;
        btnAgregarMovimiento.Click += Agregar_Click;
        mnuEditarMovimiento.Click += Editar_Click;
        mnuEliminarMovimiento.Click += Eliminar_Click;
        btnExportarBoleta.Click += Exportar_Click;
    }

    private void btnAcciones_Click(object sender, EventArgs e)
    {
        cmsMovimientos.Show(btnAcciones, new Point(0, btnAcciones.Height));
    }

    private void dgvMovimientos_SelectionChanged(object sender, EventArgs e)
    {
        btnAcciones.Enabled = dgvMovimientos.CurrentRow is not null && !dgvMovimientos.CurrentRow.IsNewRow && dgvMovimientos.CurrentRow.Selected;
    }

    private void dgvMovimientos_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var celda = dgvMovimientos.HitTest(e.X, e.Y);
        var columna = dgvMovimientos.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
        dgvMovimientos.ClearSelection();

        if (celda.RowIndex < 0 || columna is null || dgvMovimientos.Rows[celda.RowIndex].IsNewRow)
        {
            dgvMovimientos.CurrentCell = null;
            return;
        }

        dgvMovimientos.CurrentCell = dgvMovimientos.Rows[celda.RowIndex].Cells[columna.Index];
        dgvMovimientos.Rows[celda.RowIndex].Selected = true;
    }

    private void cmsMovimientos_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = dgvMovimientos.CurrentRow is null || dgvMovimientos.CurrentRow.IsNewRow || !dgvMovimientos.CurrentRow.Selected;
    }

    private void dgvMovimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !dgvMovimientos.Rows[e.RowIndex].IsNewRow)
            mnuEditarMovimiento.PerformClick();
    }


    private SesionUsuario? sesion;
    private uint detalle;
    private PagoEmpleado? pago;
    public void Configurar(SesionUsuario sesion, uint detalle)
    {
        this.sesion = sesion;
        this.detalle = detalle;
    }
    private async void Detalle_Load(object? sender, EventArgs e)
    {
        await CargarAsync();
    }
    private async Task CargarAsync()
    {
        if (sesion is null)
            return;
        try
        {
            pago = await new ServicioNomina().LeerPagoAsync(detalle, sesion);
            var movimientos = await new ServicioNomina().MovimientosAsync(detalle, sesion);
            if (IsDisposed)
                return;
            pago.Movimientos = movimientos;
            txtEmpleado.Text = pago.Codigo + " - " + pago.Empleado;
            txtPeriodo.Text = pago.Periodo;
            txtDepartamento.Text = pago.Departamento;
            txtPuesto.Text = pago.Puesto;
            txtSalarioBase.Text = pago.SalarioBase.ToString("N2");
            txtDiasPagados.Text = pago.Dias.ToString("0.##");
            lblTotalIngresos.Text = "Ingresos: Q " + pago.Ingresos.ToString("N2");
            lblTotalDeducciones.Text = "Deducciones: Q " + pago.Deducciones.ToString("N2");
            lblNeto.Text = "Neto: Q " + pago.Neto.ToString("N2");
            btnAgregarMovimiento.Enabled = mnuEditarMovimiento.Enabled = mnuEliminarMovimiento.Enabled = pago.EstadoPeriodo == "Borrador";
            dgvMovimientos.Rows.Clear();
            foreach (var movimiento in movimientos)
            {
                int fila = dgvMovimientos.Rows.Add(movimiento.Tipo == "Deduccion" ? "Deducción" : "Ingreso", movimiento.Concepto, movimiento.Cantidad, movimiento.Total);
                dgvMovimientos.Rows[fila].Tag = movimiento;
            }
            colMovimientosImportetotal.DefaultCellStyle.Format = "N2";
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async Task AbrirAsync(MovimientoPago? movimiento)
    {
        if (sesion is null || pago?.EstadoPeriodo != "Borrador")
            return;
        using var formulario = new FrmMovimientoNomina();
        formulario.Configurar(sesion, detalle, movimiento);
        if (formulario.ShowDialog(this) == DialogResult.OK)
            await CargarAsync();
    }
    private async void Agregar_Click(object? sender, EventArgs e)
    {
        await AbrirAsync(null);
    }
    private async void Editar_Click(object? sender, EventArgs e)
    {
        if (dgvMovimientos.CurrentRow?.Tag is MovimientoPago movimiento)
            await AbrirAsync(movimiento);
    }
    private async void Eliminar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || dgvMovimientos.CurrentRow?.Tag is not MovimientoPago movimiento || !AyudaFormulario.Confirmar(this, "¿Eliminar este movimiento?"))
            return;
        try
        {
            await new ServicioNomina().EliminarMovimientoAsync(movimiento.IdMovimiento, detalle, sesion);
            await CargarAsync();
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async void Exportar_Click(object? sender, EventArgs e)
    {
        if (pago is null)
            return;
        dlgGuardarBoleta.Filter = "Documento PDF|*.pdf";
        dlgGuardarBoleta.FileName = "Boleta-" + pago.Codigo + ".pdf";
        if (dlgGuardarBoleta.ShowDialog(this) != DialogResult.OK)
            return;
        try
        {
            var empresa = await new ServicioCatalogos().LeerEmpresaAsync();
            ExportadorReportes.Boletas(empresa, new List<PagoEmpleado> { pago }, dlgGuardarBoleta.FileName);
            notificador.Show("Nómina", "Boleta guardada.", KovaqsUI.Components.KToastKind.Success);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
