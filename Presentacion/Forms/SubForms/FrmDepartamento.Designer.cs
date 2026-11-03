namespace Presentacion.Forms.SubForms
{
    partial class FrmDepartamento
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
            lblTitulofrm = new KovaqsUI.Controls.KLabel();
            lblTitulo = new KovaqsUI.Controls.KLabel();
            lblDescripcion = new KovaqsUI.Controls.KLabel();
            txtNombre = new KovaqsUI.Controls.KTextBox();
            txtDescripcion = new KovaqsUI.Controls.KTextBox();
            chkActivo = new KovaqsUI.Controls.KCheckBox();
            btnGuardar = new KovaqsUI.Controls.KButton();
            btnCerrar = new KovaqsUI.Controls.KButton();
            btnCancelar = new KovaqsUI.Controls.KButton();
            components = new System.ComponentModel.Container();
            notificador = new KovaqsUI.Components.KToastNotifier(components);
            notificador.OwnerForm = this;
            SuspendLayout();
            //
            // lblTitulofrm
            //
            lblTitulofrm.BackColor = Color.Transparent;
            lblTitulofrm.Font = new Font("Inter", 16F, FontStyle.Bold);
            lblTitulofrm.Location = new Point(16, 12);
            lblTitulofrm.ForeColor = Color.FromArgb(32, 38, 45);
            lblTitulofrm.AutoSize = false;
            lblTitulofrm.TextRole = KovaqsUI.Controls.KTextRole.Title;
            lblTitulofrm.TabStop = false;
            lblTitulofrm.Name = "lblTitulofrm";
            lblTitulofrm.Size = new Size(740, 40);
            lblTitulofrm.TabIndex = 0;
            lblTitulofrm.Text = "Crear o editar departamento";
            //
            // lblTitulo
            //
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Inter", 9F);
            lblTitulo.Location = new Point(16, 70);
            lblTitulo.ForeColor = Color.FromArgb(64, 64, 64);
            lblTitulo.AutoSize = false;
            lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblTitulo.TabStop = false;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(870, 24);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Nombre del departamento";
            //
            // lblDescripcion
            //
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Inter", 9F);
            lblDescripcion.Location = new Point(16, 140);
            lblDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
            lblDescripcion.AutoSize = false;
            lblDescripcion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblDescripcion.TabStop = false;
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(870, 24);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            //
            // txtNombre
            //
            txtNombre.BackColor = Color.Transparent;
            txtNombre.Location = new Point(16, 96);
            txtNombre.Font = new Font("Inter", 9F);
            txtNombre.CornerRadius = 8;
            txtNombre.FillColor = Color.White;
            txtNombre.ForeColor = Color.FromArgb(32, 38, 45);
            txtNombre.BorderColor = Color.FromArgb(218, 218, 218);
            txtNombre.GradientColor = Color.Empty;
            txtNombre.BorderThickness = 1;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(12, 8, 12, 8);
            txtNombre.Size = new Size(870, 34);
            txtNombre.TabIndex = 3;
            //
            // txtDescripcion
            //
            txtDescripcion.BackColor = Color.Transparent;
            txtDescripcion.Location = new Point(16, 166);
            txtDescripcion.Multiline = true;
            txtDescripcion.Font = new Font("Inter", 9F);
            txtDescripcion.CornerRadius = 8;
            txtDescripcion.FillColor = Color.White;
            txtDescripcion.ForeColor = Color.FromArgb(32, 38, 45);
            txtDescripcion.BorderColor = Color.FromArgb(218, 218, 218);
            txtDescripcion.GradientColor = Color.Empty;
            txtDescripcion.BorderThickness = 1;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Padding = new Padding(12, 8, 12, 8);
            txtDescripcion.Size = new Size(870, 112);
            txtDescripcion.TabIndex = 5;
            //
            // chkActivo
            //
            chkActivo.BackColor = Color.Transparent;
            chkActivo.Font = new Font("Inter", 9F);
            chkActivo.Location = new Point(16, 296);
            chkActivo.ForeColor = Color.FromArgb(64, 64, 64);
            chkActivo.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
            chkActivo.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
            chkActivo.CheckedState.ForeColor = Color.White;
            chkActivo.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            chkActivo.Name = "chkActivo";
            chkActivo.Padding = new Padding(2);
            chkActivo.Size = new Size(426, 36);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "Departamento activo";
            chkActivo.UseVisualStyleBackColor = false;
            //
            // btnGuardar
            //
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Inter", 9F);
            btnGuardar.Location = new Point(586, 393);
            btnGuardar.CornerRadius = 8;
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
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            //
            // btnCerrar
            //
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Inter", 9F);
            btnCerrar.Location = new Point(790, 12);
            btnCerrar.CornerRadius = 8;
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
            // btnCancelar
            //
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Inter", 9F);
            btnCancelar.Location = new Point(742, 393);
            btnCancelar.CornerRadius = 8;
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
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            //
            // FrmDepartamento
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 449);
            Controls.Add(btnCancelar);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(chkActivo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Controls.Add(lblTitulofrm);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            BackColor = Color.White;
            Icon = Properties.Resources.sgeicon;
            Name = "FrmDepartamento";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Crear o editar departamento";
            Load += FrmDepartamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private KovaqsUI.Controls.KLabel lblTitulofrm;
        private KovaqsUI.Controls.KLabel lblTitulo;
        private KovaqsUI.Controls.KLabel lblDescripcion;
        private KovaqsUI.Controls.KTextBox txtNombre;
        private KovaqsUI.Controls.KTextBox txtDescripcion;
        private KovaqsUI.Controls.KCheckBox chkActivo;
        private KovaqsUI.Controls.KButton btnGuardar;
        private KovaqsUI.Controls.KButton btnCerrar;
        private KovaqsUI.Controls.KButton btnCancelar;
            private KovaqsUI.Components.KToastNotifier notificador;
}
}
