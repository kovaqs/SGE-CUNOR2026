using Entidades;
using Negocios;
namespace Presentacion.Forms.SubForms.Empleados;

public partial class FrmHistorialLaboral : Form
{
    public FrmHistorialLaboral()
    {
        InitializeComponent();
        Load += Historial_Load;
        btnCerrar.Click += Cerrar_Click;
        btnNuevaCondicion.Click += NuevaCondicion_Click;
        mnuVerCondicion.Click += VerCondicion_Click;
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


    private SesionUsuario? sesion;
    private uint empleado;
    private string nombre = "";
    public void Configurar(SesionUsuario sesion, uint empleado, string nombre)
    {
        this.sesion = sesion;
        this.empleado = empleado;
        this.nombre = nombre;
        txtEmpleado.Text = nombre;
    }
    private async void Historial_Load(object? sender, EventArgs e)
    {
        await CargarHistorialAsync();
    }
    private async Task CargarHistorialAsync()
    {
        if (sesion is null)
            return;
        try
        {
            var historial = await new ServicioEmpleados().HistorialAsync(empleado, sesion);
            if (IsDisposed)
                return;
            dgvHistorialLaboral.Rows.Clear();
            foreach (var registro in historial)
            {
                int fila = dgvHistorialLaboral.Rows.Add(registro.Inicio, registro.Fin, registro.Departamento + " / " + registro.Puesto,
                    registro.Contrato, registro.Horario, registro.Salario, registro.Motivo);
                dgvHistorialLaboral.Rows[fila].Tag = registro;
            }
            colHistorialLaboralDesde.DefaultCellStyle.Format = "dd/MM/yyyy";
            colHistorialLaboralHasta.DefaultCellStyle.Format = "dd/MM/yyyy";
            colHistorialLaboralSalario.DefaultCellStyle.Format = "N2";
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async void NuevaCondicion_Click(object? sender, EventArgs e)
    {
        if (sesion is null)
            return;
        using var formulario = new FrmCambioLaboral();
        formulario.Configurar(sesion, empleado, nombre);
        if (formulario.ShowDialog(this) == DialogResult.OK)
            await CargarHistorialAsync();
    }
    private void VerCondicion_Click(object? sender, EventArgs e)
    {
        if (dgvHistorialLaboral.CurrentRow?.Tag is HistorialEmpleado registro)
            notificador.Show("Motivo de la condición", registro.Motivo, KovaqsUI.Components.KToastKind.Information);
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
