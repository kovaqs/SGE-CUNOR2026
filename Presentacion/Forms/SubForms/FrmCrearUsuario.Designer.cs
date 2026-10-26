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
            panel2 = new Panel();
            kLabel1 = new KovaqsUI.Controls.KLabel();
            kLabel2 = new KovaqsUI.Controls.KLabel();
            kLabel4 = new KovaqsUI.Controls.KLabel();
            cboRol = new KovaqsUI.Controls.KComboBox();
            kLabel5 = new KovaqsUI.Controls.KLabel();
            cboEmpleado = new KovaqsUI.Controls.KComboBox();
            kLabel6 = new KovaqsUI.Controls.KLabel();
            chkActivo = new KovaqsUI.Controls.KCheckBox();
            chkMostrarContrasena = new KovaqsUI.Controls.KCheckBox();
            lblEstado = new KovaqsUI.Controls.KLabel();
            btnGuardar = new KovaqsUI.Controls.KButton();
            btnCancelar = new KovaqsUI.Controls.KButton();
            panel1 = new Panel();
            txtConfirmarContrasena = new KovaqsUI.Controls.KTextBox();
            txtContrasena = new KovaqsUI.Controls.KTextBox();
            txtNombreUsuario = new KovaqsUI.Controls.KTextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Animation.Duration = 200;
            btnCerrar.Appearance.Hover.FillColor = Color.Black;
            btnCerrar.Appearance.Hover.ForeColor = Color.Red;
            btnCerrar.Appearance.Normal.FillColor = Color.FromArgb(44, 44, 44);
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.CornerRadius = 5;
            btnCerrar.FillColor = Color.FromArgb(44, 44, 44);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Inter Medium", 9F);
            btnCerrar.Location = new Point(258, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(12, 4, 12, 4);
            btnCerrar.Size = new Size(71, 24);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
            // 
            // kLabel3
            // 
            kLabel3.BackColor = Color.Transparent;
            kLabel3.Font = new Font("Inter", 9F, FontStyle.Bold);
            kLabel3.ForeColor = Color.Black;
            kLabel3.Location = new Point(12, 12);
            kLabel3.Name = "kLabel3";
            kLabel3.Size = new Size(88, 15);
            kLabel3.TabIndex = 1;
            kLabel3.Text = "Crear Usuario";
            kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(kLabel3);
            panel2.Controls.Add(btnCerrar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 37);
            panel2.TabIndex = 2;
            // 
            // kLabel1
            // 
            kLabel1.BackColor = Color.Transparent;
            kLabel1.ForeColor = Color.DimGray;
            kLabel1.Location = new Point(12, 21);
            kLabel1.Name = "kLabel1";
            kLabel1.Size = new Size(115, 15);
            kLabel1.TabIndex = 6;
            kLabel1.Text = "Nombre de usuario";
            kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel2
            // 
            kLabel2.BackColor = Color.Transparent;
            kLabel2.ForeColor = Color.DimGray;
            kLabel2.Location = new Point(12, 80);
            kLabel2.Name = "kLabel2";
            kLabel2.Size = new Size(73, 15);
            kLabel2.TabIndex = 8;
            kLabel2.Text = "Contraseña";
            kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel4
            // 
            kLabel4.BackColor = Color.Transparent;
            kLabel4.ForeColor = Color.DimGray;
            kLabel4.Location = new Point(12, 141);
            kLabel4.Name = "kLabel4";
            kLabel4.Size = new Size(132, 15);
            kLabel4.TabIndex = 10;
            kLabel4.Text = "Confirmar contraseña";
            kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.ItemHeight = 28;
            cboRol.Location = new Point(12, 254);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(316, 34);
            cboRol.TabIndex = 11;
            // 
            // kLabel5
            // 
            kLabel5.BackColor = Color.Transparent;
            kLabel5.ForeColor = Color.DimGray;
            kLabel5.Location = new Point(12, 236);
            kLabel5.Name = "kLabel5";
            kLabel5.Size = new Size(25, 15);
            kLabel5.TabIndex = 12;
            kLabel5.Text = "Rol";
            kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // cboEmpleado
            // 
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.ItemHeight = 28;
            cboEmpleado.Location = new Point(12, 324);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(316, 34);
            cboEmpleado.TabIndex = 13;
            // 
            // kLabel6
            // 
            kLabel6.BackColor = Color.Transparent;
            kLabel6.ForeColor = Color.DimGray;
            kLabel6.Location = new Point(12, 306);
            kLabel6.Name = "kLabel6";
            kLabel6.Size = new Size(176, 15);
            kLabel6.TabIndex = 14;
            kLabel6.Text = "Empleado asociado (opcional)";
            kLabel6.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // chkActivo
            // 
            chkActivo.BackColor = Color.Transparent;
            chkActivo.Font = new Font("Inter Medium", 9F);
            chkActivo.Location = new Point(12, 364);
            chkActivo.Name = "chkActivo";
            chkActivo.Padding = new Padding(2);
            chkActivo.Size = new Size(180, 32);
            chkActivo.TabIndex = 15;
            chkActivo.Text = "Usuario activo";
            chkActivo.UseVisualStyleBackColor = false;
            // 
            // chkMostrarContrasena
            // 
            chkMostrarContrasena.BackColor = Color.Transparent;
            chkMostrarContrasena.Font = new Font("Inter Medium", 9F);
            chkMostrarContrasena.Location = new Point(12, 195);
            chkMostrarContrasena.Name = "chkMostrarContrasena";
            chkMostrarContrasena.Padding = new Padding(2);
            chkMostrarContrasena.Size = new Size(180, 32);
            chkMostrarContrasena.TabIndex = 16;
            chkMostrarContrasena.Text = "Mostrar contraseñas";
            chkMostrarContrasena.UseVisualStyleBackColor = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = false;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.ForeColor = Color.DimGray;
            lblEstado.Location = new Point(12, 399);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(316, 21);
            lblEstado.TabIndex = 17;
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            lblEstado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.CornerRadius = 8;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(12, 430);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(12, 4, 12, 4);
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.CornerRadius = 8;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(178, 430);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(12, 4, 12, 4);
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtConfirmarContrasena);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(chkMostrarContrasena);
            panel1.Controls.Add(chkActivo);
            panel1.Controls.Add(kLabel6);
            panel1.Controls.Add(cboEmpleado);
            panel1.Controls.Add(kLabel5);
            panel1.Controls.Add(cboRol);
            panel1.Controls.Add(kLabel4);
            panel1.Controls.Add(kLabel2);
            panel1.Controls.Add(kLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 480);
            panel1.TabIndex = 3;
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Appearance.Normal.FillColor = Color.White;
            txtConfirmarContrasena.BackColor = Color.White;
            txtConfirmarContrasena.CornerRadius = 8;
            txtConfirmarContrasena.FillColor = Color.White;
            txtConfirmarContrasena.Location = new Point(12, 159);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Padding = new Padding(12, 8, 12, 8);
            txtConfirmarContrasena.PasswordChar = '●';
            txtConfirmarContrasena.Size = new Size(316, 30);
            txtConfirmarContrasena.TabIndex = 22;
            txtConfirmarContrasena.UseSystemPasswordChar = true;
            // 
            // txtContrasena
            // 
            txtContrasena.Appearance.Normal.FillColor = Color.White;
            txtContrasena.BackColor = Color.White;
            txtContrasena.CornerRadius = 8;
            txtContrasena.FillColor = Color.White;
            txtContrasena.Location = new Point(12, 98);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(12, 8, 12, 8);
            txtContrasena.PasswordChar = '●';
            txtContrasena.Size = new Size(316, 30);
            txtContrasena.TabIndex = 21;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Appearance.Normal.FillColor = Color.White;
            txtNombreUsuario.BackColor = Color.White;
            txtNombreUsuario.CornerRadius = 8;
            txtNombreUsuario.FillColor = Color.White;
            txtNombreUsuario.Location = new Point(13, 77);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Padding = new Padding(12, 8, 12, 8);
            txtNombreUsuario.PasswordChar = '●';
            txtNombreUsuario.Size = new Size(316, 30);
            txtNombreUsuario.TabIndex = 20;
            // 
            // FrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(340, 519);
            Controls.Add(txtNombreUsuario);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCrearUsuario";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCrearUsuario";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private KovaqsUI.Controls.KButton btnCerrar;
        private KovaqsUI.Controls.KLabel kLabel3;
        private Panel panel2;
        private KovaqsUI.Controls.KLabel kLabel1;
        private KovaqsUI.Controls.KLabel kLabel2;
        private KovaqsUI.Controls.KLabel kLabel4;
        private KovaqsUI.Controls.KComboBox cboRol;
        private KovaqsUI.Controls.KLabel kLabel5;
        private KovaqsUI.Controls.KComboBox cboEmpleado;
        private KovaqsUI.Controls.KLabel kLabel6;
        private KovaqsUI.Controls.KCheckBox chkActivo;
        private KovaqsUI.Controls.KCheckBox chkMostrarContrasena;
        private KovaqsUI.Controls.KLabel lblEstado;
        private KovaqsUI.Controls.KButton btnGuardar;
        private KovaqsUI.Controls.KButton btnCancelar;
        private Panel panel1;
        private KovaqsUI.Controls.KTextBox txtConfirmarContrasena;
        private KovaqsUI.Controls.KTextBox txtContrasena;
        private KovaqsUI.Controls.KTextBox txtNombreUsuario;
    }
}