namespace Presentacion.Forms.Secciones;

partial class FrmPuestos
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
        lblTitulo = new KovaqsUI.Controls.KLabel();
        txtBuscar = new KovaqsUI.Controls.KTextBox();
        lblNombrePuesto = new KovaqsUI.Controls.KLabel();
        lblDepartamento = new KovaqsUI.Controls.KLabel();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        lblEstado = new KovaqsUI.Controls.KLabel();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        btnAgregarPuesto = new KovaqsUI.Controls.KButton();
        lblPuestos = new KovaqsUI.Controls.KLabel();
        dgvPuestos = new KovaqsUI.Controls.KDataGridView();
        lblPagina = new KovaqsUI.Controls.KLabel();
        btnAnterior = new KovaqsUI.Controls.KButton();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        cbotamanoPagina = new KovaqsUI.Controls.KComboBox();
        ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
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
        cmsPuestos = new ContextMenuStrip(components);
        mnuEditarPuesto = new ToolStripMenuItem();
        separadorAcciones = new ToolStripSeparator();
        mnuEliminarPuesto = new ToolStripMenuItem();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        notificador.OwnerForm = this;
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle3.Font = new Font("Inter", 9F);
        colNombre = new DataGridViewTextBoxColumn();
        colNombre.Name = "colNombre";
        colNombre.HeaderText = "Nombre";
        colNombre.DataPropertyName = "Nombre";
        colNombre.FillWeight = 26F;
        colNombre.ReadOnly = true;
        colDepartamento = new DataGridViewTextBoxColumn();
        colDepartamento.Name = "colDepartamento";
        colDepartamento.HeaderText = "Departamento";
        colDepartamento.DataPropertyName = "Departamento";
        colDepartamento.FillWeight = 26F;
        colDepartamento.ReadOnly = true;
        colDescripcion = new DataGridViewTextBoxColumn();
        colDescripcion.Name = "colDescripcion";
        colDescripcion.HeaderText = "Descripción";
        colDescripcion.DataPropertyName = "Descripcion";
        colDescripcion.FillWeight = 38F;
        colDescripcion.ReadOnly = true;
        colActivo = new DataGridViewCheckBoxColumn();
        colActivo.Name = "colActivo";
        colActivo.HeaderText = "Activo";
        colActivo.DataPropertyName = "Activo";
        colActivo.FillWeight = 10F;
        colActivo.ReadOnly = true;
        dgvPuestos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colDepartamento, colDescripcion, colActivo });
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Dock = DockStyle.None;
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitulo.TabStop = false;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1094, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Puestos de trabajo";
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        //
        // txtBuscar
        //
        txtBuscar.BackColor = Color.White;
        txtBuscar.CornerRadius = 8;
        txtBuscar.Font = new Font("Inter", 9F);
        txtBuscar.Location = new Point(16, 96);
        txtBuscar.Margin = new Padding(3, 2, 3, 2);
        txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        txtBuscar.FillColor = Color.White;
        txtBuscar.ForeColor = Color.FromArgb(32, 38, 45);
        txtBuscar.BorderColor = Color.FromArgb(218, 218, 218);
        txtBuscar.GradientColor = Color.Empty;
        txtBuscar.BorderThickness = 1;
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Padding = new Padding(10, 5, 10, 5);
        txtBuscar.Size = new Size(354, 34);
        txtBuscar.TabIndex = 4;
        //
        // lblNombrePuesto
        //
        lblNombrePuesto.BackColor = Color.Transparent;
        lblNombrePuesto.Font = new Font("Inter", 9F);
        lblNombrePuesto.Location = new Point(16, 70);
        lblNombrePuesto.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblNombrePuesto.TextAlign = ContentAlignment.MiddleLeft;
        lblNombrePuesto.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombrePuesto.AutoSize = false;
        lblNombrePuesto.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNombrePuesto.TabStop = false;
        lblNombrePuesto.Name = "lblNombrePuesto";
        lblNombrePuesto.Size = new Size(354, 24);
        lblNombrePuesto.TabIndex = 1;
        lblNombrePuesto.Text = "Nombre del puesto";
        //
        // lblDepartamento
        //
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.Font = new Font("Inter", 9F);
        lblDepartamento.Location = new Point(386, 70);
        lblDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
        lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamento.AutoSize = false;
        lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDepartamento.TabStop = false;
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(354, 24);
        lblDepartamento.TabIndex = 2;
        lblDepartamento.Text = "Departamento";
        //
        // cboDepartamento
        //
        cboDepartamento.CornerRadius = 8;
        cboDepartamento.Font = new Font("Inter", 9F);
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.ItemHeight = 28;
        cboDepartamento.Location = new Point(386, 96);
        cboDepartamento.Margin = new Padding(3, 2, 3, 2);
        cboDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        cboDepartamento.FillColor = Color.White;
        cboDepartamento.ForeColor = Color.FromArgb(32, 38, 45);
        cboDepartamento.BorderColor = Color.FromArgb(218, 218, 218);
        cboDepartamento.GradientColor = Color.Empty;
        cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;

        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(354, 34);
        cboDepartamento.TabIndex = 5;
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
        // cboEstado
        //
        cboEstado.CornerRadius = 8;
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Items.AddRange(new object[] { "Todos", "", "Activos", "", "Inactivos" });
        cboEstado.Location = new Point(756, 96);
        cboEstado.Margin = new Padding(3, 2, 3, 2);
        cboEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.FillColor = Color.White;
        cboEstado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.GradientColor = Color.Empty;
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;

        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(354, 34);
        cboEstado.TabIndex = 6;
        //
        // btnAgregarPuesto
        //
        btnAgregarPuesto.BackColor = Color.Transparent;
        btnAgregarPuesto.CornerRadius = 8;
        btnAgregarPuesto.FlatStyle = FlatStyle.Flat;
        btnAgregarPuesto.Font = new Font("Inter", 9F);
        btnAgregarPuesto.Location = new Point(16, 144);
        btnAgregarPuesto.Margin = new Padding(3, 2, 3, 2);
        btnAgregarPuesto.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnAgregarPuesto.BorderThickness = 1;
        btnAgregarPuesto.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnAgregarPuesto.FillColor = Color.FromArgb(49, 81, 107);
        btnAgregarPuesto.ForeColor = Color.White;
        btnAgregarPuesto.BorderColor = Color.FromArgb(49, 81, 107);
        btnAgregarPuesto.GradientColor = Color.Empty;
        btnAgregarPuesto.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnAgregarPuesto.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnAgregarPuesto.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnAgregarPuesto.Name = "btnAgregarPuesto";
        btnAgregarPuesto.Padding = new Padding(10, 4, 10, 4);
        btnAgregarPuesto.Size = new Size(264, 40);
        btnAgregarPuesto.TabIndex = 7;
        btnAgregarPuesto.Text = "Agregar";
        btnAgregarPuesto.UseVisualStyleBackColor = false;
        //
        // lblPuestos
        //
        lblPuestos.BackColor = Color.Transparent;
        lblPuestos.Font = new Font("Inter", 9F);
        lblPuestos.Location = new Point(16, 198);
        lblPuestos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblPuestos.ForeColor = Color.FromArgb(64, 64, 64);
        lblPuestos.AutoSize = false;
        lblPuestos.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPuestos.TabStop = false;
        lblPuestos.Name = "lblPuestos";
        lblPuestos.Size = new Size(1094, 24);
        lblPuestos.TabIndex = 10;
        lblPuestos.Text = "Puestos registrados";
        lblPuestos.Click += lblPuestos_Click;
        //
        // dgvPuestos
        //
        dgvPuestos.AllowUserToAddRows = false;
        dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPuestos.BackgroundColor = Color.White;
        dgvPuestos.BorderStyle = BorderStyle.None;
        dgvPuestos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Inter", 9F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvPuestos.DefaultCellStyle = dataGridViewCellStyle2;
        dgvPuestos.EnableHeadersVisualStyles = false;
        dgvPuestos.GridColor = Color.FromArgb(218, 218, 218);
        dgvPuestos.Location = new Point(16, 224);
        dgvPuestos.Margin = new Padding(3, 2, 3, 2);
        dgvPuestos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvPuestos.Font = new Font("Inter", 9F);
        dgvPuestos.ColumnHeadersHeight = 42;
        dgvPuestos.MultiSelect = false;
        dgvPuestos.AllowUserToDeleteRows = false;
        dgvPuestos.AutoGenerateColumns = false;
        dgvPuestos.Name = "dgvPuestos";
        dgvPuestos.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvPuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvPuestos.RowHeadersVisible = false;
        dgvPuestos.RowHeadersWidth = 51;
        dgvPuestos.RowTemplate.Height = 42;
        dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPuestos.Size = new Size(1094, 448);
        dgvPuestos.TabIndex = 11;
        dgvPuestos.SelectionChanged += dgvPuestos_SelectionChanged;
        //
        // lblPagina
        //
        lblPagina.AutoSize = false;
        lblPagina.BackColor = Color.Transparent;
        lblPagina.Font = new Font("Inter", 9F);
        lblPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblPagina.Location = new Point(150, 688);
        lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPagina.TabStop = false;
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(130, 40);
        lblPagina.TabIndex = 13;
        lblPagina.Text = "Página 1 de 1";
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        //
        // btnAnterior
        //
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.CornerRadius = 8;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Font = new Font("Inter", 9F);
        btnAnterior.Location = new Point(16, 688);
        btnAnterior.Margin = new Padding(3, 2, 3, 2);
        btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
        btnSiguiente.CornerRadius = 8;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.Font = new Font("Inter", 9F);
        btnSiguiente.Location = new Point(290, 688);
        btnSiguiente.Margin = new Padding(3, 2, 3, 2);
        btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
        // cbotamanoPagina
        //
        cbotamanoPagina.FormattingEnabled = true;
        cbotamanoPagina.ItemHeight = 28;
        cbotamanoPagina.Items.AddRange(new object[] { "10", "25", "50", "100" });
        cbotamanoPagina.Location = new Point(954, 691);
        cbotamanoPagina.Margin = new Padding(3, 2, 3, 2);
        cbotamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cbotamanoPagina.Font = new Font("Inter", 9F);
        cbotamanoPagina.CornerRadius = 8;
        cbotamanoPagina.FillColor = Color.White;
        cbotamanoPagina.ForeColor = Color.FromArgb(32, 38, 45);
        cbotamanoPagina.BorderColor = Color.FromArgb(218, 218, 218);
        cbotamanoPagina.GradientColor = Color.Empty;
        cbotamanoPagina.DropDownStyle = ComboBoxStyle.DropDownList;

        cbotamanoPagina.Name = "cbotamanoPagina";
        cbotamanoPagina.Size = new Size(156, 34);
        cbotamanoPagina.TabIndex = 16;
        btnAcciones.BackColor = Color.Transparent;
        btnAcciones.CornerRadius = 8;
        btnAcciones.FlatStyle = FlatStyle.Flat;
        btnAcciones.Font = new Font("Inter", 9F);
        btnAcciones.Location = new Point(292, 144);
        btnAcciones.Margin = new Padding(3, 2, 3, 2);
        btnAcciones.Anchor = AnchorStyles.Top | AnchorStyles.Left;
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
        // cmsPuestos
        //
        cmsPuestos.SuspendLayout();
        cmsPuestos.Items.AddRange(new ToolStripItem[] { mnuEditarPuesto, separadorAcciones, mnuEliminarPuesto });
        cmsPuestos.Name = "cmsPuestos";
        cmsPuestos.Font = new Font("Inter", 9F);
        cmsPuestos.ShowImageMargin = false;
        cmsPuestos.Opening += cmsPuestos_Opening;
        //
        // mnuEditarPuesto
        //
        mnuEditarPuesto.Name = "mnuEditarPuesto";
        mnuEditarPuesto.Text = "Editar";
        mnuEditarPuesto.ForeColor = Color.FromArgb(32, 38, 45);
        //
        // mnuEliminarPuesto
        //
        mnuEliminarPuesto.Name = "mnuEliminarPuesto";
        mnuEliminarPuesto.Text = "Eliminar";
        mnuEliminarPuesto.ForeColor = Color.FromArgb(166, 61, 64);
        separadorAcciones.Name = "separadorAcciones";
        dgvPuestos.ContextMenuStrip = cmsPuestos;
        dgvPuestos.MouseDown += dgvPuestos_MouseDown;
        dgvPuestos.CellDoubleClick += dgvPuestos_CellDoubleClick;
        Controls.Add(btnAcciones);
        cmsPuestos.ResumeLayout(false);
        //
        // FrmPuestos
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1126, 744);
        Controls.Add(dgvPuestos);
        Controls.Add(lblPuestos);
        Controls.Add(btnAgregarPuesto);
        Controls.Add(cboEstado);
        Controls.Add(lblEstado);
        Controls.Add(cboDepartamento);
        Controls.Add(lblDepartamento);
        Controls.Add(lblNombrePuesto);
        Controls.Add(txtBuscar);
        Controls.Add(lblTitulo);
        Controls.Add(btnAnterior);
        Controls.Add(lblPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(cbotamanoPagina);
        Controls.Add(lblTamanoPagina);
        MinimumSize = new Size(1126, 744);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3);
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmPuestos";
        Text = "Puestos";
        Load += FrmPuestos_Load;
        ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private KovaqsUI.Controls.KButton btnAcciones;
    private ContextMenuStrip cmsPuestos;
    private ToolStripMenuItem mnuEditarPuesto;
    private ToolStripSeparator separadorAcciones;
    private ToolStripMenuItem mnuEliminarPuesto;

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KTextBox txtBuscar;
    private KovaqsUI.Controls.KLabel lblNombrePuesto;
    private KovaqsUI.Controls.KLabel lblDepartamento;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KLabel lblEstado;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KButton btnAgregarPuesto;
    private KovaqsUI.Controls.KLabel lblPuestos;
    private KovaqsUI.Controls.KDataGridView dgvPuestos;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KComboBox cbotamanoPagina;
    private KovaqsUI.Controls.KLabel lblTamanoPagina;
    private KovaqsUI.Components.KToastNotifier notificador;
    private DataGridViewTextBoxColumn colNombre;
    private DataGridViewTextBoxColumn colDepartamento;
    private DataGridViewTextBoxColumn colDescripcion;
    private DataGridViewCheckBoxColumn colActivo;
}
