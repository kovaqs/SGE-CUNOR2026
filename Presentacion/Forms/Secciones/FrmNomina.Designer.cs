namespace Presentacion.Forms.Secciones;

partial class FrmNomina
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        dtpDesde = new DateTimePicker();
        dtpHasta = new DateTimePicker();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        btnNuevoPeriodo = new KovaqsUI.Controls.KButton();
        btnBoletas = new KovaqsUI.Controls.KButton();
        btnAnterior = new KovaqsUI.Controls.KButton();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        kLabel2 = new KovaqsUI.Controls.KLabel();
        kLabel3 = new KovaqsUI.Controls.KLabel();
        lblEstado = new KovaqsUI.Controls.KLabel();
        kLabel4 = new KovaqsUI.Controls.KLabel();
        dgvPeriodos = new KovaqsUI.Controls.KDataGridView();
        lblPagina = new KovaqsUI.Controls.KLabel();
        colNombre = new DataGridViewTextBoxColumn();
        colDesde = new DataGridViewTextBoxColumn();
        colHasta = new DataGridViewTextBoxColumn();
        colEstado = new DataGridViewTextBoxColumn();
        colGeneradoPor = new DataGridViewTextBoxColumn();
        colFechaCierre = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)dgvPeriodos).BeginInit();
        lblTamanoPagina = new KovaqsUI.Controls.KLabel();
        lblTamanoPagina.Text = "Filas por página";
        lblTamanoPagina.Location = new Point(814, 688);
        lblTamanoPagina.Size = new Size(130, 40);
        lblTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblTamanoPagina.TextAlign = ContentAlignment.MiddleLeft;
        lblTamanoPagina.Font = new Font("Inter", 9F);
        lblTamanoPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblTamanoPagina.AutoSize = false;
        lblTamanoPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTamanoPagina.TabIndex = 15;
        lblTamanoPagina.TabStop = false;
        lblTamanoPagina.Name = "lblTamanoPagina";
        components = new System.ComponentModel.Container();
        btnAcciones = new KovaqsUI.Controls.KButton();
        cmsPeriodos = new ContextMenuStrip(components);
        mnuVerPeriodo = new ToolStripMenuItem();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        notificador.OwnerForm = this;
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle3.Font = new Font("Inter", 9F);
        SuspendLayout();
        //
        // dtpDesde
        //
        dtpDesde.CustomFormat = "dd/MM/yyyy";
        dtpDesde.Font = new Font("Inter", 10F);
        dtpDesde.Format = DateTimePickerFormat.Custom;
        dtpDesde.Location = new Point(16, 96);
        dtpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        dtpDesde.CalendarFont = new Font("Inter", 9F);
        dtpDesde.MinimumSize = new Size(0, 34);
        dtpDesde.Name = "dtpDesde";
        dtpDesde.Size = new Size(354, 34);
        dtpDesde.TabIndex = 4;
        //
        // dtpHasta
        //
        dtpHasta.CustomFormat = "dd/MM/yyyy";
        dtpHasta.Font = new Font("Inter", 10F);
        dtpHasta.Format = DateTimePickerFormat.Custom;
        dtpHasta.Location = new Point(386, 96);
        dtpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        dtpHasta.CalendarFont = new Font("Inter", 9F);
        dtpHasta.MinimumSize = new Size(0, 34);
        dtpHasta.Name = "dtpHasta";
        dtpHasta.Size = new Size(354, 34);
        dtpHasta.TabIndex = 5;
        //
        // cboEstado
        //
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Items.AddRange(new object[] { "Todos", "Borrador", "Cerrado", "Anulado" });
        cboEstado.Location = new Point(756, 96);
        cboEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.CornerRadius = 8;
        cboEstado.FillColor = Color.White;
        cboEstado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.GradientColor = Color.Empty;

        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(354, 34);
        cboEstado.TabIndex = 6;
        //
        // btnNuevoPeriodo
        //
        btnNuevoPeriodo.BackColor = Color.Transparent;
        btnNuevoPeriodo.ClickColor = Color.Black;
        btnNuevoPeriodo.FlatStyle = FlatStyle.Flat;
        btnNuevoPeriodo.Font = new Font("Inter", 9F);
        btnNuevoPeriodo.Location = new Point(16, 144);
        btnNuevoPeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnNuevoPeriodo.CornerRadius = 8;
        btnNuevoPeriodo.BorderThickness = 1;
        btnNuevoPeriodo.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnNuevoPeriodo.FillColor = Color.FromArgb(49, 81, 107);
        btnNuevoPeriodo.ForeColor = Color.White;
        btnNuevoPeriodo.BorderColor = Color.FromArgb(49, 81, 107);
        btnNuevoPeriodo.GradientColor = Color.Empty;
        btnNuevoPeriodo.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnNuevoPeriodo.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnNuevoPeriodo.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnNuevoPeriodo.Name = "btnNuevoPeriodo";
        btnNuevoPeriodo.Padding = new Padding(10, 4, 10, 4);
        btnNuevoPeriodo.Size = new Size(264, 40);
        btnNuevoPeriodo.TabIndex = 7;
        btnNuevoPeriodo.Text = "Nuevo período";
        btnNuevoPeriodo.UseVisualStyleBackColor = false;
        //
        // btnBoletas
        //
        btnBoletas.BackColor = Color.Transparent;
        btnBoletas.FlatStyle = FlatStyle.Flat;
        btnBoletas.Font = new Font("Inter", 9F);
        btnBoletas.Location = new Point(568, 144);
        btnBoletas.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnBoletas.CornerRadius = 8;
        btnBoletas.BorderThickness = 1;
        btnBoletas.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnBoletas.FillColor = Color.White;
        btnBoletas.ForeColor = Color.FromArgb(32, 38, 45);
        btnBoletas.BorderColor = Color.FromArgb(218, 218, 218);
        btnBoletas.GradientColor = Color.Empty;
        btnBoletas.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnBoletas.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnBoletas.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnBoletas.Name = "btnBoletas";
        btnBoletas.Padding = new Padding(10, 4, 10, 4);
        btnBoletas.Size = new Size(264, 40);
        btnBoletas.TabIndex = 9;
        btnBoletas.Text = "Boletas por departamento";
        btnBoletas.UseVisualStyleBackColor = false;
        //
        // btnAnterior
        //
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Font = new Font("Inter", 9F);
        btnAnterior.Location = new Point(16, 688);
        btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAnterior.CornerRadius = 8;
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
        btnAnterior.Padding = new Padding(10, 4, 10, 4);
        btnAnterior.Size = new Size(124, 40);
        btnAnterior.TabIndex = 12;
        btnAnterior.Text = "Anterior";
        btnAnterior.UseVisualStyleBackColor = false;
        //
        // btnSiguiente
        //
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.Font = new Font("Inter", 9F);
        btnSiguiente.Location = new Point(290, 688);
        btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSiguiente.CornerRadius = 8;
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
        btnSiguiente.Padding = new Padding(10, 4, 10, 4);
        btnSiguiente.Size = new Size(124, 40);
        btnSiguiente.TabIndex = 14;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.UseVisualStyleBackColor = false;
        //
        // cboTamanoPagina
        //
        cboTamanoPagina.Font = new Font("Inter", 9F);
        cboTamanoPagina.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTamanoPagina.Items.AddRange(new object[] { "10", "25", "50", "100" });
        cboTamanoPagina.FormattingEnabled = true;
        cboTamanoPagina.ItemHeight = 28;
        cboTamanoPagina.Location = new Point(954, 691);
        cboTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cboTamanoPagina.CornerRadius = 8;
        cboTamanoPagina.FillColor = Color.White;
        cboTamanoPagina.ForeColor = Color.FromArgb(32, 38, 45);
        cboTamanoPagina.BorderColor = Color.FromArgb(218, 218, 218);
        cboTamanoPagina.GradientColor = Color.Empty;

        cboTamanoPagina.Name = "cboTamanoPagina";
        cboTamanoPagina.Size = new Size(156, 34);
        cboTamanoPagina.TabIndex = 16;
        //
        // lblTitulo
        //
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Dock = DockStyle.None;
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.AutoSize = false;
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        lblTitulo.TabStop = false;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1094, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Períodos de nómina";
        //
        // kLabel2
        //
        kLabel2.BackColor = Color.Transparent;
        kLabel2.Font = new Font("Inter", 9F);
        kLabel2.Location = new Point(16, 70);
        kLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        kLabel2.TextAlign = ContentAlignment.MiddleLeft;
        kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel2.AutoSize = false;
        kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        kLabel2.TabStop = false;
        kLabel2.Name = "kLabel2";
        kLabel2.Size = new Size(354, 24);
        kLabel2.TabIndex = 1;
        kLabel2.Text = "Desde";
        //
        // kLabel3
        //
        kLabel3.BackColor = Color.Transparent;
        kLabel3.Font = new Font("Inter", 9F);
        kLabel3.Location = new Point(386, 70);
        kLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        kLabel3.TextAlign = ContentAlignment.MiddleLeft;
        kLabel3.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel3.AutoSize = false;
        kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        kLabel3.TabStop = false;
        kLabel3.Name = "kLabel3";
        kLabel3.Size = new Size(354, 24);
        kLabel3.TabIndex = 2;
        kLabel3.Text = "Hasta";
        //
        // lblEstado
        //
        lblEstado.BackColor = Color.Transparent;
        lblEstado.Font = new Font("Inter", 9F);
        lblEstado.Location = new Point(756, 70);
        lblEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblEstado.TextAlign = ContentAlignment.MiddleLeft;
        lblEstado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstado.AutoSize = false;
        lblEstado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEstado.TabStop = false;
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(354, 24);
        lblEstado.TabIndex = 3;
        lblEstado.Text = "Estado";
        //
        // kLabel4
        //
        kLabel4.BackColor = Color.Transparent;
        kLabel4.Font = new Font("Inter", 9F);
        kLabel4.Location = new Point(16, 198);
        kLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        kLabel4.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel4.AutoSize = false;
        kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        kLabel4.TabStop = false;
        kLabel4.Name = "kLabel4";
        kLabel4.Size = new Size(1094, 24);
        kLabel4.TabIndex = 10;
        kLabel4.Text = "Períodos de pago";
        //
        // colNombre
        //
        colNombre.HeaderText = "Nombre";
        colNombre.Name = "colNombre";
        colNombre.ReadOnly = true;
        //
        // colDesde
        //
        colDesde.HeaderText = "Desde";
        colDesde.Name = "colDesde";
        colDesde.ReadOnly = true;
        //
        // colHasta
        //
        colHasta.HeaderText = "Hasta";
        colHasta.Name = "colHasta";
        colHasta.ReadOnly = true;
        //
        // colEstado
        //
        colEstado.HeaderText = "Estado";
        colEstado.Name = "colEstado";
        colEstado.ReadOnly = true;
        //
        // colGeneradoPor
        //
        colGeneradoPor.HeaderText = "Generado por";
        colGeneradoPor.Name = "colGeneradoPor";
        colGeneradoPor.ReadOnly = true;
        //
        // colFechaCierre
        //
        colFechaCierre.HeaderText = "Fecha de cierre";
        colFechaCierre.Name = "colFechaCierre";
        colFechaCierre.ReadOnly = true;
        //
        // dgvPeriodos
        //
        dgvPeriodos.AllowUserToAddRows = false;
        dgvPeriodos.AllowUserToDeleteRows = false;
        dgvPeriodos.AutoGenerateColumns = false;
        dgvPeriodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPeriodos.ReadOnly = true;
        dgvPeriodos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colDesde, colHasta, colEstado, colGeneradoPor, colFechaCierre });
        dgvPeriodos.BackgroundColor = Color.White;
        dgvPeriodos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvPeriodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvPeriodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Inter", 9F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvPeriodos.DefaultCellStyle = dataGridViewCellStyle2;
        dgvPeriodos.EnableHeadersVisualStyles = false;
        dgvPeriodos.GridColor = Color.FromArgb(218, 218, 218);
        dgvPeriodos.Location = new Point(16, 224);
        dgvPeriodos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvPeriodos.Font = new Font("Inter", 9F);
        dgvPeriodos.BorderStyle = BorderStyle.None;
        dgvPeriodos.ColumnHeadersHeight = 42;
        dgvPeriodos.MultiSelect = false;
        dgvPeriodos.Name = "dgvPeriodos";
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvPeriodos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvPeriodos.RowHeadersVisible = false;
        dgvPeriodos.RowHeadersWidth = 51;
        dgvPeriodos.RowTemplate.Height = 42;
        dgvPeriodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPeriodos.Size = new Size(1094, 448);
        dgvPeriodos.TabIndex = 11;
        //
        // lblPagina
        //
        lblPagina.BackColor = Color.Transparent;
        lblPagina.Font = new Font("Inter", 9F);
        lblPagina.Location = new Point(150, 688);
        lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        lblPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblPagina.AutoSize = false;
        lblPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPagina.TabStop = false;
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(130, 40);
        lblPagina.TabIndex = 13;
        lblPagina.Text = "Página 1 de 1";
        btnAcciones.BackColor = Color.Transparent;
        btnAcciones.FlatStyle = FlatStyle.Flat;
        btnAcciones.Font = new Font("Inter", 9F);
        btnAcciones.Location = new Point(292, 144);
        btnAcciones.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnAcciones.CornerRadius = 8;
        btnAcciones.BorderThickness = 1;
        btnAcciones.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnAcciones.FillColor = Color.White;
        btnAcciones.ForeColor = Color.FromArgb(49, 81, 107);
        btnAcciones.BorderColor = Color.FromArgb(173, 190, 204);
        btnAcciones.GradientColor = Color.Empty;
        btnAcciones.Appearance.Hover.FillColor = Color.FromArgb(239, 244, 248);
        btnAcciones.Appearance.Pressed.FillColor = Color.FromArgb(225, 235, 243);
        btnAcciones.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnAcciones.Name = "btnAcciones";
        btnAcciones.Padding = new Padding(10, 4, 10, 4);
        btnAcciones.Size = new Size(264, 40);
        btnAcciones.TabIndex = 8;
        btnAcciones.Text = "Acciones ▾";
        btnAcciones.UseVisualStyleBackColor = false;
        btnAcciones.Click += btnAcciones_Click;
        btnAcciones.Enabled = false;
        //
        // cmsPeriodos
        //
        cmsPeriodos.SuspendLayout();
        cmsPeriodos.Items.AddRange(new ToolStripItem[] { mnuVerPeriodo });
        cmsPeriodos.Name = "cmsPeriodos";
        cmsPeriodos.Font = new Font("Inter", 9F);
        cmsPeriodos.ShowImageMargin = false;
        cmsPeriodos.Opening += cmsPeriodos_Opening;
        //
        // mnuVerPeriodo
        //
        mnuVerPeriodo.Name = "mnuVerPeriodo";
        mnuVerPeriodo.Text = "Ver detalle";
        mnuVerPeriodo.ForeColor = Color.FromArgb(32, 38, 45);
        dgvPeriodos.ContextMenuStrip = cmsPeriodos;
        dgvPeriodos.MouseDown += dgvPeriodos_MouseDown;
        dgvPeriodos.SelectionChanged += dgvPeriodos_SelectionChanged;
        dgvPeriodos.CellDoubleClick += dgvPeriodos_CellDoubleClick;
        Controls.Add(btnAcciones);
        cmsPeriodos.ResumeLayout(false);
        //
        // FrmNomina
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1126, 744);
        Controls.Add(lblPagina);
        Controls.Add(dgvPeriodos);
        Controls.Add(kLabel4);
        Controls.Add(lblEstado);
        Controls.Add(kLabel3);
        Controls.Add(kLabel2);
        Controls.Add(lblTitulo);
        Controls.Add(cboTamanoPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(btnAnterior);
        Controls.Add(btnBoletas);
        Controls.Add(btnNuevoPeriodo);
        Controls.Add(cboEstado);
        Controls.Add(dtpHasta);
        Controls.Add(dtpDesde);
        Margin = new Padding(3);
        Controls.Add(lblTamanoPagina);
        MinimumSize = new Size(1126, 744);
        FormBorderStyle = FormBorderStyle.None;
        Font = new Font("Segoe UI", 9F);
        Name = "FrmNomina";
        Text = "Nómina";
        ((System.ComponentModel.ISupportInitialize)dgvPeriodos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private KovaqsUI.Controls.KButton btnAcciones;
    private ContextMenuStrip cmsPeriodos;
    private ToolStripMenuItem mnuVerPeriodo;
    private DateTimePicker dtpDesde;
    private DateTimePicker dtpHasta;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KButton btnNuevoPeriodo;
    private KovaqsUI.Controls.KButton btnBoletas;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KComboBox cboTamanoPagina;
    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KLabel kLabel2;
    private KovaqsUI.Controls.KLabel kLabel3;
    private KovaqsUI.Controls.KLabel lblEstado;
    private KovaqsUI.Controls.KLabel kLabel4;
    private KovaqsUI.Controls.KDataGridView dgvPeriodos;
    private KovaqsUI.Controls.KLabel lblPagina;
    private DataGridViewTextBoxColumn colNombre;
    private DataGridViewTextBoxColumn colDesde;
    private DataGridViewTextBoxColumn colHasta;
    private DataGridViewTextBoxColumn colEstado;
    private DataGridViewTextBoxColumn colGeneradoPor;
    private DataGridViewTextBoxColumn colFechaCierre;
    private KovaqsUI.Controls.KLabel lblTamanoPagina;
    private KovaqsUI.Components.KToastNotifier notificador;
}
