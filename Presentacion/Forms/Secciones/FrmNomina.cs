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

    private void lblTitulo_Click(object sender, EventArgs e)
    {

    }
}
