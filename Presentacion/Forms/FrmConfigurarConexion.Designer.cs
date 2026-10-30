namespace Presentacion.Forms
{
    partial class FrmConfigurarConexion
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
            components = new System.ComponentModel.Container();
            txtServidor = new KovaqsUI.Controls.KTextBox();
            txtBaseDatos = new KovaqsUI.Controls.KTextBox();
            txtUsuario = new KovaqsUI.Controls.KTextBox();
            txtContrasena = new KovaqsUI.Controls.KTextBox();
            txtHuella = new KovaqsUI.Controls.KTextBox();
            numPuerto = new KovaqsUI.Controls.KTextBox();
            btnGuardar = new KovaqsUI.Controls.KButton();
            kButton2 = new KovaqsUI.Controls.KButton();
            kLabel1 = new KovaqsUI.Controls.KLabel();
            kLabel2 = new KovaqsUI.Controls.KLabel();
            kLabel3 = new KovaqsUI.Controls.KLabel();
            kLabel4 = new KovaqsUI.Controls.KLabel();
            kLabel5 = new KovaqsUI.Controls.KLabel();
            kLabel6 = new KovaqsUI.Controls.KLabel();
            kLabel7 = new KovaqsUI.Controls.KLabel();
            btnMostrar = new KovaqsUI.Controls.KButton();
            notificador = new KovaqsUI.Components.KToastNotifier(components);
            SuspendLayout();
            // 
            // txtServidor
            // 
            txtServidor.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
            txtServidor.Appearance.Normal.FillColor = Color.White;
            txtServidor.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            txtServidor.BackColor = Color.Transparent;
            txtServidor.BorderColor = Color.FromArgb(218, 218, 218);
            txtServidor.CornerRadius = 8;
            txtServidor.FillColor = Color.White;
            txtServidor.Font = new Font("Inter", 9F);
            txtServidor.ForeColor = Color.FromArgb(32, 38, 45);
            txtServidor.Location = new Point(16, 96);
            txtServidor.Name = "txtServidor";
            txtServidor.Padding = new Padding(12, 8, 12, 8);
            txtServidor.PasswordChar = '●';
            txtServidor.Size = new Size(538, 34);
            txtServidor.TabIndex = 3;
            txtServidor.UseSystemPasswordChar = true;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
            txtBaseDatos.Appearance.Normal.FillColor = Color.White;
            txtBaseDatos.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            txtBaseDatos.BackColor = Color.Transparent;
            txtBaseDatos.BorderColor = Color.FromArgb(218, 218, 218);
            txtBaseDatos.CornerRadius = 8;
            txtBaseDatos.FillColor = Color.White;
            txtBaseDatos.Font = new Font("Inter", 9F);
            txtBaseDatos.ForeColor = Color.FromArgb(32, 38, 45);
            txtBaseDatos.Location = new Point(16, 166);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Padding = new Padding(12, 8, 12, 8);
            txtBaseDatos.PasswordChar = '●';
            txtBaseDatos.Size = new Size(538, 34);
            txtBaseDatos.TabIndex = 7;
            txtBaseDatos.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
            txtUsuario.Appearance.Normal.FillColor = Color.White;
            txtUsuario.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.BorderColor = Color.FromArgb(218, 218, 218);
            txtUsuario.CornerRadius = 8;
            txtUsuario.FillColor = Color.White;
            txtUsuario.Font = new Font("Inter", 9F);
            txtUsuario.ForeColor = Color.FromArgb(32, 38, 45);
            txtUsuario.Location = new Point(572, 166);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(12, 8, 12, 8);
            txtUsuario.PasswordChar = '●';
            txtUsuario.Size = new Size(538, 34);
            txtUsuario.TabIndex = 8;
            txtUsuario.UseSystemPasswordChar = true;
            // 
            // txtContrasena
            // 
            txtContrasena.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
            txtContrasena.Appearance.Normal.FillColor = Color.White;
            txtContrasena.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            txtContrasena.BackColor = Color.Transparent;
            txtContrasena.BorderColor = Color.FromArgb(218, 218, 218);
            txtContrasena.CornerRadius = 8;
            txtContrasena.FillColor = Color.White;
            txtContrasena.Font = new Font("Inter", 9F);
            txtContrasena.ForeColor = Color.FromArgb(32, 38, 45);
            txtContrasena.Location = new Point(16, 236);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(12, 8, 12, 8);
            txtContrasena.PasswordChar = '●';
            txtContrasena.Size = new Size(538, 34);
            txtContrasena.TabIndex = 11;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtHuella
            // 
            txtHuella.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
            txtHuella.Appearance.Normal.FillColor = Color.White;
            txtHuella.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            txtHuella.BackColor = Color.Transparent;
            txtHuella.BorderColor = Color.FromArgb(218, 218, 218);
            txtHuella.CornerRadius = 8;
            txtHuella.FillColor = Color.White;
            txtHuella.Font = new Font("Inter", 9F);
            txtHuella.ForeColor = Color.FromArgb(32, 38, 45);
            txtHuella.Location = new Point(572, 236);
            txtHuella.Name = "txtHuella";
            txtHuella.Padding = new Padding(12, 8, 12, 8);
            txtHuella.PasswordChar = '●';
            txtHuella.Size = new Size(538, 34);
            txtHuella.TabIndex = 12;
            txtHuella.UseSystemPasswordChar = true;
            // 
            // numPuerto
            // 
            numPuerto.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
            numPuerto.Appearance.Normal.FillColor = Color.White;
            numPuerto.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            numPuerto.BackColor = Color.Transparent;
            numPuerto.BorderColor = Color.FromArgb(218, 218, 218);
            numPuerto.CornerRadius = 8;
            numPuerto.FillColor = Color.White;
            numPuerto.Font = new Font("Inter", 9F);
            numPuerto.ForeColor = Color.FromArgb(32, 38, 45);
            numPuerto.Location = new Point(572, 96);
            numPuerto.Name = "numPuerto";
            numPuerto.Padding = new Padding(12, 8, 12, 8);
            numPuerto.PasswordChar = '●';
            numPuerto.Size = new Size(538, 34);
            numPuerto.TabIndex = 4;
            numPuerto.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
            btnGuardar.Appearance.Normal.BorderColor = Color.FromArgb(49, 81, 107);
            btnGuardar.Appearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
            btnGuardar.Appearance.Normal.ForeColor = Color.White;
            btnGuardar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BorderColor = Color.FromArgb(49, 81, 107);
            btnGuardar.CornerRadius = 8;
            btnGuardar.FillColor = Color.FromArgb(49, 81, 107);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
            btnGuardar.Font = new Font("Inter", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(16, 350);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 4, 10, 4);
            btnGuardar.Size = new Size(220, 40);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // kButton2
            // 
            kButton2.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            kButton2.Appearance.Normal.BorderColor = Color.FromArgb(204, 148, 150);
            kButton2.Appearance.Normal.FillColor = Color.FromArgb(255, 248, 248);
            kButton2.Appearance.Normal.ForeColor = Color.FromArgb(166, 61, 64);
            kButton2.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            kButton2.BackColor = Color.Transparent;
            kButton2.BorderColor = Color.FromArgb(204, 148, 150);
            kButton2.CornerRadius = 8;
            kButton2.FillColor = Color.FromArgb(255, 248, 248);
            kButton2.FlatStyle = FlatStyle.Flat;
            kButton2.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            kButton2.Font = new Font("Inter", 9F);
            kButton2.ForeColor = Color.FromArgb(166, 61, 64);
            kButton2.Location = new Point(248, 350);
            kButton2.Name = "kButton2";
            kButton2.Padding = new Padding(10, 4, 10, 4);
            kButton2.Size = new Size(220, 40);
            kButton2.TabIndex = 15;
            kButton2.Text = "Cancelar";
            kButton2.UseVisualStyleBackColor = false;
            kButton2.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            // 
            // kLabel1
            // 
            kLabel1.AutoSize = false;
            kLabel1.BackColor = Color.Transparent;
            kLabel1.Font = new Font("Inter", 9F);
            kLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel1.Location = new Point(16, 70);
            kLabel1.Name = "kLabel1";
            kLabel1.Size = new Size(538, 24);
            kLabel1.TabIndex = 1;
            kLabel1.Text = "Servidor";
            kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel2
            // 
            kLabel2.AutoSize = false;
            kLabel2.BackColor = Color.Transparent;
            kLabel2.Font = new Font("Inter", 9F);
            kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel2.Location = new Point(572, 70);
            kLabel2.Name = "kLabel2";
            kLabel2.Size = new Size(538, 24);
            kLabel2.TabIndex = 2;
            kLabel2.Text = "Puerto";
            kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel3
            // 
            kLabel3.AutoSize = false;
            kLabel3.BackColor = Color.Transparent;
            kLabel3.Font = new Font("Inter", 9F);
            kLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel3.Location = new Point(16, 140);
            kLabel3.Name = "kLabel3";
            kLabel3.Size = new Size(538, 24);
            kLabel3.TabIndex = 5;
            kLabel3.Text = "Base de datos";
            kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel4
            // 
            kLabel4.AutoSize = false;
            kLabel4.BackColor = Color.Transparent;
            kLabel4.Font = new Font("Inter", 9F);
            kLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel4.Location = new Point(572, 140);
            kLabel4.Name = "kLabel4";
            kLabel4.Size = new Size(538, 24);
            kLabel4.TabIndex = 6;
            kLabel4.Text = "Usuario MySQL";
            kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel5
            // 
            kLabel5.AutoSize = false;
            kLabel5.BackColor = Color.Transparent;
            kLabel5.Font = new Font("Inter", 9F);
            kLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel5.Location = new Point(16, 210);
            kLabel5.Name = "kLabel5";
            kLabel5.Size = new Size(538, 24);
            kLabel5.TabIndex = 9;
            kLabel5.Text = "Contraseña MySQL";
            kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel6
            // 
            kLabel6.AutoSize = false;
            kLabel6.BackColor = Color.Transparent;
            kLabel6.Font = new Font("Inter", 9F);
            kLabel6.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel6.Location = new Point(572, 210);
            kLabel6.Name = "kLabel6";
            kLabel6.Size = new Size(538, 24);
            kLabel6.TabIndex = 10;
            kLabel6.Text = "Huella SHA-256";
            kLabel6.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel7
            // 
            kLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kLabel7.AutoSize = false;
            kLabel7.BackColor = Color.Transparent;
            kLabel7.Font = new Font("Inter", 16F, FontStyle.Bold);
            kLabel7.ForeColor = Color.FromArgb(32, 38, 45);
            kLabel7.Location = new Point(16, 12);
            kLabel7.Name = "kLabel7";
            kLabel7.Size = new Size(1094, 40);
            kLabel7.TabIndex = 0;
            kLabel7.Text = "Conexión a la base de datos";
            kLabel7.TextAlign = ContentAlignment.MiddleLeft;
            kLabel7.TextRole = KovaqsUI.Controls.KTextRole.Title;
            // 
            // btnMostrar
            // 
            btnMostrar.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
            btnMostrar.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
            btnMostrar.Appearance.Normal.FillColor = Color.White;
            btnMostrar.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            btnMostrar.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
            btnMostrar.BackColor = Color.Transparent;
            btnMostrar.BorderColor = Color.FromArgb(218, 218, 218);
            btnMostrar.CornerRadius = 8;
            btnMostrar.FillColor = Color.White;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            btnMostrar.Font = new Font("Inter", 9F);
            btnMostrar.ForeColor = Color.FromArgb(32, 38, 45);
            btnMostrar.Location = new Point(16, 286);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Padding = new Padding(10, 4, 10, 4);
            btnMostrar.Size = new Size(200, 40);
            btnMostrar.TabIndex = 13;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // notificador
            // 
            notificador.OwnerForm = this;
            // 
            // FrmConfigurarConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1126, 440);
            Controls.Add(btnMostrar);
            Controls.Add(kLabel7);
            Controls.Add(kLabel6);
            Controls.Add(kLabel5);
            Controls.Add(kLabel4);
            Controls.Add(kLabel3);
            Controls.Add(kLabel2);
            Controls.Add(kLabel1);
            Controls.Add(kButton2);
            Controls.Add(btnGuardar);
            Controls.Add(numPuerto);
            Controls.Add(txtHuella);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtBaseDatos);
            Controls.Add(txtServidor);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmConfigurarConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConfigurarConexion";
            ResumeLayout(false);
        }

        #endregion

        private KovaqsUI.Controls.KTextBox txtServidor;
        private KovaqsUI.Controls.KTextBox txtBaseDatos;
        private KovaqsUI.Controls.KTextBox txtUsuario;
        private KovaqsUI.Controls.KTextBox txtContrasena;
        private KovaqsUI.Controls.KTextBox txtHuella;
        private KovaqsUI.Controls.KTextBox numPuerto;
        private KovaqsUI.Controls.KButton btnGuardar;
        private KovaqsUI.Controls.KButton kButton2;
        private KovaqsUI.Controls.KLabel kLabel1;
        private KovaqsUI.Controls.KLabel kLabel2;
        private KovaqsUI.Controls.KLabel kLabel3;
        private KovaqsUI.Controls.KLabel kLabel4;
        private KovaqsUI.Controls.KLabel kLabel5;
        private KovaqsUI.Controls.KLabel kLabel6;
        private KovaqsUI.Controls.KLabel kLabel7;
        private KovaqsUI.Controls.KButton btnMostrar;
            private KovaqsUI.Components.KToastNotifier notificador;
}
}
