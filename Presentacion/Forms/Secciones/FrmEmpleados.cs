using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms.Secciones
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btnAcciones_Click(object sender, EventArgs e)
        {
            cmsEmpleados.Show(btnAcciones, new Point(0, btnAcciones.Height));
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            btnAcciones.Enabled = dgvEmpleados.CurrentRow is not null && !dgvEmpleados.CurrentRow.IsNewRow && dgvEmpleados.CurrentRow.Selected;
        }

        private void dgvEmpleados_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            var celda = dgvEmpleados.HitTest(e.X, e.Y);
            var columna = dgvEmpleados.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
            dgvEmpleados.ClearSelection();

            if (celda.RowIndex < 0 || columna is null || dgvEmpleados.Rows[celda.RowIndex].IsNewRow)
            {
                dgvEmpleados.CurrentCell = null;
                return;
            }

            dgvEmpleados.CurrentCell = dgvEmpleados.Rows[celda.RowIndex].Cells[columna.Index];
            dgvEmpleados.Rows[celda.RowIndex].Selected = true;
        }

        private void cmsEmpleados_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = dgvEmpleados.CurrentRow is null || dgvEmpleados.CurrentRow.IsNewRow || !dgvEmpleados.CurrentRow.Selected;
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvEmpleados.Rows[e.RowIndex].IsNewRow)
                mnuEditarEmpleado.PerformClick();
        }

    }
}
