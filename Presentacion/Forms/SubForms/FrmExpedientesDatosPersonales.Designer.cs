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
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.Transparent;
            txtCodigo.CornerRadius = 8;
            txtCodigo.Location = new Point(40, 21);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Padding = new Padding(12, 8, 12, 8);
            txtCodigo.PlaceholderText = "Código de colaborador";
            txtCodigo.Size = new Size(260, 33);
            txtCodigo.TabIndex = 0;
            // 
            // txtDpi
            // 
            txtDpi.BackColor = Color.Transparent;
            txtDpi.CornerRadius = 8;
            txtDpi.Location = new Point(315, 21);
            txtDpi.Name = "txtDpi";
            txtDpi.Padding = new Padding(12, 8, 12, 8);
            txtDpi.PlaceholderText = "DPI";
            txtDpi.Size = new Size(260, 33);
            txtDpi.TabIndex = 1;
            // 
            // txtNombres
            // 
            txtNombres.BackColor = Color.Transparent;
            txtNombres.CornerRadius = 8;
            txtNombres.Location = new Point(40, 82);
            txtNombres.Name = "txtNombres";
            txtNombres.Padding = new Padding(12, 8, 12, 8);
            txtNombres.PlaceholderText = "Nombres";
            txtNombres.Size = new Size(260, 33);
            txtNombres.TabIndex = 2;
            // 
            // txtApellidos
            // 
            txtApellidos.BackColor = Color.Transparent;
            txtApellidos.CornerRadius = 8;
            txtApellidos.Location = new Point(315, 82);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Padding = new Padding(12, 8, 12, 8);
            txtApellidos.PlaceholderText = "Apellidos";
            txtApellidos.Size = new Size(260, 33);
            txtApellidos.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Transparent;
            txtTelefono.CornerRadius = 8;
            txtTelefono.Location = new Point(315, 145);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Padding = new Padding(12, 8, 12, 8);
            txtTelefono.PlaceholderText = "Teléfono";
            txtTelefono.Size = new Size(260, 33);
            txtTelefono.TabIndex = 4;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.Transparent;
            txtCorreo.CornerRadius = 8;
            txtCorreo.Location = new Point(40, 209);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Padding = new Padding(12, 8, 12, 8);
            txtCorreo.PlaceholderText = "Correo electrónico";
            txtCorreo.Size = new Size(260, 33);
            txtCorreo.TabIndex = 23;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.Transparent;
            txtDireccion.CornerRadius = 8;
            txtDireccion.Location = new Point(315, 209);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Padding = new Padding(12, 8, 12, 8);
            txtDireccion.PlaceholderText = "Dirección";
            txtDireccion.Size = new Size(260, 86);
            txtDireccion.TabIndex = 24;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaNacimiento.Location = new Point(40, 155);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(260, 23);
            dtpFechaNacimiento.TabIndex = 25;
            // 
            // kLabel5
            // 
            kLabel5.AutoSize = false;
            kLabel5.BackColor = Color.Transparent;
            kLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel5.Location = new Point(40, 129);
            kLabel5.Name = "kLabel5";
            kLabel5.Size = new Size(244, 23);
            kLabel5.TabIndex = 30;
            kLabel5.Text = "Fecha de nacimiento\r\n";
            kLabel5.TextAlign = ContentAlignment.MiddleLeft;
            kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // picFotografia
            // 
            picFotografia.Location = new Point(626, 21);
            picFotografia.Name = "picFotografia";
            picFotografia.Size = new Size(219, 204);
            picFotografia.TabIndex = 31;
            picFotografia.TabStop = false;
            // 
            // btnSeleccionarFoto
            // 
            btnSeleccionarFoto.BackColor = Color.Transparent;
            btnSeleccionarFoto.CornerRadius = 8;
            btnSeleccionarFoto.FlatStyle = FlatStyle.Flat;
            btnSeleccionarFoto.Font = new Font("Inter", 9F);
            btnSeleccionarFoto.Location = new Point(626, 231);
            btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            btnSeleccionarFoto.Padding = new Padding(12, 4, 12, 4);
            btnSeleccionarFoto.Size = new Size(219, 29);
            btnSeleccionarFoto.TabIndex = 32;
            btnSeleccionarFoto.Text = "Seleccionar Fotografia";
            btnSeleccionarFoto.UseVisualStyleBackColor = false;
            btnSeleccionarFoto.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // btnQuitarFoto
            // 
            btnQuitarFoto.BackColor = Color.Transparent;
            btnQuitarFoto.CornerRadius = 8;
            btnQuitarFoto.FlatStyle = FlatStyle.Flat;
            btnQuitarFoto.Font = new Font("Inter", 9F);
            btnQuitarFoto.Location = new Point(626, 266);
            btnQuitarFoto.Name = "btnQuitarFoto";
            btnQuitarFoto.Padding = new Padding(12, 4, 12, 4);
            btnQuitarFoto.Size = new Size(219, 29);
            btnQuitarFoto.TabIndex = 33;
            btnQuitarFoto.Text = "Quitar fotografía";
            btnQuitarFoto.UseVisualStyleBackColor = false;
            btnQuitarFoto.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
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
    }
}