namespace Presentacion.Forms.SubForms.Asistencias;

partial class FrmResolverPermiso
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
        lblEmpleado = new KovaqsUI.Controls.KLabel();
        txtEmpleado = new KovaqsUI.Controls.KTextBox();
        lblPeriodo = new KovaqsUI.Controls.KLabel();
        txtPeriodo = new KovaqsUI.Controls.KTextBox();
        lblMotivo = new KovaqsUI.Controls.KLabel();
        txtMotivo = new KovaqsUI.Controls.KTextBox();
        lblResolucion = new KovaqsUI.Controls.KLabel();
        cboResolucion = new KovaqsUI.Controls.KComboBox();
        lblObservaciones = new KovaqsUI.Controls.KLabel();
        txtObservaciones = new KovaqsUI.Controls.KTextBox();
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
        lblTitulo.Text = "Resolver permiso laboral";
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
        // lblEmpleado
        //
        lblEmpleado.AutoSize = false;
        lblEmpleado.BackColor = Color.Transparent;
        lblEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEmpleado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEmpleado.TextAlign = ContentAlignment.MiddleLeft;
        lblEmpleado.Text = "Empleado";
        lblEmpleado.Location = new Point(16, 70);
        lblEmpleado.Name = "lblEmpleado";
        lblEmpleado.Size = new Size(426, 24);
        lblEmpleado.TabIndex = 2;
        lblEmpleado.TabStop = false;
        //
        // txtEmpleado
        //
        txtEmpleado.BackColor = Color.Transparent;
        txtEmpleado.CornerRadius = 8;
        txtEmpleado.Font = new Font("Inter", 9F);
        txtEmpleado.Padding = new Padding(10, 6, 10, 6);
        txtEmpleado.ReadOnly = true;
        txtEmpleado.MaxLength = 100;
        txtEmpleado.Location = new Point(16, 96);
        txtEmpleado.Name = "txtEmpleado";
        txtEmpleado.Size = new Size(426, 34);
        txtEmpleado.TabIndex = 3;
        //
        // lblPeriodo
        //
        lblPeriodo.AutoSize = false;
        lblPeriodo.BackColor = Color.Transparent;
        lblPeriodo.ForeColor = Color.FromArgb(64, 64, 64);
        lblPeriodo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPeriodo.TextAlign = ContentAlignment.MiddleLeft;
        lblPeriodo.Text = "Período solicitado";
        lblPeriodo.Location = new Point(460, 70);
        lblPeriodo.Name = "lblPeriodo";
        lblPeriodo.Size = new Size(426, 24);
        lblPeriodo.TabIndex = 4;
        lblPeriodo.TabStop = false;
        //
        // txtPeriodo
        //
        txtPeriodo.BackColor = Color.Transparent;
        txtPeriodo.CornerRadius = 8;
        txtPeriodo.Font = new Font("Inter", 9F);
        txtPeriodo.Padding = new Padding(10, 6, 10, 6);
        txtPeriodo.ReadOnly = true;
        txtPeriodo.MaxLength = 100;
        txtPeriodo.Location = new Point(460, 96);
        txtPeriodo.Name = "txtPeriodo";
        txtPeriodo.Size = new Size(426, 34);
        txtPeriodo.TabIndex = 5;
        //
        // lblMotivo
        //
        lblMotivo.AutoSize = false;
        lblMotivo.BackColor = Color.Transparent;
        lblMotivo.ForeColor = Color.FromArgb(64, 64, 64);
        lblMotivo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblMotivo.TextAlign = ContentAlignment.MiddleLeft;
        lblMotivo.Text = "Motivo de la solicitud";
        lblMotivo.Location = new Point(16, 140);
        lblMotivo.Name = "lblMotivo";
        lblMotivo.Size = new Size(870, 24);
        lblMotivo.TabIndex = 6;
        lblMotivo.TabStop = false;
        //
        // txtMotivo
        //
        txtMotivo.BackColor = Color.Transparent;
        txtMotivo.CornerRadius = 8;
        txtMotivo.Font = new Font("Inter", 9F);
        txtMotivo.Padding = new Padding(10, 6, 10, 6);
        txtMotivo.Multiline = true;
        txtMotivo.ReadOnly = true;
        txtMotivo.MaxLength = 500;
        txtMotivo.Location = new Point(16, 166);
        txtMotivo.Name = "txtMotivo";
        txtMotivo.Size = new Size(870, 80);
        txtMotivo.TabIndex = 7;
        //
        // lblResolucion
        //
        lblResolucion.AutoSize = false;
        lblResolucion.BackColor = Color.Transparent;
        lblResolucion.ForeColor = Color.FromArgb(64, 64, 64);
        lblResolucion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblResolucion.TextAlign = ContentAlignment.MiddleLeft;
        lblResolucion.Text = "Resolución";
        lblResolucion.Location = new Point(16, 260);
        lblResolucion.Name = "lblResolucion";
        lblResolucion.Size = new Size(426, 24);
        lblResolucion.TabIndex = 8;
        lblResolucion.TabStop = false;
        //
        // cboResolucion
        //
        cboResolucion.Font = new Font("Inter", 9F);
        cboResolucion.DropDownStyle = ComboBoxStyle.DropDownList;
        cboResolucion.FormattingEnabled = true;
        cboResolucion.Items.AddRange(new object[] { "Aprobado", "Rechazado" });
        cboResolucion.Location = new Point(16, 286);
        cboResolucion.Name = "cboResolucion";
        cboResolucion.Size = new Size(426, 34);
        cboResolucion.TabIndex = 9;
        //
        // lblObservaciones
        //
        lblObservaciones.AutoSize = false;
        lblObservaciones.BackColor = Color.Transparent;
        lblObservaciones.ForeColor = Color.FromArgb(64, 64, 64);
        lblObservaciones.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblObservaciones.TextAlign = ContentAlignment.MiddleLeft;
        lblObservaciones.Text = "Observaciones de resolución";
        lblObservaciones.Location = new Point(16, 330);
        lblObservaciones.Name = "lblObservaciones";
        lblObservaciones.Size = new Size(870, 24);
        lblObservaciones.TabIndex = 10;
        lblObservaciones.TabStop = false;
        //
        // txtObservaciones
        //
        txtObservaciones.BackColor = Color.Transparent;
        txtObservaciones.CornerRadius = 8;
        txtObservaciones.Font = new Font("Inter", 9F);
        txtObservaciones.Padding = new Padding(10, 6, 10, 6);
        txtObservaciones.Multiline = true;
        txtObservaciones.MaxLength = 500;
        txtObservaciones.Location = new Point(16, 356);
        txtObservaciones.Name = "txtObservaciones";
        txtObservaciones.Size = new Size(870, 80);
        txtObservaciones.TabIndex = 11;
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
        btnGuardar.Text = "Resolver";
        btnGuardar.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardar.Appearance.Normal.ForeColor = Color.White;
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnGuardar.Location = new Point(586, 613);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(144, 40);
        btnGuardar.TabIndex = 12;
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
        btnCancelar.TabIndex = 13;
        notificador.OwnerForm = this;
        //
        // FrmResolverPermiso
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblEmpleado);
        Controls.Add(txtEmpleado);
        Controls.Add(lblPeriodo);
        Controls.Add(txtPeriodo);
        Controls.Add(lblMotivo);
        Controls.Add(txtMotivo);
        Controls.Add(lblResolucion);
        Controls.Add(cboResolucion);
        Controls.Add(lblObservaciones);
        Controls.Add(txtObservaciones);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancelar;
        Name = "FrmResolverPermiso";
        Text = "Resolver permiso laboral";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KTextBox txtEmpleado;
    private KovaqsUI.Controls.KLabel lblPeriodo;
    private KovaqsUI.Controls.KTextBox txtPeriodo;
    private KovaqsUI.Controls.KLabel lblMotivo;
    private KovaqsUI.Controls.KTextBox txtMotivo;
    private KovaqsUI.Controls.KLabel lblResolucion;
    private KovaqsUI.Controls.KComboBox cboResolucion;
    private KovaqsUI.Controls.KLabel lblObservaciones;
    private KovaqsUI.Controls.KTextBox txtObservaciones;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
