namespace Presentacion.Forms.SubForms.Nomina;

partial class FrmMovimientoNomina
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
        lblTipo = new KovaqsUI.Controls.KLabel();
        cboTipo = new KovaqsUI.Controls.KComboBox();
        lblConcepto = new KovaqsUI.Controls.KLabel();
        txtConcepto = new KovaqsUI.Controls.KTextBox();
        lblCantidad = new KovaqsUI.Controls.KLabel();
        numCantidad = new KovaqsUI.Controls.KNumericUpDown();
        lblImporte = new KovaqsUI.Controls.KLabel();
        numImporte = new KovaqsUI.Controls.KNumericUpDown();
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
        lblTitulo.Text = "Agregar o editar movimiento";
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
        // lblTipo
        //
        lblTipo.AutoSize = false;
        lblTipo.BackColor = Color.Transparent;
        lblTipo.ForeColor = Color.FromArgb(64, 64, 64);
        lblTipo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTipo.TextAlign = ContentAlignment.MiddleLeft;
        lblTipo.Text = "Tipo de movimiento";
        lblTipo.Location = new Point(16, 70);
        lblTipo.Font = new Font("Inter", 9F);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new Size(426, 24);
        lblTipo.TabIndex = 2;
        lblTipo.TabStop = false;
        //
        // cboTipo
        //
        cboTipo.Font = new Font("Inter", 9F);
        cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTipo.FormattingEnabled = true;
        cboTipo.Items.AddRange(new object[] { "Ingreso", "Deducción" });
        cboTipo.Location = new Point(16, 96);
        cboTipo.CornerRadius = 8;
        cboTipo.FillColor = Color.White;
        cboTipo.ForeColor = Color.FromArgb(32, 38, 45);
        cboTipo.BorderColor = Color.FromArgb(218, 218, 218);
        cboTipo.GradientColor = Color.Empty;

        cboTipo.Name = "cboTipo";
        cboTipo.Size = new Size(426, 34);
        cboTipo.TabIndex = 4;
        //
        // lblConcepto
        //
        lblConcepto.AutoSize = false;
        lblConcepto.BackColor = Color.Transparent;
        lblConcepto.ForeColor = Color.FromArgb(64, 64, 64);
        lblConcepto.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblConcepto.TextAlign = ContentAlignment.MiddleLeft;
        lblConcepto.Text = "Concepto";
        lblConcepto.Location = new Point(460, 70);
        lblConcepto.Font = new Font("Inter", 9F);
        lblConcepto.Name = "lblConcepto";
        lblConcepto.Size = new Size(426, 24);
        lblConcepto.TabIndex = 3;
        lblConcepto.TabStop = false;
        //
        // txtConcepto
        //
        txtConcepto.BackColor = Color.Transparent;
        txtConcepto.CornerRadius = 8;
        txtConcepto.Font = new Font("Inter", 9F);
        txtConcepto.Padding = new Padding(10, 6, 10, 6);
        txtConcepto.MaxLength = 150;
        txtConcepto.Location = new Point(460, 96);
        txtConcepto.FillColor = Color.White;
        txtConcepto.ForeColor = Color.FromArgb(32, 38, 45);
        txtConcepto.BorderColor = Color.FromArgb(218, 218, 218);
        txtConcepto.GradientColor = Color.Empty;
        txtConcepto.BorderThickness = 1;
        txtConcepto.Name = "txtConcepto";
        txtConcepto.Size = new Size(426, 34);
        txtConcepto.TabIndex = 5;
        //
        // lblCantidad
        //
        lblCantidad.AutoSize = false;
        lblCantidad.BackColor = Color.Transparent;
        lblCantidad.ForeColor = Color.FromArgb(64, 64, 64);
        lblCantidad.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblCantidad.TextAlign = ContentAlignment.MiddleLeft;
        lblCantidad.Text = "Cantidad";
        lblCantidad.Location = new Point(16, 140);
        lblCantidad.Font = new Font("Inter", 9F);
        lblCantidad.Name = "lblCantidad";
        lblCantidad.Size = new Size(426, 24);
        lblCantidad.TabIndex = 6;
        lblCantidad.TabStop = false;
        //
        // numCantidad
        //
        numCantidad.Font = new Font("Inter", 9F);
        numCantidad.Maximum = 99999999.99m;
        numCantidad.DecimalPlaces = 2;
        numCantidad.Value = 1m;
        numCantidad.Location = new Point(16, 166);
        numCantidad.ForeColor = Color.FromArgb(64, 64, 64);

        numCantidad.Name = "numCantidad";
        numCantidad.Size = new Size(426, 34);
        numCantidad.TabIndex = 8;
        //
        // lblImporte
        //
        lblImporte.AutoSize = false;
        lblImporte.BackColor = Color.Transparent;
        lblImporte.ForeColor = Color.FromArgb(64, 64, 64);
        lblImporte.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblImporte.TextAlign = ContentAlignment.MiddleLeft;
        lblImporte.Text = "Importe total (Q)";
        lblImporte.Location = new Point(460, 140);
        lblImporte.Font = new Font("Inter", 9F);
        lblImporte.Name = "lblImporte";
        lblImporte.Size = new Size(426, 24);
        lblImporte.TabIndex = 7;
        lblImporte.TabStop = false;
        //
        // numImporte
        //
        numImporte.Font = new Font("Inter", 9F);
        numImporte.Maximum = 99999999.99m;
        numImporte.DecimalPlaces = 2;
        numImporte.Location = new Point(460, 166);
        numImporte.ForeColor = Color.FromArgb(64, 64, 64);

        numImporte.Name = "numImporte";
        numImporte.Size = new Size(426, 34);
        numImporte.TabIndex = 9;
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
        // FrmMovimientoNomina
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblTipo);
        Controls.Add(cboTipo);
        Controls.Add(lblConcepto);
        Controls.Add(txtConcepto);
        Controls.Add(lblCantidad);
        Controls.Add(numCantidad);
        Controls.Add(lblImporte);
        Controls.Add(numImporte);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancelar;
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmMovimientoNomina";
        Text = "Agregar o editar movimiento";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblTipo;
    private KovaqsUI.Controls.KComboBox cboTipo;
    private KovaqsUI.Controls.KLabel lblConcepto;
    private KovaqsUI.Controls.KTextBox txtConcepto;
    private KovaqsUI.Controls.KLabel lblCantidad;
    private KovaqsUI.Controls.KNumericUpDown numCantidad;
    private KovaqsUI.Controls.KLabel lblImporte;
    private KovaqsUI.Controls.KNumericUpDown numImporte;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private KovaqsUI.Components.KToastNotifier notificador;
}
