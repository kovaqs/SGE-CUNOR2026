namespace Presentacion.Forms.SubForms.Configuracion;

partial class FrmHorarios
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
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        btnCerrar = new KovaqsUI.Controls.KButton();
        lblBuscar = new KovaqsUI.Controls.KLabel();
        txtBuscar = new KovaqsUI.Controls.KTextBox();
        lblEstadoFiltro = new KovaqsUI.Controls.KLabel();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        btnNuevoHorario = new KovaqsUI.Controls.KButton();
        btnEditarHorario = new KovaqsUI.Controls.KButton();
        btnEliminarHorario = new KovaqsUI.Controls.KButton();
        lblHorariosTitulo = new KovaqsUI.Controls.KLabel();
        dgvHorarios = new KovaqsUI.Controls.KDataGridView();
        colHorariosNombre = new DataGridViewTextBoxColumn();
        colHorariosDescripcion = new DataGridViewTextBoxColumn();
        colHorariosActivo = new DataGridViewCheckBoxColumn();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
        SuspendLayout();
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(119, 119, 119);
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(223, 233, 249);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Font = new Font("Inter", 9F);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Text = "Horarios de trabajo";
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(740, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.TabStop = false;
        //
        // btnCerrar
        //
        btnCerrar.BackColor = Color.Transparent;
        btnCerrar.CornerRadius = 8;
        btnCerrar.FlatStyle = FlatStyle.Flat;
        btnCerrar.Font = new Font("Inter", 9F);
        btnCerrar.Padding = new Padding(10, 4, 10, 4);
        btnCerrar.UseVisualStyleBackColor = false;
        btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCerrar.Text = "Cerrar";
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.Location = new Point(790, 12);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(96, 40);
        btnCerrar.TabIndex = 1;
        //
        // lblBuscar
        //
        lblBuscar.AutoSize = false;
        lblBuscar.BackColor = Color.Transparent;
        lblBuscar.ForeColor = Color.FromArgb(64, 64, 64);
        lblBuscar.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
        lblBuscar.Text = "Nombre del horario";
        lblBuscar.Location = new Point(16, 70);
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(426, 24);
        lblBuscar.TabIndex = 2;
        lblBuscar.TabStop = false;
        //
        // txtBuscar
        //
        txtBuscar.BackColor = Color.Transparent;
        txtBuscar.CornerRadius = 8;
        txtBuscar.Font = new Font("Inter", 9F);
        txtBuscar.Padding = new Padding(10, 6, 10, 6);
        txtBuscar.MaxLength = 100;
        txtBuscar.Location = new Point(16, 96);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.Size = new Size(426, 34);
        txtBuscar.TabIndex = 3;
        //
        // lblEstadoFiltro
        //
        lblEstadoFiltro.AutoSize = false;
        lblEstadoFiltro.BackColor = Color.Transparent;
        lblEstadoFiltro.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstadoFiltro.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEstadoFiltro.TextAlign = ContentAlignment.MiddleLeft;
        lblEstadoFiltro.Text = "Estado";
        lblEstadoFiltro.Location = new Point(460, 70);
        lblEstadoFiltro.Name = "lblEstadoFiltro";
        lblEstadoFiltro.Size = new Size(426, 24);
        lblEstadoFiltro.TabIndex = 4;
        lblEstadoFiltro.TabStop = false;
        //
        // cboEstado
        //
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        cboEstado.FormattingEnabled = true;
        cboEstado.Items.AddRange(new object[] { "Todos", "Activos", "Inactivos" });
        cboEstado.Location = new Point(460, 96);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(426, 34);
        cboEstado.TabIndex = 5;
        //
        // btnNuevoHorario
        //
        btnNuevoHorario.BackColor = Color.Transparent;
        btnNuevoHorario.CornerRadius = 8;
        btnNuevoHorario.FlatStyle = FlatStyle.Flat;
        btnNuevoHorario.Font = new Font("Inter", 9F);
        btnNuevoHorario.Padding = new Padding(10, 4, 10, 4);
        btnNuevoHorario.UseVisualStyleBackColor = false;
        btnNuevoHorario.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        btnNuevoHorario.Text = "Nuevo horario";
        btnNuevoHorario.FillColor = Color.FromArgb(32, 38, 45);
        btnNuevoHorario.ForeColor = Color.White;
        btnNuevoHorario.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnNuevoHorario.Appearance.Normal.ForeColor = Color.White;
        btnNuevoHorario.Location = new Point(16, 144);
        btnNuevoHorario.Name = "btnNuevoHorario";
        btnNuevoHorario.Size = new Size(220, 40);
        btnNuevoHorario.TabIndex = 6;
        //
        // btnEditarHorario
        //
        btnEditarHorario.BackColor = Color.Transparent;
        btnEditarHorario.CornerRadius = 8;
        btnEditarHorario.FlatStyle = FlatStyle.Flat;
        btnEditarHorario.Font = new Font("Inter", 9F);
        btnEditarHorario.Padding = new Padding(10, 4, 10, 4);
        btnEditarHorario.UseVisualStyleBackColor = false;
        btnEditarHorario.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnEditarHorario.Text = "Editar";
        btnEditarHorario.Location = new Point(248, 144);
        btnEditarHorario.Name = "btnEditarHorario";
        btnEditarHorario.Size = new Size(220, 40);
        btnEditarHorario.TabIndex = 7;
        //
        // btnEliminarHorario
        //
        btnEliminarHorario.BackColor = Color.Transparent;
        btnEliminarHorario.CornerRadius = 8;
        btnEliminarHorario.FlatStyle = FlatStyle.Flat;
        btnEliminarHorario.Font = new Font("Inter", 9F);
        btnEliminarHorario.Padding = new Padding(10, 4, 10, 4);
        btnEliminarHorario.UseVisualStyleBackColor = false;
        btnEliminarHorario.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnEliminarHorario.Text = "Eliminar";
        btnEliminarHorario.Location = new Point(480, 144);
        btnEliminarHorario.Name = "btnEliminarHorario";
        btnEliminarHorario.Size = new Size(220, 40);
        btnEliminarHorario.TabIndex = 8;
        //
        // lblHorariosTitulo
        //
        lblHorariosTitulo.AutoSize = false;
        lblHorariosTitulo.BackColor = Color.Transparent;
        lblHorariosTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblHorariosTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblHorariosTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblHorariosTitulo.Text = "Horarios disponibles";
        lblHorariosTitulo.Location = new Point(16, 198);
        lblHorariosTitulo.Name = "lblHorariosTitulo";
        lblHorariosTitulo.Size = new Size(870, 24);
        lblHorariosTitulo.TabIndex = 9;
        lblHorariosTitulo.TabStop = false;
        //
        // dgvHorarios
        //
        dgvHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvHorarios.AllowUserToAddRows = false;
        dgvHorarios.AllowUserToDeleteRows = false;
        dgvHorarios.AutoGenerateColumns = false;
        dgvHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvHorarios.ReadOnly = true;
        dgvHorarios.RowHeadersVisible = false;
        dgvHorarios.MultiSelect = false;
        dgvHorarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHorarios.BackgroundColor = Color.White;
        dgvHorarios.BorderStyle = BorderStyle.None;
        dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvHorarios.ColumnHeadersHeight = 42;
        dgvHorarios.EnableHeadersVisualStyles = false;
        dgvHorarios.GridColor = Color.FromArgb(218, 218, 218);
        dgvHorarios.RowTemplate.Height = 42;
        dgvHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvHorarios.DefaultCellStyle = dataGridViewCellStyle2;
        dgvHorarios.Location = new Point(16, 224);
        dgvHorarios.Name = "dgvHorarios";
        dgvHorarios.Size = new Size(870, 362);
        dgvHorarios.TabIndex = 10;
        dgvHorarios.Columns.AddRange(new DataGridViewColumn[] { colHorariosNombre, colHorariosDescripcion, colHorariosActivo });
        //
        // colHorariosNombre
        //
        colHorariosNombre.HeaderText = "Nombre";
        colHorariosNombre.Name = "colHorariosNombre";
        colHorariosNombre.ReadOnly = true;
        //
        // colHorariosDescripcion
        //
        colHorariosDescripcion.HeaderText = "Descripción";
        colHorariosDescripcion.Name = "colHorariosDescripcion";
        colHorariosDescripcion.ReadOnly = true;
        //
        // colHorariosActivo
        //
        colHorariosActivo.HeaderText = "Activo";
        colHorariosActivo.Name = "colHorariosActivo";
        colHorariosActivo.ReadOnly = true;
        notificador.OwnerForm = this;
        //
        // FrmHorarios
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(lblEstadoFiltro);
        Controls.Add(cboEstado);
        Controls.Add(btnNuevoHorario);
        Controls.Add(btnEditarHorario);
        Controls.Add(btnEliminarHorario);
        Controls.Add(lblHorariosTitulo);
        Controls.Add(dgvHorarios);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCerrar;
        Name = "FrmHorarios";
        Text = "Horarios de trabajo";
        ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblBuscar;
    private KovaqsUI.Controls.KTextBox txtBuscar;
    private KovaqsUI.Controls.KLabel lblEstadoFiltro;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KButton btnNuevoHorario;
    private KovaqsUI.Controls.KButton btnEditarHorario;
    private KovaqsUI.Controls.KButton btnEliminarHorario;
    private KovaqsUI.Controls.KLabel lblHorariosTitulo;
    private KovaqsUI.Controls.KDataGridView dgvHorarios;
    private DataGridViewTextBoxColumn colHorariosNombre;
    private DataGridViewTextBoxColumn colHorariosDescripcion;
    private DataGridViewCheckBoxColumn colHorariosActivo;
    private KovaqsUI.Components.KToastNotifier notificador;
}
