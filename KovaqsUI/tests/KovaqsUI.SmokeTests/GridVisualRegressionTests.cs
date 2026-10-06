using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using KovaqsUI.Controls;
using KovaqsUI.Styling;

internal static class GridVisualRegressionTests
{
    internal static void Run(Action<bool, string> check)
    {
        using var form = new Form { ClientSize = new Size(720, 480) };
        using var grid = new Probe { Dock = DockStyle.Fill, AllowUserToAddRows = false };
        grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", Width = 180 });
        grid.Columns.Add(new KBadgeColumn { Name = "State", Width = 160 });
        grid.Columns.Add(new DataGridViewCheckBoxColumn { Name = "Check", Width = 100 });
        grid.Rows.Add("Uno", "Activo", true); grid.Rows.Add("Dos", "Inactivo", false);
        form.Controls.Add(grid); form.Show(); Application.DoEvents(); grid.ClearSelection();

        grid.Appearance.Hover.BackColor = Color.Cyan; grid.Appearance.Hover.ForeColor = Color.Purple;
        grid.EnterCell(0, 1);
        var style = grid.Format(0, 1);
        check(style.BackColor == Color.Cyan && style.ForeColor == Color.Purple, "grid hover applies background and foreground through native formatting");
        using var bitmap = new Bitmap(grid.Width, grid.Height);
        grid.DrawToBitmap(bitmap, grid.ClientRectangle);
        var r = grid.GetCellDisplayRectangle(0, 1, false);
        check(bitmap.GetPixel(r.Right - 12, r.Top + 6).ToArgb() == Color.Cyan.ToArgb(), "grid paints hover through the cell background without overpainting its content");
        grid.SelectionMode = DataGridViewSelectionMode.CellSelect; grid.Rows[1].Cells[0].Selected = true;
        check(grid.Format(0, 1).BackColor != Color.Cyan && grid.Format(2, 1).BackColor == Color.Cyan, "grid cell selection takes priority over hover without changing adjacent cells");
        grid.ClearSelection(); grid.MoveTo(new Point(600, 350));
        check(grid.Format(0, 1).BackColor != Color.Cyan, "grid clears hover when pointer enters empty client space");
        grid.EnterCell(0, 1); grid.Appearance.Hover.Enabled = false; grid.Appearance.Hover.Enabled = true;
        check(grid.Format(0, 1).BackColor != Color.Cyan, "grid hover toggle clears stale row state");
        grid.EnterCell(0, 1); grid.Rows.RemoveAt(0);
        check(grid.Format(0, 0).BackColor != Color.Cyan, "grid removal clears stale row tracking");

        grid.Density = KGridDensity.Compact;
        grid.Appearance.Rows.Height = 60; grid.Appearance.Header.Height = 55;
        grid.Density = KGridDensity.Comfortable;
        check(grid.Rows[0].Height == 60 && grid.ColumnHeadersHeight == 55, "grid explicit appearance heights override density presets");
        grid.Appearance.Rows.ResetHeight(); grid.Appearance.Header.ResetHeight();
        check(grid.RowTemplate.Height == 56 && grid.Rows[0].Height == 56 && grid.ColumnHeadersHeight == 46, "grid resetting explicit heights restores current density");
        grid.Rows[0].Height = 75; grid.RowTemplate.Height = 65;
        grid.Appearance.Selection.BackColor = Color.LightBlue; grid.Theme = KTheme.Dark;
        check(grid.Rows[0].Height == 75 && grid.RowTemplate.Height == 65, "grid color and theme changes preserve manual row heights");
        grid.DefaultCellStyle.BackColor = Color.Beige; grid.GridColor = Color.Orange; grid.BackgroundColor = Color.Brown;
        grid.Theme = KTheme.Dark with { Focus = Color.Magenta };
        check(grid.DefaultCellStyle.BackColor == Color.Beige && grid.GridColor == Color.Orange && grid.BackgroundColor == Color.Brown,
            "grid theme changes preserve direct native background and divider overrides");
        grid.Appearance.Rows.BackColor = Color.Coral; grid.Theme = KTheme.Light;
        check(grid.DefaultCellStyle.BackColor == Color.Coral, "grid explicit appearance colors remain authoritative across themes");
        grid.Appearance.Rows.ResetBackColor();
        check(grid.DefaultCellStyle.BackColor == KTheme.Light.Surface, "grid appearance reset restores theme inheritance");
        var customDark = KTheme.Dark with { Focus = Color.Pink };
        grid.Theme = customDark;
        check(grid.ColumnHeadersDefaultCellStyle.BackColor == customDark.SurfaceHover, "grid derived dark themes retain dark header tokens");
        grid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.DarkRed, ForeColor = Color.White };
        grid.Theme = KTheme.Light;
        check(grid.ColumnHeadersDefaultCellStyle.BackColor == Color.DarkRed, "grid preserves explicitly replaced native header style");
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        grid.Density = KGridDensity.Normal;
        check(grid.ColumnHeadersHeightSizeMode == DataGridViewColumnHeadersHeightSizeMode.AutoSize, "grid density preserves native automatic header sizing mode");
        grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        using var customHeaderFont = new Font("Arial", 13, FontStyle.Bold);
        using var customBodyFont = new Font("Arial", 11);
        grid.ColumnHeadersDefaultCellStyle.Font = customHeaderFont; grid.Font = customBodyFont;
        check(grid.ColumnHeadersDefaultCellStyle.Font == customHeaderFont && grid.Rows[0].Cells[0].InheritedStyle.Font == customBodyFont,
            "grid font changes inherit into cells and preserve explicit header font");
        bool rejected = false; try { grid.Density = (KGridDensity)42; } catch (InvalidEnumArgumentException) { rejected = true; }
        check(rejected, "grid rejects invalid density values");

