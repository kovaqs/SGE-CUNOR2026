using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Asistencias;

public partial class FrmAsistencia : Form
{
    private SesionUsuario? sesion;
    private RegistroAsistencia? asistencia;
    private bool preparando;
    public FrmAsistencia()
    {
        InitializeComponent();
        Load += Asistencia_Load;
        cboEmpleado.SelectedIndexChanged += Jornada_Changed;
        dtpFecha.ValueChanged += Jornada_Changed;
        chkEsLaborable.CheckedChanged += Laborable_Changed;
        btnGuardar.Click += Guardar_Click;
        btnCerrar.Click += Cerrar_Click;
        btnCancelar.Click += Cerrar_Click;
        numTolerancia.Maximum = 1440;
    }
    public void Configurar(SesionUsuario sesion, RegistroAsistencia? asistencia = null)
    {
        this.sesion = sesion;
        this.asistencia = asistencia;
    }
    private async void Asistencia_Load(object? sender, EventArgs e)
    {
        if (sesion is null)
            return;
        preparando = true;
        btnGuardar.Enabled = false;
        try
        {
            AyudaFormulario.CargarCombo(cboEmpleado, await new ServicioCatalogos().OpcionesAsync("empleados", 0, true));
            if (IsDisposed)
                return;
            if (asistencia is not null)
            {
                cboEmpleado.SelectedValue = asistencia.IdEmpleado;
                dtpFecha.Value = asistencia.Fecha;
                Pintar(asistencia);
            }
            else
                Pintar(await new ServicioAsistencias().JornadaAsync(AyudaFormulario.IdSeleccionado(cboEmpleado), dtpFecha.Value));
            if (!IsDisposed)
                btnGuardar.Enabled = true;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { preparando = false; }
    }
    private void Pintar(RegistroAsistencia registro)
    {
        chkEsLaborable.Checked = registro.EsLaborable;
        numTolerancia.Value = registro.Tolerancia;
        dtpEntradaPrevista.Value = registro.EntradaPrevista ?? dtpFecha.Value.Date.AddHours(8);
        dtpEntradaPrevista.Checked = registro.EntradaPrevista is not null;
        dtpSalidaPrevista.Value = registro.SalidaPrevista ?? dtpFecha.Value.Date.AddHours(17);
        dtpSalidaPrevista.Checked = registro.SalidaPrevista is not null;
        dtpEntrada.Value = registro.Entrada ?? dtpEntradaPrevista.Value;
        dtpEntrada.Checked = registro.Entrada is not null;
        dtpSalida.Value = registro.Salida ?? dtpSalidaPrevista.Value;
        dtpSalida.Checked = registro.Salida is not null;
        cboEstado.SelectedItem = registro.Estado;
        txtObservaciones.Text = registro.Observaciones;
        Laborable_Changed(this, EventArgs.Empty);
    }
    private async void Jornada_Changed(object? sender, EventArgs e)
    {
        if (preparando || asistencia is not null)
            return;
        preparando = true;
        cboEmpleado.Enabled = dtpFecha.Enabled = btnGuardar.Enabled = false;
        try
        {
            var jornada = await new ServicioAsistencias().JornadaAsync(AyudaFormulario.IdSeleccionado(cboEmpleado), dtpFecha.Value);
            if (!IsDisposed)
                Pintar(jornada);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { preparando = false; if (!IsDisposed) cboEmpleado.Enabled = dtpFecha.Enabled = btnGuardar.Enabled = true; }
    }
    private void Laborable_Changed(object? sender, EventArgs e)
    {
        bool laborable = chkEsLaborable.Checked;
        dtpEntradaPrevista.Enabled = dtpSalidaPrevista.Enabled = dtpEntrada.Enabled = dtpSalida.Enabled = numTolerancia.Enabled = laborable;
        if (!laborable)
            cboEstado.SelectedItem = "NoLaborable";
        else if (cboEstado.Text == "NoLaborable")
            cboEstado.SelectedItem = "Pendiente";
    }
    private async void Guardar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnGuardar.Enabled)
            return;
        btnGuardar.Enabled = false;
        try
        {
            bool laborable = chkEsLaborable.Checked;
            var registro = new RegistroAsistencia
            {
                IdAsistencia = asistencia?.IdAsistencia ?? 0,
                IdEmpleado = AyudaFormulario.IdSeleccionado(cboEmpleado),
                Fecha = dtpFecha.Value.Date,
                EsLaborable = laborable,
                Tolerancia = (int)numTolerancia.Value,
                EntradaPrevista = laborable && dtpEntradaPrevista.Checked ? dtpEntradaPrevista.Value : null,
                SalidaPrevista = laborable && dtpSalidaPrevista.Checked ? dtpSalidaPrevista.Value : null,
                Entrada = laborable && dtpEntrada.Checked ? dtpEntrada.Value : null,
                Salida = laborable && dtpSalida.Checked ? dtpSalida.Value : null,
                Estado = cboEstado.Text,
                Observaciones = txtObservaciones.Text
            };
            await new ServicioAsistencias().GuardarAsync(registro, sesion);
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
