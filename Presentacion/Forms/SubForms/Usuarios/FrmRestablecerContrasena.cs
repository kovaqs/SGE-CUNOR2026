using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Usuarios;

public partial class FrmRestablecerContrasena : Form
{
    private SesionUsuario? sesion;
    private uint usuario;
    public FrmRestablecerContrasena()
    {
        InitializeComponent();
        btnGuardar.Click += Guardar_Click;
        btnCerrar.Click += Cerrar_Click;
        btnCancelar.Click += Cerrar_Click;
        chkMostrarContrasena.CheckedChanged += Mostrar_Changed;
        txtContrasena.UseSystemPasswordChar = txtConfirmarContrasena.UseSystemPasswordChar = true;
        FormClosed += Contrasena_FormClosed;
    }
    public void Configurar(SesionUsuario sesion, uint usuario, string nombre)
    {
        this.sesion = sesion;
        this.usuario = usuario;
        txtNombreUsuario.Text = nombre;
    }
    private void Mostrar_Changed(object? sender, EventArgs e)
    {
        txtContrasena.UseSystemPasswordChar = txtConfirmarContrasena.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        if (txtContrasena.Text != txtConfirmarContrasena.Text)
        {
            notificador.Show("Contraseña", "Las contraseñas no coinciden.", KovaqsUI.Components.KToastKind.Warning);
            return;
        }
        btnGuardar.Enabled = false;
        try
        {
            await new ServicioUsuarios().RestablecerAsync(usuario, txtContrasena.Text, sesion);
            if (!IsDisposed)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) { txtContrasena.Clear(); txtConfirmarContrasena.Clear(); btnGuardar.Enabled = true; } }
    }
    private void Contrasena_FormClosed(object? sender, FormClosedEventArgs e)
    {
        txtContrasena.Clear();
        txtConfirmarContrasena.Clear();
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
