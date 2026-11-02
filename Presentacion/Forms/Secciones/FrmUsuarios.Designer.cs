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
        lblTitulo = new KovaqsUI.Controls.KLabel();
        btnAgregarUsuario = new KovaqsUI.Controls.KButton();
        cboRol = new KovaqsUI.Controls.KComboBox();
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
        lblRol = new KovaqsUI.Controls.KLabel();
        lblRol.Text = "Rol del usuario";
        lblRol.Location = new Point(16, 70);
        lblRol.Size = new Size(354, 24);
        lblRol.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblRol.TextAlign = ContentAlignment.MiddleLeft;
        lblRol.Font = new Font("Inter", 9F);
        lblRol.ForeColor = Color.FromArgb(64, 64, 64);
        lblRol.AutoSize = false;
        lblRol.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblRol.TabIndex = 1;
        lblRol.TabStop = false;
        lblRol.Name = "lblRol";
        lblUsuariosTitulo = new KovaqsUI.Controls.KLabel();
        lblUsuariosTitulo.Text = "Usuarios registrados";
        lblUsuariosTitulo.Location = new Point(16, 198);
        lblUsuariosTitulo.Size = new Size(1094, 24);
        lblUsuariosTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblUsuariosTitulo.Font = new Font("Inter", 9F);
        lblUsuariosTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblUsuariosTitulo.AutoSize = false;
        lblUsuariosTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblUsuariosTitulo.TabIndex = 4;
        lblUsuariosTitulo.TabStop = false;
        lblUsuariosTitulo.Name = "lblUsuariosTitulo";
        components = new System.ComponentModel.Container();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        notificador.OwnerForm = this;
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle3.Font = new Font("Inter", 9F);
        SuspendLayout();
        //
        // dgvUsuarios
        //
        dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvUsuarios.BackgroundColor = Color.White;
        dgvUsuarios.BorderStyle = BorderStyle.None;
        dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Inter", 9F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
        dgvUsuarios.EnableHeadersVisualStyles = false;
        dgvUsuarios.GridColor = Color.FromArgb(218, 218, 218);
        dgvUsuarios.Location = new Point(16, 224);
        dgvUsuarios.Font = new Font("Inter", 9F);
        dgvUsuarios.ColumnHeadersHeight = 42;
        dgvUsuarios.MultiSelect = false;
        dgvUsuarios.ReadOnly = true;
        dgvUsuarios.AllowUserToAddRows = false;
        dgvUsuarios.AllowUserToDeleteRows = false;
        dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvUsuarios.Name = "dgvUsuarios";
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvUsuarios.RowHeadersVisible = false;
        dgvUsuarios.RowTemplate.Height = 42;
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvUsuarios.Size = new Size(1094, 504);
        dgvUsuarios.TabIndex = 5;
        //
        // lblTitulo
        //
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Dock = DockStyle.None;
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.AutoSize = false;
        lblTitulo.TabStop = false;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1094, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Usuarios";
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        //
        // btnAgregarUsuario
        //
        btnAgregarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        btnAgregarUsuario.BackColor = Color.Transparent;
        btnAgregarUsuario.BorderThickness = 1;
        btnAgregarUsuario.CornerRadius = 8;
        btnAgregarUsuario.FlatStyle = FlatStyle.Flat;
        btnAgregarUsuario.Font = new Font("Inter", 9F);
        btnAgregarUsuario.Location = new Point(16, 144);
        btnAgregarUsuario.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnAgregarUsuario.FillColor = Color.FromArgb(49, 81, 107);
        btnAgregarUsuario.ForeColor = Color.White;
        btnAgregarUsuario.BorderColor = Color.FromArgb(49, 81, 107);
        btnAgregarUsuario.GradientColor = Color.Empty;
        btnAgregarUsuario.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnAgregarUsuario.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnAgregarUsuario.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnAgregarUsuario.Name = "btnAgregarUsuario";
        btnAgregarUsuario.Padding = new Padding(10, 4, 10, 4);
        btnAgregarUsuario.Size = new Size(264, 40);
        btnAgregarUsuario.TabIndex = 3;
        btnAgregarUsuario.Text = "Agregar usuario";
        btnAgregarUsuario.UseVisualStyleBackColor = false;
        //
        // cboRol
        //
        cboRol.FormattingEnabled = true;
        cboRol.ItemHeight = 28;
        cboRol.Location = new Point(16, 96);
        cboRol.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        cboRol.Font = new Font("Inter", 9F);
        cboRol.CornerRadius = 8;
        cboRol.FillColor = Color.White;
        cboRol.ForeColor = Color.FromArgb(32, 38, 45);
        cboRol.BorderColor = Color.FromArgb(218, 218, 218);
        cboRol.GradientColor = Color.Empty;
        cboRol.DropDownStyle = ComboBoxStyle.DropDownList;

        cboRol.Name = "cboRol";
        cboRol.Size = new Size(354, 34);
        cboRol.TabIndex = 2;
        //
        // FrmUsuarios
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1126, 744);
        Controls.Add(cboRol);
        Controls.Add(btnAgregarUsuario);
        Controls.Add(lblTitulo);
        Controls.Add(dgvUsuarios);
        Controls.Add(lblRol);
        Controls.Add(lblUsuariosTitulo);
        MinimumSize = new Size(1126, 744);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3);
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmUsuarios";
        Text = "Usuarios y Permisos";
        Load += FrmUsuarios_Load;
        ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private KovaqsUI.Controls.KDataGridView dgvUsuarios;
    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnAgregarUsuario;
    private KovaqsUI.Controls.KComboBox cboRol;
    private KovaqsUI.Controls.KLabel lblRol;
    private KovaqsUI.Controls.KLabel lblUsuariosTitulo;
    private KovaqsUI.Components.KToastNotifier notificador;
}
