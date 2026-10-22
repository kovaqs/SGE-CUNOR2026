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
            kTextBox1 = new KovaqsUI.Controls.KTextBox();
            kTextBox2 = new KovaqsUI.Controls.KTextBox();
            panel2 = new Panel();
            kLabel3 = new KovaqsUI.Controls.KLabel();
            kButton2 = new KovaqsUI.Controls.KButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // kLabel1
            // 
            kLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kLabel1.AutoSize = false;
            kLabel1.BackColor = Color.Transparent;
            kLabel1.Location = new Point(13, 60);
            kLabel1.Name = "kLabel1";
            kLabel1.Size = new Size(379, 49);
            kLabel1.TabIndex = 3;
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
            kLabel2.Location = new Point(13, 109);
            kLabel2.Name = "kLabel2";
            kLabel2.Size = new Size(379, 46);
            kLabel2.TabIndex = 4;
            kLabel2.Text = "Introduce tus credenciales para empezar";
            kLabel2.TextAlign = ContentAlignment.TopCenter;
            kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Section;
            // 
            // kCheckBox1
            // 
            kCheckBox1.BackColor = Color.Transparent;
            kCheckBox1.CheckedState.BorderColor = Color.Indigo;
            kCheckBox1.CheckedState.FillColor = Color.Indigo;
            kCheckBox1.CheckedState.ForeColor = Color.White;
            kCheckBox1.CornerRadius = 4;
            kCheckBox1.Font = new Font("Inter", 9F, FontStyle.Bold);
            kCheckBox1.ForeColor = Color.Indigo;
            kCheckBox1.GlyphSize = 18;
            kCheckBox1.Location = new Point(30, 273);
            kCheckBox1.Name = "kCheckBox1";
            kCheckBox1.Padding = new Padding(2);
            kCheckBox1.Size = new Size(342, 32);
            kCheckBox1.TabIndex = 8;
            kCheckBox1.Text = "Mostrar contraseña";
            kCheckBox1.UseVisualStyleBackColor = false;
            // 
            // kButton1
            // 
            kButton1.Animation.Duration = 200;
            kButton1.Appearance.Hover.FillColor = Color.FromArgb(44, 44, 44);
            kButton1.Appearance.Hover.ForeColor = Color.LightSkyBlue;
            kButton1.Appearance.Normal.FillColor = Color.FromArgb(44, 44, 44);
            kButton1.Appearance.Normal.GradientColor = Color.Black;
            kButton1.BackColor = Color.Transparent;
            kButton1.CornerRadius = 10;
            kButton1.FillColor = Color.FromArgb(44, 44, 44);
            kButton1.FlatStyle = FlatStyle.Flat;
            kButton1.Font = new Font("Inter", 10F, FontStyle.Bold);
            kButton1.GradientColor = Color.Black;
            kButton1.Location = new Point(28, 332);
            kButton1.Name = "kButton1";
            kButton1.Padding = new Padding(12, 4, 12, 4);
            kButton1.Size = new Size(344, 40);
            kButton1.TabIndex = 9;
            kButton1.Text = "Iniciar sesión";
            kButton1.UseVisualStyleBackColor = false;
            kButton1.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
            // 
            // panel1
            // 
            panel1.Controls.Add(kButton1);
            panel1.Controls.Add(kCheckBox1);
            panel1.Controls.Add(kTextBox2);
            panel1.Controls.Add(kTextBox1);
            panel1.Controls.Add(kLabel2);
            panel1.Controls.Add(kLabel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 566);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // kTextBox1
            // 
            kTextBox1.Appearance.Normal.FillColor = Color.FromArgb(247, 247, 247);
            kTextBox1.BackColor = Color.Transparent;
            kTextBox1.BorderThickness = 0;
            kTextBox1.CornerRadius = 10;
            kTextBox1.FillColor = Color.FromArgb(247, 247, 247);
            kTextBox1.Location = new Point(28, 168);
            kTextBox1.Name = "kTextBox1";
            kTextBox1.MaxLength = 50;
            kTextBox1.Padding = new Padding(12, 8, 12, 8);
            kTextBox1.PlaceholderText = "Nombre de Usuario";
            kTextBox1.Size = new Size(346, 40);
            kTextBox1.TabIndex = 5;
            // 
            // kTextBox2
            // 
            kTextBox2.Appearance.Normal.FillColor = Color.FromArgb(247, 247, 247);
            kTextBox2.BackColor = Color.Transparent;
            kTextBox2.BorderThickness = 0;
            kTextBox2.CornerRadius = 10;
            kTextBox2.FillColor = Color.FromArgb(247, 247, 247);
            kTextBox2.Location = new Point(28, 223);
            kTextBox2.Name = "kTextBox2";
            kTextBox2.MaxLength = 128;
            kTextBox2.Padding = new Padding(12, 8, 12, 8);
            kTextBox2.PasswordChar = '●';
            kTextBox2.PlaceholderText = "Contraseña";
            kTextBox2.Size = new Size(346, 40);
            kTextBox2.TabIndex = 6;
            kTextBox2.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(kLabel3);
            panel2.Controls.Add(kButton2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 37);
            panel2.TabIndex = 1;
            // 
            // kLabel3
            // 
            kLabel3.BackColor = Color.Transparent;
            kLabel3.ForeColor = Color.DimGray;
            kLabel3.Location = new Point(12, 12);
            kLabel3.Name = "kLabel3";
            kLabel3.Size = new Size(187, 15);
            kLabel3.TabIndex = 1;
            kLabel3.Text = "Control de empleados - CUNOR";
            kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kButton2
            // 
            kButton2.Animation.Duration = 200;
            kButton2.Appearance.Hover.FillColor = Color.Black;
            kButton2.Appearance.Hover.ForeColor = Color.Red;
            kButton2.Appearance.Normal.FillColor = Color.FromArgb(44, 44, 44);
            kButton2.BackColor = Color.Transparent;
            kButton2.CornerRadius = 5;
            kButton2.FillColor = Color.FromArgb(44, 44, 44);
            kButton2.FlatStyle = FlatStyle.Flat;
            kButton2.Font = new Font("Inter Medium", 9F);
            kButton2.Location = new Point(340, 7);
            kButton2.Name = "kButton2";
            kButton2.Padding = new Padding(12, 4, 12, 4);
            kButton2.Size = new Size(56, 24);
            kButton2.TabIndex = 0;
            kButton2.Text = "Salir";
            kButton2.UseVisualStyleBackColor = false;
            kButton2.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}
