using Entidades;
using Negocios;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace Presentacion.Forms.Secciones;

public partial class FrmInicio : Form
{
    private SesionUsuario? sesion;
    private bool cargando;
    public FrmInicio()
    {
        InitializeComponent();
        btnConsultar.Click += Consultar_Click;
        btnVerEmpleados.Click += Empleados_Click;
        btnVerAsistencias.Click += Asistencias_Click;
        btnVerNomina.Click += Nomina_Click;
    }
    public async void EstablecerSesion(SesionUsuario sesion)
    {
        this.sesion = sesion;
        btnVerEmpleados.Enabled = sesion.Puede("empleados");
        btnVerAsistencias.Enabled = sesion.Puede("asistencias");
        btnVerNomina.Enabled = sesion.Puede("nomina");
        btnConsultar.Enabled = sesion.Puede("reportes");
        if (IsHandleCreated && Visible && !cargando)
            await CargarAsync();
    }
    private async void FrmInicio_Load(object sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        cargando = true;
        try
        {
            AyudaFormulario.CargarCombo(cboDepartamento, await new ServicioCatalogos().OpcionesAsync("departamentos", 0, true), "Todos");
            dtpPeriodo.Value = DateTime.Today;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; }
        await CargarAsync();
    }
    private async Task CargarAsync()
    {
        if (sesion is null || cargando)
            return;
        if (!sesion.Puede("reportes"))
        {
            lblEmpleadosActivos.Text = lblFaltasMes.Text = lblTardanzasMes.Text = "-";
            graficoMasaSalarial.Series = Array.Empty<ISeries>();
            graficoIncidencias.Series = Array.Empty<ISeries>();
            return;
        }
        cargando = true;
        btnConsultar.Enabled = false;
        try
        {
            var datos = await new ServicioIndicadores().ConsultarAsync(dtpPeriodo.Value, AyudaFormulario.IdSeleccionado(cboDepartamento), sesion);
            if (IsDisposed)
                return;
            lblEmpleadosActivos.Text = datos.EmpleadosActivos.ToString();
            lblFaltasMes.Text = datos.Faltas[5].ToString();
            lblTardanzasMes.Text = datos.Tardanzas[5].ToString();
            var salarios = new List<ISeries>();
            foreach (var dato in datos.Salarios)
                salarios.Add(new PieSeries<double> { Name = dato.Nombre, Values = new[] { (double)dato.Importe }, InnerRadius = 50 });
            graficoMasaSalarial.Series = salarios;
            graficoIncidencias.Series = new ISeries[]
            {
                new ColumnSeries<double> { Name = "Ausentismo (%)", Values = datos.IndiceAusentismo },
                new ColumnSeries<double> { Name = "Tardanzas (%)", Values = datos.IndiceTardanzas }
            };
            graficoIncidencias.XAxes = new[] { new Axis { Labels = datos.Meses } };
            graficoIncidencias.YAxes = new[] { new Axis { MinLimit = 0, MaxLimit = 100, MinStep = 1, Labeler = FormatearPorcentaje } };
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; if (!IsDisposed) btnConsultar.Enabled = sesion.Puede("reportes"); }
    }
    private async void Consultar_Click(object? sender, EventArgs e)
    {
        await CargarAsync();
    }
    private static string FormatearPorcentaje(double valor)
    {
        return valor.ToString("0.##") + " %";
    }
    private void Empleados_Click(object? sender, EventArgs e)
    {
        (TopLevelControl as FrmPrincipal)?.MostrarEmpleados();
    }
    private void Asistencias_Click(object? sender, EventArgs e)
    {
        (TopLevelControl as FrmPrincipal)?.MostrarAsistencias();
    }
    private void Nomina_Click(object? sender, EventArgs e)
    {
        (TopLevelControl as FrmPrincipal)?.MostrarNomina();
    }
}
