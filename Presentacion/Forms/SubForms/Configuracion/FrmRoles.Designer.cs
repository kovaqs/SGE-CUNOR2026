namespace Presentacion.Forms.SubForms.Configuracion;

partial class FrmRoles
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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        btnCerrar = new KovaqsUI.Controls.KButton();
        lblRolesTitulo = new KovaqsUI.Controls.KLabel();
        dgvRoles = new KovaqsUI.Controls.KDataGridView();
        lblNombre = new KovaqsUI.Controls.KLabel();
        txtNombre = new KovaqsUI.Controls.KTextBox();
        lblDescripcion = new KovaqsUI.Controls.KLabel();
        txtDescripcion = new KovaqsUI.Controls.KTextBox();
        chkActivo = new KovaqsUI.Controls.KCheckBox();
        lblPermisosTitulo = new KovaqsUI.Controls.KLabel();
        dgvPermisos = new KovaqsUI.Controls.KDataGridView();
        btnGuardar = new KovaqsUI.Controls.KButton();
        btnCancelar = new KovaqsUI.Controls.KButton();
        colRolesRol = new DataGridViewTextBoxColumn();
        colRolesActivo = new DataGridViewCheckBoxColumn();
        colPermisosAsignado = new DataGridViewCheckBoxColumn();
        colPermisosPermisodelsistema = new DataGridViewTextBoxColumn();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
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
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dataGridViewCellStyle4.BackColor = Color.White;
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle4.Font = new Font("Inter", 9F);
        dataGridViewCellStyle4.Padding = new Padding(8, 4, 8, 4);
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Text = "Roles y permisos del sistema";
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
        // lblRolesTitulo
        //
        lblRolesTitulo.AutoSize = false;
        lblRolesTitulo.BackColor = Color.Transparent;
        lblRolesTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblRolesTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblRolesTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblRolesTitulo.Text = "Roles";
        lblRolesTitulo.Location = new Point(16, 70);
        lblRolesTitulo.Font = new Font("Inter", 9F);
        lblRolesTitulo.Name = "lblRolesTitulo";
        lblRolesTitulo.Size = new Size(270, 24);
        lblRolesTitulo.TabIndex = 2;
        lblRolesTitulo.TabStop = false;
        //
        // dgvRoles
        //
        dgvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvRoles.AllowUserToAddRows = false;
        dgvRoles.AllowUserToDeleteRows = false;
        dgvRoles.AutoGenerateColumns = false;
        dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvRoles.ReadOnly = true;
        dgvRoles.RowHeadersVisible = false;
        dgvRoles.MultiSelect = false;
        dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRoles.BackgroundColor = Color.White;
        dgvRoles.BorderStyle = BorderStyle.None;
        dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvRoles.ColumnHeadersHeight = 42;
        dgvRoles.EnableHeadersVisualStyles = false;
        dgvRoles.GridColor = Color.FromArgb(218, 218, 218);
        dgvRoles.RowTemplate.Height = 42;
        dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvRoles.DefaultCellStyle = dataGridViewCellStyle2;
        dgvRoles.Location = new Point(16, 96);
        dgvRoles.Font = new Font("Inter", 9F);
        dgvRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvRoles.Name = "dgvRoles";
        dgvRoles.Size = new Size(270, 490);
        dgvRoles.TabIndex = 5;
        dgvRoles.Columns.AddRange(new DataGridViewColumn[] { colRolesRol, colRolesActivo });
        //
        // lblNombre
        //
        lblNombre.AutoSize = false;
        lblNombre.BackColor = Color.Transparent;
        lblNombre.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombre.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNombre.TextAlign = ContentAlignment.MiddleLeft;
        lblNombre.Text = "Nombre del rol";
        lblNombre.Location = new Point(310, 70);
        lblNombre.Font = new Font("Inter", 9F);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(279, 24);
        lblNombre.TabIndex = 3;
        lblNombre.TabStop = false;
        //
        // txtNombre
        //
        txtNombre.BackColor = Color.Transparent;
        txtNombre.CornerRadius = 8;
        txtNombre.Font = new Font("Inter", 9F);
        txtNombre.Padding = new Padding(10, 6, 10, 6);
        txtNombre.MaxLength = 50;
        txtNombre.Location = new Point(310, 96);
        txtNombre.FillColor = Color.White;
        txtNombre.ForeColor = Color.FromArgb(32, 38, 45);
        txtNombre.BorderColor = Color.FromArgb(218, 218, 218);
        txtNombre.GradientColor = Color.Empty;
        txtNombre.BorderThickness = 1;
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(279, 34);
        txtNombre.TabIndex = 6;
        //
        // lblDescripcion
        //
        lblDescripcion.AutoSize = false;
        lblDescripcion.BackColor = Color.Transparent;
        lblDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
        lblDescripcion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
        lblDescripcion.Text = "Descripción";
        lblDescripcion.Location = new Point(607, 70);
        lblDescripcion.Font = new Font("Inter", 9F);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(279, 24);
        lblDescripcion.TabIndex = 4;
        lblDescripcion.TabStop = false;
        //
        // txtDescripcion
        //
        txtDescripcion.BackColor = Color.Transparent;
        txtDescripcion.CornerRadius = 8;
        txtDescripcion.Font = new Font("Inter", 9F);
        txtDescripcion.Padding = new Padding(10, 6, 10, 6);
        txtDescripcion.MaxLength = 250;
        txtDescripcion.Location = new Point(607, 96);
        txtDescripcion.FillColor = Color.White;
        txtDescripcion.ForeColor = Color.FromArgb(32, 38, 45);
        txtDescripcion.BorderColor = Color.FromArgb(218, 218, 218);
        txtDescripcion.GradientColor = Color.Empty;
        txtDescripcion.BorderThickness = 1;
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(279, 34);
        txtDescripcion.TabIndex = 7;
        //
        // chkActivo
        //
        chkActivo.Font = new Font("Inter", 9F);
        chkActivo.Text = "Rol activo";
        chkActivo.Checked = true;
        chkActivo.Location = new Point(310, 164);
        chkActivo.ForeColor = Color.FromArgb(64, 64, 64);
        chkActivo.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkActivo.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
        chkActivo.CheckedState.ForeColor = Color.White;
        chkActivo.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkActivo.Name = "chkActivo";
        chkActivo.Size = new Size(279, 36);
        chkActivo.TabIndex = 8;
        //
        // lblPermisosTitulo
        //
        lblPermisosTitulo.AutoSize = false;
        lblPermisosTitulo.BackColor = Color.Transparent;
        lblPermisosTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblPermisosTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPermisosTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblPermisosTitulo.Text = "Permisos asignados";
        lblPermisosTitulo.Location = new Point(310, 250);
        lblPermisosTitulo.Font = new Font("Inter", 9F);
        lblPermisosTitulo.Name = "lblPermisosTitulo";
        lblPermisosTitulo.Size = new Size(576, 24);
        lblPermisosTitulo.TabIndex = 9;
        lblPermisosTitulo.TabStop = false;
        //
        // dgvPermisos
        //
        dgvPermisos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvPermisos.AllowUserToAddRows = false;
        dgvPermisos.AllowUserToDeleteRows = false;
        dgvPermisos.AutoGenerateColumns = false;
        dgvPermisos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPermisos.ReadOnly = false;
        dgvPermisos.RowHeadersVisible = false;
        dgvPermisos.MultiSelect = false;
        dgvPermisos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPermisos.BackgroundColor = Color.White;
        dgvPermisos.BorderStyle = BorderStyle.None;
        dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvPermisos.ColumnHeadersHeight = 42;
        dgvPermisos.EnableHeadersVisualStyles = false;
        dgvPermisos.GridColor = Color.FromArgb(218, 218, 218);
        dgvPermisos.RowTemplate.Height = 42;
        dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvPermisos.DefaultCellStyle = dataGridViewCellStyle4;
        dgvPermisos.Location = new Point(310, 276);
        dgvPermisos.Font = new Font("Inter", 9F);
        dgvPermisos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvPermisos.Name = "dgvPermisos";
        dgvPermisos.Size = new Size(576, 310);
        dgvPermisos.TabIndex = 10;
        dgvPermisos.Columns.AddRange(new DataGridViewColumn[] { colPermisosAsignado, colPermisosPermisodelsistema });
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
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnGuardar.Location = new Point(586, 613);
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
        btnGuardar.Size = new Size(144, 40);
        btnGuardar.TabIndex = 11;
        //
        // btnCancelar
        //
        btnCancelar.BackColor = Color.Transparent;
        btnCancelar.CornerRadius = 8;
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.Font = new Font("Inter", 9F);
        btnCancelar.Padding = new Padding(10, 4, 10, 4);
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Text = "Cancelar";
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.Location = new Point(742, 613);
        btnCancelar.BorderThickness = 1;
        btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
        btnCancelar.FillColor = Color.FromArgb(255, 248, 248);
        btnCancelar.ForeColor = Color.FromArgb(166, 61, 64);
        btnCancelar.BorderColor = Color.FromArgb(204, 148, 150);
        btnCancelar.GradientColor = Color.Empty;
        btnCancelar.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
        btnCancelar.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
        btnCancelar.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(144, 40);
        btnCancelar.TabIndex = 12;
        //
        // colRolesRol
        //
        colRolesRol.HeaderText = "Rol";
        colRolesRol.Name = "colRolesRol";
        colRolesRol.ReadOnly = true;
        //
        // colRolesActivo
        //
        colRolesActivo.HeaderText = "Activo";
        colRolesActivo.Name = "colRolesActivo";
        colRolesActivo.ReadOnly = true;
        //
        // colPermisosAsignado
        //
        colPermisosAsignado.HeaderText = "Asignado";
        colPermisosAsignado.Name = "colPermisosAsignado";
        colPermisosAsignado.ReadOnly = false;
        //
        // colPermisosPermisodelsistema
        //
        colPermisosPermisodelsistema.HeaderText = "Permiso del sistema";
        colPermisosPermisodelsistema.Name = "colPermisosPermisodelsistema";
        colPermisosPermisodelsistema.ReadOnly = true;
        notificador.OwnerForm = this;
        //
        // FrmRoles
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblRolesTitulo);
        Controls.Add(dgvRoles);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(lblDescripcion);
        Controls.Add(txtDescripcion);
        Controls.Add(chkActivo);
        Controls.Add(lblPermisosTitulo);
        Controls.Add(dgvPermisos);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancelar;
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmRoles";
        Text = "Roles y permisos del sistema";
        ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblRolesTitulo;
    private KovaqsUI.Controls.KDataGridView dgvRoles;
    private KovaqsUI.Controls.KLabel lblNombre;
    private KovaqsUI.Controls.KTextBox txtNombre;
    private KovaqsUI.Controls.KLabel lblDescripcion;
    private KovaqsUI.Controls.KTextBox txtDescripcion;
    private KovaqsUI.Controls.KCheckBox chkActivo;
    private KovaqsUI.Controls.KLabel lblPermisosTitulo;
    private KovaqsUI.Controls.KDataGridView dgvPermisos;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private DataGridViewTextBoxColumn colRolesRol;
    private DataGridViewCheckBoxColumn colRolesActivo;
    private DataGridViewCheckBoxColumn colPermisosAsignado;
    private DataGridViewTextBoxColumn colPermisosPermisodelsistema;
    private KovaqsUI.Components.KToastNotifier notificador;
}
