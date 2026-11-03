using System;
using System.Globalization;
using Entidades;
using KovaqsUI.Controls;
using Negocios;
using KovaqsUI.Components;

namespace Presentacion.Forms
{
    public partial class FrmConfigurarConexion : Form
    {
        private readonly ServicioConexion servicioConexion = new();
        private readonly CancellationTokenSource cancelacion = new();
        private readonly KTextBox[] campos;
        private bool guardando;
        private bool credencialesVisibles;

        public FrmConfigurarConexion()
        {
            InitializeComponent();
            campos = [txtServidor, numPuerto, txtBaseDatos, txtUsuario, txtContrasena, txtHuella];
            txtServidor.MaxLength = 253;
            txtBaseDatos.MaxLength = 64;
            txtUsuario.MaxLength = 128;
            txtContrasena.MaxLength = 256;
            txtHuella.MaxLength = 95;
            numPuerto.Text = "3306";

            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnGuardar.Click += Guardar_Click;
            btnMostrar.Click += (_, _) => MostrarCredenciales(!credencialesVisibles);
            btnCancelar.Click += (_, _) => Close();
            Shown += (_, _) => CargarConfiguracionLocal();
            FormClosing += (_, e) =>
            {
                if (guardando && e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
            };
            FormClosed += (_, _) =>
            {
                cancelacion.Cancel();
                foreach (var campo in campos)
                    campo.Text = "";
            };
            Disposed += (_, _) => { cancelacion.Cancel(); cancelacion.Dispose(); };
            MostrarCredenciales(false);
        }

        private void CargarConfiguracionLocal()
        {
            ConfiguracionBaseDatos? configuracion = null;
            try
            {
                configuracion = servicioConexion.LeerConfiguracionLocal();
                if (configuracion is null)
                    return;

                txtServidor.Text = configuracion.Servidor;
                numPuerto.Text = configuracion.Puerto.ToString(CultureInfo.InvariantCulture);
                txtBaseDatos.Text = configuracion.BaseDatos;
                txtUsuario.Text = configuracion.Usuario;
                txtContrasena.Text = configuracion.Contrasena;
                txtHuella.Text = configuracion.HuellaCertificadoSha256;
            }
            catch (Exception)
            {
                notificador.Show("Conexión", "No se pudo leer la conexión local. Introduce los datos nuevamente.", KToastKind.Warning);
            }
            finally
            {
                if (configuracion is not null)
                    configuracion.Contrasena = "";
            }
        }

        private void MostrarCredenciales(bool mostrar)
        {
            credencialesVisibles = mostrar;
            foreach (var campo in campos)
            {
                campo.PasswordChar = mostrar ? '\0' : '●';
                campo.UseSystemPasswordChar = !mostrar;
            }
            btnMostrar.Text = mostrar ? "Ocultar" : "Mostrar";
        }

        private async void Guardar_Click(object? sender, EventArgs e)
        {
            if (guardando)
                return;

            if (!uint.TryParse(numPuerto.Text.Trim(), NumberStyles.None, CultureInfo.InvariantCulture, out var puerto)
                || puerto is 0 or > 65535)
            {
                notificador.Show("Conexión", "El puerto debe ser un número entero entre 1 y 65535.", KToastKind.Warning);
                numPuerto.Focus();
                return;
            }

            var configuracion = new ConfiguracionBaseDatos
            {
                Servidor = txtServidor.Text,
                Puerto = puerto,
                BaseDatos = txtBaseDatos.Text,
                Usuario = txtUsuario.Text,
                Contrasena = txtContrasena.Text,
                HuellaCertificadoSha256 = txtHuella.Text
            };
            var token = cancelacion.Token;
            MostrarCredenciales(false);
            CambiarEstado(true);
            try
            {
                await servicioConexion.GuardarAsync(configuracion, token);
                if (IsDisposed || Disposing || token.IsCancellationRequested)
                    return;

                guardando = false;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (OperationCanceledException) { }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
            {
                if (!IsDisposed && !Disposing && Visible)
                    notificador.Show("Conexión", ex.Message, KToastKind.Warning);
            }
            catch (Exception)
            {
                if (!IsDisposed && !Disposing && Visible)
                    notificador.Show("Conexión", "No se pudo guardar la conexión. Revisa la configuración y vuelve a intentarlo.", KToastKind.Error);
            }
            finally
            {
                configuracion.Contrasena = "";
                guardando = false;
                if (!IsDisposed && !Disposing)
                    CambiarEstado(false);
            }
        }

        private void CambiarEstado(bool trabajando)
        {
            guardando = trabajando;
            UseWaitCursor = trabajando;
            btnGuardar.Enabled = btnCancelar.Enabled = btnMostrar.Enabled = !trabajando;
            foreach (var campo in campos)
                campo.Enabled = !trabajando;
        }
    }
}
