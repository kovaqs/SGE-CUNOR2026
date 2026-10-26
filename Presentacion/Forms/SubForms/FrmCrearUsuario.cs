using System;
using System.ComponentModel;
using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms
{
    public partial class FrmCrearUsuario : Form
    {
        private readonly ServicioUsuarios servicioUsuarios = new();
        private readonly CancellationTokenSource cancelacion = new();
        private readonly SesionUsuario? sesion;
        private bool guardando;
        private bool opcionesCargadas;

        public FrmCrearUsuario()
        {
            InitializeComponent();
            txtNombreUsuario.MaxLength = 50;
            txtNombreUsuario.PasswordChar = '\0';
            txtNombreUsuario.UseSystemPasswordChar = false;
            txtContrasena.MaxLength = txtConfirmarContrasena.MaxLength = 128;
            chkActivo.Checked = true;
            chkMostrarContrasena.Checked = false;
            MostrarContrasenas();

            AcceptButton = btnGuardar;
            CancelButton = btnCancelar;
            btnGuardar.DialogResult = DialogResult.None;
            btnCancelar.DialogResult = btnCerrar.DialogResult = DialogResult.Cancel;
            btnCancelar.Click += (_, _) => Close();
            btnCerrar.Click += (_, _) => Close();
            btnGuardar.Click += Guardar_Click;
            chkMostrarContrasena.CheckedChanged += (_, _) => MostrarContrasenas();
            Shown += async (_, _) =>
            {
                if (!DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
                    await CargarOpcionesAsync();
            };
            FormClosing += (_, e) =>
            {
                if (guardando && e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
            };
            FormClosed += (_, _) => txtContrasena.Text = txtConfirmarContrasena.Text = "";
            Disposed += (_, _) => { cancelacion.Cancel(); cancelacion.Dispose(); };
            btnGuardar.Enabled = false;
        }

        public FrmCrearUsuario(SesionUsuario sesionActual) : this()
        {
            sesion = sesionActual;
        }

        private async Task CargarOpcionesAsync()
        {
            CambiarEstado(true);
            lblEstado.Text = "Cargando roles y empleados...";
            var token = cancelacion.Token;
            try
            {
                var roles = await servicioUsuarios.ListarRolesAsync(token);
                var empleados = await servicioUsuarios.ListarEmpleadosDisponiblesAsync(token);
                if (IsDisposed || Disposing || token.IsCancellationRequested)
                    return;

                cboRol.DisplayMember = nameof(Rol.Nombre);
                cboRol.ValueMember = nameof(Rol.IdRol);
                cboRol.DataSource = roles;
                cboRol.SelectedIndex = -1;
                empleados.Insert(0, new EmpleadoSeleccion(null, "Sin empleado asociado"));
                cboEmpleado.DisplayMember = nameof(EmpleadoSeleccion.Nombre);
                cboEmpleado.ValueMember = nameof(EmpleadoSeleccion.IdEmpleado);
                cboEmpleado.DataSource = empleados;
                opcionesCargadas = roles.Count > 0;
                lblEstado.Text = opcionesCargadas ? "" : "No hay roles activos. Contacta al administrador.";
                txtNombreUsuario.Focus();
            }
            catch (OperationCanceledException) { }
            catch (Exception)
            {
                if (!IsDisposed && !Disposing)
                    lblEstado.Text = "No se pudieron cargar los roles y empleados.";
            }
            finally
            {
                if (!IsDisposed && !Disposing)
                    CambiarEstado(false);
            }
        }

        private void MostrarContrasenas()
        {
            var mostrar = chkMostrarContrasena.Checked;
            txtContrasena.PasswordChar = txtConfirmarContrasena.PasswordChar = mostrar ? '\0' : '●';
            txtContrasena.UseSystemPasswordChar = txtConfirmarContrasena.UseSystemPasswordChar = !mostrar;
        }

        private async void Guardar_Click(object? sender, EventArgs e)
        {
            if (guardando || !opcionesCargadas)
                return;
            if (sesion is null)
            {
                lblEstado.Text = "Inicia sesión antes de crear un usuario.";
                return;
            }
            if (cboRol.SelectedItem is not Rol rol || cboEmpleado.SelectedItem is not EmpleadoSeleccion empleado)
            {
                lblEstado.Text = "Selecciona un rol y la opción de empleado.";
                return;
            }
            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                lblEstado.Text = "Las contraseñas no coinciden.";
                txtConfirmarContrasena.Focus();
                return;
            }

            guardando = true;
            chkMostrarContrasena.Checked = false;
            CambiarEstado(true);
            lblEstado.Text = "Guardando usuario...";
            var token = cancelacion.Token;
            try
            {
                await servicioUsuarios.CrearAsync(txtNombreUsuario.Text, txtContrasena.Text, rol.IdRol,
                    empleado.IdEmpleado, chkActivo.Checked, sesion, token);
                if (IsDisposed || Disposing || token.IsCancellationRequested)
                    return;

                guardando = false;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (OperationCanceledException) { }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
            {
                if (!IsDisposed && !Disposing)
                    lblEstado.Text = ex.Message;
            }
            catch (Exception)
            {
                if (!IsDisposed && !Disposing)
                    lblEstado.Text = "No se pudo guardar el usuario. Inténtalo de nuevo.";
            }
            finally
            {
                guardando = false;
                if (!IsDisposed && !Disposing)
                    CambiarEstado(false);
            }
        }

        private void CambiarEstado(bool trabajando)
        {
            UseWaitCursor = trabajando;
            btnGuardar.Enabled = !trabajando && opcionesCargadas;
            btnCancelar.Enabled = btnCerrar.Enabled = !guardando;
            txtNombreUsuario.Enabled = txtContrasena.Enabled = txtConfirmarContrasena.Enabled = !trabajando;
            cboRol.Enabled = cboEmpleado.Enabled = chkActivo.Enabled = chkMostrarContrasena.Enabled = !trabajando;
        }

        private void chkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
