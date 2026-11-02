using Presentacion.Forms.SubForms.Usuarios;
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
        dgvUsuarios.CellDoubleClick += EditarUsuario_CellDoubleClick;
        cboRol.SelectedIndexChanged += FiltroRol_Changed;
        VisibleChanged += Usuarios_VisibleChanged;
        Disposed += (_, _) => { cancelacion.Cancel(); cancelacion.Dispose(); };
        if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            ConfigurarColumnas();
    }

    public void EstablecerSesion(SesionUsuario sesionActual)
    {
        sesion = sesionActual;
        btnAgregarUsuario.Enabled = !cargando && sesion.Puede("usuarios");
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

    private async void Usuarios_VisibleChanged(object? sender, EventArgs e)
    {
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
                e.Value = fecha.AddHours(-6);
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
            {
                listaUsuarios = usuarios;
                string filtro = cboRol.Text;
                cboRol.Items.Clear();
                cboRol.Items.Add("Todos");
                foreach (var usuario in usuarios)
                    if (!cboRol.Items.Contains(usuario.Rol))
                        cboRol.Items.Add(usuario.Rol);
                cboRol.SelectedItem = cboRol.Items.Contains(filtro) ? filtro : "Todos";
                FiltroRol_Changed(this, EventArgs.Empty);
            }
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
                btnAgregarUsuario.Enabled = sesion?.Puede("usuarios") == true;
                UseWaitCursor = false;
            }
        }
    }

    private void FrmUsuarios_Load(object sender, EventArgs e)
    {

    }

    private List<UsuarioListado> listaUsuarios = new();
    private void FiltroRol_Changed(object? sender, EventArgs e)
    {
        var filtrados = new List<UsuarioListado>();
        foreach (var usuario in listaUsuarios)
            if (cboRol.Text == "Todos" || cboRol.Text == usuario.Rol)
                filtrados.Add(usuario);
        dgvUsuarios.DataSource = filtrados;
    }
    private async void EditarUsuario_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (sesion is null || cargando || e.RowIndex < 0 || dgvUsuarios.Rows[e.RowIndex].DataBoundItem is not UsuarioListado usuario)
            return;
        using var formulario = new FrmEditarUsuario();
        formulario.Configurar(sesion, usuario.IdUsuario);
        if (formulario.ShowDialog(TopLevelControl as Form ?? this) == DialogResult.OK)
            await CargarUsuariosAsync();
    }
}
