namespace Presentacion.Forms.SubForms.Configuracion;

partial class FrmHorarios
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
        btnAcciones = new KovaqsUI.Controls.KButton();
        cmsHorarios = new ContextMenuStrip(components);
        mnuEditarHorario = new ToolStripMenuItem();
        separadorAcciones = new ToolStripSeparator();
        mnuEliminarHorario = new ToolStripMenuItem();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        btnCerrar = new KovaqsUI.Controls.KButton();
        lblBuscar = new KovaqsUI.Controls.KLabel();
        txtBuscar = new KovaqsUI.Controls.KTextBox();
        lblEstadoFiltro = new KovaqsUI.Controls.KLabel();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        btnNuevoHorario = new KovaqsUI.Controls.KButton();
        lblHorariosTitulo = new KovaqsUI.Controls.KLabel();
        dgvHorarios = new KovaqsUI.Controls.KDataGridView();
        colHorariosNombre = new DataGridViewTextBoxColumn();
        colHorariosDescripcion = new DataGridViewTextBoxColumn();
        colHorariosActivo = new DataGridViewCheckBoxColumn();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
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
        lblTitulo.Text = "Horarios de trabajo";
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(740, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.TabStop = false;
        //
        // btnCerrar
        //
        btnCerrar.BackColor = Color.Transparent;
        btnCerrar.CornerRadius = 8;
        btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.Font = new Font("Inter", 9F);
        btnCerrar.Padding = new Padding(10, 4, 10, 4);
        btnCerrar.UseVisualStyleBackColor = false;
        btnCerrar.Text = "Cerrar";
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.Location = new Point(790, 12);
        btnCerrar.BorderThickness = 1;
        btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCerrar.FillColor = Color.White;
        btnCerrar.ForeColor = Color.FromArgb(32, 38, 45);
        btnCerrar.BorderColor = Color.FromArgb(218, 218, 218);
        btnCerrar.GradientColor = Color.Empty;
        btnCerrar.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnCerrar.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnCerrar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(96, 40);
        btnCerrar.TabIndex = 1;
        //
        // lblBuscar
        //
        lblBuscar.AutoSize = false;
        lblBuscar.BackColor = Color.Transparent;
        lblBuscar.ForeColor = Color.FromArgb(64, 64, 64);
        lblBuscar.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
        lblBuscar.Text = "Nombre del horario";
        lblBuscar.Location = new Point(16, 70);
        lblBuscar.Font = new Font("Inter", 9F);
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(426, 24);
        lblBuscar.TabIndex = 2;
        lblBuscar.TabStop = false;
        //
        // txtBuscar
        //
        txtBuscar.BackColor = Color.Transparent;
        txtBuscar.CornerRadius = 8;
        txtBuscar.Font = new Font("Inter", 9F);
        txtBuscar.Padding = new Padding(10, 6, 10, 6);
        txtBuscar.MaxLength = 100;
        txtBuscar.Location = new Point(16, 96);
        txtBuscar.FillColor = Color.White;
        txtBuscar.ForeColor = Color.FromArgb(32, 38, 45);
        txtBuscar.BorderColor = Color.FromArgb(218, 218, 218);
        txtBuscar.GradientColor = Color.Empty;
        txtBuscar.BorderThickness = 1;
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Size = new Size(426, 34);
        txtBuscar.TabIndex = 4;
        //
        // lblEstadoFiltro
        //
        lblEstadoFiltro.AutoSize = false;
        lblEstadoFiltro.BackColor = Color.Transparent;
        lblEstadoFiltro.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoFiltro.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEstadoFiltro.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoFiltro.Text = "Estado";
        lblEstadoFiltro.Location = new Point(460, 70);
        lblEstadoFiltro.Font = new Font("Inter", 9F);
        lblEstadoFiltro.Name = "lblEstadoFiltro";
        lblEstadoFiltro.Size = new Size(426, 24);
        lblEstadoFiltro.TabIndex = 3;
        lblEstadoFiltro.TabStop = false;
        //
        // cboEstado
        //
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEstado.FormattingEnabled = true;
        cboEstado.Items.AddRange(new object[] { "Todos", "Activos", "Inactivos" });
        cboEstado.Location = new Point(460, 96);
        cboEstado.CornerRadius = 8;
        cboEstado.FillColor = Color.White;
        cboEstado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.GradientColor = Color.Empty;

        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(426, 34);
        cboEstado.TabIndex = 5;
        //
        // btnNuevoHorario
        //
        btnNuevoHorario.BackColor = Color.Transparent;
        btnNuevoHorario.CornerRadius = 8;
        btnNuevoHorario.FlatStyle = FlatStyle.Flat;
        btnNuevoHorario.Font = new Font("Inter", 9F);
        btnNuevoHorario.Padding = new Padding(10, 4, 10, 4);
        btnNuevoHorario.UseVisualStyleBackColor = false;
        btnNuevoHorario.Text = "Nuevo horario";
        btnNuevoHorario.Location = new Point(16, 144);
        btnNuevoHorario.BorderThickness = 1;
        btnNuevoHorario.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnNuevoHorario.FillColor = Color.FromArgb(49, 81, 107);
        btnNuevoHorario.ForeColor = Color.White;
        btnNuevoHorario.BorderColor = Color.FromArgb(49, 81, 107);
        btnNuevoHorario.GradientColor = Color.Empty;
        btnNuevoHorario.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnNuevoHorario.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnNuevoHorario.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnNuevoHorario.Name = "btnNuevoHorario";
        btnNuevoHorario.Size = new Size(220, 40);
        btnNuevoHorario.TabIndex = 6;
        //
        // lblHorariosTitulo
        //
        lblHorariosTitulo.AutoSize = false;
        lblHorariosTitulo.BackColor = Color.Transparent;
        lblHorariosTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblHorariosTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblHorariosTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblHorariosTitulo.Text = "Horarios disponibles";
        lblHorariosTitulo.Location = new Point(16, 198);
        lblHorariosTitulo.Font = new Font("Inter", 9F);
        lblHorariosTitulo.Name = "lblHorariosTitulo";
        lblHorariosTitulo.Size = new Size(870, 24);
        lblHorariosTitulo.TabIndex = 9;
        lblHorariosTitulo.TabStop = false;
        //
        // dgvHorarios
        //
        dgvHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvHorarios.AllowUserToAddRows = false;
        dgvHorarios.AllowUserToDeleteRows = false;
        dgvHorarios.AutoGenerateColumns = false;
        dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvHorarios.ReadOnly = true;
        dgvHorarios.RowHeadersVisible = false;
        dgvHorarios.MultiSelect = false;
        dgvHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHorarios.BackgroundColor = Color.White;
        dgvHorarios.BorderStyle = BorderStyle.None;
        dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvHorarios.ColumnHeadersHeight = 42;
        dgvHorarios.EnableHeadersVisualStyles = false;
        dgvHorarios.GridColor = Color.FromArgb(218, 218, 218);
        dgvHorarios.RowTemplate.Height = 42;
        dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvHorarios.DefaultCellStyle = dataGridViewCellStyle2;
        dgvHorarios.Location = new Point(16, 224);
        dgvHorarios.Font = new Font("Inter", 9F);
        dgvHorarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvHorarios.Name = "dgvHorarios";
        dgvHorarios.Size = new Size(870, 362);
        dgvHorarios.TabIndex = 10;
        dgvHorarios.Columns.AddRange(new DataGridViewColumn[] { colHorariosNombre, colHorariosDescripcion, colHorariosActivo });
        //
        // colHorariosNombre
        //
        colHorariosNombre.HeaderText = "Nombre";
        colHorariosNombre.Name = "colHorariosNombre";
        colHorariosNombre.ReadOnly = true;
        //
        // colHorariosDescripcion
        //
        colHorariosDescripcion.HeaderText = "Descripción";
        colHorariosDescripcion.Name = "colHorariosDescripcion";
        colHorariosDescripcion.ReadOnly = true;
        //
        // colHorariosActivo
        //
        colHorariosActivo.HeaderText = "Activo";
        colHorariosActivo.Name = "colHorariosActivo";
        colHorariosActivo.ReadOnly = true;
        notificador.OwnerForm = this;
        btnAcciones.BackColor = Color.Transparent;
        btnAcciones.CornerRadius = 8;
        btnAcciones.FlatStyle = FlatStyle.Flat;
        btnAcciones.Font = new Font("Inter", 9F);
        btnAcciones.Padding = new Padding(10, 4, 10, 4);
        btnAcciones.UseVisualStyleBackColor = false;
        btnAcciones.Text = "Acciones ▾";
        btnAcciones.Location = new Point(248, 144);
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
        btnAcciones.Size = new Size(220, 40);
        btnAcciones.TabIndex = 7;
        btnAcciones.Click += btnAcciones_Click;
        btnAcciones.Enabled = false;
        //
        // cmsHorarios
        //
        cmsHorarios.SuspendLayout();
        cmsHorarios.Items.AddRange(new ToolStripItem[] { mnuEditarHorario, separadorAcciones, mnuEliminarHorario });
        cmsHorarios.Name = "cmsHorarios";
        cmsHorarios.Font = new Font("Inter", 9F);
        cmsHorarios.ShowImageMargin = false;
        cmsHorarios.Opening += cmsHorarios_Opening;
        //
        // mnuEditarHorario
        //
        mnuEditarHorario.Name = "mnuEditarHorario";
        mnuEditarHorario.Text = "Editar";
        mnuEditarHorario.ForeColor = Color.FromArgb(32, 38, 45);
        //
        // mnuEliminarHorario
        //
        mnuEliminarHorario.Name = "mnuEliminarHorario";
        mnuEliminarHorario.Text = "Eliminar";
        mnuEliminarHorario.ForeColor = Color.FromArgb(166, 61, 64);
        separadorAcciones.Name = "separadorAcciones";
        dgvHorarios.ContextMenuStrip = cmsHorarios;
        dgvHorarios.MouseDown += dgvHorarios_MouseDown;
        dgvHorarios.SelectionChanged += dgvHorarios_SelectionChanged;
        dgvHorarios.CellDoubleClick += dgvHorarios_CellDoubleClick;
        Controls.Add(btnAcciones);
        cmsHorarios.ResumeLayout(false);
        //
        // FrmHorarios
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(lblEstadoFiltro);
        Controls.Add(cboEstado);
        Controls.Add(btnNuevoHorario);
        Controls.Add(lblHorariosTitulo);
        Controls.Add(dgvHorarios);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCerrar;
        Font = new Font("Segoe UI", 9F);
        Name = "FrmHorarios";
        Text = "Horarios de trabajo";
        ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KButton btnAcciones;
    private ContextMenuStrip cmsHorarios;
    private ToolStripMenuItem mnuEditarHorario;
    private ToolStripSeparator separadorAcciones;
    private ToolStripMenuItem mnuEliminarHorario;

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblBuscar;
    private KovaqsUI.Controls.KTextBox txtBuscar;
    private KovaqsUI.Controls.KLabel lblEstadoFiltro;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KButton btnNuevoHorario;
    private KovaqsUI.Controls.KLabel lblHorariosTitulo;
    private KovaqsUI.Controls.KDataGridView dgvHorarios;
    private DataGridViewTextBoxColumn colHorariosNombre;
    private DataGridViewTextBoxColumn colHorariosDescripcion;
    private DataGridViewCheckBoxColumn colHorariosActivo;
    private KovaqsUI.Components.KToastNotifier notificador;
}
