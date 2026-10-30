namespace Presentacion.Forms.SubForms.Asistencias;

public partial class FrmPermisosLaborales : Form
{
    public FrmPermisosLaborales()
    {
        InitializeComponent();
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

}
