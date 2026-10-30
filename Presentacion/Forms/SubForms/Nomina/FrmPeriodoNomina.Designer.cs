namespace Presentacion.Forms.SubForms.Nomina;

partial class FrmPeriodoNomina
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
        lblNombre = new KovaqsUI.Controls.KLabel();
        txtNombre = new KovaqsUI.Controls.KTextBox();
        lblFechaInicio = new KovaqsUI.Controls.KLabel();
        dtpFechaInicio = new DateTimePicker();
        lblFechaFin = new KovaqsUI.Controls.KLabel();
        dtpFechaFin = new DateTimePicker();
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
        lblTitulo.Text = "Crear período de nómina";
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
        // lblNombre
        //
        lblNombre.AutoSize = false;
        lblNombre.BackColor = Color.Transparent;
        lblNombre.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombre.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNombre.TextAlign = ContentAlignment.MiddleLeft;
        lblNombre.Text = "Nombre del período";
        lblNombre.Location = new Point(16, 70);
        lblNombre.Font = new Font("Inter", 9F);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(426, 24);
        lblNombre.TabIndex = 2;
        lblNombre.TabStop = false;
        //
        // txtNombre
        //
        txtNombre.BackColor = Color.Transparent;
        txtNombre.CornerRadius = 8;
        txtNombre.Font = new Font("Inter", 9F);
        txtNombre.Padding = new Padding(10, 6, 10, 6);
        txtNombre.MaxLength = 100;
        txtNombre.Location = new Point(16, 96);
        txtNombre.FillColor = Color.White;
        txtNombre.ForeColor = Color.FromArgb(32, 38, 45);
        txtNombre.BorderColor = Color.FromArgb(218, 218, 218);
        txtNombre.GradientColor = Color.Empty;
        txtNombre.BorderThickness = 1;
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(426, 34);
        txtNombre.TabIndex = 4;
        //
        // lblFechaInicio
        //
        lblFechaInicio.AutoSize = false;
        lblFechaInicio.BackColor = Color.Transparent;
        lblFechaInicio.ForeColor = Color.FromArgb(64, 64, 64);
        lblFechaInicio.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblFechaInicio.TextAlign = ContentAlignment.MiddleLeft;
        lblFechaInicio.Text = "Fecha de inicio";
        lblFechaInicio.Location = new Point(460, 70);
        lblFechaInicio.Font = new Font("Inter", 9F);
        lblFechaInicio.Name = "lblFechaInicio";
        lblFechaInicio.Size = new Size(426, 24);
        lblFechaInicio.TabIndex = 3;
        lblFechaInicio.TabStop = false;
        //
        // dtpFechaInicio
        //
        dtpFechaInicio.Font = new Font("Inter", 10F);
        dtpFechaInicio.Format = DateTimePickerFormat.Custom;
        dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
        dtpFechaInicio.MinimumSize = new Size(0, 34);
        dtpFechaInicio.Location = new Point(460, 96);
        dtpFechaInicio.CalendarFont = new Font("Inter", 9F);
        dtpFechaInicio.Name = "dtpFechaInicio";
        dtpFechaInicio.Size = new Size(426, 34);
        dtpFechaInicio.TabIndex = 5;
        //
        // lblFechaFin
        //
        lblFechaFin.AutoSize = false;
        lblFechaFin.BackColor = Color.Transparent;
        lblFechaFin.ForeColor = Color.FromArgb(64, 64, 64);
        lblFechaFin.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblFechaFin.TextAlign = ContentAlignment.MiddleLeft;
        lblFechaFin.Text = "Fecha de fin";
        lblFechaFin.Location = new Point(16, 140);
        lblFechaFin.Font = new Font("Inter", 9F);
        lblFechaFin.Name = "lblFechaFin";
        lblFechaFin.Size = new Size(426, 24);
        lblFechaFin.TabIndex = 6;
        lblFechaFin.TabStop = false;
        //
        // dtpFechaFin
        //
        dtpFechaFin.Font = new Font("Inter", 10F);
        dtpFechaFin.Format = DateTimePickerFormat.Custom;
        dtpFechaFin.CustomFormat = "dd/MM/yyyy";
        dtpFechaFin.MinimumSize = new Size(0, 34);
        dtpFechaFin.Location = new Point(16, 166);
        dtpFechaFin.CalendarFont = new Font("Inter", 9F);
        dtpFechaFin.Name = "dtpFechaFin";
        dtpFechaFin.Size = new Size(426, 34);
        dtpFechaFin.TabIndex = 7;
        //
        // lblObservaciones
        //
        lblObservaciones.AutoSize = false;
        lblObservaciones.BackColor = Color.Transparent;
        lblObservaciones.ForeColor = Color.FromArgb(64, 64, 64);
        lblObservaciones.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblObservaciones.TextAlign = ContentAlignment.MiddleLeft;
        lblObservaciones.Text = "Observaciones";
        lblObservaciones.Location = new Point(16, 210);
        lblObservaciones.Font = new Font("Inter", 9F);
        lblObservaciones.Name = "lblObservaciones";
        lblObservaciones.Size = new Size(870, 24);
        lblObservaciones.TabIndex = 8;
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
        txtObservaciones.Location = new Point(16, 236);
        txtObservaciones.FillColor = Color.White;
        txtObservaciones.ForeColor = Color.FromArgb(32, 38, 45);
        txtObservaciones.BorderColor = Color.FromArgb(218, 218, 218);
        txtObservaciones.GradientColor = Color.Empty;
        txtObservaciones.BorderThickness = 1;
        txtObservaciones.Name = "txtObservaciones";
        txtObservaciones.Size = new Size(870, 80);
        txtObservaciones.TabIndex = 9;
        //
        // btnGuardar
        //
        btnGuardar.BackColor = Color.Transparent;
        btnGuardar.CornerRadius = 8;
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.Font = new Font("Inter", 9F);
        btnGuardar.Padding = new Padding(10, 4, 10, 4);
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Text = "Guardar";
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnGuardar.Location = new Point(586, 613);
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
        btnGuardar.Size = new Size(144, 40);
        btnGuardar.TabIndex = 10;
        //
        // btnCancelar
        //
        btnCancelar.BackColor = Color.Transparent;
        btnCancelar.CornerRadius = 8;
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.Font = new Font("Inter", 9F);
        btnCancelar.Padding = new Padding(10, 4, 10, 4);
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Text = "Cancelar";
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.Location = new Point(742, 613);
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
        btnCancelar.Size = new Size(144, 40);
        btnCancelar.TabIndex = 11;
        notificador.OwnerForm = this;
        //
        // FrmPeriodoNomina
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(lblFechaInicio);
        Controls.Add(dtpFechaInicio);
        Controls.Add(lblFechaFin);
        Controls.Add(dtpFechaFin);
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
        Font = new Font("Segoe UI", 9F);
        Name = "FrmPeriodoNomina";
        Text = "Crear período de nómina";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblNombre;
    private KovaqsUI.Controls.KTextBox txtNombre;
    private KovaqsUI.Controls.KLabel lblFechaInicio;
    private DateTimePicker dtpFechaInicio;
    private KovaqsUI.Controls.KLabel lblFechaFin;
    private DateTimePicker dtpFechaFin;
    private KovaqsUI.Controls.KLabel lblObservaciones;
    private KovaqsUI.Controls.KTextBox txtObservaciones;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
