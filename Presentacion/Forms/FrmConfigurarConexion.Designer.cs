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
            btnCancelar = new KovaqsUI.Controls.KButton();
            lblServidor = new KovaqsUI.Controls.KLabel();
            lblPuerto = new KovaqsUI.Controls.KLabel();
            lblBaseDatos = new KovaqsUI.Controls.KLabel();
            lblUsuario = new KovaqsUI.Controls.KLabel();
            lblContrasena = new KovaqsUI.Controls.KLabel();
            lblHuellaCertificado = new KovaqsUI.Controls.KLabel();
            lblTitulo = new KovaqsUI.Controls.KLabel();
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
            // btnCancelar
            //
            btnCancelar.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            btnCancelar.Appearance.Normal.BorderColor = Color.FromArgb(204, 148, 150);
            btnCancelar.Appearance.Normal.FillColor = Color.FromArgb(255, 248, 248);
            btnCancelar.Appearance.Normal.ForeColor = Color.FromArgb(166, 61, 64);
            btnCancelar.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BorderColor = Color.FromArgb(204, 148, 150);
            btnCancelar.CornerRadius = 8;
            btnCancelar.FillColor = Color.FromArgb(255, 248, 248);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            btnCancelar.Font = new Font("Inter", 9F);
            btnCancelar.ForeColor = Color.FromArgb(166, 61, 64);
            btnCancelar.Location = new Point(248, 350);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(10, 4, 10, 4);
            btnCancelar.Size = new Size(220, 40);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            //
            // lblServidor
            //
            lblServidor.AutoSize = false;
            lblServidor.BackColor = Color.Transparent;
            lblServidor.Font = new Font("Inter", 9F);
            lblServidor.ForeColor = Color.FromArgb(64, 64, 64);
            lblServidor.Location = new Point(16, 70);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(538, 24);
            lblServidor.TabIndex = 1;
            lblServidor.Text = "Servidor";
            lblServidor.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblPuerto
            //
            lblPuerto.AutoSize = false;
            lblPuerto.BackColor = Color.Transparent;
            lblPuerto.Font = new Font("Inter", 9F);
            lblPuerto.ForeColor = Color.FromArgb(64, 64, 64);
            lblPuerto.Location = new Point(572, 70);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(538, 24);
            lblPuerto.TabIndex = 2;
            lblPuerto.Text = "Puerto";
            lblPuerto.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblBaseDatos
            //
            lblBaseDatos.AutoSize = false;
            lblBaseDatos.BackColor = Color.Transparent;
            lblBaseDatos.Font = new Font("Inter", 9F);
            lblBaseDatos.ForeColor = Color.FromArgb(64, 64, 64);
            lblBaseDatos.Location = new Point(16, 140);
            lblBaseDatos.Name = "lblBaseDatos";
            lblBaseDatos.Size = new Size(538, 24);
            lblBaseDatos.TabIndex = 5;
            lblBaseDatos.Text = "Base de datos";
            lblBaseDatos.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblUsuario
            //
            lblUsuario.AutoSize = false;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Inter", 9F);
            lblUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsuario.Location = new Point(572, 140);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(538, 24);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario MySQL";
            lblUsuario.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblContrasena
            //
            lblContrasena.AutoSize = false;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Inter", 9F);
            lblContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            lblContrasena.Location = new Point(16, 210);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(538, 24);
            lblContrasena.TabIndex = 9;
            lblContrasena.Text = "Contraseña MySQL";
            lblContrasena.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblHuellaCertificado
            //
            lblHuellaCertificado.AutoSize = false;
            lblHuellaCertificado.BackColor = Color.Transparent;
            lblHuellaCertificado.Font = new Font("Inter", 9F);
            lblHuellaCertificado.ForeColor = Color.FromArgb(64, 64, 64);
            lblHuellaCertificado.Location = new Point(572, 210);
            lblHuellaCertificado.Name = "lblHuellaCertificado";
            lblHuellaCertificado.Size = new Size(538, 24);
            lblHuellaCertificado.TabIndex = 10;
            lblHuellaCertificado.Text = "Huella SHA-256";
            lblHuellaCertificado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblTitulo
            //
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1094, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Conexión a la base de datos";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
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
            Controls.Add(lblTitulo);
            Controls.Add(lblHuellaCertificado);
            Controls.Add(lblContrasena);
            Controls.Add(lblUsuario);
            Controls.Add(lblBaseDatos);
            Controls.Add(lblPuerto);
            Controls.Add(lblServidor);
            Controls.Add(btnCancelar);
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
            Icon = Properties.Resources.sgeicon;
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
        private KovaqsUI.Controls.KButton btnCancelar;
        private KovaqsUI.Controls.KLabel lblServidor;
        private KovaqsUI.Controls.KLabel lblPuerto;
        private KovaqsUI.Controls.KLabel lblBaseDatos;
        private KovaqsUI.Controls.KLabel lblUsuario;
        private KovaqsUI.Controls.KLabel lblContrasena;
        private KovaqsUI.Controls.KLabel lblHuellaCertificado;
        private KovaqsUI.Controls.KLabel lblTitulo;
        private KovaqsUI.Controls.KButton btnMostrar;
            private KovaqsUI.Components.KToastNotifier notificador;
}
}
