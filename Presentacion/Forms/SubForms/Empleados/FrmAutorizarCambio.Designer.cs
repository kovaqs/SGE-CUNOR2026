namespace Presentacion.Forms.SubForms.Empleados;

partial class FrmAutorizarCambio
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
        lblEmpleado = new KovaqsUI.Controls.KLabel();
        txtEmpleado = new KovaqsUI.Controls.KTextBox();
        lblOperacion = new KovaqsUI.Controls.KLabel();
        txtOperacion = new KovaqsUI.Controls.KTextBox();
        lblUsuarioAutoriza = new KovaqsUI.Controls.KLabel();
        txtUsuarioAutoriza = new KovaqsUI.Controls.KTextBox();
        lblContrasena = new KovaqsUI.Controls.KLabel();
        txtContrasena = new KovaqsUI.Controls.KTextBox();
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
        lblTitulo.Text = "Confirmar cambio salarial";
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
        // lblEmpleado
        //
        lblEmpleado.AutoSize = false;
        lblEmpleado.BackColor = Color.Transparent;
        lblEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEmpleado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEmpleado.TextAlign = ContentAlignment.MiddleLeft;
        lblEmpleado.Text = "Empleado afectado";
        lblEmpleado.Location = new Point(16, 70);
        lblEmpleado.Name = "lblEmpleado";
        lblEmpleado.Size = new Size(426, 24);
        lblEmpleado.TabIndex = 2;
        lblEmpleado.TabStop = false;
        //
        // txtEmpleado
        //
        txtEmpleado.BackColor = Color.Transparent;
        txtEmpleado.CornerRadius = 8;
        txtEmpleado.Font = new Font("Inter", 9F);
        txtEmpleado.Padding = new Padding(10, 6, 10, 6);
        txtEmpleado.ReadOnly = true;
        txtEmpleado.MaxLength = 100;
        txtEmpleado.Location = new Point(16, 96);
        txtEmpleado.Name = "txtEmpleado";
        txtEmpleado.Size = new Size(426, 34);
        txtEmpleado.TabIndex = 3;
        //
        // lblOperacion
        //
        lblOperacion.AutoSize = false;
        lblOperacion.BackColor = Color.Transparent;
        lblOperacion.ForeColor = Color.FromArgb(64, 64, 64);
        lblOperacion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblOperacion.TextAlign = ContentAlignment.MiddleLeft;
        lblOperacion.Text = "Operación a confirmar";
        lblOperacion.Location = new Point(460, 70);
        lblOperacion.Name = "lblOperacion";
        lblOperacion.Size = new Size(426, 24);
        lblOperacion.TabIndex = 4;
        lblOperacion.TabStop = false;
        //
        // txtOperacion
        //
        txtOperacion.BackColor = Color.Transparent;
        txtOperacion.CornerRadius = 8;
        txtOperacion.Font = new Font("Inter", 9F);
        txtOperacion.Padding = new Padding(10, 6, 10, 6);
        txtOperacion.ReadOnly = true;
        txtOperacion.MaxLength = 100;
        txtOperacion.Location = new Point(460, 96);
        txtOperacion.Name = "txtOperacion";
        txtOperacion.Size = new Size(426, 34);
        txtOperacion.TabIndex = 5;
        //
        // lblUsuarioAutoriza
        //
        lblUsuarioAutoriza.AutoSize = false;
        lblUsuarioAutoriza.BackColor = Color.Transparent;
        lblUsuarioAutoriza.ForeColor = Color.FromArgb(64, 64, 64);
        lblUsuarioAutoriza.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblUsuarioAutoriza.TextAlign = ContentAlignment.MiddleLeft;
        lblUsuarioAutoriza.Text = "Usuario autorizado";
        lblUsuarioAutoriza.Location = new Point(16, 140);
        lblUsuarioAutoriza.Name = "lblUsuarioAutoriza";
        lblUsuarioAutoriza.Size = new Size(426, 24);
        lblUsuarioAutoriza.TabIndex = 6;
        lblUsuarioAutoriza.TabStop = false;
        //
        // txtUsuarioAutoriza
        //
        txtUsuarioAutoriza.BackColor = Color.Transparent;
        txtUsuarioAutoriza.CornerRadius = 8;
        txtUsuarioAutoriza.Font = new Font("Inter", 9F);
        txtUsuarioAutoriza.Padding = new Padding(10, 6, 10, 6);
        txtUsuarioAutoriza.ReadOnly = true;
        txtUsuarioAutoriza.MaxLength = 100;
        txtUsuarioAutoriza.Location = new Point(16, 166);
        txtUsuarioAutoriza.Name = "txtUsuarioAutoriza";
        txtUsuarioAutoriza.Size = new Size(426, 34);
        txtUsuarioAutoriza.TabIndex = 7;
        //
        // lblContrasena
        //
        lblContrasena.AutoSize = false;
        lblContrasena.BackColor = Color.Transparent;
        lblContrasena.ForeColor = Color.FromArgb(64, 64, 64);
        lblContrasena.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblContrasena.TextAlign = ContentAlignment.MiddleLeft;
        lblContrasena.Text = "Confirma tu contraseña";
        lblContrasena.Location = new Point(460, 140);
        lblContrasena.Name = "lblContrasena";
        lblContrasena.Size = new Size(426, 24);
        lblContrasena.TabIndex = 8;
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
        txtContrasena.Location = new Point(460, 166);
        txtContrasena.Name = "txtContrasena";
        txtContrasena.Size = new Size(426, 34);
        txtContrasena.TabIndex = 9;
        //
        // chkMostrarContrasena
        //
        chkMostrarContrasena.Font = new Font("Inter", 9F);
        chkMostrarContrasena.Text = "Mostrar contraseña";
        chkMostrarContrasena.Location = new Point(16, 234);
        chkMostrarContrasena.Name = "chkMostrarContrasena";
        chkMostrarContrasena.Size = new Size(426, 36);
        chkMostrarContrasena.TabIndex = 10;
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
        btnGuardar.Text = "Autorizar";
        btnGuardar.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardar.Appearance.Normal.ForeColor = Color.White;
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnGuardar.Location = new Point(586, 613);
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
        btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCancelar.Text = "Cancelar";
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.Location = new Point(742, 613);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(144, 40);
        btnCancelar.TabIndex = 12;
        notificador.OwnerForm = this;
        //
        // FrmAutorizarCambio
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblEmpleado);
        Controls.Add(txtEmpleado);
        Controls.Add(lblOperacion);
        Controls.Add(txtOperacion);
        Controls.Add(lblUsuarioAutoriza);
        Controls.Add(txtUsuarioAutoriza);
        Controls.Add(lblContrasena);
        Controls.Add(txtContrasena);
        Controls.Add(chkMostrarContrasena);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancelar;
        Name = "FrmAutorizarCambio";
        Text = "Confirmar cambio salarial";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KTextBox txtEmpleado;
    private KovaqsUI.Controls.KLabel lblOperacion;
    private KovaqsUI.Controls.KTextBox txtOperacion;
    private KovaqsUI.Controls.KLabel lblUsuarioAutoriza;
    private KovaqsUI.Controls.KTextBox txtUsuarioAutoriza;
    private KovaqsUI.Controls.KLabel lblContrasena;
    private KovaqsUI.Controls.KTextBox txtContrasena;
    private KovaqsUI.Controls.KCheckBox chkMostrarContrasena;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
