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
            panelCabecera = new Panel();
            lblTitulo = new KovaqsUI.Controls.KLabel();
            btnCerrar = new KovaqsUI.Controls.KButton();
            panelContenido = new Panel();
            segSecciones = new KovaqsUI.Controls.KSegmentedControl();
            itemDatosPersonales = new KovaqsUI.Controls.KSegmentItem();
            itemDatosLaborales = new KovaqsUI.Controls.KSegmentItem();
            itemDatosBancarios = new KovaqsUI.Controls.KSegmentItem();
            panelAcciones = new Panel();
            btnCancelar = new KovaqsUI.Controls.KButton();
            btnGuardar = new KovaqsUI.Controls.KButton();
            panelDatos = new Panel();
            panelCabecera.SuspendLayout();
            panelContenido.SuspendLayout();
            panelAcciones.SuspendLayout();
            SuspendLayout();
            //
            // panelCabecera
            //
            panelCabecera.BackColor = Color.White;
            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(btnCerrar);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Location = new Point(1, 1);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(974, 64);
            panelCabecera.TabIndex = 0;
            //
            // lblTitulo
            //
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.AutoSize = false;
            lblTitulo.TabStop = false;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(740, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Expediente del empleado";
            lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
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
            // panelContenido
            //
            panelContenido.BackColor = Color.White;
            panelContenido.Controls.Add(panelDatos);
            panelContenido.Controls.Add(panelAcciones);
            panelContenido.Controls.Add(segSecciones);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(1, 38);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(974, 654);
            panelContenido.TabIndex = 1;
            //
            // segSecciones
            //
            segSecciones.BackColor = Color.White;
            segSecciones.Dock = DockStyle.Top;
            segSecciones.FillColor = Color.White;
            segSecciones.Items.AddRange(new KovaqsUI.Controls.KSegmentItem[] { itemDatosPersonales, itemDatosLaborales, itemDatosBancarios });
            segSecciones.Location = new Point(0, 0);
            segSecciones.Font = new Font("Inter", 9F);
            segSecciones.Name = "segSecciones";
            segSecciones.SelectedAppearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
            segSecciones.SelectedAppearance.Normal.ForeColor = Color.WhiteSmoke;
            segSecciones.SelectedFillColor = Color.FromArgb(49, 81, 107);
            segSecciones.SelectedForeColor = Color.White;
            segSecciones.SelectedIndex = 0;
            segSecciones.Size = new Size(974, 48);
            segSecciones.Surface.FillColor = Color.White;
            segSecciones.TabIndex = 0;
            segSecciones.Text = "segSecciones";
            //
            // itemDatosPersonales
            //
            itemDatosPersonales.Text = "Datos personales";
            //
            // itemDatosLaborales
            //
            itemDatosLaborales.Text = "Datos laborales";
            //
            // itemDatosBancarios
            //
            itemDatosBancarios.Text = "Datos bancarios";
            //
            //
            //
            // panelAcciones
            //
            panelAcciones.Controls.Add(btnCancelar);
            panelAcciones.Controls.Add(btnGuardar);
            panelAcciones.Dock = DockStyle.Bottom;
            panelAcciones.Location = new Point(0, 581);
            panelAcciones.Name = "panelAcciones";
            panelAcciones.Size = new Size(974, 72);
            panelAcciones.TabIndex = 2;
            panelAcciones.Paint += panelAcciones_Paint;
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
            Controls.Add(panelContenido);
            Controls.Add(panelCabecera);
            FormBorderStyle = FormBorderStyle.None;
            Font = new Font("Segoe UI", 9F);
            Icon = Properties.Resources.sgeicon;
            Name = "FrmExpedientes";
            Padding = new Padding(1);
            Text = "FrmExpedientes";
            panelCabecera.ResumeLayout(false);
            panelCabecera.PerformLayout();
            panelContenido.ResumeLayout(false);
            panelAcciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCabecera;
        private KovaqsUI.Controls.KLabel lblTitulo;
        private KovaqsUI.Controls.KButton btnCerrar;
        private Panel panelContenido;
        private KovaqsUI.Controls.KSegmentedControl segSecciones;
        private KovaqsUI.Controls.KSegmentItem itemDatosPersonales;
        private KovaqsUI.Controls.KSegmentItem itemDatosLaborales;
        private KovaqsUI.Controls.KSegmentItem itemDatosBancarios;
        private Panel panelAcciones;
        private Panel panelDatos;
        private KovaqsUI.Controls.KButton btnCancelar;
        private KovaqsUI.Controls.KButton btnGuardar;
        private KovaqsUI.Components.KToastNotifier notificador;
    }
}
