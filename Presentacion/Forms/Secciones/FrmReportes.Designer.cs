namespace Presentacion.Forms.Secciones;

partial class FrmReportes
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        lblTipoReporte = new KovaqsUI.Controls.KLabel();
        cboTipoReporte = new KovaqsUI.Controls.KComboBox();
        lblDepartamento = new KovaqsUI.Controls.KLabel();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        lblEstadoEmpleado = new KovaqsUI.Controls.KLabel();
        cboEstadoEmpleado = new KovaqsUI.Controls.KComboBox();
        lblDesde = new KovaqsUI.Controls.KLabel();
        dtpDesde = new DateTimePicker();
        lblHasta = new KovaqsUI.Controls.KLabel();
        dtpHasta = new DateTimePicker();
        lblPeriodoNomina = new KovaqsUI.Controls.KLabel();
        cboPeriodoNomina = new KovaqsUI.Controls.KComboBox();
        btnConsultar = new KovaqsUI.Controls.KButton();
        btnLimpiarFiltros = new KovaqsUI.Controls.KButton();
        btnExportarPdf = new KovaqsUI.Controls.KButton();
        btnExportarExcel = new KovaqsUI.Controls.KButton();
        lblResultadosTitulo = new KovaqsUI.Controls.KLabel();
        dgvResultados = new KovaqsUI.Controls.KDataGridView();
        btnAnterior = new KovaqsUI.Controls.KButton();
        lblPagina = new KovaqsUI.Controls.KLabel();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        lblTamanoPagina = new KovaqsUI.Controls.KLabel();
        cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
        colResultadosCodigo = new DataGridViewTextBoxColumn();
        colResultadosEmpleado = new DataGridViewTextBoxColumn();
        colResultadosDepartamento = new DataGridViewTextBoxColumn();
        colResultadosPuesto = new DataGridViewTextBoxColumn();
        colResultadosContrato = new DataGridViewTextBoxColumn();
        colResultadosEstado = new DataGridViewTextBoxColumn();
        dlgGuardarReporte = new SaveFileDialog();
        components.Add(dlgGuardarReporte);
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
        SuspendLayout();
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 233, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Font = new Font("Inter", 9F);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Text = "Consultas y reportes";
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(870, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.TabStop = false;
        //
        // lblTipoReporte
        //
        lblTipoReporte.AutoSize = false;
        lblTipoReporte.BackColor = Color.Transparent;
        lblTipoReporte.ForeColor = Color.FromArgb(64, 64, 64);
        lblTipoReporte.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTipoReporte.TextAlign = ContentAlignment.MiddleLeft;
        lblTipoReporte.Text = "Tipo de reporte";
        lblTipoReporte.Location = new Point(16, 70);
        lblTipoReporte.Name = "lblTipoReporte";
        lblTipoReporte.Size = new Size(278, 24);
        lblTipoReporte.TabIndex = 1;
        lblTipoReporte.TabStop = false;
        //
        // cboTipoReporte
        //
        cboTipoReporte.Font = new Font("Inter", 9F);
        cboTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTipoReporte.FormattingEnabled = true;
        cboTipoReporte.Items.AddRange(new object[] { "Listado general de empleados", "Listado filtrado de empleados", "Resumen estadístico", "Asistencias mensuales", "Resumen de nómina" });
        cboTipoReporte.Location = new Point(16, 96);
        cboTipoReporte.Name = "cboTipoReporte";
        cboTipoReporte.Size = new Size(278, 34);
        cboTipoReporte.TabIndex = 2;
        //
        // lblDepartamento
        //
        lblDepartamento.AutoSize = false;
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
        lblDepartamento.Text = "Departamento";
        lblDepartamento.Location = new Point(312, 70);
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(278, 24);
        lblDepartamento.TabIndex = 3;
        lblDepartamento.TabStop = false;
        //
        // cboDepartamento
        //
        cboDepartamento.Font = new Font("Inter", 9F);
        cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.Items.AddRange(new object[] { "Todos" });
        cboDepartamento.Location = new Point(312, 96);
        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(278, 34);
        cboDepartamento.TabIndex = 4;
        //
        // lblEstadoEmpleado
        //
        lblEstadoEmpleado.AutoSize = false;
        lblEstadoEmpleado.BackColor = Color.Transparent;
        lblEstadoEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoEmpleado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEstadoEmpleado.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoEmpleado.Text = "Estado del empleado";
        lblEstadoEmpleado.Location = new Point(608, 70);
        lblEstadoEmpleado.Name = "lblEstadoEmpleado";
        lblEstadoEmpleado.Size = new Size(278, 24);
        lblEstadoEmpleado.TabIndex = 5;
        lblEstadoEmpleado.TabStop = false;
        //
        // cboEstadoEmpleado
        //
        cboEstadoEmpleado.Font = new Font("Inter", 9F);
        cboEstadoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEstadoEmpleado.FormattingEnabled = true;
        cboEstadoEmpleado.Items.AddRange(new object[] { "Todos", "Activo", "Suspendido", "Inactivo" });
        cboEstadoEmpleado.Location = new Point(608, 96);
        cboEstadoEmpleado.Name = "cboEstadoEmpleado";
        cboEstadoEmpleado.Size = new Size(278, 34);
        cboEstadoEmpleado.TabIndex = 6;
        //
        // lblDesde
        //
        lblDesde.AutoSize = false;
        lblDesde.BackColor = Color.Transparent;
        lblDesde.ForeColor = Color.FromArgb(64, 64, 64);
        lblDesde.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDesde.TextAlign = ContentAlignment.MiddleLeft;
        lblDesde.Text = "Desde";
        lblDesde.Location = new Point(16, 140);
        lblDesde.Name = "lblDesde";
        lblDesde.Size = new Size(278, 24);
        lblDesde.TabIndex = 7;
        lblDesde.TabStop = false;
        //
        // dtpDesde
        //
        dtpDesde.Font = new Font("Inter", 10F);
        dtpDesde.Format = DateTimePickerFormat.Custom;
        dtpDesde.CustomFormat = "dd/MM/yyyy";
        dtpDesde.MinimumSize = new Size(0, 34);
        dtpDesde.Location = new Point(16, 166);
        dtpDesde.Name = "dtpDesde";
        dtpDesde.Size = new Size(278, 34);
        dtpDesde.TabIndex = 8;
        //
        // lblHasta
        //
        lblHasta.AutoSize = false;
        lblHasta.BackColor = Color.Transparent;
        lblHasta.ForeColor = Color.FromArgb(64, 64, 64);
        lblHasta.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblHasta.TextAlign = ContentAlignment.MiddleLeft;
        lblHasta.Text = "Hasta";
        lblHasta.Location = new Point(312, 140);
        lblHasta.Name = "lblHasta";
        lblHasta.Size = new Size(278, 24);
        lblHasta.TabIndex = 9;
        lblHasta.TabStop = false;
        //
        // dtpHasta
        //
        dtpHasta.Font = new Font("Inter", 10F);
        dtpHasta.Format = DateTimePickerFormat.Custom;
        dtpHasta.CustomFormat = "dd/MM/yyyy";
        dtpHasta.MinimumSize = new Size(0, 34);
        dtpHasta.Location = new Point(312, 166);
        dtpHasta.Name = "dtpHasta";
        dtpHasta.Size = new Size(278, 34);
        dtpHasta.TabIndex = 10;
        //
        // lblPeriodoNomina
        //
        lblPeriodoNomina.AutoSize = false;
        lblPeriodoNomina.BackColor = Color.Transparent;
        lblPeriodoNomina.ForeColor = Color.FromArgb(64, 64, 64);
        lblPeriodoNomina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPeriodoNomina.TextAlign = ContentAlignment.MiddleLeft;
        lblPeriodoNomina.Text = "Período de nómina";
        lblPeriodoNomina.Location = new Point(608, 140);
        lblPeriodoNomina.Name = "lblPeriodoNomina";
        lblPeriodoNomina.Size = new Size(278, 24);
        lblPeriodoNomina.TabIndex = 11;
        lblPeriodoNomina.TabStop = false;
        //
        // cboPeriodoNomina
        //
        cboPeriodoNomina.Font = new Font("Inter", 9F);
        cboPeriodoNomina.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPeriodoNomina.FormattingEnabled = true;
        cboPeriodoNomina.Location = new Point(608, 166);
        cboPeriodoNomina.Name = "cboPeriodoNomina";
        cboPeriodoNomina.Size = new Size(278, 34);
        cboPeriodoNomina.TabIndex = 12;
        //
        // btnConsultar
        //
        btnConsultar.BackColor = Color.Transparent;
        btnConsultar.CornerRadius = 8;
        btnConsultar.FlatStyle = FlatStyle.Flat;
        btnConsultar.Font = new Font("Inter", 9F);
        btnConsultar.Padding = new Padding(10, 4, 10, 4);
        btnConsultar.UseVisualStyleBackColor = false;
        btnConsultar.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        btnConsultar.Text = "Consultar";
        btnConsultar.FillColor = Color.FromArgb(32, 38, 45);
        btnConsultar.ForeColor = Color.White;
        btnConsultar.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnConsultar.Appearance.Normal.ForeColor = Color.White;
        btnConsultar.Location = new Point(16, 214);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Size = new Size(208, 40);
        btnConsultar.TabIndex = 13;
        //
        // btnLimpiarFiltros
        //
        btnLimpiarFiltros.BackColor = Color.Transparent;
        btnLimpiarFiltros.CornerRadius = 8;
        btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
        btnLimpiarFiltros.Font = new Font("Inter", 9F);
        btnLimpiarFiltros.Padding = new Padding(10, 4, 10, 4);
        btnLimpiarFiltros.UseVisualStyleBackColor = false;
        btnLimpiarFiltros.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnLimpiarFiltros.Text = "Limpiar filtros";
        btnLimpiarFiltros.Location = new Point(236, 214);
        btnLimpiarFiltros.Name = "btnLimpiarFiltros";
        btnLimpiarFiltros.Size = new Size(208, 40);
        btnLimpiarFiltros.TabIndex = 14;
        //
        // btnExportarPdf
        //
        btnExportarPdf.BackColor = Color.Transparent;
        btnExportarPdf.CornerRadius = 8;
        btnExportarPdf.FlatStyle = FlatStyle.Flat;
        btnExportarPdf.Font = new Font("Inter", 9F);
        btnExportarPdf.Padding = new Padding(10, 4, 10, 4);
        btnExportarPdf.UseVisualStyleBackColor = false;
        btnExportarPdf.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnExportarPdf.Text = "Exportar PDF";
        btnExportarPdf.Location = new Point(456, 214);
        btnExportarPdf.Name = "btnExportarPdf";
        btnExportarPdf.Size = new Size(208, 40);
        btnExportarPdf.TabIndex = 15;
        //
        // btnExportarExcel
        //
        btnExportarExcel.BackColor = Color.Transparent;
        btnExportarExcel.CornerRadius = 8;
        btnExportarExcel.FlatStyle = FlatStyle.Flat;
        btnExportarExcel.Font = new Font("Inter", 9F);
        btnExportarExcel.Padding = new Padding(10, 4, 10, 4);
        btnExportarExcel.UseVisualStyleBackColor = false;
        btnExportarExcel.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnExportarExcel.Text = "Exportar Excel";
        btnExportarExcel.Location = new Point(676, 214);
        btnExportarExcel.Name = "btnExportarExcel";
        btnExportarExcel.Size = new Size(208, 40);
        btnExportarExcel.TabIndex = 16;
        //
        // lblResultadosTitulo
        //
        lblResultadosTitulo.AutoSize = false;
        lblResultadosTitulo.BackColor = Color.Transparent;
        lblResultadosTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblResultadosTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblResultadosTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblResultadosTitulo.Text = "Vista previa tabular";
        lblResultadosTitulo.Location = new Point(16, 268);
        lblResultadosTitulo.Name = "lblResultadosTitulo";
        lblResultadosTitulo.Size = new Size(870, 24);
        lblResultadosTitulo.TabIndex = 17;
        lblResultadosTitulo.TabStop = false;
        //
        // dgvResultados
        //
        dgvResultados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvResultados.AllowUserToAddRows = false;
        dgvResultados.AllowUserToDeleteRows = false;
        dgvResultados.AutoGenerateColumns = false;
        dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvResultados.ReadOnly = true;
        dgvResultados.RowHeadersVisible = false;
        dgvResultados.MultiSelect = false;
        dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvResultados.BackgroundColor = Color.White;
        dgvResultados.BorderStyle = BorderStyle.None;
        dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvResultados.ColumnHeadersHeight = 42;
        dgvResultados.EnableHeadersVisualStyles = false;
        dgvResultados.GridColor = Color.FromArgb(218, 218, 218);
        dgvResultados.RowTemplate.Height = 42;
        dgvResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvResultados.DefaultCellStyle = dataGridViewCellStyle2;
        dgvResultados.Location = new Point(16, 294);
        dgvResultados.Name = "dgvResultados";
        dgvResultados.Size = new Size(870, 306);
        dgvResultados.TabIndex = 18;
        dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colResultadosCodigo, colResultadosEmpleado, colResultadosDepartamento, colResultadosPuesto, colResultadosContrato, colResultadosEstado });
        //
        // btnAnterior
        //
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.CornerRadius = 8;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Font = new Font("Inter", 9F);
        btnAnterior.Padding = new Padding(10, 4, 10, 4);
        btnAnterior.UseVisualStyleBackColor = false;
        btnAnterior.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnAnterior.Text = "Anterior";
        btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAnterior.Location = new Point(16, 610);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Size = new Size(124, 40);
        btnAnterior.TabIndex = 19;
        //
        // lblPagina
        //
        lblPagina.AutoSize = false;
        lblPagina.BackColor = Color.Transparent;
        lblPagina.ForeColor = Color.Purple;
        lblPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        lblPagina.Text = "Página 1 de 1";
        lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPagina.Location = new Point(150, 610);
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(130, 40);
        lblPagina.TabIndex = 20;
        lblPagina.TabStop = false;
        //
        // btnSiguiente
        //
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.CornerRadius = 8;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.Font = new Font("Inter", 9F);
        btnSiguiente.Padding = new Padding(10, 4, 10, 4);
        btnSiguiente.UseVisualStyleBackColor = false;
        btnSiguiente.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSiguiente.Location = new Point(290, 610);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Size = new Size(124, 40);
        btnSiguiente.TabIndex = 21;
        //
        // lblTamanoPagina
        //
        lblTamanoPagina.AutoSize = false;
        lblTamanoPagina.BackColor = Color.Transparent;
        lblTamanoPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblTamanoPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTamanoPagina.TextAlign = ContentAlignment.MiddleLeft;
        lblTamanoPagina.Text = "Filas por página";
        lblTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblTamanoPagina.Location = new Point(590, 610);
        lblTamanoPagina.Name = "lblTamanoPagina";
        lblTamanoPagina.Size = new Size(130, 40);
        lblTamanoPagina.TabIndex = 22;
        lblTamanoPagina.TabStop = false;
        //
        // cboTamanoPagina
        //
        cboTamanoPagina.Font = new Font("Inter", 9F);
        cboTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cboTamanoPagina.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTamanoPagina.Items.AddRange(new object[] { "10", "25", "50", "100" });
        cboTamanoPagina.Location = new Point(730, 613);
        cboTamanoPagina.Name = "cboTamanoPagina";
        cboTamanoPagina.Size = new Size(156, 34);
        cboTamanoPagina.TabIndex = 23;
        //
        // colResultadosCodigo
        //
        colResultadosCodigo.HeaderText = "Código";
        colResultadosCodigo.Name = "colResultadosCodigo";
        colResultadosCodigo.ReadOnly = true;
        //
        // colResultadosEmpleado
        //
        colResultadosEmpleado.HeaderText = "Empleado";
        colResultadosEmpleado.Name = "colResultadosEmpleado";
        colResultadosEmpleado.ReadOnly = true;
        //
        // colResultadosDepartamento
        //
        colResultadosDepartamento.HeaderText = "Departamento";
        colResultadosDepartamento.Name = "colResultadosDepartamento";
        colResultadosDepartamento.ReadOnly = true;
        //
        // colResultadosPuesto
        //
        colResultadosPuesto.HeaderText = "Puesto";
        colResultadosPuesto.Name = "colResultadosPuesto";
        colResultadosPuesto.ReadOnly = true;
        //
        // colResultadosContrato
        //
        colResultadosContrato.HeaderText = "Contrato";
        colResultadosContrato.Name = "colResultadosContrato";
        colResultadosContrato.ReadOnly = true;
        //
        // colResultadosEstado
        //
        colResultadosEstado.HeaderText = "Estado";
        colResultadosEstado.Name = "colResultadosEstado";
        colResultadosEstado.ReadOnly = true;
        dlgGuardarReporte.Filter = "Documentos PDF (*.pdf)|*.pdf|Libros de Excel (*.xlsx)|*.xlsx";
        dlgGuardarReporte.DefaultExt = "pdf";
        dlgGuardarReporte.AddExtension = true;
        notificador.OwnerForm = this;
        //
        // FrmReportes
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(lblTipoReporte);
        Controls.Add(cboTipoReporte);
        Controls.Add(lblDepartamento);
        Controls.Add(cboDepartamento);
        Controls.Add(lblEstadoEmpleado);
        Controls.Add(cboEstadoEmpleado);
        Controls.Add(lblDesde);
        Controls.Add(dtpDesde);
        Controls.Add(lblHasta);
        Controls.Add(dtpHasta);
        Controls.Add(lblPeriodoNomina);
        Controls.Add(cboPeriodoNomina);
        Controls.Add(btnConsultar);
        Controls.Add(btnLimpiarFiltros);
        Controls.Add(btnExportarPdf);
        Controls.Add(btnExportarExcel);
        Controls.Add(lblResultadosTitulo);
        Controls.Add(dgvResultados);
        Controls.Add(btnAnterior);
        Controls.Add(lblPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(lblTamanoPagina);
        Controls.Add(cboTamanoPagina);
        MinimumSize = new Size(902, 669);
        Name = "FrmReportes";
        Text = "Consultas y reportes";
        ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KLabel lblTipoReporte;
    private KovaqsUI.Controls.KComboBox cboTipoReporte;
    private KovaqsUI.Controls.KLabel lblDepartamento;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KLabel lblEstadoEmpleado;
    private KovaqsUI.Controls.KComboBox cboEstadoEmpleado;
    private KovaqsUI.Controls.KLabel lblDesde;
    private DateTimePicker dtpDesde;
    private KovaqsUI.Controls.KLabel lblHasta;
    private DateTimePicker dtpHasta;
    private KovaqsUI.Controls.KLabel lblPeriodoNomina;
    private KovaqsUI.Controls.KComboBox cboPeriodoNomina;
    private KovaqsUI.Controls.KButton btnConsultar;
    private KovaqsUI.Controls.KButton btnLimpiarFiltros;
    private KovaqsUI.Controls.KButton btnExportarPdf;
    private KovaqsUI.Controls.KButton btnExportarExcel;
    private KovaqsUI.Controls.KLabel lblResultadosTitulo;
    private KovaqsUI.Controls.KDataGridView dgvResultados;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KLabel lblTamanoPagina;
    private KovaqsUI.Controls.KComboBox cboTamanoPagina;
    private DataGridViewTextBoxColumn colResultadosCodigo;
    private DataGridViewTextBoxColumn colResultadosEmpleado;
    private DataGridViewTextBoxColumn colResultadosDepartamento;
    private DataGridViewTextBoxColumn colResultadosPuesto;
    private DataGridViewTextBoxColumn colResultadosContrato;
    private DataGridViewTextBoxColumn colResultadosEstado;
    private SaveFileDialog dlgGuardarReporte;
    private KovaqsUI.Components.KToastNotifier notificador;
}
