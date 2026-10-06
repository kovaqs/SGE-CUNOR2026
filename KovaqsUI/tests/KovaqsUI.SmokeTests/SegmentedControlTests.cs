using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Design;
using KovaqsUI.Controls;
using KovaqsUI.Styling;

internal static class SegmentedControlTests
{
    internal static void Run(Action<bool, string> check)
    {
        using var form = new TestForm { ClientSize = new Size(620, 400) };
        using var before = new Button { Text = "Before", TabIndex = 0 };
        using var control = new Probe { Location = new Point(10, 50), Size = new Size(500, 64), TabIndex = 1, AccessibleName = "Periodo" };
        using var after = new Button { Text = "After", Top = 140, TabIndex = 2 };
        form.Controls.AddRange([before, control, after]);
        control.Animation.Enabled = false;
        var first = new KSegmentItem("Día", "day");
        var disabled = new KSegmentItem("No disponible", "off") { Enabled = false };
        var last = new KSegmentItem("Mes", "month");
        control.Items.AddRange(first, disabled, last);
        check(control.Controls.Count == 0 && control.SelectedIndex == -1, "segmented uses owner drawing and begins without a selection");
        int indices = 0, items = 0, values = 0;
        control.SelectedIndexChanged += (_, _) => indices++;
        control.SelectedItemChanged += (_, _) => items++;
        control.SelectedValueChanged += (_, _) => values++;
        control.SelectedValue = "month";
        control.SelectedIndex = 2;
        check(control.SelectedItem == last && indices == 1 && items == 1 && values == 1, "segmented selection properties agree and suppress duplicate notifications");
        control.Items.Insert(0, new KSegmentItem("Hora", "hour"));
        check(control.SelectedIndex == 3 && control.SelectedItem == last && indices == 2 && items == 1 && values == 1, "segmented insertion preserves selected identity and reports shifted index");
        last.Value = "monthly";
        check(control.SelectedValue == "monthly" && indices == 2 && values == 2, "segmented selected value edits notify bindings without an index event");
        last.Enabled = false;
        check(control.SelectedIndex == -1 && control.SelectedItem is null && control.SelectedValue is null && indices == 3, "segmented disabling selected item clears selection once");
        bool rejected = false;
        try { control.SelectedItem = last; } catch (ArgumentException) { rejected = true; }
        check(rejected, "segmented rejects programmatic selection of disabled items");
        last.Enabled = true; control.SelectedItem = first;
        control.Items.RemoveAt(0);
        check(control.SelectedItem == first && control.SelectedIndex == 0, "segmented removal before selection preserves selected item");
        rejected = false;
        try { control.Items.Add(first); } catch (ArgumentException) { rejected = true; }
        check(rejected && control.Items.Count == 3, "segmented collection prevents duplicate item ownership");

        var a = control.GetItemBounds(0); var b = control.GetItemBounds(1); var c = control.GetItemBounds(2);
        check(Math.Abs(a.Width - c.Width) <= 1 && b.Left - a.Right == control.ItemSpacing && c.Right == control.ClientSize.Width - control.Padding.Right,
            "segmented equal layout fills inner width with exact spacing");
        control.ItemSizeMode = KSegmentSizeMode.Content;
        check(control.GetItemBounds(1).Width > control.GetItemBounds(0).Width, "segmented content layout allocates more space to longer text");
        control.RightToLeft = RightToLeft.Yes;
        check(control.GetItemBounds(0).Left > control.GetItemBounds(2).Left, "segmented RTL mirrors horizontal item placement");
        control.RightToLeft = RightToLeft.No; control.ItemSizeMode = KSegmentSizeMode.Equal;
        control.Orientation = Orientation.Vertical; control.Size = new Size(240, 260);
        check(control.GetItemBounds(0).Bottom < control.GetItemBounds(1).Top && control.GetItemBounds(2).Bottom == control.Height - control.Padding.Bottom,
            "segmented vertical layout fills the inner height");
        control.Orientation = Orientation.Horizontal; control.Size = new Size(500, 64);

        form.Show(); Application.DoEvents();
        before.Focus(); form.DialogKey(Keys.Tab);
        check(control.Focused, "segmented receives one native Tab stop");
        form.DialogKey(Keys.Tab);
        check(after.Focused, "segmented Tab exits without stopping on individual items");
        form.DialogKey(Keys.Shift | Keys.Tab);
        check(control.Focused, "segmented Shift+Tab returns to the control");
        control.KeyDownForTest(Keys.Right);
        check(control.SelectedItem == last, "segmented horizontal arrow skips disabled item");
        control.KeyDownForTest(Keys.Home);
        check(control.SelectedItem == first, "segmented Home selects first enabled item");
        control.Orientation = Orientation.Vertical; control.KeyDownForTest(Keys.Down);
        check(control.SelectedItem == last, "segmented vertical arrow selects the next enabled item");
        control.SelectedIndex = -1; after.Focus(); control.Focus();
        control.KeyDownForTest(Keys.Space); control.KeyUpForTest(Keys.Space);
        check(control.SelectedItem == first, "segmented Space commits the focused option after focus entry");
        control.SelectedIndex = -1; control.KeyDownForTest(Keys.Enter); control.KeyUpForTest(Keys.Enter);
        check(control.SelectedItem == first, "segmented Enter activates the focused option");
        control.Orientation = Orientation.Horizontal;
        var center = Center(control.GetItemBounds(2));
        control.Down(center); control.Up(new Point(0, 0));
        check(control.SelectedItem == first, "segmented releasing outside cancels mouse selection");
        control.Down(center); control.Up(center);
        check(control.SelectedItem == last, "segmented mouse selects on release in the pressed item");
        center = Center(control.GetItemBounds(1)); control.Down(center); control.Up(center);
        check(control.SelectedItem == last, "segmented disabled option ignores mouse input");
        control.Enabled = false; control.Down(Center(control.GetItemBounds(0))); control.Up(Center(control.GetItemBounds(0)));
        check(control.SelectedItem == last, "segmented disabled control ignores mouse input");
        control.Enabled = true;
        var model = new SelectionModel { Value = "day" };
        control.DataBindings.Add(nameof(control.SelectedValue), model, nameof(model.Value), true, DataSourceUpdateMode.OnPropertyChanged);
        check(control.SelectedItem == first, "segmented binding reads selected value from model");
        control.SelectedItem = last;
        check(model.Value == "monthly", "segmented binding writes selection to model");
        model.Value = "day";
        check(control.SelectedItem == first, "segmented binding responds to model notifications");
        control.DataBindings.Clear();
        control.RightToLeft = RightToLeft.Yes; control.KeyDownForTest(Keys.Left);
        check(control.SelectedItem == last, "segmented RTL arrow follows visual direction");
        control.RightToLeft = RightToLeft.No;
        var accessible = control.AccessibilityObject;
        check(accessible.Name == "Periodo" && accessible.GetChildCount() == 3 && accessible.GetChild(1)!.State.HasFlag(AccessibleStates.Unavailable), "segmented accessibility exposes named options and disabled state");
        accessible.GetChild(0)!.DoDefaultAction();
        check(control.SelectedItem == first && accessible.GetSelected()!.State.HasFlag(AccessibleStates.Selected), "segmented accessible action selects and reports selected child");
        check(accessible.GetChild(0)!.Bounds == control.RectangleToScreen(control.GetItemBounds(0)), "segmented accessible child bounds match layout");

        control.FillColor = Color.FromArgb(218, 218, 218); control.SelectedFillColor = Color.White;
        control.SelectedForeColor = Color.Black; control.CornerRadius = 16; control.Padding = new Padding(8);
        after.Focus();
        using var bitmap = new Bitmap(control.Width, control.Height);
        control.DrawToBitmap(bitmap, control.ClientRectangle);
        a = control.GetItemBounds(0);
        check(bitmap.GetPixel(a.Left + 15, a.Top + 5).ToArgb() == Color.White.ToArgb()
            && bitmap.GetPixel(control.Width / 2, 3).ToArgb() == control.FillColor.ToArgb(), "segmented rendering separates the inset selected surface from the container");
        control.Appearance.Hover.FillColor = Color.Lime;
        control.Appearance.Pressed.FillColor = Color.Red;
        control.MoveForTest(Center(control.GetItemBounds(2)));
        control.DrawToBitmap(bitmap, control.ClientRectangle);
        c = control.GetItemBounds(2);
        check(bitmap.GetPixel(c.Left + 15, c.Top + 5).ToArgb() == Color.Lime.ToArgb(), "segmented renders configurable hover surface");
        control.Down(Center(c)); control.DrawToBitmap(bitmap, control.ClientRectangle);
        check(bitmap.GetPixel(c.Left + 15, c.Top + 5).ToArgb() == Color.Red.ToArgb(), "segmented renders configurable pressed surface");
        control.Up(Point.Empty);
        control.Animation.Enabled = true; KAnimationSettings.Enabled = true; control.Animation.Duration = 30;
        control.SelectedIndex = 2; control.Refresh();
        var timer = System.Diagnostics.Stopwatch.StartNew();
        while (timer.ElapsedMilliseconds < 100) { Application.DoEvents(); Thread.Sleep(5); }
        control.Items.Remove(last); control.Refresh();
        check(control.SelectedIndex == -1 && control.Items.Count == 2, "segmented animation tolerates removal of the selected item");
        control.Items.Add(last); control.Animation.Enabled = false; KAnimationSettings.Enabled = false;
        control.BorderThickness = 2; control.SegmentBorderThickness = 1;
        KThemeManager.Apply(form, KTheme.Dark);
        check(control.Theme == KTheme.Dark && control.FillColor == Color.FromArgb(218, 218, 218), "segmented theme propagation preserves explicit colors");
        using var larger = new Bitmap(900, 500);
        foreach (var size in new[] { new Size(1, 1), new Size(7, 5), new Size(96, 48), new Size(600, 120) })
        {
            control.Size = size; control.DrawToBitmap(larger, control.ClientRectangle);
            check(Enumerable.Range(0, control.Items.Count).All(i => { var r = control.GetItemBounds(i); return r.Width >= 0 && r.Height >= 0 && r.Right <= control.Width && r.Bottom <= control.Height; }), $"segmented layout stays bounded at {size}");
        }
        control.SelectedIndex = 0; control.Items.Clear();
        check(control.SelectedIndex == -1 && accessible.GetChildCount() == 0, "segmented clear removes selection and accessible children");
        form.Close();
        Designer(check);
    }

