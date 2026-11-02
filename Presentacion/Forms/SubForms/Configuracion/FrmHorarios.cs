namespace Presentacion.Forms.SubForms.Configuracion;

public partial class FrmHorarios : Form
{
    public FrmHorarios()
    {
        InitializeComponent();
        PrepararConsulta();
    }

    private void btnAcciones_Click(object sender, EventArgs e)
    {
        cmsHorarios.Show(btnAcciones, new Point(0, btnAcciones.Height));
    }

    private void dgvHorarios_SelectionChanged(object sender, EventArgs e)
    {
        btnAcciones.Enabled = dgvHorarios.CurrentRow is not null && !dgvHorarios.CurrentRow.IsNewRow && dgvHorarios.CurrentRow.Selected;
    }

    private void dgvHorarios_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var celda = dgvHorarios.HitTest(e.X, e.Y);
        var columna = dgvHorarios.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
        dgvHorarios.ClearSelection();

        if (celda.RowIndex < 0 || columna is null || dgvHorarios.Rows[celda.RowIndex].IsNewRow)
        {
            dgvHorarios.CurrentCell = null;
            return;
        }

        dgvHorarios.CurrentCell = dgvHorarios.Rows[celda.RowIndex].Cells[columna.Index];
        dgvHorarios.Rows[celda.RowIndex].Selected = true;
    }

    private void cmsHorarios_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = dgvHorarios.CurrentRow is null || dgvHorarios.CurrentRow.IsNewRow || !dgvHorarios.CurrentRow.Selected;
    }

    private void dgvHorarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !dgvHorarios.Rows[e.RowIndex].IsNewRow)
            mnuEditarHorario.PerformClick();
    }

    private void FrmHorarios_Load(object sender, EventArgs e)
    {

    }
    private readonly Negocios.ServicioHorarios consulta = new();
    private List<Entidades.Horariolistado> horarios = new();

    private void PrepararConsulta()
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime) return;
        cboEstado.SelectedIndex = 0;
        Load += Consulta_Inicio;
        DatosActualizados += Consulta_Inicio;
        txtBuscar.TextChanged += Consulta_Filtro;
        cboEstado.SelectedIndexChanged += Consulta_Filtro;
        btnCerrar.Click += Consulta_Cerrar;
    }

    private async void Consulta_Inicio(object? sender, EventArgs e)
    {
        try
        {
            horarios = await consulta.ListarAsync();
            if (!IsDisposed)
                Consulta_Filtro(this, EventArgs.Empty);
        }
        catch (Exception ex)
        {
            if (!IsDisposed)
                notificador.Show("Horarios", ex.Message, KovaqsUI.Components.KToastKind.Warning);
        }
    }

    private void Consulta_Filtro(object? sender, EventArgs e)
    {
        string texto = txtBuscar.Text.Trim();
        dgvHorarios.Rows.Clear();
        foreach (var horario in horarios)
        {
            if (!horario.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase))
                continue;
            if (cboEstado.Text == "Activos" && !horario.Activo) continue;
            if (cboEstado.Text == "Inactivos" && horario.Activo) continue;

            int fila = dgvHorarios.Rows.Add(
                horario.Nombre, horario.Descripcion, horario.Activo);
            dgvHorarios.Rows[fila].Tag = horario;
        }
    }

    private void Consulta_Cerrar(object? sender, EventArgs e)
    {
        Close();
    }
}
