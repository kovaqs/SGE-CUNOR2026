using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Asistencias;

public partial class FrmResolverPermiso : Form
{
    private SesionUsuario? sesion;
    private uint id;
    public FrmResolverPermiso()
    {
        InitializeComponent();
        btnGuardar.Click += Guardar_Click;
        btnCerrar.Click += Cerrar_Click;
        btnCancelar.Click += Cerrar_Click;
    }
    public void Configurar(SesionUsuario sesion, PermisoTrabajo permiso)
    {
        this.sesion = sesion;
        id = permiso.IdPermiso;
        txtEmpleado.Text = permiso.Empleado;
        txtPeriodo.Text = permiso.Inicio.ToString("dd/MM/yyyy HH:mm") + " - " + permiso.Fin.ToString("dd/MM/yyyy HH:mm");
        txtMotivo.Text = permiso.Motivo;
        txtObservaciones.Text = permiso.Observaciones;
        cboResolucion.SelectedIndex = 0;
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            await new ServicioPermisosTrabajo().ResolverAsync(id, cboResolucion.Text, txtObservaciones.Text, sesion);
            if (!IsDisposed)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnGuardar.Enabled = true; }
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
