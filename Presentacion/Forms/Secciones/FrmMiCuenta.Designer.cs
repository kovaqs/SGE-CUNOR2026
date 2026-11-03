namespace Presentacion.Forms.Secciones;

partial class FrmMiCuenta
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
        lblDatosCuenta = new KovaqsUI.Controls.KLabel();
        lblNombreMostrado = new KovaqsUI.Controls.KLabel();
        lblRol = new KovaqsUI.Controls.KLabel();
        lblNombreUsuario = new KovaqsUI.Controls.KLabel();
        lblSeguridad = new KovaqsUI.Controls.KLabel();
        lblAyuda = new KovaqsUI.Controls.KLabel();
        lblContrasenaActual = new KovaqsUI.Controls.KLabel();
        lblNuevaContrasena = new KovaqsUI.Controls.KLabel();
        lblConfirmarContrasena = new KovaqsUI.Controls.KLabel();
        txtNombreMostrado = new KovaqsUI.Controls.KTextBox();
        txtRol = new KovaqsUI.Controls.KTextBox();
        txtNombreUsuario = new KovaqsUI.Controls.KTextBox();
        txtContrasenaActual = new KovaqsUI.Controls.KTextBox();
        txtNuevaContrasena = new KovaqsUI.Controls.KTextBox();
        txtConfirmarContrasena = new KovaqsUI.Controls.KTextBox();
        chkMostrarContrasenas = new KovaqsUI.Controls.KCheckBox();
        btnGuardar = new KovaqsUI.Controls.KButton();
        btnCancelar = new KovaqsUI.Controls.KButton();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Size = new Size(1094, 40);
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.TabStop = false;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Text = "Mi cuenta";
        //
        // lblDatosCuenta
        //
        lblDatosCuenta.AutoSize = false;
        lblDatosCuenta.BackColor = Color.Transparent;
        lblDatosCuenta.TextRole = KovaqsUI.Controls.KTextRole.Section;
        lblDatosCuenta.ForeColor = Color.FromArgb(32, 38, 45);
        lblDatosCuenta.Location = new Point(16, 72);
        lblDatosCuenta.Size = new Size(1094, 28);
        lblDatosCuenta.TextAlign = ContentAlignment.MiddleLeft;
        lblDatosCuenta.TabStop = false;
        lblDatosCuenta.Name = "lblDatosCuenta";
        lblDatosCuenta.Text = "Datos de la cuenta";
        //
        // lblNombreMostrado
        //
        lblNombreMostrado.AutoSize = false;
        lblNombreMostrado.BackColor = Color.Transparent;
        lblNombreMostrado.Font = new Font("Inter", 9F);
        lblNombreMostrado.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombreMostrado.Location = new Point(16, 120);
        lblNombreMostrado.Size = new Size(520, 24);
        lblNombreMostrado.TextAlign = ContentAlignment.MiddleLeft;
        lblNombreMostrado.TabStop = false;
        lblNombreMostrado.Name = "lblNombreMostrado";
        lblNombreMostrado.Text = "Nombre mostrado";
        //
        // lblRol
        //
        lblRol.AutoSize = false;
        lblRol.BackColor = Color.Transparent;
        lblRol.Font = new Font("Inter", 9F);
        lblRol.ForeColor = Color.FromArgb(64, 64, 64);
        lblRol.Location = new Point(568, 120);
        lblRol.Size = new Size(520, 24);
        lblRol.TextAlign = ContentAlignment.MiddleLeft;
        lblRol.TabStop = false;
        lblRol.Name = "lblRol";
        lblRol.Text = "Rol";
        //
        // lblNombreUsuario
        //
        lblNombreUsuario.AutoSize = false;
        lblNombreUsuario.BackColor = Color.Transparent;
        lblNombreUsuario.Font = new Font("Inter", 9F);
        lblNombreUsuario.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombreUsuario.Location = new Point(16, 196);
        lblNombreUsuario.Size = new Size(520, 24);
        lblNombreUsuario.TextAlign = ContentAlignment.MiddleLeft;
        lblNombreUsuario.TabStop = false;
        lblNombreUsuario.Name = "lblNombreUsuario";
        lblNombreUsuario.Text = "Nombre de usuario";
        //
        // lblSeguridad
        //
        lblSeguridad.AutoSize = false;
        lblSeguridad.BackColor = Color.Transparent;
        lblSeguridad.TextRole = KovaqsUI.Controls.KTextRole.Section;
        lblSeguridad.ForeColor = Color.FromArgb(32, 38, 45);
        lblSeguridad.Location = new Point(16, 288);
        lblSeguridad.Size = new Size(1094, 28);
        lblSeguridad.TextAlign = ContentAlignment.MiddleLeft;
        lblSeguridad.TabStop = false;
        lblSeguridad.Name = "lblSeguridad";
        lblSeguridad.Text = "Seguridad";
        //
        // lblAyuda
        //
        lblAyuda.AutoSize = false;
        lblAyuda.BackColor = Color.Transparent;
        lblAyuda.Font = new Font("Inter", 9F);
        lblAyuda.ForeColor = Color.FromArgb(64, 64, 64);
        lblAyuda.Location = new Point(16, 322);
        lblAyuda.Size = new Size(1094, 34);
        lblAyuda.TextAlign = ContentAlignment.MiddleLeft;
        lblAyuda.TabStop = false;
        lblAyuda.Name = "lblAyuda";
        lblAyuda.Text = "Confirma tu contraseña actual para guardar. Deja la contraseña nueva vacía si solo cambiarás el nombre de usuario.";
        //
        // lblContrasenaActual
        //
        lblContrasenaActual.AutoSize = false;
        lblContrasenaActual.BackColor = Color.Transparent;
        lblContrasenaActual.Font = new Font("Inter", 9F);
        lblContrasenaActual.ForeColor = Color.FromArgb(64, 64, 64);
        lblContrasenaActual.Location = new Point(16, 370);
        lblContrasenaActual.Size = new Size(520, 24);
        lblContrasenaActual.TextAlign = ContentAlignment.MiddleLeft;
        lblContrasenaActual.TabStop = false;
        lblContrasenaActual.Name = "lblContrasenaActual";
        lblContrasenaActual.Text = "Contraseña actual";
        //
        // lblNuevaContrasena
        //
        lblNuevaContrasena.AutoSize = false;
        lblNuevaContrasena.BackColor = Color.Transparent;
        lblNuevaContrasena.Font = new Font("Inter", 9F);
        lblNuevaContrasena.ForeColor = Color.FromArgb(64, 64, 64);
        lblNuevaContrasena.Location = new Point(16, 450);
        lblNuevaContrasena.Size = new Size(520, 24);
        lblNuevaContrasena.TextAlign = ContentAlignment.MiddleLeft;
        lblNuevaContrasena.TabStop = false;
        lblNuevaContrasena.Name = "lblNuevaContrasena";
        lblNuevaContrasena.Text = "Contraseña nueva (12 a 128 caracteres)";
        //
        // lblConfirmarContrasena
        //
        lblConfirmarContrasena.AutoSize = false;
        lblConfirmarContrasena.BackColor = Color.Transparent;
        lblConfirmarContrasena.Font = new Font("Inter", 9F);
        lblConfirmarContrasena.ForeColor = Color.FromArgb(64, 64, 64);
        lblConfirmarContrasena.Location = new Point(568, 450);
        lblConfirmarContrasena.Size = new Size(520, 24);
        lblConfirmarContrasena.TextAlign = ContentAlignment.MiddleLeft;
        lblConfirmarContrasena.TabStop = false;
        lblConfirmarContrasena.Name = "lblConfirmarContrasena";
        lblConfirmarContrasena.Text = "Confirmar contraseña nueva";
        //
        // txtNombreMostrado
        //
        txtNombreMostrado.BackColor = Color.Transparent;
        txtNombreMostrado.Font = new Font("Inter", 9F);
        txtNombreMostrado.Location = new Point(16, 146);
        txtNombreMostrado.Size = new Size(520, 34);
        txtNombreMostrado.Padding = new Padding(10, 6, 10, 6);
        txtNombreMostrado.CornerRadius = 8;
        txtNombreMostrado.BorderThickness = 1;
        txtNombreMostrado.BorderColor = Color.FromArgb(218, 218, 218);
        txtNombreMostrado.FillColor = Color.FromArgb(244, 246, 248);
        txtNombreMostrado.ForeColor = Color.FromArgb(32, 38, 45);
        txtNombreMostrado.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        txtNombreMostrado.ReadOnly = true;
        txtNombreMostrado.UseSystemPasswordChar = false;
        txtNombreMostrado.MaxLength = 201;
        txtNombreMostrado.TabIndex = 0;
        txtNombreMostrado.TabStop = false;
        txtNombreMostrado.Name = "txtNombreMostrado";
        //
        // txtRol
        //
        txtRol.BackColor = Color.Transparent;
        txtRol.Font = new Font("Inter", 9F);
        txtRol.Location = new Point(568, 146);
        txtRol.Size = new Size(520, 34);
        txtRol.Padding = new Padding(10, 6, 10, 6);
        txtRol.CornerRadius = 8;
        txtRol.BorderThickness = 1;
        txtRol.BorderColor = Color.FromArgb(218, 218, 218);
        txtRol.FillColor = Color.FromArgb(244, 246, 248);
        txtRol.ForeColor = Color.FromArgb(32, 38, 45);
        txtRol.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        txtRol.ReadOnly = true;
        txtRol.UseSystemPasswordChar = false;
        txtRol.MaxLength = 201;
        txtRol.TabIndex = 1;
        txtRol.TabStop = false;
        txtRol.Name = "txtRol";
        //
        // txtNombreUsuario
        //
        txtNombreUsuario.BackColor = Color.Transparent;
        txtNombreUsuario.Font = new Font("Inter", 9F);
        txtNombreUsuario.Location = new Point(16, 222);
        txtNombreUsuario.Size = new Size(520, 34);
        txtNombreUsuario.Padding = new Padding(10, 6, 10, 6);
        txtNombreUsuario.CornerRadius = 8;
        txtNombreUsuario.BorderThickness = 1;
        txtNombreUsuario.BorderColor = Color.FromArgb(218, 218, 218);
        txtNombreUsuario.FillColor = Color.White;
        txtNombreUsuario.ForeColor = Color.FromArgb(32, 38, 45);
        txtNombreUsuario.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        txtNombreUsuario.ReadOnly = false;
        txtNombreUsuario.UseSystemPasswordChar = false;
        txtNombreUsuario.MaxLength = 50;
        txtNombreUsuario.TabIndex = 2;
        txtNombreUsuario.Name = "txtNombreUsuario";
        //
        // txtContrasenaActual
        //
        txtContrasenaActual.BackColor = Color.Transparent;
        txtContrasenaActual.Font = new Font("Inter", 9F);
        txtContrasenaActual.Location = new Point(16, 396);
        txtContrasenaActual.Size = new Size(520, 34);
        txtContrasenaActual.Padding = new Padding(10, 6, 10, 6);
        txtContrasenaActual.CornerRadius = 8;
        txtContrasenaActual.BorderThickness = 1;
        txtContrasenaActual.BorderColor = Color.FromArgb(218, 218, 218);
        txtContrasenaActual.FillColor = Color.White;
        txtContrasenaActual.ForeColor = Color.FromArgb(32, 38, 45);
        txtContrasenaActual.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        txtContrasenaActual.ReadOnly = false;
        txtContrasenaActual.UseSystemPasswordChar = true;
        txtContrasenaActual.MaxLength = 128;
        txtContrasenaActual.TabIndex = 3;
        txtContrasenaActual.Name = "txtContrasenaActual";
        //
        // txtNuevaContrasena
        //
        txtNuevaContrasena.BackColor = Color.Transparent;
        txtNuevaContrasena.Font = new Font("Inter", 9F);
        txtNuevaContrasena.Location = new Point(16, 476);
        txtNuevaContrasena.Size = new Size(520, 34);
        txtNuevaContrasena.Padding = new Padding(10, 6, 10, 6);
        txtNuevaContrasena.CornerRadius = 8;
        txtNuevaContrasena.BorderThickness = 1;
        txtNuevaContrasena.BorderColor = Color.FromArgb(218, 218, 218);
        txtNuevaContrasena.FillColor = Color.White;
        txtNuevaContrasena.ForeColor = Color.FromArgb(32, 38, 45);
        txtNuevaContrasena.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        txtNuevaContrasena.ReadOnly = false;
        txtNuevaContrasena.UseSystemPasswordChar = true;
        txtNuevaContrasena.MaxLength = 128;
        txtNuevaContrasena.TabIndex = 4;
        txtNuevaContrasena.Name = "txtNuevaContrasena";
        //
        // txtConfirmarContrasena
        //
        txtConfirmarContrasena.BackColor = Color.Transparent;
        txtConfirmarContrasena.Font = new Font("Inter", 9F);
        txtConfirmarContrasena.Location = new Point(568, 476);
        txtConfirmarContrasena.Size = new Size(520, 34);
        txtConfirmarContrasena.Padding = new Padding(10, 6, 10, 6);
        txtConfirmarContrasena.CornerRadius = 8;
        txtConfirmarContrasena.BorderThickness = 1;
        txtConfirmarContrasena.BorderColor = Color.FromArgb(218, 218, 218);
        txtConfirmarContrasena.FillColor = Color.White;
        txtConfirmarContrasena.ForeColor = Color.FromArgb(32, 38, 45);
        txtConfirmarContrasena.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        txtConfirmarContrasena.ReadOnly = false;
        txtConfirmarContrasena.UseSystemPasswordChar = true;
        txtConfirmarContrasena.MaxLength = 128;
        txtConfirmarContrasena.TabIndex = 5;
        txtConfirmarContrasena.Name = "txtConfirmarContrasena";
        //
        // chkMostrarContrasenas
        //
        chkMostrarContrasenas.Font = new Font("Inter", 9F);
        chkMostrarContrasenas.ForeColor = Color.FromArgb(64, 64, 64);
        chkMostrarContrasenas.Location = new Point(16, 526);
        chkMostrarContrasenas.Size = new Size(320, 36);
        chkMostrarContrasenas.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkMostrarContrasenas.CheckedState.BorderColor = Color.FromArgb(49, 81, 107);
        chkMostrarContrasenas.CheckedState.ForeColor = Color.White;
        chkMostrarContrasenas.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkMostrarContrasenas.Name = "chkMostrarContrasenas";
        chkMostrarContrasenas.Text = "Mostrar contraseñas";
        chkMostrarContrasenas.TabIndex = 6;
        chkMostrarContrasenas.CheckedChanged += chkMostrarContrasenas_CheckedChanged;
        //
        // btnGuardar
        //
        btnGuardar.BackColor = Color.Transparent;
        btnGuardar.Font = new Font("Inter", 9F);
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Padding = new Padding(10, 4, 10, 4);
        btnGuardar.CornerRadius = 8;
        btnGuardar.BorderThickness = 1;
        btnGuardar.Location = new Point(16, 584);
        btnGuardar.Size = new Size(200, 40);
        btnGuardar.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnGuardar.FillColor = Color.FromArgb(49, 81, 107);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.BorderColor = Color.FromArgb(49, 81, 107);
        btnGuardar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnGuardar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnGuardar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Text = "Guardar cambios";
        btnGuardar.TabIndex = 7;
        btnGuardar.Enabled = false;
        btnGuardar.Click += btnGuardar_Click;
        //
        // btnCancelar
        //
        btnCancelar.BackColor = Color.Transparent;
        btnCancelar.Font = new Font("Inter", 9F);
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Padding = new Padding(10, 4, 10, 4);
        btnCancelar.CornerRadius = 8;
        btnCancelar.BorderThickness = 1;
        btnCancelar.Location = new Point(228, 584);
        btnCancelar.Size = new Size(160, 40);
        btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
        btnCancelar.FillColor = Color.FromArgb(255, 248, 248);
        btnCancelar.ForeColor = Color.FromArgb(166, 61, 64);
        btnCancelar.BorderColor = Color.FromArgb(204, 148, 150);
        btnCancelar.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
        btnCancelar.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
        btnCancelar.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Text = "Cancelar";
        btnCancelar.TabIndex = 8;
        btnCancelar.Click += btnCancelar_Click;
        notificador.OwnerForm = this;
        //
        // FrmMiCuenta
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1126, 744);
        MinimumSize = new Size(1126, 744);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmMiCuenta";
        Text = "Mi cuenta";
        VisibleChanged += FrmMiCuenta_VisibleChanged;
        Disposed += FrmMiCuenta_Disposed;
        Controls.Add(lblTitulo);
        Controls.Add(lblDatosCuenta);
        Controls.Add(lblNombreMostrado);
        Controls.Add(lblRol);
        Controls.Add(lblNombreUsuario);
        Controls.Add(lblSeguridad);
        Controls.Add(lblAyuda);
        Controls.Add(lblContrasenaActual);
        Controls.Add(lblNuevaContrasena);
        Controls.Add(lblConfirmarContrasena);
        Controls.Add(txtNombreMostrado);
        Controls.Add(txtRol);
        Controls.Add(txtNombreUsuario);
        Controls.Add(txtContrasenaActual);
        Controls.Add(txtNuevaContrasena);
        Controls.Add(txtConfirmarContrasena);
        Controls.Add(chkMostrarContrasenas);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KLabel lblDatosCuenta;
    private KovaqsUI.Controls.KLabel lblNombreMostrado;
    private KovaqsUI.Controls.KLabel lblRol;
    private KovaqsUI.Controls.KLabel lblNombreUsuario;
    private KovaqsUI.Controls.KLabel lblSeguridad;
    private KovaqsUI.Controls.KLabel lblAyuda;
    private KovaqsUI.Controls.KLabel lblContrasenaActual;
    private KovaqsUI.Controls.KLabel lblNuevaContrasena;
    private KovaqsUI.Controls.KLabel lblConfirmarContrasena;
    private KovaqsUI.Controls.KTextBox txtNombreMostrado;
    private KovaqsUI.Controls.KTextBox txtRol;
    private KovaqsUI.Controls.KTextBox txtNombreUsuario;
    private KovaqsUI.Controls.KTextBox txtContrasenaActual;
    private KovaqsUI.Controls.KTextBox txtNuevaContrasena;
    private KovaqsUI.Controls.KTextBox txtConfirmarContrasena;
    private KovaqsUI.Controls.KCheckBox chkMostrarContrasenas;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
