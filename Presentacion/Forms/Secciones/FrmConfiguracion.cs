using Entidades;
using Negocios;
using Presentacion.Forms.SubForms.Configuracion;

namespace Presentacion.Forms.Secciones;

public partial class FrmConfiguracion : Form
{
    private SesionUsuario? sesion;
    public FrmConfiguracion()
    {
        InitializeComponent();
        Load += Configuracion_Load;
        btnGuardarEmpresa.Click += GuardarEmpresa_Click;
        btnTiposContrato.Click += TiposContrato_Click;
        btnHorarios.Click += Horarios_Click;
        btnRoles.Click += Roles_Click;
        btnBitacora.Click += Bitacora_Click;
    }
    public void EstablecerSesion(SesionUsuario sesion)
    {
        this.sesion = sesion;
        btnConexion.Enabled = sesion.Rol == "Administrador";
    }
    private async void Configuracion_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        try
        {
            var empresa = await new ServicioCatalogos().LeerEmpresaAsync();
            if (IsDisposed)
                return;
            txtNombreEmpresa.Text = empresa.Nombre;
            txtNit.Text = empresa.Nit;
            txtDireccion.Text = empresa.Direccion;
            txtTelefono.Text = empresa.Telefono;
            txtCorreo.Text = empresa.Correo;
            cboMoneda.SelectedIndex = 0;
            cboZonaHoraria.SelectedIndex = 0;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async void GuardarEmpresa_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardarEmpresa.Enabled)
            return;
        btnGuardarEmpresa.Enabled = false;
        try
        {
            await new ServicioCatalogos().GuardarEmpresaAsync(new Empresa
            {
                Nombre = txtNombreEmpresa.Text,
                Nit = txtNit.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            }, sesion);
            if (!IsDisposed)
                notificador.Show("Configuración", "Datos de la empresa guardados.", KovaqsUI.Components.KToastKind.Success);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnGuardarEmpresa.Enabled = true; }
    }
    private void TiposContrato_Click(object? sender, EventArgs e)
    {
        if (sesion is null)
            return;
        using var formulario = new FrmTiposContrato();
        formulario.Configurar(sesion);
        formulario.ShowDialog(TopLevelControl as Form ?? this);
    }
    private void Horarios_Click(object? sender, EventArgs e)
    {
        if (sesion is null)
            return;
        using var formulario = new FrmHorarios();
        formulario.EstablecerSesion(sesion);
        formulario.ShowDialog(TopLevelControl as Form ?? this);
    }
    private void Roles_Click(object? sender, EventArgs e)
    {
        if (sesion is null)
            return;
        using var formulario = new FrmRoles();
        formulario.Configurar(sesion);
        formulario.ShowDialog(TopLevelControl as Form ?? this);
    }
    private void Bitacora_Click(object? sender, EventArgs e)
    {
        using var formulario = new FrmBitacora();
        formulario.ShowDialog(TopLevelControl as Form ?? this);
    }
    private void btnConexion_Click(object sender, EventArgs e)
    {
        if (sesion?.Rol != "Administrador")
            return;
        using var configuracion = new FrmConfigurarConexion();
        if (configuracion.ShowDialog(TopLevelControl as Form ?? this) == DialogResult.OK && TopLevelControl is FrmPrincipal principal)
            principal.Close();
    }
}
