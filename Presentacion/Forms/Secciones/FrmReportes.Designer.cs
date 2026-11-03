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
        btnExportar = new KovaqsUI.Controls.KButton();
        cmsExportar = new ContextMenuStrip(components);
        mnuExportarPdf = new ToolStripMenuItem();
        mnuExportarExcel = new ToolStripMenuItem();
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
        colResultadoExtra = new DataGridViewTextBoxColumn();
        dlgGuardarReporte = new SaveFileDialog();
        components.Add(dlgGuardarReporte);
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
        SuspendLayout();
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
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
        lblTitulo.Dock = DockStyle.None;
        lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1094, 40);
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
        lblTipoReporte.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblTipoReporte.Font = new Font("Inter", 9F);
        lblTipoReporte.Name = "lblTipoReporte";
        lblTipoReporte.Size = new Size(354, 24);
        lblTipoReporte.TabIndex = 1;
        lblTipoReporte.TabStop = false;
        //
        // cboTipoReporte
        //
        cboTipoReporte.Font = new Font("Inter", 9F);
        cboTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTipoReporte.FormattingEnabled = true;
        cboTipoReporte.Items.AddRange(new object[] { "Listado general de empleados", "Listado filtrado de empleados", "Resumen estadístico", "Asistencias mensuales", "Resumen de nómina", "Departamentos con 5 o más empleados" });
        cboTipoReporte.Location = new Point(16, 96);
        cboTipoReporte.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        cboTipoReporte.CornerRadius = 8;
        cboTipoReporte.FillColor = Color.White;
        cboTipoReporte.ForeColor = Color.FromArgb(32, 38, 45);
        cboTipoReporte.BorderColor = Color.FromArgb(218, 218, 218);
        cboTipoReporte.GradientColor = Color.Empty;

        cboTipoReporte.Name = "cboTipoReporte";
        cboTipoReporte.Size = new Size(354, 34);
        cboTipoReporte.TabIndex = 4;
        //
        // lblDepartamento
        //
        lblDepartamento.AutoSize = false;
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
        lblDepartamento.Text = "Departamento";
        lblDepartamento.Location = new Point(386, 70);
        lblDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblDepartamento.Font = new Font("Inter", 9F);
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(354, 24);
        lblDepartamento.TabIndex = 2;
        lblDepartamento.TabStop = false;
        //
        // cboDepartamento
        //
        cboDepartamento.Font = new Font("Inter", 9F);
        cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.Items.AddRange(new object[] { "Todos" });
        cboDepartamento.Location = new Point(386, 96);
        cboDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        cboDepartamento.CornerRadius = 8;
        cboDepartamento.FillColor = Color.White;
        cboDepartamento.ForeColor = Color.FromArgb(32, 38, 45);
        cboDepartamento.BorderColor = Color.FromArgb(218, 218, 218);
        cboDepartamento.GradientColor = Color.Empty;

        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(354, 34);
        cboDepartamento.TabIndex = 5;
        //
        // lblEstadoEmpleado
        //
        lblEstadoEmpleado.AutoSize = false;
        lblEstadoEmpleado.BackColor = Color.Transparent;
        lblEstadoEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoEmpleado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEstadoEmpleado.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoEmpleado.Text = "Estado del empleado";
        lblEstadoEmpleado.Location = new Point(756, 70);
        lblEstadoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblEstadoEmpleado.Font = new Font("Inter", 9F);
        lblEstadoEmpleado.Name = "lblEstadoEmpleado";
        lblEstadoEmpleado.Size = new Size(354, 24);
        lblEstadoEmpleado.TabIndex = 3;
        lblEstadoEmpleado.TabStop = false;
        //
        // cboEstadoEmpleado
        //
        cboEstadoEmpleado.Font = new Font("Inter", 9F);
        cboEstadoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEstadoEmpleado.FormattingEnabled = true;
        cboEstadoEmpleado.Items.AddRange(new object[] { "Todos", "Activo", "Suspendido", "Inactivo" });
        cboEstadoEmpleado.Location = new Point(756, 96);
        cboEstadoEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        cboEstadoEmpleado.CornerRadius = 8;
        cboEstadoEmpleado.FillColor = Color.White;
        cboEstadoEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstadoEmpleado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstadoEmpleado.GradientColor = Color.Empty;

        cboEstadoEmpleado.Name = "cboEstadoEmpleado";
        cboEstadoEmpleado.Size = new Size(354, 34);
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
        lblDesde.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblDesde.Font = new Font("Inter", 9F);
        lblDesde.Name = "lblDesde";
        lblDesde.Size = new Size(354, 24);
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
        dtpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        dtpDesde.CalendarFont = new Font("Inter", 9F);
        dtpDesde.Name = "dtpDesde";
        dtpDesde.Size = new Size(354, 34);
        dtpDesde.TabIndex = 10;
        //
        // lblHasta
        //
        lblHasta.AutoSize = false;
        lblHasta.BackColor = Color.Transparent;
        lblHasta.ForeColor = Color.FromArgb(64, 64, 64);
        lblHasta.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblHasta.TextAlign = ContentAlignment.MiddleLeft;
        lblHasta.Text = "Hasta";
        lblHasta.Location = new Point(386, 140);
        lblHasta.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblHasta.Font = new Font("Inter", 9F);
        lblHasta.Name = "lblHasta";
        lblHasta.Size = new Size(354, 24);
        lblHasta.TabIndex = 8;
        lblHasta.TabStop = false;
        //
        // dtpHasta
        //
        dtpHasta.Font = new Font("Inter", 10F);
        dtpHasta.Format = DateTimePickerFormat.Custom;
        dtpHasta.CustomFormat = "dd/MM/yyyy";
        dtpHasta.MinimumSize = new Size(0, 34);
        dtpHasta.Location = new Point(386, 166);
        dtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        dtpHasta.CalendarFont = new Font("Inter", 9F);
        dtpHasta.Name = "dtpHasta";
        dtpHasta.Size = new Size(354, 34);
        dtpHasta.TabIndex = 11;
        //
        // lblPeriodoNomina
        //
        lblPeriodoNomina.AutoSize = false;
        lblPeriodoNomina.BackColor = Color.Transparent;
        lblPeriodoNomina.ForeColor = Color.FromArgb(64, 64, 64);
        lblPeriodoNomina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPeriodoNomina.TextAlign = ContentAlignment.MiddleLeft;
        lblPeriodoNomina.Text = "Período de nómina";
        lblPeriodoNomina.Location = new Point(756, 140);
        lblPeriodoNomina.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblPeriodoNomina.Font = new Font("Inter", 9F);
        lblPeriodoNomina.Name = "lblPeriodoNomina";
        lblPeriodoNomina.Size = new Size(354, 24);
        lblPeriodoNomina.TabIndex = 9;
        lblPeriodoNomina.TabStop = false;
        //
        // cboPeriodoNomina
        //
        cboPeriodoNomina.Font = new Font("Inter", 9F);
        cboPeriodoNomina.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPeriodoNomina.FormattingEnabled = true;
        cboPeriodoNomina.Location = new Point(756, 166);
        cboPeriodoNomina.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        cboPeriodoNomina.CornerRadius = 8;
        cboPeriodoNomina.FillColor = Color.White;
        cboPeriodoNomina.ForeColor = Color.FromArgb(32, 38, 45);
        cboPeriodoNomina.BorderColor = Color.FromArgb(218, 218, 218);
        cboPeriodoNomina.GradientColor = Color.Empty;

        cboPeriodoNomina.Name = "cboPeriodoNomina";
        cboPeriodoNomina.Size = new Size(354, 34);
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
        btnConsultar.Text = "Consultar";
        btnConsultar.Location = new Point(16, 214);
        btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnConsultar.BorderThickness = 1;
        btnConsultar.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnConsultar.FillColor = Color.FromArgb(49, 81, 107);
        btnConsultar.ForeColor = Color.White;
        btnConsultar.BorderColor = Color.FromArgb(49, 81, 107);
        btnConsultar.GradientColor = Color.Empty;
        btnConsultar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnConsultar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnConsultar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Size = new Size(264, 40);
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
        btnLimpiarFiltros.Text = "Limpiar filtros";
        btnLimpiarFiltros.Location = new Point(292, 214);
        btnLimpiarFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnLimpiarFiltros.BorderThickness = 1;
        btnLimpiarFiltros.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnLimpiarFiltros.FillColor = Color.White;
        btnLimpiarFiltros.ForeColor = Color.FromArgb(32, 38, 45);
        btnLimpiarFiltros.BorderColor = Color.FromArgb(218, 218, 218);
        btnLimpiarFiltros.GradientColor = Color.Empty;
        btnLimpiarFiltros.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnLimpiarFiltros.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnLimpiarFiltros.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnLimpiarFiltros.Name = "btnLimpiarFiltros";
        btnLimpiarFiltros.Size = new Size(264, 40);
        btnLimpiarFiltros.TabIndex = 14;
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
        lblResultadosTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblResultadosTitulo.Font = new Font("Inter", 9F);
        lblResultadosTitulo.Name = "lblResultadosTitulo";
        lblResultadosTitulo.Size = new Size(1094, 24);
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
        dgvResultados.Font = new Font("Inter", 9F);
        dgvResultados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvResultados.Name = "dgvResultados";
        dgvResultados.Size = new Size(1094, 378);
        dgvResultados.TabIndex = 18;
        dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colResultadosCodigo, colResultadosEmpleado, colResultadosDepartamento, colResultadosPuesto, colResultadosContrato, colResultadosEstado, colResultadoExtra });
        //
        // btnAnterior
        //
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.CornerRadius = 8;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Font = new Font("Inter", 9F);
        btnAnterior.Padding = new Padding(10, 4, 10, 4);
        btnAnterior.UseVisualStyleBackColor = false;
        btnAnterior.Text = "Anterior";
        btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAnterior.Location = new Point(16, 688);
        btnAnterior.BorderThickness = 1;
        btnAnterior.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnAnterior.FillColor = Color.White;
        btnAnterior.ForeColor = Color.FromArgb(32, 38, 45);
        btnAnterior.BorderColor = Color.FromArgb(218, 218, 218);
        btnAnterior.GradientColor = Color.Empty;
        btnAnterior.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnAnterior.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnAnterior.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Size = new Size(124, 40);
        btnAnterior.TabIndex = 19;
        //
        // lblPagina
        //
        lblPagina.AutoSize = false;
        lblPagina.BackColor = Color.Transparent;
        lblPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        lblPagina.Text = "Página 1 de 1";
        lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPagina.Location = new Point(150, 688);
        lblPagina.Font = new Font("Inter", 9F);
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
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSiguiente.Location = new Point(290, 688);
        btnSiguiente.BorderThickness = 1;
        btnSiguiente.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnSiguiente.FillColor = Color.White;
        btnSiguiente.ForeColor = Color.FromArgb(32, 38, 45);
        btnSiguiente.BorderColor = Color.FromArgb(218, 218, 218);
        btnSiguiente.GradientColor = Color.Empty;
        btnSiguiente.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnSiguiente.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnSiguiente.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
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
        lblTamanoPagina.Location = new Point(814, 688);
        lblTamanoPagina.Font = new Font("Inter", 9F);
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
        cboTamanoPagina.Location = new Point(954, 691);
        cboTamanoPagina.CornerRadius = 8;
        cboTamanoPagina.FillColor = Color.White;
        cboTamanoPagina.ForeColor = Color.FromArgb(32, 38, 45);
        cboTamanoPagina.BorderColor = Color.FromArgb(218, 218, 218);
        cboTamanoPagina.GradientColor = Color.Empty;

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
        colResultadoExtra.Name = "colResultadoExtra";
        colResultadoExtra.HeaderText = "Resultado";
        colResultadoExtra.ReadOnly = true;
        notificador.OwnerForm = this;
        btnExportar.BackColor = Color.Transparent;
        btnExportar.CornerRadius = 8;
        btnExportar.FlatStyle = FlatStyle.Flat;
        btnExportar.Font = new Font("Inter", 9F);
        btnExportar.Padding = new Padding(10, 4, 10, 4);
        btnExportar.UseVisualStyleBackColor = false;
        btnExportar.Text = "Exportar ▾";
        btnExportar.Click += btnExportar_Click;
        btnExportar.Location = new Point(568, 214);
        btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnExportar.BorderThickness = 1;
        btnExportar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnExportar.FillColor = Color.White;
        btnExportar.ForeColor = Color.FromArgb(49, 81, 107);
        btnExportar.BorderColor = Color.FromArgb(173, 190, 204);
        btnExportar.GradientColor = Color.Empty;
        btnExportar.Appearance.Hover.FillColor = Color.FromArgb(239, 244, 248);
        btnExportar.Appearance.Pressed.FillColor = Color.FromArgb(225, 235, 243);
        btnExportar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnExportar.Name = "btnExportar";
        btnExportar.Size = new Size(264, 40);
        btnExportar.TabIndex = 15;
        btnExportar.Click += btnExportar_Click;
        //
        // cmsExportar
        //
        cmsExportar.SuspendLayout();
        cmsExportar.Items.AddRange(new ToolStripItem[] { mnuExportarPdf, mnuExportarExcel });
        cmsExportar.Name = "cmsExportar";
        cmsExportar.Font = new Font("Inter", 9F);
        cmsExportar.ShowImageMargin = false;
        //
        // mnuExportarPdf
        //
        mnuExportarPdf.Name = "mnuExportarPdf";
        mnuExportarPdf.Text = "Exportar PDF";
        mnuExportarPdf.ForeColor = Color.FromArgb(49, 81, 107);
        //
        // mnuExportarExcel
        //
        mnuExportarExcel.Name = "mnuExportarExcel";
        mnuExportarExcel.Text = "Exportar Excel";
        mnuExportarExcel.ForeColor = Color.FromArgb(33, 115, 70);
        Controls.Add(btnExportar);
        cmsExportar.ResumeLayout(false);
        //
        // FrmReportes
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1126, 744);
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
        Controls.Add(lblResultadosTitulo);
        Controls.Add(dgvResultados);
        Controls.Add(btnAnterior);
        Controls.Add(lblPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(lblTamanoPagina);
        Controls.Add(cboTamanoPagina);
        MinimumSize = new Size(1126, 744);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3);
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmReportes";
        Text = "Consultas y reportes";
        ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KButton btnExportar;
    private ContextMenuStrip cmsExportar;
    private ToolStripMenuItem mnuExportarPdf;
    private ToolStripMenuItem mnuExportarExcel;

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
    private DataGridViewTextBoxColumn colResultadoExtra;
}
