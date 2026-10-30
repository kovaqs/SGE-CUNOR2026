namespace Presentacion.Forms.SubForms
{
    partial class FrmCrearUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCerrar = new KovaqsUI.Controls.KButton();
            kLabel3 = new KovaqsUI.Controls.KLabel();
            kLabel1 = new KovaqsUI.Controls.KLabel();
            kLabel2 = new KovaqsUI.Controls.KLabel();
            kLabel4 = new KovaqsUI.Controls.KLabel();
            cboRol = new KovaqsUI.Controls.KComboBox();
            kLabel5 = new KovaqsUI.Controls.KLabel();
            cboEmpleado = new KovaqsUI.Controls.KComboBox();
            kLabel6 = new KovaqsUI.Controls.KLabel();
            chkActivo = new KovaqsUI.Controls.KCheckBox();
            chkMostrarContrasena = new KovaqsUI.Controls.KCheckBox();
            btnGuardar = new KovaqsUI.Controls.KButton();
            btnCancelar = new KovaqsUI.Controls.KButton();
            txtConfirmarContrasena = new KovaqsUI.Controls.KTextBox();
            txtContrasena = new KovaqsUI.Controls.KTextBox();
            txtNombreUsuario = new KovaqsUI.Controls.KTextBox();
            components = new System.ComponentModel.Container();
            notificador = new KovaqsUI.Components.KToastNotifier(components);
            notificador.OwnerForm = this;
            SuspendLayout();
            //
            // btnCerrar
            //
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Animation.Duration = 200;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.CornerRadius = 8;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Inter", 9F);
            btnCerrar.Location = new Point(546, 12);
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
            btnCerrar.Size = new Size(108, 40);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            //
            // kLabel3
            //
            kLabel3.BackColor = Color.Transparent;
            kLabel3.Font = new Font("Inter", 16F, FontStyle.Bold);
            kLabel3.ForeColor = Color.FromArgb(32, 38, 45);
            kLabel3.Location = new Point(16, 12);
            kLabel3.AutoSize = false;
            kLabel3.TabStop = false;
            kLabel3.Name = "kLabel3";
            kLabel3.Size = new Size(516, 40);
            kLabel3.TabIndex = 0;
            kLabel3.Text = "Crear usuario";
            kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Title;
            //
            // kLabel1
            //
            kLabel1.BackColor = Color.Transparent;
            kLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel1.Location = new Point(16, 70);
            kLabel1.Font = new Font("Inter", 9F);
            kLabel1.AutoSize = false;
            kLabel1.TabStop = false;
            kLabel1.Name = "kLabel1";
            kLabel1.Size = new Size(638, 24);
            kLabel1.TabIndex = 2;
            kLabel1.Text = "Nombre de usuario";
            kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // kLabel2
            //
            kLabel2.BackColor = Color.Transparent;
            kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel2.Location = new Point(16, 140);
            kLabel2.Font = new Font("Inter", 9F);
            kLabel2.AutoSize = false;
            kLabel2.TabStop = false;
            kLabel2.Name = "kLabel2";
            kLabel2.Size = new Size(638, 24);
            kLabel2.TabIndex = 4;
            kLabel2.Text = "Contraseña";
            kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // kLabel4
            //
            kLabel4.BackColor = Color.Transparent;
            kLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel4.Location = new Point(16, 210);
            kLabel4.Font = new Font("Inter", 9F);
            kLabel4.AutoSize = false;
            kLabel4.TabStop = false;
            kLabel4.Name = "kLabel4";
            kLabel4.Size = new Size(638, 24);
            kLabel4.TabIndex = 6;
            kLabel4.Text = "Confirmar contraseña";
            kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // cboRol
            //
            cboRol.FormattingEnabled = true;
            cboRol.ItemHeight = 28;
            cboRol.Location = new Point(16, 306);
            cboRol.Font = new Font("Inter", 9F);
            cboRol.CornerRadius = 8;
            cboRol.FillColor = Color.White;
            cboRol.ForeColor = Color.FromArgb(32, 38, 45);
            cboRol.BorderColor = Color.FromArgb(218, 218, 218);
            cboRol.GradientColor = Color.Empty;
            cboRol.DropDownStyle = ComboBoxStyle.DropDownList;

            cboRol.Name = "cboRol";
            cboRol.Size = new Size(638, 34);
            cboRol.TabIndex = 9;
            //
            // kLabel5
            //
            kLabel5.BackColor = Color.Transparent;
            kLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel5.Location = new Point(16, 280);
            kLabel5.Font = new Font("Inter", 9F);
            kLabel5.AutoSize = false;
            kLabel5.TabStop = false;
            kLabel5.Name = "kLabel5";
            kLabel5.Size = new Size(638, 24);
            kLabel5.TabIndex = 8;
            kLabel5.Text = "Rol";
            kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // cboEmpleado
            //
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.ItemHeight = 28;
            cboEmpleado.Location = new Point(16, 376);
            cboEmpleado.Font = new Font("Inter", 9F);
            cboEmpleado.CornerRadius = 8;
            cboEmpleado.FillColor = Color.White;
            cboEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
            cboEmpleado.BorderColor = Color.FromArgb(218, 218, 218);
            cboEmpleado.GradientColor = Color.Empty;
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;

            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(638, 34);
            cboEmpleado.TabIndex = 11;
            //
            // kLabel6
            //
            kLabel6.BackColor = Color.Transparent;
            kLabel6.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel6.Location = new Point(16, 350);
            kLabel6.Font = new Font("Inter", 9F);
            kLabel6.AutoSize = false;
            kLabel6.TabStop = false;
            kLabel6.Name = "kLabel6";
            kLabel6.Size = new Size(638, 24);
            kLabel6.TabIndex = 10;
            kLabel6.Text = "Empleado asociado (opcional)";
            kLabel6.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // chkActivo
            //
            chkActivo.BackColor = Color.Transparent;
            chkActivo.Font = new Font("Inter", 9F);
            chkActivo.Location = new Point(344, 424);
            chkActivo.ForeColor = Color.FromArgb(64, 64, 64);
            chkActivo.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
            chkActivo.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
            chkActivo.CheckedState.ForeColor = Color.White;
            chkActivo.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            chkActivo.Name = "chkActivo";
            chkActivo.Padding = new Padding(2);
            chkActivo.Size = new Size(310, 32);
            chkActivo.TabIndex = 13;
            chkActivo.Text = "Usuario activo";
            chkActivo.UseVisualStyleBackColor = false;
            //
            // chkMostrarContrasena
            //
            chkMostrarContrasena.BackColor = Color.Transparent;
            chkMostrarContrasena.Font = new Font("Inter", 9F);
            chkMostrarContrasena.Location = new Point(16, 424);
            chkMostrarContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            chkMostrarContrasena.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
            chkMostrarContrasena.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
            chkMostrarContrasena.CheckedState.ForeColor = Color.White;
            chkMostrarContrasena.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            chkMostrarContrasena.Name = "chkMostrarContrasena";
            chkMostrarContrasena.Padding = new Padding(2);
            chkMostrarContrasena.Size = new Size(310, 32);
            chkMostrarContrasena.TabIndex = 12;
            chkMostrarContrasena.Text = "Mostrar contraseñas";
            chkMostrarContrasena.UseVisualStyleBackColor = false;
            //
            // btnGuardar
            //
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.CornerRadius = 8;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(354, 488);
            btnGuardar.BorderThickness = 1;
            btnGuardar.Font = new Font("Inter", 9F);
            btnGuardar.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
            btnGuardar.FillColor = Color.FromArgb(49, 81, 107);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.BorderColor = Color.FromArgb(49, 81, 107);
            btnGuardar.GradientColor = Color.Empty;
            btnGuardar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
            btnGuardar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
            btnGuardar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 4, 10, 4);
            btnGuardar.Size = new Size(144, 40);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            //
            // btnCancelar
            //
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.CornerRadius = 8;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(510, 488);
            btnCancelar.BorderThickness = 1;
            btnCancelar.Font = new Font("Inter", 9F);
            btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            btnCancelar.FillColor = Color.FromArgb(255, 248, 248);
            btnCancelar.ForeColor = Color.FromArgb(166, 61, 64);
            btnCancelar.BorderColor = Color.FromArgb(204, 148, 150);
            btnCancelar.GradientColor = Color.Empty;
            btnCancelar.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            btnCancelar.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            btnCancelar.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(10, 4, 10, 4);
            btnCancelar.Size = new Size(144, 40);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            //
            // txtConfirmarContrasena
            //
            txtConfirmarContrasena.Appearance.Normal.FillColor = Color.White;
            txtConfirmarContrasena.BackColor = Color.White;
            txtConfirmarContrasena.CornerRadius = 8;
            txtConfirmarContrasena.FillColor = Color.White;
            txtConfirmarContrasena.Location = new Point(16, 236);
            txtConfirmarContrasena.Font = new Font("Inter", 9F);
            txtConfirmarContrasena.ForeColor = Color.FromArgb(32, 38, 45);
            txtConfirmarContrasena.BorderColor = Color.FromArgb(218, 218, 218);
            txtConfirmarContrasena.GradientColor = Color.Empty;
            txtConfirmarContrasena.BorderThickness = 1;
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Padding = new Padding(12, 8, 12, 8);
            txtConfirmarContrasena.PasswordChar = '●';
            txtConfirmarContrasena.Size = new Size(638, 34);
            txtConfirmarContrasena.TabIndex = 7;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            //
            // txtContrasena
            //
            txtContrasena.Appearance.Normal.FillColor = Color.White;
            txtContrasena.BackColor = Color.White;
            txtContrasena.CornerRadius = 8;
            txtContrasena.FillColor = Color.White;
            txtContrasena.Location = new Point(16, 166);
            txtContrasena.Font = new Font("Inter", 9F);
            txtContrasena.ForeColor = Color.FromArgb(32, 38, 45);
            txtContrasena.BorderColor = Color.FromArgb(218, 218, 218);
            txtContrasena.GradientColor = Color.Empty;
            txtContrasena.BorderThickness = 1;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(12, 8, 12, 8);
            txtContrasena.PasswordChar = '●';
            txtContrasena.Size = new Size(638, 34);
            txtContrasena.TabIndex = 5;
            txtContrasena.UseSystemPasswordChar = true;
            //
            // txtNombreUsuario
            //
            txtNombreUsuario.Appearance.Normal.FillColor = Color.White;
            txtNombreUsuario.BackColor = Color.White;
            txtNombreUsuario.CornerRadius = 8;
            txtNombreUsuario.FillColor = Color.White;
            txtNombreUsuario.Location = new Point(16, 96);
            txtNombreUsuario.Font = new Font("Inter", 9F);
            txtNombreUsuario.ForeColor = Color.FromArgb(32, 38, 45);
            txtNombreUsuario.BorderColor = Color.FromArgb(218, 218, 218);
            txtNombreUsuario.GradientColor = Color.Empty;
            txtNombreUsuario.BorderThickness = 1;
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Padding = new Padding(12, 8, 12, 8);
            txtNombreUsuario.PasswordChar = '●';
            txtNombreUsuario.Size = new Size(638, 34);
            txtNombreUsuario.TabIndex = 3;
            //
            // FrmCrearUsuario
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(670, 544);
            Controls.Add(txtNombreUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ShowInTaskbar = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Controls.Add(btnCerrar);
            Controls.Add(kLabel3);
            Controls.Add(kLabel1);
            Controls.Add(kLabel2);
            Controls.Add(txtContrasena);
            Controls.Add(kLabel4);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(kLabel5);
            Controls.Add(cboRol);
            Controls.Add(kLabel6);
            Controls.Add(cboEmpleado);
            Controls.Add(chkMostrarContrasena);
            Controls.Add(chkActivo);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Font = new Font("Segoe UI", 9F);
            Name = "FrmCrearUsuario";
            Padding = new Padding(0);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear usuario";
            ResumeLayout(false);
        }

        #endregion
        private KovaqsUI.Controls.KButton btnCerrar;
        private KovaqsUI.Controls.KLabel kLabel3;
        private KovaqsUI.Controls.KLabel kLabel1;
        private KovaqsUI.Controls.KLabel kLabel2;
        private KovaqsUI.Controls.KLabel kLabel4;
        private KovaqsUI.Controls.KComboBox cboRol;
        private KovaqsUI.Controls.KLabel kLabel5;
        private KovaqsUI.Controls.KComboBox cboEmpleado;
        private KovaqsUI.Controls.KLabel kLabel6;
        private KovaqsUI.Controls.KCheckBox chkActivo;
        private KovaqsUI.Controls.KCheckBox chkMostrarContrasena;
        private KovaqsUI.Controls.KButton btnGuardar;
        private KovaqsUI.Controls.KButton btnCancelar;
        private KovaqsUI.Controls.KTextBox txtConfirmarContrasena;
        private KovaqsUI.Controls.KTextBox txtContrasena;
        private KovaqsUI.Controls.KTextBox txtNombreUsuario;
            private KovaqsUI.Components.KToastNotifier notificador;
}
}
