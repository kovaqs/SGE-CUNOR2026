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
            SuspendLayout();
            // 
            // txtBanco
            // 
            txtBanco.BackColor = Color.Transparent;
            txtBanco.CornerRadius = 8;
            txtBanco.Location = new Point(28, 23);
            txtBanco.Name = "txtBanco";
            txtBanco.Padding = new Padding(12, 8, 12, 8);
            txtBanco.PlaceholderText = "Nombre del Banco";
            txtBanco.Size = new Size(260, 33);
            txtBanco.TabIndex = 1;
            // 
            // txtCuentaBancaria
            // 
            txtCuentaBancaria.BackColor = Color.Transparent;
            txtCuentaBancaria.CornerRadius = 8;
            txtCuentaBancaria.Location = new Point(323, 23);
            txtCuentaBancaria.Name = "txtCuentaBancaria";
            txtCuentaBancaria.Padding = new Padding(12, 8, 12, 8);
            txtCuentaBancaria.PasswordChar = '●';
            txtCuentaBancaria.PlaceholderText = "Número de cuenta";
            txtCuentaBancaria.Size = new Size(260, 33);
            txtCuentaBancaria.TabIndex = 2;
            txtCuentaBancaria.UseSystemPasswordChar = true;
            // 
            // chkMostrarCuenta
            // 
            chkMostrarCuenta.BackColor = Color.Transparent;
            chkMostrarCuenta.CheckedState.BorderColor = Color.Indigo;
            chkMostrarCuenta.CheckedState.FillColor = Color.Indigo;
            chkMostrarCuenta.CheckedState.ForeColor = Color.White;
            chkMostrarCuenta.CornerRadius = 4;
            chkMostrarCuenta.Font = new Font("Inter", 9F, FontStyle.Bold);
            chkMostrarCuenta.ForeColor = Color.Indigo;
            chkMostrarCuenta.GlyphSize = 18;
            chkMostrarCuenta.Location = new Point(28, 73);
            chkMostrarCuenta.Name = "chkMostrarCuenta";
            chkMostrarCuenta.Padding = new Padding(2);
            chkMostrarCuenta.Size = new Size(260, 32);
            chkMostrarCuenta.TabIndex = 9;
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
            Name = "FrmExpedientesDatosBancarios";
            Text = "FrmExpedientesDatosBancarios";
            ResumeLayout(false);
        }

        #endregion

        private KovaqsUI.Controls.KTextBox txtBanco;
        private KovaqsUI.Controls.KTextBox txtCuentaBancaria;
        private KovaqsUI.Controls.KCheckBox chkMostrarCuenta;
    }
}