namespace Presentacion.Forms.Secciones;

public partial class FrmNomina : Form
{
    public FrmNomina()
    {
        InitializeComponent();
        PrepararConsulta();
    }

    private void btnAcciones_Click(object sender, EventArgs e)
    {
        cmsPeriodos.Show(btnAcciones, new Point(0, btnAcciones.Height));
    }

    private void dgvPeriodos_SelectionChanged(object sender, EventArgs e)
    {
        btnAcciones.Enabled = dgvPeriodos.CurrentRow is not null && !dgvPeriodos.CurrentRow.IsNewRow && dgvPeriodos.CurrentRow.Selected;
    }

    private void dgvPeriodos_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var celda = dgvPeriodos.HitTest(e.X, e.Y);
        var columna = dgvPeriodos.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
        dgvPeriodos.ClearSelection();

        if (celda.RowIndex < 0 || columna is null || dgvPeriodos.Rows[celda.RowIndex].IsNewRow)
        {
            dgvPeriodos.CurrentCell = null;
            return;
        }

        dgvPeriodos.CurrentCell = dgvPeriodos.Rows[celda.RowIndex].Cells[columna.Index];
        dgvPeriodos.Rows[celda.RowIndex].Selected = true;
    }

    private void cmsPeriodos_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = dgvPeriodos.CurrentRow is null || dgvPeriodos.CurrentRow.IsNewRow || !dgvPeriodos.CurrentRow.Selected;
    }

    private void dgvPeriodos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !dgvPeriodos.Rows[e.RowIndex].IsNewRow)
            mnuVerPeriodo.PerformClick();
    }

    private readonly Negocios.ServicioPeriodosNomina consulta = new();
    private int paginaConsulta;
    private bool consultando;
    private bool consultaIniciada;

    private void PrepararConsulta()
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        dtpDesde.Value = new DateTime(DateTime.Today.Year, 1, 1);
        dtpHasta.Value = DateTime.Today;
        cboEstado.SelectedIndex = 0;
        cboTamanoPagina.SelectedIndex = 0;
        colDesde.DefaultCellStyle.Format = colHasta.DefaultCellStyle.Format = "dd/MM/yyyy";
        colFechaCierre.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        Load += Nomina_Load;
        VisibleChanged += Nomina_VisibleChanged;
        DatosActualizados += Consulta_Filtro;
        dtpDesde.ValueChanged += Consulta_Filtro;
        dtpHasta.ValueChanged += Consulta_Filtro;
        cboEstado.SelectedIndexChanged += Consulta_Filtro;
        cboTamanoPagina.SelectedIndexChanged += Consulta_Filtro;
        btnAnterior.Click += Consulta_Anterior;
        btnSiguiente.Click += Consulta_Siguiente;
    }

    private async void Nomina_Load(object? sender, EventArgs e)
    {
        consultaIniciada = true;
        await CargarConsultaAsync();
    }

    private async void Nomina_VisibleChanged(object? sender, EventArgs e)
    {
        if (Visible && consultaIniciada && !consultando)
            await CargarConsultaAsync();
    }

    private async void Consulta_Filtro(object? sender, EventArgs e)
    {
        if (consultando)
            return;
        paginaConsulta = 0;
        await CargarConsultaAsync();
    }

    private async Task CargarConsultaAsync()
    {
        if (consultando || IsDisposed)
            return;
        consultando = true;
        HabilitarConsulta(false);
        btnAnterior.Enabled = btnSiguiente.Enabled = false;
        try
        {
            int tamano = int.Parse(cboTamanoPagina.Text);
            var periodos = await consulta.ListarAsync(
                dtpDesde.Value, dtpHasta.Value, cboEstado.Text, paginaConsulta, tamano);
            if (IsDisposed)
                return;
            bool siguiente = periodos.Count > tamano;
            if (siguiente)
                periodos.RemoveAt(tamano);
            dgvPeriodos.Rows.Clear();
            foreach (var periodo in periodos)
            {
                int fila = dgvPeriodos.Rows.Add(periodo.Nombre, periodo.Desde, periodo.Hasta,
                    periodo.Estado, periodo.GeneradoPor, periodo.FechaCierre);
                dgvPeriodos.Rows[fila].Tag = periodo;
            }
            lblPagina.Text = "Página " + (paginaConsulta + 1);
            btnAnterior.Enabled = paginaConsulta > 0;
            btnSiguiente.Enabled = siguiente;
        }
        catch (Exception ex)
        {
            if (!IsDisposed)
                AyudaFormulario.Error(notificador, ex);
        }
        finally
        {
            consultando = false;
            if (!IsDisposed)
                HabilitarConsulta(true);
        }
    }

    private void HabilitarConsulta(bool habilitar)
    {
        dtpDesde.Enabled = dtpHasta.Enabled = cboEstado.Enabled = cboTamanoPagina.Enabled = habilitar;
        dgvPeriodos.Enabled = btnNuevoPeriodo.Enabled = btnBoletas.Enabled = habilitar;
        btnAcciones.Enabled = habilitar && dgvPeriodos.CurrentRow is { Selected: true };
    }

    private async void Consulta_Anterior(object? sender, EventArgs e)
    {
        if (consultando || paginaConsulta == 0)
            return;
        paginaConsulta--;
        await CargarConsultaAsync();
    }

    private async void Consulta_Siguiente(object? sender, EventArgs e)
    {
        if (consultando)
            return;
        paginaConsulta++;
        await CargarConsultaAsync();
    }
}
