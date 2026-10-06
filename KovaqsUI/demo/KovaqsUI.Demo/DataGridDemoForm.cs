using System.Data;
using KovaqsUI.Controls;
using KovaqsUI.Styling;

namespace KovaqsUI.Demo;

internal sealed class DataGridDemoForm : Form
{
    private readonly List<Control> samples = [];
    private readonly KDataGridView grid;
    private readonly KPanel card;
    private readonly KTextBox searchBox;
    private readonly KSegmentedControl statusFilter;
    private readonly KLabel statusLabel;
    private readonly DataTable rawData;
    private readonly DataView currentView;
    private readonly Font demoFont = KTypography.Body;
    private bool dark;
    private KGridDensity currentDensity = KGridDensity.Normal;
    private KGridLines currentLines = KGridLines.Horizontal;
    private bool alternateRows;
    private bool isReadOnly = true;

    public DataGridDemoForm()
    {
        rawData = BuildSampleData();
        currentView = rawData.DefaultView;

        statusLabel = new KLabel
        {
            Dock = DockStyle.Fill,
            AutoSize = false, Height = 28,
            Padding = new Padding(0, 6, 0, 0),
            TextRole = KTextRole.Caption,
            Text = "Cargando registros…"
        };

        card = new KPanel
        {
            Dock = DockStyle.Fill,
            CornerRadius = 14,
            BorderThickness = 1,
            Padding = new Padding(12)
        };
        card.Shadow.Enabled = true;
        card.Shadow.Blur = 10;
        card.Shadow.Opacity = 16;

        grid = new KDataGridView
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            AccessibleName = "Tabla de colaboradores",
            AutoGenerateColumns = false,
            AllowUserToAddRows = false,
            AllowUserToDeleteRows = false,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        };

