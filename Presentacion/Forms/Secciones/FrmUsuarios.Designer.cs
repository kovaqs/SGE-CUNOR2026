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
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
        SuspendLayout();
        //
        // dgvUsuarios
        //
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
        dataGridViewCellStyle2.Font = new Font("Inter", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 233, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
        dgvUsuarios.EnableHeadersVisualStyles = false;
        dgvUsuarios.GridColor = Color.FromArgb(218, 218, 218);
        dgvUsuarios.Location = new Point(12, 119);
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
        dgvUsuarios.Size = new Size(1021, 626);
        dgvUsuarios.TabIndex = 0;
        //
        // FrmUsuarios
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1045, 757);
        Controls.Add(dgvUsuarios);
        Name = "FrmUsuarios";
        Text = "Usuarios y Permisos";
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KDataGridView dgvUsuarios;
}
