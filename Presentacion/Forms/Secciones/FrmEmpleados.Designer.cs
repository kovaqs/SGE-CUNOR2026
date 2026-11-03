namespace Presentacion.Forms.Secciones
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new KovaqsUI.Controls.KLabel();
            cboDepartamento = new KovaqsUI.Controls.KComboBox();
            lblDepartamento = new KovaqsUI.Controls.KLabel();
            lblTipoContrato = new KovaqsUI.Controls.KLabel();
            cboTipoContrato = new KovaqsUI.Controls.KComboBox();
            lblEstado = new KovaqsUI.Controls.KLabel();
            cboEstado = new KovaqsUI.Controls.KComboBox();
            btnAgregarEmpleado = new KovaqsUI.Controls.KButton();
            dgvEmpleados = new KovaqsUI.Controls.KDataGridView();
            btnAnterior = new KovaqsUI.Controls.KButton();
            lblPagina = new KovaqsUI.Controls.KLabel();
            btnSiguiente = new KovaqsUI.Controls.KButton();
            cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
            txtBuscar = new KovaqsUI.Controls.KTextBox();
            lblBuscar = new KovaqsUI.Controls.KLabel();
            lblTituloTabla = new KovaqsUI.Controls.KLabel();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            lblTamanoPagina = new KovaqsUI.Controls.KLabel();
            lblTamanoPagina.Text = "Filas por página";
            lblTamanoPagina.Location = new Point(814, 688);
            lblTamanoPagina.Size = new Size(130, 40);
            lblTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTamanoPagina.TextAlign = ContentAlignment.MiddleLeft;
            lblTamanoPagina.Font = new Font("Inter", 9F);
            lblTamanoPagina.ForeColor = Color.FromArgb(64, 64, 64);
            lblTamanoPagina.AutoSize = false;
            lblTamanoPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblTamanoPagina.TabIndex = 20;
            lblTamanoPagina.TabStop = false;
            lblTamanoPagina.Name = "lblTamanoPagina";
            components = new System.ComponentModel.Container();
            btnAcciones = new KovaqsUI.Controls.KButton();
            cmsEmpleados = new ContextMenuStrip(components);
            mnuEditarEmpleado = new ToolStripMenuItem();
            mnuHistorialLaboral = new ToolStripMenuItem();
            mnuEstadoEmpleado = new ToolStripMenuItem();
            mnuConstanciaLaboral = new ToolStripMenuItem();
            separadorAcciones = new ToolStripSeparator();
            mnuEliminarEmpleado = new ToolStripMenuItem();
            notificador = new KovaqsUI.Components.KToastNotifier(components);
            notificador.OwnerForm = this;
            dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.Font = new Font("Inter", 9F);
            colCodigo = new DataGridViewTextBoxColumn();
            colCodigo.Name = "colCodigo";
            colCodigo.HeaderText = "Código";
            colCodigo.DataPropertyName = "CodigoEmpleado";
            colCodigo.FillWeight = 12F;
            colCodigo.ReadOnly = true;
            colDpi = new DataGridViewTextBoxColumn();
            colDpi.Name = "colDpi";
            colDpi.HeaderText = "DPI";
            colDpi.DataPropertyName = "Dpi";
            colDpi.FillWeight = 16F;
            colDpi.ReadOnly = true;
            colNombre = new DataGridViewTextBoxColumn();
            colNombre.Name = "colNombre";
            colNombre.HeaderText = "Empleado";
            colNombre.DataPropertyName = "NombreCompleto";
            colNombre.FillWeight = 24F;
            colNombre.ReadOnly = true;
            colDepartamento = new DataGridViewTextBoxColumn();
            colDepartamento.Name = "colDepartamento";
            colDepartamento.HeaderText = "Departamento";
            colDepartamento.DataPropertyName = "Departamento";
            colDepartamento.FillWeight = 16F;
            colDepartamento.ReadOnly = true;
            colPuesto = new DataGridViewTextBoxColumn();
            colPuesto.Name = "colPuesto";
            colPuesto.HeaderText = "Puesto";
            colPuesto.DataPropertyName = "Puesto";
            colPuesto.FillWeight = 16F;
            colPuesto.ReadOnly = true;
            colEstado = new DataGridViewTextBoxColumn();
            colEstado.Name = "colEstado";
            colEstado.HeaderText = "Estado";
            colEstado.DataPropertyName = "Estado";
            colEstado.FillWeight = 16F;
            colEstado.ReadOnly = true;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colDpi, colNombre, colDepartamento, colPuesto, colEstado });
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = false;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.None;
            lblTitulo.Location = new Point(16, 12);
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
            lblTitulo.TabStop = false;
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1094, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Listado de empleados";
            lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
            //
            // cboDepartamento
            //
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.ItemHeight = 28;
            cboDepartamento.Location = new Point(386, 96);
            cboDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cboDepartamento.Font = new Font("Inter", 9F);
            cboDepartamento.CornerRadius = 8;
            cboDepartamento.FillColor = Color.White;
            cboDepartamento.ForeColor = Color.FromArgb(32, 38, 45);
            cboDepartamento.BorderColor = Color.FromArgb(218, 218, 218);
            cboDepartamento.GradientColor = Color.Empty;
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;

            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(354, 34);
            cboDepartamento.TabIndex = 5;
            //
            // lblDepartamento
            //
            lblDepartamento.AutoSize = false;
            lblDepartamento.BackColor = Color.Transparent;
            lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
            lblDepartamento.Location = new Point(386, 70);
            lblDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblDepartamento.Font = new Font("Inter", 9F);
            lblDepartamento.TabStop = false;
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(354, 24);
            lblDepartamento.TabIndex = 2;
            lblDepartamento.Text = "Departamento";
            lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
            lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblTipoContrato
            //
            lblTipoContrato.AutoSize = false;
            lblTipoContrato.BackColor = Color.Transparent;
            lblTipoContrato.ForeColor = Color.FromArgb(64, 64, 64);
            lblTipoContrato.Location = new Point(756, 70);
            lblTipoContrato.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblTipoContrato.Font = new Font("Inter", 9F);
            lblTipoContrato.TabStop = false;
            lblTipoContrato.Name = "lblTipoContrato";
            lblTipoContrato.Size = new Size(354, 24);
            lblTipoContrato.TabIndex = 3;
            lblTipoContrato.Text = "Tipo de contrato";
            lblTipoContrato.TextAlign = ContentAlignment.MiddleLeft;
            lblTipoContrato.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // cboTipoContrato
            //
            cboTipoContrato.FormattingEnabled = true;
            cboTipoContrato.ItemHeight = 28;
            cboTipoContrato.Location = new Point(756, 96);
            cboTipoContrato.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cboTipoContrato.Font = new Font("Inter", 9F);
            cboTipoContrato.CornerRadius = 8;
            cboTipoContrato.FillColor = Color.White;
            cboTipoContrato.ForeColor = Color.FromArgb(32, 38, 45);
            cboTipoContrato.BorderColor = Color.FromArgb(218, 218, 218);
            cboTipoContrato.GradientColor = Color.Empty;
            cboTipoContrato.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTipoContrato.Name = "cboTipoContrato";
            cboTipoContrato.Size = new Size(354, 34);
            cboTipoContrato.TabIndex = 6;
            //
            // lblEstado
            //
            lblEstado.AutoSize = false;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.ForeColor = Color.FromArgb(64, 64, 64);
            lblEstado.Location = new Point(16, 140);
            lblEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblEstado.Font = new Font("Inter", 9F);
            lblEstado.TabStop = false;
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(354, 24);
            lblEstado.TabIndex = 7;
            lblEstado.Text = "Estado";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            lblEstado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // cboEstado
            //
            cboEstado.FormattingEnabled = true;
            cboEstado.ItemHeight = 28;
            cboEstado.Location = new Point(16, 166);
            cboEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cboEstado.Font = new Font("Inter", 9F);
            cboEstado.CornerRadius = 8;
            cboEstado.FillColor = Color.White;
            cboEstado.ForeColor = Color.FromArgb(32, 38, 45);
            cboEstado.BorderColor = Color.FromArgb(218, 218, 218);
            cboEstado.GradientColor = Color.Empty;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(354, 34);
            cboEstado.TabIndex = 8;
            //
            // btnAgregarEmpleado
            //
            btnAgregarEmpleado.BackColor = Color.Transparent;
            btnAgregarEmpleado.CornerRadius = 8;
            btnAgregarEmpleado.FlatStyle = FlatStyle.Flat;
            btnAgregarEmpleado.Font = new Font("Inter", 9F);
            btnAgregarEmpleado.Location = new Point(16, 214);
            btnAgregarEmpleado.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnAgregarEmpleado.BorderThickness = 1;
            btnAgregarEmpleado.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
            btnAgregarEmpleado.FillColor = Color.FromArgb(49, 81, 107);
            btnAgregarEmpleado.ForeColor = Color.White;
            btnAgregarEmpleado.BorderColor = Color.FromArgb(49, 81, 107);
            btnAgregarEmpleado.GradientColor = Color.Empty;
            btnAgregarEmpleado.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
            btnAgregarEmpleado.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
            btnAgregarEmpleado.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Padding = new Padding(10, 4, 10, 4);
            btnAgregarEmpleado.Size = new Size(172, 40);
            btnAgregarEmpleado.TabIndex = 9;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = false;
            //
            // dgvEmpleados
            //
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Inter", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
            dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.GridColor = Color.FromArgb(218, 218, 218);
            dgvEmpleados.Location = new Point(16, 294);
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.Font = new Font("Inter", 9F);
            dgvEmpleados.ColumnHeadersHeight = 42;
            dgvEmpleados.MultiSelect = false;
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.AutoGenerateColumns = false;
            dgvEmpleados.Name = "dgvEmpleados";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 99);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 99);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowTemplate.Height = 42;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(1094, 378);
            dgvEmpleados.TabIndex = 16;
            //
            // btnAnterior
            //
            btnAnterior.BackColor = Color.Transparent;
            btnAnterior.CornerRadius = 8;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Inter", 9F);
            btnAnterior.Location = new Point(16, 688);
            btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            btnAnterior.Padding = new Padding(10, 4, 10, 4);
            btnAnterior.Size = new Size(124, 40);
            btnAnterior.TabIndex = 17;
            btnAnterior.Text = "Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            //
            // lblPagina
            //
            lblPagina.AutoSize = false;
            lblPagina.BackColor = Color.Transparent;
            lblPagina.Font = new Font("Inter", 9F);
            lblPagina.ForeColor = Color.FromArgb(64, 64, 64);
            lblPagina.Location = new Point(150, 688);
            lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPagina.TabStop = false;
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(130, 40);
            lblPagina.TabIndex = 18;
            lblPagina.Text = "Página 1 de 1";
            lblPagina.TextAlign = ContentAlignment.MiddleCenter;
            lblPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // btnSiguiente
            //
            btnSiguiente.BackColor = Color.Transparent;
            btnSiguiente.CornerRadius = 8;
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Inter", 9F);
            btnSiguiente.Location = new Point(290, 688);
            btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            btnSiguiente.Padding = new Padding(10, 4, 10, 4);
            btnSiguiente.Size = new Size(124, 40);
            btnSiguiente.TabIndex = 19;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            //
            // cboTamanoPagina
            //
            cboTamanoPagina.FormattingEnabled = true;
            cboTamanoPagina.ItemHeight = 28;
            cboTamanoPagina.Location = new Point(954, 691);
            cboTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cboTamanoPagina.Items.AddRange(new object[] { "10", "25", "50", "100" });
            cboTamanoPagina.Font = new Font("Inter", 9F);
            cboTamanoPagina.CornerRadius = 8;
            cboTamanoPagina.FillColor = Color.White;
            cboTamanoPagina.ForeColor = Color.FromArgb(32, 38, 45);
            cboTamanoPagina.BorderColor = Color.FromArgb(218, 218, 218);
            cboTamanoPagina.GradientColor = Color.Empty;
            cboTamanoPagina.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTamanoPagina.Name = "cboTamanoPagina";
            cboTamanoPagina.Size = new Size(156, 34);
            cboTamanoPagina.TabIndex = 21;
            //
            // txtBuscar
            //
            txtBuscar.Appearance.Normal.FillColor = Color.White;
            txtBuscar.BackColor = Color.Transparent;
            txtBuscar.CornerRadius = 8;
            txtBuscar.FillColor = Color.White;
            txtBuscar.Location = new Point(16, 96);
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtBuscar.Font = new Font("Inter", 9F);
            txtBuscar.ForeColor = Color.FromArgb(32, 38, 45);
            txtBuscar.BorderColor = Color.FromArgb(218, 218, 218);
            txtBuscar.GradientColor = Color.Empty;
            txtBuscar.BorderThickness = 1;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(12, 8, 12, 8);
            txtBuscar.PasswordChar = '●';
            txtBuscar.Size = new Size(354, 34);
            txtBuscar.TabIndex = 4;
            //
            // lblBuscar
            //
            lblBuscar.AutoSize = false;
            lblBuscar.BackColor = Color.Transparent;
            lblBuscar.ForeColor = Color.FromArgb(64, 64, 64);
            lblBuscar.Location = new Point(16, 70);
            lblBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblBuscar.Font = new Font("Inter", 9F);
            lblBuscar.TabStop = false;
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(354, 24);
            lblBuscar.TabIndex = 1;
            lblBuscar.Text = "Nombre, código o DPI";
            lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
            lblBuscar.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblTituloTabla
            //
            lblTituloTabla.AutoSize = false;
            lblTituloTabla.BackColor = Color.Transparent;
            lblTituloTabla.ForeColor = Color.FromArgb(64, 64, 64);
            lblTituloTabla.Location = new Point(16, 268);
            lblTituloTabla.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloTabla.Font = new Font("Inter", 9F);
            lblTituloTabla.TabStop = false;
            lblTituloTabla.Name = "lblTituloTabla";
            lblTituloTabla.Size = new Size(1094, 24);
            lblTituloTabla.TabIndex = 15;
            lblTituloTabla.Text = "Plantilla del personal";
            lblTituloTabla.TextAlign = ContentAlignment.MiddleLeft;
            lblTituloTabla.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            btnAcciones.BackColor = Color.Transparent;
            btnAcciones.CornerRadius = 8;
            btnAcciones.FlatStyle = FlatStyle.Flat;
            btnAcciones.Font = new Font("Inter", 9F);
            btnAcciones.Location = new Point(200, 214);
            btnAcciones.Anchor = AnchorStyles.Top | AnchorStyles.Left;
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
            btnAcciones.Padding = new Padding(10, 4, 10, 4);
            btnAcciones.Size = new Size(172, 40);
            btnAcciones.TabIndex = 10;
            btnAcciones.Text = "Acciones ▾";
            btnAcciones.UseVisualStyleBackColor = false;
            btnAcciones.Click += btnAcciones_Click;
            btnAcciones.Enabled = false;
            //
            // cmsEmpleados
            //
            cmsEmpleados.SuspendLayout();
            cmsEmpleados.Items.AddRange(new ToolStripItem[] { mnuEditarEmpleado, mnuHistorialLaboral, mnuEstadoEmpleado, mnuConstanciaLaboral, separadorAcciones, mnuEliminarEmpleado });
            cmsEmpleados.Name = "cmsEmpleados";
            cmsEmpleados.Font = new Font("Inter", 9F);
            cmsEmpleados.ShowImageMargin = false;
            cmsEmpleados.Opening += cmsEmpleados_Opening;
            //
            // mnuEditarEmpleado
            //
            mnuEditarEmpleado.Name = "mnuEditarEmpleado";
            mnuEditarEmpleado.Text = "Editar";
            mnuEditarEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
            //
            // mnuHistorialLaboral
            //
            mnuHistorialLaboral.Name = "mnuHistorialLaboral";
            mnuHistorialLaboral.Text = "Historial laboral";
            mnuHistorialLaboral.ForeColor = Color.FromArgb(32, 38, 45);
            //
            // mnuEstadoEmpleado
            //
            mnuEstadoEmpleado.Name = "mnuEstadoEmpleado";
            mnuEstadoEmpleado.Text = "Cambiar estado";
            mnuEstadoEmpleado.ForeColor = Color.FromArgb(32, 38, 45);
            //
            // mnuConstanciaLaboral
            //
            mnuConstanciaLaboral.Name = "mnuConstanciaLaboral";
            mnuConstanciaLaboral.Text = "Generar constancia";
            mnuConstanciaLaboral.ForeColor = Color.FromArgb(32, 38, 45);
            //
            // mnuEliminarEmpleado
            //
            mnuEliminarEmpleado.Name = "mnuEliminarEmpleado";
            mnuEliminarEmpleado.Text = "Eliminar";
            mnuEliminarEmpleado.ForeColor = Color.FromArgb(166, 61, 64);
            separadorAcciones.Name = "separadorAcciones";
            dgvEmpleados.ContextMenuStrip = cmsEmpleados;
            dgvEmpleados.MouseDown += dgvEmpleados_MouseDown;
            dgvEmpleados.SelectionChanged += dgvEmpleados_SelectionChanged;
            dgvEmpleados.CellDoubleClick += dgvEmpleados_CellDoubleClick;
            Controls.Add(btnAcciones);
            cmsEmpleados.ResumeLayout(false);
            //
            // FrmEmpleados
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1126, 744);
            Controls.Add(lblTituloTabla);
            Controls.Add(dgvEmpleados);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(lblEstado);
            Controls.Add(cboEstado);
            Controls.Add(lblTipoContrato);
            Controls.Add(cboTipoContrato);
            Controls.Add(lblDepartamento);
            Controls.Add(cboDepartamento);
            Controls.Add(lblTitulo);
            Controls.Add(btnAnterior);
            Controls.Add(lblPagina);
            Controls.Add(btnSiguiente);
            Controls.Add(cboTamanoPagina);
            Controls.Add(lblTamanoPagina);
            MinimumSize = new Size(1126, 744);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3);
            Font = new Font("Segoe UI", 9F);
            Icon = Properties.Resources.sgeicon;
            Name = "FrmEmpleados";
            Text = "Listado de empleados";
            Load += FrmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private KovaqsUI.Controls.KButton btnAcciones;
        private ContextMenuStrip cmsEmpleados;
        private ToolStripMenuItem mnuEditarEmpleado;
        private ToolStripMenuItem mnuHistorialLaboral;
        private ToolStripMenuItem mnuEstadoEmpleado;
        private ToolStripMenuItem mnuConstanciaLaboral;
        private ToolStripSeparator separadorAcciones;
        private ToolStripMenuItem mnuEliminarEmpleado;

        private KovaqsUI.Controls.KLabel lblTitulo;
        private KovaqsUI.Controls.KComboBox cboDepartamento;
        private KovaqsUI.Controls.KLabel lblDepartamento;
        private KovaqsUI.Controls.KLabel lblTipoContrato;
        private KovaqsUI.Controls.KComboBox cboTipoContrato;
        private KovaqsUI.Controls.KLabel lblEstado;
        private KovaqsUI.Controls.KComboBox cboEstado;
        private KovaqsUI.Controls.KButton btnAgregarEmpleado;
        private KovaqsUI.Controls.KDataGridView dgvEmpleados;
        private KovaqsUI.Controls.KButton btnAnterior;
        private KovaqsUI.Controls.KLabel lblPagina;
        private KovaqsUI.Controls.KButton btnSiguiente;
        private KovaqsUI.Controls.KComboBox cboTamanoPagina;
        private KovaqsUI.Controls.KTextBox txtBuscar;
        private KovaqsUI.Controls.KLabel lblBuscar;
        private KovaqsUI.Controls.KLabel lblTituloTabla;
            private KovaqsUI.Controls.KLabel lblTamanoPagina;
        private KovaqsUI.Components.KToastNotifier notificador;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colDpi;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDepartamento;
        private DataGridViewTextBoxColumn colPuesto;
        private DataGridViewTextBoxColumn colEstado;
}
}
