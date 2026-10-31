using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms;

public partial class FrmExpedientesDatosLaborales : Form
{
    private readonly ServicioCatalogos catalogos = new();
    private bool preparando;
    private bool editando;
    public FrmExpedientesDatosLaborales()
    {
        InitializeComponent();
        numSalario.Maximum = 999999999999.99m;
        numSalario.DecimalPlaces = 2;
        cboDepartamento.SelectedIndexChanged += Departamento_SelectedIndexChanged;
    }
    public async Task CargarAsync(Empleado empleado)
    {
        preparando = true;
        editando = empleado.IdEmpleado != 0;
        try
        {
            AyudaFormulario.CargarCombo(cboDepartamento, await catalogos.OpcionesAsync("departamentos", 0, editando));
            if (editando)
                cboDepartamento.SelectedValue = empleado.Condicion.IdDepartamento;
            AyudaFormulario.CargarCombo(cboPuesto, await catalogos.OpcionesAsync("puestos", AyudaFormulario.IdSeleccionado(cboDepartamento), editando));
            AyudaFormulario.CargarCombo(cboTipoContrato, await catalogos.OpcionesAsync("contratos", 0, editando));
            AyudaFormulario.CargarCombo(cboHorario, await catalogos.OpcionesAsync("horarios", 0, editando));
            dtpFechaContratacion.Value = empleado.FechaContratacion;
            dtpInicioVigencia.Value = editando ? empleado.Condicion.FechaInicio : empleado.FechaContratacion;
            numSalario.Value = empleado.Condicion.Salario;
            txtMotivo.Text = editando ? empleado.Condicion.Motivo : "Contratación";
            if (editando)
            {
                cboPuesto.SelectedValue = empleado.Condicion.IdPuesto;
                cboTipoContrato.SelectedValue = empleado.Condicion.IdTipoContrato;
                cboHorario.SelectedValue = empleado.Condicion.IdHorario;
            }
            cboDepartamento.Enabled = cboPuesto.Enabled = cboTipoContrato.Enabled = cboHorario.Enabled = !editando;
            numSalario.Enabled = dtpInicioVigencia.Enabled = txtMotivo.Enabled = !editando;
        }
        finally { preparando = false; }
    }
    public void Leer(Empleado empleado)
    {
        empleado.FechaContratacion = dtpFechaContratacion.Value.Date;
        if (editando)
            return;
        empleado.Condicion = new CondicionLaboral
        {
            IdDepartamento = AyudaFormulario.IdSeleccionado(cboDepartamento),
            IdPuesto = AyudaFormulario.IdSeleccionado(cboPuesto),
            IdTipoContrato = AyudaFormulario.IdSeleccionado(cboTipoContrato),
            IdHorario = AyudaFormulario.IdSeleccionado(cboHorario),
            FechaInicio = dtpInicioVigencia.Value.Date,
            Salario = numSalario.Value,
            Motivo = txtMotivo.Text
        };
    }
    private async void Departamento_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (preparando || editando)
            return;
        try
        {
            AyudaFormulario.CargarCombo(cboPuesto, await catalogos.OpcionesAsync("puestos", AyudaFormulario.IdSeleccionado(cboDepartamento)));
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
}
