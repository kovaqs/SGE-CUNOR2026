using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Configuracion;

public partial class FrmHorario : Form
{
    private HorarioTrabajo horario = new();
    private SesionUsuario? sesion;
    private uint id;
    public FrmHorario()
    {
        InitializeComponent();
        Load += Horario_Load;
        btnGuardar.Click += Guardar_Click;
        btnAplicarDia.Click += Aplicar_Click;
        cboDiaSemana.SelectedIndexChanged += Dia_Changed;
        btnCerrar.Click += Cerrar_Click;
        btnCancelar.Click += Cerrar_Click;
        numTolerancia.Maximum = 1440;
        dgvDiasHorario.ReadOnly = true;
    }
    public void Configurar(SesionUsuario sesion, uint id = 0)
    {
        this.sesion = sesion;
        this.id = id;
    }
    private async void Horario_Load(object? sender, EventArgs e)
    {
        if (sesion is null)
            return;
        btnGuardar.Enabled = false;
        try
        {
            if (id != 0)
                horario = await new ServicioCatalogos().LeerHorarioAsync(id);
            if (IsDisposed)
                return;
            txtNombre.Text = horario.Nombre;
            chkActivo.Checked = horario.Activo;
            cboDiaSemana.SelectedIndex = 0;
            PintarDias();
            btnGuardar.Enabled = true;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private void Dia_Changed(object? sender, EventArgs e)
    {
        chkLaborable.Checked = false;
        chkSalidaDiaSiguiente.Checked = false;
        numTolerancia.Value = 0;
        dtpHoraEntrada.Value = DateTime.Today.AddHours(8);
        dtpHoraSalida.Value = DateTime.Today.AddHours(17);
        foreach (var dia in horario.Dias)
            if (dia.DiaSemana == cboDiaSemana.SelectedIndex + 1)
            {
                chkLaborable.Checked = true;
                dtpHoraEntrada.Value = DateTime.Today.Add(dia.Entrada);
                dtpHoraSalida.Value = DateTime.Today.Add(dia.Salida);
                chkSalidaDiaSiguiente.Checked = dia.DiaSiguiente;
                numTolerancia.Value = dia.Tolerancia;
                break;
            }
    }
    private void Aplicar_Click(object? sender, EventArgs e)
    {
        int numero = cboDiaSemana.SelectedIndex + 1;
        for (int i = 0; i < horario.Dias.Count; i++)
            if (horario.Dias[i].DiaSemana == numero)
            {
                horario.Dias.RemoveAt(i);
                break;
            }
        if (chkLaborable.Checked)
            horario.Dias.Add(new DiaHorario
            {
                DiaSemana = numero,
                Entrada = dtpHoraEntrada.Value.TimeOfDay,
                Salida = dtpHoraSalida.Value.TimeOfDay,
                DiaSiguiente = chkSalidaDiaSiguiente.Checked,
                Tolerancia = (int)numTolerancia.Value
            });
        PintarDias();
    }
    private void PintarDias()
    {
        dgvDiasHorario.Rows.Clear();
        for (int numero = 1; numero <= 7; numero++)
            foreach (var dia in horario.Dias)
                if (dia.DiaSemana == numero)
                    dgvDiasHorario.Rows.Add(cboDiaSemana.Items[numero - 1], dia.Entrada.ToString(@"hh\:mm"), dia.Salida.ToString(@"hh\:mm"), dia.DiaSiguiente, dia.Tolerancia);
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            horario.Nombre = txtNombre.Text;
            horario.Activo = chkActivo.Checked;
            await new ServicioCatalogos().GuardarHorarioAsync(horario, sesion);
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
