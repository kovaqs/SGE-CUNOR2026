using System.Reflection;
using KovaqsUI.Controls;
using KovaqsUI.Styling;

internal static class GridDemoRegressionTests
{
    internal static void Run(Action<bool, string> check)
    {
        using var form = (Form)Assembly.Load("KovaqsUI.Demo").CreateInstance("KovaqsUI.Demo.DataGridDemoForm", true)!;
        form.Show(); Application.DoEvents();
        var all = Descendants(form).ToArray();
        var grid = all.OfType<KDataGridView>().Single();
        var search = all.OfType<KTextBox>().Single();
        var filter = all.OfType<KSegmentedControl>().Single();
        var buttons = all.OfType<KButton>().ToArray();
        foreach (var size in new[] { new Size(1060, 840), new Size(840, 640), new Size(1280, 900) })
        {
            form.Size = size; Application.DoEvents();
            var layout = form.Controls.OfType<TableLayoutPanel>().Single();
            var sections = layout.Controls.Cast<Control>().Where(c => c.Visible).ToArray();
            check(sections.All(c => layout.ClientRectangle.Contains(c.Bounds))
                && !sections.Where((a, i) => sections.Skip(i + 1).Any(b => a.Bounds.IntersectsWith(b.Bounds))).Any(),
                $"grid demo sections stay visible without overlap at {size}");
            check(buttons.All(c => c.Parent!.ClientRectangle.Contains(c.Bounds)) && grid.Height >= 120,
                $"grid demo actions wrap inside toolbar and leave usable table space at {size}");
        }
        check(grid.RowCount == 14 && !grid.AllowUserToAddRows, "grid demo initially shows actual records without phantom add row");
        filter.SelectedValue = "Inactivo";
        check(grid.RowCount == 2 && grid.Rows.Cast<DataGridViewRow>().All(r => Equals(r.Cells[5].Value, "Inactivo")), "grid demo status filter selects matching rows");
        filter.SelectedValue = "all"; search.Text = "Noah";
        check(grid.RowCount == 1 && Equals(grid.Rows[0].Cells[0].Value, "Noah Anderson"), "grid demo text search matches literal substrings");
        foreach (var text in new[] { "[", "]", "*", "%", "'", "[%]*'" })
        {
            search.Text = text;
            check(grid.RowCount == 0, $"grid demo safely treats filter metacharacters literally: {text}");
        }
        search.Text = string.Empty;
        buttons.Single(b => b.Text.StartsWith("+ Agregar")).PerformClick();
        check(grid.RowCount == 15, "grid demo add updates bound data and counts");
        buttons.Single(b => b.Text.StartsWith("Claro")).PerformClick();
        check(grid.Theme == KTheme.Dark, "grid demo theme toggle reaches nested grid");
        buttons.Single(b => b.Text.StartsWith("Densidad")).PerformClick();
        check(grid.Density == KGridDensity.Comfortable, "grid demo density action updates layout");
        buttons.Single(b => b.Text.StartsWith("Solo lectura")).PerformClick();
        check(!grid.ReadOnly, "grid demo editing toggle enables native editing");
        grid.CurrentCell = grid.Rows[0].Cells[4]; grid.BeginEdit(false);
        ((TextBox)grid.EditingControl!).Text = "no es un número";
        check(!grid.EndEdit(), "grid demo reports invalid numeric input without throwing");
        grid.CancelEdit();
        form.Close();
    }
    private static IEnumerable<Control> Descendants(Control parent)
    {
        foreach (Control child in parent.Controls)
        {
            yield return child;
            foreach (var nested in Descendants(child)) yield return nested;
        }
    }
}
