namespace Presentacion.Forms.SubForms.Empleados;

partial class FrmHistorialLaboral
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
        btnAcciones = new KovaqsUI.Controls.KButton();
        cmsHistorialLaboral = new ContextMenuStrip(components);
        mnuVerCondicion = new ToolStripMenuItem();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        btnCerrar = new KovaqsUI.Controls.KButton();
        lblEmpleado = new KovaqsUI.Controls.KLabel();
        txtEmpleado = new KovaqsUI.Controls.KTextBox();
        btnNuevaCondicion = new KovaqsUI.Controls.KButton();
        lblHistorialLaboralTitulo = new KovaqsUI.Controls.KLabel();
        dgvHistorialLaboral = new KovaqsUI.Controls.KDataGridView();
        colHistorialLaboralDesde = new DataGridViewTextBoxColumn();
        colHistorialLaboralHasta = new DataGridViewTextBoxColumn();
        colHistorialLaboralPuesto = new DataGridViewTextBoxColumn();
        colHistorialLaboralContrato = new DataGridViewTextBoxColumn();
        colHistorialLaboralHorario = new DataGridViewTextBoxColumn();
        colHistorialLaboralSalario = new DataGridViewTextBoxColumn();
        colHistorialLaboralMotivo = new DataGridViewTextBoxColumn();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvHistorialLaboral).BeginInit();
        SuspendLayout();
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Font = new Font("Inter", 9F);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Text = "Historial laboral del empleado";
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
        // txtEmpleado
        //
        txtEmpleado.BackColor = Color.Transparent;
        txtEmpleado.CornerRadius = 8;
        txtEmpleado.Font = new Font("Inter", 9F);
        txtEmpleado.Padding = new Padding(10, 6, 10, 6);
        txtEmpleado.ReadOnly = true;
        txtEmpleado.MaxLength = 100;
        txtEmpleado.Location = new Point(16, 96);
        txtEmpleado.FillColor = Color.White;
        txtEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
        txtEmpleado.BorderColor = Color.FromArgb(218, 218, 218);
        txtEmpleado.GradientColor = Color.Empty;
        txtEmpleado.BorderThickness = 1;
        txtEmpleado.Name = "txtEmpleado";
        txtEmpleado.Size = new Size(426, 34);
        txtEmpleado.TabIndex = 3;
        //
        // btnNuevaCondicion
        //
        btnNuevaCondicion.BackColor = Color.Transparent;
        btnNuevaCondicion.CornerRadius = 8;
        btnNuevaCondicion.FlatStyle = FlatStyle.Flat;
        btnNuevaCondicion.Font = new Font("Inter", 9F);
        btnNuevaCondicion.Padding = new Padding(10, 4, 10, 4);
        btnNuevaCondicion.UseVisualStyleBackColor = false;
        btnNuevaCondicion.Text = "Cambiar condición";
        btnNuevaCondicion.Location = new Point(16, 144);
        btnNuevaCondicion.BorderThickness = 1;
        btnNuevaCondicion.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnNuevaCondicion.FillColor = Color.FromArgb(49, 81, 107);
        btnNuevaCondicion.ForeColor = Color.White;
        btnNuevaCondicion.BorderColor = Color.FromArgb(49, 81, 107);
        btnNuevaCondicion.GradientColor = Color.Empty;
        btnNuevaCondicion.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnNuevaCondicion.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnNuevaCondicion.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnNuevaCondicion.Name = "btnNuevaCondicion";
        btnNuevaCondicion.Size = new Size(220, 40);
        btnNuevaCondicion.TabIndex = 4;
        //
        // lblHistorialLaboralTitulo
        //
        lblHistorialLaboralTitulo.AutoSize = false;
        lblHistorialLaboralTitulo.BackColor = Color.Transparent;
        lblHistorialLaboralTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblHistorialLaboralTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblHistorialLaboralTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblHistorialLaboralTitulo.Text = "Condiciones laborales";
        lblHistorialLaboralTitulo.Location = new Point(16, 198);
        lblHistorialLaboralTitulo.Font = new Font("Inter", 9F);
        lblHistorialLaboralTitulo.Name = "lblHistorialLaboralTitulo";
        lblHistorialLaboralTitulo.Size = new Size(870, 24);
        lblHistorialLaboralTitulo.TabIndex = 6;
        lblHistorialLaboralTitulo.TabStop = false;
        //
        // dgvHistorialLaboral
        //
        dgvHistorialLaboral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvHistorialLaboral.AllowUserToAddRows = false;
        dgvHistorialLaboral.AllowUserToDeleteRows = false;
        dgvHistorialLaboral.AutoGenerateColumns = false;
        dgvHistorialLaboral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvHistorialLaboral.ReadOnly = true;
        dgvHistorialLaboral.RowHeadersVisible = false;
        dgvHistorialLaboral.MultiSelect = false;
        dgvHistorialLaboral.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHistorialLaboral.BackgroundColor = Color.White;
        dgvHistorialLaboral.BorderStyle = BorderStyle.None;
        dgvHistorialLaboral.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvHistorialLaboral.ColumnHeadersHeight = 42;
        dgvHistorialLaboral.EnableHeadersVisualStyles = false;
        dgvHistorialLaboral.GridColor = Color.FromArgb(218, 218, 218);
        dgvHistorialLaboral.RowTemplate.Height = 42;
        dgvHistorialLaboral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvHistorialLaboral.DefaultCellStyle = dataGridViewCellStyle2;
        dgvHistorialLaboral.Location = new Point(16, 224);
        dgvHistorialLaboral.Font = new Font("Inter", 9F);
        dgvHistorialLaboral.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvHistorialLaboral.Name = "dgvHistorialLaboral";
        dgvHistorialLaboral.Size = new Size(870, 362);
        dgvHistorialLaboral.TabIndex = 7;
        dgvHistorialLaboral.Columns.AddRange(new DataGridViewColumn[] { colHistorialLaboralDesde, colHistorialLaboralHasta, colHistorialLaboralPuesto, colHistorialLaboralContrato, colHistorialLaboralHorario, colHistorialLaboralSalario, colHistorialLaboralMotivo });
        //
        // colHistorialLaboralDesde
        //
        colHistorialLaboralDesde.HeaderText = "Desde";
        colHistorialLaboralDesde.Name = "colHistorialLaboralDesde";
        colHistorialLaboralDesde.ReadOnly = true;
        //
        // colHistorialLaboralHasta
        //
        colHistorialLaboralHasta.HeaderText = "Hasta";
        colHistorialLaboralHasta.Name = "colHistorialLaboralHasta";
        colHistorialLaboralHasta.ReadOnly = true;
        //
        // colHistorialLaboralPuesto
        //
        colHistorialLaboralPuesto.HeaderText = "Puesto";
        colHistorialLaboralPuesto.Name = "colHistorialLaboralPuesto";
        colHistorialLaboralPuesto.ReadOnly = true;
        //
        // colHistorialLaboralContrato
        //
        colHistorialLaboralContrato.HeaderText = "Contrato";
        colHistorialLaboralContrato.Name = "colHistorialLaboralContrato";
        colHistorialLaboralContrato.ReadOnly = true;
        //
        // colHistorialLaboralHorario
        //
        colHistorialLaboralHorario.HeaderText = "Horario";
        colHistorialLaboralHorario.Name = "colHistorialLaboralHorario";
        colHistorialLaboralHorario.ReadOnly = true;
        //
        // colHistorialLaboralSalario
        //
        colHistorialLaboralSalario.HeaderText = "Salario";
        colHistorialLaboralSalario.Name = "colHistorialLaboralSalario";
        colHistorialLaboralSalario.ReadOnly = true;
        //
        // colHistorialLaboralMotivo
        //
        colHistorialLaboralMotivo.HeaderText = "Motivo";
        colHistorialLaboralMotivo.Name = "colHistorialLaboralMotivo";
        colHistorialLaboralMotivo.ReadOnly = true;
        notificador.OwnerForm = this;
        btnAcciones.BackColor = Color.Transparent;
        btnAcciones.CornerRadius = 8;
        btnAcciones.FlatStyle = FlatStyle.Flat;
        btnAcciones.Font = new Font("Inter", 9F);
        btnAcciones.Padding = new Padding(10, 4, 10, 4);
        btnAcciones.UseVisualStyleBackColor = false;
        btnAcciones.Text = "Acciones ▾";
        btnAcciones.Location = new Point(248, 144);
        btnAcciones.BorderThickness = 1;
        btnAcciones.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnAcciones.FillColor = Color.White;
        btnAcciones.ForeColor = Color.FromArgb(49, 81, 107);
        btnAcciones.BorderColor = Color.FromArgb(173, 190, 204);
        btnAcciones.GradientColor = Color.Empty;
        btnAcciones.Appearance.Hover.FillColor = Color.FromArgb(239, 244, 248);
        btnAcciones.Appearance.Pressed.FillColor = Color.FromArgb(225, 235, 243);
        btnAcciones.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnAcciones.Name = "btnAcciones";
        btnAcciones.Size = new Size(220, 40);
        btnAcciones.TabIndex = 5;
        btnAcciones.Click += btnAcciones_Click;
        btnAcciones.Enabled = false;
        //
        // cmsHistorialLaboral
        //
        cmsHistorialLaboral.SuspendLayout();
        cmsHistorialLaboral.Items.AddRange(new ToolStripItem[] { mnuVerCondicion });
        cmsHistorialLaboral.Name = "cmsHistorialLaboral";
        cmsHistorialLaboral.Font = new Font("Inter", 9F);
        cmsHistorialLaboral.ShowImageMargin = false;
        cmsHistorialLaboral.Opening += cmsHistorialLaboral_Opening;
        //
        // mnuVerCondicion
        //
        mnuVerCondicion.Name = "mnuVerCondicion";
        mnuVerCondicion.Text = "Ver condición";
        mnuVerCondicion.ForeColor = Color.FromArgb(32, 38, 45);
        dgvHistorialLaboral.ContextMenuStrip = cmsHistorialLaboral;
        dgvHistorialLaboral.MouseDown += dgvHistorialLaboral_MouseDown;
        dgvHistorialLaboral.SelectionChanged += dgvHistorialLaboral_SelectionChanged;
        dgvHistorialLaboral.CellDoubleClick += dgvHistorialLaboral_CellDoubleClick;
        Controls.Add(btnAcciones);
        cmsHistorialLaboral.ResumeLayout(false);
        //
        // FrmHistorialLaboral
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblEmpleado);
        Controls.Add(txtEmpleado);
        Controls.Add(btnNuevaCondicion);
        Controls.Add(lblHistorialLaboralTitulo);
        Controls.Add(dgvHistorialLaboral);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCerrar;
        Font = new Font("Segoe UI", 9F);
        Name = "FrmHistorialLaboral";
        Text = "Historial laboral del empleado";
        ((System.ComponentModel.ISupportInitialize)dgvHistorialLaboral).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KButton btnAcciones;
    private ContextMenuStrip cmsHistorialLaboral;
    private ToolStripMenuItem mnuVerCondicion;

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KTextBox txtEmpleado;
    private KovaqsUI.Controls.KButton btnNuevaCondicion;
    private KovaqsUI.Controls.KLabel lblHistorialLaboralTitulo;
    private KovaqsUI.Controls.KDataGridView dgvHistorialLaboral;
    private DataGridViewTextBoxColumn colHistorialLaboralDesde;
    private DataGridViewTextBoxColumn colHistorialLaboralHasta;
    private DataGridViewTextBoxColumn colHistorialLaboralPuesto;
    private DataGridViewTextBoxColumn colHistorialLaboralContrato;
    private DataGridViewTextBoxColumn colHistorialLaboralHorario;
    private DataGridViewTextBoxColumn colHistorialLaboralSalario;
    private DataGridViewTextBoxColumn colHistorialLaboralMotivo;
    private KovaqsUI.Components.KToastNotifier notificador;
}
