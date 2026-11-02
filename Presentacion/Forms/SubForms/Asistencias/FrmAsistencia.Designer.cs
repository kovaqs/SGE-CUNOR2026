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
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(740, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Registrar o corregir asistencia";
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        // 
        // btnCerrar
        // 
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnCerrar.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        btnCerrar.Appearance.Normal.FillColor = Color.White;
        btnCerrar.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        btnCerrar.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnCerrar.BackColor = Color.Transparent;
        btnCerrar.BorderColor = Color.FromArgb(218, 218, 218);
        btnCerrar.CornerRadius = 8;
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.FillColor = Color.White;
        btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnCerrar.Font = new Font("Inter", 9F);
        btnCerrar.ForeColor = Color.FromArgb(32, 38, 45);
        btnCerrar.Location = new Point(790, 12);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Padding = new Padding(10, 4, 10, 4);
        btnCerrar.Size = new Size(96, 40);
        btnCerrar.TabIndex = 1;
        btnCerrar.Text = "Cerrar";
        btnCerrar.UseVisualStyleBackColor = false;
        btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // lblEmpleado
        // 
        lblEmpleado.AutoSize = false;
        lblEmpleado.BackColor = Color.Transparent;
        lblEmpleado.Font = new Font("Inter", 9F);
        lblEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEmpleado.Location = new Point(16, 70);
        lblEmpleado.Name = "lblEmpleado";
        lblEmpleado.Size = new Size(426, 24);
        lblEmpleado.TabIndex = 2;
        lblEmpleado.Text = "Empleado";
        lblEmpleado.TextAlign = ContentAlignment.MiddleLeft;
        lblEmpleado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // cboEmpleado
        // 
        cboEmpleado.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        cboEmpleado.Appearance.Normal.FillColor = Color.White;
        cboEmpleado.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        cboEmpleado.BackColor = Color.White;
        cboEmpleado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEmpleado.FillColor = Color.White;
        cboEmpleado.Font = new Font("Inter", 9F);
        cboEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEmpleado.FormattingEnabled = true;
        cboEmpleado.ItemHeight = 28;
        cboEmpleado.Location = new Point(16, 96);
        cboEmpleado.Name = "cboEmpleado";
        cboEmpleado.Size = new Size(426, 34);
        cboEmpleado.TabIndex = 4;
        // 
        // lblFecha
        // 
        lblFecha.AutoSize = false;
        lblFecha.BackColor = Color.Transparent;
        lblFecha.Font = new Font("Inter", 9F);
        lblFecha.ForeColor = Color.FromArgb(64, 64, 64);
        lblFecha.Location = new Point(460, 70);
        lblFecha.Name = "lblFecha";
        lblFecha.Size = new Size(426, 24);
        lblFecha.TabIndex = 3;
        lblFecha.Text = "Día de asistencia";
        lblFecha.TextAlign = ContentAlignment.MiddleLeft;
        lblFecha.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // dtpFecha
        // 
        dtpFecha.CalendarFont = new Font("Microsoft Sans Serif", 9F);
        dtpFecha.CustomFormat = "dd/MM/yyyy";
        dtpFecha.Font = new Font("Microsoft Sans Serif", 10F);
        dtpFecha.Format = DateTimePickerFormat.Custom;
        dtpFecha.Location = new Point(460, 96);
        dtpFecha.MinimumSize = new Size(0, 34);
        dtpFecha.Name = "dtpFecha";
        dtpFecha.Size = new Size(426, 34);
        dtpFecha.TabIndex = 5;
        // 
        // chkEsLaborable
        // 
        chkEsLaborable.BackColor = Color.Transparent;
        chkEsLaborable.Checked = true;
        chkEsLaborable.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
        chkEsLaborable.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkEsLaborable.CheckedState.ForeColor = Color.White;
        chkEsLaborable.CheckState = CheckState.Checked;
        chkEsLaborable.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkEsLaborable.Font = new Font("Inter", 9F);
        chkEsLaborable.ForeColor = Color.FromArgb(64, 64, 64);
        chkEsLaborable.Location = new Point(16, 164);
        chkEsLaborable.Name = "chkEsLaborable";
        chkEsLaborable.Padding = new Padding(2);
        chkEsLaborable.Size = new Size(426, 36);
        chkEsLaborable.TabIndex = 7;
        chkEsLaborable.Text = "Día laborable";
        chkEsLaborable.UseVisualStyleBackColor = false;
        // 
        // lblTolerancia
        // 
        lblTolerancia.AutoSize = false;
        lblTolerancia.BackColor = Color.Transparent;
        lblTolerancia.Font = new Font("Inter", 9F);
        lblTolerancia.ForeColor = Color.FromArgb(64, 64, 64);
        lblTolerancia.Location = new Point(460, 140);
        lblTolerancia.Name = "lblTolerancia";
        lblTolerancia.Size = new Size(426, 24);
        lblTolerancia.TabIndex = 6;
        lblTolerancia.Text = "Tolerancia (minutos)";
        lblTolerancia.TextAlign = ContentAlignment.MiddleLeft;
        lblTolerancia.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // numTolerancia
        // 
        numTolerancia.Appearance.Normal.ForeColor = Color.FromArgb(64, 64, 64);
        numTolerancia.BackColor = Color.Transparent;
        numTolerancia.Font = new Font("Inter", 9F);
        numTolerancia.ForeColor = Color.FromArgb(64, 64, 64);
        numTolerancia.Location = new Point(460, 166);
        numTolerancia.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
        numTolerancia.Name = "numTolerancia";
        numTolerancia.Size = new Size(426, 34);
        numTolerancia.TabIndex = 8;
        // 
        // lblEntradaPrevista
        // 
        lblEntradaPrevista.AutoSize = false;
        lblEntradaPrevista.BackColor = Color.Transparent;
        lblEntradaPrevista.Font = new Font("Inter", 9F);
        lblEntradaPrevista.ForeColor = Color.FromArgb(64, 64, 64);
        lblEntradaPrevista.Location = new Point(16, 210);
        lblEntradaPrevista.Name = "lblEntradaPrevista";
        lblEntradaPrevista.Size = new Size(426, 24);
        lblEntradaPrevista.TabIndex = 9;
        lblEntradaPrevista.Text = "Entrada prevista";
        lblEntradaPrevista.TextAlign = ContentAlignment.MiddleLeft;
        lblEntradaPrevista.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // dtpEntradaPrevista
        // 
        dtpEntradaPrevista.CalendarFont = new Font("Microsoft Sans Serif", 9F);
        dtpEntradaPrevista.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpEntradaPrevista.Font = new Font("Microsoft Sans Serif", 10F);
        dtpEntradaPrevista.Format = DateTimePickerFormat.Custom;
        dtpEntradaPrevista.Location = new Point(16, 236);
        dtpEntradaPrevista.MinimumSize = new Size(0, 34);
        dtpEntradaPrevista.Name = "dtpEntradaPrevista";
        dtpEntradaPrevista.ShowCheckBox = true;
        dtpEntradaPrevista.Size = new Size(426, 34);
        dtpEntradaPrevista.TabIndex = 11;
        // 
        // lblSalidaPrevista
        // 
        lblSalidaPrevista.AutoSize = false;
        lblSalidaPrevista.BackColor = Color.Transparent;
        lblSalidaPrevista.Font = new Font("Inter", 9F);
        lblSalidaPrevista.ForeColor = Color.FromArgb(64, 64, 64);
        lblSalidaPrevista.Location = new Point(460, 210);
        lblSalidaPrevista.Name = "lblSalidaPrevista";
        lblSalidaPrevista.Size = new Size(426, 24);
        lblSalidaPrevista.TabIndex = 10;
        lblSalidaPrevista.Text = "Salida prevista";
        lblSalidaPrevista.TextAlign = ContentAlignment.MiddleLeft;
        lblSalidaPrevista.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // dtpSalidaPrevista
        // 
        dtpSalidaPrevista.CalendarFont = new Font("Microsoft Sans Serif", 9F);
        dtpSalidaPrevista.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpSalidaPrevista.Font = new Font("Microsoft Sans Serif", 10F);
        dtpSalidaPrevista.Format = DateTimePickerFormat.Custom;
        dtpSalidaPrevista.Location = new Point(460, 236);
        dtpSalidaPrevista.MinimumSize = new Size(0, 34);
        dtpSalidaPrevista.Name = "dtpSalidaPrevista";
        dtpSalidaPrevista.ShowCheckBox = true;
        dtpSalidaPrevista.Size = new Size(426, 34);
        dtpSalidaPrevista.TabIndex = 12;
        // 
        // lblEntrada
        // 
        lblEntrada.AutoSize = false;
        lblEntrada.BackColor = Color.Transparent;
        lblEntrada.Font = new Font("Inter", 9F);
        lblEntrada.ForeColor = Color.FromArgb(64, 64, 64);
        lblEntrada.Location = new Point(16, 280);
        lblEntrada.Name = "lblEntrada";
        lblEntrada.Size = new Size(426, 24);
        lblEntrada.TabIndex = 13;
        lblEntrada.Text = "Entrada registrada";
        lblEntrada.TextAlign = ContentAlignment.MiddleLeft;
        lblEntrada.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // dtpEntrada
        // 
        dtpEntrada.CalendarFont = new Font("Microsoft Sans Serif", 9F);
        dtpEntrada.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpEntrada.Font = new Font("Microsoft Sans Serif", 10F);
        dtpEntrada.Format = DateTimePickerFormat.Custom;
        dtpEntrada.Location = new Point(16, 306);
        dtpEntrada.MinimumSize = new Size(0, 34);
        dtpEntrada.Name = "dtpEntrada";
        dtpEntrada.ShowCheckBox = true;
        dtpEntrada.Size = new Size(426, 34);
        dtpEntrada.TabIndex = 15;
        // 
        // lblSalida
        // 
        lblSalida.AutoSize = false;
        lblSalida.BackColor = Color.Transparent;
        lblSalida.Font = new Font("Inter", 9F);
        lblSalida.ForeColor = Color.FromArgb(64, 64, 64);
        lblSalida.Location = new Point(460, 280);
        lblSalida.Name = "lblSalida";
        lblSalida.Size = new Size(426, 24);
        lblSalida.TabIndex = 14;
        lblSalida.Text = "Salida registrada";
        lblSalida.TextAlign = ContentAlignment.MiddleLeft;
        lblSalida.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // dtpSalida
        // 
        dtpSalida.CalendarFont = new Font("Microsoft Sans Serif", 9F);
        dtpSalida.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpSalida.Font = new Font("Microsoft Sans Serif", 10F);
        dtpSalida.Format = DateTimePickerFormat.Custom;
        dtpSalida.Location = new Point(460, 306);
        dtpSalida.MinimumSize = new Size(0, 34);
        dtpSalida.Name = "dtpSalida";
        dtpSalida.ShowCheckBox = true;
        dtpSalida.Size = new Size(426, 34);
        dtpSalida.TabIndex = 16;
        // 
        // lblEstadoFiltro
        // 
        lblEstadoFiltro.AutoSize = false;
        lblEstadoFiltro.BackColor = Color.Transparent;
        lblEstadoFiltro.Font = new Font("Inter", 9F);
        lblEstadoFiltro.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoFiltro.Location = new Point(16, 350);
        lblEstadoFiltro.Name = "lblEstadoFiltro";
        lblEstadoFiltro.Size = new Size(426, 24);
        lblEstadoFiltro.TabIndex = 17;
        lblEstadoFiltro.Text = "Estado";
        lblEstadoFiltro.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoFiltro.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // cboEstado
        // 
        cboEstado.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.Appearance.Normal.FillColor = Color.White;
        cboEstado.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.BackColor = Color.White;
        cboEstado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.FillColor = Color.White;
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
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
        lblObservaciones.Font = new Font("Inter", 9F);
        lblObservaciones.ForeColor = Color.FromArgb(64, 64, 64);
        lblObservaciones.Location = new Point(16, 420);
        lblObservaciones.Name = "lblObservaciones";
        lblObservaciones.Size = new Size(870, 24);
        lblObservaciones.TabIndex = 19;
        lblObservaciones.Text = "Observaciones";
        lblObservaciones.TextAlign = ContentAlignment.MiddleLeft;
        lblObservaciones.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // txtObservaciones
        // 
        txtObservaciones.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        txtObservaciones.Appearance.Normal.FillColor = Color.White;
        txtObservaciones.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        txtObservaciones.BackColor = Color.Transparent;
        txtObservaciones.BorderColor = Color.FromArgb(218, 218, 218);
        txtObservaciones.CornerRadius = 8;
        txtObservaciones.FillColor = Color.White;
        txtObservaciones.Font = new Font("Inter", 9F);
        txtObservaciones.ForeColor = Color.FromArgb(32, 38, 45);
        txtObservaciones.Location = new Point(16, 446);
        txtObservaciones.MaxLength = 500;
        txtObservaciones.Multiline = true;
        txtObservaciones.Name = "txtObservaciones";
        txtObservaciones.Padding = new Padding(10, 6, 10, 6);
        txtObservaciones.Size = new Size(870, 80);
        txtObservaciones.TabIndex = 20;
        // 
        // btnGuardar
        // 
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnGuardar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnGuardar.Appearance.Normal.BorderColor = Color.FromArgb(49, 81, 107);
        btnGuardar.Appearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
        btnGuardar.Appearance.Normal.ForeColor = Color.White;
        btnGuardar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnGuardar.BackColor = Color.Transparent;
        btnGuardar.BorderColor = Color.FromArgb(49, 81, 107);
        btnGuardar.CornerRadius = 8;
        btnGuardar.FillColor = Color.FromArgb(49, 81, 107);
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnGuardar.Font = new Font("Inter", 9F);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Location = new Point(586, 613);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Padding = new Padding(10, 4, 10, 4);
        btnGuardar.Size = new Size(144, 40);
        btnGuardar.TabIndex = 21;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        // 
        // btnCancelar
        // 
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
        btnCancelar.Appearance.Normal.BorderColor = Color.FromArgb(204, 148, 150);
        btnCancelar.Appearance.Normal.FillColor = Color.FromArgb(255, 248, 248);
        btnCancelar.Appearance.Normal.ForeColor = Color.FromArgb(166, 61, 64);
        btnCancelar.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
        btnCancelar.BackColor = Color.Transparent;
        btnCancelar.BorderColor = Color.FromArgb(204, 148, 150);
        btnCancelar.CornerRadius = 8;
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.FillColor = Color.FromArgb(255, 248, 248);
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
        btnCancelar.Font = new Font("Inter", 9F);
        btnCancelar.ForeColor = Color.FromArgb(166, 61, 64);
        btnCancelar.Location = new Point(742, 613);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Padding = new Padding(10, 4, 10, 4);
        btnCancelar.Size = new Size(144, 40);
        btnCancelar.TabIndex = 22;
        btnCancelar.Text = "Cancelar";
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
        // 
        // notificador
        // 
        notificador.OwnerForm = this;
        // 
        // FrmAsistencia
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        CancelButton = btnCancelar;
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
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Icon = Properties.Resources.sgeicon;
        Name = "FrmAsistencia";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
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
