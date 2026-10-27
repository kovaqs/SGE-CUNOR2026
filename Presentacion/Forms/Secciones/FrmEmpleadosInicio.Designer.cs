namespace Presentacion.Forms.Secciones;

partial class FrmEmpleados
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
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend3 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
        LiveChartsCore.Drawing.Padding padding5 = new LiveChartsCore.Drawing.Padding();
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip3 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
        LiveChartsCore.Drawing.Padding padding6 = new LiveChartsCore.Drawing.Padding();
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend4 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
        LiveChartsCore.Drawing.Padding padding7 = new LiveChartsCore.Drawing.Padding();
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip4 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
        LiveChartsCore.Drawing.Padding padding8 = new LiveChartsCore.Drawing.Padding();
        kLabel7 = new KovaqsUI.Controls.KLabel();
        dtpPeriodo = new DateTimePicker();
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
        kLabel7.Location = new Point(12, 9);
        kLabel7.Name = "kLabel7";
        kLabel7.Size = new Size(937, 46);
        kLabel7.TabIndex = 17;
        kLabel7.Text = "Empleados";
        kLabel7.TextRole = KovaqsUI.Controls.KTextRole.Title;
        // 
        // dtpPeriodo
        // 
        dtpPeriodo.CalendarFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dtpPeriodo.Location = new Point(21, 87);
        dtpPeriodo.Name = "dtpPeriodo";
        dtpPeriodo.Size = new Size(300, 23);
        dtpPeriodo.TabIndex = 18;
        // 
        // kLabel1
        // 
        kLabel1.AutoSize = false;
        kLabel1.BackColor = Color.Transparent;
        kLabel1.Location = new Point(21, 55);
        kLabel1.Name = "kLabel1";
        kLabel1.Size = new Size(245, 23);
        kLabel1.TabIndex = 19;
        kLabel1.Text = "Mes de consulta";
        kLabel1.TextAlign = ContentAlignment.MiddleLeft;
        kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // cboDepartamento
        // 
        cboDepartamento.FormattingEnabled = true;
        cboDepartamento.ItemHeight = 28;
        cboDepartamento.Location = new Point(355, 81);
        cboDepartamento.Name = "cboDepartamento";
        cboDepartamento.Size = new Size(300, 34);
        cboDepartamento.TabIndex = 20;
        // 
        // kLabel2
        // 
        kLabel2.AutoSize = false;
        kLabel2.BackColor = Color.Transparent;
        kLabel2.Location = new Point(355, 55);
        kLabel2.Name = "kLabel2";
        kLabel2.Size = new Size(245, 23);
        kLabel2.TabIndex = 21;
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
        kPanel4.Location = new Point(3, 149);
        kPanel4.Name = "kPanel4";
        kPanel4.Padding = new Padding(12);
        kPanel4.Shadow.Blur = 5;
        kPanel4.Shadow.Enabled = true;
        kPanel4.Shadow.Offset = new Point(0, 1);
        kPanel4.Shadow.Opacity = 10;
        kPanel4.Size = new Size(455, 300);
        kPanel4.TabIndex = 23;
        // 
        // kLabel3
        // 
        kLabel3.AutoSize = false;
        kLabel3.BackColor = Color.Transparent;
        kLabel3.ForeColor = Color.DimGray;
        kLabel3.Location = new Point(21, 18);
        kLabel3.Name = "kLabel3";
        kLabel3.Size = new Size(401, 23);
        kLabel3.TabIndex = 25;
        kLabel3.Text = "Masa Salarial";
        kLabel3.TextAlign = ContentAlignment.MiddleLeft;
        kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // pieChart1
        // 
        pieChart1.AutoUpdateEnabled = true;
        pieChart1.BackColor = Color.White;
        pieChart1.ChartTheme = null;
        skDefaultLegend3.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultLegend3.Content = null;
        skDefaultLegend3.IsValid = false;
        skDefaultLegend3.Opacity = 1F;
        padding5.Bottom = 0F;
        padding5.Left = 0F;
        padding5.Right = 0F;
        padding5.Top = 0F;
        skDefaultLegend3.Padding = padding5;
        skDefaultLegend3.RemoveOnCompleted = false;
        skDefaultLegend3.RotateTransform = 0F;
        skDefaultLegend3.X = 0F;
        skDefaultLegend3.Y = 0F;
        pieChart1.Legend = skDefaultLegend3;
        pieChart1.Location = new Point(108, 59);
        pieChart1.Name = "pieChart1";
        pieChart1.Size = new Size(220, 220);
        pieChart1.TabIndex = 0;
        skDefaultTooltip3.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultTooltip3.Content = null;
        skDefaultTooltip3.IsValid = false;
        skDefaultTooltip3.Opacity = 1F;
        padding6.Bottom = 0F;
        padding6.Left = 0F;
        padding6.Right = 0F;
        padding6.Top = 0F;
        skDefaultTooltip3.Padding = padding6;
        skDefaultTooltip3.RemoveOnCompleted = false;
        skDefaultTooltip3.RotateTransform = 0F;
        skDefaultTooltip3.Wedge = 10;
        skDefaultTooltip3.X = 0F;
        skDefaultTooltip3.Y = 0F;
        pieChart1.Tooltip = skDefaultTooltip3;
        pieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
        // 
        // kPanel5
        // 
        kPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        kPanel5.BackColor = Color.Transparent;
        kPanel5.Controls.Add(cartesianChart1);
        kPanel5.Controls.Add(kLabel4);
        kPanel5.Location = new Point(464, 149);
        kPanel5.Name = "kPanel5";
        kPanel5.Padding = new Padding(12);
        kPanel5.Shadow.Blur = 5;
        kPanel5.Shadow.Enabled = true;
        kPanel5.Shadow.Offset = new Point(0, 1);
        kPanel5.Shadow.Opacity = 10;
        kPanel5.Size = new Size(455, 300);
        kPanel5.TabIndex = 24;
        // 
        // cartesianChart1
        // 
        cartesianChart1.AutoUpdateEnabled = true;
        cartesianChart1.BackColor = Color.White;
        cartesianChart1.ChartTheme = null;
        cartesianChart1.Dock = DockStyle.Bottom;
        skDefaultLegend4.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultLegend4.Content = null;
        skDefaultLegend4.IsValid = false;
        skDefaultLegend4.Opacity = 1F;
        padding7.Bottom = 0F;
        padding7.Left = 0F;
        padding7.Right = 0F;
        padding7.Top = 0F;
        skDefaultLegend4.Padding = padding7;
        skDefaultLegend4.RemoveOnCompleted = false;
        skDefaultLegend4.RotateTransform = 0F;
        skDefaultLegend4.X = 0F;
        skDefaultLegend4.Y = 0F;
        cartesianChart1.Legend = skDefaultLegend4;
        cartesianChart1.Location = new Point(18, 52);
        cartesianChart1.MatchAxesScreenDataRatio = false;
        cartesianChart1.Name = "cartesianChart1";
        cartesianChart1.Size = new Size(419, 230);
        cartesianChart1.TabIndex = 27;
        skDefaultTooltip4.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultTooltip4.Content = null;
        skDefaultTooltip4.IsValid = false;
        skDefaultTooltip4.Opacity = 1F;
        padding8.Bottom = 0F;
        padding8.Left = 0F;
        padding8.Right = 0F;
        padding8.Top = 0F;
        skDefaultTooltip4.Padding = padding8;
        skDefaultTooltip4.RemoveOnCompleted = false;
        skDefaultTooltip4.RotateTransform = 0F;
        skDefaultTooltip4.Wedge = 10;
        skDefaultTooltip4.X = 0F;
        skDefaultTooltip4.Y = 0F;
        cartesianChart1.Tooltip = skDefaultTooltip4;
        cartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
        cartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
        // 
        // kLabel4
        // 
        kLabel4.AutoSize = false;
        kLabel4.BackColor = Color.Transparent;
        kLabel4.ForeColor = Color.DimGray;
        kLabel4.Location = new Point(21, 18);
        kLabel4.Name = "kLabel4";
        kLabel4.Size = new Size(401, 23);
        kLabel4.TabIndex = 26;
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
        flowLayoutPanel1.Controls.Add(btnConsultar);
        flowLayoutPanel1.Controls.Add(btnVerEmpleados);
        flowLayoutPanel1.Controls.Add(btnVerAsistencias);
        flowLayoutPanel1.Controls.Add(btnVerNomina);
        flowLayoutPanel1.Location = new Point(21, 121);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(928, 507);
        flowLayoutPanel1.TabIndex = 25;
        // 
        // kPanel3
        // 
        kPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        kPanel3.BackColor = Color.Transparent;
        kPanel3.Controls.Add(lblEmpleadosActivos);
        kPanel3.Controls.Add(kLabel5);
        kPanel3.Location = new Point(3, 3);
        kPanel3.Name = "kPanel3";
        kPanel3.Padding = new Padding(12);
        kPanel3.Shadow.Blur = 5;
        kPanel3.Shadow.Enabled = true;
        kPanel3.Shadow.Offset = new Point(0, 1);
        kPanel3.Shadow.Opacity = 10;
        kPanel3.Size = new Size(300, 140);
        kPanel3.TabIndex = 27;
        // 
        // lblEmpleadosActivos
        // 
        lblEmpleadosActivos.AutoSize = false;
        lblEmpleadosActivos.BackColor = Color.Transparent;
        lblEmpleadosActivos.Dock = DockStyle.Top;
        lblEmpleadosActivos.Location = new Point(18, 41);
        lblEmpleadosActivos.Name = "lblEmpleadosActivos";
        lblEmpleadosActivos.Size = new Size(264, 81);
        lblEmpleadosActivos.TabIndex = 21;
        lblEmpleadosActivos.Text = "000";
        lblEmpleadosActivos.TextAlign = ContentAlignment.MiddleLeft;
        lblEmpleadosActivos.TextRole = KovaqsUI.Controls.KTextRole.Title;
        // 
        // kLabel5
        // 
        kLabel5.AutoSize = false;
        kLabel5.BackColor = Color.Transparent;
        kLabel5.Dock = DockStyle.Top;
        kLabel5.ForeColor = Color.DimGray;
        kLabel5.Location = new Point(18, 18);
        kLabel5.Name = "kLabel5";
        kLabel5.Size = new Size(264, 23);
        kLabel5.TabIndex = 20;
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
        kPanel2.Location = new Point(309, 3);
        kPanel2.Name = "kPanel2";
        kPanel2.Padding = new Padding(12);
        kPanel2.Shadow.Blur = 5;
        kPanel2.Shadow.Enabled = true;
        kPanel2.Shadow.Offset = new Point(0, 1);
        kPanel2.Shadow.Opacity = 10;
        kPanel2.Size = new Size(300, 140);
        kPanel2.TabIndex = 26;
        // 
        // lblFaltasMes
        // 
        lblFaltasMes.AutoSize = false;
        lblFaltasMes.BackColor = Color.Transparent;
        lblFaltasMes.Dock = DockStyle.Top;
        lblFaltasMes.Location = new Point(18, 41);
        lblFaltasMes.Name = "lblFaltasMes";
        lblFaltasMes.Size = new Size(264, 81);
        lblFaltasMes.TabIndex = 22;
        lblFaltasMes.Text = "000";
        lblFaltasMes.TextAlign = ContentAlignment.MiddleLeft;
        lblFaltasMes.TextRole = KovaqsUI.Controls.KTextRole.Title;
        // 
        // kLabel6
        // 
        kLabel6.AutoSize = false;
        kLabel6.BackColor = Color.Transparent;
        kLabel6.Dock = DockStyle.Top;
        kLabel6.ForeColor = Color.DimGray;
        kLabel6.Location = new Point(18, 18);
        kLabel6.Name = "kLabel6";
        kLabel6.Size = new Size(264, 23);
        kLabel6.TabIndex = 21;
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
        kPanel1.Location = new Point(615, 3);
        kPanel1.Name = "kPanel1";
        kPanel1.Padding = new Padding(12);
        kPanel1.Shadow.Blur = 5;
        kPanel1.Shadow.Enabled = true;
        kPanel1.Shadow.Offset = new Point(0, 1);
        kPanel1.Shadow.Opacity = 10;
        kPanel1.Size = new Size(300, 140);
        kPanel1.TabIndex = 25;
        // 
        // lblTardanzasMes
        // 
        lblTardanzasMes.AutoSize = false;
        lblTardanzasMes.BackColor = Color.Transparent;
        lblTardanzasMes.Dock = DockStyle.Top;
        lblTardanzasMes.Location = new Point(18, 41);
        lblTardanzasMes.Name = "lblTardanzasMes";
        lblTardanzasMes.Size = new Size(264, 81);
        lblTardanzasMes.TabIndex = 22;
        lblTardanzasMes.Text = "000";
        lblTardanzasMes.TextAlign = ContentAlignment.MiddleLeft;
        lblTardanzasMes.TextRole = KovaqsUI.Controls.KTextRole.Title;
        // 
        // kLabel8
        // 
        kLabel8.AutoSize = false;
        kLabel8.BackColor = Color.Transparent;
        kLabel8.Dock = DockStyle.Top;
        kLabel8.ForeColor = Color.DimGray;
        kLabel8.Location = new Point(18, 18);
        kLabel8.Name = "kLabel8";
        kLabel8.Size = new Size(264, 23);
        kLabel8.TabIndex = 21;
        kLabel8.Text = "Llegadas tarde";
        kLabel8.TextAlign = ContentAlignment.MiddleLeft;
        kLabel8.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        // 
        // btnConsultar
        // 
        btnConsultar.BackColor = Color.Transparent;
        btnConsultar.CornerRadius = 8;
        btnConsultar.FlatStyle = FlatStyle.Flat;
        btnConsultar.Location = new Point(3, 455);
        btnConsultar.Name = "btnConsultar";
        btnConsultar.Padding = new Padding(12, 4, 12, 4);
        btnConsultar.Size = new Size(205, 40);
        btnConsultar.TabIndex = 28;
        btnConsultar.Text = "Consultar";
        btnConsultar.UseVisualStyleBackColor = false;
        btnConsultar.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        // 
        // btnVerEmpleados
        // 
        btnVerEmpleados.BackColor = Color.Transparent;
        btnVerEmpleados.CornerRadius = 8;
        btnVerEmpleados.FlatStyle = FlatStyle.Flat;
        btnVerEmpleados.Location = new Point(214, 455);
        btnVerEmpleados.Name = "btnVerEmpleados";
        btnVerEmpleados.Padding = new Padding(12, 4, 12, 4);
        btnVerEmpleados.Size = new Size(205, 40);
        btnVerEmpleados.TabIndex = 29;
        btnVerEmpleados.Text = "Ver empleados";
        btnVerEmpleados.UseVisualStyleBackColor = false;
        btnVerEmpleados.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // btnVerAsistencias
        // 
        btnVerAsistencias.BackColor = Color.Transparent;
        btnVerAsistencias.CornerRadius = 8;
        btnVerAsistencias.FlatStyle = FlatStyle.Flat;
        btnVerAsistencias.Location = new Point(425, 455);
        btnVerAsistencias.Name = "btnVerAsistencias";
        btnVerAsistencias.Padding = new Padding(12, 4, 12, 4);
        btnVerAsistencias.Size = new Size(205, 40);
        btnVerAsistencias.TabIndex = 30;
        btnVerAsistencias.Text = "Ver asistencias";
        btnVerAsistencias.UseVisualStyleBackColor = false;
        btnVerAsistencias.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // btnVerNomina
        // 
        btnVerNomina.BackColor = Color.Transparent;
        btnVerNomina.CornerRadius = 8;
        btnVerNomina.FlatStyle = FlatStyle.Flat;
        btnVerNomina.Location = new Point(636, 455);
        btnVerNomina.Name = "btnVerNomina";
        btnVerNomina.Padding = new Padding(12, 4, 12, 4);
        btnVerNomina.Size = new Size(205, 40);
        btnVerNomina.TabIndex = 31;
        btnVerNomina.Text = "Ver nómina";
        btnVerNomina.UseVisualStyleBackColor = false;
        btnVerNomina.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        // 
        // FrmEmpleados
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(961, 640);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(kLabel2);
        Controls.Add(cboDepartamento);
        Controls.Add(kLabel1);
        Controls.Add(dtpPeriodo);
        Controls.Add(kLabel7);
        Name = "FrmEmpleados";
        Text = "Empleados";
        Load += FrmEmpleados_Load;
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
    private DateTimePicker dtpPeriodo;
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
    private KovaqsUI.Controls.KButton btnConsultar;
    private KovaqsUI.Controls.KButton btnVerEmpleados;
    private KovaqsUI.Controls.KButton btnVerAsistencias;
    private KovaqsUI.Controls.KButton btnVerNomina;
}
