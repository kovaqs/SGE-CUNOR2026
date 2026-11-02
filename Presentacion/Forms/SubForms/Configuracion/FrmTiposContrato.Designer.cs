namespace Presentacion.Forms.SubForms.Configuracion;

partial class FrmTiposContrato
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
        lblNombre = new KovaqsUI.Controls.KLabel();
        txtNombre = new KovaqsUI.Controls.KTextBox();
        lblDescripcion = new KovaqsUI.Controls.KLabel();
        txtDescripcion = new KovaqsUI.Controls.KTextBox();
        chkActivo = new KovaqsUI.Controls.KCheckBox();
        lblTiposContratoTitulo = new KovaqsUI.Controls.KLabel();
        dgvTiposContrato = new KovaqsUI.Controls.KDataGridView();
        btnGuardar = new KovaqsUI.Controls.KButton();
        btnNuevo = new KovaqsUI.Controls.KButton();
        btnEliminar = new KovaqsUI.Controls.KButton();
        colTiposContratoNombre = new DataGridViewTextBoxColumn();
        colTiposContratoActivo = new DataGridViewCheckBoxColumn();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvTiposContrato).BeginInit();
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
        lblTitulo.Text = "Catálogo de tipos de contrato";
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
        // lblNombre
        //
        lblNombre.AutoSize = false;
        lblNombre.BackColor = Color.Transparent;
        lblNombre.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombre.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNombre.TextAlign = ContentAlignment.MiddleLeft;
        lblNombre.Text = "Nombre del tipo de contrato";
        lblNombre.Location = new Point(16, 70);
        lblNombre.Font = new Font("Inter", 9F);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(320, 24);
        lblNombre.TabIndex = 2;
        lblNombre.TabStop = false;
        //
        // txtNombre
        //
        txtNombre.BackColor = Color.Transparent;
        txtNombre.CornerRadius = 8;
        txtNombre.Font = new Font("Inter", 9F);
        txtNombre.Padding = new Padding(10, 6, 10, 6);
        txtNombre.MaxLength = 80;
        txtNombre.Location = new Point(16, 96);
        txtNombre.FillColor = Color.White;
        txtNombre.ForeColor = Color.FromArgb(32, 38, 45);
        txtNombre.BorderColor = Color.FromArgb(218, 218, 218);
        txtNombre.GradientColor = Color.Empty;
        txtNombre.BorderThickness = 1;
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(320, 34);
        txtNombre.TabIndex = 4;
        //
        // lblDescripcion
        //
        lblDescripcion.AutoSize = false;
        lblDescripcion.BackColor = Color.Transparent;
        lblDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
        lblDescripcion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
        lblDescripcion.Text = "Descripción";
        lblDescripcion.Location = new Point(16, 140);
        lblDescripcion.Font = new Font("Inter", 9F);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(320, 24);
        lblDescripcion.TabIndex = 6;
        lblDescripcion.TabStop = false;
        //
        // txtDescripcion
        //
        txtDescripcion.BackColor = Color.Transparent;
        txtDescripcion.CornerRadius = 8;
        txtDescripcion.Font = new Font("Inter", 9F);
        txtDescripcion.Padding = new Padding(10, 6, 10, 6);
        txtDescripcion.Multiline = true;
        txtDescripcion.MaxLength = 500;
        txtDescripcion.Location = new Point(16, 166);
        txtDescripcion.FillColor = Color.White;
        txtDescripcion.ForeColor = Color.FromArgb(32, 38, 45);
        txtDescripcion.BorderColor = Color.FromArgb(218, 218, 218);
        txtDescripcion.GradientColor = Color.Empty;
        txtDescripcion.BorderThickness = 1;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(320, 80);
        txtDescripcion.TabIndex = 7;
        //
        // chkActivo
        //
        chkActivo.Font = new Font("Inter", 9F);
        chkActivo.Text = "Tipo de contrato activo";
        chkActivo.Checked = true;
        chkActivo.Location = new Point(16, 284);
        chkActivo.ForeColor = Color.FromArgb(64, 64, 64);
        chkActivo.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkActivo.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
        chkActivo.CheckedState.ForeColor = Color.White;
        chkActivo.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkActivo.Name = "chkActivo";
        chkActivo.Size = new Size(320, 36);
        chkActivo.TabIndex = 8;
        //
        // lblTiposContratoTitulo
        //
        lblTiposContratoTitulo.AutoSize = false;
        lblTiposContratoTitulo.BackColor = Color.Transparent;
        lblTiposContratoTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblTiposContratoTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTiposContratoTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTiposContratoTitulo.Text = "Tipos de contrato";
        lblTiposContratoTitulo.Location = new Point(366, 70);
        lblTiposContratoTitulo.Font = new Font("Inter", 9F);
        lblTiposContratoTitulo.Name = "lblTiposContratoTitulo";
        lblTiposContratoTitulo.Size = new Size(520, 24);
        lblTiposContratoTitulo.TabIndex = 3;
        lblTiposContratoTitulo.TabStop = false;
        //
        // dgvTiposContrato
        //
        dgvTiposContrato.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvTiposContrato.AllowUserToAddRows = false;
        dgvTiposContrato.AllowUserToDeleteRows = false;
        dgvTiposContrato.AutoGenerateColumns = false;
        dgvTiposContrato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTiposContrato.ReadOnly = true;
        dgvTiposContrato.RowHeadersVisible = false;
        dgvTiposContrato.MultiSelect = false;
        dgvTiposContrato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTiposContrato.BackgroundColor = Color.White;
        dgvTiposContrato.BorderStyle = BorderStyle.None;
        dgvTiposContrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvTiposContrato.ColumnHeadersHeight = 42;
        dgvTiposContrato.EnableHeadersVisualStyles = false;
        dgvTiposContrato.GridColor = Color.FromArgb(218, 218, 218);
        dgvTiposContrato.RowTemplate.Height = 42;
        dgvTiposContrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvTiposContrato.DefaultCellStyle = dataGridViewCellStyle2;
        dgvTiposContrato.Location = new Point(366, 96);
        dgvTiposContrato.Font = new Font("Inter", 9F);
        dgvTiposContrato.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvTiposContrato.Name = "dgvTiposContrato";
        dgvTiposContrato.Size = new Size(520, 490);
        dgvTiposContrato.TabIndex = 5;
        dgvTiposContrato.Columns.AddRange(new DataGridViewColumn[] { colTiposContratoNombre, colTiposContratoActivo });
        //
        // btnGuardar
        //
        btnGuardar.BackColor = Color.Transparent;
        btnGuardar.CornerRadius = 8;
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.Font = new Font("Inter", 9F);
        btnGuardar.Padding = new Padding(10, 4, 10, 4);
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Text = "Guardar";
        btnGuardar.Location = new Point(16, 410);
        btnGuardar.BorderThickness = 1;
        btnGuardar.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnGuardar.FillColor = Color.FromArgb(49, 81, 107);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.BorderColor = Color.FromArgb(49, 81, 107);
        btnGuardar.GradientColor = Color.Empty;
        btnGuardar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnGuardar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnGuardar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(220, 40);
        btnGuardar.TabIndex = 9;
        //
        // btnNuevo
        //
        btnNuevo.BackColor = Color.Transparent;
        btnNuevo.CornerRadius = 8;
        btnNuevo.FlatStyle = FlatStyle.Flat;
        btnNuevo.Font = new Font("Inter", 9F);
        btnNuevo.Padding = new Padding(10, 4, 10, 4);
        btnNuevo.UseVisualStyleBackColor = false;
        btnNuevo.Text = "Nuevo / limpiar";
        btnNuevo.Location = new Point(16, 464);
        btnNuevo.BorderThickness = 1;
        btnNuevo.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnNuevo.FillColor = Color.White;
        btnNuevo.ForeColor = Color.FromArgb(32, 38, 45);
        btnNuevo.BorderColor = Color.FromArgb(218, 218, 218);
        btnNuevo.GradientColor = Color.Empty;
        btnNuevo.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnNuevo.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnNuevo.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.Size = new Size(220, 40);
        btnNuevo.TabIndex = 10;
        //
        // btnEliminar
        //
        btnEliminar.BackColor = Color.Transparent;
        btnEliminar.CornerRadius = 8;
        btnEliminar.FlatStyle = FlatStyle.Flat;
        btnEliminar.Font = new Font("Inter", 9F);
        btnEliminar.Padding = new Padding(10, 4, 10, 4);
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Text = "Eliminar";
        btnEliminar.Location = new Point(16, 518);
        btnEliminar.BorderThickness = 1;
        btnEliminar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
        btnEliminar.FillColor = Color.FromArgb(166, 61, 64);
        btnEliminar.ForeColor = Color.White;
        btnEliminar.BorderColor = Color.FromArgb(166, 61, 64);
        btnEliminar.GradientColor = Color.Empty;
        btnEliminar.Appearance.Hover.FillColor = Color.FromArgb(145, 49, 53);
        btnEliminar.Appearance.Pressed.FillColor = Color.FromArgb(123, 40, 44);
        btnEliminar.FocusAppearance.Color = Color.FromArgb(255, 225, 226);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(220, 40);
        btnEliminar.TabIndex = 11;
        //
        // colTiposContratoNombre
        //
        colTiposContratoNombre.HeaderText = "Nombre";
        colTiposContratoNombre.Name = "colTiposContratoNombre";
        colTiposContratoNombre.ReadOnly = true;
        //
        // colTiposContratoActivo
        //
        colTiposContratoActivo.HeaderText = "Activo";
        colTiposContratoActivo.Name = "colTiposContratoActivo";
        colTiposContratoActivo.ReadOnly = true;
        notificador.OwnerForm = this;
        //
        // FrmTiposContrato
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(lblDescripcion);
        Controls.Add(txtDescripcion);
        Controls.Add(chkActivo);
        Controls.Add(lblTiposContratoTitulo);
        Controls.Add(dgvTiposContrato);
        Controls.Add(btnGuardar);
        Controls.Add(btnNuevo);
        Controls.Add(btnEliminar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCerrar;
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmTiposContrato";
        Text = "Catálogo de tipos de contrato";
        ((System.ComponentModel.ISupportInitialize)dgvTiposContrato).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblNombre;
    private KovaqsUI.Controls.KTextBox txtNombre;
    private KovaqsUI.Controls.KLabel lblDescripcion;
    private KovaqsUI.Controls.KTextBox txtDescripcion;
    private KovaqsUI.Controls.KCheckBox chkActivo;
    private KovaqsUI.Controls.KLabel lblTiposContratoTitulo;
    private KovaqsUI.Controls.KDataGridView dgvTiposContrato;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnNuevo;
    private KovaqsUI.Controls.KButton btnEliminar;
    private DataGridViewTextBoxColumn colTiposContratoNombre;
    private DataGridViewCheckBoxColumn colTiposContratoActivo;
    private KovaqsUI.Components.KToastNotifier notificador;
}
