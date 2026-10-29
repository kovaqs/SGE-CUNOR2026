namespace Presentacion.Forms.Secciones;

partial class FrmNomina
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        dateTimePicker1 = new DateTimePicker();
        dateTimePicker2 = new DateTimePicker();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        btnNuevoPeriodo = new KovaqsUI.Controls.KButton();
        btnVerPeriodo = new KovaqsUI.Controls.KButton();
        btnBoletas = new KovaqsUI.Controls.KButton();
        btnAnterior = new KovaqsUI.Controls.KButton();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        kLabel2 = new KovaqsUI.Controls.KLabel();
        kLabel3 = new KovaqsUI.Controls.KLabel();
        lblEstado = new KovaqsUI.Controls.KLabel();
        kLabel4 = new KovaqsUI.Controls.KLabel();
        kDataGridView1 = new KovaqsUI.Controls.KDataGridView();
        lblPagina = new KovaqsUI.Controls.KLabel();
        kLabel1 = new KovaqsUI.Controls.KLabel();
        ((System.ComponentModel.ISupportInitialize)kDataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker1.Format = DateTimePickerFormat.Custom;
        dateTimePicker1.Location = new Point(23, 104);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(313, 32);
        dateTimePicker1.TabIndex = 1;
        // 
        // dateTimePicker2
        // 
        dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        dateTimePicker2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dateTimePicker2.Format = DateTimePickerFormat.Custom;
        dateTimePicker2.Location = new Point(360, 104);
        dateTimePicker2.Name = "dateTimePicker2";
        dateTimePicker2.Size = new Size(313, 32);
        dateTimePicker2.TabIndex = 2;
        // 
        // cboEstado
        // 
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Items.AddRange(new object[] { "Todos" });
        cboEstado.Location = new Point(694, 106);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(300, 34);
        cboEstado.TabIndex = 7;
        // 
        // btnNuevoPeriodo
        // 
        btnNuevoPeriodo.Appearance.Normal.BorderColor = Color.Transparent;
        btnNuevoPeriodo.Appearance.Normal.FillColor = Color.Black;
        btnNuevoPeriodo.Appearance.Normal.ForeColor = Color.White;
        btnNuevoPeriodo.BackColor = Color.Transparent;
        btnNuevoPeriodo.BorderColor = Color.Transparent;
        btnNuevoPeriodo.ClickColor = Color.Black;
        btnNuevoPeriodo.FillColor = Color.Black;
        btnNuevoPeriodo.FlatStyle = FlatStyle.Flat;
        btnNuevoPeriodo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnNuevoPeriodo.ForeColor = Color.White;
        btnNuevoPeriodo.Location = new Point(23, 176);
        btnNuevoPeriodo.Name = "btnNuevoPeriodo";
        btnNuevoPeriodo.Padding = new Padding(12, 4, 12, 4);
        btnNuevoPeriodo.Size = new Size(247, 50);
        btnNuevoPeriodo.TabIndex = 8;
        btnNuevoPeriodo.Text = "Nuevo período";
        btnNuevoPeriodo.UseVisualStyleBackColor = false;
        // 
        // btnVerPeriodo
        // 
        btnVerPeriodo.Appearance.Normal.BorderColor = Color.FromArgb(64, 64, 64);
        btnVerPeriodo.Appearance.Normal.FillColor = Color.Transparent;
        btnVerPeriodo.BackColor = Color.Transparent;
        btnVerPeriodo.BorderColor = Color.FromArgb(64, 64, 64);
        btnVerPeriodo.FillColor = Color.Transparent;
        btnVerPeriodo.FlatStyle = FlatStyle.Flat;
        btnVerPeriodo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnVerPeriodo.Location = new Point(290, 176);
        btnVerPeriodo.Name = "btnVerPeriodo";
        btnVerPeriodo.Padding = new Padding(12, 4, 12, 4);
        btnVerPeriodo.Size = new Size(249, 50);
        btnVerPeriodo.TabIndex = 9;
        btnVerPeriodo.Text = "Ver detalle";
        btnVerPeriodo.UseVisualStyleBackColor = false;
        // 
        // btnBoletas
        // 
        btnBoletas.Appearance.Normal.BorderColor = Color.FromArgb(64, 64, 64);
        btnBoletas.Appearance.Normal.FillColor = Color.Transparent;
        btnBoletas.BackColor = Color.Transparent;
        btnBoletas.BorderColor = Color.FromArgb(64, 64, 64);
        btnBoletas.FillColor = Color.Transparent;
        btnBoletas.FlatStyle = FlatStyle.Flat;
        btnBoletas.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBoletas.Location = new Point(561, 176);
        btnBoletas.Name = "btnBoletas";
        btnBoletas.Padding = new Padding(12, 4, 12, 4);
        btnBoletas.Size = new Size(242, 50);
        btnBoletas.TabIndex = 10;
        btnBoletas.Text = "Boletas por departamento";
        btnBoletas.UseVisualStyleBackColor = false;
        // 
        // btnAnterior
        // 
        btnAnterior.Appearance.Normal.BorderColor = Color.FromArgb(64, 64, 64);
        btnAnterior.Appearance.Normal.FillColor = Color.Transparent;
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.BorderColor = Color.FromArgb(64, 64, 64);
        btnAnterior.FillColor = Color.Transparent;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Font = new Font("Century Gothic", 12F);
        btnAnterior.Location = new Point(26, 580);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Padding = new Padding(12, 4, 12, 4);
        btnAnterior.Size = new Size(161, 35);
        btnAnterior.TabIndex = 12;
        btnAnterior.Text = "Anterior";
        btnAnterior.UseVisualStyleBackColor = false;
        // 
        // btnSiguiente
        // 
        btnSiguiente.Appearance.Normal.BorderColor = Color.FromArgb(64, 64, 64);
        btnSiguiente.Appearance.Normal.FillColor = Color.Transparent;
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.BorderColor = Color.FromArgb(64, 64, 64);
        btnSiguiente.FillColor = Color.Transparent;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.Font = new Font("Century Gothic", 12F);
        btnSiguiente.Location = new Point(360, 580);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Padding = new Padding(12, 4, 12, 4);
        btnSiguiente.Size = new Size(161, 35);
        btnSiguiente.TabIndex = 13;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.UseVisualStyleBackColor = false;
        // 
        // cboTamanoPagina
        // 
        cboTamanoPagina.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboTamanoPagina.FormattingEnabled = true;
        cboTamanoPagina.ItemHeight = 28;
        cboTamanoPagina.Location = new Point(748, 580);
        cboTamanoPagina.Name = "cboTamanoPagina";
        cboTamanoPagina.Size = new Size(249, 34);
        cboTamanoPagina.TabIndex = 14;
        // 
        // lblTitulo
        // 
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.Location = new Point(23, 40);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(236, 27);
        lblTitulo.TabIndex = 16;
        lblTitulo.Text = "Períodos de nómina";
        // 
        // kLabel2
        // 
        kLabel2.BackColor = Color.Transparent;
        kLabel2.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
        kLabel2.Location = new Point(23, 81);
        kLabel2.Name = "kLabel2";
        kLabel2.Size = new Size(55, 18);
        kLabel2.TabIndex = 17;
        kLabel2.Text = "Desde";
        // 
        // kLabel3
        // 
        kLabel3.BackColor = Color.Transparent;
        kLabel3.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
        kLabel3.Location = new Point(360, 81);
        kLabel3.Name = "kLabel3";
        kLabel3.Size = new Size(48, 18);
        kLabel3.TabIndex = 18;
        kLabel3.Text = "Hasta";
        // 
        // lblEstado
        // 
        lblEstado.BackColor = Color.Transparent;
        lblEstado.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
        lblEstado.Location = new Point(694, 83);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(56, 18);
        lblEstado.TabIndex = 19;
        lblEstado.Text = "Estado";
        // 
        // kLabel4
        // 
        kLabel4.BackColor = Color.Transparent;
        kLabel4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        kLabel4.Location = new Point(23, 260);
        kLabel4.Name = "kLabel4";
        kLabel4.Size = new Size(139, 18);
        kLabel4.TabIndex = 20;
        kLabel4.Text = "Períodos de pago";
        // 
        // kDataGridView1
        // 
        kDataGridView1.BackgroundColor = Color.White;
        kDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        kDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        kDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(10, 5, 10, 5);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 233, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        kDataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
        kDataGridView1.EnableHeadersVisualStyles = false;
        kDataGridView1.GridColor = Color.FromArgb(218, 218, 218);
        kDataGridView1.Location = new Point(23, 287);
        kDataGridView1.Name = "kDataGridView1";
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        kDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        kDataGridView1.RowHeadersVisible = false;
        kDataGridView1.RowHeadersWidth = 51;
        kDataGridView1.RowTemplate.Height = 52;
        kDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        kDataGridView1.Size = new Size(971, 248);
        kDataGridView1.TabIndex = 21;
        // 
        // lblPagina
        // 
        lblPagina.BackColor = Color.Transparent;
        lblPagina.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lblPagina.Location = new Point(206, 586);
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(145, 23);
        lblPagina.TabIndex = 22;
        lblPagina.Text = "Página 1 de 1";
        // 
        // kLabel1
        // 
        kLabel1.BackColor = Color.Transparent;
        kLabel1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        kLabel1.Location = new Point(748, 557);
        kLabel1.Name = "kLabel1";
        kLabel1.Size = new Size(125, 18);
        kLabel1.TabIndex = 23;
        kLabel1.Text = "Filas por página";
        // 
        // FrmNomina
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1031, 892);
        Controls.Add(kLabel1);
        Controls.Add(lblPagina);
        Controls.Add(kDataGridView1);
        Controls.Add(kLabel4);
        Controls.Add(lblEstado);
        Controls.Add(kLabel3);
        Controls.Add(kLabel2);
        Controls.Add(lblTitulo);
        Controls.Add(cboTamanoPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(btnAnterior);
        Controls.Add(btnBoletas);
        Controls.Add(btnVerPeriodo);
        Controls.Add(btnNuevoPeriodo);
        Controls.Add(cboEstado);
        Controls.Add(dateTimePicker2);
        Controls.Add(dateTimePicker1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "FrmNomina";
        Text = "Nómina";
        ((System.ComponentModel.ISupportInitialize)kDataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private DateTimePicker dateTimePicker1;
    private DateTimePicker dateTimePicker2;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KButton btnNuevoPeriodo;
    private KovaqsUI.Controls.KButton btnVerPeriodo;
    private KovaqsUI.Controls.KButton btnBoletas;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KComboBox cboTamanoPagina;
    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KLabel kLabel2;
    private KovaqsUI.Controls.KLabel kLabel3;
    private KovaqsUI.Controls.KLabel lblEstado;
    private KovaqsUI.Controls.KLabel kLabel4;
    private KovaqsUI.Controls.KDataGridView kDataGridView1;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KLabel kLabel1;
}
