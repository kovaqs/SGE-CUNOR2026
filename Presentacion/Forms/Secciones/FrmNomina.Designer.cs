namespace Presentacion.Forms.Secciones;

partial class FrmNomina
{
    private readonly Negocios.ServicioPeriodosNomina consulta = new();
    private int paginaConsulta;
    private bool consultando;

    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();

        base.Dispose(disposing);
    }

    private void PrepararConsulta()
    {
        if (System.ComponentModel.LicenseManager.UsageMode ==
        System.ComponentModel.LicenseUsageMode.Designtime) return;
        dtpDesde.Value = new DateTime(DateTime.Today.Year, 1, 1);
        dtpHasta.Value = DateTime.Today;
        cboEstado.SelectedIndex = 0;
        cboTamanoPagina.SelectedIndex = 0;
        dgvPeriodos.AutoGenerateColumns = false;
        colDesde.DefaultCellStyle.Format = "dd/MM/yyyy";
        colHasta.DefaultCellStyle.Format = "dd/MM/yyyy";
        colFechaCierre.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        Load += Consulta_Filtro;
        dtpDesde.ValueChanged += Consulta_Filtro;
        dtpHasta.ValueChanged += Consulta_Filtro;
        cboEstado.SelectedIndexChanged += Consulta_Filtro;
        cboTamanoPagina.SelectedIndexChanged += Consulta_Filtro;
        btnAnterior.Click += Consulta_Anterior;
        btnSiguiente.Click += Consulta_Siguiente;
    }

    private async void Consulta_Filtro(object? sender, EventArgs e)
    {
        if (consultando) return;
        paginaConsulta = 0;
        await CargarConsultaAsync();
    }

    private async Task CargarConsultaAsync()
    {
        if (consultando) return;
        consultando = true;
        HabilitarFiltrosConsulta(false);
        btnAnterior.Enabled = false;
        btnSiguiente.Enabled = false;

        try
        {
            int tamano = int.Parse(cboTamanoPagina.Text);
            var registros = await consulta.ListarAsync(
                dtpDesde.Value, dtpHasta.Value, cboEstado.Text,
                paginaConsulta, tamano);

            if (IsDisposed) return;

            bool haySiguiente = registros.Count > tamano;
            if (haySiguiente) registros.RemoveAt(tamano);

            dgvPeriodos.Rows.Clear();
            foreach (var registro in registros)
            {
                int fila = dgvPeriodos.Rows.Add(
                    registro.Nombre, registro.Desde, registro.Hasta,
                    registro.Estado, registro.GeneradoPor, registro.FechaCierre);
                dgvPeriodos.Rows[fila].Tag = registro;
            }

            lblPagina.Text = "Página " + (paginaConsulta + 1);
            btnAnterior.Enabled = paginaConsulta > 0;
            btnSiguiente.Enabled = haySiguiente;
        }
        catch (Exception ex)
        {
            if (!IsDisposed)
                notificador.Show("Consulta", ex.Message,
                    KovaqsUI.Components.KToastKind.Warning);
        }
        finally
        {
            consultando = false;
            if (!IsDisposed) HabilitarFiltrosConsulta(true);
        }
    }

    private void HabilitarFiltrosConsulta(bool habilitar)
    {
        dtpDesde.Enabled = dtpHasta.Enabled = habilitar;
        cboEstado.Enabled = cboTamanoPagina.Enabled = habilitar;
    }

    private async void Consulta_Anterior(object? sender, EventArgs e)
    {
        if (consultando || paginaConsulta == 0) return;
        paginaConsulta--;
        await CargarConsultaAsync();
    }

    private async void Consulta_Siguiente(object? sender, EventArgs e)
    {
        if (consultando) return;
        paginaConsulta++;
        await CargarConsultaAsync();
    }


    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        dtpDesde = new DateTimePicker();
        dtpHasta = new DateTimePicker();
        cboEstado = new KovaqsUI.Controls.KComboBox();
        btnNuevoPeriodo = new KovaqsUI.Controls.KButton();
        btnBoletas = new KovaqsUI.Controls.KButton();
        btnAnterior = new KovaqsUI.Controls.KButton();
        btnSiguiente = new KovaqsUI.Controls.KButton();
        cboTamanoPagina = new KovaqsUI.Controls.KComboBox();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        lblDesde = new KovaqsUI.Controls.KLabel();
        lblHasta = new KovaqsUI.Controls.KLabel();
        lblEstado = new KovaqsUI.Controls.KLabel();
        lblTituloTabla = new KovaqsUI.Controls.KLabel();
        dgvPeriodos = new KovaqsUI.Controls.KDataGridView();
        colNombre = new DataGridViewTextBoxColumn();
        colDesde = new DataGridViewTextBoxColumn();
        colHasta = new DataGridViewTextBoxColumn();
        colEstado = new DataGridViewTextBoxColumn();
        colGeneradoPor = new DataGridViewTextBoxColumn();
        colFechaCierre = new DataGridViewTextBoxColumn();
        cmsPeriodos = new ContextMenuStrip(components);
        mnuVerPeriodo = new ToolStripMenuItem();
        lblPagina = new KovaqsUI.Controls.KLabel();
        lblTamanoPagina = new KovaqsUI.Controls.KLabel();
        btnAcciones = new KovaqsUI.Controls.KButton();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        ((System.ComponentModel.ISupportInitialize)dgvPeriodos).BeginInit();
        cmsPeriodos.SuspendLayout();
        SuspendLayout();
        // 
        // dtpDesde
        // 
        dtpDesde.CalendarFont = new Font("Microsoft Sans Serif", 9F);
        dtpDesde.CustomFormat = "dd/MM/yyyy";
        dtpDesde.Font = new Font("Microsoft Sans Serif", 10F);
        dtpDesde.Format = DateTimePickerFormat.Custom;
        dtpDesde.Location = new Point(18, 128);
        dtpDesde.Margin = new Padding(3, 4, 3, 4);
        dtpDesde.MinimumSize = new Size(4, 34);
        dtpDesde.Name = "dtpDesde";
        dtpDesde.Size = new Size(404, 34);
        dtpDesde.TabIndex = 4;
        // 
        // dtpHasta
        // 
        dtpHasta.CalendarFont = new Font("Microsoft Sans Serif", 9F);
        dtpHasta.CustomFormat = "dd/MM/yyyy";
        dtpHasta.Font = new Font("Microsoft Sans Serif", 10F);
        dtpHasta.Format = DateTimePickerFormat.Custom;
        dtpHasta.Location = new Point(441, 128);
        dtpHasta.Margin = new Padding(3, 4, 3, 4);
        dtpHasta.MinimumSize = new Size(4, 34);
        dtpHasta.Name = "dtpHasta";
        dtpHasta.Size = new Size(404, 34);
        dtpHasta.TabIndex = 5;
        // 
        // cboEstado
        // 
        cboEstado.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.Appearance.Normal.FillColor = Color.White;
        cboEstado.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.BackColor = Color.White;
        cboEstado.BorderColor = Color.FromArgb(218, 218, 218);
        cboEstado.FillColor = Color.White;
        cboEstado.Font = new Font("Inter", 9F);
        cboEstado.ForeColor = Color.FromArgb(32, 38, 45);
        cboEstado.FormattingEnabled = true;
        cboEstado.ItemHeight = 28;
        cboEstado.Items.AddRange(new object[] { "Todos", "Borrador", "Cerrado", "Anulado" });
        cboEstado.Location = new Point(864, 128);
        cboEstado.Margin = new Padding(3, 4, 3, 4);
        cboEstado.Name = "cboEstado";
        cboEstado.Size = new Size(404, 34);
        cboEstado.TabIndex = 6;
        // 
        // btnNuevoPeriodo
        // 
        btnNuevoPeriodo.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnNuevoPeriodo.Appearance.Normal.BorderColor = Color.FromArgb(49, 81, 107);
        btnNuevoPeriodo.Appearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
        btnNuevoPeriodo.Appearance.Normal.ForeColor = Color.White;
        btnNuevoPeriodo.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnNuevoPeriodo.BackColor = Color.Transparent;
        btnNuevoPeriodo.BorderColor = Color.FromArgb(49, 81, 107);
        btnNuevoPeriodo.ClickColor = Color.Black;
        btnNuevoPeriodo.CornerRadius = 8;
        btnNuevoPeriodo.FillColor = Color.FromArgb(49, 81, 107);
        btnNuevoPeriodo.FlatStyle = FlatStyle.Flat;
        btnNuevoPeriodo.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnNuevoPeriodo.Font = new Font("Inter", 9F);
        btnNuevoPeriodo.ForeColor = Color.White;
        btnNuevoPeriodo.Location = new Point(18, 192);
        btnNuevoPeriodo.Margin = new Padding(3, 4, 3, 4);
        btnNuevoPeriodo.Name = "btnNuevoPeriodo";
        btnNuevoPeriodo.Padding = new Padding(11, 5, 11, 5);
        btnNuevoPeriodo.Size = new Size(302, 53);
        btnNuevoPeriodo.TabIndex = 7;
        btnNuevoPeriodo.Text = "Nuevo período";
        btnNuevoPeriodo.UseVisualStyleBackColor = false;
        // 
        // btnBoletas
        // 
        btnBoletas.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnBoletas.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        btnBoletas.Appearance.Normal.FillColor = Color.White;
        btnBoletas.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        btnBoletas.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnBoletas.BackColor = Color.Transparent;
        btnBoletas.BorderColor = Color.FromArgb(218, 218, 218);
        btnBoletas.CornerRadius = 8;
        btnBoletas.FillColor = Color.White;
        btnBoletas.FlatStyle = FlatStyle.Flat;
        btnBoletas.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnBoletas.Font = new Font("Inter", 9F);
        btnBoletas.ForeColor = Color.FromArgb(32, 38, 45);
        btnBoletas.Location = new Point(649, 192);
        btnBoletas.Margin = new Padding(3, 4, 3, 4);
        btnBoletas.Name = "btnBoletas";
        btnBoletas.Padding = new Padding(11, 5, 11, 5);
        btnBoletas.Size = new Size(302, 53);
        btnBoletas.TabIndex = 9;
        btnBoletas.Text = "Boletas por departamento";
        btnBoletas.UseVisualStyleBackColor = false;
        btnBoletas.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // btnAnterior
        // 
        btnAnterior.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnAnterior.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnAnterior.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        btnAnterior.Appearance.Normal.FillColor = Color.White;
        btnAnterior.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        btnAnterior.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnAnterior.BackColor = Color.Transparent;
        btnAnterior.BorderColor = Color.FromArgb(218, 218, 218);
        btnAnterior.CornerRadius = 8;
        btnAnterior.FillColor = Color.White;
        btnAnterior.FlatStyle = FlatStyle.Flat;
        btnAnterior.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnAnterior.Font = new Font("Inter", 9F);
        btnAnterior.ForeColor = Color.FromArgb(32, 38, 45);
        btnAnterior.Location = new Point(18, 917);
        btnAnterior.Margin = new Padding(3, 4, 3, 4);
        btnAnterior.Name = "btnAnterior";
        btnAnterior.Padding = new Padding(11, 5, 11, 5);
        btnAnterior.Size = new Size(142, 53);
        btnAnterior.TabIndex = 12;
        btnAnterior.Text = "Anterior";
        btnAnterior.UseVisualStyleBackColor = false;
        btnAnterior.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // btnSiguiente
        // 
        btnSiguiente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSiguiente.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnSiguiente.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        btnSiguiente.Appearance.Normal.FillColor = Color.White;
        btnSiguiente.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        btnSiguiente.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnSiguiente.BackColor = Color.Transparent;
        btnSiguiente.BorderColor = Color.FromArgb(218, 218, 218);
        btnSiguiente.CornerRadius = 8;
        btnSiguiente.FillColor = Color.White;
        btnSiguiente.FlatStyle = FlatStyle.Flat;
        btnSiguiente.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnSiguiente.Font = new Font("Inter", 9F);
        btnSiguiente.ForeColor = Color.FromArgb(32, 38, 45);
        btnSiguiente.Location = new Point(331, 917);
        btnSiguiente.Margin = new Padding(3, 4, 3, 4);
        btnSiguiente.Name = "btnSiguiente";
        btnSiguiente.Padding = new Padding(11, 5, 11, 5);
        btnSiguiente.Size = new Size(142, 53);
        btnSiguiente.TabIndex = 14;
        btnSiguiente.Text = "Siguiente";
        btnSiguiente.UseVisualStyleBackColor = false;
        btnSiguiente.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // cboTamanoPagina
        // 
        cboTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cboTamanoPagina.Appearance.Normal.BorderColor = Color.FromArgb(218, 218, 218);
        cboTamanoPagina.Appearance.Normal.FillColor = Color.White;
        cboTamanoPagina.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
        cboTamanoPagina.BackColor = Color.White;
        cboTamanoPagina.BorderColor = Color.FromArgb(218, 218, 218);
        cboTamanoPagina.FillColor = Color.White;
        cboTamanoPagina.Font = new Font("Inter", 9F);
        cboTamanoPagina.ForeColor = Color.FromArgb(32, 38, 45);
        cboTamanoPagina.FormattingEnabled = true;
        cboTamanoPagina.ItemHeight = 28;
        cboTamanoPagina.Items.AddRange(new object[] { "10", "25", "50", "100" });
        cboTamanoPagina.Location = new Point(1090, 921);
        cboTamanoPagina.Margin = new Padding(3, 4, 3, 4);
        cboTamanoPagina.Name = "cboTamanoPagina";
        cboTamanoPagina.Size = new Size(178, 34);
        cboTamanoPagina.TabIndex = 16;
        // 
        // lblTitulo
        // 
        lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.Location = new Point(18, 16);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1250, 53);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Períodos de nómina";
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        lblTitulo.Click += lblTitulo_Click;
        // 
        // kLabel2
        // 
        kLabel2.AutoSize = false;
        kLabel2.BackColor = Color.Transparent;
        kLabel2.Font = new Font("Inter", 9F);
        kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel2.Location = new Point(18, 93);
        kLabel2.Name = "kLabel2";
        kLabel2.Size = new Size(405, 32);
        kLabel2.TabIndex = 1;
        kLabel2.Text = "Desde";
        kLabel2.TextAlign = ContentAlignment.MiddleLeft;
        kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // kLabel3
        // 
        kLabel3.AutoSize = false;
        kLabel3.BackColor = Color.Transparent;
        kLabel3.Font = new Font("Inter", 9F);
        kLabel3.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel3.Location = new Point(441, 93);
        kLabel3.Name = "kLabel3";
        kLabel3.Size = new Size(405, 32);
        kLabel3.TabIndex = 2;
        kLabel3.Text = "Hasta";
        kLabel3.TextAlign = ContentAlignment.MiddleLeft;
        kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // lblEstado
        // 
        lblEstado.AutoSize = false;
        lblEstado.BackColor = Color.Transparent;
        lblEstado.Font = new Font("Inter", 9F);
        lblEstado.ForeColor = Color.FromArgb(64, 64, 64);
        lblEstado.Location = new Point(864, 93);
        lblEstado.Name = "lblEstado";
        lblEstado.Size = new Size(405, 32);
        lblEstado.TabIndex = 3;
        lblEstado.Text = "Estado";
        lblEstado.TextAlign = ContentAlignment.MiddleLeft;
        lblEstado.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // kLabel4
        // 
        kLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        kLabel4.AutoSize = false;
        kLabel4.BackColor = Color.Transparent;
        kLabel4.Font = new Font("Inter", 9F);
        kLabel4.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel4.Location = new Point(18, 264);
        kLabel4.Name = "kLabel4";
        kLabel4.Size = new Size(1250, 32);
        kLabel4.TabIndex = 10;
        kLabel4.Text = "Períodos de pago";
        kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // dgvPeriodos
        // 
        dgvPeriodos.AllowUserToAddRows = false;
        dgvPeriodos.AllowUserToDeleteRows = false;
        dgvPeriodos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvPeriodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvPeriodos.BackgroundColor = Color.White;
        dgvPeriodos.BorderStyle = BorderStyle.None;
        dgvPeriodos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvPeriodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvPeriodos.ColumnHeadersHeight = 42;
        dgvPeriodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgvPeriodos.Columns.AddRange(new DataGridViewColumn[] { colNombre, colDesde, colHasta, colEstado, colGeneradoPor, colFechaCierre });
        dgvPeriodos.ContextMenuStrip = cmsPeriodos;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.Padding = new Padding(8, 4, 8, 4);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 238, 245);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(13, 21, 23);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        dgvPeriodos.DefaultCellStyle = dataGridViewCellStyle2;
        dgvPeriodos.EnableHeadersVisualStyles = false;
        dgvPeriodos.Font = new Font("Inter", 9F);
        dgvPeriodos.GridColor = Color.FromArgb(218, 218, 218);
        dgvPeriodos.Location = new Point(18, 299);
        dgvPeriodos.Margin = new Padding(3, 4, 3, 4);
        dgvPeriodos.MultiSelect = false;
        dgvPeriodos.Name = "dgvPeriodos";
        dgvPeriodos.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(244, 244, 244);
        dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 85, 99);
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgvPeriodos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgvPeriodos.RowHeadersVisible = false;
        dgvPeriodos.RowHeadersWidth = 51;
        dgvPeriodos.RowTemplate.Height = 42;
        dgvPeriodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvPeriodos.Size = new Size(1250, 597);
        dgvPeriodos.TabIndex = 11;
        dgvPeriodos.CellDoubleClick += dgvPeriodos_CellDoubleClick;
        dgvPeriodos.SelectionChanged += dgvPeriodos_SelectionChanged;
        dgvPeriodos.MouseDown += dgvPeriodos_MouseDown;
        // 
        // colNombre
        // 
        colNombre.HeaderText = "Nombre";
        colNombre.MinimumWidth = 6;
        colNombre.Name = "colNombre";
        colNombre.ReadOnly = true;
        // 
        // colDesde
        // 
        colDesde.HeaderText = "Desde";
        colDesde.MinimumWidth = 6;
        colDesde.Name = "colDesde";
        colDesde.ReadOnly = true;
        // 
        // colHasta
        // 
        colHasta.HeaderText = "Hasta";
        colHasta.MinimumWidth = 6;
        colHasta.Name = "colHasta";
        colHasta.ReadOnly = true;
        // 
        // colEstado
        // 
        colEstado.HeaderText = "Estado";
        colEstado.MinimumWidth = 6;
        colEstado.Name = "colEstado";
        colEstado.ReadOnly = true;
        // 
        // colGeneradoPor
        // 
        colGeneradoPor.HeaderText = "Generado por";
        colGeneradoPor.MinimumWidth = 6;
        colGeneradoPor.Name = "colGeneradoPor";
        colGeneradoPor.ReadOnly = true;
        // 
        // colFechaCierre
        // 
        colFechaCierre.HeaderText = "Fecha de cierre";
        colFechaCierre.MinimumWidth = 6;
        colFechaCierre.Name = "colFechaCierre";
        colFechaCierre.ReadOnly = true;
        // 
        // cmsPeriodos
        // 
        cmsPeriodos.Font = new Font("Microsoft Sans Serif", 9F);
        cmsPeriodos.ImageScalingSize = new Size(20, 20);
        cmsPeriodos.Items.AddRange(new ToolStripItem[] { mnuVerPeriodo });
        cmsPeriodos.Name = "cmsPeriodos";
        cmsPeriodos.ShowImageMargin = false;
        cmsPeriodos.Size = new Size(120, 26);
        cmsPeriodos.Opening += cmsPeriodos_Opening;
        // 
        // mnuVerPeriodo
        // 
        mnuVerPeriodo.ForeColor = Color.FromArgb(32, 38, 45);
        mnuVerPeriodo.Name = "mnuVerPeriodo";
        mnuVerPeriodo.Size = new Size(119, 22);
        mnuVerPeriodo.Text = "Ver detalle";
        // 
        // lblPagina
        // 
        lblPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblPagina.AutoSize = false;
        lblPagina.BackColor = Color.Transparent;
        lblPagina.Font = new Font("Inter", 9F);
        lblPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblPagina.Location = new Point(171, 917);
        lblPagina.Name = "lblPagina";
        lblPagina.Size = new Size(149, 53);
        lblPagina.TabIndex = 13;
        lblPagina.Text = "Página 1 de 1";
        lblPagina.TextAlign = ContentAlignment.MiddleCenter;
        lblPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // lblTamanoPagina
        // 
        lblTamanoPagina.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblTamanoPagina.AutoSize = false;
        lblTamanoPagina.BackColor = Color.Transparent;
        lblTamanoPagina.Font = new Font("Inter", 9F);
        lblTamanoPagina.ForeColor = Color.FromArgb(64, 64, 64);
        lblTamanoPagina.Location = new Point(930, 917);
        lblTamanoPagina.Name = "lblTamanoPagina";
        lblTamanoPagina.Size = new Size(149, 53);
        lblTamanoPagina.TabIndex = 15;
        lblTamanoPagina.Text = "Filas por página";
        lblTamanoPagina.TextAlign = ContentAlignment.MiddleLeft;
        lblTamanoPagina.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // btnAcciones
        // 
        btnAcciones.Appearance.Hover.FillColor = Color.FromArgb(239, 244, 248);
        btnAcciones.Appearance.Normal.BorderColor = Color.FromArgb(173, 190, 204);
        btnAcciones.Appearance.Normal.FillColor = Color.White;
        btnAcciones.Appearance.Normal.ForeColor = Color.FromArgb(49, 81, 107);
        btnAcciones.Appearance.Pressed.FillColor = Color.FromArgb(225, 235, 243);
        btnAcciones.BackColor = Color.Transparent;
        btnAcciones.BorderColor = Color.FromArgb(173, 190, 204);
        btnAcciones.CornerRadius = 8;
        btnAcciones.Enabled = false;
        btnAcciones.FillColor = Color.White;
        btnAcciones.FlatStyle = FlatStyle.Flat;
        btnAcciones.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnAcciones.Font = new Font("Inter", 9F);
        btnAcciones.ForeColor = Color.FromArgb(49, 81, 107);
        btnAcciones.Location = new Point(334, 192);
        btnAcciones.Margin = new Padding(3, 4, 3, 4);
        btnAcciones.Name = "btnAcciones";
        btnAcciones.Padding = new Padding(11, 5, 11, 5);
        btnAcciones.Size = new Size(302, 53);
        btnAcciones.TabIndex = 8;
        btnAcciones.Text = "Acciones ▾";
        btnAcciones.UseVisualStyleBackColor = false;
        btnAcciones.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnAcciones.Click += btnAcciones_Click;
        // 
        // notificador
        // 
        notificador.OwnerForm = this;
        // 
        // FrmNomina
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1287, 992);
        Controls.Add(btnAcciones);
        Controls.Add(lblPagina);
        Controls.Add(dgvPeriodos);
        Controls.Add(lblTituloTabla);
        Controls.Add(lblEstado);
        Controls.Add(lblHasta);
        Controls.Add(lblDesde);
        Controls.Add(lblTitulo);
        Controls.Add(cboTamanoPagina);
        Controls.Add(btnSiguiente);
        Controls.Add(btnAnterior);
        Controls.Add(btnBoletas);
        Controls.Add(btnNuevoPeriodo);
        Controls.Add(cboEstado);
        Controls.Add(dtpHasta);
        Controls.Add(dtpDesde);
        Controls.Add(lblTamanoPagina);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(1287, 992);
        Name = "FrmNomina";
        Text = "Nómina";
        ((System.ComponentModel.ISupportInitialize)dgvPeriodos).EndInit();
        cmsPeriodos.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KButton btnAcciones;
    private ContextMenuStrip cmsPeriodos;
    private ToolStripMenuItem mnuVerPeriodo;
    private DateTimePicker dtpDesde;
    private DateTimePicker dtpHasta;
    private KovaqsUI.Controls.KComboBox cboEstado;
    private KovaqsUI.Controls.KButton btnNuevoPeriodo;
    private KovaqsUI.Controls.KButton btnBoletas;
    private KovaqsUI.Controls.KButton btnAnterior;
    private KovaqsUI.Controls.KButton btnSiguiente;
    private KovaqsUI.Controls.KComboBox cboTamanoPagina;
    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KLabel lblDesde;
    private KovaqsUI.Controls.KLabel lblHasta;
    private KovaqsUI.Controls.KLabel lblEstado;
    private KovaqsUI.Controls.KLabel lblTituloTabla;
    private KovaqsUI.Controls.KDataGridView dgvPeriodos;
    private KovaqsUI.Controls.KLabel lblPagina;
    private DataGridViewTextBoxColumn colNombre;
    private DataGridViewTextBoxColumn colDesde;
    private DataGridViewTextBoxColumn colHasta;
    private DataGridViewTextBoxColumn colEstado;
    private DataGridViewTextBoxColumn colGeneradoPor;
    private DataGridViewTextBoxColumn colFechaCierre;
    private KovaqsUI.Controls.KLabel lblTamanoPagina;
    private KovaqsUI.Components.KToastNotifier notificador;
}
