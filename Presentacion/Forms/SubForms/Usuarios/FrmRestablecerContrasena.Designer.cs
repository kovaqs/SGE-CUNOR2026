namespace Presentacion.Forms.SubForms.Usuarios;

partial class FrmRestablecerContrasena
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
        lblContrasena = new KovaqsUI.Controls.KLabel();
        txtContrasena = new KovaqsUI.Controls.KTextBox();
        lblConfirmarContrasena = new KovaqsUI.Controls.KLabel();
        txtConfirmarContrasena = new KovaqsUI.Controls.KTextBox();
        chkMostrarContrasena = new KovaqsUI.Controls.KCheckBox();
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
        lblTitulo.Text = "Restablecer contraseña de usuario";
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
        lblNombreUsuario.Text = "Cuenta seleccionada";
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
        txtNombreUsuario.ReadOnly = true;
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
        // lblContrasena
        //
        lblContrasena.AutoSize = false;
        lblContrasena.BackColor = Color.Transparent;
        lblContrasena.ForeColor = Color.FromArgb(64, 64, 64);
        lblContrasena.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblContrasena.TextAlign = ContentAlignment.MiddleLeft;
        lblContrasena.Text = "Nueva contraseña";
        lblContrasena.Location = new Point(460, 70);
        lblContrasena.Font = new Font("Inter", 9F);
        lblContrasena.Name = "lblContrasena";
        lblContrasena.Size = new Size(426, 24);
        lblContrasena.TabIndex = 3;
        lblContrasena.TabStop = false;
        //
        // txtContrasena
        //
        txtContrasena.BackColor = Color.Transparent;
        txtContrasena.CornerRadius = 8;
        txtContrasena.Font = new Font("Inter", 9F);
        txtContrasena.Padding = new Padding(10, 6, 10, 6);
        txtContrasena.UseSystemPasswordChar = true;
        txtContrasena.MaxLength = 128;
        txtContrasena.Location = new Point(460, 96);
        txtContrasena.FillColor = Color.White;
        txtContrasena.ForeColor = Color.FromArgb(32, 38, 45);
        txtContrasena.BorderColor = Color.FromArgb(218, 218, 218);
        txtContrasena.GradientColor = Color.Empty;
        txtContrasena.BorderThickness = 1;
        txtContrasena.Name = "txtContrasena";
        txtContrasena.Size = new Size(426, 34);
        txtContrasena.TabIndex = 5;
        //
        // lblConfirmarContrasena
        //
        lblConfirmarContrasena.AutoSize = false;
        lblConfirmarContrasena.BackColor = Color.Transparent;
        lblConfirmarContrasena.ForeColor = Color.FromArgb(64, 64, 64);
        lblConfirmarContrasena.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblConfirmarContrasena.TextAlign = ContentAlignment.MiddleLeft;
        lblConfirmarContrasena.Text = "Confirmar contraseña";
        lblConfirmarContrasena.Location = new Point(16, 140);
        lblConfirmarContrasena.Font = new Font("Inter", 9F);
        lblConfirmarContrasena.Name = "lblConfirmarContrasena";
        lblConfirmarContrasena.Size = new Size(426, 24);
        lblConfirmarContrasena.TabIndex = 6;
        lblConfirmarContrasena.TabStop = false;
        //
        // txtConfirmarContrasena
        //
        txtConfirmarContrasena.BackColor = Color.Transparent;
        txtConfirmarContrasena.CornerRadius = 8;
        txtConfirmarContrasena.Font = new Font("Inter", 9F);
        txtConfirmarContrasena.Padding = new Padding(10, 6, 10, 6);
        txtConfirmarContrasena.UseSystemPasswordChar = true;
        txtConfirmarContrasena.MaxLength = 128;
        txtConfirmarContrasena.Location = new Point(16, 166);
        txtConfirmarContrasena.FillColor = Color.White;
        txtConfirmarContrasena.ForeColor = Color.FromArgb(32, 38, 45);
        txtConfirmarContrasena.BorderColor = Color.FromArgb(218, 218, 218);
        txtConfirmarContrasena.GradientColor = Color.Empty;
        txtConfirmarContrasena.BorderThickness = 1;
        txtConfirmarContrasena.Name = "txtConfirmarContrasena";
        txtConfirmarContrasena.Size = new Size(426, 34);
        txtConfirmarContrasena.TabIndex = 8;
        //
        // chkMostrarContrasena
        //
        chkMostrarContrasena.Font = new Font("Inter", 9F);
        chkMostrarContrasena.Text = "Mostrar contraseñas";
        chkMostrarContrasena.Location = new Point(460, 164);
        chkMostrarContrasena.ForeColor = Color.FromArgb(64, 64, 64);
        chkMostrarContrasena.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkMostrarContrasena.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
        chkMostrarContrasena.CheckedState.ForeColor = Color.White;
        chkMostrarContrasena.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkMostrarContrasena.Name = "chkMostrarContrasena";
        chkMostrarContrasena.Size = new Size(426, 36);
        chkMostrarContrasena.TabIndex = 7;
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
        btnGuardar.TabIndex = 9;
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
        btnCancelar.TabIndex = 10;
        notificador.OwnerForm = this;
        //
        // FrmRestablecerContrasena
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblNombreUsuario);
        Controls.Add(txtNombreUsuario);
        Controls.Add(lblContrasena);
        Controls.Add(txtContrasena);
        Controls.Add(lblConfirmarContrasena);
        Controls.Add(txtConfirmarContrasena);
        Controls.Add(chkMostrarContrasena);
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
        Name = "FrmRestablecerContrasena";
        Text = "Restablecer contraseña de usuario";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblNombreUsuario;
    private KovaqsUI.Controls.KTextBox txtNombreUsuario;
    private KovaqsUI.Controls.KLabel lblContrasena;
    private KovaqsUI.Controls.KTextBox txtContrasena;
    private KovaqsUI.Controls.KLabel lblConfirmarContrasena;
    private KovaqsUI.Controls.KTextBox txtConfirmarContrasena;
    private KovaqsUI.Controls.KCheckBox chkMostrarContrasena;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
