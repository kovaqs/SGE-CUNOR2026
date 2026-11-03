namespace Presentacion.Forms.SubForms
{
    partial class FrmExpedientesDatosBancarios
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
            txtBanco = new KovaqsUI.Controls.KTextBox();
            txtCuentaBancaria = new KovaqsUI.Controls.KTextBox();
            chkMostrarCuenta = new KovaqsUI.Controls.KCheckBox();
            lblBanco = new KovaqsUI.Controls.KLabel();
            lblBanco.Text = "Nombre del banco";
            lblBanco.Location = new Point(16, 16);
            lblBanco.Size = new Size(423, 24);
            lblBanco.Font = new Font("Inter", 9F);
            lblBanco.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblBanco.ForeColor = Color.FromArgb(64, 64, 64);
            lblBanco.BackColor = Color.Transparent;
            lblBanco.AutoSize = false;
            lblBanco.TextAlign = ContentAlignment.MiddleLeft;
            lblBanco.TabStop = false;
            lblBanco.TabIndex = 0;
            lblBanco.Name = "lblBanco";
            lblCuentaBancaria = new KovaqsUI.Controls.KLabel();
            lblCuentaBancaria.Text = "Número de cuenta";
            lblCuentaBancaria.Location = new Point(456, 16);
            lblCuentaBancaria.Size = new Size(423, 24);
            lblCuentaBancaria.Font = new Font("Inter", 9F);
            lblCuentaBancaria.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblCuentaBancaria.ForeColor = Color.FromArgb(64, 64, 64);
            lblCuentaBancaria.BackColor = Color.Transparent;
            lblCuentaBancaria.AutoSize = false;
            lblCuentaBancaria.TextAlign = ContentAlignment.MiddleLeft;
            lblCuentaBancaria.TabStop = false;
            lblCuentaBancaria.TabIndex = 1;
            lblCuentaBancaria.Name = "lblCuentaBancaria";
            SuspendLayout();
            //
            // txtBanco
            //
            txtBanco.BackColor = Color.Transparent;
            txtBanco.CornerRadius = 8;
            txtBanco.Location = new Point(16, 42);
            txtBanco.Font = new Font("Inter", 9F);
            txtBanco.FillColor = Color.White;
            txtBanco.ForeColor = Color.FromArgb(32, 38, 45);
            txtBanco.BorderColor = Color.FromArgb(218, 218, 218);
            txtBanco.GradientColor = Color.Empty;
            txtBanco.BorderThickness = 1;
            txtBanco.Name = "txtBanco";
            txtBanco.Padding = new Padding(12, 8, 12, 8);
            txtBanco.PlaceholderText = "Nombre del Banco";
            txtBanco.Size = new Size(423, 34);
            txtBanco.TabIndex = 2;
            //
            // txtCuentaBancaria
            //
            txtCuentaBancaria.BackColor = Color.Transparent;
            txtCuentaBancaria.CornerRadius = 8;
            txtCuentaBancaria.Location = new Point(456, 42);
            txtCuentaBancaria.Font = new Font("Inter", 9F);
            txtCuentaBancaria.FillColor = Color.White;
            txtCuentaBancaria.ForeColor = Color.FromArgb(32, 38, 45);
            txtCuentaBancaria.BorderColor = Color.FromArgb(218, 218, 218);
            txtCuentaBancaria.GradientColor = Color.Empty;
            txtCuentaBancaria.BorderThickness = 1;
            txtCuentaBancaria.Name = "txtCuentaBancaria";
            txtCuentaBancaria.Padding = new Padding(12, 8, 12, 8);
            txtCuentaBancaria.PasswordChar = '●';
            txtCuentaBancaria.PlaceholderText = "Número de cuenta";
            txtCuentaBancaria.Size = new Size(423, 34);
            txtCuentaBancaria.TabIndex = 3;
            txtCuentaBancaria.UseSystemPasswordChar = true;
            //
            // chkMostrarCuenta
            //
            chkMostrarCuenta.BackColor = Color.Transparent;
            chkMostrarCuenta.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
            chkMostrarCuenta.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
            chkMostrarCuenta.CheckedState.ForeColor = Color.White;
            chkMostrarCuenta.CornerRadius = 4;
            chkMostrarCuenta.Font = new Font("Inter", 9F);
            chkMostrarCuenta.ForeColor = Color.FromArgb(64, 64, 64);
            chkMostrarCuenta.GlyphSize = 18;
            chkMostrarCuenta.Location = new Point(16, 94);
            chkMostrarCuenta.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            chkMostrarCuenta.Name = "chkMostrarCuenta";
            chkMostrarCuenta.Padding = new Padding(2);
            chkMostrarCuenta.Size = new Size(423, 36);
            chkMostrarCuenta.TabIndex = 4;
            chkMostrarCuenta.Text = "Mostrar cuenta bancaria";
            chkMostrarCuenta.UseVisualStyleBackColor = false;
            //
            // FrmExpedientesDatosBancarios
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 450);
            Controls.Add(chkMostrarCuenta);
            Controls.Add(txtCuentaBancaria);
            Controls.Add(txtBanco);
            FormBorderStyle = FormBorderStyle.None;
            Font = new Font("Segoe UI", 9F);
            Controls.Add(lblBanco);
            Controls.Add(lblCuentaBancaria);
            Icon = Properties.Resources.sgeicon;
            Name = "FrmExpedientesDatosBancarios";
            Text = "FrmExpedientesDatosBancarios";
            ResumeLayout(false);
        }

        #endregion

        private KovaqsUI.Controls.KTextBox txtBanco;
        private KovaqsUI.Controls.KTextBox txtCuentaBancaria;
        private KovaqsUI.Controls.KCheckBox chkMostrarCuenta;
            private KovaqsUI.Controls.KLabel lblBanco;
        private KovaqsUI.Controls.KLabel lblCuentaBancaria;
}
}
