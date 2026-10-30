namespace Presentacion.Forms.SubForms.Empleados;

partial class FrmCambioLaboral
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
        lblFechaInicio = new KovaqsUI.Controls.KLabel();
        dtpFechaInicio = new DateTimePicker();
        lblDepartamento = new KovaqsUI.Controls.KLabel();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        lblPuesto = new KovaqsUI.Controls.KLabel();
        cboPuesto = new KovaqsUI.Controls.KComboBox();
        lblTipoContrato = new KovaqsUI.Controls.KLabel();
        cboTipoContrato = new KovaqsUI.Controls.KComboBox();
        lblHorario = new KovaqsUI.Controls.KLabel();
        cboHorario = new KovaqsUI.Controls.KComboBox();
        lblSalario = new KovaqsUI.Controls.KLabel();
        numSalario = new KovaqsUI.Controls.KNumericUpDown();
        lblMotivo = new KovaqsUI.Controls.KLabel();
        txtMotivo = new KovaqsUI.Controls.KTextBox();
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
        lblTitulo.Text = "Cambio de condición laboral";
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
        // lblFechaInicio
        //
        lblFechaInicio.AutoSize = false;
        lblFechaInicio.BackColor = Color.Transparent;
        lblFechaInicio.ForeColor = Color.FromArgb(64, 64, 64);
        lblFechaInicio.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblFechaInicio.TextAlign = ContentAlignment.MiddleLeft;
        lblFechaInicio.Text = "Inicio de vigencia";
        lblFechaInicio.Location = new Point(460, 70);
        lblFechaInicio.Name = "lblFechaInicio";
        lblFechaInicio.Size = new Size(426, 24);
        lblFechaInicio.TabIndex = 4;
        lblFechaInicio.TabStop = false;
        //
        // dtpFechaInicio
        //
        dtpFechaInicio.Font = new Font("Inter", 10F);
        dtpFechaInicio.Format = DateTimePickerFormat.Custom;
        dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
        dtpFechaInicio.MinimumSize = new Size(0, 34);
        dtpFechaInicio.Location = new Point(460, 96);
        dtpFechaInicio.Name = "dtpFechaInicio";
        dtpFechaInicio.Size = new Size(426, 34);
        dtpFechaInicio.TabIndex = 5;
        //
        // lblDepartamento
        //
        lblDepartamento.AutoSize = false;
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
        lblDepartamento.Text = "Departamento";
        lblDepartamento.Location = new Point(16, 140);
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(426, 24);
        lblDepartamento.TabIndex = 6;
        lblDepartamento.TabStop = false;
        //
        // cboDepartamento
        //
        cboDepartamento.Font = new Font("Inter", 9F);
        cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.Location = new Point(16, 166);
        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(426, 34);
        cboDepartamento.TabIndex = 7;
        //
        // lblPuesto
        //
        lblPuesto.AutoSize = false;
        lblPuesto.BackColor = Color.Transparent;
        lblPuesto.ForeColor = Color.FromArgb(64, 64, 64);
        lblPuesto.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPuesto.TextAlign = ContentAlignment.MiddleLeft;
        lblPuesto.Text = "Puesto";
        lblPuesto.Location = new Point(460, 140);
        lblPuesto.Name = "lblPuesto";
        lblPuesto.Size = new Size(426, 24);
        lblPuesto.TabIndex = 8;
        lblPuesto.TabStop = false;
        //
        // cboPuesto
        //
        cboPuesto.Font = new Font("Inter", 9F);
        cboPuesto.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPuesto.FormattingEnabled = true;
        cboPuesto.Location = new Point(460, 166);
        cboPuesto.Name = "cboPuesto";
        cboPuesto.Size = new Size(426, 34);
        cboPuesto.TabIndex = 9;
        //
        // lblTipoContrato
        //
        lblTipoContrato.AutoSize = false;
        lblTipoContrato.BackColor = Color.Transparent;
        lblTipoContrato.ForeColor = Color.FromArgb(64, 64, 64);
        lblTipoContrato.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTipoContrato.TextAlign = ContentAlignment.MiddleLeft;
        lblTipoContrato.Text = "Tipo de contrato";
        lblTipoContrato.Location = new Point(16, 210);
        lblTipoContrato.Name = "lblTipoContrato";
        lblTipoContrato.Size = new Size(426, 24);
        lblTipoContrato.TabIndex = 10;
        lblTipoContrato.TabStop = false;
        //
        // cboTipoContrato
        //
        cboTipoContrato.Font = new Font("Inter", 9F);
        cboTipoContrato.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTipoContrato.FormattingEnabled = true;
        cboTipoContrato.Location = new Point(16, 236);
        cboTipoContrato.Name = "cboTipoContrato";
        cboTipoContrato.Size = new Size(426, 34);
        cboTipoContrato.TabIndex = 11;
        //
        // lblHorario
        //
        lblHorario.AutoSize = false;
        lblHorario.BackColor = Color.Transparent;
        lblHorario.ForeColor = Color.FromArgb(64, 64, 64);
        lblHorario.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblHorario.TextAlign = ContentAlignment.MiddleLeft;
        lblHorario.Text = "Horario";
        lblHorario.Location = new Point(460, 210);
        lblHorario.Name = "lblHorario";
        lblHorario.Size = new Size(426, 24);
        lblHorario.TabIndex = 12;
        lblHorario.TabStop = false;
        //
        // cboHorario
        //
        cboHorario.Font = new Font("Inter", 9F);
        cboHorario.DropDownStyle = ComboBoxStyle.DropDownList;
        cboHorario.FormattingEnabled = true;
        cboHorario.Location = new Point(460, 236);
        cboHorario.Name = "cboHorario";
        cboHorario.Size = new Size(426, 34);
        cboHorario.TabIndex = 13;
        //
        // lblSalario
        //
        lblSalario.AutoSize = false;
        lblSalario.BackColor = Color.Transparent;
        lblSalario.ForeColor = Color.FromArgb(64, 64, 64);
        lblSalario.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblSalario.TextAlign = ContentAlignment.MiddleLeft;
        lblSalario.Text = "Nuevo salario (Q)";
        lblSalario.Location = new Point(16, 280);
        lblSalario.Name = "lblSalario";
        lblSalario.Size = new Size(426, 24);
        lblSalario.TabIndex = 14;
        lblSalario.TabStop = false;
        //
        // numSalario
        //
        numSalario.Font = new Font("Inter", 9F);
        numSalario.Maximum = 99999999.99m;
        numSalario.DecimalPlaces = 2;
        numSalario.Location = new Point(16, 306);
        numSalario.Name = "numSalario";
        numSalario.Size = new Size(426, 34);
        numSalario.TabIndex = 15;
        //
        // lblMotivo
        //
        lblMotivo.AutoSize = false;
        lblMotivo.BackColor = Color.Transparent;
        lblMotivo.ForeColor = Color.FromArgb(64, 64, 64);
        lblMotivo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblMotivo.TextAlign = ContentAlignment.MiddleLeft;
        lblMotivo.Text = "Motivo del cambio";
        lblMotivo.Location = new Point(16, 350);
        lblMotivo.Name = "lblMotivo";
        lblMotivo.Size = new Size(870, 24);
        lblMotivo.TabIndex = 16;
        lblMotivo.TabStop = false;
        //
        // txtMotivo
        //
        txtMotivo.BackColor = Color.Transparent;
        txtMotivo.CornerRadius = 8;
        txtMotivo.Font = new Font("Inter", 9F);
        txtMotivo.Padding = new Padding(10, 6, 10, 6);
        txtMotivo.Multiline = true;
        txtMotivo.MaxLength = 500;
        txtMotivo.Location = new Point(16, 376);
        txtMotivo.Name = "txtMotivo";
        txtMotivo.Size = new Size(870, 80);
        txtMotivo.TabIndex = 17;
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
        btnGuardar.TabIndex = 18;
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
        btnCancelar.TabIndex = 19;
        notificador.OwnerForm = this;
        //
        // FrmCambioLaboral
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblEmpleado);
        Controls.Add(txtEmpleado);
        Controls.Add(lblFechaInicio);
        Controls.Add(dtpFechaInicio);
        Controls.Add(lblDepartamento);
        Controls.Add(cboDepartamento);
        Controls.Add(lblPuesto);
        Controls.Add(cboPuesto);
        Controls.Add(lblTipoContrato);
        Controls.Add(cboTipoContrato);
        Controls.Add(lblHorario);
        Controls.Add(cboHorario);
        Controls.Add(lblSalario);
        Controls.Add(numSalario);
        Controls.Add(lblMotivo);
        Controls.Add(txtMotivo);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancelar;
        Name = "FrmCambioLaboral";
        Text = "Cambio de condición laboral";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KTextBox txtEmpleado;
    private KovaqsUI.Controls.KLabel lblFechaInicio;
    private DateTimePicker dtpFechaInicio;
    private KovaqsUI.Controls.KLabel lblDepartamento;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KLabel lblPuesto;
    private KovaqsUI.Controls.KComboBox cboPuesto;
    private KovaqsUI.Controls.KLabel lblTipoContrato;
    private KovaqsUI.Controls.KComboBox cboTipoContrato;
    private KovaqsUI.Controls.KLabel lblHorario;
    private KovaqsUI.Controls.KComboBox cboHorario;
    private KovaqsUI.Controls.KLabel lblSalario;
    private KovaqsUI.Controls.KNumericUpDown numSalario;
    private KovaqsUI.Controls.KLabel lblMotivo;
    private KovaqsUI.Controls.KTextBox txtMotivo;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
