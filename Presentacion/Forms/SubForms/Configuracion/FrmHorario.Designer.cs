namespace Presentacion.Forms.SubForms.Configuracion;

partial class FrmHorario
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
        lblNombre = new KovaqsUI.Controls.KLabel();
        txtNombre = new KovaqsUI.Controls.KTextBox();
        chkActivo = new KovaqsUI.Controls.KCheckBox();
        lblDiasHorarioTitulo = new KovaqsUI.Controls.KLabel();
        dgvDiasHorario = new KovaqsUI.Controls.KDataGridView();
        lblDiaSemana = new KovaqsUI.Controls.KLabel();
        cboDiaSemana = new KovaqsUI.Controls.KComboBox();
        lblHoraEntrada = new KovaqsUI.Controls.KLabel();
        dtpHoraEntrada = new DateTimePicker();
        lblHoraSalida = new KovaqsUI.Controls.KLabel();
        dtpHoraSalida = new DateTimePicker();
        chkSalidaDiaSiguiente = new KovaqsUI.Controls.KCheckBox();
        lblTolerancia = new KovaqsUI.Controls.KLabel();
        numTolerancia = new KovaqsUI.Controls.KNumericUpDown();
        chkLaborable = new KovaqsUI.Controls.KCheckBox();
        btnAplicarDia = new KovaqsUI.Controls.KButton();
        btnGuardar = new KovaqsUI.Controls.KButton();
        btnCancelar = new KovaqsUI.Controls.KButton();
        colDiasHorarioDia = new DataGridViewTextBoxColumn();
        colDiasHorarioEntrada = new DataGridViewTextBoxColumn();
        colDiasHorarioSalida = new DataGridViewTextBoxColumn();
        colDiasHorarioDiasiguiente = new DataGridViewCheckBoxColumn();
        colDiasHorarioTolerancia = new DataGridViewTextBoxColumn();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvDiasHorario).BeginInit();
        SuspendLayout();
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.Font = new Font("Inter", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
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
        lblTitulo.Text = "Horario y distribución semanal";
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
        btnCerrar.Text = "Cerrar";
        btnCerrar.DialogResult = DialogResult.Cancel;
        btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnCerrar.Location = new Point(790, 12);
        btnCerrar.BorderThickness = 1;
        btnCerrar.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnCerrar.FillColor = Color.White;
        btnCerrar.ForeColor = Color.FromArgb(32, 38, 45);
        btnCerrar.BorderColor = Color.FromArgb(218, 218, 218);
        btnCerrar.GradientColor = Color.Empty;
        btnCerrar.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnCerrar.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnCerrar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnCerrar.Name = "btnCerrar";
        btnCerrar.Size = new Size(96, 40);
        btnCerrar.TabIndex = 1;
        //
        // lblNombre
        //
        lblNombre.AutoSize = false;
        lblNombre.BackColor = Color.Transparent;
        lblNombre.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombre.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNombre.TextAlign = ContentAlignment.MiddleLeft;
        lblNombre.Text = "Nombre del horario";
        lblNombre.Location = new Point(16, 70);
        lblNombre.Font = new Font("Inter", 9F);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(574, 24);
        lblNombre.TabIndex = 2;
        lblNombre.TabStop = false;
        //
        // txtNombre
        //
        txtNombre.BackColor = Color.Transparent;
        txtNombre.CornerRadius = 8;
        txtNombre.Font = new Font("Inter", 9F);
        txtNombre.Padding = new Padding(10, 6, 10, 6);
        txtNombre.MaxLength = 100;
        txtNombre.Location = new Point(16, 96);
        txtNombre.FillColor = Color.White;
        txtNombre.ForeColor = Color.FromArgb(32, 38, 45);
        txtNombre.BorderColor = Color.FromArgb(218, 218, 218);
        txtNombre.GradientColor = Color.Empty;
        txtNombre.BorderThickness = 1;
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(574, 34);
        txtNombre.TabIndex = 4;
        //
        // chkActivo
        //
        chkActivo.Font = new Font("Inter", 9F);
        chkActivo.Text = "Horario activo";
        chkActivo.Checked = true;
        chkActivo.Location = new Point(620, 94);
        chkActivo.ForeColor = Color.FromArgb(64, 64, 64);
        chkActivo.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkActivo.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
        chkActivo.CheckedState.ForeColor = Color.White;
        chkActivo.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkActivo.Name = "chkActivo";
        chkActivo.Size = new Size(266, 36);
        chkActivo.TabIndex = 3;
        //
        // lblDiasHorarioTitulo
        //
        lblDiasHorarioTitulo.AutoSize = false;
        lblDiasHorarioTitulo.BackColor = Color.Transparent;
        lblDiasHorarioTitulo.ForeColor = Color.FromArgb(64, 64, 64);
        lblDiasHorarioTitulo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDiasHorarioTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblDiasHorarioTitulo.Text = "Distribución semanal";
        lblDiasHorarioTitulo.Location = new Point(16, 154);
        lblDiasHorarioTitulo.Font = new Font("Inter", 9F);
        lblDiasHorarioTitulo.Name = "lblDiasHorarioTitulo";
        lblDiasHorarioTitulo.Size = new Size(870, 24);
        lblDiasHorarioTitulo.TabIndex = 5;
        lblDiasHorarioTitulo.TabStop = false;
        //
        // dgvDiasHorario
        //
        dgvDiasHorario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvDiasHorario.AllowUserToAddRows = false;
        dgvDiasHorario.AllowUserToDeleteRows = false;
        dgvDiasHorario.AutoGenerateColumns = false;
        dgvDiasHorario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvDiasHorario.ReadOnly = true;
        dgvDiasHorario.RowHeadersVisible = false;
        dgvDiasHorario.MultiSelect = false;
        dgvDiasHorario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDiasHorario.BackgroundColor = Color.White;
        dgvDiasHorario.BorderStyle = BorderStyle.None;
        dgvDiasHorario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvDiasHorario.ColumnHeadersHeight = 42;
        dgvDiasHorario.EnableHeadersVisualStyles = false;
        dgvDiasHorario.GridColor = Color.FromArgb(218, 218, 218);
        dgvDiasHorario.RowTemplate.Height = 42;
        dgvDiasHorario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvDiasHorario.DefaultCellStyle = dataGridViewCellStyle2;
        dgvDiasHorario.Location = new Point(16, 180);
        dgvDiasHorario.Font = new Font("Inter", 9F);
        dgvDiasHorario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvDiasHorario.Name = "dgvDiasHorario";
        dgvDiasHorario.Size = new Size(870, 190);
        dgvDiasHorario.TabIndex = 6;
        dgvDiasHorario.Columns.AddRange(new DataGridViewColumn[] { colDiasHorarioDia, colDiasHorarioEntrada, colDiasHorarioSalida, colDiasHorarioDiasiguiente, colDiasHorarioTolerancia });
        //
        // lblDiaSemana
        //
        lblDiaSemana.AutoSize = false;
        lblDiaSemana.BackColor = Color.Transparent;
        lblDiaSemana.ForeColor = Color.FromArgb(64, 64, 64);
        lblDiaSemana.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDiaSemana.TextAlign = ContentAlignment.MiddleLeft;
        lblDiaSemana.Text = "Día de la semana";
        lblDiaSemana.Location = new Point(16, 402);
        lblDiaSemana.Font = new Font("Inter", 9F);
        lblDiaSemana.Name = "lblDiaSemana";
        lblDiaSemana.Size = new Size(278, 24);
        lblDiaSemana.TabIndex = 7;
        lblDiaSemana.TabStop = false;
        //
        // cboDiaSemana
        //
        cboDiaSemana.Font = new Font("Inter", 9F);
        cboDiaSemana.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDiaSemana.FormattingEnabled = true;
        cboDiaSemana.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
        cboDiaSemana.Location = new Point(16, 428);
        cboDiaSemana.CornerRadius = 8;
        cboDiaSemana.FillColor = Color.White;
        cboDiaSemana.ForeColor = Color.FromArgb(32, 38, 45);
        cboDiaSemana.BorderColor = Color.FromArgb(218, 218, 218);
        cboDiaSemana.GradientColor = Color.Empty;

        cboDiaSemana.Name = "cboDiaSemana";
        cboDiaSemana.Size = new Size(278, 34);
        cboDiaSemana.TabIndex = 10;
        //
        // lblHoraEntrada
        //
        lblHoraEntrada.AutoSize = false;
        lblHoraEntrada.BackColor = Color.Transparent;
        lblHoraEntrada.ForeColor = Color.FromArgb(64, 64, 64);
        lblHoraEntrada.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblHoraEntrada.TextAlign = ContentAlignment.MiddleLeft;
        lblHoraEntrada.Text = "Hora de entrada";
        lblHoraEntrada.Location = new Point(312, 402);
        lblHoraEntrada.Font = new Font("Inter", 9F);
        lblHoraEntrada.Name = "lblHoraEntrada";
        lblHoraEntrada.Size = new Size(278, 24);
        lblHoraEntrada.TabIndex = 8;
        lblHoraEntrada.TabStop = false;
        //
        // dtpHoraEntrada
        //
        dtpHoraEntrada.Font = new Font("Inter", 10F);
        dtpHoraEntrada.Format = DateTimePickerFormat.Custom;
        dtpHoraEntrada.CustomFormat = "HH:mm";
        dtpHoraEntrada.MinimumSize = new Size(0, 34);
        dtpHoraEntrada.ShowUpDown = true;
        dtpHoraEntrada.Location = new Point(312, 428);
        dtpHoraEntrada.CalendarFont = new Font("Inter", 9F);
        dtpHoraEntrada.Name = "dtpHoraEntrada";
        dtpHoraEntrada.Size = new Size(278, 34);
        dtpHoraEntrada.TabIndex = 11;
        //
        // lblHoraSalida
        //
        lblHoraSalida.AutoSize = false;
        lblHoraSalida.BackColor = Color.Transparent;
        lblHoraSalida.ForeColor = Color.FromArgb(64, 64, 64);
        lblHoraSalida.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblHoraSalida.TextAlign = ContentAlignment.MiddleLeft;
        lblHoraSalida.Text = "Hora de salida";
        lblHoraSalida.Location = new Point(608, 402);
        lblHoraSalida.Font = new Font("Inter", 9F);
        lblHoraSalida.Name = "lblHoraSalida";
        lblHoraSalida.Size = new Size(278, 24);
        lblHoraSalida.TabIndex = 9;
        lblHoraSalida.TabStop = false;
        //
        // dtpHoraSalida
        //
        dtpHoraSalida.Font = new Font("Inter", 10F);
        dtpHoraSalida.Format = DateTimePickerFormat.Custom;
        dtpHoraSalida.CustomFormat = "HH:mm";
        dtpHoraSalida.MinimumSize = new Size(0, 34);
        dtpHoraSalida.ShowUpDown = true;
        dtpHoraSalida.Location = new Point(608, 428);
        dtpHoraSalida.CalendarFont = new Font("Inter", 9F);
        dtpHoraSalida.Name = "dtpHoraSalida";
        dtpHoraSalida.Size = new Size(278, 34);
        dtpHoraSalida.TabIndex = 12;
        //
        // chkSalidaDiaSiguiente
        //
        chkSalidaDiaSiguiente.Font = new Font("Inter", 9F);
        chkSalidaDiaSiguiente.Text = "Salida al día siguiente";
        chkSalidaDiaSiguiente.Location = new Point(16, 496);
        chkSalidaDiaSiguiente.ForeColor = Color.FromArgb(64, 64, 64);
        chkSalidaDiaSiguiente.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkSalidaDiaSiguiente.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
        chkSalidaDiaSiguiente.CheckedState.ForeColor = Color.White;
        chkSalidaDiaSiguiente.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkSalidaDiaSiguiente.Name = "chkSalidaDiaSiguiente";
        chkSalidaDiaSiguiente.Size = new Size(278, 36);
        chkSalidaDiaSiguiente.TabIndex = 14;
        //
        // lblTolerancia
        //
        lblTolerancia.AutoSize = false;
        lblTolerancia.BackColor = Color.Transparent;
        lblTolerancia.ForeColor = Color.FromArgb(64, 64, 64);
        lblTolerancia.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTolerancia.TextAlign = ContentAlignment.MiddleLeft;
        lblTolerancia.Text = "Tolerancia (minutos)";
        lblTolerancia.Location = new Point(312, 472);
        lblTolerancia.Font = new Font("Inter", 9F);
        lblTolerancia.Name = "lblTolerancia";
        lblTolerancia.Size = new Size(278, 24);
        lblTolerancia.TabIndex = 13;
        lblTolerancia.TabStop = false;
        //
        // numTolerancia
        //
        numTolerancia.Font = new Font("Inter", 9F);
        numTolerancia.Maximum = 1440m;
        numTolerancia.DecimalPlaces = 0;
        numTolerancia.Location = new Point(312, 498);
        numTolerancia.ForeColor = Color.FromArgb(64, 64, 64);

        numTolerancia.Name = "numTolerancia";
        numTolerancia.Size = new Size(278, 34);
        numTolerancia.TabIndex = 16;
        //
        // chkLaborable
        //
        chkLaborable.Font = new Font("Inter", 9F);
        chkLaborable.Text = "Trabaja este día";
        chkLaborable.Checked = true;
        chkLaborable.Location = new Point(608, 496);
        chkLaborable.ForeColor = Color.FromArgb(64, 64, 64);
        chkLaborable.CheckedState.FillColor = Color.FromArgb(49, 81, 107);
        chkLaborable.CheckedState.BorderColor = Color.FromArgb(32, 38, 45);
        chkLaborable.CheckedState.ForeColor = Color.White;
        chkLaborable.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        chkLaborable.Name = "chkLaborable";
        chkLaborable.Size = new Size(278, 36);
        chkLaborable.TabIndex = 15;
        //
        // btnAplicarDia
        //
        btnAplicarDia.BackColor = Color.Transparent;
        btnAplicarDia.CornerRadius = 8;
        btnAplicarDia.FlatStyle = FlatStyle.Flat;
        btnAplicarDia.Font = new Font("Inter", 9F);
        btnAplicarDia.Padding = new Padding(10, 4, 10, 4);
        btnAplicarDia.UseVisualStyleBackColor = false;
        btnAplicarDia.Text = "Aplicar al día seleccionado";
        btnAplicarDia.Location = new Point(16, 550);
        btnAplicarDia.BorderThickness = 1;
        btnAplicarDia.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnAplicarDia.FillColor = Color.White;
        btnAplicarDia.ForeColor = Color.FromArgb(32, 38, 45);
        btnAplicarDia.BorderColor = Color.FromArgb(218, 218, 218);
        btnAplicarDia.GradientColor = Color.Empty;
        btnAplicarDia.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnAplicarDia.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnAplicarDia.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnAplicarDia.Name = "btnAplicarDia";
        btnAplicarDia.Size = new Size(220, 40);
        btnAplicarDia.TabIndex = 17;
        //
        // btnGuardar
        //
        btnGuardar.BackColor = Color.Transparent;
        btnGuardar.CornerRadius = 8;
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.Font = new Font("Inter", 9F);
        btnGuardar.Padding = new Padding(10, 4, 10, 4);
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Text = "Guardar";
        btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnGuardar.Location = new Point(586, 613);
        btnGuardar.BorderThickness = 1;
        btnGuardar.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnGuardar.FillColor = Color.FromArgb(49, 81, 107);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.BorderColor = Color.FromArgb(49, 81, 107);
        btnGuardar.GradientColor = Color.Empty;
        btnGuardar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnGuardar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnGuardar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(144, 40);
        btnGuardar.TabIndex = 18;
        //
        // btnCancelar
        //
        btnCancelar.BackColor = Color.Transparent;
        btnCancelar.CornerRadius = 8;
        btnCancelar.FlatStyle = FlatStyle.Flat;
        btnCancelar.Font = new Font("Inter", 9F);
        btnCancelar.Padding = new Padding(10, 4, 10, 4);
        btnCancelar.UseVisualStyleBackColor = false;
        btnCancelar.Text = "Cancelar";
        btnCancelar.DialogResult = DialogResult.Cancel;
        btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnCancelar.Location = new Point(742, 613);
        btnCancelar.BorderThickness = 1;
        btnCancelar.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
        btnCancelar.FillColor = Color.FromArgb(255, 248, 248);
        btnCancelar.ForeColor = Color.FromArgb(166, 61, 64);
        btnCancelar.BorderColor = Color.FromArgb(204, 148, 150);
        btnCancelar.GradientColor = Color.Empty;
        btnCancelar.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
        btnCancelar.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
        btnCancelar.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
        btnCancelar.Name = "btnCancelar";
        btnCancelar.Size = new Size(144, 40);
        btnCancelar.TabIndex = 19;
        //
        // colDiasHorarioDia
        //
        colDiasHorarioDia.HeaderText = "Día";
        colDiasHorarioDia.Name = "colDiasHorarioDia";
        colDiasHorarioDia.ReadOnly = true;
        //
        // colDiasHorarioEntrada
        //
        colDiasHorarioEntrada.HeaderText = "Entrada";
        colDiasHorarioEntrada.Name = "colDiasHorarioEntrada";
        colDiasHorarioEntrada.ReadOnly = true;
        //
        // colDiasHorarioSalida
        //
        colDiasHorarioSalida.HeaderText = "Salida";
        colDiasHorarioSalida.Name = "colDiasHorarioSalida";
        colDiasHorarioSalida.ReadOnly = true;
        //
        // colDiasHorarioDiasiguiente
        //
        colDiasHorarioDiasiguiente.HeaderText = "Día siguiente";
        colDiasHorarioDiasiguiente.Name = "colDiasHorarioDiasiguiente";
        colDiasHorarioDiasiguiente.ReadOnly = true;
        //
        // colDiasHorarioTolerancia
        //
        colDiasHorarioTolerancia.HeaderText = "Tolerancia";
        colDiasHorarioTolerancia.Name = "colDiasHorarioTolerancia";
        colDiasHorarioTolerancia.ReadOnly = true;
        notificador.OwnerForm = this;
        //
        // FrmHorario
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
        Controls.Add(lblTitulo);
        Controls.Add(btnCerrar);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(chkActivo);
        Controls.Add(lblDiasHorarioTitulo);
        Controls.Add(dgvDiasHorario);
        Controls.Add(lblDiaSemana);
        Controls.Add(cboDiaSemana);
        Controls.Add(lblHoraEntrada);
        Controls.Add(dtpHoraEntrada);
        Controls.Add(lblHoraSalida);
        Controls.Add(dtpHoraSalida);
        Controls.Add(chkSalidaDiaSiguiente);
        Controls.Add(lblTolerancia);
        Controls.Add(numTolerancia);
        Controls.Add(chkLaborable);
        Controls.Add(btnAplicarDia);
        Controls.Add(btnGuardar);
        Controls.Add(btnCancelar);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        CancelButton = btnCancelar;
        Font = new Font("Segoe UI", 9F);
        Name = "FrmHorario";
        Text = "Horario y distribución semanal";
        ((System.ComponentModel.ISupportInitialize)dgvDiasHorario).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KButton btnCerrar;
    private KovaqsUI.Controls.KLabel lblNombre;
    private KovaqsUI.Controls.KTextBox txtNombre;
    private KovaqsUI.Controls.KCheckBox chkActivo;
    private KovaqsUI.Controls.KLabel lblDiasHorarioTitulo;
    private KovaqsUI.Controls.KDataGridView dgvDiasHorario;
    private KovaqsUI.Controls.KLabel lblDiaSemana;
    private KovaqsUI.Controls.KComboBox cboDiaSemana;
    private KovaqsUI.Controls.KLabel lblHoraEntrada;
    private DateTimePicker dtpHoraEntrada;
    private KovaqsUI.Controls.KLabel lblHoraSalida;
    private DateTimePicker dtpHoraSalida;
    private KovaqsUI.Controls.KCheckBox chkSalidaDiaSiguiente;
    private KovaqsUI.Controls.KLabel lblTolerancia;
    private KovaqsUI.Controls.KNumericUpDown numTolerancia;
    private KovaqsUI.Controls.KCheckBox chkLaborable;
    private KovaqsUI.Controls.KButton btnAplicarDia;
    private KovaqsUI.Controls.KButton btnGuardar;
    private KovaqsUI.Controls.KButton btnCancelar;
    private DataGridViewTextBoxColumn colDiasHorarioDia;
    private DataGridViewTextBoxColumn colDiasHorarioEntrada;
    private DataGridViewTextBoxColumn colDiasHorarioSalida;
    private DataGridViewCheckBoxColumn colDiasHorarioDiasiguiente;
    private DataGridViewTextBoxColumn colDiasHorarioTolerancia;
    private KovaqsUI.Components.KToastNotifier notificador;
}
