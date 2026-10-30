namespace Presentacion.Forms.SubForms.Nomina;

public partial class FrmDetalleNomina : Form
{
    public FrmDetalleNomina()
    {
        InitializeComponent();
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

}
