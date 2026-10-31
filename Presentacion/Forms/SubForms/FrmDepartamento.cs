using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms;

public partial class FrmDepartamento : Form
{
    private SesionUsuario? sesion;
    private uint id;
    public FrmDepartamento()
    {
        InitializeComponent();
        btnGuardar.Click += Guardar_Click;
        btnCancelar.Click += Cancelar_Click;
        btnCerrar.Click += Cancelar_Click;
    }
    public void Configurar(SesionUsuario sesion, Departamento? departamento = null)
    {
        this.sesion = sesion;
        id = departamento?.IdDepartamento ?? 0;
        txtNombre.Text = departamento?.Nombre ?? "";
        txtDescripcion.Text = departamento?.Descripcion ?? "";
        chkActivo.Checked = departamento?.Activo ?? true;
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            await new ServicioDepartamentos().GuardarAsync(new Departamento
            {
                IdDepartamento = id,
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
    private void FrmDepartamento_Load(object sender, EventArgs e)
    {
    }
    private void Cancelar_Click(object? sender, EventArgs e)
    {
        Close();
    }
}
