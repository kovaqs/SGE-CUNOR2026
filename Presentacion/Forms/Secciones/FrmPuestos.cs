namespace Presentacion.Forms.Secciones;

public partial class FrmPuestos : Form
{
    public FrmPuestos()
    {
        InitializeComponent();
    }

    private void dgvPuestos_SelectionChanged(object sender, EventArgs e)
    {
        btnAcciones.Enabled = dgvPuestos.CurrentRow is not null && !dgvPuestos.CurrentRow.IsNewRow && dgvPuestos.CurrentRow.Selected;
    }

    private void FrmPuestos_Load(object sender, EventArgs e)
    {

    }

    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void lblPuestos_Click(object sender, EventArgs e)
    {

    }

    private void btnAcciones_Click(object sender, EventArgs e)
    {
        cmsPuestos.Show(btnAcciones, new Point(0, btnAcciones.Height));
    }

    private void dgvPuestos_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var celda = dgvPuestos.HitTest(e.X, e.Y);
        var columna = dgvPuestos.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
        dgvPuestos.ClearSelection();

        if (celda.RowIndex < 0 || columna is null || dgvPuestos.Rows[celda.RowIndex].IsNewRow)
        {
            dgvPuestos.CurrentCell = null;
            return;
        }

        dgvPuestos.CurrentCell = dgvPuestos.Rows[celda.RowIndex].Cells[columna.Index];
        dgvPuestos.Rows[celda.RowIndex].Selected = true;
    }

    private void cmsPuestos_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = dgvPuestos.CurrentRow is null || dgvPuestos.CurrentRow.IsNewRow || !dgvPuestos.CurrentRow.Selected;
    }

    private void dgvPuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !dgvPuestos.Rows[e.RowIndex].IsNewRow)
            mnuEditarPuesto.PerformClick();
    }

}
