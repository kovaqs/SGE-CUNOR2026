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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        btnAcciones = new KovaqsUI.Controls.KButton();
        cmsHorarios = new ContextMenuStrip(components);
        mnuEditarHorario = new ToolStripMenuItem();
        separadorAcciones = new ToolStripSeparator();
        mnuEliminarHorario = new ToolStripMenuItem();
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
        cmsHorarios.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
        SuspendLayout();
        // 
        // btnAcciones
        // 
        btnAcciones.Appearance.Hover.FillColor = Color.FromArgb(239, 244, 248);
        btnAcciones.Appearance.Normal.BorderColor = Color.FromArgb(173, 190, 204);
        btnAcciones.Appearance.Normal.FillColor = Color.White;
        btnAcciones.Appearance.Normal.ForeColor = Color.FromArgb(49, 81, 107);
        btnAcciones.Appearance.Pressed.FillColor = Color.FromArgb(225, 235, 243);
        btnAcciones.BackColor = Color.Transparent;
        btnAcciones.BorderColor = Color.FromArgb(173, 190, 204);
        btnAcciones.CornerRadius = 8;
        btnAcciones.Enabled = false;
        btnAcciones.FillColor = Color.White;
        btnAcciones.FlatStyle = FlatStyle.Flat;
        btnAcciones.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnAcciones.Font = new Font("Inter", 9F);
        btnAcciones.ForeColor = Color.FromArgb(49, 81, 107);
        btnAcciones.Location = new Point(283, 192);
        btnAcciones.Margin = new Padding(3, 4, 3, 4);
        btnAcciones.Name = "btnAcciones";
        btnAcciones.Padding = new Padding(11, 5, 11, 5);
        btnAcciones.Size = new Size(251, 53);
        btnAcciones.TabIndex = 7;
        btnAcciones.Text = "Acciones ▾";
        btnAcciones.UseVisualStyleBackColor = false;
        btnAcciones.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnAcciones.Click += btnAcciones_Click;
        // 
        // cmsHorarios
        // 
        cmsHorarios.Font = new Font("Microsoft Sans Serif", 9F);
        cmsHorarios.ImageScalingSize = new Size(20, 20);
        cmsHorarios.Items.AddRange(new ToolStripItem[] { mnuEditarHorario, separadorAcciones, mnuEliminarHorario });
        cmsHorarios.Name = "cmsHorarios";
        cmsHorarios.ShowImageMargin = false;
        cmsHorarios.Size = new Size(105, 54);
        cmsHorarios.Opening += cmsHorarios_Opening;
        // 
        // mnuEditarHorario
        // 
        mnuEditarHorario.ForeColor = Color.FromArgb(32, 38, 45);
        mnuEditarHorario.Name = "mnuEditarHorario";
        mnuEditarHorario.Size = new Size(104, 22);
        mnuEditarHorario.Text = "Editar";
        // 
        // separadorAcciones
        // 
        separadorAcciones.Name = "separadorAcciones";
        separadorAcciones.Size = new Size(101, 6);
        // 
        // mnuEliminarHorario
        // 
        mnuEliminarHorario.ForeColor = Color.FromArgb(166, 61, 64);
        mnuEliminarHorario.Name = "mnuEliminarHorario";
        mnuEliminarHorario.Size = new Size(104, 22);
        mnuEliminarHorario.Text = "Eliminar";
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.Location = new Point(18, 16);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(846, 53);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Horarios de trabajo";
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        // 
        // btnCerrar
        // 
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnCerrar.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        btnCerrar.Appearance.Normal.FillColor = Color.White;
        btnCerrar.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        btnCerrar.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnCerrar.BackColor = Color.Transparent;
        btnCerrar.BorderColor = Color.FromArgb(218, 218, 218);
        btnCerrar.CornerRadius = 8;
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.FillColor = Color.White;
        btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnCerrar.Font = new Font("Inter", 9F);
        btnCerrar.ForeColor = Color.FromArgb(32, 38, 45);
        btnCerrar.Location = new Point(903, 16);
        btnCerrar.Margin = new Padding(3, 4, 3, 4);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Padding = new Padding(11, 5, 11, 5);
        btnCerrar.Size = new Size(110, 53);
        btnCerrar.TabIndex = 1;
        btnCerrar.Text = "Cerrar";
        btnCerrar.UseVisualStyleBackColor = false;
        btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // lblBuscar
        // 
        lblBuscar.AutoSize = false;
        lblBuscar.BackColor = Color.Transparent;
        lblBuscar.Font = new Font("Inter", 9F);
        lblBuscar.ForeColor = Color.FromArgb(64, 64, 64);
        lblBuscar.Location = new Point(18, 93);
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(487, 32);
        lblBuscar.TabIndex = 2;
        lblBuscar.Text = "Nombre del horario";
        lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
        lblBuscar.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // txtBuscar
        // 
        txtBuscar.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        txtBuscar.Appearance.Normal.FillColor = Color.White;
        txtBuscar.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        txtBuscar.BackColor = Color.Transparent;
        txtBuscar.BorderColor = Color.FromArgb(218, 218, 218);
        txtBuscar.CornerRadius = 8;
        txtBuscar.FillColor = Color.White;
        txtBuscar.Font = new Font("Inter", 9F);
        txtBuscar.ForeColor = Color.FromArgb(32, 38, 45);
        txtBuscar.Location = new Point(18, 128);
        txtBuscar.Margin = new Padding(3, 4, 3, 4);
        txtBuscar.MaxLength = 100;
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Padding = new Padding(11, 8, 11, 8);
        txtBuscar.Size = new Size(487, 45);
        txtBuscar.TabIndex = 4;
        // 
        // lblEstadoFiltro
        // 
        lblEstadoFiltro.AutoSize = false;
        lblEstadoFiltro.BackColor = Color.Transparent;
        lblEstadoFiltro.Font = new Font("Inter", 9F);
        lblEstadoFiltro.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoFiltro.Location = new Point(526, 93);
        lblEstadoFiltro.Name = "lblEstadoFiltro";
        lblEstadoFiltro.Size = new Size(487, 32);
        lblEstadoFiltro.TabIndex = 3;
        lblEstadoFiltro.Text = "Estado";
        lblEstadoFiltro.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoFiltro.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
        cboEstado.Items.AddRange(new object[] { "Todos", "Activos", "Inactivos" });
        cboEstado.Location = new Point(526, 128);
        cboEstado.Margin = new Padding(3, 4, 3, 4);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(486, 34);
        cboEstado.TabIndex = 5;
        // 
        // btnNuevoHorario
        // 
        btnNuevoHorario.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnNuevoHorario.Appearance.Normal.BorderColor = Color.FromArgb(49, 81, 107);
        btnNuevoHorario.Appearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
        btnNuevoHorario.Appearance.Normal.ForeColor = Color.White;
        btnNuevoHorario.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnNuevoHorario.BackColor = Color.Transparent;
        btnNuevoHorario.BorderColor = Color.FromArgb(49, 81, 107);
        btnNuevoHorario.CornerRadius = 8;
        btnNuevoHorario.FillColor = Color.FromArgb(49, 81, 107);
        btnNuevoHorario.FlatStyle = FlatStyle.Flat;
        btnNuevoHorario.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnNuevoHorario.Font = new Font("Inter", 9F);
        btnNuevoHorario.ForeColor = Color.White;
        btnNuevoHorario.Location = new Point(18, 192);
        btnNuevoHorario.Margin = new Padding(3, 4, 3, 4);
        btnNuevoHorario.Name = "btnNuevoHorario";
        btnNuevoHorario.Padding = new Padding(11, 5, 11, 5);
        btnNuevoHorario.Size = new Size(251, 53);
        btnNuevoHorario.TabIndex = 6;
        btnNuevoHorario.Text = "Nuevo horario";
        btnNuevoHorario.UseVisualStyleBackColor = false;
        // 
        // lblHorariosTitulo
        // 
        lblHorariosTitulo.AutoSize = false;
        lblHorariosTitulo.BackColor = Color.Transparent;
        lblHorariosTitulo.Font = new Font("Inter", 9F);
        lblHorariosTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblHorariosTitulo.Location = new Point(18, 264);
        lblHorariosTitulo.Name = "lblHorariosTitulo";
        lblHorariosTitulo.Size = new Size(994, 32);
        lblHorariosTitulo.TabIndex = 9;
        lblHorariosTitulo.Text = "Horarios disponibles";
        lblHorariosTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblHorariosTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // dgvHorarios
        // 
        dgvHorarios.AllowUserToAddRows = false;
        dgvHorarios.AllowUserToDeleteRows = false;
        dgvHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvHorarios.BackgroundColor = Color.White;
        dgvHorarios.BorderStyle = BorderStyle.None;
        dgvHorarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvHorarios.ColumnHeadersHeight = 42;
        dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvHorarios.Columns.AddRange(new DataGridViewColumn[] { colHorariosNombre, colHorariosDescripcion, colHorariosActivo });
        dgvHorarios.ContextMenuStrip = cmsHorarios;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvHorarios.DefaultCellStyle = dataGridViewCellStyle2;
        dgvHorarios.EnableHeadersVisualStyles = false;
        dgvHorarios.Font = new Font("Inter", 9F);
        dgvHorarios.GridColor = Color.FromArgb(218, 218, 218);
        dgvHorarios.Location = new Point(18, 299);
        dgvHorarios.Margin = new Padding(3, 4, 3, 4);
        dgvHorarios.MultiSelect = false;
        dgvHorarios.Name = "dgvHorarios";
        dgvHorarios.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvHorarios.RowHeadersVisible = false;
        dgvHorarios.RowHeadersWidth = 51;
        dgvHorarios.RowTemplate.Height = 42;
        dgvHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHorarios.Size = new Size(994, 483);
        dgvHorarios.TabIndex = 10;
        dgvHorarios.CellDoubleClick += dgvHorarios_CellDoubleClick;
        dgvHorarios.SelectionChanged += dgvHorarios_SelectionChanged;
        dgvHorarios.MouseDown += dgvHorarios_MouseDown;
        // 
        // colHorariosNombre
        // 
        colHorariosNombre.HeaderText = "Nombre";
        colHorariosNombre.MinimumWidth = 6;
        colHorariosNombre.Name = "colHorariosNombre";
        colHorariosNombre.ReadOnly = true;
        // 
        // colHorariosDescripcion
        // 
        colHorariosDescripcion.HeaderText = "Descripción";
        colHorariosDescripcion.MinimumWidth = 6;
        colHorariosDescripcion.Name = "colHorariosDescripcion";
        colHorariosDescripcion.ReadOnly = true;
        // 
        // colHorariosActivo
        // 
        colHorariosActivo.HeaderText = "Activo";
        colHorariosActivo.MinimumWidth = 6;
        colHorariosActivo.Name = "colHorariosActivo";
        colHorariosActivo.ReadOnly = true;
        // 
        // notificador
        // 
        notificador.OwnerForm = this;
        // 
        // FrmHorarios
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        CancelButton = btnCerrar;
        ClientSize = new Size(1031, 892);
        Controls.Add(btnAcciones);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(lblEstadoFiltro);
        Controls.Add(cboEstado);
        Controls.Add(btnNuevoHorario);
        Controls.Add(lblHorariosTitulo);
        Controls.Add(dgvHorarios);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmHorarios";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Horarios de trabajo";
        Load += FrmHorarios_Load;
        cmsHorarios.ResumeLayout(false);
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
