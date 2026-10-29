namespace Presentacion.Forms.Secciones;

partial class FrmAsistencias
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
        label1 = new Label();
        dtpDesde = new DateTimePicker();
        mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
        dtpHasta = new DateTimePicker();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        txtBuscarEmpleado = new KovaqsUI.Controls.KTextBox();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        kLabel1 = new KovaqsUI.Controls.KLabel();
        kLabel2 = new KovaqsUI.Controls.KLabel();
        kLabel3 = new KovaqsUI.Controls.KLabel();
        kLabel4 = new KovaqsUI.Controls.KLabel();
        lblEstado = new KovaqsUI.Controls.KLabel();
        btnRegistrarAsistencia = new KovaqsUI.Controls.KButton();
        btnConsultar = new KovaqsUI.Controls.KButton();
        btnPermisosLaborales = new KovaqsUI.Controls.KButton();
        btnExportarExcel = new KovaqsUI.Controls.KButton();
        dgvAsistencias = new KovaqsUI.Controls.KDataGridView();
        kLabel5 = new KovaqsUI.Controls.KLabel();
        btnAnterior = new KovaqsUI.Controls.KButton();
        lblPagina = new KovaqsUI.Controls.KLabel();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
        kLabel7 = new KovaqsUI.Controls.KLabel();
        ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(133, 63);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(0, 27);
        label1.TabIndex = 0;
        // 
        // dtpDesde
        // 
        dtpDesde.CustomFormat = "dd/MM/yyyy";
        dtpDesde.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dtpDesde.Format = DateTimePickerFormat.Custom;
        dtpDesde.Location = new Point(55, 77);
        dtpDesde.Name = "dtpDesde";
        dtpDesde.Size = new Size(250, 30);
        dtpDesde.TabIndex = 1;
        dtpDesde.ValueChanged += dtpDesde_ValueChanged;
        // 
        // mySqlDataAdapter1
        // 
        mySqlDataAdapter1.DeleteCommand = null;
        mySqlDataAdapter1.InsertCommand = null;
        mySqlDataAdapter1.SelectCommand = null;
        mySqlDataAdapter1.UpdateBatchSize = 0;
        mySqlDataAdapter1.UpdateCommand = null;
        // 
        // dtpHasta
        // 
        dtpHasta.CustomFormat = "dd/MM/yyyy";
        dtpHasta.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dtpHasta.Format = DateTimePickerFormat.Custom;
        dtpHasta.Location = new Point(364, 77);
        dtpHasta.Name = "dtpHasta";
        dtpHasta.Size = new Size(250, 30);
        dtpHasta.TabIndex = 5;
        // 
        // cboDepartamento
        // 
        cboDepartamento.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.ItemHeight = 28;
        cboDepartamento.Location = new Point(758, 77);
        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(300, 34);
        cboDepartamento.TabIndex = 9;
        // 
        // txtBuscarEmpleado
        // 
        txtBuscarEmpleado.BackColor = Color.Transparent;
        txtBuscarEmpleado.Location = new Point(55, 172);
        txtBuscarEmpleado.Name = "txtBuscarEmpleado";
        txtBuscarEmpleado.Padding = new Padding(12, 8, 12, 8);
        txtBuscarEmpleado.Size = new Size(244, 30);
        txtBuscarEmpleado.TabIndex = 10;
        // 
        // cboEstado
        // 
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Location = new Point(364, 172);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(274, 34);
        cboEstado.TabIndex = 11;
        // 
        // lblTitulo
        // 
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.Location = new Point(74, 9);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(295, 27);
        lblTitulo.TabIndex = 12;
        lblTitulo.Text = "Asistencias e incidencias";
        // 
        // kLabel1
        // 
        kLabel1.BackColor = Color.Transparent;
        kLabel1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        kLabel1.Location = new Point(55, 54);
        kLabel1.Name = "kLabel1";
        kLabel1.RightToLeft = RightToLeft.No;
        kLabel1.Size = new Size(62, 19);
        kLabel1.TabIndex = 13;
        kLabel1.Text = "Desde";
        // 
        // kLabel2
        // 
        kLabel2.BackColor = Color.Transparent;
        kLabel2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        kLabel2.Location = new Point(364, 54);
        kLabel2.Name = "kLabel2";
        kLabel2.Size = new Size(55, 19);
        kLabel2.TabIndex = 14;
        kLabel2.Text = "Hasta";
        // 
        // kLabel3
        // 
        kLabel3.BackColor = Color.Transparent;
        kLabel3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        kLabel3.Location = new Point(758, 54);
        kLabel3.Name = "kLabel3";
        kLabel3.Size = new Size(126, 19);
        kLabel3.TabIndex = 15;
        kLabel3.Text = "Departamento";
        // 
        // kLabel4
        // 
        kLabel4.BackColor = Color.Transparent;
        kLabel4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        kLabel4.Location = new Point(55, 149);
        kLabel4.Name = "kLabel4";
        kLabel4.Size = new Size(158, 19);
        kLabel4.TabIndex = 16;
        kLabel4.Text = "Nombre o Código";
        // 
        // lblEstado
        // 
        lblEstado.BackColor = Color.Transparent;
        lblEstado.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblEstado.Location = new Point(364, 149);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(63, 19);
        lblEstado.TabIndex = 17;
        lblEstado.Text = "Estado";
        // 
        // btnRegistrarAsistencia
        // 
        btnRegistrarAsistencia.Appearance.Normal.BorderColor = Color.Black;
        btnRegistrarAsistencia.Appearance.Normal.FillColor = Color.Black;
        btnRegistrarAsistencia.Appearance.Normal.ForeColor = Color.White;
        btnRegistrarAsistencia.BackColor = Color.Transparent;
        btnRegistrarAsistencia.BorderColor = Color.Black;
        btnRegistrarAsistencia.FillColor = Color.Black;
        btnRegistrarAsistencia.FlatStyle = FlatStyle.Flat;
        btnRegistrarAsistencia.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnRegistrarAsistencia.ForeColor = Color.White;
        btnRegistrarAsistencia.Location = new Point(55, 222);
        btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
        btnRegistrarAsistencia.Padding = new Padding(12, 4, 12, 4);
        btnRegistrarAsistencia.Size = new Size(181, 50);
        btnRegistrarAsistencia.TabIndex = 18;
        btnRegistrarAsistencia.Text = "Registrar/editar";
        btnRegistrarAsistencia.UseVisualStyleBackColor = false;
        // 
        // btnConsultar
        // 
        btnConsultar.Appearance.Normal.BorderColor = Color.LightGray;
        btnConsultar.Appearance.Normal.FillColor = Color.White;
        btnConsultar.BackColor = Color.White;
        btnConsultar.BorderColor = Color.LightGray;
        btnConsultar.FillColor = Color.White;
        btnConsultar.FlatStyle = FlatStyle.Flat;
        btnConsultar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnConsultar.Location = new Point(323, 222);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Padding = new Padding(12, 4, 12, 4);
        btnConsultar.Size = new Size(140, 50);
        btnConsultar.TabIndex = 19;
        btnConsultar.Text = "Consultar ";
        btnConsultar.UseVisualStyleBackColor = false;
        // 
        // btnPermisosLaborales
        // 
        btnPermisosLaborales.Appearance.Normal.BorderColor = Color.LightGray;
        btnPermisosLaborales.Appearance.Normal.FillColor = Color.White;
        btnPermisosLaborales.BackColor = Color.Transparent;
        btnPermisosLaborales.BorderColor = Color.LightGray;
        btnPermisosLaborales.FillColor = Color.White;
        btnPermisosLaborales.FlatStyle = FlatStyle.Flat;
        btnPermisosLaborales.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnPermisosLaborales.Location = new Point(573, 222);
        btnPermisosLaborales.Name = "btnPermisosLaborales";
        btnPermisosLaborales.Padding = new Padding(12, 4, 12, 4);
        btnPermisosLaborales.Size = new Size(210, 50);
        btnPermisosLaborales.TabIndex = 20;
        btnPermisosLaborales.Text = "Permisos laborales";
        btnPermisosLaborales.UseVisualStyleBackColor = false;
        // 
        // btnExportarExcel
        // 
        btnExportarExcel.Appearance.Normal.BorderColor = Color.Gainsboro;
        btnExportarExcel.Appearance.Normal.FillColor = Color.White;
        btnExportarExcel.BackColor = Color.Transparent;
        btnExportarExcel.BorderColor = Color.Gainsboro;
        btnExportarExcel.FillColor = Color.White;
        btnExportarExcel.FlatStyle = FlatStyle.Flat;
        btnExportarExcel.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnExportarExcel.Location = new Point(889, 222);
        btnExportarExcel.Name = "btnExportarExcel";
        btnExportarExcel.Padding = new Padding(12, 4, 12, 4);
        btnExportarExcel.Size = new Size(198, 50);
        btnExportarExcel.TabIndex = 21;
        btnExportarExcel.Text = "Exportar Excel";
        btnExportarExcel.UseVisualStyleBackColor = false;
        // 
        // dgvAsistencias
        // 
        dgvAsistencias.BackgroundColor = Color.White;
        dgvAsistencias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvAsistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(10, 5, 10, 5);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 233, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvAsistencias.DefaultCellStyle = dataGridViewCellStyle2;
        dgvAsistencias.EnableHeadersVisualStyles = false;
        dgvAsistencias.GridColor = Color.FromArgb(218, 218, 218);
        dgvAsistencias.Location = new Point(55, 324);
        dgvAsistencias.Name = "dgvAsistencias";
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvAsistencias.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvAsistencias.RowHeadersVisible = false;
        dgvAsistencias.RowHeadersWidth = 51;
        dgvAsistencias.RowTemplate.Height = 52;
        dgvAsistencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvAsistencias.Size = new Size(1032, 251);
        dgvAsistencias.TabIndex = 22;
        // 
        // kLabel5
        // 
        kLabel5.BackColor = Color.Transparent;
        kLabel5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        kLabel5.Location = new Point(53, 301);
        kLabel5.Name = "kLabel5";
        kLabel5.Size = new Size(186, 19);
        kLabel5.TabIndex = 23;
        kLabel5.Text = "Marcas e incidencias";
        // 
        // btnAnterior
        // 
        btnAnterior.Appearance.Normal.BorderColor = Color.LightGray;
        btnAnterior.Appearance.Normal.FillColor = Color.White;
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.BorderColor = Color.LightGray;
        btnAnterior.FillColor = Color.White;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnAnterior.Location = new Point(55, 614);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Padding = new Padding(12, 4, 12, 4);
        btnAnterior.Size = new Size(140, 50);
        btnAnterior.TabIndex = 24;
        btnAnterior.Text = "Anterior";
        btnAnterior.UseVisualStyleBackColor = false;
        // 
        // lblPagina
        // 
        lblPagina.BackColor = Color.Transparent;
        lblPagina.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblPagina.Location = new Point(304, 626);
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(123, 19);
        lblPagina.TabIndex = 26;
        lblPagina.Text = "Página 1 de 1";
        // 
        // btnSiguiente
        // 
        btnSiguiente.Appearance.Normal.BorderColor = Color.LightGray;
        btnSiguiente.Appearance.Normal.FillColor = Color.White;
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.BorderColor = Color.LightGray;
        btnSiguiente.FillColor = Color.White;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSiguiente.Location = new Point(532, 610);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Padding = new Padding(12, 4, 12, 4);
        btnSiguiente.Size = new Size(140, 50);
        btnSiguiente.TabIndex = 27;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.UseVisualStyleBackColor = false;
        // 
        // cboTamanoPagina
        // 
        cboTamanoPagina.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cboTamanoPagina.FormattingEnabled = true;
        cboTamanoPagina.ItemHeight = 28;
        cboTamanoPagina.Location = new Point(815, 626);
        cboTamanoPagina.Name = "cboTamanoPagina";
        cboTamanoPagina.Size = new Size(300, 34);
        cboTamanoPagina.TabIndex = 28;
        // 
        // kLabel7
        // 
        kLabel7.BackColor = Color.Transparent;
        kLabel7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        kLabel7.Location = new Point(815, 600);
        kLabel7.Name = "kLabel7";
        kLabel7.Size = new Size(139, 19);
        kLabel7.TabIndex = 29;
        kLabel7.Text = "Filas por página";
        // 
        // FrmAsistencias
        // 
        AutoScaleDimensions = new SizeF(14F, 27F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1155, 1055);
        Controls.Add(kLabel7);
        Controls.Add(cboTamanoPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(lblPagina);
        Controls.Add(btnAnterior);
        Controls.Add(kLabel5);
        Controls.Add(dgvAsistencias);
        Controls.Add(btnExportarExcel);
        Controls.Add(btnPermisosLaborales);
        Controls.Add(btnConsultar);
        Controls.Add(btnRegistrarAsistencia);
        Controls.Add(lblEstado);
        Controls.Add(kLabel4);
        Controls.Add(kLabel3);
        Controls.Add(kLabel2);
        Controls.Add(kLabel1);
        Controls.Add(lblTitulo);
        Controls.Add(cboEstado);
        Controls.Add(txtBuscarEmpleado);
        Controls.Add(cboDepartamento);
        Controls.Add(dtpHasta);
        Controls.Add(dtpDesde);
        Controls.Add(label1);
        Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Margin = new Padding(5);
        Name = "FrmAsistencias";
        Text = "Control de Asistencias";
        Load += FrmAsistencias_Load;
        ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private DateTimePicker dtpDesde;
    private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
    private DateTimePicker dtpHasta;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KTextBox txtBuscarEmpleado;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KLabel kLabel1;
    private KovaqsUI.Controls.KLabel kLabel2;
    private KovaqsUI.Controls.KLabel kLabel3;
    private KovaqsUI.Controls.KLabel kLabel4;
    private KovaqsUI.Controls.KLabel lblEstado;
    private KovaqsUI.Controls.KButton btnRegistrarAsistencia;
    private KovaqsUI.Controls.KButton btnConsultar;
    private KovaqsUI.Controls.KButton btnPermisosLaborales;
    private KovaqsUI.Controls.KButton btnExportarExcel;
    private KovaqsUI.Controls.KDataGridView dgvAsistencias;
    private KovaqsUI.Controls.KLabel kLabel5;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KLabel lblPagina;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KComboBox cboTamanoPagina;
    private KovaqsUI.Controls.KLabel kLabel7;
}
