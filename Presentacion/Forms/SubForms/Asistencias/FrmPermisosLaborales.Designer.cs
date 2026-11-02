namespace Presentacion.Forms.SubForms.Asistencias;

partial class FrmPermisosLaborales
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
        cmsPermisos = new ContextMenuStrip(components);
        mnuEditarPermiso = new ToolStripMenuItem();
        mnuResolverPermiso = new ToolStripMenuItem();
        separadorAcciones = new ToolStripSeparator();
        mnuCancelarPermiso = new ToolStripMenuItem();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        btnCerrar = new KovaqsUI.Controls.KButton();
        lblDesde = new KovaqsUI.Controls.KLabel();
        dtpDesde = new DateTimePicker();
        lblHasta = new KovaqsUI.Controls.KLabel();
        dtpHasta = new DateTimePicker();
        lblEstadoFiltro = new KovaqsUI.Controls.KLabel();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        lblBuscarEmpleado = new KovaqsUI.Controls.KLabel();
        txtBuscarEmpleado = new KovaqsUI.Controls.KTextBox();
        btnNuevoPermiso = new KovaqsUI.Controls.KButton();
        lblPermisosTitulo = new KovaqsUI.Controls.KLabel();
        dgvPermisos = new KovaqsUI.Controls.KDataGridView();
        colPermisosEmpleado = new DataGridViewTextBoxColumn();
        colPermisosInicio = new DataGridViewTextBoxColumn();
        colPermisosFin = new DataGridViewTextBoxColumn();
        colPermisosMotivo = new DataGridViewTextBoxColumn();
        colPermisosCongoce = new DataGridViewCheckBoxColumn();
        colPermisosEstado = new DataGridViewTextBoxColumn();
        btnAnterior = new KovaqsUI.Controls.KButton();
        lblPagina = new KovaqsUI.Controls.KLabel();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        lblTamanoPagina = new KovaqsUI.Controls.KLabel();
        cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
        dataGridViewCellStyle3.Font = new Font("Inter", 9F);
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.TabStop = false;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(740, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Permisos laborales";
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        //
        // btnCerrar
        //
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.BackColor = Color.Transparent;
        btnCerrar.CornerRadius = 8;
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.Font = new Font("Inter", 9F);
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
        btnCerrar.Padding = new Padding(10, 4, 10, 4);
        btnCerrar.Size = new Size(96, 40);
        btnCerrar.TabIndex = 1;
        btnCerrar.Text = "Cerrar";
        btnCerrar.UseVisualStyleBackColor = false;
        //
        // lblDesde
        //
        lblDesde.AutoSize = false;
        lblDesde.BackColor = Color.Transparent;
        lblDesde.ForeColor = Color.FromArgb(64, 64, 64);
        lblDesde.Location = new Point(16, 70);
        lblDesde.Font = new Font("Inter", 9F);
        lblDesde.TabStop = false;
        lblDesde.Name = "lblDesde";
        lblDesde.Size = new Size(278, 24);
        lblDesde.TabIndex = 2;
        lblDesde.Text = "Desde";
        lblDesde.TextAlign = ContentAlignment.MiddleLeft;
        lblDesde.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // dtpDesde
        //
        dtpDesde.CustomFormat = "dd/MM/yyyy";
        dtpDesde.Font = new Font("Inter", 10F);
        dtpDesde.Format = DateTimePickerFormat.Custom;
        dtpDesde.Location = new Point(16, 96);
        dtpDesde.MinimumSize = new Size(0, 34);
        dtpDesde.CalendarFont = new Font("Inter", 9F);
        dtpDesde.Name = "dtpDesde";
        dtpDesde.Size = new Size(278, 34);
        dtpDesde.TabIndex = 5;
        //
        // lblHasta
        //
        lblHasta.AutoSize = false;
        lblHasta.BackColor = Color.Transparent;
        lblHasta.ForeColor = Color.FromArgb(64, 64, 64);
        lblHasta.Location = new Point(312, 70);
        lblHasta.Font = new Font("Inter", 9F);
        lblHasta.TabStop = false;
        lblHasta.Name = "lblHasta";
        lblHasta.Size = new Size(278, 24);
        lblHasta.TabIndex = 3;
        lblHasta.Text = "Hasta";
        lblHasta.TextAlign = ContentAlignment.MiddleLeft;
        lblHasta.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // dtpHasta
        //
        dtpHasta.CustomFormat = "dd/MM/yyyy";
        dtpHasta.Font = new Font("Inter", 10F);
        dtpHasta.Format = DateTimePickerFormat.Custom;
        dtpHasta.Location = new Point(312, 96);
        dtpHasta.MinimumSize = new Size(0, 34);
        dtpHasta.CalendarFont = new Font("Inter", 9F);
        dtpHasta.Name = "dtpHasta";
        dtpHasta.Size = new Size(278, 34);
        dtpHasta.TabIndex = 6;
        //
        // lblEstadoFiltro
        //
        lblEstadoFiltro.AutoSize = false;
        lblEstadoFiltro.BackColor = Color.Transparent;
        lblEstadoFiltro.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoFiltro.Location = new Point(608, 70);
        lblEstadoFiltro.Font = new Font("Inter", 9F);
        lblEstadoFiltro.TabStop = false;
        lblEstadoFiltro.Name = "lblEstadoFiltro";
        lblEstadoFiltro.Size = new Size(278, 24);
        lblEstadoFiltro.TabIndex = 4;
        lblEstadoFiltro.Text = "Estado";
        lblEstadoFiltro.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoFiltro.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // cboEstado
        //
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Items.AddRange(new object[] { "Todos", "Pendiente", "Aprobado", "Rechazado", "Cancelado" });
        cboEstado.Location = new Point(608, 96);
        cboEstado.CornerRadius = 8;
        cboEstado.FillColor = Color.White;
        cboEstado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.GradientColor = Color.Empty;
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;

        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(278, 34);
        cboEstado.TabIndex = 7;
        //
        // lblBuscarEmpleado
        //
        lblBuscarEmpleado.AutoSize = false;
        lblBuscarEmpleado.BackColor = Color.Transparent;
        lblBuscarEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
        lblBuscarEmpleado.Location = new Point(16, 140);
        lblBuscarEmpleado.Font = new Font("Inter", 9F);
        lblBuscarEmpleado.TabStop = false;
        lblBuscarEmpleado.Name = "lblBuscarEmpleado";
        lblBuscarEmpleado.Size = new Size(278, 24);
        lblBuscarEmpleado.TabIndex = 8;
        lblBuscarEmpleado.Text = "Nombre o código";
        lblBuscarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
        lblBuscarEmpleado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // txtBuscarEmpleado
        //
        txtBuscarEmpleado.BackColor = Color.Transparent;
        txtBuscarEmpleado.CornerRadius = 8;
        txtBuscarEmpleado.Font = new Font("Inter", 9F);
        txtBuscarEmpleado.Location = new Point(16, 166);
        txtBuscarEmpleado.MaxLength = 100;
        txtBuscarEmpleado.FillColor = Color.White;
        txtBuscarEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
        txtBuscarEmpleado.BorderColor = Color.FromArgb(218, 218, 218);
        txtBuscarEmpleado.GradientColor = Color.Empty;
        txtBuscarEmpleado.BorderThickness = 1;
        txtBuscarEmpleado.Name = "txtBuscarEmpleado";
        txtBuscarEmpleado.Padding = new Padding(10, 6, 10, 6);
        txtBuscarEmpleado.Size = new Size(278, 34);
        txtBuscarEmpleado.TabIndex = 9;
        //
        // btnNuevoPermiso
        //
        btnNuevoPermiso.BackColor = Color.Transparent;
        btnNuevoPermiso.CornerRadius = 8;
        btnNuevoPermiso.FlatStyle = FlatStyle.Flat;
        btnNuevoPermiso.Font = new Font("Inter", 9F);
        btnNuevoPermiso.Location = new Point(16, 214);
        btnNuevoPermiso.BorderThickness = 1;
        btnNuevoPermiso.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnNuevoPermiso.FillColor = Color.FromArgb(49, 81, 107);
        btnNuevoPermiso.ForeColor = Color.White;
        btnNuevoPermiso.BorderColor = Color.FromArgb(49, 81, 107);
        btnNuevoPermiso.GradientColor = Color.Empty;
        btnNuevoPermiso.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnNuevoPermiso.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnNuevoPermiso.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnNuevoPermiso.Name = "btnNuevoPermiso";
        btnNuevoPermiso.Padding = new Padding(10, 4, 10, 4);
        btnNuevoPermiso.Size = new Size(208, 40);
        btnNuevoPermiso.TabIndex = 10;
        btnNuevoPermiso.Text = "Solicitar permiso";
        btnNuevoPermiso.UseVisualStyleBackColor = false;
        //
        // lblPermisosTitulo
        //
        lblPermisosTitulo.AutoSize = false;
        lblPermisosTitulo.BackColor = Color.Transparent;
        lblPermisosTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblPermisosTitulo.Location = new Point(16, 268);
        lblPermisosTitulo.Font = new Font("Inter", 9F);
        lblPermisosTitulo.TabStop = false;
        lblPermisosTitulo.Name = "lblPermisosTitulo";
        lblPermisosTitulo.Size = new Size(870, 24);
        lblPermisosTitulo.TabIndex = 14;
        lblPermisosTitulo.Text = "Permisos solicitados";
        lblPermisosTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblPermisosTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // dgvPermisos
        //
        dgvPermisos.AllowUserToAddRows = false;
        dgvPermisos.AllowUserToDeleteRows = false;
        dgvPermisos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPermisos.BackgroundColor = Color.White;
        dgvPermisos.BorderStyle = BorderStyle.None;
        dgvPermisos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvPermisos.ColumnHeadersHeight = 42;
        dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvPermisos.Columns.AddRange(new DataGridViewColumn[] { colPermisosEmpleado, colPermisosInicio, colPermisosFin, colPermisosMotivo, colPermisosCongoce, colPermisosEstado });
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Inter", 9F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvPermisos.DefaultCellStyle = dataGridViewCellStyle2;
        dgvPermisos.EnableHeadersVisualStyles = false;
        dgvPermisos.GridColor = Color.FromArgb(218, 218, 218);
        dgvPermisos.Location = new Point(16, 294);
        dgvPermisos.MultiSelect = false;
        dgvPermisos.Font = new Font("Inter", 9F);
        dgvPermisos.Name = "dgvPermisos";
        dgvPermisos.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvPermisos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvPermisos.RowHeadersVisible = false;
        dgvPermisos.RowTemplate.Height = 42;
        dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPermisos.Size = new Size(870, 292);
        dgvPermisos.TabIndex = 15;
        //
        // colPermisosEmpleado
        //
        colPermisosEmpleado.HeaderText = "Empleado";
        colPermisosEmpleado.Name = "colPermisosEmpleado";
        colPermisosEmpleado.ReadOnly = true;
        //
        // colPermisosInicio
        //
        colPermisosInicio.HeaderText = "Inicio";
        colPermisosInicio.Name = "colPermisosInicio";
        colPermisosInicio.ReadOnly = true;
        //
        // colPermisosFin
        //
        colPermisosFin.HeaderText = "Fin";
        colPermisosFin.Name = "colPermisosFin";
        colPermisosFin.ReadOnly = true;
        //
        // colPermisosMotivo
        //
        colPermisosMotivo.HeaderText = "Motivo";
        colPermisosMotivo.Name = "colPermisosMotivo";
        colPermisosMotivo.ReadOnly = true;
        //
        // colPermisosCongoce
        //
        colPermisosCongoce.HeaderText = "Con goce";
        colPermisosCongoce.Name = "colPermisosCongoce";
        colPermisosCongoce.ReadOnly = true;
        //
        // colPermisosEstado
        //
        colPermisosEstado.HeaderText = "Estado";
        colPermisosEstado.Name = "colPermisosEstado";
        colPermisosEstado.ReadOnly = true;
        //
        // btnAnterior
        //
        btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.CornerRadius = 8;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Font = new Font("Inter", 9F);
        btnAnterior.Location = new Point(16, 605);
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
        btnAnterior.TabIndex = 16;
        btnAnterior.Text = "Anterior";
        btnAnterior.UseVisualStyleBackColor = false;
        //
        // lblPagina
        //
        lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPagina.AutoSize = false;
        lblPagina.BackColor = Color.Transparent;
        lblPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblPagina.Location = new Point(150, 605);
        lblPagina.Font = new Font("Inter", 9F);
        lblPagina.TabStop = false;
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(130, 40);
        lblPagina.TabIndex = 17;
        lblPagina.Text = "Página 1 de 1";
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        lblPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // btnSiguiente
        //
        btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.CornerRadius = 8;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.Font = new Font("Inter", 9F);
        btnSiguiente.Location = new Point(290, 605);
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
        btnSiguiente.TabIndex = 18;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.UseVisualStyleBackColor = false;
        //
        // lblTamanoPagina
        //
        lblTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblTamanoPagina.AutoSize = false;
        lblTamanoPagina.BackColor = Color.Transparent;
        lblTamanoPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblTamanoPagina.Location = new Point(590, 605);
        lblTamanoPagina.Font = new Font("Inter", 9F);
        lblTamanoPagina.TabStop = false;
        lblTamanoPagina.Name = "lblTamanoPagina";
        lblTamanoPagina.Size = new Size(130, 40);
        lblTamanoPagina.TabIndex = 19;
        lblTamanoPagina.Text = "Filas por página";
        lblTamanoPagina.TextAlign = ContentAlignment.MiddleLeft;
        lblTamanoPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // cboTamanoPagina
        //
        cboTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cboTamanoPagina.Font = new Font("Inter", 9F);
        cboTamanoPagina.ItemHeight = 28;
        cboTamanoPagina.Items.AddRange(new object[] { "10", "25", "50", "100" });
        cboTamanoPagina.Location = new Point(730, 608);
        cboTamanoPagina.CornerRadius = 8;
        cboTamanoPagina.FillColor = Color.White;
        cboTamanoPagina.ForeColor = Color.FromArgb(32, 38, 45);
        cboTamanoPagina.BorderColor = Color.FromArgb(218, 218, 218);
        cboTamanoPagina.GradientColor = Color.Empty;
        cboTamanoPagina.DropDownStyle = ComboBoxStyle.DropDownList;

        cboTamanoPagina.Name = "cboTamanoPagina";
        cboTamanoPagina.Size = new Size(156, 34);
        cboTamanoPagina.TabIndex = 20;
        //
        // notificador
        //
        notificador.OwnerForm = this;
        btnAcciones.BackColor = Color.Transparent;
        btnAcciones.CornerRadius = 8;
        btnAcciones.FlatStyle = FlatStyle.Flat;
        btnAcciones.Font = new Font("Inter", 9F);
        btnAcciones.Location = new Point(236, 214);
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
        btnAcciones.Size = new Size(208, 40);
        btnAcciones.TabIndex = 11;
        btnAcciones.Text = "Acciones ▾";
        btnAcciones.UseVisualStyleBackColor = false;
        btnAcciones.Click += btnAcciones_Click;
        btnAcciones.Enabled = false;
        //
        // cmsPermisos
        //
        cmsPermisos.SuspendLayout();
        cmsPermisos.Items.AddRange(new ToolStripItem[] { mnuEditarPermiso, mnuResolverPermiso, separadorAcciones, mnuCancelarPermiso });
        cmsPermisos.Name = "cmsPermisos";
        cmsPermisos.Font = new Font("Inter", 9F);
        cmsPermisos.ShowImageMargin = false;
        cmsPermisos.Opening += cmsPermisos_Opening;
        //
        // mnuEditarPermiso
        //
        mnuEditarPermiso.Name = "mnuEditarPermiso";
        mnuEditarPermiso.Text = "Editar pendiente";
        mnuEditarPermiso.ForeColor = Color.FromArgb(32, 38, 45);
        //
        // mnuResolverPermiso
        //
        mnuResolverPermiso.Name = "mnuResolverPermiso";
        mnuResolverPermiso.Text = "Resolver";
        mnuResolverPermiso.ForeColor = Color.FromArgb(32, 38, 45);
        //
        // mnuCancelarPermiso
        //
        mnuCancelarPermiso.Name = "mnuCancelarPermiso";
        mnuCancelarPermiso.Text = "Cancelar permiso";
        mnuCancelarPermiso.ForeColor = Color.FromArgb(166, 61, 64);
        separadorAcciones.Name = "separadorAcciones";
        dgvPermisos.ContextMenuStrip = cmsPermisos;
        dgvPermisos.MouseDown += dgvPermisos_MouseDown;
        dgvPermisos.SelectionChanged += dgvPermisos_SelectionChanged;
        dgvPermisos.CellDoubleClick += dgvPermisos_CellDoubleClick;
        Controls.Add(btnAcciones);
        cmsPermisos.ResumeLayout(false);
        //
        // FrmPermisosLaborales
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        CancelButton = btnCerrar;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblDesde);
        Controls.Add(dtpDesde);
        Controls.Add(lblHasta);
        Controls.Add(dtpHasta);
        Controls.Add(lblEstadoFiltro);
        Controls.Add(cboEstado);
        Controls.Add(lblBuscarEmpleado);
        Controls.Add(txtBuscarEmpleado);
        Controls.Add(btnNuevoPermiso);
        Controls.Add(lblPermisosTitulo);
        Controls.Add(dgvPermisos);
        Controls.Add(btnAnterior);
        Controls.Add(lblPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(lblTamanoPagina);
        Controls.Add(cboTamanoPagina);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmPermisosLaborales";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Permisos laborales";
        Load += FrmPermisosLaborales_Load;
        ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KButton btnAcciones;
    private ContextMenuStrip cmsPermisos;
    private ToolStripMenuItem mnuEditarPermiso;
    private ToolStripMenuItem mnuResolverPermiso;
    private ToolStripSeparator separadorAcciones;
    private ToolStripMenuItem mnuCancelarPermiso;

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblDesde;
    private DateTimePicker dtpDesde;
    private KovaqsUI.Controls.KLabel lblHasta;
    private DateTimePicker dtpHasta;
    private KovaqsUI.Controls.KLabel lblEstadoFiltro;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KLabel lblBuscarEmpleado;
    private KovaqsUI.Controls.KTextBox txtBuscarEmpleado;
    private KovaqsUI.Controls.KButton btnNuevoPermiso;
    private KovaqsUI.Controls.KLabel lblPermisosTitulo;
    private KovaqsUI.Controls.KDataGridView dgvPermisos;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KLabel lblTamanoPagina;
    private KovaqsUI.Controls.KComboBox cboTamanoPagina;
    private DataGridViewTextBoxColumn colPermisosEmpleado;
    private DataGridViewTextBoxColumn colPermisosInicio;
    private DataGridViewTextBoxColumn colPermisosFin;
    private DataGridViewTextBoxColumn colPermisosMotivo;
    private DataGridViewCheckBoxColumn colPermisosCongoce;
    private DataGridViewTextBoxColumn colPermisosEstado;
    private KovaqsUI.Components.KToastNotifier notificador;
}
