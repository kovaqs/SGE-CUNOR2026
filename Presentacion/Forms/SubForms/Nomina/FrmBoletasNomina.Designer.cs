namespace Presentacion.Forms.SubForms.Nomina;

partial class FrmBoletasNomina
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
        lblPeriodo = new KovaqsUI.Controls.KLabel();
        cboPeriodo = new KovaqsUI.Controls.KComboBox();
        lblDepartamento = new KovaqsUI.Controls.KLabel();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        lblDestino = new KovaqsUI.Controls.KLabel();
        txtDestino = new KovaqsUI.Controls.KTextBox();
        btnSeleccionarDestino = new KovaqsUI.Controls.KButton();
        btnGenerarPdf = new KovaqsUI.Controls.KButton();
        dlgGuardarPdf = new SaveFileDialog();
        components.Add(dlgGuardarPdf);
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
        lblTitulo.Text = "Emitir boletas por departamento";
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
        // lblPeriodo
        //
        lblPeriodo.AutoSize = false;
        lblPeriodo.BackColor = Color.Transparent;
        lblPeriodo.ForeColor = Color.FromArgb(64, 64, 64);
        lblPeriodo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPeriodo.TextAlign = ContentAlignment.MiddleLeft;
        lblPeriodo.Text = "Período de nómina";
        lblPeriodo.Location = new Point(16, 70);
        lblPeriodo.Name = "lblPeriodo";
        lblPeriodo.Size = new Size(426, 24);
        lblPeriodo.TabIndex = 2;
        lblPeriodo.TabStop = false;
        //
        // cboPeriodo
        //
        cboPeriodo.Font = new Font("Inter", 9F);
        cboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPeriodo.FormattingEnabled = true;
        cboPeriodo.Location = new Point(16, 96);
        cboPeriodo.Name = "cboPeriodo";
        cboPeriodo.Size = new Size(426, 34);
        cboPeriodo.TabIndex = 3;
        //
        // lblDepartamento
        //
        lblDepartamento.AutoSize = false;
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
        lblDepartamento.Text = "Departamento";
        lblDepartamento.Location = new Point(460, 70);
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(426, 24);
        lblDepartamento.TabIndex = 4;
        lblDepartamento.TabStop = false;
        //
        // cboDepartamento
        //
        cboDepartamento.Font = new Font("Inter", 9F);
        cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.Items.AddRange(new object[] { "Todos" });
        cboDepartamento.Location = new Point(460, 96);
        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(426, 34);
        cboDepartamento.TabIndex = 5;
        //
        // lblDestino
        //
        lblDestino.AutoSize = false;
        lblDestino.BackColor = Color.Transparent;
        lblDestino.ForeColor = Color.FromArgb(64, 64, 64);
        lblDestino.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDestino.TextAlign = ContentAlignment.MiddleLeft;
        lblDestino.Text = "Guardar archivo PDF";
        lblDestino.Location = new Point(16, 140);
        lblDestino.Name = "lblDestino";
        lblDestino.Size = new Size(426, 24);
        lblDestino.TabIndex = 6;
        lblDestino.TabStop = false;
        //
        // txtDestino
        //
        txtDestino.BackColor = Color.Transparent;
        txtDestino.CornerRadius = 8;
        txtDestino.Font = new Font("Inter", 9F);
        txtDestino.Padding = new Padding(10, 6, 10, 6);
        txtDestino.ReadOnly = true;
        txtDestino.MaxLength = 100;
        txtDestino.Location = new Point(16, 166);
        txtDestino.Name = "txtDestino";
        txtDestino.Size = new Size(426, 34);
        txtDestino.TabIndex = 7;
        //
        // btnSeleccionarDestino
        //
        btnSeleccionarDestino.BackColor = Color.Transparent;
        btnSeleccionarDestino.CornerRadius = 8;
        btnSeleccionarDestino.FlatStyle = FlatStyle.Flat;
        btnSeleccionarDestino.Font = new Font("Inter", 9F);
        btnSeleccionarDestino.Padding = new Padding(10, 4, 10, 4);
        btnSeleccionarDestino.UseVisualStyleBackColor = false;
        btnSeleccionarDestino.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        btnSeleccionarDestino.Text = "Elegir destino";
        btnSeleccionarDestino.FillColor = Color.FromArgb(32, 38, 45);
        btnSeleccionarDestino.ForeColor = Color.White;
        btnSeleccionarDestino.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnSeleccionarDestino.Appearance.Normal.ForeColor = Color.White;
        btnSeleccionarDestino.Location = new Point(16, 218);
        btnSeleccionarDestino.Name = "btnSeleccionarDestino";
        btnSeleccionarDestino.Size = new Size(220, 40);
        btnSeleccionarDestino.TabIndex = 8;
        //
        // btnGenerarPdf
        //
        btnGenerarPdf.BackColor = Color.Transparent;
        btnGenerarPdf.CornerRadius = 8;
        btnGenerarPdf.FlatStyle = FlatStyle.Flat;
        btnGenerarPdf.Font = new Font("Inter", 9F);
        btnGenerarPdf.Padding = new Padding(10, 4, 10, 4);
        btnGenerarPdf.UseVisualStyleBackColor = false;
        btnGenerarPdf.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnGenerarPdf.Text = "Generar boletas PDF";
        btnGenerarPdf.Location = new Point(248, 218);
        btnGenerarPdf.Name = "btnGenerarPdf";
        btnGenerarPdf.Size = new Size(220, 40);
        btnGenerarPdf.TabIndex = 9;
        dlgGuardarPdf.Filter = "Documentos PDF (*.pdf)|*.pdf";
        dlgGuardarPdf.DefaultExt = "pdf";
        dlgGuardarPdf.AddExtension = true;
        notificador.OwnerForm = this;
        //
        // FrmBoletasNomina
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblPeriodo);
        Controls.Add(cboPeriodo);
        Controls.Add(lblDepartamento);
        Controls.Add(cboDepartamento);
        Controls.Add(lblDestino);
        Controls.Add(txtDestino);
        Controls.Add(btnSeleccionarDestino);
        Controls.Add(btnGenerarPdf);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCerrar;
        Name = "FrmBoletasNomina";
        Text = "Emitir boletas por departamento";
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblPeriodo;
    private KovaqsUI.Controls.KComboBox cboPeriodo;
    private KovaqsUI.Controls.KLabel lblDepartamento;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KLabel lblDestino;
    private KovaqsUI.Controls.KTextBox txtDestino;
    private KovaqsUI.Controls.KButton btnSeleccionarDestino;
    private KovaqsUI.Controls.KButton btnGenerarPdf;
    private SaveFileDialog dlgGuardarPdf;
    private KovaqsUI.Components.KToastNotifier notificador;
}
