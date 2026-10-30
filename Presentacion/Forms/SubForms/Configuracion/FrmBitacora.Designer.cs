namespace Presentacion.Forms.SubForms.Configuracion;

partial class FrmBitacora
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
        btnCerrar = new KovaqsUI.Controls.KButton();
        lblDesde = new KovaqsUI.Controls.KLabel();
        dtpDesde = new DateTimePicker();
        lblHasta = new KovaqsUI.Controls.KLabel();
        dtpHasta = new DateTimePicker();
        lblUsuario = new KovaqsUI.Controls.KLabel();
        cboUsuario = new KovaqsUI.Controls.KComboBox();
        lblOperacion = new KovaqsUI.Controls.KLabel();
        cboOperacion = new KovaqsUI.Controls.KComboBox();
        lblEntidad = new KovaqsUI.Controls.KLabel();
        cboEntidad = new KovaqsUI.Controls.KComboBox();
        btnConsultar = new KovaqsUI.Controls.KButton();
        btnLimpiarFiltros = new KovaqsUI.Controls.KButton();
        lblBitacoraTitulo = new KovaqsUI.Controls.KLabel();
        dgvBitacora = new KovaqsUI.Controls.KDataGridView();
        lblDescripcion = new KovaqsUI.Controls.KLabel();
        txtDescripcion = new KovaqsUI.Controls.KTextBox();
        colBitacoraFechayhora = new DataGridViewTextBoxColumn();
        colBitacoraUsuario = new DataGridViewTextBoxColumn();
        colBitacoraOperacion = new DataGridViewTextBoxColumn();
        colBitacoraEntidad = new DataGridViewTextBoxColumn();
        colBitacoraRegistro = new DataGridViewTextBoxColumn();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
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
        lblTitulo.Text = "Bitácora de operaciones";
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
        btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCerrar.Text = "Cerrar";
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.Location = new Point(790, 12);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(96, 40);
        btnCerrar.TabIndex = 1;
        //
        // lblDesde
        //
        lblDesde.AutoSize = false;
        lblDesde.BackColor = Color.Transparent;
        lblDesde.ForeColor = Color.FromArgb(64, 64, 64);
        lblDesde.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDesde.TextAlign = ContentAlignment.MiddleLeft;
        lblDesde.Text = "Desde";
        lblDesde.Location = new Point(16, 70);
        lblDesde.Name = "lblDesde";
        lblDesde.Size = new Size(278, 24);
        lblDesde.TabIndex = 2;
        lblDesde.TabStop = false;
        //
        // dtpDesde
        //
        dtpDesde.Font = new Font("Inter", 10F);
        dtpDesde.Format = DateTimePickerFormat.Custom;
        dtpDesde.CustomFormat = "dd/MM/yyyy";
        dtpDesde.MinimumSize = new Size(0, 34);
        dtpDesde.Location = new Point(16, 96);
        dtpDesde.Name = "dtpDesde";
        dtpDesde.Size = new Size(278, 34);
        dtpDesde.TabIndex = 3;
        //
        // lblHasta
        //
        lblHasta.AutoSize = false;
        lblHasta.BackColor = Color.Transparent;
        lblHasta.ForeColor = Color.FromArgb(64, 64, 64);
        lblHasta.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblHasta.TextAlign = ContentAlignment.MiddleLeft;
        lblHasta.Text = "Hasta";
        lblHasta.Location = new Point(312, 70);
        lblHasta.Name = "lblHasta";
        lblHasta.Size = new Size(278, 24);
        lblHasta.TabIndex = 4;
        lblHasta.TabStop = false;
        //
        // dtpHasta
        //
        dtpHasta.Font = new Font("Inter", 10F);
        dtpHasta.Format = DateTimePickerFormat.Custom;
        dtpHasta.CustomFormat = "dd/MM/yyyy";
        dtpHasta.MinimumSize = new Size(0, 34);
        dtpHasta.Location = new Point(312, 96);
        dtpHasta.Name = "dtpHasta";
        dtpHasta.Size = new Size(278, 34);
        dtpHasta.TabIndex = 5;
        //
        // lblUsuario
        //
        lblUsuario.AutoSize = false;
        lblUsuario.BackColor = Color.Transparent;
        lblUsuario.ForeColor = Color.FromArgb(64, 64, 64);
        lblUsuario.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
        lblUsuario.Text = "Usuario";
        lblUsuario.Location = new Point(608, 70);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(278, 24);
        lblUsuario.TabIndex = 6;
        lblUsuario.TabStop = false;
        //
        // cboUsuario
        //
        cboUsuario.Font = new Font("Inter", 9F);
        cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
        cboUsuario.FormattingEnabled = true;
        cboUsuario.Items.AddRange(new object[] { "Todos" });
        cboUsuario.Location = new Point(608, 96);
        cboUsuario.Name = "cboUsuario";
        cboUsuario.Size = new Size(278, 34);
        cboUsuario.TabIndex = 7;
        //
        // lblOperacion
        //
        lblOperacion.AutoSize = false;
        lblOperacion.BackColor = Color.Transparent;
        lblOperacion.ForeColor = Color.FromArgb(64, 64, 64);
        lblOperacion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblOperacion.TextAlign = ContentAlignment.MiddleLeft;
        lblOperacion.Text = "Operación";
        lblOperacion.Location = new Point(16, 140);
        lblOperacion.Name = "lblOperacion";
        lblOperacion.Size = new Size(278, 24);
        lblOperacion.TabIndex = 8;
        lblOperacion.TabStop = false;
        //
        // cboOperacion
        //
        cboOperacion.Font = new Font("Inter", 9F);
        cboOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
        cboOperacion.FormattingEnabled = true;
        cboOperacion.Items.AddRange(new object[] { "Todas", "INSERT", "UPDATE", "DELETE", "LOGIN", "LOGOUT" });
        cboOperacion.Location = new Point(16, 166);
        cboOperacion.Name = "cboOperacion";
        cboOperacion.Size = new Size(278, 34);
        cboOperacion.TabIndex = 9;
        //
        // lblEntidad
        //
        lblEntidad.AutoSize = false;
        lblEntidad.BackColor = Color.Transparent;
        lblEntidad.ForeColor = Color.FromArgb(64, 64, 64);
        lblEntidad.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEntidad.TextAlign = ContentAlignment.MiddleLeft;
        lblEntidad.Text = "Módulo / entidad";
        lblEntidad.Location = new Point(312, 140);
        lblEntidad.Name = "lblEntidad";
        lblEntidad.Size = new Size(278, 24);
        lblEntidad.TabIndex = 10;
        lblEntidad.TabStop = false;
        //
        // cboEntidad
        //
        cboEntidad.Font = new Font("Inter", 9F);
        cboEntidad.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEntidad.FormattingEnabled = true;
        cboEntidad.Items.AddRange(new object[] { "Todas", "Empleados", "Usuarios", "Departamentos", "Puestos", "Asistencias", "Nómina" });
        cboEntidad.Location = new Point(312, 166);
        cboEntidad.Name = "cboEntidad";
        cboEntidad.Size = new Size(278, 34);
        cboEntidad.TabIndex = 11;
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
        btnConsultar.Size = new Size(220, 40);
        btnConsultar.TabIndex = 12;
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
        btnLimpiarFiltros.Location = new Point(248, 214);
        btnLimpiarFiltros.Name = "btnLimpiarFiltros";
        btnLimpiarFiltros.Size = new Size(220, 40);
        btnLimpiarFiltros.TabIndex = 13;
        //
        // lblBitacoraTitulo
        //
        lblBitacoraTitulo.AutoSize = false;
        lblBitacoraTitulo.BackColor = Color.Transparent;
        lblBitacoraTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblBitacoraTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblBitacoraTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblBitacoraTitulo.Text = "Operaciones registradas";
        lblBitacoraTitulo.Location = new Point(16, 268);
        lblBitacoraTitulo.Name = "lblBitacoraTitulo";
        lblBitacoraTitulo.Size = new Size(870, 24);
        lblBitacoraTitulo.TabIndex = 14;
        lblBitacoraTitulo.TabStop = false;
        //
        // dgvBitacora
        //
        dgvBitacora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvBitacora.AllowUserToAddRows = false;
        dgvBitacora.AllowUserToDeleteRows = false;
        dgvBitacora.AutoGenerateColumns = false;
        dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvBitacora.ReadOnly = true;
        dgvBitacora.RowHeadersVisible = false;
        dgvBitacora.MultiSelect = false;
        dgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvBitacora.BackgroundColor = Color.White;
        dgvBitacora.BorderStyle = BorderStyle.None;
        dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvBitacora.ColumnHeadersHeight = 42;
        dgvBitacora.EnableHeadersVisualStyles = false;
        dgvBitacora.GridColor = Color.FromArgb(218, 218, 218);
        dgvBitacora.RowTemplate.Height = 42;
        dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvBitacora.DefaultCellStyle = dataGridViewCellStyle2;
        dgvBitacora.Location = new Point(16, 294);
        dgvBitacora.Name = "dgvBitacora";
        dgvBitacora.Size = new Size(870, 158);
        dgvBitacora.TabIndex = 15;
        dgvBitacora.Columns.AddRange(new DataGridViewColumn[] { colBitacoraFechayhora, colBitacoraUsuario, colBitacoraOperacion, colBitacoraEntidad, colBitacoraRegistro });
        //
        // lblDescripcion
        //
        lblDescripcion.AutoSize = false;
        lblDescripcion.BackColor = Color.Transparent;
        lblDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
        lblDescripcion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
        lblDescripcion.Text = "Descripción del registro seleccionado";
        lblDescripcion.Location = new Point(16, 472);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(870, 24);
        lblDescripcion.TabIndex = 16;
        lblDescripcion.TabStop = false;
        //
        // txtDescripcion
        //
        txtDescripcion.BackColor = Color.Transparent;
        txtDescripcion.CornerRadius = 8;
        txtDescripcion.Font = new Font("Inter", 9F);
        txtDescripcion.Padding = new Padding(10, 6, 10, 6);
        txtDescripcion.Multiline = true;
        txtDescripcion.ReadOnly = true;
        txtDescripcion.MaxLength = 500;
        txtDescripcion.Location = new Point(16, 498);
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(870, 80);
        txtDescripcion.TabIndex = 17;
        //
        // colBitacoraFechayhora
        //
        colBitacoraFechayhora.HeaderText = "Fecha y hora";
        colBitacoraFechayhora.Name = "colBitacoraFechayhora";
        colBitacoraFechayhora.ReadOnly = true;
        //
        // colBitacoraUsuario
        //
        colBitacoraUsuario.HeaderText = "Usuario";
        colBitacoraUsuario.Name = "colBitacoraUsuario";
        colBitacoraUsuario.ReadOnly = true;
        //
        // colBitacoraOperacion
        //
        colBitacoraOperacion.HeaderText = "Operación";
        colBitacoraOperacion.Name = "colBitacoraOperacion";
        colBitacoraOperacion.ReadOnly = true;
        //
        // colBitacoraEntidad
        //
        colBitacoraEntidad.HeaderText = "Entidad";
        colBitacoraEntidad.Name = "colBitacoraEntidad";
        colBitacoraEntidad.ReadOnly = true;
        //
        // colBitacoraRegistro
        //
        colBitacoraRegistro.HeaderText = "Registro";
        colBitacoraRegistro.Name = "colBitacoraRegistro";
        colBitacoraRegistro.ReadOnly = true;
        notificador.OwnerForm = this;
        //
        // FrmBitacora
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblDesde);
        Controls.Add(dtpDesde);
        Controls.Add(lblHasta);
        Controls.Add(dtpHasta);
        Controls.Add(lblUsuario);
        Controls.Add(cboUsuario);
        Controls.Add(lblOperacion);
        Controls.Add(cboOperacion);
        Controls.Add(lblEntidad);
        Controls.Add(cboEntidad);
        Controls.Add(btnConsultar);
        Controls.Add(btnLimpiarFiltros);
        Controls.Add(lblBitacoraTitulo);
        Controls.Add(dgvBitacora);
        Controls.Add(lblDescripcion);
        Controls.Add(txtDescripcion);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCerrar;
        Name = "FrmBitacora";
        Text = "Bitácora de operaciones";
        ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblDesde;
    private DateTimePicker dtpDesde;
    private KovaqsUI.Controls.KLabel lblHasta;
    private DateTimePicker dtpHasta;
    private KovaqsUI.Controls.KLabel lblUsuario;
    private KovaqsUI.Controls.KComboBox cboUsuario;
    private KovaqsUI.Controls.KLabel lblOperacion;
    private KovaqsUI.Controls.KComboBox cboOperacion;
    private KovaqsUI.Controls.KLabel lblEntidad;
    private KovaqsUI.Controls.KComboBox cboEntidad;
    private KovaqsUI.Controls.KButton btnConsultar;
    private KovaqsUI.Controls.KButton btnLimpiarFiltros;
    private KovaqsUI.Controls.KLabel lblBitacoraTitulo;
    private KovaqsUI.Controls.KDataGridView dgvBitacora;
    private KovaqsUI.Controls.KLabel lblDescripcion;
    private KovaqsUI.Controls.KTextBox txtDescripcion;
    private DataGridViewTextBoxColumn colBitacoraFechayhora;
    private DataGridViewTextBoxColumn colBitacoraUsuario;
    private DataGridViewTextBoxColumn colBitacoraOperacion;
    private DataGridViewTextBoxColumn colBitacoraEntidad;
    private DataGridViewTextBoxColumn colBitacoraRegistro;
    private KovaqsUI.Components.KToastNotifier notificador;
}
