using System;
using System.ComponentModel;
using KovaqsUI.Components;
using Negocios;

namespace Presentacion.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly ServicioAutenticacion autenticacion = new();
        private readonly ServicioConexion servicioConexion = new();
        private readonly CancellationTokenSource cancelacion = new();
        private FrmPrincipal? principal;
        private long? versionConexion;
        private bool ocupado;
        private bool preparado;

        public FrmLogin()
        {
            InitializeComponent();
            AcceptButton = btnIngresar;
            CancelButton = btnSalir;
            btnIngresar.Click += Ingresar_Click;
            btnSalir.Click += (_, _) => Close();
            chkMostrarContrasena.CheckedChanged += (_, _) =>
            {
                txtContrasena.PasswordChar = chkMostrarContrasena.Checked ? '\0' : '●';
                txtContrasena.UseSystemPasswordChar = !chkMostrarContrasena.Checked;
            };
            FormClosed += (_, _) =>
            {
                temporizadorConexion.Stop();
                cancelacion.Cancel();
                cancelacion.Dispose();
            };
        }

        private async void FrmLogin_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            await PrepararAsync();
            if (!IsDisposed)
                temporizadorConexion.Start();
        }

        private async Task PrepararAsync()
        {
            CambiarEstado(true);
            preparado = false;
            try
            {
                versionConexion = servicioConexion.VersionActual;
                if (versionConexion is null)
                {
                    btnConfigurarConexion.Visible = true;
                    lblIndicaciones.Text = "Configura la conexión a MySQL para empezar.";
                    return;
                }
                preparado = await autenticacion.HayUsuariosAsync(cancelacion.Token);
                if (ConexionHaCambiado())
                {
                    MostrarErrorConexion("La configuración cambió. Comprueba de nuevo la conexión.");
                    return;
                }
                btnConfigurarConexion.Visible = false;
                lblIndicaciones.Text = preparado
                    ? "Introduce tus credenciales para empezar"
                    : "No hay usuarios registrados. Contacta al administrador.";
                if (preparado)
                    txtContrasena.Focus();
            }
            catch (OperationCanceledException) { }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
            {
                if (!IsDisposed)
                    MostrarErrorConexion(ex.Message);
            }
            catch (Exception)
            {
                if (!IsDisposed)
                    MostrarErrorConexion("No se pudo preparar el acceso. Revisa la configuración de conexión.");
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnIngresar.Text = preparado ? "Iniciar sesión" : "Reintentar";
                    CambiarEstado(false);
                }
            }
        }

        private async void btnConfigurarConexion_Click(object sender, EventArgs e)
        {
            if (ocupado)
                return;

            CambiarEstado(true);
            try
            {
                using var conexion = new FrmConfigurarConexion();
                conexion.ShowDialog(this);
                txtContrasena.Text = "";
                chkMostrarContrasena.Checked = false;
            }
            finally
            {
                if (!IsDisposed)
                    await PrepararAsync();
            }
        }

        private bool ConexionHaCambiado()
        {
            try { return servicioConexion.VersionActual != versionConexion; }
            catch (InvalidOperationException) { return true; }
        }

        private async void temporizadorConexion_Tick(object sender, EventArgs e)
        {
            if (IsDisposed || (ocupado && principal is null) || !ConexionHaCambiado())
                return;

            if (principal is not null)
                principal.Close();
            else
                await PrepararAsync();
        }

        private void MostrarErrorConexion(string mensaje)
        {
            preparado = false;
            btnConfigurarConexion.Visible = true;
            btnIngresar.Text = "Reintentar";
            lblIndicaciones.Text = "No se pudo comprobar la conexión. Puedes revisarla o reintentar.";
            notificador.Show("Conexión", mensaje, KToastKind.Warning);
        }

        private async void Ingresar_Click(object? sender, EventArgs e)
        {
            if (ocupado)
                return;
            if (!preparado)
            {
                await PrepararAsync();
                return;
            }
            CambiarEstado(true);
            bool revisarConexion = false;
            bool conexionModificada = false;
            try
            {
                if (ConexionHaCambiado())
                {
                    revisarConexion = true;
                    return;
                }
                var sesion = await autenticacion.IniciarSesionAsync(txtUsuario.Text, txtContrasena.Text, cancelacion.Token);
                txtContrasena.Text = "";
                chkMostrarContrasena.Checked = false;
                if (sesion is null)
                {
                    lblIndicaciones.Text = "Usuario o contraseña incorrectos, o cuenta inactiva.";
                    await Task.Delay(1500, cancelacion.Token);
                    return;
                }
                revisarConexion = true;
                if (ConexionHaCambiado())
                    return;

                using var ventana = new FrmPrincipal(sesion);
                principal = ventana;
                Hide();
                try
                {
                    ventana.ShowDialog();
                    principal = null;
                    var sesionActual = ventana.SesionActual ?? sesion;
                    txtUsuario.Text = sesionActual.NombreUsuario;
                    conexionModificada = ConexionHaCambiado();
                    if (!conexionModificada)
                        await autenticacion.CerrarSesionAsync(sesionActual, cancelacion.Token);
                }
                finally
                {
                    principal = null;
                    if (!IsDisposed)
                    {
                        if (ventana.SalirDeAplicacion)
                            Close();
                        else
                            Show();
                    }
                }
            }
            catch (OperationCanceledException) { }
            catch (ArgumentException ex)
            {
                if (!IsDisposed)
                    notificador.Show("Inicio de sesión", ex.Message, KToastKind.Warning);
            }
            catch (InvalidOperationException ex)
            {
                if (!IsDisposed)
                    MostrarErrorConexion(ex.Message);
            }
            catch (Exception)
            {
                if (!IsDisposed)
                    MostrarErrorConexion("No se pudo completar el inicio de sesión. Revisa la conexión y vuelve a intentarlo.");
            }
            finally
            {
                if (!IsDisposed)
                {
                    txtContrasena.Text = "";
                    if (revisarConexion)
                        await PrepararAsync();
                    else
                        CambiarEstado(false);

                    if (!IsDisposed)
                    {
                        if (conexionModificada)
                            notificador.Show("Sesión cerrada", "Cambió la conexión a MySQL. Inicia sesión nuevamente.", KToastKind.Warning);
                        txtContrasena.Focus();
                    }
                }
            }
        }

        private void CambiarEstado(bool trabajando)
        {
            ocupado = trabajando;
            UseWaitCursor = trabajando;
            btnIngresar.Enabled = btnSalir.Enabled = !trabajando;
            btnConfigurarConexion.Enabled = !trabajando;
            txtUsuario.Enabled = txtContrasena.Enabled = chkMostrarContrasena.Enabled = !trabajando;
        }

        private void panelCabecera_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelAcceso_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
