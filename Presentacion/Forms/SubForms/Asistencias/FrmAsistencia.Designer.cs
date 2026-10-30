namespace Presentacion.Forms.SubForms.Asistencias;

partial class FrmAsistencia
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
        cboEmpleado = new KovaqsUI.Controls.KComboBox();
        lblFecha = new KovaqsUI.Controls.KLabel();
        dtpFecha = new DateTimePicker();
        chkEsLaborable = new KovaqsUI.Controls.KCheckBox();
        lblTolerancia = new KovaqsUI.Controls.KLabel();
        numTolerancia = new KovaqsUI.Controls.KNumericUpDown();
        lblEntradaPrevista = new KovaqsUI.Controls.KLabel();
        dtpEntradaPrevista = new DateTimePicker();
        lblSalidaPrevista = new KovaqsUI.Controls.KLabel();
        dtpSalidaPrevista = new DateTimePicker();
        lblEntrada = new KovaqsUI.Controls.KLabel();
        dtpEntrada = new DateTimePicker();
        lblSalida = new KovaqsUI.Controls.KLabel();
        dtpSalida = new DateTimePicker();
        lblEstadoFiltro = new KovaqsUI.Controls.KLabel();
        cboEstado = new KovaqsUI.Controls.KComboBox();
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
        lblTitulo.Text = "Registrar o corregir asistencia";
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
        // cboEmpleado
        //
        cboEmpleado.Font = new Font("Inter", 9F);
        cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEmpleado.FormattingEnabled = true;
        cboEmpleado.Location = new Point(16, 96);
        cboEmpleado.Name = "cboEmpleado";
        cboEmpleado.Size = new Size(426, 34);
        cboEmpleado.TabIndex = 3;
        //
        // lblFecha
        //
        lblFecha.AutoSize = false;
        lblFecha.BackColor = Color.Transparent;
        lblFecha.ForeColor = Color.FromArgb(64, 64, 64);
        lblFecha.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblFecha.TextAlign = ContentAlignment.MiddleLeft;
        lblFecha.Text = "Día de asistencia";
        lblFecha.Location = new Point(460, 70);
        lblFecha.Name = "lblFecha";
        lblFecha.Size = new Size(426, 24);
        lblFecha.TabIndex = 4;
        lblFecha.TabStop = false;
        //
        // dtpFecha
        //
        dtpFecha.Font = new Font("Inter", 10F);
        dtpFecha.Format = DateTimePickerFormat.Custom;
        dtpFecha.CustomFormat = "dd/MM/yyyy";
        dtpFecha.MinimumSize = new Size(0, 34);
        dtpFecha.Location = new Point(460, 96);
        dtpFecha.Name = "dtpFecha";
        dtpFecha.Size = new Size(426, 34);
        dtpFecha.TabIndex = 5;
        //
        // chkEsLaborable
        //
        chkEsLaborable.Font = new Font("Inter", 9F);
        chkEsLaborable.Text = "Día laborable";
        chkEsLaborable.Checked = true;
        chkEsLaborable.Location = new Point(16, 164);
        chkEsLaborable.Name = "chkEsLaborable";
        chkEsLaborable.Size = new Size(426, 36);
        chkEsLaborable.TabIndex = 6;
        //
        // lblTolerancia
        //
        lblTolerancia.AutoSize = false;
        lblTolerancia.BackColor = Color.Transparent;
        lblTolerancia.ForeColor = Color.FromArgb(64, 64, 64);
        lblTolerancia.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTolerancia.TextAlign = ContentAlignment.MiddleLeft;
        lblTolerancia.Text = "Tolerancia (minutos)";
        lblTolerancia.Location = new Point(460, 140);
        lblTolerancia.Name = "lblTolerancia";
        lblTolerancia.Size = new Size(426, 24);
        lblTolerancia.TabIndex = 7;
        lblTolerancia.TabStop = false;
        //
        // numTolerancia
        //
        numTolerancia.Font = new Font("Inter", 9F);
        numTolerancia.Maximum = 1440m;
        numTolerancia.DecimalPlaces = 0;
        numTolerancia.Location = new Point(460, 166);
        numTolerancia.Name = "numTolerancia";
        numTolerancia.Size = new Size(426, 34);
        numTolerancia.TabIndex = 8;
        //
        // lblEntradaPrevista
        //
        lblEntradaPrevista.AutoSize = false;
        lblEntradaPrevista.BackColor = Color.Transparent;
        lblEntradaPrevista.ForeColor = Color.FromArgb(64, 64, 64);
        lblEntradaPrevista.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEntradaPrevista.TextAlign = ContentAlignment.MiddleLeft;
        lblEntradaPrevista.Text = "Entrada prevista";
        lblEntradaPrevista.Location = new Point(16, 210);
        lblEntradaPrevista.Name = "lblEntradaPrevista";
        lblEntradaPrevista.Size = new Size(426, 24);
        lblEntradaPrevista.TabIndex = 9;
        lblEntradaPrevista.TabStop = false;
        //
        // dtpEntradaPrevista
        //
        dtpEntradaPrevista.Font = new Font("Inter", 10F);
        dtpEntradaPrevista.Format = DateTimePickerFormat.Custom;
        dtpEntradaPrevista.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpEntradaPrevista.MinimumSize = new Size(0, 34);
        dtpEntradaPrevista.ShowCheckBox = true;
        dtpEntradaPrevista.Location = new Point(16, 236);
        dtpEntradaPrevista.Name = "dtpEntradaPrevista";
        dtpEntradaPrevista.Size = new Size(426, 34);
        dtpEntradaPrevista.TabIndex = 10;
        //
        // lblSalidaPrevista
        //
        lblSalidaPrevista.AutoSize = false;
        lblSalidaPrevista.BackColor = Color.Transparent;
        lblSalidaPrevista.ForeColor = Color.FromArgb(64, 64, 64);
        lblSalidaPrevista.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblSalidaPrevista.TextAlign = ContentAlignment.MiddleLeft;
        lblSalidaPrevista.Text = "Salida prevista";
        lblSalidaPrevista.Location = new Point(460, 210);
        lblSalidaPrevista.Name = "lblSalidaPrevista";
        lblSalidaPrevista.Size = new Size(426, 24);
        lblSalidaPrevista.TabIndex = 11;
        lblSalidaPrevista.TabStop = false;
        //
        // dtpSalidaPrevista
        //
        dtpSalidaPrevista.Font = new Font("Inter", 10F);
        dtpSalidaPrevista.Format = DateTimePickerFormat.Custom;
        dtpSalidaPrevista.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpSalidaPrevista.MinimumSize = new Size(0, 34);
        dtpSalidaPrevista.ShowCheckBox = true;
        dtpSalidaPrevista.Location = new Point(460, 236);
        dtpSalidaPrevista.Name = "dtpSalidaPrevista";
        dtpSalidaPrevista.Size = new Size(426, 34);
        dtpSalidaPrevista.TabIndex = 12;
        //
        // lblEntrada
        //
        lblEntrada.AutoSize = false;
        lblEntrada.BackColor = Color.Transparent;
        lblEntrada.ForeColor = Color.FromArgb(64, 64, 64);
        lblEntrada.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEntrada.TextAlign = ContentAlignment.MiddleLeft;
        lblEntrada.Text = "Entrada registrada";
        lblEntrada.Location = new Point(16, 280);
        lblEntrada.Name = "lblEntrada";
        lblEntrada.Size = new Size(426, 24);
        lblEntrada.TabIndex = 13;
        lblEntrada.TabStop = false;
        //
        // dtpEntrada
        //
        dtpEntrada.Font = new Font("Inter", 10F);
        dtpEntrada.Format = DateTimePickerFormat.Custom;
        dtpEntrada.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpEntrada.MinimumSize = new Size(0, 34);
        dtpEntrada.ShowCheckBox = true;
        dtpEntrada.Location = new Point(16, 306);
        dtpEntrada.Name = "dtpEntrada";
        dtpEntrada.Size = new Size(426, 34);
        dtpEntrada.TabIndex = 14;
        //
        // lblSalida
        //
        lblSalida.AutoSize = false;
        lblSalida.BackColor = Color.Transparent;
        lblSalida.ForeColor = Color.FromArgb(64, 64, 64);
        lblSalida.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblSalida.TextAlign = ContentAlignment.MiddleLeft;
        lblSalida.Text = "Salida registrada";
        lblSalida.Location = new Point(460, 280);
        lblSalida.Name = "lblSalida";
        lblSalida.Size = new Size(426, 24);
        lblSalida.TabIndex = 15;
        lblSalida.TabStop = false;
        //
        // dtpSalida
        //
        dtpSalida.Font = new Font("Inter", 10F);
        dtpSalida.Format = DateTimePickerFormat.Custom;
        dtpSalida.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpSalida.MinimumSize = new Size(0, 34);
        dtpSalida.ShowCheckBox = true;
        dtpSalida.Location = new Point(460, 306);
        dtpSalida.Name = "dtpSalida";
        dtpSalida.Size = new Size(426, 34);
        dtpSalida.TabIndex = 16;
        //
        // lblEstadoFiltro
        //
        lblEstadoFiltro.AutoSize = false;
        lblEstadoFiltro.BackColor = Color.Transparent;
        lblEstadoFiltro.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoFiltro.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEstadoFiltro.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoFiltro.Text = "Estado";
        lblEstadoFiltro.Location = new Point(16, 350);
        lblEstadoFiltro.Name = "lblEstadoFiltro";
        lblEstadoFiltro.Size = new Size(426, 24);
        lblEstadoFiltro.TabIndex = 17;
        lblEstadoFiltro.TabStop = false;
        //
        // cboEstado
        //
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEstado.FormattingEnabled = true;
        cboEstado.Items.AddRange(new object[] { "Pendiente", "Presente", "Falta", "Justificada", "NoLaborable" });
        cboEstado.Location = new Point(16, 376);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(426, 34);
        cboEstado.TabIndex = 18;
        //
        // lblObservaciones
        //
        lblObservaciones.AutoSize = false;
        lblObservaciones.BackColor = Color.Transparent;
        lblObservaciones.ForeColor = Color.FromArgb(64, 64, 64);
        lblObservaciones.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblObservaciones.TextAlign = ContentAlignment.MiddleLeft;
        lblObservaciones.Text = "Observaciones";
        lblObservaciones.Location = new Point(16, 420);
        lblObservaciones.Name = "lblObservaciones";
        lblObservaciones.Size = new Size(870, 24);
        lblObservaciones.TabIndex = 19;
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
        txtObservaciones.Location = new Point(16, 446);
        txtObservaciones.Name = "txtObservaciones";
        txtObservaciones.Size = new Size(870, 80);
        txtObservaciones.TabIndex = 20;
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
        btnGuardar.TabIndex = 21;
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
        btnCancelar.TabIndex = 22;
        notificador.OwnerForm = this;
        //
        // FrmAsistencia
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblEmpleado);
        Controls.Add(cboEmpleado);
        Controls.Add(lblFecha);
        Controls.Add(dtpFecha);
        Controls.Add(chkEsLaborable);
        Controls.Add(lblTolerancia);
        Controls.Add(numTolerancia);
        Controls.Add(lblEntradaPrevista);
        Controls.Add(dtpEntradaPrevista);
        Controls.Add(lblSalidaPrevista);
        Controls.Add(dtpSalidaPrevista);
        Controls.Add(lblEntrada);
        Controls.Add(dtpEntrada);
        Controls.Add(lblSalida);
        Controls.Add(dtpSalida);
        Controls.Add(lblEstadoFiltro);
        Controls.Add(cboEstado);
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
        Name = "FrmAsistencia";
        Text = "Registrar o corregir asistencia";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KComboBox cboEmpleado;
    private KovaqsUI.Controls.KLabel lblFecha;
    private DateTimePicker dtpFecha;
    private KovaqsUI.Controls.KCheckBox chkEsLaborable;
    private KovaqsUI.Controls.KLabel lblTolerancia;
    private KovaqsUI.Controls.KNumericUpDown numTolerancia;
    private KovaqsUI.Controls.KLabel lblEntradaPrevista;
    private DateTimePicker dtpEntradaPrevista;
    private KovaqsUI.Controls.KLabel lblSalidaPrevista;
    private DateTimePicker dtpSalidaPrevista;
    private KovaqsUI.Controls.KLabel lblEntrada;
    private DateTimePicker dtpEntrada;
    private KovaqsUI.Controls.KLabel lblSalida;
    private DateTimePicker dtpSalida;
    private KovaqsUI.Controls.KLabel lblEstadoFiltro;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KLabel lblObservaciones;
    private KovaqsUI.Controls.KTextBox txtObservaciones;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
