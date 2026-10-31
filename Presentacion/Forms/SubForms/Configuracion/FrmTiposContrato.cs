using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Configuracion;

public partial class FrmTiposContrato : Form
{
    private readonly ServicioTiposContrato servicio = new();
    private SesionUsuario? sesion;
    private uint id;
    public FrmTiposContrato()
    {
        InitializeComponent();
        Load += Tipos_Load;
        btnCerrar.Click += Cerrar_Click;
        btnNuevo.Click += Nuevo_Click;
        btnGuardar.Click += Guardar_Click;
        btnEliminar.Click += Eliminar_Click;
        dgvTiposContrato.SelectionChanged += Seleccion_Changed;
    }
    public void Configurar(SesionUsuario sesion)
    {
        this.sesion = sesion;
    }
    private async void Tipos_Load(object? sender, EventArgs e)
    {
        await CargarAsync();
    }
    private async Task CargarAsync()
    {
        try
        {
            var tipos = await servicio.ListarAsync();
            if (IsDisposed)
                return;
            dgvTiposContrato.Rows.Clear();
            foreach (var tipo in tipos)
            {
                int fila = dgvTiposContrato.Rows.Add(tipo.Nombre, tipo.Activo);
                dgvTiposContrato.Rows[fila].Tag = tipo;
            }
            Nuevo_Click(this, EventArgs.Empty);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private void Seleccion_Changed(object? sender, EventArgs e)
    {
        if (dgvTiposContrato.CurrentRow?.Tag is not TipoContrato tipo)
            return;
        id = tipo.IdTipoContrato;
        txtNombre.Text = tipo.Nombre;
        txtDescripcion.Text = tipo.Descripcion;
        chkActivo.Checked = tipo.Activo;
    }
    private void Nuevo_Click(object? sender, EventArgs e)
    {
        id = 0;
        dgvTiposContrato.ClearSelection();
        dgvTiposContrato.CurrentCell = null;
        txtNombre.Clear();
        txtDescripcion.Clear();
        chkActivo.Checked = true;
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            if (id == 0)
                await servicio.CrearAsync(txtNombre.Text, txtDescripcion.Text, sesion, chkActivo.Checked);
            else
                await servicio.ActualizarAsync(id, txtNombre.Text, txtDescripcion.Text, sesion, chkActivo.Checked);
            await CargarAsync();
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnGuardar.Enabled = true; }
    }
    private async void Eliminar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || id == 0 || !AyudaFormulario.Confirmar(this, "¿Eliminar este tipo de contrato?"))
            return;
        try
        {
            await new ServicioCatalogos().EliminarAsync("tipos_contrato", id, sesion);
            await CargarAsync();
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
