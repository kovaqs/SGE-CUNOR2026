namespace Presentacion.Forms.Secciones;

partial class FrmPuestos
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
        DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        txtBuscar = new KovaqsUI.Controls.KTextBox();
        lblNombrePuesto = new KovaqsUI.Controls.KLabel();
        lblDepartamento = new KovaqsUI.Controls.KLabel();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        lblEstado = new KovaqsUI.Controls.KLabel();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        btnAgregarPuesto = new KovaqsUI.Controls.KButton();
        btnEditarPuesto = new KovaqsUI.Controls.KButton();
        btnEliminarPuesto = new KovaqsUI.Controls.KButton();
        lblPuestos = new KovaqsUI.Controls.KLabel();
        dgvPuestos = new KovaqsUI.Controls.KDataGridView();
        lblPagina = new KovaqsUI.Controls.KLabel();
        btnAnterior = new KovaqsUI.Controls.KButton();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        cbotamanoPagina = new KovaqsUI.Controls.KComboBox();
        lblEtiquetaEstado = new KovaqsUI.Controls.KLabel();
        flowLayoutPanel1 = new FlowLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
        flowLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Dock = DockStyle.Top;
        lblTitulo.Font = new Font("Inter SemiBold", 23F);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(902, 43);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Puestos de trabajo";
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        // 
        // txtBuscar
        // 
        txtBuscar.BackColor = Color.White;
        txtBuscar.CornerRadius = 8;
        txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtBuscar.Location = new Point(12, 80);
        txtBuscar.Margin = new Padding(3, 2, 3, 2);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Padding = new Padding(10, 5, 10, 5);
        txtBuscar.Size = new Size(238, 34);
        txtBuscar.TabIndex = 1;
        // 
        // lblNombrePuesto
        // 
        lblNombrePuesto.BackColor = Color.Transparent;
        lblNombrePuesto.Font = new Font("Segoe UI", 9F);
        lblNombrePuesto.Location = new Point(15, 52);
        lblNombrePuesto.Name = "lblNombrePuesto";
        lblNombrePuesto.Size = new Size(109, 15);
        lblNombrePuesto.TabIndex = 2;
        lblNombrePuesto.Text = "Nombre del puesto";
        // 
        // lblDepartamento
        // 
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.Font = new Font("Segoe UI", 9F);
        lblDepartamento.Location = new Point(281, 52);
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(83, 15);
        lblDepartamento.TabIndex = 3;
        lblDepartamento.Text = "Departamento";
        // 
        // cboDepartamento
        // 
        cboDepartamento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.ItemHeight = 28;
        cboDepartamento.Location = new Point(281, 80);
        cboDepartamento.Margin = new Padding(3, 2, 3, 2);
        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(189, 34);
        cboDepartamento.TabIndex = 4;
        // 
        // lblEstado
        // 
        lblEstado.BackColor = Color.Transparent;
        lblEstado.Font = new Font("Segoe UI", 9F);
        lblEstado.Location = new Point(482, 52);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(42, 15);
        lblEstado.TabIndex = 5;
        lblEstado.Text = "Estado";
        // 
        // cboEstado
        // 
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Items.AddRange(new object[] { "Todos", "", "Activos", "", "Inactivos" });
        cboEstado.Location = new Point(482, 80);
        cboEstado.Margin = new Padding(3, 2, 3, 2);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(189, 34);
        cboEstado.TabIndex = 6;
        // 
        // btnAgregarPuesto
        // 
        btnAgregarPuesto.BackColor = Color.Transparent;
        btnAgregarPuesto.CornerRadius = 8;
        btnAgregarPuesto.FlatStyle = FlatStyle.Flat;
        btnAgregarPuesto.Font = new Font("Inter", 9F);
        btnAgregarPuesto.Location = new Point(12, 128);
        btnAgregarPuesto.Margin = new Padding(3, 2, 3, 2);
        btnAgregarPuesto.Name = "btnAgregarPuesto";
        btnAgregarPuesto.Padding = new Padding(10, 3, 10, 3);
        btnAgregarPuesto.Size = new Size(240, 40);
        btnAgregarPuesto.TabIndex = 7;
        btnAgregarPuesto.Text = "Agregar";
        btnAgregarPuesto.UseVisualStyleBackColor = false;
        btnAgregarPuesto.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        // 
        // btnEditarPuesto
        // 
        btnEditarPuesto.BackColor = Color.Transparent;
        btnEditarPuesto.CornerRadius = 8;
        btnEditarPuesto.FlatStyle = FlatStyle.Flat;
        btnEditarPuesto.Font = new Font("Inter", 9F);
        btnEditarPuesto.Location = new Point(281, 128);
        btnEditarPuesto.Margin = new Padding(3, 2, 3, 2);
        btnEditarPuesto.Name = "btnEditarPuesto";
        btnEditarPuesto.Padding = new Padding(10, 3, 10, 3);
        btnEditarPuesto.Size = new Size(189, 40);
        btnEditarPuesto.TabIndex = 8;
        btnEditarPuesto.Text = "Editar";
        btnEditarPuesto.UseVisualStyleBackColor = false;
        btnEditarPuesto.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // btnEliminarPuesto
        // 
        btnEliminarPuesto.BackColor = Color.Transparent;
        btnEliminarPuesto.CornerRadius = 8;
        btnEliminarPuesto.FlatStyle = FlatStyle.Flat;
        btnEliminarPuesto.Font = new Font("Inter", 9F);
        btnEliminarPuesto.Location = new Point(482, 128);
        btnEliminarPuesto.Margin = new Padding(3, 2, 3, 2);
        btnEliminarPuesto.Name = "btnEliminarPuesto";
        btnEliminarPuesto.Padding = new Padding(10, 3, 10, 3);
        btnEliminarPuesto.Size = new Size(189, 40);
        btnEliminarPuesto.TabIndex = 9;
        btnEliminarPuesto.Text = "Eliminar";
        btnEliminarPuesto.UseVisualStyleBackColor = false;
        btnEliminarPuesto.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
        // 
        // lblPuestos
        // 
        lblPuestos.BackColor = Color.Transparent;
        lblPuestos.Font = new Font("Inter", 9F);
        lblPuestos.Location = new Point(12, 186);
        lblPuestos.Name = "lblPuestos";
        lblPuestos.Size = new Size(52, 15);
        lblPuestos.TabIndex = 10;
        lblPuestos.Text = "Puestos";
        // 
        // dgvPuestos
        // 
        dgvPuestos.AllowUserToAddRows = false;
        dgvPuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPuestos.BackgroundColor = Color.White;
        dgvPuestos.BorderStyle = BorderStyle.None;
        dgvPuestos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle25.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle25.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle25.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle25.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
        dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
        dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle26.BackColor = Color.White;
        dataGridViewCellStyle26.Font = new Font("Microsoft Sans Serif", 10F);
        dataGridViewCellStyle26.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle26.Padding = new Padding(10, 5, 10, 5);
        dataGridViewCellStyle26.SelectionBackColor = Color.FromArgb(223, 233, 249);
        dataGridViewCellStyle26.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle26.WrapMode = DataGridViewTriState.False;
        dgvPuestos.DefaultCellStyle = dataGridViewCellStyle26;
        dgvPuestos.EnableHeadersVisualStyles = false;
        dgvPuestos.GridColor = Color.FromArgb(218, 218, 218);
        dgvPuestos.Location = new Point(12, 203);
        dgvPuestos.Margin = new Padding(3, 2, 3, 2);
        dgvPuestos.Name = "dgvPuestos";
        dgvPuestos.ReadOnly = true;
        dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle27.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle27.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle27.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle27.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
        dgvPuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
        dgvPuestos.RowHeadersVisible = false;
        dgvPuestos.RowHeadersWidth = 51;
        dgvPuestos.RowTemplate.Height = 52;
        dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPuestos.Size = new Size(878, 415);
        dgvPuestos.TabIndex = 11;
        dgvPuestos.SelectionChanged += dgvPuestos_SelectionChanged;
        // 
        // lblPagina
        // 
        lblPagina.AutoSize = false;
        lblPagina.BackColor = Color.Transparent;
        lblPagina.Font = new Font("Inter", 10F);
        lblPagina.ForeColor = Color.Purple;
        lblPagina.Location = new Point(133, 0);
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(105, 36);
        lblPagina.TabIndex = 12;
        lblPagina.Text = "Pagina 1 De 1";
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnAnterior
        // 
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.CornerRadius = 8;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Font = new Font("Inter", 10F);
        btnAnterior.Location = new Point(244, 2);
        btnAnterior.Margin = new Padding(3, 2, 3, 2);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Padding = new Padding(10, 3, 10, 3);
        btnAnterior.Size = new Size(124, 26);
        btnAnterior.TabIndex = 13;
        btnAnterior.Text = "Anterior";
        btnAnterior.UseVisualStyleBackColor = false;
        btnAnterior.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // btnSiguiente
        // 
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.CornerRadius = 8;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.Font = new Font("Inter", 10F);
        btnSiguiente.Location = new Point(3, 2);
        btnSiguiente.Margin = new Padding(3, 2, 3, 2);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Padding = new Padding(10, 3, 10, 3);
        btnSiguiente.Size = new Size(124, 26);
        btnSiguiente.TabIndex = 14;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.UseVisualStyleBackColor = false;
        btnSiguiente.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // cbotamanoPagina
        // 
        cbotamanoPagina.FormattingEnabled = true;
        cbotamanoPagina.ItemHeight = 28;
        cbotamanoPagina.Items.AddRange(new object[] { "10", "", "25", "50", "10" });
        cbotamanoPagina.Location = new Point(374, 2);
        cbotamanoPagina.Margin = new Padding(3, 2, 3, 2);
        cbotamanoPagina.Name = "cbotamanoPagina";
        cbotamanoPagina.Size = new Size(189, 34);
        cbotamanoPagina.TabIndex = 16;
        // 
        // lblEtiquetaEstado
        // 
        lblEtiquetaEstado.BackColor = Color.Transparent;
        lblEtiquetaEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblEtiquetaEstado.Location = new Point(31, 526);
        lblEtiquetaEstado.Name = "lblEtiquetaEstado";
        lblEtiquetaEstado.Size = new Size(0, 15);
        lblEtiquetaEstado.TabIndex = 17;
        // 
        // flowLayoutPanel1
        //
        flowLayoutPanel1.Controls.Add(btnSiguiente);
        flowLayoutPanel1.Controls.Add(lblPagina);
        flowLayoutPanel1.Controls.Add(btnAnterior);
        flowLayoutPanel1.Controls.Add(cbotamanoPagina);
        flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        flowLayoutPanel1.Location = new Point(12, 623);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(878, 38);
        flowLayoutPanel1.TabIndex = 18;
        //
        // FrmPuestos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(lblEtiquetaEstado);
        Controls.Add(dgvPuestos);
        Controls.Add(lblPuestos);
        Controls.Add(btnEliminarPuesto);
        Controls.Add(btnEditarPuesto);
        Controls.Add(btnAgregarPuesto);
        Controls.Add(cboEstado);
        Controls.Add(lblEstado);
        Controls.Add(cboDepartamento);
        Controls.Add(lblDepartamento);
        Controls.Add(lblNombrePuesto);
        Controls.Add(txtBuscar);
        Controls.Add(lblTitulo);
        Name = "FrmPuestos";
        Text = "Puestos";
        Load += FrmPuestos_Load;
        ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
        flowLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KTextBox txtBuscar;
    private KovaqsUI.Controls.KLabel lblNombrePuesto;
    private KovaqsUI.Controls.KLabel lblDepartamento;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KLabel lblEstado;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KButton btnAgregarPuesto;
    private KovaqsUI.Controls.KButton btnEditarPuesto;
    private KovaqsUI.Controls.KButton btnEliminarPuesto;
    private KovaqsUI.Controls.KLabel lblPuestos;
    private KovaqsUI.Controls.KDataGridView dgvPuestos;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KComboBox cbotamanoPagina;
    private KovaqsUI.Controls.KLabel lblEtiquetaEstado;
    private FlowLayoutPanel flowLayoutPanel1;
}
