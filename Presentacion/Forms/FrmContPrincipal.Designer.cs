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
            panelContenido = new Panel();
            btnSalir = new KovaqsUI.Controls.KButton();
            lblTitulo = new KovaqsUI.Controls.KLabel();
            panelCabecera = new Panel();
            panelCabecera.SuspendLayout();
            SuspendLayout();
            //
            // panelContenido
            //
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 38);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(403, 606);
            panelContenido.TabIndex = 1;
            //
            // btnSalir
            //
            btnSalir.Animation.Duration = 200;
            btnSalir.BackColor = Color.Transparent;
            btnSalir.CornerRadius = 8;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Inter", 9F);
            btnSalir.Location = new Point(340, 7);
            btnSalir.BorderThickness = 1;
            btnSalir.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            btnSalir.FillColor = Color.FromArgb(255, 248, 248);
            btnSalir.ForeColor = Color.FromArgb(166, 61, 64);
            btnSalir.BorderColor = Color.FromArgb(204, 148, 150);
            btnSalir.GradientColor = Color.Empty;
            btnSalir.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            btnSalir.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            btnSalir.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(10, 4, 10, 4);
            btnSalir.Size = new Size(56, 24);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            //
            // lblTitulo
            //
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Font = new Font("Inter", 9F);
            lblTitulo.AutoSize = false;
            lblTitulo.TabStop = false;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Control de empleados - CUNOR";
            lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // panelCabecera
            //
            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(btnSalir);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Location = new Point(0, 0);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(403, 38);
            panelCabecera.TabIndex = 0;
            //
            // FrmContPrincipal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(403, 644);
            Controls.Add(panelContenido);
            Controls.Add(panelCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Font = new Font("Segoe UI", 9F);
            Icon = Properties.Resources.sgeicon;
            Name = "FrmContPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmContPrincipal";
            panelCabecera.ResumeLayout(false);
            panelCabecera.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelContenido;
        private KovaqsUI.Controls.KButton btnSalir;
        private KovaqsUI.Controls.KLabel lblTitulo;
        private Panel panelCabecera;
    }
}
