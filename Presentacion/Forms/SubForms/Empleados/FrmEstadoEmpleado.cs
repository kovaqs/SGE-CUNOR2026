using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Empleados;

public partial class FrmEstadoEmpleado : Form
{
    private SesionUsuario? sesion;
    private uint empleado;
    public FrmEstadoEmpleado()
    {
        InitializeComponent();
        btnGuardar.Click += Guardar_Click;
        btnCancelar.Click += Cancelar_Click;
        btnCerrar.Click += Cancelar_Click;
        cboEstado.SelectedIndexChanged += Estado_Changed;
    }
    public void Configurar(SesionUsuario sesion, EmpleadoListado empleado)
    {
        this.sesion = sesion;
        this.empleado = empleado.IdEmpleado;
        txtEmpleado.Text = empleado.Nombre;
        cboEstado.SelectedItem = empleado.Estado;
        dtpFechaBaja.Value = DateTime.Today;
        Estado_Changed(this, EventArgs.Empty);
    }
    private void Estado_Changed(object? sender, EventArgs e)
    {
        dtpFechaBaja.Enabled = cboEstado.Text == "Inactivo";
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            await new ServicioEmpleados().CambiarEstadoAsync(empleado, cboEstado.Text, cboEstado.Text == "Inactivo" ? dtpFechaBaja.Value.Date : null, sesion);
            if (!IsDisposed)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnGuardar.Enabled = true; }
    }
    private void Cancelar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
