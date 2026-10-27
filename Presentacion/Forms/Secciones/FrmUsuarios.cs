using System.ComponentModel;
using Entidades;
using Negocios;
using Presentacion.Forms.SubForms;

namespace Presentacion.Forms.Secciones;

public partial class FrmUsuarios : Form
{
    private readonly ServicioUsuarios servicioUsuarios = new();
    private readonly CancellationTokenSource cancelacion = new();
    private bool cargando;
    private SesionUsuario? sesion;

    public FrmUsuarios()
    {
        InitializeComponent();
        btnAgregarUsuario.Click += AgregarUsuario_Click;
        Disposed += (_, _) => { cancelacion.Cancel(); cancelacion.Dispose(); };
        if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            ConfigurarColumnas();
    }

    public void EstablecerSesion(SesionUsuario sesionActual)
    {
        sesion = sesionActual;
    }

    private async void AgregarUsuario_Click(object? sender, EventArgs e)
    {
        if (cargando)
            return;
        if (sesion is null)
        {
            MessageBox.Show(this, "Inicia sesión antes de crear un usuario.", "Usuarios",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        using var formulario = new FrmCrearUsuario(sesion);
        if (formulario.ShowDialog(TopLevelControl as Form ?? this) == DialogResult.OK)
            await CargarUsuariosAsync();
    }

    protected override async void OnVisibleChanged(EventArgs e)
    {
        base.OnVisibleChanged(e);
        if (!Visible || !IsHandleCreated || IsDisposed || Disposing || cargando
            || DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            return;

        await CargarUsuariosAsync();
    }

    private void ConfigurarColumnas()
    {
        dgvUsuarios.AutoGenerateColumns = false;
        dgvUsuarios.ReadOnly = true;
        dgvUsuarios.AllowUserToAddRows = false;
        dgvUsuarios.AllowUserToDeleteRows = false;
        dgvUsuarios.Columns.AddRange(
            new DataGridViewTextBoxColumn
            {
                Name = nameof(UsuarioListado.IdUsuario),
                DataPropertyName = nameof(UsuarioListado.IdUsuario),
                HeaderText = "ID",
                Width = 60
            },
            new DataGridViewTextBoxColumn
            {
                Name = nameof(UsuarioListado.NombreUsuario),
                DataPropertyName = nameof(UsuarioListado.NombreUsuario),
                HeaderText = "Usuario",
                Width = 160
            },
            new DataGridViewTextBoxColumn
            {
                Name = nameof(UsuarioListado.NombreEmpleado),
                DataPropertyName = nameof(UsuarioListado.NombreEmpleado),
                HeaderText = "Empleado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 180,
                DefaultCellStyle = new DataGridViewCellStyle { NullValue = "Sin empleado asociado" }
            },
            new DataGridViewTextBoxColumn
            {
                Name = nameof(UsuarioListado.Rol),
                DataPropertyName = nameof(UsuarioListado.Rol),
                HeaderText = "Rol",
                Width = 160
            },
            new DataGridViewCheckBoxColumn
            {
                Name = nameof(UsuarioListado.Activo),
                DataPropertyName = nameof(UsuarioListado.Activo),
                HeaderText = "Activo",
                Width = 70
            },
            new DataGridViewTextBoxColumn
            {
                Name = nameof(UsuarioListado.UltimoAcceso),
                DataPropertyName = nameof(UsuarioListado.UltimoAcceso),
                HeaderText = "Último acceso",
                Width = 170,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm", NullValue = "Nunca" }
            });
        dgvUsuarios.CellFormatting += (_, e) =>
        {
            if (e.ColumnIndex == dgvUsuarios.Columns[nameof(UsuarioListado.UltimoAcceso)]!.Index
                && e.Value is DateTime fecha)
                e.Value = fecha.ToLocalTime();
        };
    }

    private async Task CargarUsuariosAsync()
    {
        cargando = true;
        UseWaitCursor = true;
        dgvUsuarios.Enabled = false;
        btnAgregarUsuario.Enabled = false;
        dgvUsuarios.DataSource = null;
        var token = cancelacion.Token;
        try
        {
            var usuarios = await servicioUsuarios.ListarAsync(token);
            if (!IsDisposed && !Disposing && !token.IsCancellationRequested)
                dgvUsuarios.DataSource = usuarios;
        }
        catch (OperationCanceledException) { }
        catch (Exception)
        {
            if (!IsDisposed && !Disposing && Visible)
                MessageBox.Show(this, "No se pudieron cargar los usuarios. Revisa la conexión y vuelve a entrar a esta sección.",
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            cargando = false;
            if (!IsDisposed && !Disposing)
            {
                dgvUsuarios.Enabled = true;
                btnAgregarUsuario.Enabled = true;
                UseWaitCursor = false;
            }
        }
    }

    private void FrmUsuarios_Load(object sender, EventArgs e)
    {

    }
}
