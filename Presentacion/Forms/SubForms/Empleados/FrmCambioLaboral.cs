using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Empleados;

public partial class FrmCambioLaboral : Form
{
    private readonly ServicioCatalogos catalogos = new();
    private SesionUsuario? sesion;
    private uint empleado;
    private bool preparando;
    public FrmCambioLaboral()
    {
        InitializeComponent();
        Load += Cambio_Load;
        cboDepartamento.SelectedIndexChanged += Departamento_Changed;
        btnGuardar.Click += Guardar_Click;
        btnCancelar.Click += Cancelar_Click;
        btnCerrar.Click += Cancelar_Click;
        numSalario.Maximum = 999999999999.99m;
        numSalario.DecimalPlaces = 2;
    }
    public void Configurar(SesionUsuario sesion, uint empleado, string nombre)
    {
        this.sesion = sesion;
        this.empleado = empleado;
        txtEmpleado.Text = nombre;
    }
    private async void Cambio_Load(object? sender, EventArgs e)
    {
        if (sesion is null)
            return;
        preparando = true;
        btnGuardar.Enabled = false;
        try
        {
            var actual = await new ServicioEmpleados().BuscarAsync(empleado, sesion);
            AyudaFormulario.CargarCombo(cboDepartamento, await catalogos.OpcionesAsync("departamentos"));
            cboDepartamento.SelectedValue = actual.Condicion.IdDepartamento;
            AyudaFormulario.CargarCombo(cboPuesto, await catalogos.OpcionesAsync("puestos", AyudaFormulario.IdSeleccionado(cboDepartamento)));
            AyudaFormulario.CargarCombo(cboTipoContrato, await catalogos.OpcionesAsync("contratos"));
            AyudaFormulario.CargarCombo(cboHorario, await catalogos.OpcionesAsync("horarios"));
            if (IsDisposed)
                return;
            cboPuesto.SelectedValue = actual.Condicion.IdPuesto;
            cboTipoContrato.SelectedValue = actual.Condicion.IdTipoContrato;
            cboHorario.SelectedValue = actual.Condicion.IdHorario;
            numSalario.Value = actual.Condicion.Salario;
            dtpFechaInicio.Value = DateTime.Today > actual.Condicion.FechaInicio ? DateTime.Today : actual.Condicion.FechaInicio.AddDays(1);
            btnGuardar.Enabled = true;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { preparando = false; }
    }
    private async void Departamento_Changed(object? sender, EventArgs e)
    {
        if (preparando)
            return;
        try
        {
            AyudaFormulario.CargarCombo(cboPuesto, await catalogos.OpcionesAsync("puestos", AyudaFormulario.IdSeleccionado(cboDepartamento)));
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
            using var autorizacion = new FrmAutorizarCambio();
            autorizacion.Configurar(sesion, txtEmpleado.Text, "Registrar cambio de condición laboral y salario");
            if (autorizacion.ShowDialog(this) != DialogResult.OK)
                return;
            var condicion = new CondicionLaboral
            {
                IdEmpleado = empleado,
                IdPuesto = AyudaFormulario.IdSeleccionado(cboPuesto),
                IdTipoContrato = AyudaFormulario.IdSeleccionado(cboTipoContrato),
                IdHorario = AyudaFormulario.IdSeleccionado(cboHorario),
                FechaInicio = dtpFechaInicio.Value.Date,
                Salario = numSalario.Value,
                Motivo = txtMotivo.Text
            };
            await new ServicioDatosSensibles().RegistrarCondicionAsync(condicion, sesion, autorizacion.ClaveConfirmada);
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