        Text = "KovaqsUI · Tabla de datos profesional";
        AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(1060, 840);
        MinimumSize = new Size(840, 640);
        BackColor = KTheme.Light.Background;
        Font = demoFont;
        var layout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 5, Padding = new Padding(24), Margin = Padding.Empty };
        layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32));
        Controls.Add(layout);

        var headerPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            Padding = new Padding(0, 0, 0, 12), Margin = Padding.Empty
        };
        layout.Controls.Add(headerPanel, 0, 0);

        var title = new KLabel
            { Text = "Gestión de personal", TextRole = KTextRole.Title, AutoSize = true, Margin = new Padding(0, 0, 0, 4) };
        var subtitle = new KLabel
        {
            Text = "Directorio de colaboradores · selección nativa · filtros e insignias de estado",
            TextRole = KTextRole.Subtitle,
            AutoSize = true,
            Margin = new Padding(0, 0, 0, 16)
        };
        headerPanel.Controls.AddRange([title, subtitle]);
        samples.AddRange([title, subtitle]);

        // Barra de herramientas superior
        var toolbar = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            WrapContents = true,
            Padding = new Padding(0, 0, 0, 8), Margin = Padding.Empty
        };
        layout.Controls.Add(toolbar, 0, 1);

        searchBox = new KTextBox
        {
            PlaceholderText = "Buscar nombre, correo o cargo…",
            Size = new Size(300, 42),
            Margin = new Padding(0, 0, 12, 8), AccessibleName = "Buscar colaboradores"
        };
        searchBox.TextChanged += (_, _) => ApplyFilters();
        var searchLabel = new KLabel { Text = "Buscar", AutoSize = true, Margin = new Padding(0, 11, 10, 0) };
        toolbar.Controls.Add(searchLabel); samples.Add(searchLabel);
        toolbar.Controls.Add(searchBox);
        samples.Add(searchBox);

        statusFilter = new KSegmentedControl
        {
            Size = new Size(400, 42),
            Padding = new Padding(4),
            CornerRadius = 10,
            SegmentCornerRadius = 8,
            ItemSizeMode = KSegmentSizeMode.Content,
            Margin = new Padding(0, 0, 12, 8), AccessibleName = "Filtrar por estado"
        };
        statusFilter.Items.AddRange(
            new KSegmentItem("Todos", "all"),
            new KSegmentItem("Activos", "Activo"),
            new KSegmentItem("Pendientes", "Pendiente"),
            new KSegmentItem("Inactivos", "Inactivo")
        );
        statusFilter.SelectedIndex = 0;
        statusFilter.SelectedIndexChanged += (_, _) => ApplyFilters();
        toolbar.Controls.Add(statusFilter);
        samples.Add(statusFilter);

        var addBtn = new KButton
        {
            Text = "+ Agregar",
            Variant = KButtonVariant.Primary,
            Size = new Size(110, 40),
            Margin = new Padding(0, 0, 8, 0)
        };
        addBtn.Click += (_, _) => AddSampleRow();
        toolbar.Controls.Add(addBtn);

        // Barra de acciones y conmutadores inferiores
        var bottomPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            Padding = new Padding(0, 12, 0, 0), Margin = Padding.Empty,
            WrapContents = true
        };
        layout.Controls.Add(bottomPanel, 0, 3);

        var themeBtn = new KButton { Text = "Claro / Oscuro", Variant = KButtonVariant.Outline, Size = new Size(125, 38), Margin = new Padding(0, 0, 8, 0) };
        themeBtn.Click += (_, _) => { dark = !dark; ApplyTheme(); };

        var densityBtn = new KButton { Text = "Densidad: Normal", Variant = KButtonVariant.Outline, Size = new Size(140, 38), Margin = new Padding(0, 0, 8, 0) };
        densityBtn.Click += (_, _) =>
        {
            currentDensity = currentDensity switch
            {
                KGridDensity.Compact => KGridDensity.Normal,
                KGridDensity.Normal => KGridDensity.Comfortable,
                _ => KGridDensity.Compact
            };
            grid.Density = currentDensity;
            densityBtn.Text = $"Densidad: {currentDensity}";
        };

        var alternateBtn = new KButton { Text = "Alternas: No", Variant = KButtonVariant.Outline, Size = new Size(120, 38), Margin = new Padding(0, 0, 8, 0) };
        alternateBtn.Click += (_, _) =>
        {
            alternateRows = !alternateRows;
            grid.Appearance.AlternateRows.Enabled = alternateRows;
            alternateBtn.Text = alternateRows ? "Alternas: Sí" : "Alternas: No";
        };

        var linesBtn = new KButton { Text = "Divisores: Horiz", Variant = KButtonVariant.Outline, Size = new Size(135, 38), Margin = new Padding(0, 0, 8, 0) };
        linesBtn.Click += (_, _) =>
        {
            currentLines = currentLines switch
            {
                KGridLines.Horizontal => KGridLines.Both,
                KGridLines.Both => KGridLines.None,
                _ => KGridLines.Horizontal
            };
            grid.GridLines = currentLines;
            linesBtn.Text = $"Divisores: {currentLines}";
        };

        var readOnlyBtn = new KButton { Text = "Solo lectura: Sí", Variant = KButtonVariant.Outline, Size = new Size(135, 38), Margin = new Padding(0, 0, 8, 0) };
        readOnlyBtn.Click += (_, _) =>
        {
            isReadOnly = !isReadOnly;
            grid.ReadOnly = isReadOnly;
            readOnlyBtn.Text = isReadOnly ? "Solo lectura: Sí" : "Solo lectura: No";
        };

        var customizeBtn = new KButton { Text = "Personalizar…", Variant = KButtonVariant.Outline, Size = new Size(125, 38), Margin = new Padding(0, 0, 8, 0) };
        customizeBtn.Click += (_, _) => new AppearanceInspector(samples).Show(this);

        bottomPanel.Controls.AddRange([themeBtn, densityBtn, alternateBtn, linesBtn, readOnlyBtn, customizeBtn]);
        foreach (KButton button in bottomPanel.Controls)
        {
            button.Size = new Size(152, 42);
            button.Padding = new Padding(6, 4, 6, 4);
            button.Margin = new Padding(0, 0, 8, 8);
            samples.Add(button);
        }
        themeBtn.Width = 142;
        densityBtn.Width = 190;
        alternateBtn.Width = 124;
        linesBtn.Width = 180;
        readOnlyBtn.Width = 148;
        customizeBtn.Width = 140;
        samples.Add(addBtn);

        // Barra de estado
        layout.Controls.Add(statusLabel, 0, 4);

        card.Margin = Padding.Empty;
        layout.Controls.Add(card, 0, 2);
        card.Controls.Add(grid);
        samples.Add(grid);

        // Configuración de columnas
        var nameCol = new DataGridViewTextBoxColumn { HeaderText = "Colaborador", DataPropertyName = "Nombre", Width = 170 };
        var roleCol = new DataGridViewTextBoxColumn { HeaderText = "Cargo", DataPropertyName = "Cargo", Width = 150 };
        var emailCol = new DataGridViewTextBoxColumn { HeaderText = "Correo electrónico", DataPropertyName = "Email", Width = 210 };
        var countryCol = new DataGridViewTextBoxColumn { HeaderText = "País", DataPropertyName = "Pais", Width = 130 };
        var salaryCol = new DataGridViewTextBoxColumn { HeaderText = "Salario (USD)", DataPropertyName = "Salario", Width = 115 };
        salaryCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        salaryCol.DefaultCellStyle.Format = "N0";

        var badgeCol = new KBadgeColumn
        {
            HeaderText = "Estado",
            DataPropertyName = "Estado",
            Width = 120
        };

        nameCol.MinimumWidth = 150; nameCol.FillWeight = 18;
        roleCol.MinimumWidth = 140; roleCol.FillWeight = 18;
        emailCol.MinimumWidth = 190; emailCol.FillWeight = 24;
        countryCol.MinimumWidth = 105; countryCol.FillWeight = 13;
        salaryCol.MinimumWidth = 110; salaryCol.FillWeight = 13;
        salaryCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        badgeCol.MinimumWidth = 110; badgeCol.FillWeight = 14;
        badgeCol.SortMode = DataGridViewColumnSortMode.Automatic;
        grid.Columns.AddRange([nameCol, roleCol, emailCol, countryCol, salaryCol, badgeCol]);
        grid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        grid.DataSource = currentView;

        grid.DataError += (_, e) => { e.ThrowException = false; e.Cancel = true; statusLabel.Text = "El valor no es válido para esta columna. Corrígelo o presiona Esc."; };
        grid.DataBindingComplete += (_, _) => UpdateStatus();
        grid.Paint += (_, e) =>
        {
            if (currentView.Count != 0) return;
            var area = new Rectangle(12, grid.ColumnHeadersHeight + 24, Math.Max(0, grid.Width - 24), 60);
            TextRenderer.DrawText(e.Graphics, "No hay colaboradores que coincidan con los filtros.", grid.Font, area,
                grid.Theme.TextSecondary, TextFormatFlags.HorizontalCenter | TextFormatFlags.WordBreak);
        };
        grid.SelectionChanged += (_, _) => UpdateStatus();
        UpdateStatus();
        ApplyTheme();
    }

    private DataTable BuildSampleData()
    {
        var dt = new DataTable("Employees");
        dt.Columns.Add("Nombre", typeof(string));
        dt.Columns.Add("Cargo", typeof(string));
        dt.Columns.Add("Email", typeof(string));
        dt.Columns.Add("Pais", typeof(string));
        dt.Columns.Add("Salario", typeof(decimal));
        dt.Columns.Add("Estado", typeof(string));

        dt.Rows.Add("Liam Smith", "Director Ejecutivo", "liam.smith@example.com", "Estados Unidos", 754713m, "Activo");
        dt.Rows.Add("Noah Anderson", "Director Financiero", "anderson@example.com", "Argentina", 457468m, "Activo");
        dt.Rows.Add("Isabella Garcia", "Directora de Operaciones", "garcia@example.com", "Australia", 363559m, "Activo");
        dt.Rows.Add("William Clark", "Director Técnico", "william@example.com", "Bélgica", 234700m, "Activo");
        dt.Rows.Add("James Hall", "Gerente de Producto", "james@example.com", "Brasil", 230735m, "Pendiente");
        dt.Rows.Add("Benjamin Lewis", "Recursos Humanos", "lewis@example.com", "Canadá", 127000m, "Activo");
        dt.Rows.Add("Amelia Davis", "Gerente de Ventas", "davis@example.com", "China", 110000m, "Pendiente");
        dt.Rows.Add("Emma Johnson", "Diseñadora UX/UI", "johnson@example.com", "Colombia", 121220m, "Activo");
        dt.Rows.Add("Lucas Young", "Diseñador de Interacción", "young@example.com", "Finlandia", 132290m, "Inactivo");
        dt.Rows.Add("Alexander Wright", "Científico de Datos", "wright@example.com", "Francia", 85000m, "Pendiente");
        dt.Rows.Add("Harper Martinez", "Ingeniera de Software", "martinez@example.com", "Alemania", 65000m, "Activo");
        dt.Rows.Add("Olivia Brown", "Atención al Cliente", "brown@example.com", "Irlanda", 115000m, "Inactivo");
        dt.Rows.Add("Ava Williams", "Soporte Técnico", "williams@example.com", "Ucrania", 110140m, "Activo");
        dt.Rows.Add("Sophia Jones", "Líder de Proyecto", "jones@example.com", "Reino Unido", 110140m, "Pendiente");

        return dt;
    }

    private void AddSampleRow()
    {
        int count = rawData.Rows.Count + 1;
        rawData.Rows.Add($"Nuevo Miembro {count}", "Especialista", $"nuevo{count}@example.com", "Guatemala", 95000m, "Pendiente");
        ApplyFilters();
    }

    private void ApplyFilters()
    {
        string text = EscapeFilterText(searchBox.Text.Trim());
        string selectedStatus = statusFilter.SelectedValue ?? "all";

        var filters = new List<string>();
        if (!string.IsNullOrEmpty(text))
        {
            filters.Add($"(Nombre LIKE '%{text}%' OR Email LIKE '%{text}%' OR Cargo LIKE '%{text}%')");
        }

        if (selectedStatus != "all" && !string.IsNullOrEmpty(selectedStatus))
        {
            filters.Add($"Estado = '{selectedStatus}'");
        }

        currentView.RowFilter = filters.Count > 0 ? string.Join(" AND ", filters) : string.Empty;
        UpdateStatus();
    }

    private static string EscapeFilterText(string value) => string.Concat(value.Select(c => c switch
    {
        '\'' => "''", '[' => "[[]", ']' => "[]]", '%' => "[%]", '*' => "[*]", _ => c.ToString()
    }));

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (disposing) { currentView.Dispose(); rawData.Dispose(); demoFont.Dispose(); }
    }

    private void UpdateStatus()
    {
        int selected = grid.SelectedRows.Count;
        int total = currentView.Count;
        statusLabel.Text = $"Registros visibles: {total} de {rawData.Rows.Count} · Filas seleccionadas: {selected}";
    }

    internal void ApplyDark()
    {
        dark = true;
        ApplyTheme();
    }

    private void ApplyTheme()
    {
        var theme = dark ? KTheme.Dark : KTheme.Light;
        BackColor = theme.Background;
        ForeColor = theme.TextPrimary;
        KThemeManager.Apply(this, theme);
    }
}
