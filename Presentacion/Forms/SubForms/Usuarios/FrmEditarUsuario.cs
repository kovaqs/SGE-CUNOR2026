using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Usuarios;

public partial class FrmEditarUsuario : Form
{
    private readonly ServicioUsuarios servicio = new();
    private SesionUsuario? sesion;
    private UsuarioEdicion? usuario;
    private uint id;
    public FrmEditarUsuario()
    {
        InitializeComponent();
        Load += Usuario_Load;
        btnGuardar.Click += Guardar_Click;
        btnRestablecerContrasena.Click += Restablecer_Click;
        btnCerrar.Click += Cerrar_Click;
        btnCancelar.Click += Cerrar_Click;
    }
    public void Configurar(SesionUsuario sesion, uint id)
    {
        this.sesion = sesion;
        this.id = id;
    }
    private async void Usuario_Load(object? sender, EventArgs e)
    {
        btnGuardar.Enabled = false;
        try
        {
            usuario = await servicio.LeerEdicionAsync(id);
            cboRol.DisplayMember = nameof(Rol.Nombre);
            cboRol.ValueMember = nameof(Rol.IdRol);
            cboRol.DataSource = await servicio.ListarRolesAsync();
            cboRol.SelectedValue = usuario.IdRol;
            AyudaFormulario.CargarCombo(cboEmpleado, await new ServicioCatalogos().OpcionesAsync("empleados", 0, true), "Sin empleado");
            if (IsDisposed)
                return;
            cboEmpleado.SelectedValue = usuario.IdEmpleado ?? 0;
            txtNombreUsuario.Text = usuario.NombreUsuario;
            chkActivo.Checked = usuario.Activo;
            btnGuardar.Enabled = true;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || usuario is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.IdRol = Convert.ToUInt32(cboRol.SelectedValue ?? 0);
            uint empleado = AyudaFormulario.IdSeleccionado(cboEmpleado);
            usuario.IdEmpleado = empleado == 0 ? null : empleado;
            usuario.Activo = chkActivo.Checked;
            await servicio.GuardarEdicionAsync(usuario, sesion);
            if (!IsDisposed)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnGuardar.Enabled = true; }
    }
    private void Restablecer_Click(object? sender, EventArgs e)
    {
        if (sesion is null || usuario is null)
            return;
        using var formulario = new FrmRestablecerContrasena();
        formulario.Configurar(sesion, usuario.IdUsuario, usuario.NombreUsuario);
        formulario.ShowDialog(this);
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
