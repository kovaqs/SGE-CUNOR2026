using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Nomina;

public partial class FrmPeriodoNominaDetalle : Form
{
    private readonly ServicioNomina servicio = new();
    private SesionUsuario? sesion;
    private uint periodo;
    private int pagina;
    private bool cargando;
    public FrmPeriodoNominaDetalle()
    {
        InitializeComponent();
        Load += Periodo_Load;
        btnCerrar.Click += Cerrar_Click;
        btnCalcularNomina.Click += Calcular_Click;
        btnVerDetalle.Click += VerDetalle_Click;
        btnCerrarPeriodo.Click += CerrarPeriodo_Click;
        btnAnularPeriodo.Click += AnularPeriodo_Click;
        cboDepartamento.SelectedIndexChanged += Filtro_Changed;
        cboTamanoPagina.SelectedIndexChanged += Filtro_Changed;
        txtBuscarEmpleado.KeyDown += Buscar_KeyDown;
        btnAnterior.Click += Anterior_Click;
        btnSiguiente.Click += Siguiente_Click;
        dgvDetalleNomina.CellDoubleClick += VerDetalle_CellDoubleClick;
    }
    public void Configurar(SesionUsuario sesion, uint periodo)
    {
        this.sesion = sesion;
        this.periodo = periodo;
    }
    private async void Periodo_Load(object? sender, EventArgs e)
    {
        cargando = true;
        try
        {
            AyudaFormulario.CargarCombo(cboDepartamento, await new ServicioCatalogos().OpcionesAsync("departamentos", 0, true), "Todos");
            cboTamanoPagina.SelectedIndex = 0;
            colDetalleNominaIngresos.DefaultCellStyle.Format = colDetalleNominaDeducciones.DefaultCellStyle.Format = colDetalleNominaNeto.DefaultCellStyle.Format = "N2";
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; }
        await CargarAsync();
    }
    private async Task CargarAsync()
    {
        if (sesion is null || cargando || cboTamanoPagina.SelectedIndex < 0)
            return;
        cargando = true;
        dgvDetalleNomina.Enabled = false;
        btnAnterior.Enabled = btnSiguiente.Enabled = false;
        try
        {
            var datos = await servicio.LeerPeriodoAsync(periodo);
            int tamano = int.Parse(cboTamanoPagina.Text);
            var pagos = await servicio.PagosAsync(periodo, AyudaFormulario.IdSeleccionado(cboDepartamento), txtBuscarEmpleado.Text, pagina, tamano, sesion);
            if (IsDisposed)
                return;
            txtPeriodo.Text = datos.Nombre;
            txtEstadoPeriodo.Text = datos.Estado;
            btnCalcularNomina.Enabled = btnCerrarPeriodo.Enabled = datos.Estado == "Borrador";
            btnAnularPeriodo.Enabled = datos.Estado != "Anulado";
            bool siguiente = pagos.Count > tamano;
            if (siguiente)
                pagos.RemoveAt(tamano);
            dgvDetalleNomina.Rows.Clear();
            decimal ingresos = 0, deducciones = 0, neto = 0;
            foreach (var pago in pagos)
            {
                int fila = dgvDetalleNomina.Rows.Add(pago.Codigo, pago.Empleado, pago.Departamento, pago.Ingresos, pago.Deducciones, pago.Neto);
                dgvDetalleNomina.Rows[fila].Tag = pago;
                ingresos += pago.Ingresos;
                deducciones += pago.Deducciones;
                neto += pago.Neto;
            }
            lblTotalIngresos.Text = "Ingresos (página): Q " + ingresos.ToString("N2");
            lblTotalDeducciones.Text = "Deducciones (página): Q " + deducciones.ToString("N2");
            lblTotalNeto.Text = "Neto (página): Q " + neto.ToString("N2");
            lblPagina.Text = "Página " + (pagina + 1);
            btnAnterior.Enabled = pagina > 0;
            btnSiguiente.Enabled = siguiente;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; if (!IsDisposed) dgvDetalleNomina.Enabled = true; }
    }
    private async void Calcular_Click(object? sender, EventArgs e)
    {
        if (sesion is null || cargando || !AyudaFormulario.Confirmar(this, "¿Generar la nómina mensual con el sueldo completo y sin deducciones automáticas?"))
            return;
        btnCalcularNomina.Enabled = false;
        try
        {
            await servicio.GenerarAsync(periodo, sesion);
            await CargarAsync();
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnCalcularNomina.Enabled = txtEstadoPeriodo.Text == "Borrador"; }
    }
    private async void VerDetalle_Click(object? sender, EventArgs e)
    {
        if (sesion is null || cargando || dgvDetalleNomina.CurrentRow?.Tag is not PagoEmpleado pago)
            return;
        using var formulario = new FrmDetalleNomina();
        formulario.Configurar(sesion, pago.IdDetalle);
        formulario.ShowDialog(this);
        await CargarAsync();
    }
    private void VerDetalle_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
            VerDetalle_Click(sender, EventArgs.Empty);
    }
    private async Task CambiarEstadoAsync(string estado)
    {
        if (sesion is null || cargando || !AyudaFormulario.Confirmar(this, "¿Cambiar el período a " + estado + "? Sus movimientos quedarán bloqueados."))
            return;
        try
        {
            await servicio.CambiarEstadoAsync(periodo, estado, sesion);
            await CargarAsync();
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async void CerrarPeriodo_Click(object? sender, EventArgs e)
    {
        await CambiarEstadoAsync("Cerrado");
    }
    private async void AnularPeriodo_Click(object? sender, EventArgs e)
    {
        await CambiarEstadoAsync("Anulado");
    }
    private async void Filtro_Changed(object? sender, EventArgs e)
    {
        if (!cargando)
        {
            pagina = 0;
            await CargarAsync();
        }
    }
    private async void Buscar_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && !cargando)
        {
            e.SuppressKeyPress = true;
            pagina = 0;
            await CargarAsync();
        }
    }
    private async void Anterior_Click(object? sender, EventArgs e)
    {
        if (!cargando && pagina > 0)
        {
            pagina--;
            await CargarAsync();
        }
    }
    private async void Siguiente_Click(object? sender, EventArgs e)
    {
        if (!cargando)
        {
            pagina++;
            await CargarAsync();
        }
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
