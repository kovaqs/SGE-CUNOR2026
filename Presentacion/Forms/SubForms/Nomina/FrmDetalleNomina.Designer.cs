namespace Presentacion.Forms.SubForms.Nomina;

partial class FrmDetalleNomina
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        btnCerrar = new KovaqsUI.Controls.KButton();
        lblEmpleado = new KovaqsUI.Controls.KLabel();
        txtEmpleado = new KovaqsUI.Controls.KTextBox();
        lblPeriodo = new KovaqsUI.Controls.KLabel();
        txtPeriodo = new KovaqsUI.Controls.KTextBox();
        lblPuesto = new KovaqsUI.Controls.KLabel();
        txtPuesto = new KovaqsUI.Controls.KTextBox();
        lblSalarioBase = new KovaqsUI.Controls.KLabel();
        txtSalarioBase = new KovaqsUI.Controls.KTextBox();
        lblDiasPagados = new KovaqsUI.Controls.KLabel();
        txtDiasPagados = new KovaqsUI.Controls.KTextBox();
        lblDepartamento = new KovaqsUI.Controls.KLabel();
        txtDepartamento = new KovaqsUI.Controls.KTextBox();
        lblMovimientosTitulo = new KovaqsUI.Controls.KLabel();
        dgvMovimientos = new KovaqsUI.Controls.KDataGridView();
        lblTotalIngresos = new KovaqsUI.Controls.KLabel();
        lblTotalDeducciones = new KovaqsUI.Controls.KLabel();
        lblNeto = new KovaqsUI.Controls.KLabel();
        btnAgregarMovimiento = new KovaqsUI.Controls.KButton();
        btnEditarMovimiento = new KovaqsUI.Controls.KButton();
        btnEliminarMovimiento = new KovaqsUI.Controls.KButton();
        btnExportarBoleta = new KovaqsUI.Controls.KButton();
        colMovimientosTipo = new DataGridViewTextBoxColumn();
        colMovimientosConcepto = new DataGridViewTextBoxColumn();
        colMovimientosCantidad = new DataGridViewTextBoxColumn();
        colMovimientosImportetotal = new DataGridViewTextBoxColumn();
        dlgGuardarBoleta = new SaveFileDialog();
        components.Add(dlgGuardarBoleta);
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
        SuspendLayout();
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 233, 249);
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
        lblTitulo.Text = "Detalle individual y movimientos";
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
        lblEmpleado.Size = new Size(278, 24);
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
        txtEmpleado.Size = new Size(278, 34);
        txtEmpleado.TabIndex = 3;
        //
        // lblPeriodo
        //
        lblPeriodo.AutoSize = false;
        lblPeriodo.BackColor = Color.Transparent;
        lblPeriodo.ForeColor = Color.FromArgb(64, 64, 64);
        lblPeriodo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPeriodo.TextAlign = ContentAlignment.MiddleLeft;
        lblPeriodo.Text = "Período";
        lblPeriodo.Location = new Point(312, 70);
        lblPeriodo.Name = "lblPeriodo";
        lblPeriodo.Size = new Size(278, 24);
        lblPeriodo.TabIndex = 4;
        lblPeriodo.TabStop = false;
        //
        // txtPeriodo
        //
        txtPeriodo.BackColor = Color.Transparent;
        txtPeriodo.CornerRadius = 8;
        txtPeriodo.Font = new Font("Inter", 9F);
        txtPeriodo.Padding = new Padding(10, 6, 10, 6);
        txtPeriodo.ReadOnly = true;
        txtPeriodo.MaxLength = 100;
        txtPeriodo.Location = new Point(312, 96);
        txtPeriodo.Name = "txtPeriodo";
        txtPeriodo.Size = new Size(278, 34);
        txtPeriodo.TabIndex = 5;
        //
        // lblPuesto
        //
        lblPuesto.AutoSize = false;
        lblPuesto.BackColor = Color.Transparent;
        lblPuesto.ForeColor = Color.FromArgb(64, 64, 64);
        lblPuesto.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPuesto.TextAlign = ContentAlignment.MiddleLeft;
        lblPuesto.Text = "Puesto del período";
        lblPuesto.Location = new Point(608, 70);
        lblPuesto.Name = "lblPuesto";
        lblPuesto.Size = new Size(278, 24);
        lblPuesto.TabIndex = 6;
        lblPuesto.TabStop = false;
        //
        // txtPuesto
        //
        txtPuesto.BackColor = Color.Transparent;
        txtPuesto.CornerRadius = 8;
        txtPuesto.Font = new Font("Inter", 9F);
        txtPuesto.Padding = new Padding(10, 6, 10, 6);
        txtPuesto.ReadOnly = true;
        txtPuesto.MaxLength = 100;
        txtPuesto.Location = new Point(608, 96);
        txtPuesto.Name = "txtPuesto";
        txtPuesto.Size = new Size(278, 34);
        txtPuesto.TabIndex = 7;
        //
        // lblSalarioBase
        //
        lblSalarioBase.AutoSize = false;
        lblSalarioBase.BackColor = Color.Transparent;
        lblSalarioBase.ForeColor = Color.FromArgb(64, 64, 64);
        lblSalarioBase.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblSalarioBase.TextAlign = ContentAlignment.MiddleLeft;
        lblSalarioBase.Text = "Salario base (Q)";
        lblSalarioBase.Location = new Point(16, 140);
        lblSalarioBase.Name = "lblSalarioBase";
        lblSalarioBase.Size = new Size(278, 24);
        lblSalarioBase.TabIndex = 8;
        lblSalarioBase.TabStop = false;
        //
        // txtSalarioBase
        //
        txtSalarioBase.BackColor = Color.Transparent;
        txtSalarioBase.CornerRadius = 8;
        txtSalarioBase.Font = new Font("Inter", 9F);
        txtSalarioBase.Padding = new Padding(10, 6, 10, 6);
        txtSalarioBase.ReadOnly = true;
        txtSalarioBase.MaxLength = 100;
        txtSalarioBase.Location = new Point(16, 166);
        txtSalarioBase.Name = "txtSalarioBase";
        txtSalarioBase.Size = new Size(278, 34);
        txtSalarioBase.TabIndex = 9;
        //
        // lblDiasPagados
        //
        lblDiasPagados.AutoSize = false;
        lblDiasPagados.BackColor = Color.Transparent;
        lblDiasPagados.ForeColor = Color.FromArgb(64, 64, 64);
        lblDiasPagados.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDiasPagados.TextAlign = ContentAlignment.MiddleLeft;
        lblDiasPagados.Text = "Días pagados";
        lblDiasPagados.Location = new Point(312, 140);
        lblDiasPagados.Name = "lblDiasPagados";
        lblDiasPagados.Size = new Size(278, 24);
        lblDiasPagados.TabIndex = 10;
        lblDiasPagados.TabStop = false;
        //
        // txtDiasPagados
        //
        txtDiasPagados.BackColor = Color.Transparent;
        txtDiasPagados.CornerRadius = 8;
        txtDiasPagados.Font = new Font("Inter", 9F);
        txtDiasPagados.Padding = new Padding(10, 6, 10, 6);
        txtDiasPagados.ReadOnly = true;
        txtDiasPagados.MaxLength = 100;
        txtDiasPagados.Location = new Point(312, 166);
        txtDiasPagados.Name = "txtDiasPagados";
        txtDiasPagados.Size = new Size(278, 34);
        txtDiasPagados.TabIndex = 11;
        //
        // lblDepartamento
        //
        lblDepartamento.AutoSize = false;
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
        lblDepartamento.Text = "Departamento del período";
        lblDepartamento.Location = new Point(608, 140);
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(278, 24);
        lblDepartamento.TabIndex = 12;
        lblDepartamento.TabStop = false;
        //
        // txtDepartamento
        //
        txtDepartamento.BackColor = Color.Transparent;
        txtDepartamento.CornerRadius = 8;
        txtDepartamento.Font = new Font("Inter", 9F);
        txtDepartamento.Padding = new Padding(10, 6, 10, 6);
        txtDepartamento.ReadOnly = true;
        txtDepartamento.MaxLength = 100;
        txtDepartamento.Location = new Point(608, 166);
        txtDepartamento.Name = "txtDepartamento";
        txtDepartamento.Size = new Size(278, 34);
        txtDepartamento.TabIndex = 13;
        //
        // lblMovimientosTitulo
        //
        lblMovimientosTitulo.AutoSize = false;
        lblMovimientosTitulo.BackColor = Color.Transparent;
        lblMovimientosTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblMovimientosTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblMovimientosTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblMovimientosTitulo.Text = "Ingresos y deducciones";
        lblMovimientosTitulo.Location = new Point(16, 212);
        lblMovimientosTitulo.Name = "lblMovimientosTitulo";
        lblMovimientosTitulo.Size = new Size(870, 24);
        lblMovimientosTitulo.TabIndex = 14;
        lblMovimientosTitulo.TabStop = false;
        //
        // dgvMovimientos
        //
        dgvMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvMovimientos.AllowUserToAddRows = false;
        dgvMovimientos.AllowUserToDeleteRows = false;
        dgvMovimientos.AutoGenerateColumns = false;
        dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvMovimientos.ReadOnly = true;
        dgvMovimientos.RowHeadersVisible = false;
        dgvMovimientos.MultiSelect = false;
        dgvMovimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvMovimientos.BackgroundColor = Color.White;
        dgvMovimientos.BorderStyle = BorderStyle.None;
        dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvMovimientos.ColumnHeadersHeight = 42;
        dgvMovimientos.EnableHeadersVisualStyles = false;
        dgvMovimientos.GridColor = Color.FromArgb(218, 218, 218);
        dgvMovimientos.RowTemplate.Height = 42;
        dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle2;
        dgvMovimientos.Location = new Point(16, 238);
        dgvMovimientos.Name = "dgvMovimientos";
        dgvMovimientos.Size = new Size(870, 284);
        dgvMovimientos.TabIndex = 15;
        dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { colMovimientosTipo, colMovimientosConcepto, colMovimientosCantidad, colMovimientosImportetotal });
        //
        // lblTotalIngresos
        //
        lblTotalIngresos.AutoSize = false;
        lblTotalIngresos.BackColor = Color.Transparent;
        lblTotalIngresos.ForeColor = Color.FromArgb(64, 64, 64);
        lblTotalIngresos.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTotalIngresos.TextAlign = ContentAlignment.MiddleLeft;
        lblTotalIngresos.Text = "Total ingresos: Q 0.00";
        lblTotalIngresos.Font = new Font("Inter", 9F, FontStyle.Bold);
        lblTotalIngresos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTotalIngresos.Location = new Point(16, 536);
        lblTotalIngresos.Name = "lblTotalIngresos";
        lblTotalIngresos.Size = new Size(278, 30);
        lblTotalIngresos.TabIndex = 16;
        lblTotalIngresos.TabStop = false;
        //
        // lblTotalDeducciones
        //
        lblTotalDeducciones.AutoSize = false;
        lblTotalDeducciones.BackColor = Color.Transparent;
        lblTotalDeducciones.ForeColor = Color.FromArgb(64, 64, 64);
        lblTotalDeducciones.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTotalDeducciones.TextAlign = ContentAlignment.MiddleLeft;
        lblTotalDeducciones.Text = "Total deducciones: Q 0.00";
        lblTotalDeducciones.Font = new Font("Inter", 9F, FontStyle.Bold);
        lblTotalDeducciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTotalDeducciones.Location = new Point(306, 536);
        lblTotalDeducciones.Name = "lblTotalDeducciones";
        lblTotalDeducciones.Size = new Size(278, 30);
        lblTotalDeducciones.TabIndex = 17;
        lblTotalDeducciones.TabStop = false;
        //
        // lblNeto
        //
        lblNeto.AutoSize = false;
        lblNeto.BackColor = Color.Transparent;
        lblNeto.ForeColor = Color.FromArgb(64, 64, 64);
        lblNeto.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNeto.TextAlign = ContentAlignment.MiddleLeft;
        lblNeto.Text = "Neto a pagar: Q 0.00";
        lblNeto.Font = new Font("Inter", 9F, FontStyle.Bold);
        lblNeto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblNeto.Location = new Point(596, 536);
        lblNeto.Name = "lblNeto";
        lblNeto.Size = new Size(278, 30);
        lblNeto.TabIndex = 18;
        lblNeto.TabStop = false;
        //
        // btnAgregarMovimiento
        //
        btnAgregarMovimiento.BackColor = Color.Transparent;
        btnAgregarMovimiento.CornerRadius = 8;
        btnAgregarMovimiento.FlatStyle = FlatStyle.Flat;
        btnAgregarMovimiento.Font = new Font("Inter", 9F);
        btnAgregarMovimiento.Padding = new Padding(10, 4, 10, 4);
        btnAgregarMovimiento.UseVisualStyleBackColor = false;
        btnAgregarMovimiento.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        btnAgregarMovimiento.Text = "Agregar movimiento";
        btnAgregarMovimiento.FillColor = Color.FromArgb(32, 38, 45);
        btnAgregarMovimiento.ForeColor = Color.White;
        btnAgregarMovimiento.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnAgregarMovimiento.Appearance.Normal.ForeColor = Color.White;
        btnAgregarMovimiento.Location = new Point(16, 582);
        btnAgregarMovimiento.Name = "btnAgregarMovimiento";
        btnAgregarMovimiento.Size = new Size(208, 40);
        btnAgregarMovimiento.TabIndex = 19;
        //
        // btnEditarMovimiento
        //
        btnEditarMovimiento.BackColor = Color.Transparent;
        btnEditarMovimiento.CornerRadius = 8;
        btnEditarMovimiento.FlatStyle = FlatStyle.Flat;
        btnEditarMovimiento.Font = new Font("Inter", 9F);
        btnEditarMovimiento.Padding = new Padding(10, 4, 10, 4);
        btnEditarMovimiento.UseVisualStyleBackColor = false;
        btnEditarMovimiento.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnEditarMovimiento.Text = "Editar movimiento";
        btnEditarMovimiento.Location = new Point(236, 582);
        btnEditarMovimiento.Name = "btnEditarMovimiento";
        btnEditarMovimiento.Size = new Size(208, 40);
        btnEditarMovimiento.TabIndex = 20;
        //
        // btnEliminarMovimiento
        //
        btnEliminarMovimiento.BackColor = Color.Transparent;
        btnEliminarMovimiento.CornerRadius = 8;
        btnEliminarMovimiento.FlatStyle = FlatStyle.Flat;
        btnEliminarMovimiento.Font = new Font("Inter", 9F);
        btnEliminarMovimiento.Padding = new Padding(10, 4, 10, 4);
        btnEliminarMovimiento.UseVisualStyleBackColor = false;
        btnEliminarMovimiento.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnEliminarMovimiento.Text = "Eliminar movimiento";
        btnEliminarMovimiento.Location = new Point(456, 582);
        btnEliminarMovimiento.Name = "btnEliminarMovimiento";
        btnEliminarMovimiento.Size = new Size(208, 40);
        btnEliminarMovimiento.TabIndex = 21;
        //
        // btnExportarBoleta
        //
        btnExportarBoleta.BackColor = Color.Transparent;
        btnExportarBoleta.CornerRadius = 8;
        btnExportarBoleta.FlatStyle = FlatStyle.Flat;
        btnExportarBoleta.Font = new Font("Inter", 9F);
        btnExportarBoleta.Padding = new Padding(10, 4, 10, 4);
        btnExportarBoleta.UseVisualStyleBackColor = false;
        btnExportarBoleta.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnExportarBoleta.Text = "Exportar boleta";
        btnExportarBoleta.Location = new Point(676, 582);
        btnExportarBoleta.Name = "btnExportarBoleta";
        btnExportarBoleta.Size = new Size(208, 40);
        btnExportarBoleta.TabIndex = 22;
        //
        // colMovimientosTipo
        //
        colMovimientosTipo.HeaderText = "Tipo";
        colMovimientosTipo.Name = "colMovimientosTipo";
        colMovimientosTipo.ReadOnly = true;
        //
        // colMovimientosConcepto
        //
        colMovimientosConcepto.HeaderText = "Concepto";
        colMovimientosConcepto.Name = "colMovimientosConcepto";
        colMovimientosConcepto.ReadOnly = true;
        //
        // colMovimientosCantidad
        //
        colMovimientosCantidad.HeaderText = "Cantidad";
        colMovimientosCantidad.Name = "colMovimientosCantidad";
        colMovimientosCantidad.ReadOnly = true;
        //
        // colMovimientosImportetotal
        //
        colMovimientosImportetotal.HeaderText = "Importe total";
        colMovimientosImportetotal.Name = "colMovimientosImportetotal";
        colMovimientosImportetotal.ReadOnly = true;
        dlgGuardarBoleta.Filter = "Documentos PDF (*.pdf)|*.pdf";
        dlgGuardarBoleta.DefaultExt = "pdf";
        dlgGuardarBoleta.AddExtension = true;
        notificador.OwnerForm = this;
        //
        // FrmDetalleNomina
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblEmpleado);
        Controls.Add(txtEmpleado);
        Controls.Add(lblPeriodo);
        Controls.Add(txtPeriodo);
        Controls.Add(lblPuesto);
        Controls.Add(txtPuesto);
        Controls.Add(lblSalarioBase);
        Controls.Add(txtSalarioBase);
        Controls.Add(lblDiasPagados);
        Controls.Add(txtDiasPagados);
        Controls.Add(lblDepartamento);
        Controls.Add(txtDepartamento);
        Controls.Add(lblMovimientosTitulo);
        Controls.Add(dgvMovimientos);
        Controls.Add(lblTotalIngresos);
        Controls.Add(lblTotalDeducciones);
        Controls.Add(lblNeto);
        Controls.Add(btnAgregarMovimiento);
        Controls.Add(btnEditarMovimiento);
        Controls.Add(btnEliminarMovimiento);
        Controls.Add(btnExportarBoleta);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCerrar;
        Name = "FrmDetalleNomina";
        Text = "Detalle individual y movimientos";
        ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblEmpleado;
    private KovaqsUI.Controls.KTextBox txtEmpleado;
    private KovaqsUI.Controls.KLabel lblPeriodo;
    private KovaqsUI.Controls.KTextBox txtPeriodo;
    private KovaqsUI.Controls.KLabel lblPuesto;
    private KovaqsUI.Controls.KTextBox txtPuesto;
    private KovaqsUI.Controls.KLabel lblSalarioBase;
    private KovaqsUI.Controls.KTextBox txtSalarioBase;
    private KovaqsUI.Controls.KLabel lblDiasPagados;
    private KovaqsUI.Controls.KTextBox txtDiasPagados;
    private KovaqsUI.Controls.KLabel lblDepartamento;
    private KovaqsUI.Controls.KTextBox txtDepartamento;
    private KovaqsUI.Controls.KLabel lblMovimientosTitulo;
    private KovaqsUI.Controls.KDataGridView dgvMovimientos;
    private KovaqsUI.Controls.KLabel lblTotalIngresos;
    private KovaqsUI.Controls.KLabel lblTotalDeducciones;
    private KovaqsUI.Controls.KLabel lblNeto;
    private KovaqsUI.Controls.KButton btnAgregarMovimiento;
    private KovaqsUI.Controls.KButton btnEditarMovimiento;
    private KovaqsUI.Controls.KButton btnEliminarMovimiento;
    private KovaqsUI.Controls.KButton btnExportarBoleta;
    private DataGridViewTextBoxColumn colMovimientosTipo;
    private DataGridViewTextBoxColumn colMovimientosConcepto;
    private DataGridViewTextBoxColumn colMovimientosCantidad;
    private DataGridViewTextBoxColumn colMovimientosImportetotal;
    private SaveFileDialog dlgGuardarBoleta;
    private KovaqsUI.Components.KToastNotifier notificador;
}
