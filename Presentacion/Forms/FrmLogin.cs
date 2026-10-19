using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly ServicioAutenticacion autenticacion = new();
        private readonly CancellationTokenSource cancelacion = new();
        private bool ocupado;
        private bool preparado;

        public FrmLogin()
        {
            InitializeComponent();
            AcceptButton = kButton1;
            CancelButton = kButton2;
            kButton1.Click += Ingresar_Click;
            kButton2.Click += (_, _) => Close();
            kLabel4.Click += ConfigurarConexion_Click;
            kCheckBox1.CheckedChanged += (_, _) =>
            {
                kTextBox2.PasswordChar = kCheckBox1.Checked ? '\0' : '●';
                kTextBox2.UseSystemPasswordChar = !kCheckBox1.Checked;
            };
            FormClosed += (_, _) => { cancelacion.Cancel(); cancelacion.Dispose(); };
        }

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);
            await PrepararAsync();
        }

        private async Task PrepararAsync()
        {
            CambiarEstado(true);
            preparado = false;
            try
            {
                if (!new ServicioConexion().EstaConfigurada)
                {
                    using var conexion = new FrmConexion();
                    if (conexion.ShowDialog(this) != DialogResult.OK)
                    {
                        Close();
                        return;
                    }
                }
                if (!await autenticacion.HayUsuariosAsync(cancelacion.Token))
                {
                    using var inicial = new FrmUsuarioInicial();
                    if (inicial.ShowDialog(this) != DialogResult.OK)
                    {
                        Close();
                        return;
                    }
                    kTextBox1.Text = "admin";
                    kLabel2.Text = "Cuenta creada. Introduce tu contraseña para ingresar.";
                }
                else
                    kLabel2.Text = "Introduce tus credenciales para empezar";
                preparado = true;
                kTextBox2.Focus();
            }
            catch (OperationCanceledException) { }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
            {
                if (!IsDisposed)
                    MessageBox.Show(this, ex.Message, "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                if (!IsDisposed)
                    MessageBox.Show(this, "No se pudo preparar el acceso. Revisa la configuración de conexión.",
                        "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                var sesion = await autenticacion.IniciarSesionAsync(kTextBox1.Text, kTextBox2.Text, cancelacion.Token);
                kTextBox2.Text = "";
                kCheckBox1.Checked = false;
                if (sesion is null)
                {
                    kLabel2.Text = "Usuario o contraseña incorrectos, o cuenta inactiva.";
                    await Task.Delay(1500, cancelacion.Token);
                    return;
                }
                Hide();
                try
                {
                    using var principal = new FrmPrincipal(sesion);
                    principal.ShowDialog();
                    await autenticacion.CerrarSesionAsync(sesion, cancelacion.Token);
                }
                finally
                {
                    if (!IsDisposed)
                        Show();
                }
                kLabel2.Text = "Sesión cerrada. Puedes volver a ingresar.";
            }
            catch (OperationCanceledException) { }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
            {
                if (!IsDisposed)
                    MessageBox.Show(this, ex.Message, "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                if (!IsDisposed)
                    MessageBox.Show(this, "No se pudo completar el inicio de sesión. Vuelve a intentarlo.",
                        "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (!IsDisposed)
                {
                    kTextBox2.Text = "";
                    CambiarEstado(false);
                    kTextBox2.Focus();
                }
            }
        }

        private async void ConfigurarConexion_Click(object? sender, EventArgs e)
        {
            if (ocupado)
                return;
            using var conexion = new FrmConexion();
            if (conexion.ShowDialog(this) == DialogResult.OK)
                await PrepararAsync();
        }

        private void CambiarEstado(bool trabajando)
        {
            ocupado = trabajando;
            UseWaitCursor = trabajando;
            kButton1.Enabled = kButton2.Enabled = kLabel4.Enabled = !trabajando;
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
