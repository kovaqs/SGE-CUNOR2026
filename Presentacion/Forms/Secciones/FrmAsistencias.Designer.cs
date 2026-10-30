namespace Presentacion.Forms.Secciones;

partial class FrmAsistencias
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
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        dtpDesde = new DateTimePicker();
        dtpHasta = new DateTimePicker();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        txtBuscarEmpleado = new KovaqsUI.Controls.KTextBox();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        kLabel1 = new KovaqsUI.Controls.KLabel();
        kLabel2 = new KovaqsUI.Controls.KLabel();
        kLabel3 = new KovaqsUI.Controls.KLabel();
        kLabel4 = new KovaqsUI.Controls.KLabel();
        lblEstado = new KovaqsUI.Controls.KLabel();
        btnRegistrarAsistencia = new KovaqsUI.Controls.KButton();
        btnConsultar = new KovaqsUI.Controls.KButton();
        btnPermisosLaborales = new KovaqsUI.Controls.KButton();
        btnExportarExcel = new KovaqsUI.Controls.KButton();
        dgvAsistencias = new KovaqsUI.Controls.KDataGridView();
        colFecha = new DataGridViewTextBoxColumn();
        colEmpleado = new DataGridViewTextBoxColumn();
        colDepartamento = new DataGridViewTextBoxColumn();
        colEntrada = new DataGridViewTextBoxColumn();
        colSalida = new DataGridViewTextBoxColumn();
        colEstado = new DataGridViewTextBoxColumn();
        colTardanza = new DataGridViewTextBoxColumn();
        kLabel5 = new KovaqsUI.Controls.KLabel();
        btnAnterior = new KovaqsUI.Controls.KButton();
        lblPagina = new KovaqsUI.Controls.KLabel();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
        lblTamanoPagina = new KovaqsUI.Controls.KLabel();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
        SuspendLayout();
        // 
        // dtpDesde
        // 
        dtpDesde.CalendarFont = new Font("Microsoft Sans Serif", 9F);
        dtpDesde.CustomFormat = "dd/MM/yyyy";
        dtpDesde.Font = new Font("Microsoft Sans Serif", 10F);
        dtpDesde.Format = DateTimePickerFormat.Custom;
        dtpDesde.Location = new Point(16, 96);
        dtpDesde.MinimumSize = new Size(0, 34);
        dtpDesde.Name = "dtpDesde";
        dtpDesde.Size = new Size(354, 34);
        dtpDesde.TabIndex = 4;
        dtpDesde.ValueChanged += dtpDesde_ValueChanged;
        // 
        // dtpHasta
        // 
        dtpHasta.CalendarFont = new Font("Microsoft Sans Serif", 9F);
        dtpHasta.CustomFormat = "dd/MM/yyyy";
        dtpHasta.Font = new Font("Microsoft Sans Serif", 10F);
        dtpHasta.Format = DateTimePickerFormat.Custom;
        dtpHasta.Location = new Point(386, 96);
        dtpHasta.MinimumSize = new Size(0, 34);
        dtpHasta.Name = "dtpHasta";
        dtpHasta.Size = new Size(354, 34);
        dtpHasta.TabIndex = 5;
        // 
        // cboDepartamento
        // 
        cboDepartamento.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        cboDepartamento.Appearance.Normal.FillColor = Color.White;
        cboDepartamento.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        cboDepartamento.BackColor = Color.White;
        cboDepartamento.BorderColor = Color.FromArgb(218, 218, 218);
        cboDepartamento.FillColor = Color.White;
        cboDepartamento.Font = new Font("Inter", 9F);
        cboDepartamento.ForeColor = Color.FromArgb(32, 38, 45);
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.ItemHeight = 28;
        cboDepartamento.Items.AddRange(new object[] { "Todos" });
        cboDepartamento.Location = new Point(756, 96);
        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(354, 34);
        cboDepartamento.TabIndex = 6;
        // 
        // txtBuscarEmpleado
        // 
        txtBuscarEmpleado.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        txtBuscarEmpleado.Appearance.Normal.FillColor = Color.White;
        txtBuscarEmpleado.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        txtBuscarEmpleado.BackColor = Color.Transparent;
        txtBuscarEmpleado.BorderColor = Color.FromArgb(218, 218, 218);
        txtBuscarEmpleado.CornerRadius = 8;
        txtBuscarEmpleado.FillColor = Color.White;
        txtBuscarEmpleado.Font = new Font("Inter", 9F);
        txtBuscarEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
        txtBuscarEmpleado.Location = new Point(16, 166);
        txtBuscarEmpleado.Name = "txtBuscarEmpleado";
        txtBuscarEmpleado.Padding = new Padding(12, 8, 12, 8);
        txtBuscarEmpleado.Size = new Size(354, 34);
        txtBuscarEmpleado.TabIndex = 9;
        // 
        // cboEstado
        // 
        cboEstado.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.Appearance.Normal.FillColor = Color.White;
        cboEstado.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.BackColor = Color.White;
        cboEstado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.FillColor = Color.White;
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Presente", "Falta", "Justificada", "NoLaborable" });
        cboEstado.Location = new Point(386, 166);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(354, 34);
        cboEstado.TabIndex = 10;
        // 
        // lblTitulo
        // 
        lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1094, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Asistencias e incidencias";
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        // 
        // kLabel1
        // 
        kLabel1.AutoSize = false;
        kLabel1.BackColor = Color.Transparent;
        kLabel1.Font = new Font("Inter", 9F);
        kLabel1.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel1.Location = new Point(16, 70);
        kLabel1.Name = "kLabel1";
        kLabel1.RightToLeft = RightToLeft.No;
        kLabel1.Size = new Size(354, 24);
        kLabel1.TabIndex = 1;
        kLabel1.Text = "Desde";
        kLabel1.TextAlign = ContentAlignment.MiddleLeft;
        kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // kLabel2
        // 
        kLabel2.AutoSize = false;
        kLabel2.BackColor = Color.Transparent;
        kLabel2.Font = new Font("Inter", 9F);
        kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel2.Location = new Point(386, 70);
        kLabel2.Name = "kLabel2";
        kLabel2.Size = new Size(354, 24);
        kLabel2.TabIndex = 2;
        kLabel2.Text = "Hasta";
        kLabel2.TextAlign = ContentAlignment.MiddleLeft;
        kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // kLabel3
        // 
        kLabel3.AutoSize = false;
        kLabel3.BackColor = Color.Transparent;
        kLabel3.Font = new Font("Inter", 9F);
        kLabel3.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel3.Location = new Point(756, 70);
        kLabel3.Name = "kLabel3";
        kLabel3.Size = new Size(354, 24);
        kLabel3.TabIndex = 3;
        kLabel3.Text = "Departamento";
        kLabel3.TextAlign = ContentAlignment.MiddleLeft;
        kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // kLabel4
        // 
        kLabel4.AutoSize = false;
        kLabel4.BackColor = Color.Transparent;
        kLabel4.Font = new Font("Inter", 9F);
        kLabel4.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel4.Location = new Point(16, 140);
        kLabel4.Name = "kLabel4";
        kLabel4.Size = new Size(354, 24);
        kLabel4.TabIndex = 7;
        kLabel4.Text = "Nombre o Código";
        kLabel4.TextAlign = ContentAlignment.MiddleLeft;
        kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // lblEstado
        // 
        lblEstado.AutoSize = false;
        lblEstado.BackColor = Color.Transparent;
        lblEstado.Font = new Font("Inter", 9F);
        lblEstado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstado.Location = new Point(386, 140);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(354, 24);
        lblEstado.TabIndex = 8;
        lblEstado.Text = "Estado";
        lblEstado.TextAlign = ContentAlignment.MiddleLeft;
        lblEstado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // btnRegistrarAsistencia
        // 
        btnRegistrarAsistencia.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnRegistrarAsistencia.Appearance.Normal.BorderColor = Color.FromArgb(49, 81, 107);
        btnRegistrarAsistencia.Appearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
        btnRegistrarAsistencia.Appearance.Normal.ForeColor = Color.White;
        btnRegistrarAsistencia.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnRegistrarAsistencia.BackColor = Color.Transparent;
        btnRegistrarAsistencia.BorderColor = Color.FromArgb(49, 81, 107);
        btnRegistrarAsistencia.CornerRadius = 8;
        btnRegistrarAsistencia.FillColor = Color.FromArgb(49, 81, 107);
        btnRegistrarAsistencia.FlatStyle = FlatStyle.Flat;
        btnRegistrarAsistencia.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnRegistrarAsistencia.Font = new Font("Inter", 9F);
        btnRegistrarAsistencia.ForeColor = Color.White;
        btnRegistrarAsistencia.Location = new Point(16, 214);
        btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
        btnRegistrarAsistencia.Padding = new Padding(10, 4, 10, 4);
        btnRegistrarAsistencia.Size = new Size(264, 40);
        btnRegistrarAsistencia.TabIndex = 11;
        btnRegistrarAsistencia.Text = "Registrar o editar";
        btnRegistrarAsistencia.UseVisualStyleBackColor = false;
        // 
        // btnConsultar
        // 
        btnConsultar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnConsultar.Appearance.Normal.BorderColor = Color.FromArgb(49, 81, 107);
        btnConsultar.Appearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
        btnConsultar.Appearance.Normal.ForeColor = Color.White;
        btnConsultar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnConsultar.BackColor = Color.Transparent;
        btnConsultar.BorderColor = Color.FromArgb(49, 81, 107);
        btnConsultar.CornerRadius = 8;
        btnConsultar.FillColor = Color.FromArgb(49, 81, 107);
        btnConsultar.FlatStyle = FlatStyle.Flat;
        btnConsultar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnConsultar.Font = new Font("Inter", 9F);
        btnConsultar.ForeColor = Color.White;
        btnConsultar.Location = new Point(292, 214);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Padding = new Padding(10, 4, 10, 4);
        btnConsultar.Size = new Size(264, 40);
        btnConsultar.TabIndex = 12;
        btnConsultar.Text = "Consultar";
        btnConsultar.UseVisualStyleBackColor = false;
        // 
        // btnPermisosLaborales
        // 
        btnPermisosLaborales.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnPermisosLaborales.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        btnPermisosLaborales.Appearance.Normal.FillColor = Color.White;
        btnPermisosLaborales.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        btnPermisosLaborales.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnPermisosLaborales.BackColor = Color.Transparent;
        btnPermisosLaborales.BorderColor = Color.FromArgb(218, 218, 218);
        btnPermisosLaborales.CornerRadius = 8;
        btnPermisosLaborales.FillColor = Color.White;
        btnPermisosLaborales.FlatStyle = FlatStyle.Flat;
        btnPermisosLaborales.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnPermisosLaborales.Font = new Font("Inter", 9F);
        btnPermisosLaborales.ForeColor = Color.FromArgb(32, 38, 45);
        btnPermisosLaborales.Location = new Point(568, 214);
        btnPermisosLaborales.Name = "btnPermisosLaborales";
        btnPermisosLaborales.Padding = new Padding(10, 4, 10, 4);
        btnPermisosLaborales.Size = new Size(264, 40);
        btnPermisosLaborales.TabIndex = 13;
        btnPermisosLaborales.Text = "Permisos laborales";
        btnPermisosLaborales.UseVisualStyleBackColor = false;
        btnPermisosLaborales.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // btnExportarExcel
        // 
        btnExportarExcel.Appearance.Hover.FillColor = Color.FromArgb(27, 99, 60);
        btnExportarExcel.Appearance.Normal.BorderColor = Color.FromArgb(33, 115, 70);
        btnExportarExcel.Appearance.Normal.FillColor = Color.FromArgb(33, 115, 70);
        btnExportarExcel.Appearance.Normal.ForeColor = Color.White;
        btnExportarExcel.Appearance.Pressed.FillColor = Color.FromArgb(21, 80, 48);
        btnExportarExcel.BackColor = Color.Transparent;
        btnExportarExcel.BorderColor = Color.FromArgb(33, 115, 70);
        btnExportarExcel.CornerRadius = 8;
        btnExportarExcel.FillColor = Color.FromArgb(33, 115, 70);
        btnExportarExcel.FlatStyle = FlatStyle.Flat;
        btnExportarExcel.FocusAppearance.Color = Color.FromArgb(220, 242, 229);
        btnExportarExcel.Font = new Font("Inter", 9F);
        btnExportarExcel.ForeColor = Color.White;
        btnExportarExcel.Location = new Point(844, 214);
        btnExportarExcel.Name = "btnExportarExcel";
        btnExportarExcel.Padding = new Padding(10, 4, 10, 4);
        btnExportarExcel.Size = new Size(264, 40);
        btnExportarExcel.TabIndex = 14;
        btnExportarExcel.Text = "Exportar Excel";
        btnExportarExcel.UseVisualStyleBackColor = false;
        // 
        // dgvAsistencias
        // 
        dgvAsistencias.AllowUserToAddRows = false;
        dgvAsistencias.AllowUserToDeleteRows = false;
        dgvAsistencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvAsistencias.BackgroundColor = Color.White;
        dgvAsistencias.BorderStyle = BorderStyle.None;
        dgvAsistencias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvAsistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvAsistencias.ColumnHeadersHeight = 42;
        dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvAsistencias.Columns.AddRange(new DataGridViewColumn[] { colFecha, colEmpleado, colDepartamento, colEntrada, colSalida, colEstado, colTardanza });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvAsistencias.DefaultCellStyle = dataGridViewCellStyle2;
        dgvAsistencias.EnableHeadersVisualStyles = false;
        dgvAsistencias.Font = new Font("Inter", 9F);
        dgvAsistencias.GridColor = Color.FromArgb(218, 218, 218);
        dgvAsistencias.Location = new Point(16, 294);
        dgvAsistencias.MultiSelect = false;
        dgvAsistencias.Name = "dgvAsistencias";
        dgvAsistencias.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvAsistencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvAsistencias.RowHeadersVisible = false;
        dgvAsistencias.RowHeadersWidth = 51;
        dgvAsistencias.RowTemplate.Height = 42;
        dgvAsistencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAsistencias.Size = new Size(1094, 378);
        dgvAsistencias.TabIndex = 16;
        // 
        // colFecha
        // 
        colFecha.HeaderText = "Fecha";
        colFecha.Name = "colFecha";
        colFecha.ReadOnly = true;
        // 
        // colEmpleado
        // 
        colEmpleado.HeaderText = "Empleado";
        colEmpleado.Name = "colEmpleado";
        colEmpleado.ReadOnly = true;
        // 
        // colDepartamento
        // 
        colDepartamento.FillWeight = 150F;
        colDepartamento.HeaderText = "Departamento";
        colDepartamento.Name = "colDepartamento";
        colDepartamento.ReadOnly = true;
        // 
        // colEntrada
        // 
        colEntrada.HeaderText = "Entrada";
        colEntrada.Name = "colEntrada";
        colEntrada.ReadOnly = true;
        // 
        // colSalida
        // 
        colSalida.HeaderText = "Salida";
        colSalida.Name = "colSalida";
        colSalida.ReadOnly = true;
        // 
        // colEstado
        // 
        colEstado.HeaderText = "Estado";
        colEstado.Name = "colEstado";
        colEstado.ReadOnly = true;
        // 
        // colTardanza
        // 
        colTardanza.HeaderText = "Tardanza (min)";
        colTardanza.Name = "colTardanza";
        colTardanza.ReadOnly = true;
        // 
        // kLabel5
        // 
        kLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        kLabel5.AutoSize = false;
        kLabel5.BackColor = Color.Transparent;
        kLabel5.Font = new Font("Inter", 9F);
        kLabel5.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel5.Location = new Point(16, 268);
        kLabel5.Name = "kLabel5";
        kLabel5.Size = new Size(1094, 24);
        kLabel5.TabIndex = 15;
        kLabel5.Text = "Marcas e incidencias";
        kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // btnAnterior
        // 
        btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAnterior.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnAnterior.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        btnAnterior.Appearance.Normal.FillColor = Color.White;
        btnAnterior.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        btnAnterior.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.BorderColor = Color.FromArgb(218, 218, 218);
        btnAnterior.CornerRadius = 8;
        btnAnterior.FillColor = Color.White;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnAnterior.Font = new Font("Inter", 9F);
        btnAnterior.ForeColor = Color.FromArgb(32, 38, 45);
        btnAnterior.Location = new Point(16, 688);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Padding = new Padding(10, 4, 10, 4);
        btnAnterior.Size = new Size(124, 40);
        btnAnterior.TabIndex = 17;
        btnAnterior.Text = "Anterior";
        btnAnterior.UseVisualStyleBackColor = false;
        btnAnterior.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // lblPagina
        // 
        lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPagina.AutoSize = false;
        lblPagina.BackColor = Color.Transparent;
        lblPagina.Font = new Font("Inter", 9F);
        lblPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblPagina.Location = new Point(150, 688);
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(130, 40);
        lblPagina.TabIndex = 18;
        lblPagina.Text = "Página 1 de 1";
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        lblPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // btnSiguiente
        // 
        btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSiguiente.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnSiguiente.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        btnSiguiente.Appearance.Normal.FillColor = Color.White;
        btnSiguiente.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        btnSiguiente.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.BorderColor = Color.FromArgb(218, 218, 218);
        btnSiguiente.CornerRadius = 8;
        btnSiguiente.FillColor = Color.White;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnSiguiente.Font = new Font("Inter", 9F);
        btnSiguiente.ForeColor = Color.FromArgb(32, 38, 45);
        btnSiguiente.Location = new Point(290, 688);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Padding = new Padding(10, 4, 10, 4);
        btnSiguiente.Size = new Size(124, 40);
        btnSiguiente.TabIndex = 19;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.UseVisualStyleBackColor = false;
        btnSiguiente.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // cboTamanoPagina
        // 
        cboTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cboTamanoPagina.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        cboTamanoPagina.Appearance.Normal.FillColor = Color.White;
        cboTamanoPagina.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        cboTamanoPagina.BackColor = Color.White;
        cboTamanoPagina.BorderColor = Color.FromArgb(218, 218, 218);
        cboTamanoPagina.FillColor = Color.White;
        cboTamanoPagina.Font = new Font("Inter", 9F);
        cboTamanoPagina.ForeColor = Color.FromArgb(32, 38, 45);
        cboTamanoPagina.FormattingEnabled = true;
        cboTamanoPagina.ItemHeight = 28;
        cboTamanoPagina.Items.AddRange(new object[] { "10", "25", "50", "100" });
        cboTamanoPagina.Location = new Point(954, 691);
        cboTamanoPagina.Name = "cboTamanoPagina";
        cboTamanoPagina.Size = new Size(156, 34);
        cboTamanoPagina.TabIndex = 21;
        // 
        // lblTamanoPagina
        // 
        lblTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblTamanoPagina.AutoSize = false;
        lblTamanoPagina.BackColor = Color.Transparent;
        lblTamanoPagina.Font = new Font("Inter", 9F);
        lblTamanoPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblTamanoPagina.Location = new Point(814, 688);
        lblTamanoPagina.Name = "lblTamanoPagina";
        lblTamanoPagina.Size = new Size(130, 40);
        lblTamanoPagina.TabIndex = 20;
        lblTamanoPagina.Text = "Filas por página";
        lblTamanoPagina.TextAlign = ContentAlignment.MiddleLeft;
        lblTamanoPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // notificador
        // 
        notificador.OwnerForm = this;
        // 
        // FrmAsistencias
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1126, 744);
        Controls.Add(cboTamanoPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(lblPagina);
        Controls.Add(btnAnterior);
        Controls.Add(kLabel5);
        Controls.Add(dgvAsistencias);
        Controls.Add(btnExportarExcel);
        Controls.Add(btnPermisosLaborales);
        Controls.Add(btnConsultar);
        Controls.Add(btnRegistrarAsistencia);
        Controls.Add(lblEstado);
        Controls.Add(kLabel4);
        Controls.Add(kLabel3);
        Controls.Add(kLabel2);
        Controls.Add(kLabel1);
        Controls.Add(lblTitulo);
        Controls.Add(cboEstado);
        Controls.Add(txtBuscarEmpleado);
        Controls.Add(cboDepartamento);
        Controls.Add(dtpHasta);
        Controls.Add(dtpDesde);
        Controls.Add(lblTamanoPagina);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.None;
        MinimumSize = new Size(1126, 744);
        Name = "FrmAsistencias";
        Text = "Control de Asistencias";
        Load += FrmAsistencias_Load;
        ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DateTimePicker dtpDesde;
    private DateTimePicker dtpHasta;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KTextBox txtBuscarEmpleado;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KLabel kLabel1;
    private KovaqsUI.Controls.KLabel kLabel2;
    private KovaqsUI.Controls.KLabel kLabel3;
    private KovaqsUI.Controls.KLabel kLabel4;
    private KovaqsUI.Controls.KLabel lblEstado;
    private KovaqsUI.Controls.KButton btnRegistrarAsistencia;
    private KovaqsUI.Controls.KButton btnConsultar;
    private KovaqsUI.Controls.KButton btnPermisosLaborales;
    private KovaqsUI.Controls.KButton btnExportarExcel;
    private KovaqsUI.Controls.KDataGridView dgvAsistencias;
    private KovaqsUI.Controls.KLabel kLabel5;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KComboBox cboTamanoPagina;
    private DataGridViewTextBoxColumn colFecha;
    private DataGridViewTextBoxColumn colEmpleado;
    private DataGridViewTextBoxColumn colDepartamento;
    private DataGridViewTextBoxColumn colEntrada;
    private DataGridViewTextBoxColumn colSalida;
    private DataGridViewTextBoxColumn colEstado;
    private DataGridViewTextBoxColumn colTardanza;
    private KovaqsUI.Controls.KLabel lblTamanoPagina;
    private KovaqsUI.Components.KToastNotifier notificador;
}
