namespace Presentacion.Forms.SubForms.Usuarios;

partial class FrmEditarUsuario
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
        lblTitulo = new KovaqsUI.Controls.KLabel();
        btnCerrar = new KovaqsUI.Controls.KButton();
        lblNombreUsuario = new KovaqsUI.Controls.KLabel();
        txtNombreUsuario = new KovaqsUI.Controls.KTextBox();
        lblRol = new KovaqsUI.Controls.KLabel();
        cboRol = new KovaqsUI.Controls.KComboBox();
        lblEmpleado = new KovaqsUI.Controls.KLabel();
        cboEmpleado = new KovaqsUI.Controls.KComboBox();
        chkActivo = new KovaqsUI.Controls.KCheckBox();
        btnRestablecerContrasena = new KovaqsUI.Controls.KButton();
        btnGuardar = new KovaqsUI.Controls.KButton();
        btnCancelar = new KovaqsUI.Controls.KButton();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Text = "Editar cuenta de usuario";
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
        // lblNombreUsuario
        //
        lblNombreUsuario.AutoSize = false;
        lblNombreUsuario.BackColor = Color.Transparent;
        lblNombreUsuario.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombreUsuario.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNombreUsuario.TextAlign = ContentAlignment.MiddleLeft;
        lblNombreUsuario.Text = "Nombre de usuario";
        lblNombreUsuario.Location = new Point(16, 70);
        lblNombreUsuario.Font = new Font("Inter", 9F);
        lblNombreUsuario.Name = "lblNombreUsuario";
        lblNombreUsuario.Size = new Size(426, 24);
        lblNombreUsuario.TabIndex = 2;
        lblNombreUsuario.TabStop = false;
        //
        // txtNombreUsuario
        //
        txtNombreUsuario.BackColor = Color.Transparent;
        txtNombreUsuario.CornerRadius = 8;
        txtNombreUsuario.Font = new Font("Inter", 9F);
        txtNombreUsuario.Padding = new Padding(10, 6, 10, 6);
        txtNombreUsuario.MaxLength = 50;
        txtNombreUsuario.Location = new Point(16, 96);
        txtNombreUsuario.FillColor = Color.White;
        txtNombreUsuario.ForeColor = Color.FromArgb(32, 38, 45);
        txtNombreUsuario.BorderColor = Color.FromArgb(218, 218, 218);
        txtNombreUsuario.GradientColor = Color.Empty;
        txtNombreUsuario.BorderThickness = 1;
        txtNombreUsuario.Name = "txtNombreUsuario";
        txtNombreUsuario.Size = new Size(426, 34);
        txtNombreUsuario.TabIndex = 4;
        //
        // lblRol
        //
        lblRol.AutoSize = false;
        lblRol.BackColor = Color.Transparent;
        lblRol.ForeColor = Color.FromArgb(64, 64, 64);
        lblRol.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblRol.TextAlign = ContentAlignment.MiddleLeft;
        lblRol.Text = "Rol";
        lblRol.Location = new Point(460, 70);
        lblRol.Font = new Font("Inter", 9F);
        lblRol.Name = "lblRol";
        lblRol.Size = new Size(426, 24);
        lblRol.TabIndex = 3;
        lblRol.TabStop = false;
        //
        // cboRol
        //
        cboRol.Font = new Font("Inter", 9F);
        cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRol.FormattingEnabled = true;
        cboRol.Location = new Point(460, 96);
        cboRol.CornerRadius = 8;
        cboRol.FillColor = Color.White;
        cboRol.ForeColor = Color.FromArgb(32, 38, 45);
        cboRol.BorderColor = Color.FromArgb(218, 218, 218);
        cboRol.GradientColor = Color.Empty;

        cboRol.Name = "cboRol";
        cboRol.Size = new Size(426, 34);
        cboRol.TabIndex = 5;
        //
        // lblEmpleado
        //
        lblEmpleado.AutoSize = false;
        lblEmpleado.BackColor = Color.Transparent;
        lblEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEmpleado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEmpleado.TextAlign = ContentAlignment.MiddleLeft;
        lblEmpleado.Text = "Empleado asociado";
        lblEmpleado.Location = new Point(16, 140);
        lblEmpleado.Font = new Font("Inter", 9F);
        lblEmpleado.Name = "lblEmpleado";
        lblEmpleado.Size = new Size(426, 24);
        lblEmpleado.TabIndex = 6;
        lblEmpleado.TabStop = false;
        //
        // cboEmpleado
        //
        cboEmpleado.Font = new Font("Inter", 9F);
        cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEmpleado.FormattingEnabled = true;
        cboEmpleado.Location = new Point(16, 166);
        cboEmpleado.CornerRadius = 8;
        cboEmpleado.FillColor = Color.White;
        cboEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEmpleado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEmpleado.GradientColor = Color.Empty;

        cboEmpleado.Name = "cboEmpleado";
        cboEmpleado.Size = new Size(426, 34);
        cboEmpleado.TabIndex = 8;
        //
        // chkActivo
        //
        chkActivo.Font = new Font("Inter", 9F);
        chkActivo.Text = "Usuario activo";
        chkActivo.Checked = true;
        chkActivo.Location = new Point(460, 164);
        chkActivo.ForeColor = Color.FromArgb(64, 64, 64);
        chkActivo.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkActivo.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
        chkActivo.CheckedState.ForeColor = Color.White;
        chkActivo.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkActivo.Name = "chkActivo";
        chkActivo.Size = new Size(426, 36);
        chkActivo.TabIndex = 7;
        //
        // btnRestablecerContrasena
        //
        btnRestablecerContrasena.BackColor = Color.Transparent;
        btnRestablecerContrasena.CornerRadius = 8;
        btnRestablecerContrasena.FlatStyle = FlatStyle.Flat;
        btnRestablecerContrasena.Font = new Font("Inter", 9F);
        btnRestablecerContrasena.Padding = new Padding(10, 4, 10, 4);
        btnRestablecerContrasena.UseVisualStyleBackColor = false;
        btnRestablecerContrasena.Text = "Restablecer contraseña";
        btnRestablecerContrasena.Location = new Point(16, 218);
        btnRestablecerContrasena.BorderThickness = 1;
        btnRestablecerContrasena.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnRestablecerContrasena.FillColor = Color.White;
        btnRestablecerContrasena.ForeColor = Color.FromArgb(32, 38, 45);
        btnRestablecerContrasena.BorderColor = Color.FromArgb(218, 218, 218);
        btnRestablecerContrasena.GradientColor = Color.Empty;
        btnRestablecerContrasena.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnRestablecerContrasena.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnRestablecerContrasena.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnRestablecerContrasena.Name = "btnRestablecerContrasena";
        btnRestablecerContrasena.Size = new Size(220, 40);
        btnRestablecerContrasena.TabIndex = 9;
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
        btnGuardar.TabIndex = 10;
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
        btnCancelar.TabIndex = 11;
        notificador.OwnerForm = this;
        //
        // FrmEditarUsuario
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblNombreUsuario);
        Controls.Add(txtNombreUsuario);
        Controls.Add(lblRol);
        Controls.Add(cboRol);
        Controls.Add(lblEmpleado);
        Controls.Add(cboEmpleado);
        Controls.Add(chkActivo);
        Controls.Add(btnRestablecerContrasena);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancelar;
        Font = new Font("Segoe UI", 9F);
        Name = "FrmEditarUsuario";
        Text = "Editar cuenta de usuario";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblNombreUsuario;
    private KovaqsUI.Controls.KTextBox txtNombreUsuario;
    private KovaqsUI.Controls.KLabel lblRol;
    private KovaqsUI.Controls.KComboBox cboRol;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KComboBox cboEmpleado;
    private KovaqsUI.Controls.KCheckBox chkActivo;
    private KovaqsUI.Controls.KButton btnRestablecerContrasena;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
