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
        ayudaIndicadores = new ToolTip(components);
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
        lblTitulo = new KovaqsUI.Controls.KLabel();
        lblPeriodo = new KovaqsUI.Controls.KLabel();
        cboDepartamento = new KovaqsUI.Controls.KComboBox();
        lblDepartamento = new KovaqsUI.Controls.KLabel();
        panelSalarios = new KovaqsUI.Controls.KPanel();
        lblTituloSalarios = new KovaqsUI.Controls.KLabel();
        graficoMasaSalarial = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
        panelIncidencias = new KovaqsUI.Controls.KPanel();
        graficoIncidencias = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
        lblTituloIncidencias = new KovaqsUI.Controls.KLabel();
        panelIndicadores = new FlowLayoutPanel();
        panelEmpleados = new KovaqsUI.Controls.KPanel();
        lblEmpleadosActivos = new KovaqsUI.Controls.KLabel();
        lblTituloEmpleados = new KovaqsUI.Controls.KLabel();
        panelFaltas = new KovaqsUI.Controls.KPanel();
        lblFaltasMes = new KovaqsUI.Controls.KLabel();
        lblTituloFaltas = new KovaqsUI.Controls.KLabel();
        panelTardanzas = new KovaqsUI.Controls.KPanel();
        lblTardanzasMes = new KovaqsUI.Controls.KLabel();
        lblTituloTardanzas = new KovaqsUI.Controls.KLabel();
        dtpPeriodo = new DateTimePicker();
        btnConsultar = new KovaqsUI.Controls.KButton();
        btnVerEmpleados = new KovaqsUI.Controls.KButton();
        btnVerAsistencias = new KovaqsUI.Controls.KButton();
        btnVerNomina = new KovaqsUI.Controls.KButton();
        panelSalarios.SuspendLayout();
        panelIncidencias.SuspendLayout();
        panelIndicadores.SuspendLayout();
        panelEmpleados.SuspendLayout();
        panelFaltas.SuspendLayout();
        panelTardanzas.SuspendLayout();
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Dock = DockStyle.None;
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.TabStop = false;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1094, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Inicio";
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        //
        // lblPeriodo
        //
        lblPeriodo.AutoSize = false;
        lblPeriodo.BackColor = Color.Transparent;
        lblPeriodo.Location = new Point(16, 70);
        lblPeriodo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblPeriodo.Font = new Font("Inter", 9F);
        lblPeriodo.ForeColor = Color.FromArgb(64, 64, 64);
        lblPeriodo.TabStop = false;
        lblPeriodo.Name = "lblPeriodo";
        lblPeriodo.Size = new Size(354, 24);
        lblPeriodo.TabIndex = 1;
        lblPeriodo.Text = "Mes de consulta";
        lblPeriodo.TextAlign = ContentAlignment.MiddleLeft;
        lblPeriodo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
        // lblDepartamento
        //
        lblDepartamento.AutoSize = false;
        lblDepartamento.BackColor = Color.Transparent;
        lblDepartamento.Location = new Point(386, 70);
        lblDepartamento.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        lblDepartamento.Font = new Font("Inter", 9F);
        lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
        lblDepartamento.TabStop = false;
        lblDepartamento.Name = "lblDepartamento";
        lblDepartamento.Size = new Size(354, 24);
        lblDepartamento.TabIndex = 2;
        lblDepartamento.Text = "Departamento";
        lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
        lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // panelSalarios
        //
        panelSalarios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        panelSalarios.BackColor = Color.Transparent;
        panelSalarios.Controls.Add(lblTituloSalarios);
        panelSalarios.Controls.Add(graficoMasaSalarial);
        panelSalarios.Location = new Point(0, 148);
        panelSalarios.Margin = new Padding(0, 0, 16, 0);
        panelSalarios.FillColor = Color.White;
        panelSalarios.BorderColor = Color.FromArgb(218, 218, 218);
        panelSalarios.GradientColor = Color.Empty;
        panelSalarios.CornerRadius = 8;
        panelSalarios.Name = "panelSalarios";
        panelSalarios.Padding = new Padding(12);
        panelSalarios.Shadow.Blur = 5;
        panelSalarios.Shadow.Enabled = false;
        panelSalarios.Shadow.Offset = new Point(0, 1);
        panelSalarios.Shadow.Opacity = 10;
        panelSalarios.Size = new Size(539, 326);
        panelSalarios.TabIndex = 3;
        //
        // lblTituloSalarios
        //
        lblTituloSalarios.AutoSize = false;
        lblTituloSalarios.BackColor = Color.Transparent;
        lblTituloSalarios.ForeColor = Color.FromArgb(64, 64, 64);
        lblTituloSalarios.Location = new Point(16, 14);
        lblTituloSalarios.Font = new Font("Inter", 9F);
        lblTituloSalarios.TabStop = false;
        lblTituloSalarios.Name = "lblTituloSalarios";
        lblTituloSalarios.Size = new Size(507, 26);
        lblTituloSalarios.TabIndex = 0;
        lblTituloSalarios.Text = "Masa salarial por departamento";
        lblTituloSalarios.TextAlign = ContentAlignment.MiddleLeft;
        lblTituloSalarios.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // graficoMasaSalarial
        //
        graficoMasaSalarial.AutoUpdateEnabled = true;
        graficoMasaSalarial.BackColor = Color.White;
        graficoMasaSalarial.ChartTheme = null;
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
        graficoMasaSalarial.Legend = skDefaultLegend1;
        graficoMasaSalarial.Location = new Point(16, 52);
        graficoMasaSalarial.Name = "graficoMasaSalarial";
        graficoMasaSalarial.Size = new Size(507, 258);
        graficoMasaSalarial.TabIndex = 1;
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
        graficoMasaSalarial.Tooltip = skDefaultTooltip1;
        graficoMasaSalarial.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
        //
        // panelIncidencias
        //
        panelIncidencias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        panelIncidencias.BackColor = Color.Transparent;
        panelIncidencias.Controls.Add(graficoIncidencias);
        panelIncidencias.Controls.Add(lblTituloIncidencias);
        panelIncidencias.Location = new Point(555, 148);
        panelIncidencias.Margin = new Padding(0);
        panelIncidencias.FillColor = Color.White;
        panelIncidencias.BorderColor = Color.FromArgb(218, 218, 218);
        panelIncidencias.GradientColor = Color.Empty;
        panelIncidencias.CornerRadius = 8;
        panelIncidencias.Name = "panelIncidencias";
        panelIncidencias.Padding = new Padding(12);
        panelIncidencias.Shadow.Blur = 5;
        panelIncidencias.Shadow.Enabled = false;
        panelIncidencias.Shadow.Offset = new Point(0, 1);
        panelIncidencias.Shadow.Opacity = 10;
        panelIncidencias.Size = new Size(539, 326);
        panelIncidencias.TabIndex = 4;
        //
        // graficoIncidencias
        //
        graficoIncidencias.AutoUpdateEnabled = true;
        graficoIncidencias.BackColor = Color.White;
        graficoIncidencias.ChartTheme = null;
        graficoIncidencias.Dock = DockStyle.Bottom;
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
        graficoIncidencias.Legend = skDefaultLegend2;
        graficoIncidencias.Location = new Point(16, 52);
        graficoIncidencias.MatchAxesScreenDataRatio = false;
        graficoIncidencias.Name = "graficoIncidencias";
        ayudaIndicadores.SetToolTip(graficoIncidencias, "Faltas o tardanzas / jornadas laborables registradas y resueltas × 100. Se excluyen días no laborables y jornadas pendientes.");
        graficoIncidencias.Size = new Size(507, 258);
        graficoIncidencias.TabIndex = 1;
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
        graficoIncidencias.Tooltip = skDefaultTooltip2;
        graficoIncidencias.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
        graficoIncidencias.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
        //
        // lblTituloIncidencias
        //
        lblTituloIncidencias.AutoSize = false;
        lblTituloIncidencias.BackColor = Color.Transparent;
        lblTituloIncidencias.ForeColor = Color.FromArgb(64, 64, 64);
        lblTituloIncidencias.Location = new Point(16, 14);
        lblTituloIncidencias.Font = new Font("Inter", 9F);
        lblTituloIncidencias.TabStop = false;
        lblTituloIncidencias.Name = "lblTituloIncidencias";
        lblTituloIncidencias.Size = new Size(507, 26);
        lblTituloIncidencias.TabIndex = 0;
        lblTituloIncidencias.Text = "Ausentismo y tardanzas (%)";
        lblTituloIncidencias.TextAlign = ContentAlignment.MiddleLeft;
        lblTituloIncidencias.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // panelIndicadores
        //
        panelIndicadores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        panelIndicadores.Controls.Add(panelEmpleados);
        panelIndicadores.Controls.Add(panelFaltas);
        panelIndicadores.Controls.Add(panelTardanzas);
        panelIndicadores.Controls.Add(panelSalarios);
        panelIndicadores.Controls.Add(panelIncidencias);
        panelIndicadores.Location = new Point(16, 150);
        panelIndicadores.WrapContents = true;
        panelIndicadores.Padding = new Padding(0);
        panelIndicadores.Name = "panelIndicadores";
        panelIndicadores.Size = new Size(1094, 484);
        panelIndicadores.TabIndex = 5;
        //
        // panelEmpleados
        //
        panelEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelEmpleados.BackColor = Color.Transparent;
        panelEmpleados.Controls.Add(lblEmpleadosActivos);
        panelEmpleados.Controls.Add(lblTituloEmpleados);
        panelEmpleados.Location = new Point(0, 0);
        panelEmpleados.Margin = new Padding(0, 0, 16, 16);
        panelEmpleados.FillColor = Color.White;
        panelEmpleados.BorderColor = Color.FromArgb(218, 218, 218);
        panelEmpleados.GradientColor = Color.Empty;
        panelEmpleados.CornerRadius = 8;
        panelEmpleados.Name = "panelEmpleados";
        panelEmpleados.Padding = new Padding(12);
        panelEmpleados.Shadow.Blur = 5;
        panelEmpleados.Shadow.Enabled = false;
        panelEmpleados.Shadow.Offset = new Point(0, 1);
        panelEmpleados.Shadow.Opacity = 10;
        panelEmpleados.Size = new Size(354, 132);
        panelEmpleados.TabIndex = 0;
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
        // lblTituloEmpleados
        //
        lblTituloEmpleados.AutoSize = false;
        lblTituloEmpleados.BackColor = Color.Transparent;
        lblTituloEmpleados.Dock = DockStyle.Top;
        lblTituloEmpleados.ForeColor = Color.FromArgb(64, 64, 64);
        lblTituloEmpleados.Location = new Point(16, 14);
        lblTituloEmpleados.Font = new Font("Inter", 9F);
        lblTituloEmpleados.TabStop = false;
        lblTituloEmpleados.Name = "lblTituloEmpleados";
        lblTituloEmpleados.Size = new Size(322, 24);
        lblTituloEmpleados.TabIndex = 0;
        lblTituloEmpleados.Text = "Empleados activos";
        lblTituloEmpleados.TextAlign = ContentAlignment.MiddleLeft;
        lblTituloEmpleados.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // panelFaltas
        //
        panelFaltas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelFaltas.BackColor = Color.Transparent;
        panelFaltas.Controls.Add(lblFaltasMes);
        panelFaltas.Controls.Add(lblTituloFaltas);
        panelFaltas.Location = new Point(370, 0);
        panelFaltas.Margin = new Padding(0, 0, 16, 16);
        panelFaltas.FillColor = Color.White;
        panelFaltas.BorderColor = Color.FromArgb(218, 218, 218);
        panelFaltas.GradientColor = Color.Empty;
        panelFaltas.CornerRadius = 8;
        panelFaltas.Name = "panelFaltas";
        panelFaltas.Padding = new Padding(12);
        panelFaltas.Shadow.Blur = 5;
        panelFaltas.Shadow.Enabled = false;
        panelFaltas.Shadow.Offset = new Point(0, 1);
        panelFaltas.Shadow.Opacity = 10;
        panelFaltas.Size = new Size(354, 132);
        panelFaltas.TabIndex = 1;
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
        // lblTituloFaltas
        //
        lblTituloFaltas.AutoSize = false;
        lblTituloFaltas.BackColor = Color.Transparent;
        lblTituloFaltas.Dock = DockStyle.Top;
        lblTituloFaltas.ForeColor = Color.FromArgb(64, 64, 64);
        lblTituloFaltas.Location = new Point(16, 14);
        lblTituloFaltas.Font = new Font("Inter", 9F);
        lblTituloFaltas.TabStop = false;
        lblTituloFaltas.Name = "lblTituloFaltas";
        lblTituloFaltas.Size = new Size(322, 24);
        lblTituloFaltas.TabIndex = 0;
        lblTituloFaltas.Text = "Faltas del mes";
        lblTituloFaltas.TextAlign = ContentAlignment.MiddleLeft;
        lblTituloFaltas.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        //
        // panelTardanzas
        //
        panelTardanzas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelTardanzas.BackColor = Color.Transparent;
        panelTardanzas.Controls.Add(lblTardanzasMes);
        panelTardanzas.Controls.Add(lblTituloTardanzas);
        panelTardanzas.Location = new Point(740, 0);
        panelTardanzas.Margin = new Padding(0, 0, 0, 16);
        panelTardanzas.FillColor = Color.White;
        panelTardanzas.BorderColor = Color.FromArgb(218, 218, 218);
        panelTardanzas.GradientColor = Color.Empty;
        panelTardanzas.CornerRadius = 8;
        panelTardanzas.Name = "panelTardanzas";
        panelTardanzas.Padding = new Padding(12);
        panelTardanzas.Shadow.Blur = 5;
        panelTardanzas.Shadow.Enabled = false;
        panelTardanzas.Shadow.Offset = new Point(0, 1);
        panelTardanzas.Shadow.Opacity = 10;
        panelTardanzas.Size = new Size(354, 132);
        panelTardanzas.TabIndex = 2;
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
        // lblTituloTardanzas
        //
        lblTituloTardanzas.AutoSize = false;
        lblTituloTardanzas.BackColor = Color.Transparent;
        lblTituloTardanzas.Dock = DockStyle.Top;
        lblTituloTardanzas.ForeColor = Color.FromArgb(64, 64, 64);
        lblTituloTardanzas.Location = new Point(16, 14);
        lblTituloTardanzas.Font = new Font("Inter", 9F);
        lblTituloTardanzas.TabStop = false;
        lblTituloTardanzas.Name = "lblTituloTardanzas";
        lblTituloTardanzas.Size = new Size(322, 24);
        lblTituloTardanzas.TabIndex = 0;
        lblTituloTardanzas.Text = "Llegadas tarde";
        lblTituloTardanzas.TextAlign = ContentAlignment.MiddleLeft;
        lblTituloTardanzas.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
        Controls.Add(panelIndicadores);
        Controls.Add(lblDepartamento);
        Controls.Add(cboDepartamento);
        Controls.Add(lblPeriodo);
        Controls.Add(lblTitulo);
        MinimumSize = new Size(1126, 744);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3);
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmInicio";
        Text = "Inicio";
        Load += FrmInicio_Load;
        panelSalarios.ResumeLayout(false);
        panelIncidencias.ResumeLayout(false);
        panelIndicadores.ResumeLayout(false);
        panelEmpleados.ResumeLayout(false);
        panelFaltas.ResumeLayout(false);
        panelTardanzas.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KLabel lblPeriodo;
    private KovaqsUI.Controls.KComboBox cboDepartamento;
    private KovaqsUI.Controls.KLabel lblDepartamento;
    private KovaqsUI.Controls.KPanel panelSalarios;
    private KovaqsUI.Controls.KPanel panelIncidencias;
    private LiveChartsCore.SkiaSharpView.WinForms.PieChart graficoMasaSalarial;
    private KovaqsUI.Controls.KLabel lblTituloSalarios;
    private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart graficoIncidencias;
    private KovaqsUI.Controls.KLabel lblTituloIncidencias;
    private FlowLayoutPanel panelIndicadores;
    private KovaqsUI.Controls.KPanel panelEmpleados;
    private KovaqsUI.Controls.KPanel panelFaltas;
    private KovaqsUI.Controls.KPanel panelTardanzas;
    private KovaqsUI.Controls.KLabel lblTituloEmpleados;
    private KovaqsUI.Controls.KLabel lblEmpleadosActivos;
    private KovaqsUI.Controls.KLabel lblFaltasMes;
    private KovaqsUI.Controls.KLabel lblTituloFaltas;
    private KovaqsUI.Controls.KLabel lblTardanzasMes;
    private KovaqsUI.Controls.KLabel lblTituloTardanzas;
    private DateTimePicker dtpPeriodo;
    private KovaqsUI.Controls.KButton btnConsultar;
    private KovaqsUI.Controls.KButton btnVerEmpleados;
    private KovaqsUI.Controls.KButton btnVerAsistencias;
    private KovaqsUI.Controls.KButton btnVerNomina;
    private KovaqsUI.Components.KToastNotifier notificador;
    private ToolTip ayudaIndicadores;
}
