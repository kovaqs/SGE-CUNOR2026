using Entidades;
using KovaqsUI.Components;
using Negocios;

namespace Presentacion.Forms.Secciones;

public partial class FrmMiCuenta : Form
{
    private readonly ServicioUsuarios servicio = new();
    private readonly CancellationTokenSource cancelacion = new();
    private bool guardando;
    public SesionUsuario? SesionActual { get; private set; }
    public event EventHandler? CuentaActualizada;

    public FrmMiCuenta()
    {
        InitializeComponent();
    }

    public void EstablecerSesion(SesionUsuario sesion)
    {
        if (guardando || SesionActual == sesion)
            return;
        SesionActual = sesion;
        RestaurarCampos();
    }

    private void RestaurarCampos()
    {
        if (SesionActual is null)
            return;
        txtNombreMostrado.Text = SesionActual.Nombre;
        txtRol.Text = SesionActual.Rol;
        txtNombreUsuario.Text = SesionActual.NombreUsuario;
        LimpiarContrasenas();
        btnGuardar.Enabled = true;
    }

    private async void btnGuardar_Click(object sender, EventArgs e)
    {
        if (guardando || SesionActual is null)
            return;
        if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
        {
            notificador.Show("Mi cuenta", "La contraseña nueva y su confirmación no coinciden.", KToastKind.Warning);
            txtConfirmarContrasena.Focus();
            return;
        }
        guardando = true;
        CambiarEstado();
        try
        {
            var actual = await servicio.ActualizarCuentaAsync(SesionActual, txtNombreUsuario.Text,
                txtContrasenaActual.Text, txtNuevaContrasena.Text, cancelacion.Token);
            if (IsDisposed || Disposing)
                return;
            SesionActual = actual;
            RestaurarCampos();
            CuentaActualizada?.Invoke(this, EventArgs.Empty);
            if (Visible)
                notificador.Show("Mi cuenta", "Los cambios se guardaron correctamente.", KToastKind.Success);
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
        {
            if (!IsDisposed && !Disposing && Visible)
                notificador.Show("Mi cuenta", ex.Message, KToastKind.Warning);
        }
        catch (Exception)
        {
            if (!IsDisposed && !Disposing && Visible)
                notificador.Show("Mi cuenta", "No se pudieron guardar los cambios. Vuelve a intentarlo.", KToastKind.Error);
        }
        finally
        {
            guardando = false;
            if (!IsDisposed && !Disposing)
            {
                LimpiarContrasenas();
                CambiarEstado();
            }
        }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        RestaurarCampos();
    }

    private void chkMostrarContrasenas_CheckedChanged(object sender, EventArgs e)
    {
        txtContrasenaActual.UseSystemPasswordChar = txtNuevaContrasena.UseSystemPasswordChar
            = txtConfirmarContrasena.UseSystemPasswordChar = !chkMostrarContrasenas.Checked;
    }

    private void LimpiarContrasenas()
    {
        txtContrasenaActual.Clear();
        txtNuevaContrasena.Clear();
        txtConfirmarContrasena.Clear();
        chkMostrarContrasenas.Checked = false;
    }

    private void CambiarEstado()
    {
        UseWaitCursor = guardando;
        btnGuardar.Enabled = !guardando && SesionActual is not null;
        btnCancelar.Enabled = txtNombreUsuario.Enabled = txtContrasenaActual.Enabled
            = txtNuevaContrasena.Enabled = txtConfirmarContrasena.Enabled = chkMostrarContrasenas.Enabled = !guardando;
    }

    private void FrmMiCuenta_VisibleChanged(object sender, EventArgs e)
    {
        if (!Visible && !Disposing && !IsDisposed)
            LimpiarContrasenas();
    }

    private void FrmMiCuenta_Disposed(object sender, EventArgs e)
    {
        cancelacion.Cancel();
        cancelacion.Dispose();
    }
}
