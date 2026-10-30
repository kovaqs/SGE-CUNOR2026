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
            kLabel1 = new KovaqsUI.Controls.KLabel();
            kLabel2 = new KovaqsUI.Controls.KLabel();
            kCheckBox1 = new KovaqsUI.Controls.KCheckBox();
            kButton1 = new KovaqsUI.Controls.KButton();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            kTextBox2 = new KovaqsUI.Controls.KTextBox();
            kTextBox1 = new KovaqsUI.Controls.KTextBox();
            lblUsuario = new KovaqsUI.Controls.KLabel();
            lblContrasena = new KovaqsUI.Controls.KLabel();
            panel2 = new Panel();
            kLabel3 = new KovaqsUI.Controls.KLabel();
            kButton2 = new KovaqsUI.Controls.KButton();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kLabel1
            // 
            kLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kLabel1.AutoSize = false;
            kLabel1.BackColor = Color.Transparent;
            kLabel1.Font = new Font("Inter", 22F, FontStyle.Bold);
            kLabel1.ForeColor = Color.FromArgb(32, 38, 45);
            kLabel1.Location = new Point(13, 25);
            kLabel1.Name = "kLabel1";
            kLabel1.Size = new Size(360, 49);
            kLabel1.TabIndex = 0;
            kLabel1.Text = "¡Bienvenid@!";
            kLabel1.TextAlign = ContentAlignment.MiddleCenter;
            kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Title;
            // 
            // kLabel2
            // 
            kLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kLabel2.AutoSize = false;
            kLabel2.BackColor = Color.Transparent;
            kLabel2.Font = new Font("Inter", 9F);
            kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel2.Location = new Point(21, 225);
            kLabel2.Name = "kLabel2";
            kLabel2.Size = new Size(344, 46);
            kLabel2.TabIndex = 2;
            kLabel2.Text = "Introduce tus credenciales para ingresar\r\nSi aún no tienes una cuenta, solicítala a Administración";
            kLabel2.TextAlign = ContentAlignment.MiddleCenter;
            kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kCheckBox1
            // 
            kCheckBox1.BackColor = Color.Transparent;
            kCheckBox1.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
            kCheckBox1.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
            kCheckBox1.CheckedState.ForeColor = Color.White;
            kCheckBox1.CornerRadius = 4;
            kCheckBox1.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            kCheckBox1.Font = new Font("Inter", 9F);
            kCheckBox1.ForeColor = Color.FromArgb(64, 64, 64);
            kCheckBox1.GlyphSize = 18;
            kCheckBox1.Location = new Point(21, 435);
            kCheckBox1.Name = "kCheckBox1";
            kCheckBox1.Padding = new Padding(2);
            kCheckBox1.Size = new Size(344, 32);
            kCheckBox1.TabIndex = 7;
            kCheckBox1.Text = "Mostrar contraseña";
            kCheckBox1.UseVisualStyleBackColor = false;
            // 
            // kButton1
            // 
            kButton1.Animation.Duration = 200;
            kButton1.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
            kButton1.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
            kButton1.BackColor = Color.Transparent;
            kButton1.BorderColor = Color.FromArgb(49, 81, 107);
            kButton1.CornerRadius = 8;
            kButton1.FillColor = Color.FromArgb(49, 81, 107);
            kButton1.FlatStyle = FlatStyle.Flat;
            kButton1.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
            kButton1.Font = new Font("Inter", 9F);
            kButton1.ForeColor = Color.White;
            kButton1.Location = new Point(21, 482);
            kButton1.Name = "kButton1";
            kButton1.Padding = new Padding(10, 4, 10, 4);
            kButton1.Size = new Size(344, 40);
            kButton1.TabIndex = 8;
            kButton1.Text = "Iniciar sesión";
            kButton1.UseVisualStyleBackColor = false;
            kButton1.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
            kButton1.GradientColor = Color.Empty;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(kButton1);
            panel1.Controls.Add(kCheckBox1);
            panel1.Controls.Add(kTextBox2);
            panel1.Controls.Add(kTextBox1);
            panel1.Controls.Add(kLabel2);
            panel1.Controls.Add(kLabel1);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(lblContrasena);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(1, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 564);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_inst;
            pictureBox2.Location = new Point(133, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // kTextBox2
            // 
            kTextBox2.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
            kTextBox2.Appearance.Normal.FillColor = Color.White;
            kTextBox2.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            kTextBox2.BackColor = Color.Transparent;
            kTextBox2.BorderColor = Color.FromArgb(218, 218, 218);
            kTextBox2.CornerRadius = 8;
            kTextBox2.FillColor = Color.White;
            kTextBox2.Font = new Font("Inter", 9F);
            kTextBox2.ForeColor = Color.FromArgb(32, 38, 45);
            kTextBox2.Location = new Point(21, 389);
            kTextBox2.MaxLength = 128;
            kTextBox2.Name = "kTextBox2";
            kTextBox2.Padding = new Padding(12, 8, 12, 8);
            kTextBox2.PasswordChar = '●';
            kTextBox2.PlaceholderText = "Contraseña";
            kTextBox2.Size = new Size(344, 34);
            kTextBox2.TabIndex = 6;
            kTextBox2.UseSystemPasswordChar = true;
            // 
            // kTextBox1
            // 
            kTextBox1.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
            kTextBox1.Appearance.Normal.FillColor = Color.White;
            kTextBox1.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            kTextBox1.BackColor = Color.Transparent;
            kTextBox1.BorderColor = Color.FromArgb(218, 218, 218);
            kTextBox1.CornerRadius = 8;
            kTextBox1.FillColor = Color.White;
            kTextBox1.Font = new Font("Inter", 9F);
            kTextBox1.ForeColor = Color.FromArgb(32, 38, 45);
            kTextBox1.Location = new Point(21, 319);
            kTextBox1.MaxLength = 50;
            kTextBox1.Name = "kTextBox1";
            kTextBox1.Padding = new Padding(12, 8, 12, 8);
            kTextBox1.PlaceholderText = "Nombre de Usuario";
            kTextBox1.Size = new Size(344, 34);
            kTextBox1.TabIndex = 4;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(kLabel3);
            panel2.Controls.Add(kButton2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(868, 37);
            panel2.TabIndex = 0;
            // 
            // kLabel3
            // 
            kLabel3.AutoSize = false;
            kLabel3.BackColor = Color.Transparent;
            kLabel3.Font = new Font("Inter", 9F);
            kLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel3.Location = new Point(12, 9);
            kLabel3.Name = "kLabel3";
            kLabel3.Size = new Size(270, 20);
            kLabel3.TabIndex = 1;
            kLabel3.Text = "Control de empleados - CUNOR";
            kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kButton2
            // 
            kButton2.Animation.Duration = 200;
            kButton2.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            kButton2.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            kButton2.BackColor = Color.Transparent;
            kButton2.BorderColor = Color.FromArgb(204, 148, 150);
            kButton2.CornerRadius = 8;
            kButton2.FillColor = Color.FromArgb(255, 248, 248);
            kButton2.FlatStyle = FlatStyle.Flat;
            kButton2.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            kButton2.Font = new Font("Inter", 9F);
            kButton2.ForeColor = Color.FromArgb(166, 61, 64);
            kButton2.Location = new Point(807, 7);
            kButton2.Name = "kButton2";
            kButton2.Padding = new Padding(10, 4, 10, 4);
            kButton2.Size = new Size(56, 24);
            kButton2.TabIndex = 0;
            kButton2.Text = "Salir";
            kButton2.UseVisualStyleBackColor = false;
            kButton2.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            kButton2.GradientColor = Color.Empty;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(385, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(484, 564);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.imageSistema3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(484, 564);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(870, 603);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KovaqsUI.Controls.KLabel kLabel1;
        private KovaqsUI.Controls.KLabel kLabel2;
        private KovaqsUI.Controls.KCheckBox kCheckBox1;
        private KovaqsUI.Controls.KButton kButton1;
        private Panel panel1;
        private KovaqsUI.Controls.KTextBox kTextBox2;
        private KovaqsUI.Controls.KTextBox kTextBox1;
        private Panel panel2;
        private KovaqsUI.Controls.KLabel kLabel3;
        private KovaqsUI.Controls.KButton kButton2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
            private KovaqsUI.Controls.KLabel lblUsuario;
        private KovaqsUI.Controls.KLabel lblContrasena;
}
}
