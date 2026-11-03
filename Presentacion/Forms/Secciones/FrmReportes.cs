using System.Data;
using Entidades;
using Negocios;
using Presentacion.Reportes;

namespace Presentacion.Forms.Secciones;

public partial class FrmReportes : Form
{
    private SesionUsuario? sesion;
    private DataTable? resultados;
    private string tituloResultados = "Reporte";
    private string filtrosResultados = "";
    private int pagina;
    private int columnaOrden = -1;
    private bool ordenAscendente = true;
    public FrmReportes()
    {
        InitializeComponent();
        dlgGuardarReporte.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Load += Reportes_Load;
        btnConsultar.Click += Consultar_Click;
        btnLimpiarFiltros.Click += Limpiar_Click;
        btnAnterior.Click += Anterior_Click;
        btnSiguiente.Click += Siguiente_Click;
        cboTamanoPagina.SelectedIndexChanged += Tamano_Changed;
        cboTipoReporte.SelectedIndexChanged += Tipo_Changed;
        mnuExportarPdf.Click += Pdf_Click;
        mnuExportarExcel.Click += Excel_Click;
        dgvResultados.ColumnHeaderMouseClick += OrdenarResultados;
    }
    public void EstablecerSesion(SesionUsuario sesion)
    {
        this.sesion = sesion;
    }
    private async void Reportes_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        try
        {
            var catalogos = new ServicioCatalogos();
            AyudaFormulario.CargarCombo(cboDepartamento, await catalogos.OpcionesAsync("departamentos", 0, true), "Todos");
            AyudaFormulario.CargarCombo(cboPeriodoNomina, await catalogos.OpcionesAsync("periodos"));
            if (IsDisposed)
                return;
            cboTamanoPagina.SelectedIndex = 0;
            Limpiar_Click(this, EventArgs.Empty);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
    }
    private async void Consultar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || !btnConsultar.Enabled)
            return;
        btnConsultar.Enabled = false;
        string tituloConsulta = cboTipoReporte.Text;
        string filtrosConsulta = DescribirFiltros();
        try
        {
            resultados = await new ServicioReportes().ConsultarAsync(cboTipoReporte.SelectedIndex, dtpDesde.Value, dtpHasta.Value,
                AyudaFormulario.IdSeleccionado(cboDepartamento), cboEstadoEmpleado.Text, AyudaFormulario.IdSeleccionado(cboPeriodoNomina), sesion);
            if (!IsDisposed)
            {
                tituloResultados = tituloConsulta;
                filtrosResultados = filtrosConsulta;
                columnaOrden = -1;
                pagina = 0;
                PintarPagina();
            }
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnConsultar.Enabled = true; }
    }
    private void PintarPagina()
    {
        if (resultados is null || cboTamanoPagina.SelectedIndex < 0)
            return;
        int tamano = int.Parse(cboTamanoPagina.Text);
        dgvResultados.AutoGenerateColumns = false;
        for (int i = 0; i < dgvResultados.Columns.Count; i++)
        {
            var columna = dgvResultados.Columns[i];
            columna.Visible = i < resultados.Columns.Count;
            if (!columna.Visible)
                continue;
            columna.HeaderText = resultados.Columns[i].ColumnName;
            columna.DataPropertyName = resultados.Columns[i].ColumnName;
            columna.SortMode = DataGridViewColumnSortMode.Programmatic;
            columna.HeaderCell.SortGlyphDirection = i == columnaOrden
                ? (ordenAscendente ? SortOrder.Ascending : SortOrder.Descending) : SortOrder.None;
            columna.DefaultCellStyle.Format = resultados.Columns[i].DataType == typeof(decimal) ? "N2" : resultados.Columns[i].DataType == typeof(DateTime) ? "dd/MM/yyyy HH:mm" : "";
        }
        var vista = resultados.Clone();
        int inicio = pagina * tamano;
        for (int i = inicio; i < Math.Min(inicio + tamano, resultados.Rows.Count); i++)
            vista.ImportRow(resultados.DefaultView[i].Row);
        dgvResultados.DataSource = vista;
        int paginas = Math.Max(1, (resultados.Rows.Count + tamano - 1) / tamano);
        lblPagina.Text = "Página " + (pagina + 1) + " de " + paginas;
        btnAnterior.Enabled = pagina > 0;
        btnSiguiente.Enabled = pagina + 1 < paginas;
    }
    private void Limpiar_Click(object? sender, EventArgs e)
    {
        cboTipoReporte.SelectedIndex = 0;
        cboDepartamento.SelectedIndex = 0;
        cboEstadoEmpleado.SelectedIndex = 0;
        dtpDesde.Value = new DateTime(DateTime.Today.Year, 1, 1);
        dtpHasta.Value = DateTime.Today;
    }
    private string DescribirFiltros()
    {
        string departamento = "Departamento: " + cboDepartamento.Text;
        if (cboTipoReporte.SelectedIndex == 4)
            return "Período: " + cboPeriodoNomina.Text + " | " + departamento;
        string fechas = cboTipoReporte.SelectedIndex is 1 or 3
            ? "Desde " + dtpDesde.Value.ToString("dd/MM/yyyy") + " hasta " + dtpHasta.Value.ToString("dd/MM/yyyy")
            : "Al " + dtpHasta.Value.ToString("dd/MM/yyyy");
        return fechas + " | " + departamento + " | Estado: " + cboEstadoEmpleado.Text;
    }
    private void OrdenarResultados(object? sender, DataGridViewCellMouseEventArgs e)
    {
        if (resultados is null || e.ColumnIndex < 0 || e.ColumnIndex >= resultados.Columns.Count)
            return;
        ordenAscendente = columnaOrden != e.ColumnIndex || !ordenAscendente;
        columnaOrden = e.ColumnIndex;
        string columna = resultados.Columns[columnaOrden].ColumnName.Replace("]", "]]");
        resultados.DefaultView.Sort = "[" + columna + "] " + (ordenAscendente ? "ASC" : "DESC");
        pagina = 0;
        PintarPagina();
    }
    private void Tipo_Changed(object? sender, EventArgs e)
    {
        cboPeriodoNomina.Enabled = cboTipoReporte.SelectedIndex == 4;
        cboEstadoEmpleado.Enabled = cboTipoReporte.SelectedIndex != 4;
        dtpDesde.Enabled = cboTipoReporte.SelectedIndex is 1 or 3;
        dtpHasta.Enabled = cboTipoReporte.SelectedIndex != 4;
    }
    private void Tamano_Changed(object? sender, EventArgs e)
    {
        pagina = 0;
        PintarPagina();
    }
    private void Anterior_Click(object? sender, EventArgs e)
    {
        if (pagina > 0)
        {
            pagina--;
            PintarPagina();
        }
    }
    private void Siguiente_Click(object? sender, EventArgs e)
    {
        pagina++;
        PintarPagina();
    }
    private async Task ExportarAsync(bool excel)
    {
        if (resultados is null)
        {
            notificador.Show("Reportes", "Primero realiza una consulta.", KovaqsUI.Components.KToastKind.Warning);
            return;
        }
        dlgGuardarReporte.Filter = excel ? "Libro de Excel|*.xlsx" : "Documento PDF|*.pdf";
        dlgGuardarReporte.FileName = excel ? "Reporte.xlsx" : "Reporte.pdf";
        if (dlgGuardarReporte.ShowDialog(this) != DialogResult.OK)
            return;
        btnExportar.Enabled = false;
        try
        {
            var datos = resultados.DefaultView.ToTable();
            string archivo = dlgGuardarReporte.FileName;
            string titulo = tituloResultados;
            string filtros = filtrosResultados;
            await Task.Run(() => { if (excel) ExportadorReportes.Excel(datos, archivo, titulo, filtros); else ExportadorReportes.Pdf(datos, titulo, archivo, filtros); });
            if (!IsDisposed)
                notificador.Show("Reportes", "Archivo guardado con todos los resultados de la consulta.", KovaqsUI.Components.KToastKind.Success);
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { if (!IsDisposed) btnExportar.Enabled = true; }
    }
    private async void Pdf_Click(object? sender, EventArgs e)
    {
        await ExportarAsync(false);
    }
    private async void Excel_Click(object? sender, EventArgs e)
    {
        await ExportarAsync(true);
    }
    private void btnExportar_Click(object? sender, EventArgs e)
    {
        cmsExportar.Show(btnExportar, new Point(0, btnExportar.Height));
    }
}
