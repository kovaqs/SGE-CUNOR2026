namespace Presentacion.Forms.SubForms.Asistencias;

partial class FrmPermisoLaboral
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
        lblFechaInicio = new KovaqsUI.Controls.KLabel();
        dtpFechaInicio = new DateTimePicker();
        lblFechaFin = new KovaqsUI.Controls.KLabel();
        dtpFechaFin = new DateTimePicker();
        chkConGoce = new KovaqsUI.Controls.KCheckBox();
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
        lblTitulo.Text = "Solicitar o editar permiso laboral";
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
        // lblFechaInicio
        //
        lblFechaInicio.AutoSize = false;
        lblFechaInicio.BackColor = Color.Transparent;
        lblFechaInicio.ForeColor = Color.FromArgb(64, 64, 64);
        lblFechaInicio.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblFechaInicio.TextAlign = ContentAlignment.MiddleLeft;
        lblFechaInicio.Text = "Inicio del permiso";
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
        dtpFechaInicio.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpFechaInicio.MinimumSize = new Size(0, 34);
        dtpFechaInicio.Location = new Point(460, 96);
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
        lblFechaFin.Text = "Fin del permiso";
        lblFechaFin.Location = new Point(16, 140);
        lblFechaFin.Name = "lblFechaFin";
        lblFechaFin.Size = new Size(426, 24);
        lblFechaFin.TabIndex = 6;
        lblFechaFin.TabStop = false;
        //
        // dtpFechaFin
        //
        dtpFechaFin.Font = new Font("Inter", 10F);
        dtpFechaFin.Format = DateTimePickerFormat.Custom;
        dtpFechaFin.CustomFormat = "dd/MM/yyyy HH:mm";
        dtpFechaFin.MinimumSize = new Size(0, 34);
        dtpFechaFin.Location = new Point(16, 166);
        dtpFechaFin.Name = "dtpFechaFin";
        dtpFechaFin.Size = new Size(426, 34);
        dtpFechaFin.TabIndex = 7;
        //
        // chkConGoce
        //
        chkConGoce.Font = new Font("Inter", 9F);
        chkConGoce.Text = "Permiso con goce de salario";
        chkConGoce.Location = new Point(460, 164);
        chkConGoce.Name = "chkConGoce";
        chkConGoce.Size = new Size(426, 36);
        chkConGoce.TabIndex = 8;
        //
        // lblMotivo
        //
        lblMotivo.AutoSize = false;
        lblMotivo.BackColor = Color.Transparent;
        lblMotivo.ForeColor = Color.FromArgb(64, 64, 64);
        lblMotivo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblMotivo.TextAlign = ContentAlignment.MiddleLeft;
        lblMotivo.Text = "Motivo";
        lblMotivo.Location = new Point(16, 210);
        lblMotivo.Name = "lblMotivo";
        lblMotivo.Size = new Size(870, 24);
        lblMotivo.TabIndex = 9;
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
        txtMotivo.Location = new Point(16, 236);
        txtMotivo.Name = "txtMotivo";
        txtMotivo.Size = new Size(870, 80);
        txtMotivo.TabIndex = 10;
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
        btnGuardar.TabIndex = 11;
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
        btnCancelar.TabIndex = 12;
        notificador.OwnerForm = this;
        //
        // FrmPermisoLaboral
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblEmpleado);
        Controls.Add(cboEmpleado);
        Controls.Add(lblFechaInicio);
        Controls.Add(dtpFechaInicio);
        Controls.Add(lblFechaFin);
        Controls.Add(dtpFechaFin);
        Controls.Add(chkConGoce);
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
        Name = "FrmPermisoLaboral";
        Text = "Solicitar o editar permiso laboral";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KComboBox cboEmpleado;
    private KovaqsUI.Controls.KLabel lblFechaInicio;
    private DateTimePicker dtpFechaInicio;
    private KovaqsUI.Controls.KLabel lblFechaFin;
    private DateTimePicker dtpFechaFin;
    private KovaqsUI.Controls.KCheckBox chkConGoce;
    private KovaqsUI.Controls.KLabel lblMotivo;
    private KovaqsUI.Controls.KTextBox txtMotivo;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
