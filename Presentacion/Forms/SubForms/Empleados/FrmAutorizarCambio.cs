namespace Presentacion.Forms.SubForms.Empleados;

using Entidades;
using KovaqsUI.Components;
using Negocios;

public partial class FrmAutorizarCambio : Form
{
    private SesionUsuario? sesion;
    private bool verificando;
    public string ClaveConfirmada { get; private set; } = "";

    public FrmAutorizarCambio()
    {
        InitializeComponent();
    }

    public void Configurar(SesionUsuario sesion, string empleado, string operacion)
    {
        ClaveConfirmada = "";
        txtContrasena.Clear();
        chkMostrarContrasena.Checked = false;
        this.sesion = sesion;
        txtEmpleado.Text = empleado;
        txtOperacion.Text = operacion;
        txtUsuarioAutoriza.Text = sesion.NombreUsuario;
        btnGuardar.Enabled = true;
    }

    private async void btnGuardar_Click(object sender, EventArgs e)
    {
        if (verificando || sesion is null)
            return;
        verificando = true;
        btnGuardar.Enabled = btnCancelar.Enabled = btnCerrar.Enabled = false;
        UseWaitCursor = true;
        var contrasena = txtContrasena.Text;
        try
        {
            var coincide = await new ServicioAutenticacion().ConfirmarClaveAsync(sesion, contrasena);
            if (IsDisposed || Disposing)
                return;
            if (!coincide)
            {
                notificador.Show("Autorización", "La contraseña no coincide o el usuario ya no está activo.", KToastKind.Warning);
                return;
            }
            ClaveConfirmada = contrasena;
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception)
        {
            if (!IsDisposed && !Disposing)
                notificador.Show("Autorización", "No se pudo comprobar la contraseña. Revisa la conexión.", KToastKind.Warning);
        }
        finally
        {
            verificando = false;
            if (!IsDisposed && !Disposing)
            {
                txtContrasena.Clear();
                UseWaitCursor = false;
                btnGuardar.Enabled = btnCancelar.Enabled = btnCerrar.Enabled = true;
            }
        }
    }

    private void chkMostrarContrasena_CheckedChanged(object sender, EventArgs e)
    {
        txtContrasena.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
    }

    private void FrmAutorizarCambio_FormClosed(object sender, FormClosedEventArgs e)
    {
        txtContrasena.Clear();
        if (DialogResult != DialogResult.OK)
            ClaveConfirmada = "";
    }

    private void FrmAutorizarCambio_Disposed(object sender, EventArgs e)
    {
        ClaveConfirmada = "";
    }
}
