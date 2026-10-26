namespace Presentacion.Forms.Secciones
{
    partial class FrmEmpleados2
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            kLabel7 = new KovaqsUI.Controls.KLabel();
            cboDepartamento = new KovaqsUI.Controls.KComboBox();
            kLabel2 = new KovaqsUI.Controls.KLabel();
            kLabel3 = new KovaqsUI.Controls.KLabel();
            cboTipoContrato = new KovaqsUI.Controls.KComboBox();
            kLabel4 = new KovaqsUI.Controls.KLabel();
            cboEstado = new KovaqsUI.Controls.KComboBox();
            btnAgregarEmpleado = new KovaqsUI.Controls.KButton();
            btnEditarEmpleado = new KovaqsUI.Controls.KButton();
            btnHistorialLaboral = new KovaqsUI.Controls.KButton();
            btnEstadoEmpleado = new KovaqsUI.Controls.KButton();
            kButton4 = new KovaqsUI.Controls.KButton();
            dgvEmpleados = new KovaqsUI.Controls.KDataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            kButton6 = new KovaqsUI.Controls.KButton();
            kLabel8 = new KovaqsUI.Controls.KLabel();
            kButton5 = new KovaqsUI.Controls.KButton();
            kComboBox3 = new KovaqsUI.Controls.KComboBox();
            kButton7 = new KovaqsUI.Controls.KButton();
            txtBuscar = new KovaqsUI.Controls.KTextBox();
            kLabel5 = new KovaqsUI.Controls.KLabel();
            kLabel1 = new KovaqsUI.Controls.KLabel();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kLabel7
            // 
            kLabel7.AutoSize = false;
            kLabel7.BackColor = Color.Transparent;
            kLabel7.Dock = DockStyle.Top;
            kLabel7.Location = new Point(0, 0);
            kLabel7.Name = "kLabel7";
            kLabel7.Size = new Size(902, 43);
            kLabel7.TabIndex = 17;
            kLabel7.Text = "Listado de empleados";
            kLabel7.TextRole = KovaqsUI.Controls.KTextRole.Title;
            // 
            // cboDepartamento
            // 
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.ItemHeight = 28;
            cboDepartamento.Location = new Point(278, 86);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(244, 34);
            cboDepartamento.TabIndex = 21;
            // 
            // kLabel2
            // 
            kLabel2.AutoSize = false;
            kLabel2.BackColor = Color.Transparent;
            kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel2.Location = new Point(278, 60);
            kLabel2.Name = "kLabel2";
            kLabel2.Size = new Size(244, 23);
            kLabel2.TabIndex = 22;
            kLabel2.Text = "Departamento";
            kLabel2.TextAlign = ContentAlignment.MiddleLeft;
            kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel3
            // 
            kLabel3.AutoSize = false;
            kLabel3.BackColor = Color.Transparent;
            kLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel3.Location = new Point(538, 60);
            kLabel3.Name = "kLabel3";
            kLabel3.Size = new Size(244, 23);
            kLabel3.TabIndex = 24;
            kLabel3.Text = "Tipo de contrato";
            kLabel3.TextAlign = ContentAlignment.MiddleLeft;
            kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // cboTipoContrato
            // 
            cboTipoContrato.FormattingEnabled = true;
            cboTipoContrato.ItemHeight = 28;
            cboTipoContrato.Location = new Point(538, 86);
            cboTipoContrato.Name = "cboTipoContrato";
            cboTipoContrato.Size = new Size(244, 34);
            cboTipoContrato.TabIndex = 23;
            // 
            // kLabel4
            // 
            kLabel4.AutoSize = false;
            kLabel4.BackColor = Color.Transparent;
            kLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel4.Location = new Point(15, 128);
            kLabel4.Name = "kLabel4";
            kLabel4.Size = new Size(244, 23);
            kLabel4.TabIndex = 26;
            kLabel4.Text = "Estado";
            kLabel4.TextAlign = ContentAlignment.MiddleLeft;
            kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.ItemHeight = 28;
            cboEstado.Location = new Point(15, 154);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(244, 34);
            cboEstado.TabIndex = 25;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.BackColor = Color.Transparent;
            btnAgregarEmpleado.CornerRadius = 8;
            btnAgregarEmpleado.FlatStyle = FlatStyle.Flat;
            btnAgregarEmpleado.Font = new Font("Inter", 9F);
            btnAgregarEmpleado.Location = new Point(12, 208);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Padding = new Padding(12, 4, 12, 4);
            btnAgregarEmpleado.Size = new Size(140, 40);
            btnAgregarEmpleado.TabIndex = 27;
            btnAgregarEmpleado.Text = "Agregar";
            btnAgregarEmpleado.UseVisualStyleBackColor = false;
            btnAgregarEmpleado.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
            // 
            // btnEditarEmpleado
            // 
            btnEditarEmpleado.BackColor = Color.Transparent;
            btnEditarEmpleado.CornerRadius = 8;
            btnEditarEmpleado.FlatStyle = FlatStyle.Flat;
            btnEditarEmpleado.Font = new Font("Inter", 9F);
            btnEditarEmpleado.Location = new Point(158, 208);
            btnEditarEmpleado.Name = "btnEditarEmpleado";
            btnEditarEmpleado.Padding = new Padding(12, 4, 12, 4);
            btnEditarEmpleado.Size = new Size(140, 40);
            btnEditarEmpleado.TabIndex = 30;
            btnEditarEmpleado.Text = "Editar";
            btnEditarEmpleado.UseVisualStyleBackColor = false;
            btnEditarEmpleado.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // btnHistorialLaboral
            // 
            btnHistorialLaboral.BackColor = Color.Transparent;
            btnHistorialLaboral.CornerRadius = 8;
            btnHistorialLaboral.FlatStyle = FlatStyle.Flat;
            btnHistorialLaboral.Font = new Font("Inter", 9F);
            btnHistorialLaboral.Location = new Point(304, 208);
            btnHistorialLaboral.Name = "btnHistorialLaboral";
            btnHistorialLaboral.Padding = new Padding(12, 4, 12, 4);
            btnHistorialLaboral.Size = new Size(140, 40);
            btnHistorialLaboral.TabIndex = 31;
            btnHistorialLaboral.Text = "Historial";
            btnHistorialLaboral.UseVisualStyleBackColor = false;
            btnHistorialLaboral.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // btnEstadoEmpleado
            // 
            btnEstadoEmpleado.BackColor = Color.Transparent;
            btnEstadoEmpleado.CornerRadius = 8;
            btnEstadoEmpleado.FlatStyle = FlatStyle.Flat;
            btnEstadoEmpleado.Font = new Font("Inter", 9F);
            btnEstadoEmpleado.Location = new Point(450, 208);
            btnEstadoEmpleado.Name = "btnEstadoEmpleado";
            btnEstadoEmpleado.Padding = new Padding(12, 4, 12, 4);
            btnEstadoEmpleado.Size = new Size(140, 40);
            btnEstadoEmpleado.TabIndex = 32;
            btnEstadoEmpleado.Text = "Cambiar estado";
            btnEstadoEmpleado.UseVisualStyleBackColor = false;
            btnEstadoEmpleado.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // kButton4
            // 
            kButton4.BackColor = Color.Transparent;
            kButton4.CornerRadius = 8;
            kButton4.FlatStyle = FlatStyle.Flat;
            kButton4.Font = new Font("Inter", 9F);
            kButton4.Location = new Point(596, 208);
            kButton4.Name = "kButton4";
            kButton4.Padding = new Padding(12, 4, 12, 4);
            kButton4.Size = new Size(140, 40);
            kButton4.TabIndex = 33;
            kButton4.Text = "Constancia";
            kButton4.UseVisualStyleBackColor = false;
            kButton4.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.BorderStyle = BorderStyle.None;
            dgvEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(119, 119, 119);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(119, 119, 119);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(13, 21, 23);
            dataGridViewCellStyle5.Padding = new Padding(8, 4, 8, 4);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(223, 233, 249);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(13, 21, 23);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle5;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.GridColor = Color.FromArgb(218, 218, 218);
            dgvEmpleados.Location = new Point(12, 277);
            dgvEmpleados.Name = "dgvEmpleados";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(119, 119, 119);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(244, 244, 244);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(119, 119, 119);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvEmpleados.RowHeadersVisible = false;
            dgvEmpleados.RowTemplate.Height = 42;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(878, 340);
            dgvEmpleados.TabIndex = 35;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(kButton6);
            flowLayoutPanel1.Controls.Add(kLabel8);
            flowLayoutPanel1.Controls.Add(kButton5);
            flowLayoutPanel1.Controls.Add(kComboBox3);
            flowLayoutPanel1.Location = new Point(12, 623);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(878, 38);
            flowLayoutPanel1.TabIndex = 36;
            // 
            // kButton6
            // 
            kButton6.BackColor = Color.Transparent;
            kButton6.CornerRadius = 5;
            kButton6.FlatStyle = FlatStyle.Flat;
            kButton6.Font = new Font("Inter", 10F);
            kButton6.Location = new Point(3, 3);
            kButton6.Name = "kButton6";
            kButton6.Padding = new Padding(12, 4, 12, 4);
            kButton6.Size = new Size(124, 26);
            kButton6.TabIndex = 41;
            kButton6.Text = "Anterior";
            kButton6.UseVisualStyleBackColor = false;
            kButton6.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // kLabel8
            // 
            kLabel8.AutoSize = false;
            kLabel8.BackColor = Color.Transparent;
            kLabel8.Font = new Font("Inter", 10F);
            kLabel8.ForeColor = Color.Purple;
            kLabel8.Location = new Point(133, 0);
            kLabel8.Name = "kLabel8";
            kLabel8.Size = new Size(121, 37);
            kLabel8.TabIndex = 40;
            kLabel8.Text = "Página 1 de 1";
            kLabel8.TextAlign = ContentAlignment.MiddleCenter;
            kLabel8.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kButton5
            // 
            kButton5.BackColor = Color.Transparent;
            kButton5.CornerRadius = 5;
            kButton5.FlatStyle = FlatStyle.Flat;
            kButton5.Font = new Font("Inter", 10F);
            kButton5.Location = new Point(260, 3);
            kButton5.Name = "kButton5";
            kButton5.Padding = new Padding(12, 4, 12, 4);
            kButton5.Size = new Size(124, 26);
            kButton5.TabIndex = 39;
            kButton5.Text = "Siguiente";
            kButton5.UseVisualStyleBackColor = false;
            kButton5.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // kComboBox3
            // 
            kComboBox3.FormattingEnabled = true;
            kComboBox3.ItemHeight = 28;
            kComboBox3.Location = new Point(390, 3);
            kComboBox3.Name = "kComboBox3";
            kComboBox3.Size = new Size(244, 34);
            kComboBox3.TabIndex = 42;
            // 
            // kButton7
            // 
            kButton7.BackColor = Color.Transparent;
            kButton7.CornerRadius = 8;
            kButton7.FlatStyle = FlatStyle.Flat;
            kButton7.Font = new Font("Inter", 9F);
            kButton7.Location = new Point(742, 208);
            kButton7.Name = "kButton7";
            kButton7.Padding = new Padding(12, 4, 12, 4);
            kButton7.Size = new Size(140, 40);
            kButton7.TabIndex = 37;
            kButton7.Text = "Eliminar";
            kButton7.UseVisualStyleBackColor = false;
            kButton7.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
            // 
            // txtBuscar
            // 
            txtBuscar.Appearance.Normal.FillColor = Color.White;
            txtBuscar.BackColor = Color.Transparent;
            txtBuscar.CornerRadius = 8;
            txtBuscar.FillColor = Color.White;
            txtBuscar.Location = new Point(15, 86);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Padding = new Padding(12, 8, 12, 8);
            txtBuscar.PasswordChar = '●';
            txtBuscar.Size = new Size(244, 34);
            txtBuscar.TabIndex = 28;
            // 
            // kLabel5
            // 
            kLabel5.AutoSize = false;
            kLabel5.BackColor = Color.Transparent;
            kLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel5.Location = new Point(15, 60);
            kLabel5.Name = "kLabel5";
            kLabel5.Size = new Size(244, 23);
            kLabel5.TabIndex = 29;
            kLabel5.Text = "DPI";
            kLabel5.TextAlign = ContentAlignment.MiddleLeft;
            kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // kLabel1
            // 
            kLabel1.AutoSize = false;
            kLabel1.BackColor = Color.Transparent;
            kLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel1.Location = new Point(15, 251);
            kLabel1.Name = "kLabel1";
            kLabel1.Size = new Size(244, 23);
            kLabel1.TabIndex = 38;
            kLabel1.Text = "Plantilla del personal";
            kLabel1.TextAlign = ContentAlignment.MiddleLeft;
            kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            // 
            // FrmEmpleados2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(902, 669);
            Controls.Add(kLabel1);
            Controls.Add(kButton7);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dgvEmpleados);
            Controls.Add(kButton4);
            Controls.Add(btnEstadoEmpleado);
            Controls.Add(btnHistorialLaboral);
            Controls.Add(btnEditarEmpleado);
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
            Name = "FrmEmpleados2";
            Text = "FrmEmpleados2";
            Load += FrmEmpleados2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private KovaqsUI.Controls.KLabel kLabel7;
        private KovaqsUI.Controls.KComboBox cboDepartamento;
        private KovaqsUI.Controls.KLabel kLabel2;
        private KovaqsUI.Controls.KLabel kLabel3;
        private KovaqsUI.Controls.KComboBox cboTipoContrato;
        private KovaqsUI.Controls.KLabel kLabel4;
        private KovaqsUI.Controls.KComboBox cboEstado;
        private KovaqsUI.Controls.KButton btnAgregarEmpleado;
        private KovaqsUI.Controls.KButton btnEditarEmpleado;
        private KovaqsUI.Controls.KButton btnHistorialLaboral;
        private KovaqsUI.Controls.KButton btnEstadoEmpleado;
        private KovaqsUI.Controls.KButton kButton4;
        private KovaqsUI.Controls.KDataGridView dgvEmpleados;
        private FlowLayoutPanel flowLayoutPanel1;
        private KovaqsUI.Controls.KButton kButton6;
        private KovaqsUI.Controls.KLabel kLabel8;
        private KovaqsUI.Controls.KButton kButton5;
        private KovaqsUI.Controls.KButton kButton7;
        private KovaqsUI.Controls.KComboBox kComboBox3;
        private KovaqsUI.Controls.KTextBox txtBuscar;
        private KovaqsUI.Controls.KLabel kLabel5;
        private KovaqsUI.Controls.KLabel kLabel1;
    }
}