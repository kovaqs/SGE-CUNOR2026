using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Asistencias;

public partial class FrmPermisoLaboral : Form
{
    private SesionUsuario? sesion;
    private PermisoTrabajo? permiso;
    public FrmPermisoLaboral()
    {
        InitializeComponent();
        Load += Permiso_Load;
        btnGuardar.Click += Guardar_Click;
        btnCerrar.Click += Cerrar_Click;
        btnCancelar.Click += Cerrar_Click;
    }
    public void Configurar(SesionUsuario sesion, PermisoTrabajo? permiso = null)
    {
        this.sesion = sesion;
        this.permiso = permiso;
    }
    private async void Permiso_Load(object? sender, EventArgs e)
    {
        btnGuardar.Enabled = false;
        try
        {
            AyudaFormulario.CargarCombo(cboEmpleado, await new ServicioCatalogos().OpcionesAsync("empleados", 0, true));
            if (IsDisposed)
                return;
            dtpFechaInicio.Value = permiso?.Inicio ?? DateTime.Today.AddHours(8);
            dtpFechaFin.Value = permiso?.Fin ?? DateTime.Today.AddHours(17);
            if (permiso is not null)
                cboEmpleado.SelectedValue = permiso.IdEmpleado;
            chkConGoce.Checked = permiso?.ConGoce ?? true;
            txtMotivo.Text = permiso?.Motivo ?? "";
            btnGuardar.Enabled = true;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            await new ServicioPermisosTrabajo().GuardarAsync(new PermisoTrabajo
            {
                IdPermiso = permiso?.IdPermiso ?? 0,
                IdEmpleado = AyudaFormulario.IdSeleccionado(cboEmpleado),
                Inicio = dtpFechaInicio.Value,
                Fin = dtpFechaFin.Value,
                ConGoce = chkConGoce.Checked,
                Motivo = txtMotivo.Text
            }, sesion);
            if (!IsDisposed)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnGuardar.Enabled = true; }
    }
    private void Cerrar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
