using Entidades;
using Negocios;
using Presentacion.Navegacion;

namespace Presentacion.Forms.SubForms;

public partial class FrmExpedientes : Form
{
    private readonly ServicioEmpleados servicio = new();
    private GestorFormularios? gestor;
    private FrmExpedientesDatosPersonales? personales;
    private FrmExpedientesDatosLaborales? laborales;
    private FrmExpedientesDatosBancarios? bancarios;
    private SesionUsuario? sesion;
    private Empleado empleado = new();
    private uint idEmpleado;
    private bool guardando;

    public FrmExpedientes()
    {
        InitializeComponent();
        Load += Expediente_Load;
        kSegmentedControl1.SelectedIndexChanged += Seccion_SelectedIndexChanged;
        btnGuardar.Click += Guardar_Click;
        btnCerrar.Click += Cancelar_Click;
        btnCancelar.Click += Cancelar_Click;
    }
    public void Configurar(SesionUsuario sesion, uint id = 0)
    {
        this.sesion = sesion;
        idEmpleado = id;
    }
    private async void Expediente_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        btnGuardar.Enabled = false;
        try
        {
            if (sesion is null)
                throw new InvalidOperationException("Inicia sesión antes de abrir un expediente.");
            empleado = idEmpleado == 0 ? new Empleado() : await servicio.BuscarAsync(idEmpleado, sesion);
            if (IsDisposed)
                return;
            gestor = new GestorFormularios(panelDatos);
            personales = gestor.Mostrar<FrmExpedientesDatosPersonales>();
            personales.Cargar(empleado);
            bancarios = gestor.Mostrar<FrmExpedientesDatosBancarios>();
            bancarios.Cargar(empleado);
            laborales = gestor.Mostrar<FrmExpedientesDatosLaborales>();
            await laborales.CargarAsync(empleado);
            if (IsDisposed)
                return;
            kLabel3.Text = idEmpleado == 0 ? "Nuevo expediente" : "Editar expediente - " + empleado.Codigo;
            Seccion_SelectedIndexChanged(this, EventArgs.Empty);
            btnGuardar.Enabled = true;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private void Seccion_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (gestor is null)
            return;
        switch (kSegmentedControl1.SelectedIndex)
        {
            case 1:
                gestor.Mostrar<FrmExpedientesDatosLaborales>();
                break;
            case 2:
                gestor.Mostrar<FrmExpedientesDatosBancarios>();
                break;
            default:
                gestor.Mostrar<FrmExpedientesDatosPersonales>();
                break;
        }
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (guardando || sesion is null || personales is null || laborales is null || bancarios is null)
            return;
        guardando = true;
        btnGuardar.Enabled = btnCancelar.Enabled = btnCerrar.Enabled = false;
        try
        {
            personales.Leer(empleado);
            laborales.Leer(empleado);
            bancarios.Leer(empleado);
            await servicio.GuardarAsync(empleado, sesion);
            if (IsDisposed)
                return;
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { guardando = false; if (!IsDisposed) btnGuardar.Enabled = btnCancelar.Enabled = btnCerrar.Enabled = true; }
    }
    private void Cancelar_Click(object? sender, EventArgs e)
    {
        if (!guardando)
            Close();
    }
    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }
    private void panel3_Paint(object sender, PaintEventArgs e)
    {
    }
}
