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
            lblEstado = new KovaqsUI.Controls.KLabel();
            txtNombre = new KovaqsUI.Controls.KTextBox();
            txtDescripcion = new KovaqsUI.Controls.KTextBox();
            chkActivo = new KovaqsUI.Controls.KCheckBox();
            btnGuardar = new KovaqsUI.Controls.KButton();
            btnCerrar = new KovaqsUI.Controls.KButton();
            btnCancelar = new KovaqsUI.Controls.KButton();
            SuspendLayout();
            // 
            // lblTitulofrm
            // 
            lblTitulofrm.BackColor = Color.Transparent;
            lblTitulofrm.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulofrm.Location = new Point(15, 37);
            lblTitulofrm.Name = "lblTitulofrm";
            lblTitulofrm.Size = new Size(392, 38);
            lblTitulofrm.TabIndex = 0;
            lblTitulofrm.Text = "\tCrear o editar departamento";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(15, 131);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(288, 31);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Nombre del departamento";
            // 
            // lblDescripcion
            // 
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(547, 131);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(134, 31);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción";
            // 
            // lblEstado
            // 
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(49, 491);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 28);
            lblEstado.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Transparent;
            txtNombre.Location = new Point(15, 179);
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(12, 8, 12, 8);
            txtNombre.Size = new Size(433, 50);
            txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.Transparent;
            txtDescripcion.Location = new Point(547, 179);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Padding = new Padding(12, 8, 12, 8);
            txtDescripcion.Size = new Size(433, 102);
            txtDescripcion.TabIndex = 5;
            // 
            // chkActivo
            // 
            chkActivo.BackColor = Color.Transparent;
            chkActivo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkActivo.Location = new Point(49, 356);
            chkActivo.Name = "chkActivo";
            chkActivo.Padding = new Padding(2);
            chkActivo.Size = new Size(314, 65);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "Departamento activo";
            chkActivo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(590, 505);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(12, 4, 12, 4);
            btnGuardar.Size = new Size(155, 65);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(819, 37);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(12, 4, 12, 4);
            btnCerrar.Size = new Size(161, 44);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(803, 505);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(12, 4, 12, 4);
            btnCancelar.Size = new Size(175, 65);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // FrmDepartamento
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 607);
            Controls.Add(btnCancelar);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(chkActivo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblEstado);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Controls.Add(lblTitulofrm);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
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
        private KovaqsUI.Controls.KLabel lblEstado;
        private KovaqsUI.Controls.KTextBox txtNombre;
        private KovaqsUI.Controls.KTextBox txtDescripcion;
        private KovaqsUI.Controls.KCheckBox chkActivo;
        private KovaqsUI.Controls.KButton btnGuardar;
        private KovaqsUI.Controls.KButton btnCerrar;
        private KovaqsUI.Controls.KButton btnCancelar;
    }
}