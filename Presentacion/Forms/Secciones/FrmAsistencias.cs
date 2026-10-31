using System.Data;
using Entidades;
using Negocios;
using Presentacion.Forms.SubForms.Asistencias;
using Presentacion.Reportes;

namespace Presentacion.Forms.Secciones;

public partial class FrmAsistencias : Form
{
    private readonly ServicioAsistencias servicio = new();
    private SesionUsuario? sesion;
    private bool cargando;
    private int pagina;
    public FrmAsistencias()
    {
        InitializeComponent();
        VisibleChanged += Seccion_VisibleChanged;
        btnConsultar.Click += Consultar_Click;
        btnRegistrarAsistencia.Click += Registrar_Click;
        btnPermisosLaborales.Click += Permisos_Click;
        btnExportarExcel.Click += Exportar_Click;
        btnAnterior.Click += Anterior_Click;
        btnSiguiente.Click += Siguiente_Click;
        cboTamanoPagina.SelectedIndexChanged += Consultar_Click;
        dgvAsistencias.CellDoubleClick += Editar_CellDoubleClick;
    }
    public void EstablecerSesion(SesionUsuario sesion)
    {
        this.sesion = sesion;
    }
    private async void FrmAsistencias_Load(object sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        cargando = true;
        try
        {
            AyudaFormulario.CargarCombo(cboDepartamento, await new ServicioCatalogos().OpcionesAsync("departamentos", 0, true), "Todos");
            if (IsDisposed)
                return;
            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpHasta.Value = DateTime.Today;
            cboEstado.SelectedIndex = 0;
            cboTamanoPagina.SelectedIndex = 0;
            colFecha.DefaultCellStyle.Format = "dd/MM/yyyy";
            colEntrada.DefaultCellStyle.Format = colSalida.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; }
        await CargarAsync();
    }
    private async Task CargarAsync()
    {
        if (cargando || cboTamanoPagina.SelectedIndex < 0)
            return;
        cargando = true;
        btnConsultar.Enabled = false;
        dgvAsistencias.Enabled = false;
        btnAnterior.Enabled = btnSiguiente.Enabled = false;
        try
        {
            int limite = int.Parse(cboTamanoPagina.Text);
            var registros = await servicio.ListarAsync(dtpDesde.Value, dtpHasta.Value, AyudaFormulario.IdSeleccionado(cboDepartamento), txtBuscarEmpleado.Text, cboEstado.Text, pagina, limite);
            if (IsDisposed)
                return;
            bool siguiente = registros.Count > limite;
            if (siguiente)
                registros.RemoveAt(limite);
            dgvAsistencias.Rows.Clear();
            foreach (var registro in registros)
            {
                int fila = dgvAsistencias.Rows.Add(registro.Fecha, registro.Empleado, registro.Departamento, registro.Entrada, registro.Salida, registro.Estado, registro.Tardanza);
                dgvAsistencias.Rows[fila].Tag = registro;
            }
            lblPagina.Text = "Página " + (pagina + 1);
            btnAnterior.Enabled = pagina > 0;
            btnSiguiente.Enabled = siguiente;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; if (!IsDisposed) btnConsultar.Enabled = dgvAsistencias.Enabled = true; }
    }
    private async void Consultar_Click(object? sender, EventArgs e)
    {
        if (!cargando)
        {
            pagina = 0;
            await CargarAsync();
        }
    }
    private async void Anterior_Click(object? sender, EventArgs e)
    {
        if (!cargando && pagina > 0)
        {
            pagina--;
            await CargarAsync();
        }
    }
    private async void Siguiente_Click(object? sender, EventArgs e)
    {
        if (!cargando)
        {
            pagina++;
            await CargarAsync();
        }
    }
    private void dtpDesde_ValueChanged(object sender, EventArgs e)
    {
    }
    private async void Registrar_Click(object? sender, EventArgs e)
    {
        await AbrirAsync(null);
    }
    private async void Editar_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && dgvAsistencias.Rows[e.RowIndex].Tag is RegistroAsistencia registro)
            await AbrirAsync(registro);
    }
    private async Task AbrirAsync(RegistroAsistencia? registro)
    {
        if (sesion is null || cargando)
            return;
        using var formulario = new FrmAsistencia();
        formulario.Configurar(sesion, registro);
        if (formulario.ShowDialog(TopLevelControl as Form ?? this) == DialogResult.OK)
            await CargarAsync();
    }
    private void Permisos_Click(object? sender, EventArgs e)
    {
        if (sesion is null)
            return;
        using var formulario = new FrmPermisosLaborales();
        formulario.EstablecerSesion(sesion);
        formulario.ShowDialog(TopLevelControl as Form ?? this);
    }
    private async void Exportar_Click(object? sender, EventArgs e)
    {
        if (cargando)
            return;
        using var dialogo = new SaveFileDialog { Filter = "Libro de Excel|*.xlsx", FileName = "Asistencias.xlsx", InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) };
        if (dialogo.ShowDialog(this) != DialogResult.OK)
            return;
        btnExportarExcel.Enabled = false;
        try
        {
            var registros = await servicio.ListarAsync(dtpDesde.Value, dtpHasta.Value, AyudaFormulario.IdSeleccionado(cboDepartamento), txtBuscarEmpleado.Text, cboEstado.Text, 0, int.MaxValue - 1);
            var tabla = new DataTable();
            tabla.Columns.Add("Fecha", typeof(DateTime));
            tabla.Columns.Add("Empleado");
            tabla.Columns.Add("Departamento");
            tabla.Columns.Add("Entrada", typeof(DateTime));
            tabla.Columns.Add("Salida", typeof(DateTime));
            tabla.Columns.Add("Estado");
            tabla.Columns.Add("Tardanza (min)", typeof(int));
            foreach (var registro in registros)
                tabla.Rows.Add(registro.Fecha, registro.Empleado, registro.Departamento,
                (object?)registro.Entrada ?? DBNull.Value, (object?)registro.Salida ?? DBNull.Value, registro.Estado, registro.Tardanza);
            await Task.Run(() => ExportadorReportes.Excel(tabla, dialogo.FileName));
            if (!IsDisposed)
                notificador.Show("Asistencias", "Reporte de Excel guardado.", KovaqsUI.Components.KToastKind.Success);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnExportarExcel.Enabled = true; }
    }

    private async void Seccion_VisibleChanged(object? sender, EventArgs e)
    {
        if (!Visible || !IsHandleCreated || cargando || cboTamanoPagina.SelectedIndex < 0)
            return;
        cargando = true;
        try
        {

            uint departamento = AyudaFormulario.IdSeleccionado(cboDepartamento);
            AyudaFormulario.CargarCombo(cboDepartamento, await new ServicioCatalogos().OpcionesAsync("departamentos", 0, true), "Todos");
            if (IsDisposed)
                return;
            cboDepartamento.SelectedValue = departamento;

            pagina = 0;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; }
        if (!IsDisposed)
            await CargarAsync();
    }
}
