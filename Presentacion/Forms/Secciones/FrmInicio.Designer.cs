namespace Presentacion.Forms.Secciones;

partial class FrmInicio
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
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        notificador.OwnerForm = this;
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
        LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
        LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
        LiveChartsCore.Drawing.Padding padding3 = new LiveChartsCore.Drawing.Padding();
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
        LiveChartsCore.Drawing.Padding padding4 = new LiveChartsCore.Drawing.Padding();
        kLabel7 = new KovaqsUI.Controls.KLabel();
        kLabel1 = new KovaqsUI.Controls.KLabel();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        kLabel2 = new KovaqsUI.Controls.KLabel();
        kPanel4 = new KovaqsUI.Controls.KPanel();
        kLabel3 = new KovaqsUI.Controls.KLabel();
        pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
        kPanel5 = new KovaqsUI.Controls.KPanel();
        cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
        kLabel4 = new KovaqsUI.Controls.KLabel();
        flowLayoutPanel1 = new FlowLayoutPanel();
        kPanel3 = new KovaqsUI.Controls.KPanel();
        lblEmpleadosActivos = new KovaqsUI.Controls.KLabel();
        kLabel5 = new KovaqsUI.Controls.KLabel();
        kPanel2 = new KovaqsUI.Controls.KPanel();
        lblFaltasMes = new KovaqsUI.Controls.KLabel();
        kLabel6 = new KovaqsUI.Controls.KLabel();
        kPanel1 = new KovaqsUI.Controls.KPanel();
        lblTardanzasMes = new KovaqsUI.Controls.KLabel();
        kLabel8 = new KovaqsUI.Controls.KLabel();
        dtpPeriodo = new DateTimePicker();
        btnConsultar = new KovaqsUI.Controls.KButton();
        btnVerEmpleados = new KovaqsUI.Controls.KButton();
        btnVerAsistencias = new KovaqsUI.Controls.KButton();
        btnVerNomina = new KovaqsUI.Controls.KButton();
        kPanel4.SuspendLayout();
        kPanel5.SuspendLayout();
        flowLayoutPanel1.SuspendLayout();
        kPanel3.SuspendLayout();
        kPanel2.SuspendLayout();
        kPanel1.SuspendLayout();
        SuspendLayout();
        //
        // kLabel7
        //
        kLabel7.AutoSize = false;
        kLabel7.BackColor = Color.Transparent;
        kLabel7.Dock = DockStyle.None;
        kLabel7.Location = new Point(16, 12);
        kLabel7.TextAlign = ContentAlignment.MiddleLeft;
        kLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        kLabel7.Font = new Font("Inter", 16F, FontStyle.Bold);
        kLabel7.ForeColor = Color.FromArgb(32, 38, 45);
        kLabel7.TabStop = false;
        kLabel7.Name = "kLabel7";
        kLabel7.Size = new Size(1094, 40);
        kLabel7.TabIndex = 0;
        kLabel7.Text = "Inicio";
        kLabel7.TextRole = KovaqsUI.Controls.KTextRole.Title;
        //
        // kLabel1
        //
        kLabel1.AutoSize = false;
        kLabel1.BackColor = Color.Transparent;
        kLabel1.Location = new Point(16, 70);
        kLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        kLabel1.Font = new Font("Inter", 9F);
        kLabel1.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel1.TabStop = false;
        kLabel1.Name = "kLabel1";
        kLabel1.Size = new Size(354, 24);
        kLabel1.TabIndex = 1;
        kLabel1.Text = "Mes de consulta";
        kLabel1.TextAlign = ContentAlignment.MiddleLeft;
        kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // cboDepartamento
        //
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.ItemHeight = 28;
        cboDepartamento.Location = new Point(386, 96);
        cboDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        cboDepartamento.Font = new Font("Inter", 9F);
        cboDepartamento.CornerRadius = 8;
        cboDepartamento.FillColor = Color.White;
        cboDepartamento.ForeColor = Color.FromArgb(32, 38, 45);
        cboDepartamento.BorderColor = Color.FromArgb(218, 218, 218);
        cboDepartamento.GradientColor = Color.Empty;
        cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;

        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(354, 34);
        cboDepartamento.TabIndex = 4;
        //
        // kLabel2
        //
        kLabel2.AutoSize = false;
        kLabel2.BackColor = Color.Transparent;
        kLabel2.Location = new Point(386, 70);
        kLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        kLabel2.Font = new Font("Inter", 9F);
        kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel2.TabStop = false;
        kLabel2.Name = "kLabel2";
        kLabel2.Size = new Size(354, 24);
        kLabel2.TabIndex = 2;
        kLabel2.Text = "Departamento";
        kLabel2.TextAlign = ContentAlignment.MiddleLeft;
        kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // kPanel4
        //
        kPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        kPanel4.BackColor = Color.Transparent;
        kPanel4.Controls.Add(kLabel3);
        kPanel4.Controls.Add(pieChart1);
        kPanel4.Location = new Point(0, 148);
        kPanel4.Margin = new Padding(0, 0, 16, 0);
        kPanel4.FillColor = Color.White;
        kPanel4.BorderColor = Color.FromArgb(218, 218, 218);
        kPanel4.GradientColor = Color.Empty;
        kPanel4.CornerRadius = 8;
        kPanel4.Name = "kPanel4";
        kPanel4.Padding = new Padding(12);
        kPanel4.Shadow.Blur = 5;
        kPanel4.Shadow.Enabled = false;
        kPanel4.Shadow.Offset = new Point(0, 1);
        kPanel4.Shadow.Opacity = 10;
        kPanel4.Size = new Size(539, 326);
        kPanel4.TabIndex = 3;
        //
        // kLabel3
        //
        kLabel3.AutoSize = false;
        kLabel3.BackColor = Color.Transparent;
        kLabel3.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel3.Location = new Point(16, 14);
        kLabel3.Font = new Font("Inter", 9F);
        kLabel3.TabStop = false;
        kLabel3.Name = "kLabel3";
        kLabel3.Size = new Size(507, 26);
        kLabel3.TabIndex = 0;
        kLabel3.Text = "Masa salarial por departamento";
        kLabel3.TextAlign = ContentAlignment.MiddleLeft;
        kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // pieChart1
        //
        pieChart1.AutoUpdateEnabled = true;
        pieChart1.BackColor = Color.White;
        pieChart1.ChartTheme = null;
        skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultLegend1.Content = null;
        skDefaultLegend1.IsValid = false;
        skDefaultLegend1.Opacity = 1F;
        padding1.Bottom = 0F;
        padding1.Left = 0F;
        padding1.Right = 0F;
        padding1.Top = 0F;
        skDefaultLegend1.Padding = padding1;
        skDefaultLegend1.RemoveOnCompleted = false;
        skDefaultLegend1.RotateTransform = 0F;
        skDefaultLegend1.X = 0F;
        skDefaultLegend1.Y = 0F;
        pieChart1.Legend = skDefaultLegend1;
        pieChart1.Location = new Point(16, 52);
        pieChart1.Name = "pieChart1";
        pieChart1.Size = new Size(507, 258);
        pieChart1.TabIndex = 1;
        skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultTooltip1.Content = null;
        skDefaultTooltip1.IsValid = false;
        skDefaultTooltip1.Opacity = 1F;
        padding2.Bottom = 0F;
        padding2.Left = 0F;
        padding2.Right = 0F;
        padding2.Top = 0F;
        skDefaultTooltip1.Padding = padding2;
        skDefaultTooltip1.RemoveOnCompleted = false;
        skDefaultTooltip1.RotateTransform = 0F;
        skDefaultTooltip1.Wedge = 10;
        skDefaultTooltip1.X = 0F;
        skDefaultTooltip1.Y = 0F;
        pieChart1.Tooltip = skDefaultTooltip1;
        pieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
        //
        // kPanel5
        //
        kPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        kPanel5.BackColor = Color.Transparent;
        kPanel5.Controls.Add(cartesianChart1);
        kPanel5.Controls.Add(kLabel4);
        kPanel5.Location = new Point(555, 148);
        kPanel5.Margin = new Padding(0);
        kPanel5.FillColor = Color.White;
        kPanel5.BorderColor = Color.FromArgb(218, 218, 218);
        kPanel5.GradientColor = Color.Empty;
        kPanel5.CornerRadius = 8;
        kPanel5.Name = "kPanel5";
        kPanel5.Padding = new Padding(12);
        kPanel5.Shadow.Blur = 5;
        kPanel5.Shadow.Enabled = false;
        kPanel5.Shadow.Offset = new Point(0, 1);
        kPanel5.Shadow.Opacity = 10;
        kPanel5.Size = new Size(539, 326);
        kPanel5.TabIndex = 4;
        //
        // cartesianChart1
        //
        cartesianChart1.AutoUpdateEnabled = true;
        cartesianChart1.BackColor = Color.White;
        cartesianChart1.ChartTheme = null;
        cartesianChart1.Dock = DockStyle.Bottom;
        skDefaultLegend2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultLegend2.Content = null;
        skDefaultLegend2.IsValid = false;
        skDefaultLegend2.Opacity = 1F;
        padding3.Bottom = 0F;
        padding3.Left = 0F;
        padding3.Right = 0F;
        padding3.Top = 0F;
        skDefaultLegend2.Padding = padding3;
        skDefaultLegend2.RemoveOnCompleted = false;
        skDefaultLegend2.RotateTransform = 0F;
        skDefaultLegend2.X = 0F;
        skDefaultLegend2.Y = 0F;
        cartesianChart1.Legend = skDefaultLegend2;
        cartesianChart1.Location = new Point(16, 52);
        cartesianChart1.MatchAxesScreenDataRatio = false;
        cartesianChart1.Name = "cartesianChart1";
        cartesianChart1.Size = new Size(507, 258);
        cartesianChart1.TabIndex = 1;
        skDefaultTooltip2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultTooltip2.Content = null;
        skDefaultTooltip2.IsValid = false;
        skDefaultTooltip2.Opacity = 1F;
        padding4.Bottom = 0F;
        padding4.Left = 0F;
        padding4.Right = 0F;
        padding4.Top = 0F;
        skDefaultTooltip2.Padding = padding4;
        skDefaultTooltip2.RemoveOnCompleted = false;
        skDefaultTooltip2.RotateTransform = 0F;
        skDefaultTooltip2.Wedge = 10;
        skDefaultTooltip2.X = 0F;
        skDefaultTooltip2.Y = 0F;
        cartesianChart1.Tooltip = skDefaultTooltip2;
        cartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
        cartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
        //
        // kLabel4
        //
        kLabel4.AutoSize = false;
        kLabel4.BackColor = Color.Transparent;
        kLabel4.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel4.Location = new Point(16, 14);
        kLabel4.Font = new Font("Inter", 9F);
        kLabel4.TabStop = false;
        kLabel4.Name = "kLabel4";
        kLabel4.Size = new Size(507, 26);
        kLabel4.TabIndex = 0;
        kLabel4.Text = "Faltas y tardanzas";
        kLabel4.TextAlign = ContentAlignment.MiddleLeft;
        kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // flowLayoutPanel1
        //
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        flowLayoutPanel1.Controls.Add(kPanel3);
        flowLayoutPanel1.Controls.Add(kPanel2);
        flowLayoutPanel1.Controls.Add(kPanel1);
        flowLayoutPanel1.Controls.Add(kPanel4);
        flowLayoutPanel1.Controls.Add(kPanel5);
        flowLayoutPanel1.Location = new Point(16, 150);
        flowLayoutPanel1.WrapContents = true;
        flowLayoutPanel1.Padding = new Padding(0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(1094, 484);
        flowLayoutPanel1.TabIndex = 5;
        //
        // kPanel3
        //
        kPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        kPanel3.BackColor = Color.Transparent;
        kPanel3.Controls.Add(lblEmpleadosActivos);
        kPanel3.Controls.Add(kLabel5);
        kPanel3.Location = new Point(0, 0);
        kPanel3.Margin = new Padding(0, 0, 16, 16);
        kPanel3.FillColor = Color.White;
        kPanel3.BorderColor = Color.FromArgb(218, 218, 218);
        kPanel3.GradientColor = Color.Empty;
        kPanel3.CornerRadius = 8;
        kPanel3.Name = "kPanel3";
        kPanel3.Padding = new Padding(12);
        kPanel3.Shadow.Blur = 5;
        kPanel3.Shadow.Enabled = false;
        kPanel3.Shadow.Offset = new Point(0, 1);
        kPanel3.Shadow.Opacity = 10;
        kPanel3.Size = new Size(354, 132);
        kPanel3.TabIndex = 0;
        //
        // lblEmpleadosActivos
        //
        lblEmpleadosActivos.AutoSize = false;
        lblEmpleadosActivos.BackColor = Color.Transparent;
        lblEmpleadosActivos.Dock = DockStyle.Top;
        lblEmpleadosActivos.Location = new Point(16, 44);
        lblEmpleadosActivos.Font = new Font("Inter", 28F, FontStyle.Bold);
        lblEmpleadosActivos.ForeColor = Color.FromArgb(32, 38, 45);
        lblEmpleadosActivos.TabStop = false;
        lblEmpleadosActivos.Name = "lblEmpleadosActivos";
        lblEmpleadosActivos.Size = new Size(322, 64);
        lblEmpleadosActivos.TabIndex = 1;
        lblEmpleadosActivos.Text = "000";
        lblEmpleadosActivos.TextAlign = ContentAlignment.MiddleLeft;
        lblEmpleadosActivos.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // kLabel5
        //
        kLabel5.AutoSize = false;
        kLabel5.BackColor = Color.Transparent;
        kLabel5.Dock = DockStyle.Top;
        kLabel5.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel5.Location = new Point(16, 14);
        kLabel5.Font = new Font("Inter", 9F);
        kLabel5.TabStop = false;
        kLabel5.Name = "kLabel5";
        kLabel5.Size = new Size(322, 24);
        kLabel5.TabIndex = 0;
        kLabel5.Text = "Empleados activos";
        kLabel5.TextAlign = ContentAlignment.MiddleLeft;
        kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // kPanel2
        //
        kPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        kPanel2.BackColor = Color.Transparent;
        kPanel2.Controls.Add(lblFaltasMes);
        kPanel2.Controls.Add(kLabel6);
        kPanel2.Location = new Point(370, 0);
        kPanel2.Margin = new Padding(0, 0, 16, 16);
        kPanel2.FillColor = Color.White;
        kPanel2.BorderColor = Color.FromArgb(218, 218, 218);
        kPanel2.GradientColor = Color.Empty;
        kPanel2.CornerRadius = 8;
        kPanel2.Name = "kPanel2";
        kPanel2.Padding = new Padding(12);
        kPanel2.Shadow.Blur = 5;
        kPanel2.Shadow.Enabled = false;
        kPanel2.Shadow.Offset = new Point(0, 1);
        kPanel2.Shadow.Opacity = 10;
        kPanel2.Size = new Size(354, 132);
        kPanel2.TabIndex = 1;
        //
        // lblFaltasMes
        //
        lblFaltasMes.AutoSize = false;
        lblFaltasMes.BackColor = Color.Transparent;
        lblFaltasMes.Dock = DockStyle.Top;
        lblFaltasMes.Location = new Point(16, 44);
        lblFaltasMes.Font = new Font("Inter", 28F, FontStyle.Bold);
        lblFaltasMes.ForeColor = Color.FromArgb(32, 38, 45);
        lblFaltasMes.TabStop = false;
        lblFaltasMes.Name = "lblFaltasMes";
        lblFaltasMes.Size = new Size(322, 64);
        lblFaltasMes.TabIndex = 1;
        lblFaltasMes.Text = "000";
        lblFaltasMes.TextAlign = ContentAlignment.MiddleLeft;
        lblFaltasMes.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // kLabel6
        //
        kLabel6.AutoSize = false;
        kLabel6.BackColor = Color.Transparent;
        kLabel6.Dock = DockStyle.Top;
        kLabel6.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel6.Location = new Point(16, 14);
        kLabel6.Font = new Font("Inter", 9F);
        kLabel6.TabStop = false;
        kLabel6.Name = "kLabel6";
        kLabel6.Size = new Size(322, 24);
        kLabel6.TabIndex = 0;
        kLabel6.Text = "Faltas del mes";
        kLabel6.TextAlign = ContentAlignment.MiddleLeft;
        kLabel6.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // kPanel1
        //
        kPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        kPanel1.BackColor = Color.Transparent;
        kPanel1.Controls.Add(lblTardanzasMes);
        kPanel1.Controls.Add(kLabel8);
        kPanel1.Location = new Point(740, 0);
        kPanel1.Margin = new Padding(0, 0, 0, 16);
        kPanel1.FillColor = Color.White;
        kPanel1.BorderColor = Color.FromArgb(218, 218, 218);
        kPanel1.GradientColor = Color.Empty;
        kPanel1.CornerRadius = 8;
        kPanel1.Name = "kPanel1";
        kPanel1.Padding = new Padding(12);
        kPanel1.Shadow.Blur = 5;
        kPanel1.Shadow.Enabled = false;
        kPanel1.Shadow.Offset = new Point(0, 1);
        kPanel1.Shadow.Opacity = 10;
        kPanel1.Size = new Size(354, 132);
        kPanel1.TabIndex = 2;
        //
        // lblTardanzasMes
        //
        lblTardanzasMes.AutoSize = false;
        lblTardanzasMes.BackColor = Color.Transparent;
        lblTardanzasMes.Dock = DockStyle.Top;
        lblTardanzasMes.Location = new Point(16, 44);
        lblTardanzasMes.Font = new Font("Inter", 28F, FontStyle.Bold);
        lblTardanzasMes.ForeColor = Color.FromArgb(32, 38, 45);
        lblTardanzasMes.TabStop = false;
        lblTardanzasMes.Name = "lblTardanzasMes";
        lblTardanzasMes.Size = new Size(322, 64);
        lblTardanzasMes.TabIndex = 1;
        lblTardanzasMes.Text = "000";
        lblTardanzasMes.TextAlign = ContentAlignment.MiddleLeft;
        lblTardanzasMes.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // kLabel8
        //
        kLabel8.AutoSize = false;
        kLabel8.BackColor = Color.Transparent;
        kLabel8.Dock = DockStyle.Top;
        kLabel8.ForeColor = Color.FromArgb(64, 64, 64);
        kLabel8.Location = new Point(16, 14);
        kLabel8.Font = new Font("Inter", 9F);
        kLabel8.TabStop = false;
        kLabel8.Name = "kLabel8";
        kLabel8.Size = new Size(322, 24);
        kLabel8.TabIndex = 0;
        kLabel8.Text = "Llegadas tarde";
        kLabel8.TextAlign = ContentAlignment.MiddleLeft;
        kLabel8.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // dtpPeriodo
        //
        dtpPeriodo.Checked = false;
        dtpPeriodo.CustomFormat = "dd/MM/yyyy";
        dtpPeriodo.Font = new Font("Inter", 10F);
        dtpPeriodo.Format = DateTimePickerFormat.Custom;
        dtpPeriodo.Location = new Point(16, 96);
        dtpPeriodo.MinimumSize = new Size(0, 34);
        dtpPeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        dtpPeriodo.CalendarFont = new Font("Inter", 9F);
        dtpPeriodo.Name = "dtpPeriodo";
        dtpPeriodo.ShowCheckBox = true;
        dtpPeriodo.Size = new Size(354, 34);
        dtpPeriodo.TabIndex = 3;
        //
        // btnConsultar
        //
        btnConsultar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnConsultar.BackColor = Color.Transparent;
        btnConsultar.CornerRadius = 8;
        btnConsultar.FlatStyle = FlatStyle.Flat;
        btnConsultar.Location = new Point(16, 688);
        btnConsultar.BorderThickness = 1;
        btnConsultar.Font = new Font("Inter", 9F);
        btnConsultar.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnConsultar.FillColor = Color.FromArgb(49, 81, 107);
        btnConsultar.ForeColor = Color.White;
        btnConsultar.BorderColor = Color.FromArgb(49, 81, 107);
        btnConsultar.GradientColor = Color.Empty;
        btnConsultar.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnConsultar.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnConsultar.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Padding = new Padding(10, 4, 10, 4);
        btnConsultar.Size = new Size(264, 40);
        btnConsultar.TabIndex = 6;
        btnConsultar.Text = "Consultar";
        btnConsultar.UseVisualStyleBackColor = false;
        //
        // btnVerEmpleados
        //
        btnVerEmpleados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnVerEmpleados.BackColor = Color.Transparent;
        btnVerEmpleados.CornerRadius = 8;
        btnVerEmpleados.FlatStyle = FlatStyle.Flat;
        btnVerEmpleados.Location = new Point(292, 688);
        btnVerEmpleados.BorderThickness = 1;
        btnVerEmpleados.Font = new Font("Inter", 9F);
        btnVerEmpleados.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnVerEmpleados.FillColor = Color.White;
        btnVerEmpleados.ForeColor = Color.FromArgb(32, 38, 45);
        btnVerEmpleados.BorderColor = Color.FromArgb(218, 218, 218);
        btnVerEmpleados.GradientColor = Color.Empty;
        btnVerEmpleados.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnVerEmpleados.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnVerEmpleados.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnVerEmpleados.Name = "btnVerEmpleados";
        btnVerEmpleados.Padding = new Padding(10, 4, 10, 4);
        btnVerEmpleados.Size = new Size(264, 40);
        btnVerEmpleados.TabIndex = 7;
        btnVerEmpleados.Text = "Ver empleados";
        btnVerEmpleados.UseVisualStyleBackColor = false;
        //
        // btnVerAsistencias
        //
        btnVerAsistencias.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnVerAsistencias.BackColor = Color.Transparent;
        btnVerAsistencias.CornerRadius = 8;
        btnVerAsistencias.FlatStyle = FlatStyle.Flat;
        btnVerAsistencias.Location = new Point(568, 688);
        btnVerAsistencias.BorderThickness = 1;
        btnVerAsistencias.Font = new Font("Inter", 9F);
        btnVerAsistencias.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnVerAsistencias.FillColor = Color.White;
        btnVerAsistencias.ForeColor = Color.FromArgb(32, 38, 45);
        btnVerAsistencias.BorderColor = Color.FromArgb(218, 218, 218);
        btnVerAsistencias.GradientColor = Color.Empty;
        btnVerAsistencias.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnVerAsistencias.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnVerAsistencias.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnVerAsistencias.Name = "btnVerAsistencias";
        btnVerAsistencias.Padding = new Padding(10, 4, 10, 4);
        btnVerAsistencias.Size = new Size(264, 40);
        btnVerAsistencias.TabIndex = 8;
        btnVerAsistencias.Text = "Ver asistencias";
        btnVerAsistencias.UseVisualStyleBackColor = false;
        //
        // btnVerNomina
        //
        btnVerNomina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnVerNomina.BackColor = Color.Transparent;
        btnVerNomina.CornerRadius = 8;
        btnVerNomina.FlatStyle = FlatStyle.Flat;
        btnVerNomina.Location = new Point(844, 688);
        btnVerNomina.BorderThickness = 1;
        btnVerNomina.Font = new Font("Inter", 9F);
        btnVerNomina.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnVerNomina.FillColor = Color.White;
        btnVerNomina.ForeColor = Color.FromArgb(32, 38, 45);
        btnVerNomina.BorderColor = Color.FromArgb(218, 218, 218);
        btnVerNomina.GradientColor = Color.Empty;
        btnVerNomina.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnVerNomina.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnVerNomina.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnVerNomina.Name = "btnVerNomina";
        btnVerNomina.Padding = new Padding(10, 4, 10, 4);
        btnVerNomina.Size = new Size(264, 40);
        btnVerNomina.TabIndex = 9;
        btnVerNomina.Text = "Ver nómina";
        btnVerNomina.UseVisualStyleBackColor = false;
        //
        // FrmInicio
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1126, 744);
        Controls.Add(btnConsultar);
        Controls.Add(btnVerEmpleados);
        Controls.Add(btnVerAsistencias);
        Controls.Add(btnVerNomina);
        Controls.Add(dtpPeriodo);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(kLabel2);
        Controls.Add(cboDepartamento);
        Controls.Add(kLabel1);
        Controls.Add(kLabel7);
        MinimumSize = new Size(1126, 744);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3);
        Font = new Font("Segoe UI", 9F);
        Name = "FrmInicio";
        Text = "Inicio";
        Load += FrmInicio_Load;
        kPanel4.ResumeLayout(false);
        kPanel5.ResumeLayout(false);
        flowLayoutPanel1.ResumeLayout(false);
        kPanel3.ResumeLayout(false);
        kPanel2.ResumeLayout(false);
        kPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel kLabel7;
    private KovaqsUI.Controls.KLabel kLabel1;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KLabel kLabel2;
    private KovaqsUI.Controls.KPanel kPanel4;
    private KovaqsUI.Controls.KPanel kPanel5;
    private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    private KovaqsUI.Controls.KLabel kLabel3;
    private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    private KovaqsUI.Controls.KLabel kLabel4;
    private FlowLayoutPanel flowLayoutPanel1;
    private KovaqsUI.Controls.KPanel kPanel3;
    private KovaqsUI.Controls.KPanel kPanel2;
    private KovaqsUI.Controls.KPanel kPanel1;
    private KovaqsUI.Controls.KLabel kLabel5;
    private KovaqsUI.Controls.KLabel lblEmpleadosActivos;
    private KovaqsUI.Controls.KLabel lblFaltasMes;
    private KovaqsUI.Controls.KLabel kLabel6;
    private KovaqsUI.Controls.KLabel lblTardanzasMes;
    private KovaqsUI.Controls.KLabel kLabel8;
    private DateTimePicker dtpPeriodo;
    private KovaqsUI.Controls.KButton btnConsultar;
    private KovaqsUI.Controls.KButton btnVerEmpleados;
    private KovaqsUI.Controls.KButton btnVerAsistencias;
    private KovaqsUI.Controls.KButton btnVerNomina;
    private KovaqsUI.Components.KToastNotifier notificador;
}
