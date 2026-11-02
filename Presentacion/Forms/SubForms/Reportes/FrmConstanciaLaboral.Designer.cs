namespace Presentacion.Forms.SubForms.Reportes;

partial class FrmConstanciaLaboral
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
        lblFechaEmision = new KovaqsUI.Controls.KLabel();
        dtpFechaEmision = new DateTimePicker();
        lblLugarEmision = new KovaqsUI.Controls.KLabel();
        txtLugarEmision = new KovaqsUI.Controls.KTextBox();
        lblFirmante = new KovaqsUI.Controls.KLabel();
        txtFirmante = new KovaqsUI.Controls.KTextBox();
        lblCargoFirmante = new KovaqsUI.Controls.KLabel();
        txtCargoFirmante = new KovaqsUI.Controls.KTextBox();
        chkIncluirSalario = new KovaqsUI.Controls.KCheckBox();
        btnExportarPdf = new KovaqsUI.Controls.KButton();
        btnImprimir = new KovaqsUI.Controls.KButton();
        dlgGuardarConstancia = new SaveFileDialog();
        components.Add(dlgGuardarConstancia);
        dlgImprimir = new PrintDialog();
        components.Add(dlgImprimir);
        docConstancia = new System.Drawing.Printing.PrintDocument();
        components.Add(docConstancia);
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
        lblTitulo.Text = "Emitir constancia laboral";
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
        btnCerrar.Text = "Cerrar";
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.Location = new Point(790, 12);
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
        lblEmpleado.Font = new Font("Inter", 9F);
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
        cboEmpleado.CornerRadius = 8;
        cboEmpleado.FillColor = Color.White;
        cboEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEmpleado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEmpleado.GradientColor = Color.Empty;

        cboEmpleado.Name = "cboEmpleado";
        cboEmpleado.Size = new Size(426, 34);
        cboEmpleado.TabIndex = 4;
        //
        // lblFechaEmision
        //
        lblFechaEmision.AutoSize = false;
        lblFechaEmision.BackColor = Color.Transparent;
        lblFechaEmision.ForeColor = Color.FromArgb(64, 64, 64);
        lblFechaEmision.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblFechaEmision.TextAlign = ContentAlignment.MiddleLeft;
        lblFechaEmision.Text = "Fecha de emisión";
        lblFechaEmision.Location = new Point(460, 70);
        lblFechaEmision.Font = new Font("Inter", 9F);
        lblFechaEmision.Name = "lblFechaEmision";
        lblFechaEmision.Size = new Size(426, 24);
        lblFechaEmision.TabIndex = 3;
        lblFechaEmision.TabStop = false;
        //
        // dtpFechaEmision
        //
        dtpFechaEmision.Font = new Font("Inter", 10F);
        dtpFechaEmision.Format = DateTimePickerFormat.Custom;
        dtpFechaEmision.CustomFormat = "dd/MM/yyyy";
        dtpFechaEmision.MinimumSize = new Size(0, 34);
        dtpFechaEmision.Location = new Point(460, 96);
        dtpFechaEmision.CalendarFont = new Font("Inter", 9F);
        dtpFechaEmision.Name = "dtpFechaEmision";
        dtpFechaEmision.Size = new Size(426, 34);
        dtpFechaEmision.TabIndex = 5;
        //
        // lblLugarEmision
        //
        lblLugarEmision.AutoSize = false;
        lblLugarEmision.BackColor = Color.Transparent;
        lblLugarEmision.ForeColor = Color.FromArgb(64, 64, 64);
        lblLugarEmision.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblLugarEmision.TextAlign = ContentAlignment.MiddleLeft;
        lblLugarEmision.Text = "Lugar de emisión";
        lblLugarEmision.Location = new Point(16, 140);
        lblLugarEmision.Font = new Font("Inter", 9F);
        lblLugarEmision.Name = "lblLugarEmision";
        lblLugarEmision.Size = new Size(426, 24);
        lblLugarEmision.TabIndex = 6;
        lblLugarEmision.TabStop = false;
        //
        // txtLugarEmision
        //
        txtLugarEmision.BackColor = Color.Transparent;
        txtLugarEmision.CornerRadius = 8;
        txtLugarEmision.Font = new Font("Inter", 9F);
        txtLugarEmision.Padding = new Padding(10, 6, 10, 6);
        txtLugarEmision.MaxLength = 100;
        txtLugarEmision.Location = new Point(16, 166);
        txtLugarEmision.FillColor = Color.White;
        txtLugarEmision.ForeColor = Color.FromArgb(32, 38, 45);
        txtLugarEmision.BorderColor = Color.FromArgb(218, 218, 218);
        txtLugarEmision.GradientColor = Color.Empty;
        txtLugarEmision.BorderThickness = 1;
        txtLugarEmision.Name = "txtLugarEmision";
        txtLugarEmision.Size = new Size(426, 34);
        txtLugarEmision.TabIndex = 8;
        //
        // lblFirmante
        //
        lblFirmante.AutoSize = false;
        lblFirmante.BackColor = Color.Transparent;
        lblFirmante.ForeColor = Color.FromArgb(64, 64, 64);
        lblFirmante.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblFirmante.TextAlign = ContentAlignment.MiddleLeft;
        lblFirmante.Text = "Nombre del firmante";
        lblFirmante.Location = new Point(460, 140);
        lblFirmante.Font = new Font("Inter", 9F);
        lblFirmante.Name = "lblFirmante";
        lblFirmante.Size = new Size(426, 24);
        lblFirmante.TabIndex = 7;
        lblFirmante.TabStop = false;
        //
        // txtFirmante
        //
        txtFirmante.BackColor = Color.Transparent;
        txtFirmante.CornerRadius = 8;
        txtFirmante.Font = new Font("Inter", 9F);
        txtFirmante.Padding = new Padding(10, 6, 10, 6);
        txtFirmante.MaxLength = 100;
        txtFirmante.Location = new Point(460, 166);
        txtFirmante.FillColor = Color.White;
        txtFirmante.ForeColor = Color.FromArgb(32, 38, 45);
        txtFirmante.BorderColor = Color.FromArgb(218, 218, 218);
        txtFirmante.GradientColor = Color.Empty;
        txtFirmante.BorderThickness = 1;
        txtFirmante.Name = "txtFirmante";
        txtFirmante.Size = new Size(426, 34);
        txtFirmante.TabIndex = 9;
        //
        // lblCargoFirmante
        //
        lblCargoFirmante.AutoSize = false;
        lblCargoFirmante.BackColor = Color.Transparent;
        lblCargoFirmante.ForeColor = Color.FromArgb(64, 64, 64);
        lblCargoFirmante.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblCargoFirmante.TextAlign = ContentAlignment.MiddleLeft;
        lblCargoFirmante.Text = "Cargo del firmante";
        lblCargoFirmante.Location = new Point(16, 210);
        lblCargoFirmante.Font = new Font("Inter", 9F);
        lblCargoFirmante.Name = "lblCargoFirmante";
        lblCargoFirmante.Size = new Size(426, 24);
        lblCargoFirmante.TabIndex = 10;
        lblCargoFirmante.TabStop = false;
        //
        // txtCargoFirmante
        //
        txtCargoFirmante.BackColor = Color.Transparent;
        txtCargoFirmante.CornerRadius = 8;
        txtCargoFirmante.Font = new Font("Inter", 9F);
        txtCargoFirmante.Padding = new Padding(10, 6, 10, 6);
        txtCargoFirmante.MaxLength = 100;
        txtCargoFirmante.Location = new Point(16, 236);
        txtCargoFirmante.FillColor = Color.White;
        txtCargoFirmante.ForeColor = Color.FromArgb(32, 38, 45);
        txtCargoFirmante.BorderColor = Color.FromArgb(218, 218, 218);
        txtCargoFirmante.GradientColor = Color.Empty;
        txtCargoFirmante.BorderThickness = 1;
        txtCargoFirmante.Name = "txtCargoFirmante";
        txtCargoFirmante.Size = new Size(426, 34);
        txtCargoFirmante.TabIndex = 12;
        //
        // chkIncluirSalario
        //
        chkIncluirSalario.Font = new Font("Inter", 9F);
        chkIncluirSalario.Text = "Incluir salario autorizado";
        chkIncluirSalario.Location = new Point(460, 234);
        chkIncluirSalario.ForeColor = Color.FromArgb(64, 64, 64);
        chkIncluirSalario.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkIncluirSalario.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
        chkIncluirSalario.CheckedState.ForeColor = Color.White;
        chkIncluirSalario.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkIncluirSalario.Name = "chkIncluirSalario";
        chkIncluirSalario.Size = new Size(426, 36);
        chkIncluirSalario.TabIndex = 11;
        //
        // btnExportarPdf
        //
        btnExportarPdf.BackColor = Color.Transparent;
        btnExportarPdf.CornerRadius = 8;
        btnExportarPdf.FlatStyle = FlatStyle.Flat;
        btnExportarPdf.Font = new Font("Inter", 9F);
        btnExportarPdf.Padding = new Padding(10, 4, 10, 4);
        btnExportarPdf.UseVisualStyleBackColor = false;
        btnExportarPdf.Text = "Generar PDF";
        btnExportarPdf.Location = new Point(16, 288);
        btnExportarPdf.BorderThickness = 1;
        btnExportarPdf.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnExportarPdf.FillColor = Color.FromArgb(49, 81, 107);
        btnExportarPdf.ForeColor = Color.White;
        btnExportarPdf.BorderColor = Color.FromArgb(49, 81, 107);
        btnExportarPdf.GradientColor = Color.Empty;
        btnExportarPdf.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnExportarPdf.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnExportarPdf.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnExportarPdf.Name = "btnExportarPdf";
        btnExportarPdf.Size = new Size(220, 40);
        btnExportarPdf.TabIndex = 13;
        //
        // btnImprimir
        //
        btnImprimir.BackColor = Color.Transparent;
        btnImprimir.CornerRadius = 8;
        btnImprimir.FlatStyle = FlatStyle.Flat;
        btnImprimir.Font = new Font("Inter", 9F);
        btnImprimir.Padding = new Padding(10, 4, 10, 4);
        btnImprimir.UseVisualStyleBackColor = false;
        btnImprimir.Text = "Imprimir";
        btnImprimir.Location = new Point(248, 288);
        btnImprimir.BorderThickness = 1;
        btnImprimir.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnImprimir.FillColor = Color.White;
        btnImprimir.ForeColor = Color.FromArgb(49, 81, 107);
        btnImprimir.BorderColor = Color.FromArgb(173, 190, 204);
        btnImprimir.GradientColor = Color.Empty;
        btnImprimir.Appearance.Hover.FillColor = Color.FromArgb(239, 244, 248);
        btnImprimir.Appearance.Pressed.FillColor = Color.FromArgb(225, 235, 243);
        btnImprimir.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnImprimir.Name = "btnImprimir";
        btnImprimir.Size = new Size(220, 40);
        btnImprimir.TabIndex = 14;
        dlgGuardarConstancia.Filter = "Documentos PDF (*.pdf)|*.pdf";
        dlgGuardarConstancia.DefaultExt = "pdf";
        dlgGuardarConstancia.AddExtension = true;
        notificador.OwnerForm = this;
        //
        // FrmConstanciaLaboral
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblEmpleado);
        Controls.Add(cboEmpleado);
        Controls.Add(lblFechaEmision);
        Controls.Add(dtpFechaEmision);
        Controls.Add(lblLugarEmision);
        Controls.Add(txtLugarEmision);
        Controls.Add(lblFirmante);
        Controls.Add(txtFirmante);
        Controls.Add(lblCargoFirmante);
        Controls.Add(txtCargoFirmante);
        Controls.Add(chkIncluirSalario);
        Controls.Add(btnExportarPdf);
        Controls.Add(btnImprimir);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCerrar;
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmConstanciaLaboral";
        Text = "Emitir constancia laboral";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KComboBox cboEmpleado;
    private KovaqsUI.Controls.KLabel lblFechaEmision;
    private DateTimePicker dtpFechaEmision;
    private KovaqsUI.Controls.KLabel lblLugarEmision;
    private KovaqsUI.Controls.KTextBox txtLugarEmision;
    private KovaqsUI.Controls.KLabel lblFirmante;
    private KovaqsUI.Controls.KTextBox txtFirmante;
    private KovaqsUI.Controls.KLabel lblCargoFirmante;
    private KovaqsUI.Controls.KTextBox txtCargoFirmante;
    private KovaqsUI.Controls.KCheckBox chkIncluirSalario;
    private KovaqsUI.Controls.KButton btnExportarPdf;
    private KovaqsUI.Controls.KButton btnImprimir;
    private SaveFileDialog dlgGuardarConstancia;
    private PrintDialog dlgImprimir;
    private System.Drawing.Printing.PrintDocument docConstancia;
    private KovaqsUI.Components.KToastNotifier notificador;
}
