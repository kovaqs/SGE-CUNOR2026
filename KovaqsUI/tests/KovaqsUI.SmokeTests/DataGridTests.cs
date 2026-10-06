using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using KovaqsUI.Controls;
using KovaqsUI.Styling;

internal static class DataGridTests
{
    [DllImport("user32.dll")]
    private static extern int GetGuiResources(IntPtr process, uint flags);

    public static void Run(Action<bool, string> check)
    {
        using var form = new Form { ClientSize = new Size(800, 600) };
        using var grid = new KDataGridView { Location = new Point(20, 20), Size = new Size(740, 500) };
        form.Controls.Add(grid);
        form.Show();
        Application.DoEvents();

        // 1. Configuración nativa y valores predeterminados
        check(!grid.EnableHeadersVisualStyles, "KDataGridView desactiva EnableHeadersVisualStyles para permitir estilos propios");
        check(grid.BorderStyle == BorderStyle.None, "KDataGridView usa BorderStyle.None por defecto");
        check(grid.CellBorderStyle == DataGridViewCellBorderStyle.SingleHorizontal, "KDataGridView usa divisores horizontales por defecto");
        check(!grid.RowHeadersVisible, "KDataGridView oculta encabezados de fila por defecto");
        check(grid.SelectionMode == DataGridViewSelectionMode.FullRowSelect, "KDataGridView inicia en FullRowSelect");

        // 2. Tipografía e integración con KFontManager
        var fontProp = TypeDescriptor.GetProperties(grid)[nameof(KDataGridView.Font)]!;
        check(fontProp.Converter is KFontConverter, "KDataGridView asocia KFontConverter a la propiedad Font");
        check(grid.Font.Name.StartsWith("Inter"), "KDataGridView inicializa su tipografía con Inter");

        // 3. Densidades y preservación de dimensiones manuales
        grid.Density = KGridDensity.Compact;
        check(grid.RowTemplate.Height <= 36 && grid.ColumnHeadersHeight <= 36, "densidad Compact aplica alturas reducidas");

        grid.Density = KGridDensity.Comfortable;
        check(grid.RowTemplate.Height >= 50 && grid.ColumnHeadersHeight >= 40, "densidad Comfortable aplica alturas amplias");

        // Sobrescritura manual no es pisada por Density o Theme
        grid.RowTemplate.Height = 47;
        grid.Theme = KTheme.Dark;
        check(grid.RowTemplate.Height == 47, "altura de fila manual persiste tras cambio de tema");

        // 4. Precedencia: Override local > Theme > Default
        grid.Appearance.Header.BackColor = Color.Navy;
        grid.Theme = KTheme.Light;
        check(grid.Appearance.Header.BackColor == Color.Navy, "color de encabezado explícito persiste tras cambio de tema");
        check(grid.ColumnHeadersDefaultCellStyle.BackColor == Color.Navy, "estilo de encabezado refleja el color explícito");

        grid.Appearance.Header.ResetBackColor();
        check(grid.Appearance.Header.BackColor.IsEmpty, "ResetBackColor restaura herencia de tema");
        check(grid.ColumnHeadersDefaultCellStyle.BackColor != Color.Navy, "estilo de encabezado recupera color del tema");

        // 5. Enlace de datos: DataTable
        var table = new DataTable("Test");
        table.Columns.Add("Id", typeof(int));
        table.Columns.Add("Nombre", typeof(string));
        table.Columns.Add("Rol", typeof(string));
        for (int i = 1; i <= 5; i++) table.Rows.Add(i, $"Empleado {i}", i % 2 == 0 ? "Admin" : "Usuario");

        grid.AllowUserToAddRows = false;
        grid.DataSource = table;
        Application.DoEvents();
        check(grid.RowCount == 5 && grid.ColumnCount == 3, "DataSource con DataTable vincula filas y columnas correctamente");

        grid.Sort(grid.Columns[0], ListSortDirection.Descending);
        check((int)grid.Rows[0].Cells[0].Value == 5, "ordenamiento nativo funciona correctamente en KDataGridView");

        // 6. Enlace de datos: BindingList<T> con notificaciones
        var list = new BindingList<TestEmployee>
        {
            new() { Name = "Ana", Department = "Ventas", Active = true },
            new() { Name = "Carlos", Department = "IT", Active = false }
        };
        grid.DataSource = list;
        Application.DoEvents();
        check(grid.RowCount == 2, "DataSource con BindingList<T> vincula 2 elementos");

        list.Add(new TestEmployee { Name = "Beatriz", Department = "Diseño", Active = true });
        Application.DoEvents();
        check(grid.RowCount == 3, "BindingList notifica inserciones dinámicas a KDataGridView");

        // 7. Modos de selección nativos
        check(grid.SelectedRows.Count > 0, "FullRowSelect selecciona fila completa");
        grid.ClearSelection();
        grid.Rows[1].Selected = true;
        check(grid.SelectedRows.Count == 1 && grid.SelectedRows[0].Index == 1, "selección programática de fila respetada");

        grid.SelectionMode = DataGridViewSelectionMode.CellSelect;
        grid.ClearSelection();
        grid.Rows[0].Cells[0].Selected = true;
        check(grid.SelectedCells.Count == 1 && grid.SelectedCells[0].RowIndex == 0, "modo CellSelect respetado");
        grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        using var badgeGrid = new KDataGridView { Size = new Size(400, 200), AutoGenerateColumns = false };
        var nameCol = new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre", Width = 150 };
        var badgeCol = new KBadgeColumn { HeaderText = "Estado", DataPropertyName = "Estado", Width = 150 };
        badgeGrid.Columns.AddRange(nameCol, badgeCol);

        var badgeTable = new DataTable();
        badgeTable.Columns.Add("Nombre", typeof(string));
        badgeTable.Columns.Add("Estado", typeof(string));
        badgeTable.Rows.Add("Tarea 1", "Aprobado");
        badgeTable.Rows.Add("Tarea 2", "Pendiente");
        badgeTable.Rows.Add("Tarea 3", "Rechazado");
        badgeGrid.DataSource = badgeTable;
        form.Controls.Add(badgeGrid);
        badgeGrid.BringToFront();
        Application.DoEvents();

        check(badgeGrid.Columns[1] is KBadgeColumn, "KBadgeColumn se incorpora correctamente al grid");
        check(badgeGrid.Rows[0].Cells[1] is KBadgeCell, "las celdas de KBadgeColumn son de tipo KBadgeCell");

        // Custom StyleSelector
        bool customSelectorInvoked = false;
        badgeCol.StyleSelector = val =>
        {
            customSelectorInvoked = true;
            return new KBadgeStyle(Color.LightCyan, Color.DarkCyan);
        };
        using (var bmp = new Bitmap(badgeGrid.Width, badgeGrid.Height))
        {
            badgeGrid.DrawToBitmap(bmp, badgeGrid.ClientRectangle);
        }
        check(customSelectorInvoked, "KBadgeColumn invoca StyleSelector personalizado al renderizar");

        // 9. Serialización y PropertyGrid en tiempo de diseño
        var appProp = TypeDescriptor.GetProperties(grid)[nameof(KDataGridView.Appearance)]!;
        check(appProp.SerializationVisibility == DesignerSerializationVisibility.Content, "Appearance expone DesignerSerializationVisibility.Content");

        var rowProp = TypeDescriptor.GetProperties(grid.Appearance)[nameof(KGridAppearance.Rows)]!;
        check(rowProp.SerializationVisibility == DesignerSerializationVisibility.Content, "Appearance.Rows expone DesignerSerializationVisibility.Content");

        var hoverProp = TypeDescriptor.GetProperties(grid.Appearance.Hover)[nameof(KGridHoverStyle.Enabled)]!;
        check(hoverProp.ShouldSerializeValue(grid.Appearance.Hover) == false, "Hover.Enabled no serializa su valor predeterminado (true)");
        grid.Appearance.Hover.Enabled = false;
        check(hoverProp.ShouldSerializeValue(grid.Appearance.Hover) == true, "Hover.Enabled serializa cambio explícito");
        hoverProp.ResetValue(grid.Appearance.Hover);
        check(grid.Appearance.Hover.Enabled == true, "ResetValue restaura valor predeterminado");

        // 10. Estabilidad de recursos GDI tras operaciones sucesivas
        int gdiBefore = GetGuiResources(Process.GetCurrentProcess().Handle, 0);
        using var renderBmp = new Bitmap(grid.Width, grid.Height);
        for (int i = 0; i < 50; i++)
        {
            grid.Theme = i % 2 == 0 ? KTheme.Dark : KTheme.Light;
            grid.Density = i % 3 == 0 ? KGridDensity.Compact : (i % 3 == 1 ? KGridDensity.Normal : KGridDensity.Comfortable);
            grid.DrawToBitmap(renderBmp, grid.ClientRectangle);
        }
        int gdiAfter = GetGuiResources(Process.GetCurrentProcess().Handle, 0);
        check(Math.Abs(gdiAfter - gdiBefore) <= 4, $"estabilidad de recursos GDI (delta={gdiAfter - gdiBefore}) tras 50 ciclos de repaint/tema/densidad");

        form.Controls.Remove(badgeGrid);
        form.Controls.Remove(grid);
    }

    private sealed class TestEmployee
    {
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public bool Active { get; set; }
    }
}
