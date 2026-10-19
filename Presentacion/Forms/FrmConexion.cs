using Entidades;
using Negocios;

namespace Presentacion.Forms;

public sealed class FrmConexion : Form
{
    private readonly TextBox txtServidor = new() { MaxLength = 253 };
    private readonly NumericUpDown numPuerto = new() { Minimum = 1, Maximum = 65535, Value = 3306 };
    private readonly TextBox txtBaseDatos = new() { MaxLength = 64 };
    private readonly TextBox txtUsuario = new() { MaxLength = 128 };
    private readonly TextBox txtContrasena = new() { UseSystemPasswordChar = true, MaxLength = 256 };
    private readonly TextBox txtHuella = new() { MaxLength = 95 };
    private readonly Button btnGuardar = new() { Text = "Conectar y guardar", AutoSize = true };
    private readonly Button btnCancelar = new() { Text = "Cancelar", DialogResult = DialogResult.Cancel, AutoSize = true };
    private readonly CancellationTokenSource cancelacion = new();
    private bool guardando;

    public FrmConexion()
    {
        Text = "Conexión a MySQL";
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = MinimizeBox = false;
        ClientSize = new Size(590, 470);
        AutoScaleMode = AutoScaleMode.Font;
        var campos = new TableLayoutPanel
        {
            Dock = DockStyle.Fill, Padding = new Padding(20), ColumnCount = 2, RowCount = 9
        };
        campos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140));
        campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        for (var fila = 0; fila < 9; fila++)
            campos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        AgregarAviso(campos, 0, "Introduce los datos de Clever Cloud. Se guardan únicamente en el Administrador de credenciales de tu usuario de Windows.");
        AgregarCampo(campos, 1, "Servidor", txtServidor);
        AgregarCampo(campos, 2, "Puerto", numPuerto);
        AgregarCampo(campos, 3, "Base de datos", txtBaseDatos);
        AgregarCampo(campos, 4, "Usuario MySQL", txtUsuario);
        AgregarCampo(campos, 5, "Contraseña MySQL", txtContrasena);
        AgregarCampo(campos, 6, "Huella SHA-256", txtHuella);
        AgregarAviso(campos, 7, "Sin huella se validan la autoridad y el nombre del servidor. Para un certificado propio del proveedor, utiliza su huella verificada por un canal de confianza.");
        var botones = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft, AutoSize = true };
        botones.Controls.AddRange([btnCancelar, btnGuardar]);
        campos.Controls.Add(botones, 0, 8);
        campos.SetColumnSpan(botones, 2);
        Controls.Add(campos);
        AcceptButton = btnGuardar;
        CancelButton = btnCancelar;
        btnGuardar.Click += Guardar_Click;
        Shown += (_, _) => CargarConfiguracionLocal();
        FormClosing += (_, e) => e.Cancel = guardando && e.CloseReason == CloseReason.UserClosing;
        FormClosed += (_, _) => { cancelacion.Cancel(); cancelacion.Dispose(); };
    }

    private void CargarConfiguracionLocal()
    {
        try
        {
            var configuracion = new ServicioConexion().LeerConfiguracionLocal();
            if (configuracion is null)
                return;
            txtServidor.Text = configuracion.Servidor;
            numPuerto.Value = Math.Clamp(configuracion.Puerto, 1, 65535);
            txtBaseDatos.Text = configuracion.BaseDatos;
            txtUsuario.Text = configuracion.Usuario;
            txtContrasena.Text = configuracion.Contrasena;
            txtHuella.Text = configuracion.HuellaCertificadoSha256;
            configuracion.Contrasena = "";
        }
        catch (Exception)
        {
            MessageBox.Show(this, "No se pudo leer la conexión local. Puedes introducir los datos nuevamente.",
                "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private static void AgregarCampo(TableLayoutPanel panel, int fila, string nombre, Control editor)
    {
        panel.Controls.Add(new Label { Text = nombre, AutoSize = true, Anchor = AnchorStyles.Left }, 0, fila);
        editor.Dock = DockStyle.Top;
        editor.Margin = new Padding(3, 10, 3, 6);
        panel.Controls.Add(editor, 1, fila);
    }

    private static void AgregarAviso(TableLayoutPanel panel, int fila, string texto)
    {
        var aviso = new Label { Text = texto, Dock = DockStyle.Fill, AutoSize = true, Margin = new Padding(3, 3, 3, 15) };
        panel.Controls.Add(aviso, 0, fila);
        panel.SetColumnSpan(aviso, 2);
    }

    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (guardando)
            return;
        guardando = true;
        btnGuardar.Enabled = btnCancelar.Enabled = false;
        UseWaitCursor = true;
        var configuracion = new ConfiguracionBaseDatos
        {
            Servidor = txtServidor.Text, Puerto = (uint)numPuerto.Value,
            BaseDatos = txtBaseDatos.Text, Usuario = txtUsuario.Text, Contrasena = txtContrasena.Text,
            HuellaCertificadoSha256 = txtHuella.Text
        };
        try
        {
            await new ServicioConexion().GuardarAsync(configuracion, cancelacion.Token);
            txtContrasena.Clear();
            guardando = false;
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
        {
            MessageBox.Show(this, ex.Message, "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "No se pudo guardar la conexión. Revisa la configuración de Windows y vuelve a intentarlo.",
                "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            configuracion.Contrasena = "";
            guardando = false;
            if (!IsDisposed)
            {
                btnGuardar.Enabled = btnCancelar.Enabled = true;
                UseWaitCursor = false;
            }
        }
    }
}
