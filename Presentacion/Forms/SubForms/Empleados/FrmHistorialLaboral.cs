namespace Presentacion.Forms.SubForms.Empleados;

public partial class FrmHistorialLaboral : Form
{
    public FrmHistorialLaboral()
    {
        InitializeComponent();
    }

    private void btnAcciones_Click(object sender, EventArgs e)
    {
        cmsHistorialLaboral.Show(btnAcciones, new Point(0, btnAcciones.Height));
    }

    private void dgvHistorialLaboral_SelectionChanged(object sender, EventArgs e)
    {
        btnAcciones.Enabled = dgvHistorialLaboral.CurrentRow is not null && !dgvHistorialLaboral.CurrentRow.IsNewRow && dgvHistorialLaboral.CurrentRow.Selected;
    }

    private void dgvHistorialLaboral_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var celda = dgvHistorialLaboral.HitTest(e.X, e.Y);
        var columna = dgvHistorialLaboral.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
        dgvHistorialLaboral.ClearSelection();

        if (celda.RowIndex < 0 || columna is null || dgvHistorialLaboral.Rows[celda.RowIndex].IsNewRow)
        {
            dgvHistorialLaboral.CurrentCell = null;
            return;
        }

        dgvHistorialLaboral.CurrentCell = dgvHistorialLaboral.Rows[celda.RowIndex].Cells[columna.Index];
        dgvHistorialLaboral.Rows[celda.RowIndex].Selected = true;
    }

    private void cmsHistorialLaboral_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = dgvHistorialLaboral.CurrentRow is null || dgvHistorialLaboral.CurrentRow.IsNewRow || !dgvHistorialLaboral.CurrentRow.Selected;
    }

    private void dgvHistorialLaboral_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !dgvHistorialLaboral.Rows[e.RowIndex].IsNewRow)
            mnuVerCondicion.PerformClick();
    }

}
