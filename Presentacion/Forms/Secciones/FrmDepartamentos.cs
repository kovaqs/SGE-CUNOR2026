namespace Presentacion.Forms.Secciones;

public partial class FrmDepartamentos : Form
{
    public FrmDepartamentos()
    {
        InitializeComponent();
    }

    private void btnAcciones_Click(object sender, EventArgs e)
    {
        cmsDepartamentos.Show(btnAcciones, new Point(0, btnAcciones.Height));
    }

    private void dgvDepartamentos_SelectionChanged(object sender, EventArgs e)
    {
        btnAcciones.Enabled = dgvDepartamentos.CurrentRow is not null && !dgvDepartamentos.CurrentRow.IsNewRow && dgvDepartamentos.CurrentRow.Selected;
    }

    private void dgvDepartamentos_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var celda = dgvDepartamentos.HitTest(e.X, e.Y);
        var columna = dgvDepartamentos.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
        dgvDepartamentos.ClearSelection();

        if (celda.RowIndex < 0 || columna is null || dgvDepartamentos.Rows[celda.RowIndex].IsNewRow)
        {
            dgvDepartamentos.CurrentCell = null;
            return;
        }

        dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[celda.RowIndex].Cells[columna.Index];
        dgvDepartamentos.Rows[celda.RowIndex].Selected = true;
    }

    private void cmsDepartamentos_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = dgvDepartamentos.CurrentRow is null || dgvDepartamentos.CurrentRow.IsNewRow || !dgvDepartamentos.CurrentRow.Selected;
    }

    private void dgvDepartamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !dgvDepartamentos.Rows[e.RowIndex].IsNewRow)
            mnuEditarDepartamento.PerformClick();
    }

}
