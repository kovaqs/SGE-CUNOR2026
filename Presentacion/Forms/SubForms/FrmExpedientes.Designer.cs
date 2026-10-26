namespace Presentacion.Forms.SubForms
{
    partial class FrmExpedientes
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
            panel2 = new Panel();
            kLabel3 = new KovaqsUI.Controls.KLabel();
            btnCerrar = new KovaqsUI.Controls.KButton();
            panel1 = new Panel();
            kSegmentedControl1 = new KovaqsUI.Controls.KSegmentedControl();
            kSegmentItem3 = new KovaqsUI.Controls.KSegmentItem();
            kSegmentItem4 = new KovaqsUI.Controls.KSegmentItem();
            kSegmentItem5 = new KovaqsUI.Controls.KSegmentItem();
            kSegmentItem1 = new KovaqsUI.Controls.KSegmentItem();
            kSegmentItem2 = new KovaqsUI.Controls.KSegmentItem();
            panel3 = new Panel();
            btnCancelar = new KovaqsUI.Controls.KButton();
            btnGuardar = new KovaqsUI.Controls.KButton();
            panelDatos = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(kLabel3);
            panel2.Controls.Add(btnCerrar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 37);
            panel2.TabIndex = 3;
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
            btnCerrar.Location = new Point(891, 7);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(12, 4, 12, 4);
            btnCerrar.Size = new Size(71, 24);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Salir";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelDatos);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(kSegmentedControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 654);
            panel1.TabIndex = 4;
            // 
            // kSegmentedControl1
            // 
            kSegmentedControl1.BackColor = Color.White;
            kSegmentedControl1.Dock = DockStyle.Top;
            kSegmentedControl1.FillColor = Color.White;
            kSegmentedControl1.Items.AddRange(new KovaqsUI.Controls.KSegmentItem[] { kSegmentItem3, kSegmentItem4, kSegmentItem5 });
            kSegmentedControl1.Location = new Point(0, 0);
            kSegmentedControl1.Name = "kSegmentedControl1";
            kSegmentedControl1.SelectedAppearance.Normal.FillColor = Color.DarkSlateGray;
            kSegmentedControl1.SelectedAppearance.Normal.ForeColor = Color.WhiteSmoke;
            kSegmentedControl1.SelectedFillColor = Color.DarkSlateGray;
            kSegmentedControl1.SelectedForeColor = Color.WhiteSmoke;
            kSegmentedControl1.SelectedIndex = 0;
            kSegmentedControl1.Size = new Size(974, 48);
            kSegmentedControl1.Surface.FillColor = Color.White;
            kSegmentedControl1.TabIndex = 0;
            kSegmentedControl1.Text = "kSegmentedControl1";
            // 
            // kSegmentItem3
            // 
            kSegmentItem3.Text = "Datos Personales";
            // 
            // kSegmentItem4
            // 
            kSegmentItem4.Text = "Datos Laborales";
            // 
            // kSegmentItem5
            // 
            kSegmentItem5.Text = "Datos Bancarios";
            // 
            // kSegmentItem2
            // 
            kSegmentItem2.Value = "ss";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCancelar);
            panel3.Controls.Add(btnGuardar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 581);
            panel3.Name = "panel3";
            panel3.Size = new Size(974, 73);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.CornerRadius = 8;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Inter", 10F);
            btnCancelar.Location = new Point(287, 20);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(12, 4, 12, 4);
            btnCancelar.Size = new Size(260, 34);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.CornerRadius = 8;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Inter", 10F);
            btnGuardar.Location = new Point(12, 20);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(12, 4, 12, 4);
            btnGuardar.Size = new Size(260, 34);
            btnGuardar.TabIndex = 38;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // panelDatos
            // 
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(0, 48);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(974, 533);
            panelDatos.TabIndex = 2;
            // 
            // FrmExpedientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(976, 693);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmExpedientes";
            Padding = new Padding(1);
            Text = "FrmExpedientes";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private KovaqsUI.Controls.KLabel kLabel3;
        private KovaqsUI.Controls.KButton btnCerrar;
        private Panel panel1;
        private KovaqsUI.Controls.KSegmentItem kSegmentItem1;
        private KovaqsUI.Controls.KSegmentedControl kSegmentedControl1;
        private KovaqsUI.Controls.KSegmentItem kSegmentItem3;
        private KovaqsUI.Controls.KSegmentItem kSegmentItem4;
        private KovaqsUI.Controls.KSegmentItem kSegmentItem5;
        private KovaqsUI.Controls.KSegmentItem kSegmentItem2;
        private Panel panel3;
        private Panel panelDatos;
        private KovaqsUI.Controls.KButton btnCancelar;
        private KovaqsUI.Controls.KButton btnGuardar;
    }
}