namespace Presentacion.Forms.SubForms.Empleados;

partial class FrmEstadoEmpleado
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
        lblEstadoFiltro = new KovaqsUI.Controls.KLabel();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        lblFechaBaja = new KovaqsUI.Controls.KLabel();
        dtpFechaBaja = new DateTimePicker();
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
        lblTitulo.Text = "Cambiar estado del empleado";
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
        // lblEstadoFiltro
        //
        lblEstadoFiltro.AutoSize = false;
        lblEstadoFiltro.BackColor = Color.Transparent;
        lblEstadoFiltro.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoFiltro.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEstadoFiltro.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoFiltro.Text = "Estado del empleado";
        lblEstadoFiltro.Location = new Point(460, 70);
        lblEstadoFiltro.Name = "lblEstadoFiltro";
        lblEstadoFiltro.Size = new Size(426, 24);
        lblEstadoFiltro.TabIndex = 4;
        lblEstadoFiltro.TabStop = false;
        //
        // cboEstado
        //
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEstado.FormattingEnabled = true;
        cboEstado.Items.AddRange(new object[] { "Activo", "Suspendido", "Inactivo" });
        cboEstado.Location = new Point(460, 96);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(426, 34);
        cboEstado.TabIndex = 5;
        //
        // lblFechaBaja
        //
        lblFechaBaja.AutoSize = false;
        lblFechaBaja.BackColor = Color.Transparent;
        lblFechaBaja.ForeColor = Color.FromArgb(64, 64, 64);
        lblFechaBaja.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblFechaBaja.TextAlign = ContentAlignment.MiddleLeft;
        lblFechaBaja.Text = "Fecha de baja";
        lblFechaBaja.Location = new Point(16, 140);
        lblFechaBaja.Name = "lblFechaBaja";
        lblFechaBaja.Size = new Size(426, 24);
        lblFechaBaja.TabIndex = 6;
        lblFechaBaja.TabStop = false;
        //
        // dtpFechaBaja
        //
        dtpFechaBaja.Font = new Font("Inter", 10F);
        dtpFechaBaja.Format = DateTimePickerFormat.Custom;
        dtpFechaBaja.CustomFormat = "dd/MM/yyyy";
        dtpFechaBaja.MinimumSize = new Size(0, 34);
        dtpFechaBaja.ShowCheckBox = true;
        dtpFechaBaja.Checked = false;
        dtpFechaBaja.Location = new Point(16, 166);
        dtpFechaBaja.Name = "dtpFechaBaja";
        dtpFechaBaja.Size = new Size(426, 34);
        dtpFechaBaja.TabIndex = 7;
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
        btnGuardar.TabIndex = 8;
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
        btnCancelar.TabIndex = 9;
        notificador.OwnerForm = this;
        //
        // FrmEstadoEmpleado
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblEmpleado);
        Controls.Add(txtEmpleado);
        Controls.Add(lblEstadoFiltro);
        Controls.Add(cboEstado);
        Controls.Add(lblFechaBaja);
        Controls.Add(dtpFechaBaja);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancelar;
        Name = "FrmEstadoEmpleado";
        Text = "Cambiar estado del empleado";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KTextBox txtEmpleado;
    private KovaqsUI.Controls.KLabel lblEstadoFiltro;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KLabel lblFechaBaja;
    private DateTimePicker dtpFechaBaja;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
