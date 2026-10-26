namespace Presentacion.Forms.Secciones;

partial class FrmUsuarios
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
        dgvUsuarios = new KovaqsUI.Controls.KDataGridView();
        kLabel1 = new KovaqsUI.Controls.KLabel();
        btnAgregarUsuario = new KovaqsUI.Controls.KButton();
        kComboBox1 = new KovaqsUI.Controls.KComboBox();
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
        SuspendLayout();
        // 
        // dgvUsuarios
        // 
        dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dgvUsuarios.BackgroundColor = Color.White;
        dgvUsuarios.BorderStyle = BorderStyle.None;
        dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 233, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
        dgvUsuarios.EnableHeadersVisualStyles = false;
        dgvUsuarios.GridColor = Color.FromArgb(218, 218, 218);
        dgvUsuarios.Location = new Point(12, 128);
        dgvUsuarios.Name = "dgvUsuarios";
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvUsuarios.RowHeadersVisible = false;
        dgvUsuarios.RowTemplate.Height = 42;
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvUsuarios.Size = new Size(1021, 617);
        dgvUsuarios.TabIndex = 0;
        // 
        // kLabel1
        // 
        kLabel1.BackColor = Color.Transparent;
        kLabel1.Location = new Point(12, 18);
        kLabel1.Name = "kLabel1";
        kLabel1.Size = new Size(150, 37);
        kLabel1.TabIndex = 1;
        kLabel1.Text = "Usuarios";
        kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Title;
        // 
        // btnAgregarUsuario
        // 
        btnAgregarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAgregarUsuario.Appearance.Normal.FillColor = Color.DimGray;
        btnAgregarUsuario.Appearance.Normal.ForeColor = Color.WhiteSmoke;
        btnAgregarUsuario.Appearance.Normal.GradientColor = Color.Black;
        btnAgregarUsuario.BackColor = Color.Transparent;
        btnAgregarUsuario.BorderThickness = 0;
        btnAgregarUsuario.CornerRadius = 8;
        btnAgregarUsuario.FillColor = Color.DimGray;
        btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
        btnAgregarUsuario.Font = new Font("Inter Medium", 9F);
        btnAgregarUsuario.ForeColor = Color.WhiteSmoke;
        btnAgregarUsuario.GradientColor = Color.Black;
        btnAgregarUsuario.Location = new Point(907, 23);
        btnAgregarUsuario.Name = "btnAgregarUsuario";
        btnAgregarUsuario.Padding = new Padding(12, 4, 12, 4);
        btnAgregarUsuario.Size = new Size(126, 40);
        btnAgregarUsuario.TabIndex = 2;
        btnAgregarUsuario.Text = "Agregar Usuario";
        btnAgregarUsuario.UseVisualStyleBackColor = false;
        // 
        // kComboBox1
        // 
        kComboBox1.FormattingEnabled = true;
        kComboBox1.ItemHeight = 28;
        kComboBox1.Location = new Point(12, 88);
        kComboBox1.Name = "kComboBox1";
        kComboBox1.Size = new Size(235, 34);
        kComboBox1.TabIndex = 3;
        // 
        // FrmUsuarios
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1045, 757);
        Controls.Add(kComboBox1);
        Controls.Add(btnAgregarUsuario);
        Controls.Add(kLabel1);
        Controls.Add(dgvUsuarios);
        Name = "FrmUsuarios";
        Text = "Usuarios y Permisos";
        Load += FrmUsuarios_Load;
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private KovaqsUI.Controls.KDataGridView dgvUsuarios;
    private KovaqsUI.Controls.KLabel kLabel1;
    private KovaqsUI.Controls.KButton btnAgregarUsuario;
    private KovaqsUI.Controls.KComboBox kComboBox1;
}
