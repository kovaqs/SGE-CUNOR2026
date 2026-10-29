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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
        Puesto = new DataGridViewTextBoxColumn();
        Departamento = new DataGridViewTextBoxColumn();
        Descripcion = new DataGridViewTextBoxColumn();
        Activo = new DataGridViewTextBoxColumn();
        lblPagina = new KovaqsUI.Controls.KLabel();
        btnAnterior = new KovaqsUI.Controls.KButton();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        lblFilasPagina = new KovaqsUI.Controls.KLabel();
        cbotamanoPagina = new KovaqsUI.Controls.KComboBox();
        lblEtiquetaEstado = new KovaqsUI.Controls.KLabel();
        ((System.ComponentModel.ISupportInitialize)dgvPuestos).BeginInit();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.Black;
        lblTitulo.Location = new Point(26, 9);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(279, 41);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Puestos de trabajo";
        // 
        // txtBuscar
        // 
        txtBuscar.BackColor = Color.White;
        txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtBuscar.Location = new Point(35, 106);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Padding = new Padding(11, 7, 11, 7);
        txtBuscar.Size = new Size(215, 35);
        txtBuscar.TabIndex = 1;
        // 
        // lblNombrePuesto
        // 
        lblNombrePuesto.BackColor = Color.Transparent;
        lblNombrePuesto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblNombrePuesto.Location = new Point(35, 70);
        lblNombrePuesto.Name = "lblNombrePuesto";
        lblNombrePuesto.Size = new Size(144, 20);
        lblNombrePuesto.TabIndex = 2;
        lblNombrePuesto.Text = "Nombre del puesto";
        // 
        // lblDepartamento
        // 
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblDepartamento.Location = new Point(299, 70);
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(111, 20);
        lblDepartamento.TabIndex = 3;
        lblDepartamento.Text = "Departamento";
        // 
        // cboDepartamento
        // 
        cboDepartamento.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.ItemHeight = 28;
        cboDepartamento.Location = new Point(299, 107);
        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(215, 34);
        cboDepartamento.TabIndex = 4;
        // 
        // lblEstado
        // 
        lblEstado.BackColor = Color.Transparent;
        lblEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblEstado.Location = new Point(551, 70);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(56, 20);
        lblEstado.TabIndex = 5;
        lblEstado.Text = "Estado";
        // 
        // cboEstado
        // 
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Items.AddRange(new object[] { "Todos", "", "Activos", "", "Inactivos" });
        cboEstado.Location = new Point(551, 106);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(215, 34);
        cboEstado.TabIndex = 6;
        // 
        // btnAgregarPuesto
        // 
        btnAgregarPuesto.BackColor = Color.Transparent;
        btnAgregarPuesto.FlatStyle = FlatStyle.Flat;
        btnAgregarPuesto.Location = new Point(55, 171);
        btnAgregarPuesto.Name = "btnAgregarPuesto";
        btnAgregarPuesto.Padding = new Padding(12, 4, 12, 4);
        btnAgregarPuesto.Size = new Size(165, 36);
        btnAgregarPuesto.TabIndex = 7;
        btnAgregarPuesto.Text = "Agregar";
        btnAgregarPuesto.UseVisualStyleBackColor = false;
        // 
        // btnEditarPuesto
        // 
        btnEditarPuesto.BackColor = Color.Transparent;
        btnEditarPuesto.FlatStyle = FlatStyle.Flat;
        btnEditarPuesto.Location = new Point(329, 171);
        btnEditarPuesto.Name = "btnEditarPuesto";
        btnEditarPuesto.Padding = new Padding(12, 4, 12, 4);
        btnEditarPuesto.Size = new Size(165, 36);
        btnEditarPuesto.TabIndex = 8;
        btnEditarPuesto.Text = "Editar";
        btnEditarPuesto.UseVisualStyleBackColor = false;
        // 
        // btnEliminarPuesto
        // 
        btnEliminarPuesto.BackColor = Color.Transparent;
        btnEliminarPuesto.FlatStyle = FlatStyle.Flat;
        btnEliminarPuesto.Location = new Point(579, 171);
        btnEliminarPuesto.Name = "btnEliminarPuesto";
        btnEliminarPuesto.Padding = new Padding(12, 4, 12, 4);
        btnEliminarPuesto.Size = new Size(165, 36);
        btnEliminarPuesto.TabIndex = 9;
        btnEliminarPuesto.Text = "Eliminar";
        btnEliminarPuesto.UseVisualStyleBackColor = false;
        // 
        // lblPuestos
        // 
        lblPuestos.BackColor = Color.Transparent;
        lblPuestos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPuestos.Location = new Point(35, 248);
        lblPuestos.Name = "lblPuestos";
        lblPuestos.Size = new Size(64, 20);
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
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle4.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        dgvPuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
        dgvPuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPuestos.Columns.AddRange(new DataGridViewColumn[] { Puesto, Departamento, Descripcion, Activo });
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = Color.White;
        dataGridViewCellStyle5.Font = new Font("Inter", 10F);
        dataGridViewCellStyle5.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle5.Padding = new Padding(10, 5, 10, 5);
        dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(223, 233, 249);
        dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
        dgvPuestos.DefaultCellStyle = dataGridViewCellStyle5;
        dgvPuestos.EnableHeadersVisualStyles = false;
        dgvPuestos.GridColor = Color.FromArgb(218, 218, 218);
        dgvPuestos.Location = new Point(35, 280);
        dgvPuestos.Name = "dgvPuestos";
        dgvPuestos.ReadOnly = true;
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle6.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
        dgvPuestos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
        dgvPuestos.RowHeadersVisible = false;
        dgvPuestos.RowHeadersWidth = 51;
        dgvPuestos.RowTemplate.Height = 52;
        dgvPuestos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPuestos.Size = new Size(680, 300);
        dgvPuestos.TabIndex = 11;
        dgvPuestos.SelectionChanged += dgvPuestos_SelectionChanged;
        // 
        // Puesto
        // 
        Puesto.HeaderText = "Puesto";
        Puesto.MinimumWidth = 6;
        Puesto.Name = "Puesto";
        Puesto.ReadOnly = true;
        // 
        // Departamento
        // 
        Departamento.HeaderText = "Departamento";
        Departamento.MinimumWidth = 6;
        Departamento.Name = "Departamento";
        Departamento.ReadOnly = true;
        // 
        // Descripcion
        // 
        Descripcion.HeaderText = "Descripcion";
        Descripcion.MinimumWidth = 6;
        Descripcion.Name = "Descripcion";
        Descripcion.ReadOnly = true;
        // 
        // Activo
        // 
        Activo.HeaderText = "Activo";
        Activo.MinimumWidth = 6;
        Activo.Name = "Activo";
        Activo.ReadOnly = true;
        // 
        // lblPagina
        // 
        lblPagina.BackColor = Color.Transparent;
        lblPagina.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPagina.Location = new Point(221, 640);
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(105, 20);
        lblPagina.TabIndex = 12;
        lblPagina.Text = "Pagina 1 De 1";
        // 
        // btnAnterior
        // 
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Location = new Point(35, 632);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Padding = new Padding(12, 4, 12, 4);
        btnAnterior.Size = new Size(165, 36);
        btnAnterior.TabIndex = 13;
        btnAnterior.Text = "Anterior";
        btnAnterior.UseVisualStyleBackColor = false;
        // 
        // btnSiguiente
        // 
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.Location = new Point(349, 632);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Padding = new Padding(12, 4, 12, 4);
        btnSiguiente.Size = new Size(165, 36);
        btnSiguiente.TabIndex = 14;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.UseVisualStyleBackColor = false;
        // 
        // lblFilasPagina
        // 
        lblFilasPagina.BackColor = Color.Transparent;
        lblFilasPagina.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblFilasPagina.Location = new Point(788, 599);
        lblFilasPagina.Name = "lblFilasPagina";
        lblFilasPagina.Size = new Size(119, 20);
        lblFilasPagina.TabIndex = 15;
        lblFilasPagina.Text = "Filas por página";
        // 
        // cbotamanoPagina
        // 
        cbotamanoPagina.FormattingEnabled = true;
        cbotamanoPagina.ItemHeight = 28;
        cbotamanoPagina.Items.AddRange(new object[] { "10", "", "25", "50", "10" });
        cbotamanoPagina.Location = new Point(788, 634);
        cbotamanoPagina.Name = "cbotamanoPagina";
        cbotamanoPagina.Size = new Size(215, 34);
        cbotamanoPagina.TabIndex = 16;
        // 
        // lblEtiquetaEstado
        // 
        lblEtiquetaEstado.BackColor = Color.Transparent;
        lblEtiquetaEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblEtiquetaEstado.Location = new Point(35, 702);
        lblEtiquetaEstado.Name = "lblEtiquetaEstado";
        lblEtiquetaEstado.Size = new Size(0, 20);
        lblEtiquetaEstado.TabIndex = 17;
        // 
        // FrmPuestos
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1031, 892);
        Controls.Add(lblEtiquetaEstado);
        Controls.Add(cbotamanoPagina);
        Controls.Add(lblFilasPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(btnAnterior);
        Controls.Add(lblPagina);
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
        Margin = new Padding(3, 4, 3, 4);
        Name = "FrmPuestos";
        Text = "Puestos";
        ((System.ComponentModel.ISupportInitialize)dgvPuestos).EndInit();
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
    private DataGridViewTextBoxColumn Puesto;
    private DataGridViewTextBoxColumn Departamento;
    private DataGridViewTextBoxColumn Descripcion;
    private DataGridViewTextBoxColumn Activo;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KLabel lblFilasPagina;
    private KovaqsUI.Controls.KComboBox cbotamanoPagina;
    private KovaqsUI.Controls.KLabel lblEtiquetaEstado;
}
