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
        btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCerrar.Text = "Cerrar";
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.Location = new Point(790, 12);
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
        txtNombreUsuario.Name = "txtNombreUsuario";
        txtNombreUsuario.Size = new Size(426, 34);
        txtNombreUsuario.TabIndex = 3;
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
        lblRol.Name = "lblRol";
        lblRol.Size = new Size(426, 24);
        lblRol.TabIndex = 4;
        lblRol.TabStop = false;
        //
        // cboRol
        //
        cboRol.Font = new Font("Inter", 9F);
        cboRol.DropDownStyle = ComboBoxStyle.DropDownList;
        cboRol.FormattingEnabled = true;
        cboRol.Location = new Point(460, 96);
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
        cboEmpleado.Name = "cboEmpleado";
        cboEmpleado.Size = new Size(426, 34);
        cboEmpleado.TabIndex = 7;
        //
        // chkActivo
        //
        chkActivo.Font = new Font("Inter", 9F);
        chkActivo.Text = "Usuario activo";
        chkActivo.Checked = true;
        chkActivo.Location = new Point(460, 164);
        chkActivo.Name = "chkActivo";
        chkActivo.Size = new Size(426, 36);
        chkActivo.TabIndex = 8;
        //
        // btnRestablecerContrasena
        //
        btnRestablecerContrasena.BackColor = Color.Transparent;
        btnRestablecerContrasena.CornerRadius = 8;
        btnRestablecerContrasena.FlatStyle = FlatStyle.Flat;
        btnRestablecerContrasena.Font = new Font("Inter", 9F);
        btnRestablecerContrasena.Padding = new Padding(10, 4, 10, 4);
        btnRestablecerContrasena.UseVisualStyleBackColor = false;
        btnRestablecerContrasena.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        btnRestablecerContrasena.Text = "Restablecer contraseña";
        btnRestablecerContrasena.FillColor = Color.FromArgb(32, 38, 45);
        btnRestablecerContrasena.ForeColor = Color.White;
        btnRestablecerContrasena.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnRestablecerContrasena.Appearance.Normal.ForeColor = Color.White;
        btnRestablecerContrasena.Location = new Point(16, 218);
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
        btnGuardar.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        btnGuardar.Text = "Guardar";
        btnGuardar.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardar.Appearance.Normal.ForeColor = Color.White;
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnGuardar.Location = new Point(586, 613);
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
        btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCancelar.Text = "Cancelar";
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.Location = new Point(742, 613);
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
