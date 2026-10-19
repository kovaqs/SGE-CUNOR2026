using Negocios;

namespace Presentacion.Forms;

public sealed class FrmUsuarioInicial : Form
{
    private readonly TextBox txtContrasena = new() { UseSystemPasswordChar = true, MaxLength = 128, Dock = DockStyle.Fill };
    private readonly TextBox txtConfirmacion = new() { UseSystemPasswordChar = true, MaxLength = 128, Dock = DockStyle.Fill };
    private readonly Button btnCrear = new() { Text = "Crear administrador", AutoSize = true };
    private readonly Button btnCancelar = new() { Text = "Cancelar", DialogResult = DialogResult.Cancel, AutoSize = true };
    private readonly CancellationTokenSource cancelacion = new();
    private bool creando;

    public FrmUsuarioInicial()
    {
        Text = "Primer acceso";
        ClientSize = new Size(490, 270);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = MinimizeBox = false;
        AutoScaleMode = AutoScaleMode.Font;
        var campos = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(20), ColumnCount = 2, RowCount = 5 };
        campos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145));
        campos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        for (var fila = 0; fila < 5; fila++)
            campos.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        var aviso = new Label
        {
            Text = "Crea la contraseña del usuario admin (mínimo 12 caracteres). Este paso solo está disponible mientras no existan usuarios.",
            AutoSize = true, Dock = DockStyle.Fill, Margin = new Padding(3, 3, 3, 20)
        };
        campos.Controls.Add(aviso, 0, 0);
        campos.SetColumnSpan(aviso, 2);
        campos.Controls.Add(new Label { Text = "Usuario", AutoSize = true }, 0, 1);
        campos.Controls.Add(new TextBox { Text = "admin", ReadOnly = true, Dock = DockStyle.Fill }, 1, 1);
        campos.Controls.Add(new Label { Text = "Contraseña", AutoSize = true }, 0, 2);
        campos.Controls.Add(txtContrasena, 1, 2);
        campos.Controls.Add(new Label { Text = "Confirmar contraseña", AutoSize = true }, 0, 3);
        campos.Controls.Add(txtConfirmacion, 1, 3);
        var botones = new FlowLayoutPanel { AutoSize = true, Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft };
        botones.Controls.AddRange([btnCancelar, btnCrear]);
        campos.Controls.Add(botones, 0, 4);
        campos.SetColumnSpan(botones, 2);
        Controls.Add(campos);
        AcceptButton = btnCrear;
        CancelButton = btnCancelar;
        btnCrear.Click += Crear_Click;
        Shown += (_, _) => txtContrasena.Focus();
        FormClosing += (_, e) => e.Cancel = creando && e.CloseReason == CloseReason.UserClosing;
        FormClosed += (_, _) => { cancelacion.Cancel(); cancelacion.Dispose(); };
    }

    private async void Crear_Click(object? sender, EventArgs e)
    {
        if (creando)
            return;
        if (txtContrasena.Text != txtConfirmacion.Text)
        {
            MessageBox.Show(this, "Las contraseñas no coinciden.", "Primer acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        creando = true;
        btnCrear.Enabled = btnCancelar.Enabled = false;
        UseWaitCursor = true;
        try
        {
            await new ServicioAutenticacion().CrearAdministradorAsync(txtContrasena.Text, cancelacion.Token);
            txtContrasena.Clear();
            txtConfirmacion.Clear();
            creando = false;
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
        {
            MessageBox.Show(this, ex.Message, "Primer acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception)
        {
            MessageBox.Show(this, "No se pudo crear el administrador. Vuelve a intentar iniciar la aplicación.",
                "Primer acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            creando = false;
            if (!IsDisposed)
            {
                btnCrear.Enabled = btnCancelar.Enabled = true;
                UseWaitCursor = false;
            }
        }
    }
}
