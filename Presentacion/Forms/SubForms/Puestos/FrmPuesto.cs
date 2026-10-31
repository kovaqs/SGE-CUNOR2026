using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Puestos;

public partial class FrmPuesto : Form
{
    private SesionUsuario? sesion;
    private Puesto? puesto;
    public FrmPuesto()
    {
        InitializeComponent();
        Load += Puesto_Load;
        btnGuardar.Click += Guardar_Click;
        btnCancelar.Click += Cancelar_Click;
        btnCerrar.Click += Cancelar_Click;
    }
    public void Configurar(SesionUsuario sesion, Puesto? puesto = null)
    {
        this.sesion = sesion;
        this.puesto = puesto;
    }
    private async void Puesto_Load(object? sender, EventArgs e)
    {
        btnGuardar.Enabled = false;
        try
        {
            AyudaFormulario.CargarCombo(cboDepartamento, await new ServicioCatalogos().OpcionesAsync("departamentos", 0, puesto is not null));
            if (IsDisposed)
                return;
            if (puesto is not null)
                cboDepartamento.SelectedValue = puesto.IdDepartamento;
            txtNombre.Text = puesto?.Nombre ?? "";
            txtDescripcion.Text = puesto?.Descripcion ?? "";
            chkActivo.Checked = puesto?.Activo ?? true;
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
            await new ServicioCatalogos().GuardarPuestoAsync(new Puesto
            {
                IdPuesto = puesto?.IdPuesto ?? 0,
                IdDepartamento = AyudaFormulario.IdSeleccionado(cboDepartamento),
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Activo = chkActivo.Checked
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
    private void Cancelar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
