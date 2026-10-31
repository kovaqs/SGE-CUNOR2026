namespace Presentacion.Forms.SubForms
{
    partial class FrmExpedientesDatosPersonales
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
            txtCodigo = new KovaqsUI.Controls.KTextBox();
            txtDpi = new KovaqsUI.Controls.KTextBox();
            txtNombres = new KovaqsUI.Controls.KTextBox();
            txtApellidos = new KovaqsUI.Controls.KTextBox();
            txtTelefono = new KovaqsUI.Controls.KTextBox();
            txtCorreo = new KovaqsUI.Controls.KTextBox();
            txtDireccion = new KovaqsUI.Controls.KTextBox();
            dtpFechaNacimiento = new DateTimePicker();
            kLabel5 = new KovaqsUI.Controls.KLabel();
            picFotografia = new PictureBox();
            btnSeleccionarFoto = new KovaqsUI.Controls.KButton();
            btnQuitarFoto = new KovaqsUI.Controls.KButton();
            ((System.ComponentModel.ISupportInitialize)picFotografia).BeginInit();
            lblCodigo = new KovaqsUI.Controls.KLabel();
            lblCodigo.Text = "Código de colaborador";
            lblCodigo.Location = new Point(16, 16);
            lblCodigo.Size = new Size(278, 24);
            lblCodigo.Font = new Font("Inter", 9F);
            lblCodigo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblCodigo.ForeColor = Color.FromArgb(64, 64, 64);
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.AutoSize = false;
            lblCodigo.TextAlign = ContentAlignment.MiddleLeft;
            lblCodigo.TabStop = false;
            lblCodigo.TabIndex = 0;
            lblCodigo.Name = "lblCodigo";
            lblDpi = new KovaqsUI.Controls.KLabel();
            lblDpi.Text = "DPI";
            lblDpi.Location = new Point(312, 16);
            lblDpi.Size = new Size(278, 24);
            lblDpi.Font = new Font("Inter", 9F);
            lblDpi.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblDpi.ForeColor = Color.FromArgb(64, 64, 64);
            lblDpi.BackColor = Color.Transparent;
            lblDpi.AutoSize = false;
            lblDpi.TextAlign = ContentAlignment.MiddleLeft;
            lblDpi.TabStop = false;
            lblDpi.TabIndex = 1;
            lblDpi.Name = "lblDpi";
            lblNombres = new KovaqsUI.Controls.KLabel();
            lblNombres.Text = "Nombres";
            lblNombres.Location = new Point(16, 86);
            lblNombres.Size = new Size(278, 24);
            lblNombres.Font = new Font("Inter", 9F);
            lblNombres.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblNombres.ForeColor = Color.FromArgb(64, 64, 64);
            lblNombres.BackColor = Color.Transparent;
            lblNombres.AutoSize = false;
            lblNombres.TextAlign = ContentAlignment.MiddleLeft;
            lblNombres.TabStop = false;
            lblNombres.TabIndex = 6;
            lblNombres.Name = "lblNombres";
            lblApellidos = new KovaqsUI.Controls.KLabel();
            lblApellidos.Text = "Apellidos";
            lblApellidos.Location = new Point(312, 86);
            lblApellidos.Size = new Size(278, 24);
            lblApellidos.Font = new Font("Inter", 9F);
            lblApellidos.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblApellidos.ForeColor = Color.FromArgb(64, 64, 64);
            lblApellidos.BackColor = Color.Transparent;
            lblApellidos.AutoSize = false;
            lblApellidos.TextAlign = ContentAlignment.MiddleLeft;
            lblApellidos.TabStop = false;
            lblApellidos.TabIndex = 7;
            lblApellidos.Name = "lblApellidos";
            lblTelefono = new KovaqsUI.Controls.KLabel();
            lblTelefono.Text = "Teléfono";
            lblTelefono.Location = new Point(312, 156);
            lblTelefono.Size = new Size(278, 24);
            lblTelefono.Font = new Font("Inter", 9F);
            lblTelefono.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblTelefono.ForeColor = Color.FromArgb(64, 64, 64);
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.AutoSize = false;
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            lblTelefono.TabStop = false;
            lblTelefono.TabIndex = 11;
            lblTelefono.Name = "lblTelefono";
            lblCorreo = new KovaqsUI.Controls.KLabel();
            lblCorreo.Text = "Correo electrónico";
            lblCorreo.Location = new Point(16, 226);
            lblCorreo.Size = new Size(278, 24);
            lblCorreo.Font = new Font("Inter", 9F);
            lblCorreo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.AutoSize = false;
            lblCorreo.TextAlign = ContentAlignment.MiddleLeft;
            lblCorreo.TabStop = false;
            lblCorreo.TabIndex = 14;
            lblCorreo.Name = "lblCorreo";
            lblDireccion = new KovaqsUI.Controls.KLabel();
            lblDireccion.Text = "Dirección";
            lblDireccion.Location = new Point(312, 226);
            lblDireccion.Size = new Size(278, 24);
            lblDireccion.Font = new Font("Inter", 9F);
            lblDireccion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblDireccion.ForeColor = Color.FromArgb(64, 64, 64);
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.AutoSize = false;
            lblDireccion.TextAlign = ContentAlignment.MiddleLeft;
            lblDireccion.TabStop = false;
            lblDireccion.TabIndex = 15;
            lblDireccion.Name = "lblDireccion";
            lblFotografia = new KovaqsUI.Controls.KLabel();
            lblFotografia.Text = "Fotografía";
            lblFotografia.Location = new Point(608, 16);
            lblFotografia.Size = new Size(271, 24);
            lblFotografia.Font = new Font("Inter", 9F);
            lblFotografia.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblFotografia.ForeColor = Color.FromArgb(64, 64, 64);
            lblFotografia.BackColor = Color.Transparent;
            lblFotografia.AutoSize = false;
            lblFotografia.TextAlign = ContentAlignment.MiddleLeft;
            lblFotografia.TabStop = false;
            lblFotografia.TabIndex = 2;
            lblFotografia.Name = "lblFotografia";
            SuspendLayout();
            //
            // txtCodigo
            //
            txtCodigo.BackColor = Color.Transparent;
            txtCodigo.CornerRadius = 8;
            txtCodigo.Location = new Point(16, 42);
            txtCodigo.Font = new Font("Inter", 9F);
            txtCodigo.FillColor = Color.White;
            txtCodigo.ForeColor = Color.FromArgb(32, 38, 45);
            txtCodigo.BorderColor = Color.FromArgb(218, 218, 218);
            txtCodigo.GradientColor = Color.Empty;
            txtCodigo.BorderThickness = 1;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Padding = new Padding(12, 8, 12, 8);
            txtCodigo.PlaceholderText = "Código de colaborador";
            txtCodigo.Size = new Size(278, 34);
            txtCodigo.TabIndex = 3;
            //
            // txtDpi
            //
            txtDpi.BackColor = Color.Transparent;
            txtDpi.CornerRadius = 8;
            txtDpi.Location = new Point(312, 42);
            txtDpi.Font = new Font("Inter", 9F);
            txtDpi.FillColor = Color.White;
            txtDpi.ForeColor = Color.FromArgb(32, 38, 45);
            txtDpi.BorderColor = Color.FromArgb(218, 218, 218);
            txtDpi.GradientColor = Color.Empty;
            txtDpi.BorderThickness = 1;
            txtDpi.Name = "txtDpi";
            txtDpi.Padding = new Padding(12, 8, 12, 8);
            txtDpi.PlaceholderText = "DPI";
            txtDpi.Size = new Size(278, 34);
            txtDpi.TabIndex = 4;
            //
            // txtNombres
            //
            txtNombres.BackColor = Color.Transparent;
            txtNombres.CornerRadius = 8;
            txtNombres.Location = new Point(16, 112);
            txtNombres.Font = new Font("Inter", 9F);
            txtNombres.FillColor = Color.White;
            txtNombres.ForeColor = Color.FromArgb(32, 38, 45);
            txtNombres.BorderColor = Color.FromArgb(218, 218, 218);
            txtNombres.GradientColor = Color.Empty;
            txtNombres.BorderThickness = 1;
            txtNombres.Name = "txtNombres";
            txtNombres.Padding = new Padding(12, 8, 12, 8);
            txtNombres.PlaceholderText = "Nombres";
            txtNombres.Size = new Size(278, 34);
            txtNombres.TabIndex = 8;
            //
            // txtApellidos
            //
            txtApellidos.BackColor = Color.Transparent;
            txtApellidos.CornerRadius = 8;
            txtApellidos.Location = new Point(312, 112);
            txtApellidos.Font = new Font("Inter", 9F);
            txtApellidos.FillColor = Color.White;
            txtApellidos.ForeColor = Color.FromArgb(32, 38, 45);
            txtApellidos.BorderColor = Color.FromArgb(218, 218, 218);
            txtApellidos.GradientColor = Color.Empty;
            txtApellidos.BorderThickness = 1;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Padding = new Padding(12, 8, 12, 8);
            txtApellidos.PlaceholderText = "Apellidos";
            txtApellidos.Size = new Size(278, 34);
            txtApellidos.TabIndex = 9;
            //
            // txtTelefono
            //
            txtTelefono.BackColor = Color.Transparent;
            txtTelefono.CornerRadius = 8;
            txtTelefono.Location = new Point(312, 182);
            txtTelefono.Font = new Font("Inter", 9F);
            txtTelefono.FillColor = Color.White;
            txtTelefono.ForeColor = Color.FromArgb(32, 38, 45);
            txtTelefono.BorderColor = Color.FromArgb(218, 218, 218);
            txtTelefono.GradientColor = Color.Empty;
            txtTelefono.BorderThickness = 1;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(12, 8, 12, 8);
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(278, 34);
            txtTelefono.TabIndex = 13;
            //
            // txtCorreo
            //
            txtCorreo.BackColor = Color.Transparent;
            txtCorreo.CornerRadius = 8;
            txtCorreo.Location = new Point(16, 252);
            txtCorreo.Font = new Font("Inter", 9F);
            txtCorreo.FillColor = Color.White;
            txtCorreo.ForeColor = Color.FromArgb(32, 38, 45);
            txtCorreo.BorderColor = Color.FromArgb(218, 218, 218);
            txtCorreo.GradientColor = Color.Empty;
            txtCorreo.BorderThickness = 1;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(12, 8, 12, 8);
            txtCorreo.PlaceholderText = "Correo electrónico";
            txtCorreo.Size = new Size(278, 34);
            txtCorreo.TabIndex = 16;
            //
            // txtDireccion
            //
            txtDireccion.BackColor = Color.Transparent;
            txtDireccion.CornerRadius = 8;
            txtDireccion.Location = new Point(312, 252);
            txtDireccion.Multiline = true;
            txtDireccion.Font = new Font("Inter", 9F);
            txtDireccion.FillColor = Color.White;
            txtDireccion.ForeColor = Color.FromArgb(32, 38, 45);
            txtDireccion.BorderColor = Color.FromArgb(218, 218, 218);
            txtDireccion.GradientColor = Color.Empty;
            txtDireccion.BorderThickness = 1;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Padding = new Padding(12, 8, 12, 8);
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(278, 80);
            txtDireccion.TabIndex = 17;
            //
            // dtpFechaNacimiento
            //
            dtpFechaNacimiento.CalendarFont = new Font("Inter", 9F);
            dtpFechaNacimiento.Location = new Point(16, 182);
            dtpFechaNacimiento.Font = new Font("Inter", 10F);
            dtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.MinimumSize = new Size(0, 34);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(278, 34);
            dtpFechaNacimiento.TabIndex = 12;
            //
            // kLabel5
            //
            kLabel5.AutoSize = false;
            kLabel5.BackColor = Color.Transparent;
            kLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel5.Location = new Point(16, 156);
            kLabel5.Font = new Font("Inter", 9F);
            kLabel5.TabStop = false;
            kLabel5.Name = "kLabel5";
            kLabel5.Size = new Size(278, 24);
            kLabel5.TabIndex = 10;
            kLabel5.Text = "Fecha de nacimiento";
            kLabel5.TextAlign = ContentAlignment.MiddleLeft;
            kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // picFotografia
            //
            picFotografia.Location = new Point(608, 42);
            picFotografia.BorderStyle = BorderStyle.FixedSingle;
            picFotografia.SizeMode = PictureBoxSizeMode.Zoom;
            picFotografia.Name = "picFotografia";
            picFotografia.Size = new Size(271, 220);
            picFotografia.TabIndex = 5;
            picFotografia.TabStop = false;
            //
            // btnSeleccionarFoto
            //
            btnSeleccionarFoto.BackColor = Color.Transparent;
            btnSeleccionarFoto.CornerRadius = 8;
            btnSeleccionarFoto.FlatStyle = FlatStyle.Flat;
            btnSeleccionarFoto.Font = new Font("Inter", 9F);
            btnSeleccionarFoto.Location = new Point(608, 276);
            btnSeleccionarFoto.BorderThickness = 1;
            btnSeleccionarFoto.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            btnSeleccionarFoto.FillColor = Color.White;
            btnSeleccionarFoto.ForeColor = Color.FromArgb(32, 38, 45);
            btnSeleccionarFoto.BorderColor = Color.FromArgb(218, 218, 218);
            btnSeleccionarFoto.GradientColor = Color.Empty;
            btnSeleccionarFoto.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
            btnSeleccionarFoto.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
            btnSeleccionarFoto.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            btnSeleccionarFoto.Padding = new Padding(10, 4, 10, 4);
            btnSeleccionarFoto.Size = new Size(271, 40);
            btnSeleccionarFoto.TabIndex = 18;
            btnSeleccionarFoto.Text = "Seleccionar fotografía";
            btnSeleccionarFoto.UseVisualStyleBackColor = false;
            //
            // btnQuitarFoto
            //
            btnQuitarFoto.BackColor = Color.Transparent;
            btnQuitarFoto.CornerRadius = 8;
            btnQuitarFoto.FlatStyle = FlatStyle.Flat;
            btnQuitarFoto.Font = new Font("Inter", 9F);
            btnQuitarFoto.Location = new Point(608, 328);
            btnQuitarFoto.BorderThickness = 1;
            btnQuitarFoto.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            btnQuitarFoto.FillColor = Color.FromArgb(255, 248, 248);
            btnQuitarFoto.ForeColor = Color.FromArgb(166, 61, 64);
            btnQuitarFoto.BorderColor = Color.FromArgb(204, 148, 150);
            btnQuitarFoto.GradientColor = Color.Empty;
            btnQuitarFoto.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            btnQuitarFoto.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            btnQuitarFoto.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            btnQuitarFoto.Name = "btnQuitarFoto";
            btnQuitarFoto.Padding = new Padding(10, 4, 10, 4);
            btnQuitarFoto.Size = new Size(271, 40);
            btnQuitarFoto.TabIndex = 19;
            btnQuitarFoto.Text = "Quitar fotografía";
            btnQuitarFoto.UseVisualStyleBackColor = false;
            //
            // FrmExpedientesDatosPersonales
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 450);
            Controls.Add(btnQuitarFoto);
            Controls.Add(btnSeleccionarFoto);
            Controls.Add(picFotografia);
            Controls.Add(kLabel5);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(txtDpi);
            Controls.Add(txtCodigo);
            FormBorderStyle = FormBorderStyle.None;
            Font = new Font("Segoe UI", 9F);
            Controls.Add(lblCodigo);
            Controls.Add(lblDpi);
            Controls.Add(lblNombres);
            Controls.Add(lblApellidos);
            Controls.Add(lblTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblDireccion);
            Controls.Add(lblFotografia);
            Name = "FrmExpedientesDatosPersonales";
            Text = "FrmExpedientesDatosPersonales";
            ((System.ComponentModel.ISupportInitialize)picFotografia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KovaqsUI.Controls.KTextBox txtCodigo;
        private KovaqsUI.Controls.KTextBox txtDpi;
        private KovaqsUI.Controls.KTextBox txtNombres;
        private KovaqsUI.Controls.KTextBox txtApellidos;
        private KovaqsUI.Controls.KTextBox txtTelefono;
        private KovaqsUI.Controls.KTextBox txtCorreo;
        private KovaqsUI.Controls.KTextBox txtDireccion;
        private DateTimePicker dtpFechaNacimiento;
        private KovaqsUI.Controls.KLabel kLabel5;
        private PictureBox picFotografia;
        private KovaqsUI.Controls.KButton btnSeleccionarFoto;
        private KovaqsUI.Controls.KButton btnQuitarFoto;
            private KovaqsUI.Controls.KLabel lblCodigo;
        private KovaqsUI.Controls.KLabel lblDpi;
        private KovaqsUI.Controls.KLabel lblNombres;
        private KovaqsUI.Controls.KLabel lblApellidos;
        private KovaqsUI.Controls.KLabel lblTelefono;
        private KovaqsUI.Controls.KLabel lblCorreo;
        private KovaqsUI.Controls.KLabel lblDireccion;
        private KovaqsUI.Controls.KLabel lblFotografia;
        private KovaqsUI.Components.KToastNotifier notificador;
}
}
