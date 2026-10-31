using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Configuracion;

public partial class FrmRoles : Form
{
    private readonly ServicioRoles servicio = new();
    private SesionUsuario? sesion;
    private List<PermisoSistema> permisos = new();
    private uint id;
    public FrmRoles()
    {
        InitializeComponent();
        Load += Roles_Load;
        btnGuardar.Click += Guardar_Click;
        btnCancelar.Click += Nuevo_Click;
        btnCerrar.Click += Cerrar_Click;
        dgvRoles.SelectionChanged += Seleccion_Changed;
    }
    public void Configurar(SesionUsuario sesion)
    {
        this.sesion = sesion;
    }
    private async void Roles_Load(object? sender, EventArgs e)
    {
        if (sesion is null)
            return;
        try
        {
            permisos = await servicio.PermisosAsync(sesion);
            await CargarAsync();
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async Task CargarAsync()
    {
        var roles = await servicio.ListarAsync();
        if (IsDisposed)
            return;
        dgvRoles.Rows.Clear();
        foreach (var rol in roles)
        {
            int fila = dgvRoles.Rows.Add(rol.Nombre, rol.Activo);
            dgvRoles.Rows[fila].Tag = rol;
        }
        Nuevo_Click(this, EventArgs.Empty);
    }
    private void PintarPermisos(RolAdministracion? rol)
    {
        dgvPermisos.Rows.Clear();
        foreach (var permiso in permisos)
        {
            int fila = dgvPermisos.Rows.Add(rol?.Nombre == "Administrador" || rol?.Permisos.Contains(permiso.Id) == true, permiso.Nombre);
            dgvPermisos.Rows[fila].Tag = permiso;
        }
        dgvPermisos.ReadOnly = rol?.Nombre == "Administrador";
    }
    private void Seleccion_Changed(object? sender, EventArgs e)
    {
        if (dgvRoles.CurrentRow?.Tag is not RolAdministracion rol)
            return;
        id = rol.IdRol;
        txtNombre.Text = rol.Nombre;
        txtDescripcion.Text = rol.Descripcion;
        chkActivo.Checked = rol.Activo;
        PintarPermisos(rol);
    }
    private void Nuevo_Click(object? sender, EventArgs e)
    {
        id = 0;
        dgvRoles.ClearSelection();
        dgvRoles.CurrentCell = null;
        txtNombre.Clear();
        txtDescripcion.Clear();
        chkActivo.Checked = true;
        PintarPermisos(null);
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        dgvPermisos.EndEdit();
        try
        {
            var rol = new RolAdministracion { IdRol = id, Nombre = txtNombre.Text, Descripcion = txtDescripcion.Text, Activo = chkActivo.Checked };
            foreach (DataGridViewRow fila in dgvPermisos.Rows)
                if (fila.Tag is PermisoSistema permiso && Convert.ToBoolean(fila.Cells[0].Value))
                    rol.Permisos.Add(permiso.Id);
            await servicio.GuardarAsync(rol, sesion);
            await CargarAsync();
            notificador.Show("Roles", "Rol guardado. Sus usuarios verán los permisos al iniciar sesión nuevamente.", KovaqsUI.Components.KToastKind.Success);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnGuardar.Enabled = true; }
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
