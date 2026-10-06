namespace Presentacion.Forms
{
    partial class FrmContPrincipal
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
            panel1 = new Panel();
            kLabel1 = new KovaqsUI.Controls.KLabel();
            kButton1 = new KovaqsUI.Controls.KButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(kLabel1);
            panel1.Controls.Add(kButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 38);
            panel1.TabIndex = 0;
            // 
            // kLabel1
            // 
            kLabel1.BackColor = Color.Transparent;
            kLabel1.ForeColor = Color.DimGray;
            kLabel1.Location = new Point(12, 12);
            kLabel1.Name = "kLabel1";
            kLabel1.Size = new Size(187, 15);
            kLabel1.TabIndex = 1;
            kLabel1.Text = "Control de empleados - CUNOR";
            kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kButton1
            // 
            kButton1.Animation.Duration = 200;
            kButton1.Appearance.Hover.FillColor = Color.Black;
            kButton1.Appearance.Hover.ForeColor = Color.Red;
            kButton1.Appearance.Normal.FillColor = Color.FromArgb(44, 44, 44);
            kButton1.BackColor = Color.Transparent;
            kButton1.CornerRadius = 5;
            kButton1.FillColor = Color.FromArgb(44, 44, 44);
            kButton1.FlatStyle = FlatStyle.Flat;
            kButton1.Font = new Font("Inter Medium", 9F);
            kButton1.Location = new Point(340, 7);
            kButton1.Name = "kButton1";
            kButton1.Padding = new Padding(12, 4, 12, 4);
            kButton1.Size = new Size(56, 24);
            kButton1.TabIndex = 0;
            kButton1.Text = "Salir";
            kButton1.UseVisualStyleBackColor = false;
            kButton1.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 606);
            panel2.TabIndex = 1;
            // 
            // FrmContPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 644);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmContPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmContPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private KovaqsUI.Controls.KButton kButton1;
        private Panel panel2;
        private KovaqsUI.Controls.KLabel kLabel1;
    }
}