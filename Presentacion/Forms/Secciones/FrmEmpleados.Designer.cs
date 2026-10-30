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
            kLabel7 = new KovaqsUI.Controls.KLabel();
            cboDepartamento = new KovaqsUI.Controls.KComboBox();
            kLabel2 = new KovaqsUI.Controls.KLabel();
            kLabel3 = new KovaqsUI.Controls.KLabel();
            cboTipoContrato = new KovaqsUI.Controls.KComboBox();
            kLabel4 = new KovaqsUI.Controls.KLabel();
            cboEstado = new KovaqsUI.Controls.KComboBox();
            btnAgregarEmpleado = new KovaqsUI.Controls.KButton();
            dgvEmpleados = new KovaqsUI.Controls.KDataGridView();
            kButton6 = new KovaqsUI.Controls.KButton();
            kLabel8 = new KovaqsUI.Controls.KLabel();
            kButton5 = new KovaqsUI.Controls.KButton();
            kComboBox3 = new KovaqsUI.Controls.KComboBox();
            txtBuscar = new KovaqsUI.Controls.KTextBox();
            kLabel5 = new KovaqsUI.Controls.KLabel();
            kLabel1 = new KovaqsUI.Controls.KLabel();
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
            // kLabel7
            //
            kLabel7.AutoSize = false;
            kLabel7.BackColor = Color.Transparent;
            kLabel7.Dock = DockStyle.None;
            kLabel7.Location = new Point(16, 12);
            kLabel7.TextAlign = ContentAlignment.MiddleLeft;
            kLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kLabel7.Font = new Font("Inter", 16F, FontStyle.Bold);
            kLabel7.ForeColor = Color.FromArgb(32, 38, 45);
            kLabel7.TabStop = false;
            kLabel7.Name = "kLabel7";
            kLabel7.Size = new Size(1094, 40);
            kLabel7.TabIndex = 0;
            kLabel7.Text = "Listado de empleados";
            kLabel7.TextRole = KovaqsUI.Controls.KTextRole.Title;
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
            // kLabel2
            //
            kLabel2.AutoSize = false;
            kLabel2.BackColor = Color.Transparent;
            kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel2.Location = new Point(386, 70);
            kLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            kLabel2.Font = new Font("Inter", 9F);
            kLabel2.TabStop = false;
            kLabel2.Name = "kLabel2";
            kLabel2.Size = new Size(354, 24);
            kLabel2.TabIndex = 2;
            kLabel2.Text = "Departamento";
            kLabel2.TextAlign = ContentAlignment.MiddleLeft;
            kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // kLabel3
            //
            kLabel3.AutoSize = false;
            kLabel3.BackColor = Color.Transparent;
            kLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel3.Location = new Point(756, 70);
            kLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            kLabel3.Font = new Font("Inter", 9F);
            kLabel3.TabStop = false;
            kLabel3.Name = "kLabel3";
            kLabel3.Size = new Size(354, 24);
            kLabel3.TabIndex = 3;
            kLabel3.Text = "Tipo de contrato";
            kLabel3.TextAlign = ContentAlignment.MiddleLeft;
            kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
            // kLabel4
            //
            kLabel4.AutoSize = false;
            kLabel4.BackColor = Color.Transparent;
            kLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel4.Location = new Point(16, 140);
            kLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            kLabel4.Font = new Font("Inter", 9F);
            kLabel4.TabStop = false;
            kLabel4.Name = "kLabel4";
            kLabel4.Size = new Size(354, 24);
            kLabel4.TabIndex = 7;
            kLabel4.Text = "Estado";
            kLabel4.TextAlign = ContentAlignment.MiddleLeft;
            kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
            // kButton6
            //
            kButton6.BackColor = Color.Transparent;
            kButton6.CornerRadius = 8;
            kButton6.FlatStyle = FlatStyle.Flat;
            kButton6.Font = new Font("Inter", 9F);
            kButton6.Location = new Point(16, 688);
            kButton6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kButton6.BorderThickness = 1;
            kButton6.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            kButton6.FillColor = Color.White;
            kButton6.ForeColor = Color.FromArgb(32, 38, 45);
            kButton6.BorderColor = Color.FromArgb(218, 218, 218);
            kButton6.GradientColor = Color.Empty;
            kButton6.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
            kButton6.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
            kButton6.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            kButton6.Name = "kButton6";
            kButton6.Padding = new Padding(10, 4, 10, 4);
            kButton6.Size = new Size(124, 40);
            kButton6.TabIndex = 17;
            kButton6.Text = "Anterior";
            kButton6.UseVisualStyleBackColor = false;
            //
            // kLabel8
            //
            kLabel8.AutoSize = false;
            kLabel8.BackColor = Color.Transparent;
            kLabel8.Font = new Font("Inter", 9F);
            kLabel8.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel8.Location = new Point(150, 688);
            kLabel8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kLabel8.TabStop = false;
            kLabel8.Name = "kLabel8";
            kLabel8.Size = new Size(130, 40);
            kLabel8.TabIndex = 18;
            kLabel8.Text = "Página 1 de 1";
            kLabel8.TextAlign = ContentAlignment.MiddleCenter;
            kLabel8.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // kButton5
            //
            kButton5.BackColor = Color.Transparent;
            kButton5.CornerRadius = 8;
            kButton5.FlatStyle = FlatStyle.Flat;
            kButton5.Font = new Font("Inter", 9F);
            kButton5.Location = new Point(290, 688);
            kButton5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            kButton5.BorderThickness = 1;
            kButton5.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            kButton5.FillColor = Color.White;
            kButton5.ForeColor = Color.FromArgb(32, 38, 45);
            kButton5.BorderColor = Color.FromArgb(218, 218, 218);
            kButton5.GradientColor = Color.Empty;
            kButton5.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
            kButton5.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
            kButton5.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            kButton5.Name = "kButton5";
            kButton5.Padding = new Padding(10, 4, 10, 4);
            kButton5.Size = new Size(124, 40);
            kButton5.TabIndex = 19;
            kButton5.Text = "Siguiente";
            kButton5.UseVisualStyleBackColor = false;
            //
            // kComboBox3
            //
            kComboBox3.FormattingEnabled = true;
            kComboBox3.ItemHeight = 28;
            kComboBox3.Location = new Point(954, 691);
            kComboBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            kComboBox3.Items.AddRange(new object[] { "10", "25", "50", "100" });
            kComboBox3.Font = new Font("Inter", 9F);
            kComboBox3.CornerRadius = 8;
            kComboBox3.FillColor = Color.White;
            kComboBox3.ForeColor = Color.FromArgb(32, 38, 45);
            kComboBox3.BorderColor = Color.FromArgb(218, 218, 218);
            kComboBox3.GradientColor = Color.Empty;
            kComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

            kComboBox3.Name = "kComboBox3";
            kComboBox3.Size = new Size(156, 34);
            kComboBox3.TabIndex = 21;
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
            // kLabel5
            //
            kLabel5.AutoSize = false;
            kLabel5.BackColor = Color.Transparent;
            kLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel5.Location = new Point(16, 70);
            kLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            kLabel5.Font = new Font("Inter", 9F);
            kLabel5.TabStop = false;
            kLabel5.Name = "kLabel5";
            kLabel5.Size = new Size(354, 24);
            kLabel5.TabIndex = 1;
            kLabel5.Text = "Nombre, código o DPI";
            kLabel5.TextAlign = ContentAlignment.MiddleLeft;
            kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // kLabel1
            //
            kLabel1.AutoSize = false;
            kLabel1.BackColor = Color.Transparent;
            kLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel1.Location = new Point(16, 268);
            kLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kLabel1.Font = new Font("Inter", 9F);
            kLabel1.TabStop = false;
            kLabel1.Name = "kLabel1";
            kLabel1.Size = new Size(1094, 24);
            kLabel1.TabIndex = 15;
            kLabel1.Text = "Plantilla del personal";
            kLabel1.TextAlign = ContentAlignment.MiddleLeft;
            kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
            Controls.Add(kLabel1);
            Controls.Add(dgvEmpleados);
            Controls.Add(kLabel5);
            Controls.Add(txtBuscar);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(kLabel4);
            Controls.Add(cboEstado);
            Controls.Add(kLabel3);
            Controls.Add(cboTipoContrato);
            Controls.Add(kLabel2);
            Controls.Add(cboDepartamento);
            Controls.Add(kLabel7);
            Controls.Add(kButton6);
            Controls.Add(kLabel8);
            Controls.Add(kButton5);
            Controls.Add(kComboBox3);
            Controls.Add(lblTamanoPagina);
            MinimumSize = new Size(1126, 744);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3);
            Font = new Font("Segoe UI", 9F);
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

        private KovaqsUI.Controls.KLabel kLabel7;
        private KovaqsUI.Controls.KComboBox cboDepartamento;
        private KovaqsUI.Controls.KLabel kLabel2;
        private KovaqsUI.Controls.KLabel kLabel3;
        private KovaqsUI.Controls.KComboBox cboTipoContrato;
        private KovaqsUI.Controls.KLabel kLabel4;
        private KovaqsUI.Controls.KComboBox cboEstado;
        private KovaqsUI.Controls.KButton btnAgregarEmpleado;
        private KovaqsUI.Controls.KDataGridView dgvEmpleados;
        private KovaqsUI.Controls.KButton kButton6;
        private KovaqsUI.Controls.KLabel kLabel8;
        private KovaqsUI.Controls.KButton kButton5;
        private KovaqsUI.Controls.KComboBox kComboBox3;
        private KovaqsUI.Controls.KTextBox txtBuscar;
        private KovaqsUI.Controls.KLabel kLabel5;
        private KovaqsUI.Controls.KLabel kLabel1;
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
