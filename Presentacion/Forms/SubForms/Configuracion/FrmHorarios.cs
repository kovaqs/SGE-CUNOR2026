namespace Presentacion.Forms.SubForms.Configuracion;

public partial class FrmHorarios : Form
{
    public FrmHorarios()
    {
        InitializeComponent();
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

}
