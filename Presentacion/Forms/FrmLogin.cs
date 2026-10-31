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
            AcceptButton = kButton1;
            CancelButton = kButton2;
            kButton1.Click += Ingresar_Click;
            kButton2.Click += (_, _) => Close();
            kCheckBox1.CheckedChanged += (_, _) =>
            {
                kTextBox2.PasswordChar = kCheckBox1.Checked ? '\0' : '●';
                kTextBox2.UseSystemPasswordChar = !kCheckBox1.Checked;
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
                    kLabel2.Text = "Configura la conexión a MySQL para empezar.";
                    return;
                }
                preparado = await autenticacion.HayUsuariosAsync(cancelacion.Token);
                if (ConexionHaCambiado())
                {
                    MostrarErrorConexion("La configuración cambió. Comprueba de nuevo la conexión.");
                    return;
                }
                btnConfigurarConexion.Visible = false;
                kLabel2.Text = preparado
                    ? "Introduce tus credenciales para empezar"
                    : "No hay usuarios registrados. Contacta al administrador.";
                if (preparado)
                    kTextBox2.Focus();
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
                    kButton1.Text = preparado ? "Iniciar sesión" : "Reintentar";
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
                kTextBox2.Text = "";
                kCheckBox1.Checked = false;
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
            kButton1.Text = "Reintentar";
            kLabel2.Text = "No se pudo comprobar la conexión. Puedes revisarla o reintentar.";
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
                var sesion = await autenticacion.IniciarSesionAsync(kTextBox1.Text, kTextBox2.Text, cancelacion.Token);
                kTextBox2.Text = "";
                kCheckBox1.Checked = false;
                if (sesion is null)
                {
                    kLabel2.Text = "Usuario o contraseña incorrectos, o cuenta inactiva.";
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
                    kTextBox1.Text = sesionActual.NombreUsuario;
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
                    kTextBox2.Text = "";
                    if (revisarConexion)
                        await PrepararAsync();
                    else
                        CambiarEstado(false);

                    if (!IsDisposed)
                    {
                        if (conexionModificada)
                            notificador.Show("Sesión cerrada", "Cambió la conexión a MySQL. Inicia sesión nuevamente.", KToastKind.Warning);
                        kTextBox2.Focus();
                    }
                }
            }
        }

        private void CambiarEstado(bool trabajando)
        {
            ocupado = trabajando;
            UseWaitCursor = trabajando;
            kButton1.Enabled = kButton2.Enabled = !trabajando;
            btnConfigurarConexion.Enabled = !trabajando;
            kTextBox1.Enabled = kTextBox2.Enabled = kCheckBox1.Enabled = !trabajando;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