        int headerPaints = 0;
        DataGridViewCellPaintingEventHandler painter = (_, e) =>
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            { headerPaints++; e.Graphics!.FillRectangle(Brushes.Magenta, e.CellBounds); e.Handled = true; }
        };
        grid.CellPainting += painter; grid.DrawToBitmap(bitmap, grid.ClientRectangle);
        r = grid.GetCellDisplayRectangle(0, -1, false);
        check(headerPaints > 0 && bitmap.GetPixel(r.Left + 10, r.Top + 10).ToArgb() == Color.Magenta.ToArgb(),
            "grid respects consumer CellPainting handlers for headers");
        grid.CellPainting -= painter;
        grid.Columns[0].HeaderCell.Style.BackColor = Color.Navy;
        grid.Columns[0].HeaderCell.Style.ForeColor = Color.White;
        grid.DrawToBitmap(bitmap, grid.ClientRectangle);
        check(bitmap.GetPixel(r.Right - 12, r.Top + 6).ToArgb() == Color.Navy.ToArgb(), "grid honors per-column header colors");

        grid.Rows[0].Cells[1].Value = "Inactivo"; grid.ClearSelection(); grid.DrawToBitmap(bitmap, grid.ClientRectangle);
        r = grid.GetCellDisplayRectangle(1, 0, false);
        check(Count(bitmap, r, KBadgeStyle.Danger.BackColor) > 10 && Count(bitmap, r, KBadgeStyle.Success.BackColor) == 0,
            "badge inactive state is danger rather than success");
        var badge = (KBadgeColumn)grid.Columns[1];
        badge.StyleSelector = _ => new KBadgeStyle(Color.Lime, Color.Black);
        badge.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        badge.DefaultCellStyle.Padding = new Padding(14, 5, 18, 5);
        grid.Columns[1].Width = 50; grid.Rows[0].Cells[1].Value = "Una insignia de texto muy largo";
        grid.DrawToBitmap(bitmap, grid.ClientRectangle);
        r = grid.GetCellDisplayRectangle(1, 0, false);
        check(Count(bitmap, new Rectangle(r.Right + 1, r.Top + 2, 20, r.Height - 4), Color.Lime) == 0,
            "badge clips long content inside narrow cell and preserves adjacent cells");
        var clone = (KBadgeColumn)badge.Clone();
        check(clone.StyleSelector == badge.StyleSelector && clone.CellTemplate is KBadgeCell, "badge column cloning preserves custom selector and cell type"); clone.Dispose();

        grid.CurrentCell = grid.Rows[0].Cells[0];
        check(grid.BeginEdit(false), "grid starts native text editing");
        ((TextBox)grid.EditingControl!).Text = "Editado"; grid.EndEdit();
        check(Equals(grid.Rows[0].Cells[0].Value, "Editado"), "grid commits native edit after custom rendering");
        grid.Rows[0].Cells[0].Selected = true;
        check(grid.GetClipboardContent()?.GetData(DataFormats.UnicodeText)?.ToString()?.Contains("Editado") == true, "grid native clipboard content retains edited values");
        grid.RightToLeft = RightToLeft.Yes; grid.RowHeadersVisible = true;
        grid.Columns[0].Frozen = true;
        grid.DrawToBitmap(bitmap, grid.ClientRectangle);
        check(grid.GetCellDisplayRectangle(0, 0, false).Left > grid.GetCellDisplayRectangle(1, 0, false).Left,
            "grid native RTL and frozen columns retain mirrored layout");
        using var virtualGrid = new Probe { VirtualMode = true, AllowUserToAddRows = false, Size = new Size(400, 220) };
        virtualGrid.Columns.Add("Data", "Dato");
        int requested = 0;
        virtualGrid.CellValueNeeded += (_, e) => { requested++; e.Value = $"Fila {e.RowIndex}"; };
        virtualGrid.RowCount = 10000; form.Controls.Add(virtualGrid); virtualGrid.BringToFront();
        virtualGrid.FirstDisplayedScrollingRowIndex = 9990;
        using var virtualImage = new Bitmap(400, 220); virtualGrid.DrawToBitmap(virtualImage, virtualGrid.ClientRectangle);
        check(requested > 0 && virtualGrid.RowCount == 10000 && virtualGrid.FirstDisplayedScrollingRowIndex >= 9990,
            "grid preserves virtual data and scrolling near the end of a large row set");
        form.Close();
        Designer(check);
    }

    private static int Count(Bitmap bitmap, Rectangle bounds, Color color)
    {
        int count = 0; bounds.Intersect(new Rectangle(Point.Empty, bitmap.Size));
        for (int y = bounds.Top; y < bounds.Bottom; y++) for (int x = bounds.Left; x < bounds.Right; x++)
            if (bitmap.GetPixel(x, y).ToArgb() == color.ToArgb()) count++;
        return count;
    }
    private static void Designer(Action<bool, string> check)
    {
        using var surface = new DesignSurface(typeof(Form));
        var host = (IDesignerHost)surface.GetService(typeof(IDesignerHost))!;
        var grid = (KDataGridView)host.CreateComponent(typeof(KDataGridView), "grid");
        ((Form)host.RootComponent!).Controls.Add(grid);
        grid.Density = KGridDensity.Compact; grid.Appearance.Rows.Height = 48;
        grid.Appearance.Header.BackColor = Color.Navy; grid.Appearance.Hover.ForeColor = Color.Purple;
        var column = (KBadgeColumn)host.CreateComponent(typeof(KBadgeColumn), "statusColumn");
        column.HeaderText = "Estado"; grid.Columns.Add(column);
        var serializer = new CodeDomComponentSerializationService(surface);
        using var store = serializer.CreateStore(); serializer.Serialize(store, column); serializer.Serialize(store, grid); store.Close();
        using var container = new Container(); serializer.DeserializeTo(store, container);
        var copy = container.Components.OfType<KDataGridView>().Single();
        check(store.Errors.Count == 0 && copy.Columns[0] is KBadgeColumn && copy.Appearance.Rows.Height == 48
            && copy.Appearance.Header.BackColor == Color.Navy && copy.Appearance.Hover.ForeColor == Color.Purple,
            "grid and badge column serialize and restore through CodeDOM with nested appearance");
    }
    private sealed class Probe : KDataGridView
    {
        internal void EnterCell(int column, int row) => OnCellMouseEnter(new DataGridViewCellEventArgs(column, row));
        internal void MoveTo(Point point) => OnMouseMove(new MouseEventArgs(MouseButtons.None, 0, point.X, point.Y, 0));
        internal DataGridViewCellStyle Format(int column, int row)
        {
            var style = Rows[row].Cells[column].InheritedStyle.Clone();
            var e = new DataGridViewCellFormattingEventArgs(column, row, Rows[row].Cells[column].Value, typeof(string), style);
            OnCellFormatting(e); return e.CellStyle!;
        }
    }
}