    private static void Designer(Action<bool, string> check)
    {
        using var surface = new DesignSurface(typeof(Form));
        var host = (IDesignerHost)surface.GetService(typeof(IDesignerHost))!;
        var control = (KSegmentedControl)host.CreateComponent(typeof(KSegmentedControl), "segments");
        ((Form)host.RootComponent!).Controls.Add(control);
        var first = (KSegmentItem)host.CreateComponent(typeof(KSegmentItem), "firstSegment");
        first.Text = "Opción 1"; first.Value = "one";
        control.Items.Add(first);
        var second = (KSegmentItem)host.CreateComponent(typeof(KSegmentItem), "secondSegment");
        second.Text = "Opción 2"; second.Value = "two"; second.Enabled = false; control.Items.Add(second);
        control.SelectedIndex = 0; control.Orientation = Orientation.Vertical;
        control.SelectedAppearance.Hover.FillColor = Color.Coral; control.ItemSpacing = 9;
        var property = TypeDescriptor.GetProperties(control)[nameof(KSegmentedControl.Items)]!;
        check(property.SerializationVisibility == DesignerSerializationVisibility.Content && property.GetEditor(typeof(UITypeEditor)) is CollectionEditor,
            "segmented designer exposes the standard collection editor");
        check(host.GetDesigner(control) is not null && control.Site!.DesignMode, "segmented designer resolves a control designer on DesignSurface");
        using var grid = new PropertyGrid { SelectedObject = first }; grid.CreateControl();
        TypeDescriptor.GetProperties(first)[nameof(KSegmentItem.Text)]!.SetValue(first, "Editada");
        check(control.Items[0].Text == "Editada", "segmented item properties edit through PropertyGrid descriptors");
        var serializer = new CodeDomComponentSerializationService(surface);
        using var store = serializer.CreateStore();
        serializer.Serialize(store, first); serializer.Serialize(store, second); serializer.Serialize(store, control); store.Close();
        check(store.Errors.Count == 0, "segmented designer serializes its collection without errors");
        using var restored = new Container(); serializer.DeserializeTo(store, restored);
        var copy = restored.Components.OfType<KSegmentedControl>().Single();
        check(copy.Items.Count == 2 && copy.Items[0].Text == "Editada" && copy.Items[0].Value == "one" && !copy.Items[1].Enabled,
            "segmented designer round trip restores item text, values and enabled state");
        check(copy.SelectedIndex == 0 && copy.Orientation == Orientation.Vertical && copy.ItemSpacing == 9 && copy.SelectedAppearance.Hover.FillColor == Color.Coral,
            "segmented designer round trip restores selection, layout and nested appearance");
    }
    private static Point Center(Rectangle r) => new(r.Left + r.Width / 2, r.Top + r.Height / 2);
    private sealed class SelectionModel : INotifyPropertyChanged
    {
        private string? value;
        public string? Value { get => value; set { this.value = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value))); } }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
    private sealed class Probe : KSegmentedControl
    {
        public void KeyDownForTest(Keys key) => OnKeyDown(new KeyEventArgs(key));
        public void KeyUpForTest(Keys key) => OnKeyUp(new KeyEventArgs(key));
        public void Down(Point p) => OnMouseDown(new MouseEventArgs(MouseButtons.Left, 1, p.X, p.Y, 0));
        public void MoveForTest(Point p) => OnMouseMove(new MouseEventArgs(MouseButtons.None, 0, p.X, p.Y, 0));
        public void Up(Point p) => OnMouseUp(new MouseEventArgs(MouseButtons.Left, 1, p.X, p.Y, 0));
    }
    private sealed class TestForm : Form { public bool DialogKey(Keys key) => ProcessDialogKey(key); }
}
