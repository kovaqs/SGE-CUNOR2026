namespace Presentacion.Forms.Secciones;

partial class FrmDepartamentos
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
        lblBuscar = new KovaqsUI.Controls.KLabel();
        lblEstado = new KovaqsUI.Controls.KLabel();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        btnAgregarDepartamento = new KovaqsUI.Controls.KButton();
        lblDepartamentos = new KovaqsUI.Controls.KLabel();
        dgvDepartamentos = new KovaqsUI.Controls.KDataGridView();
        lblPagina = new KovaqsUI.Controls.KLabel();
        btnAnterior = new KovaqsUI.Controls.KButton();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
        ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).BeginInit();
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
        lblTamanoPagina.TabIndex = 13;
        lblTamanoPagina.TabStop = false;
        lblTamanoPagina.Name = "lblTamanoPagina";
        components = new System.ComponentModel.Container();
        btnAcciones = new KovaqsUI.Controls.KButton();
        cmsDepartamentos = new ContextMenuStrip(components);
        mnuEditarDepartamento = new ToolStripMenuItem();
        separadorAcciones = new ToolStripSeparator();
        mnuEliminarDepartamento = new ToolStripMenuItem();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        notificador.OwnerForm = this;
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle3.Font = new Font("Inter", 9F);
        colNombre = new DataGridViewTextBoxColumn();
        colNombre.Name = "colNombre";
        colNombre.HeaderText = "Nombre";
        colNombre.DataPropertyName = "Nombre";
        colNombre.FillWeight = 38F;
        colNombre.ReadOnly = true;
        colDescripcion = new DataGridViewTextBoxColumn();
        colDescripcion.Name = "colDescripcion";
        colDescripcion.HeaderText = "Descripción";
        colDescripcion.DataPropertyName = "Descripcion";
        colDescripcion.FillWeight = 52F;
        colDescripcion.ReadOnly = true;
        colActivo = new DataGridViewCheckBoxColumn();
        colActivo.Name = "colActivo";
        colActivo.HeaderText = "Activo";
        colActivo.DataPropertyName = "Activo";
        colActivo.FillWeight = 10F;
        colActivo.ReadOnly = true;
        dgvDepartamentos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colDescripcion, colActivo });
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
        lblTitulo.Text = "Departamentos";
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
        txtBuscar.TabIndex = 3;
        //
        // lblBuscar
        //
        lblBuscar.BackColor = Color.Transparent;
        lblBuscar.Font = new Font("Inter", 9F);
        lblBuscar.Location = new Point(16, 70);
        lblBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
        lblBuscar.ForeColor = Color.FromArgb(64, 64, 64);
        lblBuscar.AutoSize = false;
        lblBuscar.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblBuscar.TabStop = false;
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(354, 24);
        lblBuscar.TabIndex = 1;
        lblBuscar.Text = "Nombre del departamento";
        //
        // lblEstado
        //
        lblEstado.BackColor = Color.Transparent;
        lblEstado.Font = new Font("Inter", 9F);
        lblEstado.Location = new Point(386, 70);
        lblEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblEstado.TextAlign = ContentAlignment.MiddleLeft;
        lblEstado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstado.AutoSize = false;
        lblEstado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEstado.TabStop = false;
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(354, 24);
        lblEstado.TabIndex = 2;
        lblEstado.Text = "Estado";
        //
        // cboEstado
        //
        cboEstado.CornerRadius = 8;
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Items.AddRange(new object[] { "Todos", "Activo", "Inactivo" });
        cboEstado.Location = new Point(386, 96);
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
        cboEstado.TabIndex = 4;
        //
        // btnAgregarDepartamento
        //
        btnAgregarDepartamento.BackColor = Color.Transparent;
        btnAgregarDepartamento.CornerRadius = 8;
        btnAgregarDepartamento.FlatStyle = FlatStyle.Flat;
        btnAgregarDepartamento.Font = new Font("Inter", 9F);
        btnAgregarDepartamento.Location = new Point(16, 144);
        btnAgregarDepartamento.Margin = new Padding(3, 2, 3, 2);
        btnAgregarDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnAgregarDepartamento.BorderThickness = 1;
        btnAgregarDepartamento.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnAgregarDepartamento.FillColor = Color.FromArgb(49, 81, 107);
        btnAgregarDepartamento.ForeColor = Color.White;
        btnAgregarDepartamento.BorderColor = Color.FromArgb(49, 81, 107);
        btnAgregarDepartamento.GradientColor = Color.Empty;
        btnAgregarDepartamento.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnAgregarDepartamento.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnAgregarDepartamento.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnAgregarDepartamento.Name = "btnAgregarDepartamento";
        btnAgregarDepartamento.Padding = new Padding(10, 4, 10, 4);
        btnAgregarDepartamento.Size = new Size(264, 40);
        btnAgregarDepartamento.TabIndex = 5;
        btnAgregarDepartamento.Text = "Agregar";
        btnAgregarDepartamento.UseVisualStyleBackColor = false;
        //
        // lblDepartamentos
        //
        lblDepartamentos.BackColor = Color.Transparent;
        lblDepartamentos.Font = new Font("Inter", 9F);
        lblDepartamentos.Location = new Point(16, 198);
        lblDepartamentos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblDepartamentos.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamentos.AutoSize = false;
        lblDepartamentos.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDepartamentos.TabStop = false;
        lblDepartamentos.Name = "lblDepartamentos";
        lblDepartamentos.Size = new Size(1094, 24);
        lblDepartamentos.TabIndex = 8;
        lblDepartamentos.Text = "Departamentos registrados";
        //
        // dgvDepartamentos
        //
        dgvDepartamentos.AllowUserToAddRows = false;
        dgvDepartamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDepartamentos.BackgroundColor = Color.White;
        dgvDepartamentos.BorderStyle = BorderStyle.None;
        dgvDepartamentos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvDepartamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Inter", 9F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvDepartamentos.DefaultCellStyle = dataGridViewCellStyle2;
        dgvDepartamentos.EnableHeadersVisualStyles = false;
        dgvDepartamentos.GridColor = Color.FromArgb(218, 218, 218);
        dgvDepartamentos.Location = new Point(16, 224);
        dgvDepartamentos.Margin = new Padding(3, 2, 3, 2);
        dgvDepartamentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvDepartamentos.Font = new Font("Inter", 9F);
        dgvDepartamentos.ColumnHeadersHeight = 42;
        dgvDepartamentos.MultiSelect = false;
        dgvDepartamentos.AllowUserToDeleteRows = false;
        dgvDepartamentos.AutoGenerateColumns = false;
        dgvDepartamentos.Name = "dgvDepartamentos";
        dgvDepartamentos.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvDepartamentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvDepartamentos.RowHeadersVisible = false;
        dgvDepartamentos.RowHeadersWidth = 51;
        dgvDepartamentos.RowTemplate.Height = 42;
        dgvDepartamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDepartamentos.Size = new Size(1094, 448);
        dgvDepartamentos.TabIndex = 9;
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
        lblPagina.TabIndex = 11;
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
        btnAnterior.TabIndex = 10;
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
        btnSiguiente.TabIndex = 12;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.UseVisualStyleBackColor = false;
        //
        // cboTamanoPagina
        //
        cboTamanoPagina.FormattingEnabled = true;
        cboTamanoPagina.ItemHeight = 28;
        cboTamanoPagina.Items.AddRange(new object[] { "10", "25", "50", "100" });
        cboTamanoPagina.Location = new Point(954, 691);
        cboTamanoPagina.Margin = new Padding(3, 2, 3, 2);
        cboTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cboTamanoPagina.Font = new Font("Inter", 9F);
        cboTamanoPagina.CornerRadius = 8;
        cboTamanoPagina.FillColor = Color.White;
        cboTamanoPagina.ForeColor = Color.FromArgb(32, 38, 45);
        cboTamanoPagina.BorderColor = Color.FromArgb(218, 218, 218);
        cboTamanoPagina.GradientColor = Color.Empty;
        cboTamanoPagina.DropDownStyle = ComboBoxStyle.DropDownList;

        cboTamanoPagina.Name = "cboTamanoPagina";
        cboTamanoPagina.Size = new Size(156, 34);
        cboTamanoPagina.TabIndex = 14;
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
        btnAcciones.TabIndex = 6;
        btnAcciones.Text = "Acciones ▾";
        btnAcciones.UseVisualStyleBackColor = false;
        btnAcciones.Click += btnAcciones_Click;
        btnAcciones.Enabled = false;
        //
        // cmsDepartamentos
        //
        cmsDepartamentos.SuspendLayout();
        cmsDepartamentos.Items.AddRange(new ToolStripItem[] { mnuEditarDepartamento, separadorAcciones, mnuEliminarDepartamento });
        cmsDepartamentos.Name = "cmsDepartamentos";
        cmsDepartamentos.Font = new Font("Inter", 9F);
        cmsDepartamentos.ShowImageMargin = false;
        cmsDepartamentos.Opening += cmsDepartamentos_Opening;
        //
        // mnuEditarDepartamento
        //
        mnuEditarDepartamento.Name = "mnuEditarDepartamento";
        mnuEditarDepartamento.Text = "Editar";
        mnuEditarDepartamento.ForeColor = Color.FromArgb(32, 38, 45);
        //
        // mnuEliminarDepartamento
        //
        mnuEliminarDepartamento.Name = "mnuEliminarDepartamento";
        mnuEliminarDepartamento.Text = "Eliminar";
        mnuEliminarDepartamento.ForeColor = Color.FromArgb(166, 61, 64);
        separadorAcciones.Name = "separadorAcciones";
        dgvDepartamentos.ContextMenuStrip = cmsDepartamentos;
        dgvDepartamentos.MouseDown += dgvDepartamentos_MouseDown;
        dgvDepartamentos.SelectionChanged += dgvDepartamentos_SelectionChanged;
        dgvDepartamentos.CellDoubleClick += dgvDepartamentos_CellDoubleClick;
        Controls.Add(btnAcciones);
        cmsDepartamentos.ResumeLayout(false);
        //
        // FrmDepartamentos
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1126, 744);
        Controls.Add(dgvDepartamentos);
        Controls.Add(lblDepartamentos);
        Controls.Add(btnAgregarDepartamento);
        Controls.Add(cboEstado);
        Controls.Add(lblEstado);
        Controls.Add(lblBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(lblTitulo);
        Controls.Add(btnAnterior);
        Controls.Add(lblPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(cboTamanoPagina);
        Controls.Add(lblTamanoPagina);
        MinimumSize = new Size(1126, 744);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3);
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmDepartamentos";
        Text = "Departamentos";
        ((System.ComponentModel.ISupportInitialize)dgvDepartamentos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private KovaqsUI.Controls.KButton btnAcciones;
    private ContextMenuStrip cmsDepartamentos;
    private ToolStripMenuItem mnuEditarDepartamento;
    private ToolStripSeparator separadorAcciones;
    private ToolStripMenuItem mnuEliminarDepartamento;

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KTextBox txtBuscar;
    private KovaqsUI.Controls.KLabel lblBuscar;
    private KovaqsUI.Controls.KLabel lblEstado;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KButton btnAgregarDepartamento;
    private KovaqsUI.Controls.KLabel lblDepartamentos;
    private KovaqsUI.Controls.KDataGridView dgvDepartamentos;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KComboBox cboTamanoPagina;
    private KovaqsUI.Controls.KLabel lblTamanoPagina;
    private KovaqsUI.Components.KToastNotifier notificador;
    private DataGridViewTextBoxColumn colNombre;
    private DataGridViewTextBoxColumn colDescripcion;
    private DataGridViewCheckBoxColumn colActivo;
}
