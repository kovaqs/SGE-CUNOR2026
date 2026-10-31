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
            components = new System.ComponentModel.Container();
            notificador = new KovaqsUI.Components.KToastNotifier(components);
            notificador.OwnerForm = this;
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
            panel2.Size = new Size(974, 64);
            panel2.TabIndex = 0;
            //
            // kLabel3
            //
            kLabel3.BackColor = Color.Transparent;
            kLabel3.Font = new Font("Inter", 16F, FontStyle.Bold);
            kLabel3.ForeColor = Color.FromArgb(32, 38, 45);
            kLabel3.Location = new Point(16, 12);
            kLabel3.AutoSize = false;
            kLabel3.TabStop = false;
            kLabel3.Name = "kLabel3";
            kLabel3.Size = new Size(740, 40);
            kLabel3.TabIndex = 0;
            kLabel3.Text = "Expediente del empleado";
            kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Title;
            //
            // btnCerrar
            //
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Animation.Duration = 200;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.CornerRadius = 8;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Inter", 9F);
            btnCerrar.Location = new Point(862, 12);
            btnCerrar.BorderThickness = 1;
            btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            btnCerrar.FillColor = Color.White;
            btnCerrar.ForeColor = Color.FromArgb(32, 38, 45);
            btnCerrar.BorderColor = Color.FromArgb(218, 218, 218);
            btnCerrar.GradientColor = Color.Empty;
            btnCerrar.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
            btnCerrar.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
            btnCerrar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(10, 4, 10, 4);
            btnCerrar.Size = new Size(96, 40);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
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
            panel1.TabIndex = 1;
            //
            // kSegmentedControl1
            //
            kSegmentedControl1.BackColor = Color.White;
            kSegmentedControl1.Dock = DockStyle.Top;
            kSegmentedControl1.FillColor = Color.White;
            kSegmentedControl1.Items.AddRange(new KovaqsUI.Controls.KSegmentItem[] { kSegmentItem3, kSegmentItem4, kSegmentItem5 });
            kSegmentedControl1.Location = new Point(0, 0);
            kSegmentedControl1.Font = new Font("Inter", 9F);
            kSegmentedControl1.Name = "kSegmentedControl1";
            kSegmentedControl1.SelectedAppearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
            kSegmentedControl1.SelectedAppearance.Normal.ForeColor = Color.WhiteSmoke;
            kSegmentedControl1.SelectedFillColor = Color.FromArgb(49, 81, 107);
            kSegmentedControl1.SelectedForeColor = Color.White;
            kSegmentedControl1.SelectedIndex = 0;
            kSegmentedControl1.Size = new Size(974, 48);
            kSegmentedControl1.Surface.FillColor = Color.White;
            kSegmentedControl1.TabIndex = 0;
            kSegmentedControl1.Text = "kSegmentedControl1";
            //
            // kSegmentItem3
            //
            kSegmentItem3.Text = "Datos personales";
            //
            // kSegmentItem4
            //
            kSegmentItem4.Text = "Datos laborales";
            //
            // kSegmentItem5
            //
            kSegmentItem5.Text = "Datos bancarios";
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
            panel3.Size = new Size(974, 72);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            //
            // btnCancelar
            //
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.CornerRadius = 8;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Inter", 9F);
            btnCancelar.Location = new Point(802, 16);
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelar.BorderThickness = 1;
            btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            btnCancelar.FillColor = Color.FromArgb(255, 248, 248);
            btnCancelar.ForeColor = Color.FromArgb(166, 61, 64);
            btnCancelar.BorderColor = Color.FromArgb(204, 148, 150);
            btnCancelar.GradientColor = Color.Empty;
            btnCancelar.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            btnCancelar.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            btnCancelar.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(10, 4, 10, 4);
            btnCancelar.Size = new Size(144, 40);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            //
            // btnGuardar
            //
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.CornerRadius = 8;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Inter", 9F);
            btnGuardar.Location = new Point(646, 16);
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BorderThickness = 1;
            btnGuardar.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
            btnGuardar.FillColor = Color.FromArgb(49, 81, 107);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.BorderColor = Color.FromArgb(49, 81, 107);
            btnGuardar.GradientColor = Color.Empty;
            btnGuardar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
            btnGuardar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
            btnGuardar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 4, 10, 4);
            btnGuardar.Size = new Size(144, 40);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            //
            // panelDatos
            //
            panelDatos.Dock = DockStyle.Fill;
            panelDatos.Location = new Point(0, 48);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(974, 533);
            panelDatos.TabIndex = 1;
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
            Font = new Font("Segoe UI", 9F);
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
        private KovaqsUI.Components.KToastNotifier notificador;
    }
}
