namespace Presentacion.Forms
{
    partial class FrmLogin
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
            lblBienvenida = new KovaqsUI.Controls.KLabel();
            lblIndicaciones = new KovaqsUI.Controls.KLabel();
            chkMostrarContrasena = new KovaqsUI.Controls.KCheckBox();
            btnIngresar = new KovaqsUI.Controls.KButton();
            panelAcceso = new Panel();
            picLogo = new PictureBox();
            txtContrasena = new KovaqsUI.Controls.KTextBox();
            txtUsuario = new KovaqsUI.Controls.KTextBox();
            lblUsuario = new KovaqsUI.Controls.KLabel();
            lblContrasena = new KovaqsUI.Controls.KLabel();
            panelCabecera = new Panel();
            lblTitulo = new KovaqsUI.Controls.KLabel();
            btnSalir = new KovaqsUI.Controls.KButton();
            panelImagen = new Panel();
            picFondo = new PictureBox();
            btnConfigurarConexion = new KovaqsUI.Controls.KButton();
            notificador = new KovaqsUI.Components.KToastNotifier(components);
            temporizadorConexion = new System.Windows.Forms.Timer(components);
            panelAcceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelCabecera.SuspendLayout();
            panelImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFondo).BeginInit();
            SuspendLayout();
            //
            // lblBienvenida
            //
            lblBienvenida.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBienvenida.AutoSize = false;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Inter", 22F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(32, 38, 45);
            lblBienvenida.Location = new Point(13, 25);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(360, 49);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "¡Bienvenid@!";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.TextRole = KovaqsUI.Controls.KTextRole.Title;
            //
            // lblIndicaciones
            //
            lblIndicaciones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblIndicaciones.AutoSize = false;
            lblIndicaciones.BackColor = Color.Transparent;
            lblIndicaciones.Font = new Font("Inter", 9F);
            lblIndicaciones.ForeColor = Color.FromArgb(64, 64, 64);
            lblIndicaciones.Location = new Point(21, 225);
            lblIndicaciones.Name = "lblIndicaciones";
            lblIndicaciones.Size = new Size(344, 46);
            lblIndicaciones.TabIndex = 2;
            lblIndicaciones.Text = "Introduce tus credenciales para ingresar\r\nSi aún no tienes una cuenta, solicítala a Administración";
            lblIndicaciones.TextAlign = ContentAlignment.MiddleCenter;
            lblIndicaciones.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // chkMostrarContrasena
            //
            chkMostrarContrasena.BackColor = Color.Transparent;
            chkMostrarContrasena.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
            chkMostrarContrasena.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
            chkMostrarContrasena.CheckedState.ForeColor = Color.White;
            chkMostrarContrasena.CornerRadius = 4;
            chkMostrarContrasena.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            chkMostrarContrasena.Font = new Font("Inter", 9F);
            chkMostrarContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            chkMostrarContrasena.GlyphSize = 18;
            chkMostrarContrasena.Location = new Point(21, 435);
            chkMostrarContrasena.Name = "chkMostrarContrasena";
            chkMostrarContrasena.Padding = new Padding(2);
            chkMostrarContrasena.Size = new Size(344, 32);
            chkMostrarContrasena.TabIndex = 7;
            chkMostrarContrasena.Text = "Mostrar contraseña";
            chkMostrarContrasena.UseVisualStyleBackColor = false;
            //
            // btnIngresar
            //
            btnIngresar.Animation.Duration = 200;
            btnIngresar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
            btnIngresar.Appearance.Normal.BorderColor = Color.FromArgb(49, 81, 107);
            btnIngresar.Appearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
            btnIngresar.Appearance.Normal.ForeColor = Color.White;
            btnIngresar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.BorderColor = Color.FromArgb(49, 81, 107);
            btnIngresar.CornerRadius = 8;
            btnIngresar.FillColor = Color.FromArgb(49, 81, 107);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
            btnIngresar.Font = new Font("Inter", 9F);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(21, 482);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Padding = new Padding(10, 4, 10, 4);
            btnIngresar.Size = new Size(344, 40);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.UseVisualStyleBackColor = false;
            //
            // panelAcceso
            //
            panelAcceso.BackColor = Color.White;
            panelAcceso.Controls.Add(picLogo);
            panelAcceso.Controls.Add(btnIngresar);
            panelAcceso.Controls.Add(chkMostrarContrasena);
            panelAcceso.Controls.Add(txtContrasena);
            panelAcceso.Controls.Add(txtUsuario);
            panelAcceso.Controls.Add(lblIndicaciones);
            panelAcceso.Controls.Add(lblBienvenida);
            panelAcceso.Controls.Add(lblUsuario);
            panelAcceso.Controls.Add(lblContrasena);
            panelAcceso.Dock = DockStyle.Left;
            panelAcceso.Location = new Point(1, 38);
            panelAcceso.Name = "panelAcceso";
            panelAcceso.Size = new Size(384, 564);
            panelAcceso.TabIndex = 1;
            panelAcceso.Paint += panelAcceso_Paint;
            //
            // picLogo
            //
            picLogo.Image = Properties.Resources.logo_inst;
            picLogo.Location = new Point(133, 85);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 120);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
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
            txtContrasena.Location = new Point(21, 389);
            txtContrasena.MaxLength = 128;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Padding = new Padding(12, 8, 12, 8);
            txtContrasena.PasswordChar = '●';
            txtContrasena.PlaceholderText = "Contraseña";
            txtContrasena.Size = new Size(344, 34);
            txtContrasena.TabIndex = 6;
            txtContrasena.UseSystemPasswordChar = true;
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
            txtUsuario.Location = new Point(21, 319);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Padding = new Padding(12, 8, 12, 8);
            txtUsuario.PlaceholderText = "Nombre de Usuario";
            txtUsuario.Size = new Size(344, 34);
            txtUsuario.TabIndex = 4;
            //
            // lblUsuario
            //
            lblUsuario.AutoSize = false;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Inter", 9F);
            lblUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsuario.Location = new Point(21, 293);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(344, 24);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Nombre de usuario";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            lblUsuario.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblContrasena
            //
            lblContrasena.AutoSize = false;
            lblContrasena.BackColor = Color.Transparent;
            lblContrasena.Font = new Font("Inter", 9F);
            lblContrasena.ForeColor = Color.FromArgb(64, 64, 64);
            lblContrasena.Location = new Point(21, 363);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(344, 24);
            lblContrasena.TabIndex = 5;
            lblContrasena.Text = "Contraseña";
            lblContrasena.TextAlign = ContentAlignment.MiddleLeft;
            lblContrasena.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // panelCabecera
            //
            panelCabecera.BackColor = Color.White;
            panelCabecera.Controls.Add(btnConfigurarConexion);
            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(btnSalir);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Location = new Point(1, 1);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(868, 37);
            panelCabecera.TabIndex = 0;
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Inter", 9F);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Control de empleados - CUNOR";
            lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // btnSalir
            //
            btnSalir.Animation.Duration = 200;
            btnSalir.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            btnSalir.Appearance.Normal.BorderColor = Color.FromArgb(204, 148, 150);
            btnSalir.Appearance.Normal.FillColor = Color.FromArgb(255, 248, 248);
            btnSalir.Appearance.Normal.ForeColor = Color.FromArgb(166, 61, 64);
            btnSalir.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BorderColor = Color.FromArgb(204, 148, 150);
            btnSalir.CornerRadius = 8;
            btnSalir.FillColor = Color.FromArgb(255, 248, 248);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            btnSalir.Font = new Font("Inter", 9F);
            btnSalir.ForeColor = Color.FromArgb(166, 61, 64);
            btnSalir.Location = new Point(807, 7);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 4, 10, 4);
            btnSalir.Size = new Size(56, 24);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            //
            // panelImagen
            //
            panelImagen.BackColor = Color.White;
            panelImagen.Controls.Add(picFondo);
            panelImagen.Dock = DockStyle.Fill;
            panelImagen.Location = new Point(385, 38);
            panelImagen.Name = "panelImagen";
            panelImagen.Size = new Size(484, 564);
            panelImagen.TabIndex = 2;
            //
            // picFondo
            //
            picFondo.Dock = DockStyle.Fill;
            picFondo.Image = Properties.Resources.imageSistema3;
            picFondo.Location = new Point(0, 0);
            picFondo.Name = "picFondo";
            picFondo.Size = new Size(484, 564);
            picFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            picFondo.TabIndex = 0;
            picFondo.TabStop = false;
            //
            // btnConfigurarConexion
            //
            btnConfigurarConexion.Animation.Duration = 200;
            btnConfigurarConexion.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            btnConfigurarConexion.Appearance.Normal.BorderColor = Color.FromArgb(64, 64, 64);
            btnConfigurarConexion.Appearance.Normal.FillColor = Color.White;
            btnConfigurarConexion.Appearance.Normal.ForeColor = Color.Black;
            btnConfigurarConexion.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            btnConfigurarConexion.BackColor = Color.Transparent;
            btnConfigurarConexion.BorderColor = Color.FromArgb(64, 64, 64);
            btnConfigurarConexion.CornerRadius = 8;
            btnConfigurarConexion.FillColor = Color.White;
            btnConfigurarConexion.FlatStyle = FlatStyle.Flat;
            btnConfigurarConexion.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            btnConfigurarConexion.Font = new Font("Inter", 9F);
            btnConfigurarConexion.ForeColor = Color.Black;
            btnConfigurarConexion.Location = new Point(625, 7);
            btnConfigurarConexion.Name = "btnConfigurarConexion";
            btnConfigurarConexion.Padding = new Padding(10, 4, 10, 4);
            btnConfigurarConexion.Size = new Size(176, 24);
            btnConfigurarConexion.TabIndex = 2;
            btnConfigurarConexion.Text = "Configurar la conexión";
            btnConfigurarConexion.UseVisualStyleBackColor = false;
            btnConfigurarConexion.Visible = false;
            btnConfigurarConexion.Click += btnConfigurarConexion_Click;
            //
            // notificador
            //
            notificador.OwnerForm = this;
            //
            // temporizadorConexion
            //
            temporizadorConexion.Interval = 3000;
            temporizadorConexion.Tick += temporizadorConexion_Tick;
            //
            // FrmLogin
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(870, 603);
            Controls.Add(panelImagen);
            Controls.Add(panelAcceso);
            Controls.Add(panelCabecera);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = Properties.Resources.sgeicon;
            Name = "FrmLogin";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            panelAcceso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelCabecera.ResumeLayout(false);
            panelImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFondo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KovaqsUI.Controls.KLabel lblBienvenida;
        private KovaqsUI.Controls.KLabel lblIndicaciones;
        private KovaqsUI.Controls.KCheckBox chkMostrarContrasena;
        private KovaqsUI.Controls.KButton btnIngresar;
        private Panel panelAcceso;
        private KovaqsUI.Controls.KTextBox txtContrasena;
        private KovaqsUI.Controls.KTextBox txtUsuario;
        private Panel panelCabecera;
        private KovaqsUI.Controls.KLabel lblTitulo;
        private KovaqsUI.Controls.KButton btnSalir;
        private Panel panelImagen;
        private PictureBox picFondo;
        private PictureBox picLogo;
            private KovaqsUI.Controls.KLabel lblUsuario;
        private KovaqsUI.Controls.KLabel lblContrasena;
        private KovaqsUI.Controls.KButton btnConfigurarConexion;
        private KovaqsUI.Components.KToastNotifier notificador;
        private System.Windows.Forms.Timer temporizadorConexion;
    }
}
