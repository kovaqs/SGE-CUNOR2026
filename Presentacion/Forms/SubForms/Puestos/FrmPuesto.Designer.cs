namespace Presentacion.Forms.SubForms.Puestos;

partial class FrmPuesto
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        btnCerrar = new KovaqsUI.Controls.KButton();
        lblDepartamento = new KovaqsUI.Controls.KLabel();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        lblNombre = new KovaqsUI.Controls.KLabel();
        txtNombre = new KovaqsUI.Controls.KTextBox();
        lblDescripcion = new KovaqsUI.Controls.KLabel();
        txtDescripcion = new KovaqsUI.Controls.KTextBox();
        chkActivo = new KovaqsUI.Controls.KCheckBox();
        btnGuardar = new KovaqsUI.Controls.KButton();
        btnCancelar = new KovaqsUI.Controls.KButton();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Text = "Crear o editar puesto";
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(740, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.TabStop = false;
        //
        // btnCerrar
        //
        btnCerrar.BackColor = Color.Transparent;
        btnCerrar.CornerRadius = 8;
        btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.Font = new Font("Inter", 9F);
        btnCerrar.Padding = new Padding(10, 4, 10, 4);
        btnCerrar.UseVisualStyleBackColor = false;
        btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCerrar.Text = "Cerrar";
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.Location = new Point(790, 12);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(96, 40);
        btnCerrar.TabIndex = 1;
        //
        // lblDepartamento
        //
        lblDepartamento.AutoSize = false;
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
        lblDepartamento.Text = "Departamento";
        lblDepartamento.Location = new Point(16, 70);
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(426, 24);
        lblDepartamento.TabIndex = 2;
        lblDepartamento.TabStop = false;
        //
        // cboDepartamento
        //
        cboDepartamento.Font = new Font("Inter", 9F);
        cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.Location = new Point(16, 96);
        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(426, 34);
        cboDepartamento.TabIndex = 3;
        //
        // lblNombre
        //
        lblNombre.AutoSize = false;
        lblNombre.BackColor = Color.Transparent;
        lblNombre.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombre.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNombre.TextAlign = ContentAlignment.MiddleLeft;
        lblNombre.Text = "Nombre del puesto";
        lblNombre.Location = new Point(460, 70);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(426, 24);
        lblNombre.TabIndex = 4;
        lblNombre.TabStop = false;
        //
        // txtNombre
        //
        txtNombre.BackColor = Color.Transparent;
        txtNombre.CornerRadius = 8;
        txtNombre.Font = new Font("Inter", 9F);
        txtNombre.Padding = new Padding(10, 6, 10, 6);
        txtNombre.MaxLength = 100;
        txtNombre.Location = new Point(460, 96);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(426, 34);
        txtNombre.TabIndex = 5;
        //
        // lblDescripcion
        //
        lblDescripcion.AutoSize = false;
        lblDescripcion.BackColor = Color.Transparent;
        lblDescripcion.ForeColor = Color.FromArgb(64, 64, 64);
        lblDescripcion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
        lblDescripcion.Text = "Descripción";
        lblDescripcion.Location = new Point(16, 140);
        lblDescripcion.Name = "lblDescripcion";
        lblDescripcion.Size = new Size(870, 24);
        lblDescripcion.TabIndex = 6;
        lblDescripcion.TabStop = false;
        //
        // txtDescripcion
        //
        txtDescripcion.BackColor = Color.Transparent;
        txtDescripcion.CornerRadius = 8;
        txtDescripcion.Font = new Font("Inter", 9F);
        txtDescripcion.Padding = new Padding(10, 6, 10, 6);
        txtDescripcion.Multiline = true;
        txtDescripcion.MaxLength = 500;
        txtDescripcion.Location = new Point(16, 166);
        txtDescripcion.Name = "txtDescripcion";
        txtDescripcion.Size = new Size(870, 80);
        txtDescripcion.TabIndex = 7;
        //
        // chkActivo
        //
        chkActivo.Font = new Font("Inter", 9F);
        chkActivo.Text = "Puesto activo";
        chkActivo.Checked = true;
        chkActivo.Location = new Point(16, 284);
        chkActivo.Name = "chkActivo";
        chkActivo.Size = new Size(426, 36);
        chkActivo.TabIndex = 8;
        //
        // btnGuardar
        //
        btnGuardar.BackColor = Color.Transparent;
        btnGuardar.CornerRadius = 8;
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.Font = new Font("Inter", 9F);
        btnGuardar.Padding = new Padding(10, 4, 10, 4);
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        btnGuardar.Text = "Guardar";
        btnGuardar.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardar.Appearance.Normal.ForeColor = Color.White;
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnGuardar.Location = new Point(586, 613);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(144, 40);
        btnGuardar.TabIndex = 9;
        //
        // btnCancelar
        //
        btnCancelar.BackColor = Color.Transparent;
        btnCancelar.CornerRadius = 8;
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.Font = new Font("Inter", 9F);
        btnCancelar.Padding = new Padding(10, 4, 10, 4);
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCancelar.Text = "Cancelar";
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.Location = new Point(742, 613);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(144, 40);
        btnCancelar.TabIndex = 10;
        notificador.OwnerForm = this;
        //
        // FrmPuesto
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblDepartamento);
        Controls.Add(cboDepartamento);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(lblDescripcion);
        Controls.Add(txtDescripcion);
        Controls.Add(chkActivo);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancelar;
        Name = "FrmPuesto";
        Text = "Crear o editar puesto";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblDepartamento;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KLabel lblNombre;
    private KovaqsUI.Controls.KTextBox txtNombre;
    private KovaqsUI.Controls.KLabel lblDescripcion;
    private KovaqsUI.Controls.KTextBox txtDescripcion;
    private KovaqsUI.Controls.KCheckBox chkActivo;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
