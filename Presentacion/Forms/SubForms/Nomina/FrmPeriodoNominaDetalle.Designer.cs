namespace Presentacion.Forms.SubForms.Nomina;

partial class FrmPeriodoNominaDetalle
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
        lblPeriodo = new KovaqsUI.Controls.KLabel();
        txtPeriodo = new KovaqsUI.Controls.KTextBox();
        lblEstadoDelPeriodo = new KovaqsUI.Controls.KLabel();
        txtEstadoPeriodo = new KovaqsUI.Controls.KTextBox();
        lblDepartamento = new KovaqsUI.Controls.KLabel();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        lblBuscarEmpleado = new KovaqsUI.Controls.KLabel();
        txtBuscarEmpleado = new KovaqsUI.Controls.KTextBox();
        btnCalcularNomina = new KovaqsUI.Controls.KButton();
        btnVerDetalle = new KovaqsUI.Controls.KButton();
        btnCerrarPeriodo = new KovaqsUI.Controls.KButton();
        btnAnularPeriodo = new KovaqsUI.Controls.KButton();
        lblDetalleNominaTitulo = new KovaqsUI.Controls.KLabel();
        dgvDetalleNomina = new KovaqsUI.Controls.KDataGridView();
        lblTotalIngresos = new KovaqsUI.Controls.KLabel();
        lblTotalDeducciones = new KovaqsUI.Controls.KLabel();
        lblTotalNeto = new KovaqsUI.Controls.KLabel();
        btnAnterior = new KovaqsUI.Controls.KButton();
        lblPagina = new KovaqsUI.Controls.KLabel();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        lblTamanoPagina = new KovaqsUI.Controls.KLabel();
        cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
        colDetalleNominaCodigo = new DataGridViewTextBoxColumn();
        colDetalleNominaEmpleado = new DataGridViewTextBoxColumn();
        colDetalleNominaDepartamento = new DataGridViewTextBoxColumn();
        colDetalleNominaIngresos = new DataGridViewTextBoxColumn();
        colDetalleNominaDeducciones = new DataGridViewTextBoxColumn();
        colDetalleNominaNeto = new DataGridViewTextBoxColumn();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvDetalleNomina).BeginInit();
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
        lblTitulo.Text = "Detalle de un período de pago";
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
        // lblPeriodo
        //
        lblPeriodo.AutoSize = false;
        lblPeriodo.BackColor = Color.Transparent;
        lblPeriodo.ForeColor = Color.FromArgb(64, 64, 64);
        lblPeriodo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPeriodo.TextAlign = ContentAlignment.MiddleLeft;
        lblPeriodo.Text = "Período";
        lblPeriodo.Location = new Point(16, 70);
        lblPeriodo.Font = new Font("Inter", 9F);
        lblPeriodo.Name = "lblPeriodo";
        lblPeriodo.Size = new Size(278, 24);
        lblPeriodo.TabIndex = 2;
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
        txtPeriodo.Location = new Point(16, 96);
        txtPeriodo.FillColor = Color.White;
        txtPeriodo.ForeColor = Color.FromArgb(32, 38, 45);
        txtPeriodo.BorderColor = Color.FromArgb(218, 218, 218);
        txtPeriodo.GradientColor = Color.Empty;
        txtPeriodo.BorderThickness = 1;
        txtPeriodo.Name = "txtPeriodo";
        txtPeriodo.Size = new Size(278, 34);
        txtPeriodo.TabIndex = 5;
        //
        // lblEstadoDelPeriodo
        //
        lblEstadoDelPeriodo.AutoSize = false;
        lblEstadoDelPeriodo.BackColor = Color.Transparent;
        lblEstadoDelPeriodo.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoDelPeriodo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEstadoDelPeriodo.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoDelPeriodo.Text = "Estado del período";
        lblEstadoDelPeriodo.Location = new Point(312, 70);
        lblEstadoDelPeriodo.Font = new Font("Inter", 9F);
        lblEstadoDelPeriodo.Name = "lblEstadoDelPeriodo";
        lblEstadoDelPeriodo.Size = new Size(278, 24);
        lblEstadoDelPeriodo.TabIndex = 3;
        lblEstadoDelPeriodo.TabStop = false;
        //
        // txtEstadoPeriodo
        //
        txtEstadoPeriodo.BackColor = Color.Transparent;
        txtEstadoPeriodo.CornerRadius = 8;
        txtEstadoPeriodo.Font = new Font("Inter", 9F);
        txtEstadoPeriodo.Padding = new Padding(10, 6, 10, 6);
        txtEstadoPeriodo.ReadOnly = true;
        txtEstadoPeriodo.MaxLength = 100;
        txtEstadoPeriodo.Location = new Point(312, 96);
        txtEstadoPeriodo.FillColor = Color.White;
        txtEstadoPeriodo.ForeColor = Color.FromArgb(32, 38, 45);
        txtEstadoPeriodo.BorderColor = Color.FromArgb(218, 218, 218);
        txtEstadoPeriodo.GradientColor = Color.Empty;
        txtEstadoPeriodo.BorderThickness = 1;
        txtEstadoPeriodo.Name = "txtEstadoPeriodo";
        txtEstadoPeriodo.Size = new Size(278, 34);
        txtEstadoPeriodo.TabIndex = 6;
        //
        // lblDepartamento
        //
        lblDepartamento.AutoSize = false;
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
        lblDepartamento.Text = "Departamento";
        lblDepartamento.Location = new Point(608, 70);
        lblDepartamento.Font = new Font("Inter", 9F);
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(278, 24);
        lblDepartamento.TabIndex = 4;
        lblDepartamento.TabStop = false;
        //
        // cboDepartamento
        //
        cboDepartamento.Font = new Font("Inter", 9F);
        cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.Items.AddRange(new object[] { "Todos" });
        cboDepartamento.Location = new Point(608, 96);
        cboDepartamento.CornerRadius = 8;
        cboDepartamento.FillColor = Color.White;
        cboDepartamento.ForeColor = Color.FromArgb(32, 38, 45);
        cboDepartamento.BorderColor = Color.FromArgb(218, 218, 218);
        cboDepartamento.GradientColor = Color.Empty;

        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(278, 34);
        cboDepartamento.TabIndex = 7;
        //
        // lblBuscarEmpleado
        //
        lblBuscarEmpleado.AutoSize = false;
        lblBuscarEmpleado.BackColor = Color.Transparent;
        lblBuscarEmpleado.ForeColor = Color.FromArgb(64, 64, 64);
        lblBuscarEmpleado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblBuscarEmpleado.TextAlign = ContentAlignment.MiddleLeft;
        lblBuscarEmpleado.Text = "Nombre o código";
        lblBuscarEmpleado.Location = new Point(16, 140);
        lblBuscarEmpleado.Font = new Font("Inter", 9F);
        lblBuscarEmpleado.Name = "lblBuscarEmpleado";
        lblBuscarEmpleado.Size = new Size(278, 24);
        lblBuscarEmpleado.TabIndex = 8;
        lblBuscarEmpleado.TabStop = false;
        //
        // txtBuscarEmpleado
        //
        txtBuscarEmpleado.BackColor = Color.Transparent;
        txtBuscarEmpleado.CornerRadius = 8;
        txtBuscarEmpleado.Font = new Font("Inter", 9F);
        txtBuscarEmpleado.Padding = new Padding(10, 6, 10, 6);
        txtBuscarEmpleado.MaxLength = 100;
        txtBuscarEmpleado.Location = new Point(16, 166);
        txtBuscarEmpleado.FillColor = Color.White;
        txtBuscarEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
        txtBuscarEmpleado.BorderColor = Color.FromArgb(218, 218, 218);
        txtBuscarEmpleado.GradientColor = Color.Empty;
        txtBuscarEmpleado.BorderThickness = 1;
        txtBuscarEmpleado.Name = "txtBuscarEmpleado";
        txtBuscarEmpleado.Size = new Size(278, 34);
        txtBuscarEmpleado.TabIndex = 9;
        //
        // btnCalcularNomina
        //
        btnCalcularNomina.BackColor = Color.Transparent;
        btnCalcularNomina.CornerRadius = 8;
        btnCalcularNomina.FlatStyle = FlatStyle.Flat;
        btnCalcularNomina.Font = new Font("Inter", 9F);
        btnCalcularNomina.Padding = new Padding(10, 4, 10, 4);
        btnCalcularNomina.UseVisualStyleBackColor = false;
        btnCalcularNomina.Text = "Calcular borrador";
        btnCalcularNomina.Location = new Point(16, 214);
        btnCalcularNomina.BorderThickness = 1;
        btnCalcularNomina.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnCalcularNomina.FillColor = Color.FromArgb(49, 81, 107);
        btnCalcularNomina.ForeColor = Color.White;
        btnCalcularNomina.BorderColor = Color.FromArgb(49, 81, 107);
        btnCalcularNomina.GradientColor = Color.Empty;
        btnCalcularNomina.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnCalcularNomina.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnCalcularNomina.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnCalcularNomina.Name = "btnCalcularNomina";
        btnCalcularNomina.Size = new Size(208, 40);
        btnCalcularNomina.TabIndex = 10;
        //
        // btnVerDetalle
        //
        btnVerDetalle.BackColor = Color.Transparent;
        btnVerDetalle.CornerRadius = 8;
        btnVerDetalle.FlatStyle = FlatStyle.Flat;
        btnVerDetalle.Font = new Font("Inter", 9F);
        btnVerDetalle.Padding = new Padding(10, 4, 10, 4);
        btnVerDetalle.UseVisualStyleBackColor = false;
        btnVerDetalle.Text = "Ver empleado";
        btnVerDetalle.Location = new Point(236, 214);
        btnVerDetalle.BorderThickness = 1;
        btnVerDetalle.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnVerDetalle.FillColor = Color.White;
        btnVerDetalle.ForeColor = Color.FromArgb(32, 38, 45);
        btnVerDetalle.BorderColor = Color.FromArgb(218, 218, 218);
        btnVerDetalle.GradientColor = Color.Empty;
        btnVerDetalle.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnVerDetalle.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnVerDetalle.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnVerDetalle.Name = "btnVerDetalle";
        btnVerDetalle.Size = new Size(208, 40);
        btnVerDetalle.TabIndex = 11;
        //
        // btnCerrarPeriodo
        //
        btnCerrarPeriodo.BackColor = Color.Transparent;
        btnCerrarPeriodo.CornerRadius = 8;
        btnCerrarPeriodo.FlatStyle = FlatStyle.Flat;
        btnCerrarPeriodo.Font = new Font("Inter", 9F);
        btnCerrarPeriodo.Padding = new Padding(10, 4, 10, 4);
        btnCerrarPeriodo.UseVisualStyleBackColor = false;
        btnCerrarPeriodo.Text = "Cerrar período";
        btnCerrarPeriodo.Location = new Point(456, 214);
        btnCerrarPeriodo.BorderThickness = 1;
        btnCerrarPeriodo.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCerrarPeriodo.FillColor = Color.White;
        btnCerrarPeriodo.ForeColor = Color.FromArgb(49, 81, 107);
        btnCerrarPeriodo.BorderColor = Color.FromArgb(173, 190, 204);
        btnCerrarPeriodo.GradientColor = Color.Empty;
        btnCerrarPeriodo.Appearance.Hover.FillColor = Color.FromArgb(239, 244, 248);
        btnCerrarPeriodo.Appearance.Pressed.FillColor = Color.FromArgb(225, 235, 243);
        btnCerrarPeriodo.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnCerrarPeriodo.Name = "btnCerrarPeriodo";
        btnCerrarPeriodo.Size = new Size(208, 40);
        btnCerrarPeriodo.TabIndex = 12;
        //
        // btnAnularPeriodo
        //
        btnAnularPeriodo.BackColor = Color.Transparent;
        btnAnularPeriodo.CornerRadius = 8;
        btnAnularPeriodo.FlatStyle = FlatStyle.Flat;
        btnAnularPeriodo.Font = new Font("Inter", 9F);
        btnAnularPeriodo.Padding = new Padding(10, 4, 10, 4);
        btnAnularPeriodo.UseVisualStyleBackColor = false;
        btnAnularPeriodo.Text = "Anular período";
        btnAnularPeriodo.Location = new Point(676, 214);
        btnAnularPeriodo.BorderThickness = 1;
        btnAnularPeriodo.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
        btnAnularPeriodo.FillColor = Color.FromArgb(166, 61, 64);
        btnAnularPeriodo.ForeColor = Color.White;
        btnAnularPeriodo.BorderColor = Color.FromArgb(166, 61, 64);
        btnAnularPeriodo.GradientColor = Color.Empty;
        btnAnularPeriodo.Appearance.Hover.FillColor = Color.FromArgb(145, 49, 53);
        btnAnularPeriodo.Appearance.Pressed.FillColor = Color.FromArgb(123, 40, 44);
        btnAnularPeriodo.FocusAppearance.Color = Color.FromArgb(255, 225, 226);
        btnAnularPeriodo.Name = "btnAnularPeriodo";
        btnAnularPeriodo.Size = new Size(208, 40);
        btnAnularPeriodo.TabIndex = 13;
        //
        // lblDetalleNominaTitulo
        //
        lblDetalleNominaTitulo.AutoSize = false;
        lblDetalleNominaTitulo.BackColor = Color.Transparent;
        lblDetalleNominaTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblDetalleNominaTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDetalleNominaTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblDetalleNominaTitulo.Text = "Empleados del período";
        lblDetalleNominaTitulo.Location = new Point(16, 268);
        lblDetalleNominaTitulo.Font = new Font("Inter", 9F);
        lblDetalleNominaTitulo.Name = "lblDetalleNominaTitulo";
        lblDetalleNominaTitulo.Size = new Size(870, 24);
        lblDetalleNominaTitulo.TabIndex = 14;
        lblDetalleNominaTitulo.TabStop = false;
        //
        // dgvDetalleNomina
        //
        dgvDetalleNomina.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvDetalleNomina.AllowUserToAddRows = false;
        dgvDetalleNomina.AllowUserToDeleteRows = false;
        dgvDetalleNomina.AutoGenerateColumns = false;
        dgvDetalleNomina.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDetalleNomina.ReadOnly = true;
        dgvDetalleNomina.RowHeadersVisible = false;
        dgvDetalleNomina.MultiSelect = false;
        dgvDetalleNomina.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDetalleNomina.BackgroundColor = Color.White;
        dgvDetalleNomina.BorderStyle = BorderStyle.None;
        dgvDetalleNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvDetalleNomina.ColumnHeadersHeight = 42;
        dgvDetalleNomina.EnableHeadersVisualStyles = false;
        dgvDetalleNomina.GridColor = Color.FromArgb(218, 218, 218);
        dgvDetalleNomina.RowTemplate.Height = 42;
        dgvDetalleNomina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvDetalleNomina.DefaultCellStyle = dataGridViewCellStyle2;
        dgvDetalleNomina.Location = new Point(16, 294);
        dgvDetalleNomina.Font = new Font("Inter", 9F);
        dgvDetalleNomina.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvDetalleNomina.Name = "dgvDetalleNomina";
        dgvDetalleNomina.Size = new Size(870, 220);
        dgvDetalleNomina.TabIndex = 15;
        dgvDetalleNomina.Columns.AddRange(new DataGridViewColumn[] { colDetalleNominaCodigo, colDetalleNominaEmpleado, colDetalleNominaDepartamento, colDetalleNominaIngresos, colDetalleNominaDeducciones, colDetalleNominaNeto });
        //
        // lblTotalIngresos
        //
        lblTotalIngresos.AutoSize = false;
        lblTotalIngresos.BackColor = Color.Transparent;
        lblTotalIngresos.ForeColor = Color.FromArgb(64, 64, 64);
        lblTotalIngresos.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTotalIngresos.TextAlign = ContentAlignment.MiddleLeft;
        lblTotalIngresos.Text = "Total de ingresos: Q 0.00";
        lblTotalIngresos.Font = new Font("Inter", 9F);
        lblTotalIngresos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTotalIngresos.Location = new Point(16, 526);
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
        lblTotalDeducciones.Text = "Total de deducciones: Q 0.00";
        lblTotalDeducciones.Font = new Font("Inter", 9F);
        lblTotalDeducciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTotalDeducciones.Location = new Point(306, 526);
        lblTotalDeducciones.Name = "lblTotalDeducciones";
        lblTotalDeducciones.Size = new Size(278, 30);
        lblTotalDeducciones.TabIndex = 17;
        lblTotalDeducciones.TabStop = false;
        //
        // lblTotalNeto
        //
        lblTotalNeto.AutoSize = false;
        lblTotalNeto.BackColor = Color.Transparent;
        lblTotalNeto.ForeColor = Color.FromArgb(64, 64, 64);
        lblTotalNeto.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTotalNeto.TextAlign = ContentAlignment.MiddleLeft;
        lblTotalNeto.Text = "Total neto: Q 0.00";
        lblTotalNeto.Font = new Font("Inter", 9F);
        lblTotalNeto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblTotalNeto.Location = new Point(596, 526);
        lblTotalNeto.Name = "lblTotalNeto";
        lblTotalNeto.Size = new Size(278, 30);
        lblTotalNeto.TabIndex = 18;
        lblTotalNeto.TabStop = false;
        //
        // btnAnterior
        //
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.CornerRadius = 8;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Font = new Font("Inter", 9F);
        btnAnterior.Padding = new Padding(10, 4, 10, 4);
        btnAnterior.UseVisualStyleBackColor = false;
        btnAnterior.Text = "Anterior";
        btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAnterior.Location = new Point(16, 568);
        btnAnterior.BorderThickness = 1;
        btnAnterior.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnAnterior.FillColor = Color.White;
        btnAnterior.ForeColor = Color.FromArgb(32, 38, 45);
        btnAnterior.BorderColor = Color.FromArgb(218, 218, 218);
        btnAnterior.GradientColor = Color.Empty;
        btnAnterior.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnAnterior.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnAnterior.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Size = new Size(124, 40);
        btnAnterior.TabIndex = 19;
        //
        // lblPagina
        //
        lblPagina.AutoSize = false;
        lblPagina.BackColor = Color.Transparent;
        lblPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        lblPagina.Text = "Página 1 de 1";
        lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPagina.Location = new Point(150, 568);
        lblPagina.Font = new Font("Inter", 9F);
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(130, 40);
        lblPagina.TabIndex = 20;
        lblPagina.TabStop = false;
        //
        // btnSiguiente
        //
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.CornerRadius = 8;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.Font = new Font("Inter", 9F);
        btnSiguiente.Padding = new Padding(10, 4, 10, 4);
        btnSiguiente.UseVisualStyleBackColor = false;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSiguiente.Location = new Point(290, 568);
        btnSiguiente.BorderThickness = 1;
        btnSiguiente.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnSiguiente.FillColor = Color.White;
        btnSiguiente.ForeColor = Color.FromArgb(32, 38, 45);
        btnSiguiente.BorderColor = Color.FromArgb(218, 218, 218);
        btnSiguiente.GradientColor = Color.Empty;
        btnSiguiente.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnSiguiente.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnSiguiente.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Size = new Size(124, 40);
        btnSiguiente.TabIndex = 21;
        //
        // lblTamanoPagina
        //
        lblTamanoPagina.AutoSize = false;
        lblTamanoPagina.BackColor = Color.Transparent;
        lblTamanoPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblTamanoPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTamanoPagina.TextAlign = ContentAlignment.MiddleLeft;
        lblTamanoPagina.Text = "Filas por página";
        lblTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblTamanoPagina.Location = new Point(590, 568);
        lblTamanoPagina.Font = new Font("Inter", 9F);
        lblTamanoPagina.Name = "lblTamanoPagina";
        lblTamanoPagina.Size = new Size(130, 40);
        lblTamanoPagina.TabIndex = 22;
        lblTamanoPagina.TabStop = false;
        //
        // cboTamanoPagina
        //
        cboTamanoPagina.Font = new Font("Inter", 9F);
        cboTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cboTamanoPagina.DropDownStyle = ComboBoxStyle.DropDownList;
        cboTamanoPagina.Items.AddRange(new object[] { "10", "25", "50", "100" });
        cboTamanoPagina.Location = new Point(730, 571);
        cboTamanoPagina.CornerRadius = 8;
        cboTamanoPagina.FillColor = Color.White;
        cboTamanoPagina.ForeColor = Color.FromArgb(32, 38, 45);
        cboTamanoPagina.BorderColor = Color.FromArgb(218, 218, 218);
        cboTamanoPagina.GradientColor = Color.Empty;

        cboTamanoPagina.Name = "cboTamanoPagina";
        cboTamanoPagina.Size = new Size(156, 34);
        cboTamanoPagina.TabIndex = 23;
        //
        // colDetalleNominaCodigo
        //
        colDetalleNominaCodigo.HeaderText = "Código";
        colDetalleNominaCodigo.Name = "colDetalleNominaCodigo";
        colDetalleNominaCodigo.ReadOnly = true;
        //
        // colDetalleNominaEmpleado
        //
        colDetalleNominaEmpleado.HeaderText = "Empleado";
        colDetalleNominaEmpleado.Name = "colDetalleNominaEmpleado";
        colDetalleNominaEmpleado.ReadOnly = true;
        //
        // colDetalleNominaDepartamento
        //
        colDetalleNominaDepartamento.HeaderText = "Departamento";
        colDetalleNominaDepartamento.Name = "colDetalleNominaDepartamento";
        colDetalleNominaDepartamento.ReadOnly = true;
        //
        // colDetalleNominaIngresos
        //
        colDetalleNominaIngresos.HeaderText = "Ingresos";
        colDetalleNominaIngresos.Name = "colDetalleNominaIngresos";
        colDetalleNominaIngresos.ReadOnly = true;
        //
        // colDetalleNominaDeducciones
        //
        colDetalleNominaDeducciones.HeaderText = "Deducciones";
        colDetalleNominaDeducciones.Name = "colDetalleNominaDeducciones";
        colDetalleNominaDeducciones.ReadOnly = true;
        //
        // colDetalleNominaNeto
        //
        colDetalleNominaNeto.HeaderText = "Neto";
        colDetalleNominaNeto.Name = "colDetalleNominaNeto";
        colDetalleNominaNeto.ReadOnly = true;
        notificador.OwnerForm = this;
        //
        // FrmPeriodoNominaDetalle
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblPeriodo);
        Controls.Add(txtPeriodo);
        Controls.Add(lblEstadoDelPeriodo);
        Controls.Add(txtEstadoPeriodo);
        Controls.Add(lblDepartamento);
        Controls.Add(cboDepartamento);
        Controls.Add(lblBuscarEmpleado);
        Controls.Add(txtBuscarEmpleado);
        Controls.Add(btnCalcularNomina);
        Controls.Add(btnVerDetalle);
        Controls.Add(btnCerrarPeriodo);
        Controls.Add(btnAnularPeriodo);
        Controls.Add(lblDetalleNominaTitulo);
        Controls.Add(dgvDetalleNomina);
        Controls.Add(lblTotalIngresos);
        Controls.Add(lblTotalDeducciones);
        Controls.Add(lblTotalNeto);
        Controls.Add(btnAnterior);
        Controls.Add(lblPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(lblTamanoPagina);
        Controls.Add(cboTamanoPagina);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCerrar;
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmPeriodoNominaDetalle";
        Text = "Detalle de un período de pago";
        ((System.ComponentModel.ISupportInitialize)dgvDetalleNomina).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblPeriodo;
    private KovaqsUI.Controls.KTextBox txtPeriodo;
    private KovaqsUI.Controls.KLabel lblEstadoDelPeriodo;
    private KovaqsUI.Controls.KTextBox txtEstadoPeriodo;
    private KovaqsUI.Controls.KLabel lblDepartamento;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KLabel lblBuscarEmpleado;
    private KovaqsUI.Controls.KTextBox txtBuscarEmpleado;
    private KovaqsUI.Controls.KButton btnCalcularNomina;
    private KovaqsUI.Controls.KButton btnVerDetalle;
    private KovaqsUI.Controls.KButton btnCerrarPeriodo;
    private KovaqsUI.Controls.KButton btnAnularPeriodo;
    private KovaqsUI.Controls.KLabel lblDetalleNominaTitulo;
    private KovaqsUI.Controls.KDataGridView dgvDetalleNomina;
    private KovaqsUI.Controls.KLabel lblTotalIngresos;
    private KovaqsUI.Controls.KLabel lblTotalDeducciones;
    private KovaqsUI.Controls.KLabel lblTotalNeto;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KLabel lblTamanoPagina;
    private KovaqsUI.Controls.KComboBox cboTamanoPagina;
    private DataGridViewTextBoxColumn colDetalleNominaCodigo;
    private DataGridViewTextBoxColumn colDetalleNominaEmpleado;
    private DataGridViewTextBoxColumn colDetalleNominaDepartamento;
    private DataGridViewTextBoxColumn colDetalleNominaIngresos;
    private DataGridViewTextBoxColumn colDetalleNominaDeducciones;
    private DataGridViewTextBoxColumn colDetalleNominaNeto;
    private KovaqsUI.Components.KToastNotifier notificador;
}
