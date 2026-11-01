namespace Presentacion.Forms.SubForms.Asistencias;

public partial class FrmPermisosLaborales : Form
{
    public FrmPermisosLaborales()
    {
        InitializeComponent();
        PrepararConsulta();
    }

    private void FrmPermisosLaborales_Load(object sender, EventArgs e)
    {

    }

    private void btnAcciones_Click(object sender, EventArgs e)
    {
        cmsPermisos.Show(btnAcciones, new Point(0, btnAcciones.Height));
    }

    private void dgvPermisos_SelectionChanged(object sender, EventArgs e)
    {
        btnAcciones.Enabled = dgvPermisos.CurrentRow is not null && !dgvPermisos.CurrentRow.IsNewRow && dgvPermisos.CurrentRow.Selected;
    }

    private void dgvPermisos_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var celda = dgvPermisos.HitTest(e.X, e.Y);
        var columna = dgvPermisos.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
        dgvPermisos.ClearSelection();

        if (celda.RowIndex < 0 || columna is null || dgvPermisos.Rows[celda.RowIndex].IsNewRow)
        {
            dgvPermisos.CurrentCell = null;
            return;
        }

        dgvPermisos.CurrentCell = dgvPermisos.Rows[celda.RowIndex].Cells[columna.Index];
        dgvPermisos.Rows[celda.RowIndex].Selected = true;
    }

    private void cmsPermisos_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = dgvPermisos.CurrentRow is null || dgvPermisos.CurrentRow.IsNewRow || !dgvPermisos.CurrentRow.Selected;
    }

    private void dgvPermisos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !dgvPermisos.Rows[e.RowIndex].IsNewRow)
            mnuEditarPermiso.PerformClick();
    }
    private readonly Negocios.ServicioPermisosLaborales consulta = new();
    private int paginaConsulta;
    private bool consultando;

    private void PrepararConsulta()
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return;
        dtpDesde.Value = new DateTime(DateTime.Today.Year, 1, 1);
        dtpHasta.Value = DateTime.Today;
        cboEstado.SelectedIndex = 0;
        cboTamanoPagina.SelectedIndex = 0;
        dgvPermisos.AutoGenerateColumns = false;
        colPermisosInicio.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        colPermisosFin.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

        txtBuscarEmpleado.KeyDown += Consulta_Buscar;
        btnCerrar.Click += Consulta_Cerrar;
        Load += Consulta_Filtro;
        dtpDesde.ValueChanged += Consulta_Filtro;
        dtpHasta.ValueChanged += Consulta_Filtro;
        cboEstado.SelectedIndexChanged += Consulta_Filtro;
        cboTamanoPagina.SelectedIndexChanged += Consulta_Filtro;
        btnAnterior.Click += Consulta_Anterior;
        btnSiguiente.Click += Consulta_Siguiente;
    }

    private async void Consulta_Filtro(object? sender, EventArgs e)
    {
        if (consultando) return;
        paginaConsulta = 0;
        await CargarConsultaAsync();
    }

    private async Task CargarConsultaAsync()
    {
        if (consultando) return;
        consultando = true;
        HabilitarFiltrosConsulta(false);
        btnAnterior.Enabled = false;
        btnSiguiente.Enabled = false;

        try
        {
            int tamano = int.Parse(cboTamanoPagina.Text);
            var registros = await consulta.ListarAsync(
                dtpDesde.Value, dtpHasta.Value, cboEstado.Text,
                txtBuscarEmpleado.Text, paginaConsulta, tamano);

            if (IsDisposed) return;

            bool haySiguiente = registros.Count > tamano;
            if (haySiguiente) registros.RemoveAt(tamano);

            dgvPermisos.Rows.Clear();
            foreach (var registro in registros)
            {
                int fila = dgvPermisos.Rows.Add(
                    registro.Empleado, registro.Inicio, registro.Fin,
                    registro.Motivo, registro.ConGoce, registro.Estado);
                dgvPermisos.Rows[fila].Tag = registro;
            }

            lblPagina.Text = "Página " + (paginaConsulta + 1);
            btnAnterior.Enabled = paginaConsulta > 0;
            btnSiguiente.Enabled = haySiguiente;
        }
        catch (Exception ex)
        {
            if (!IsDisposed)
                notificador.Show("Consulta", ex.Message, KovaqsUI.Components.KToastKind.Warning);
        }
        finally
        {
            consultando = false;
            if (!IsDisposed) HabilitarFiltrosConsulta(true);
        }
    }

    private void HabilitarFiltrosConsulta(bool habilitar)
    {
        dtpDesde.Enabled = dtpHasta.Enabled = habilitar;
        cboEstado.Enabled = cboTamanoPagina.Enabled = habilitar;
        txtBuscarEmpleado.Enabled = habilitar;
    }

    private async void Consulta_Anterior(object? sender, EventArgs e)
    {
        if (consultando || paginaConsulta == 0) return;
        paginaConsulta--;
        await CargarConsultaAsync();
    }

    private async void Consulta_Siguiente(object? sender, EventArgs e)
    {
        if (consultando) return;
        paginaConsulta++;
        await CargarConsultaAsync();
    }

    private async void Consulta_Buscar(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode != Keys.Enter || consultando) return;
        e.SuppressKeyPress = true;
        paginaConsulta = 0;
        await CargarConsultaAsync();
    }

    private void Consulta_Cerrar(object? sender, EventArgs e)
    {
        Close();
    }
}
