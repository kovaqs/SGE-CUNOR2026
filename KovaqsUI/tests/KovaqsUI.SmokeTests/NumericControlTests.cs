using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using KovaqsUI.Controls;

internal static class NumericControlTests
{
    internal static void Run(Action<bool, string> check)
    {
        using var form = new Form();
        using var numeric = new Probe { Minimum = -2, Maximum = 2, Increment = .25m, DecimalPlaces = 2 };
        form.Controls.Add(numeric); form.Show(); numeric.Focus(); Application.DoEvents();
        check(numeric.Controls.Count == 0, "numeric is one painted control without child buttons or label");
        int changes = 0; numeric.ValueChanged += (_, _) => changes++;
        numeric.UpButton(); numeric.UpButton(); numeric.DownButton();
        check(numeric.Value == .25m && changes == 3, "numeric decimal increment and notifications are exact");
        numeric.Value = 2; changes = 0; numeric.UpButton();
        check(numeric.Value == 2 && changes == 0, "numeric at maximum suppresses duplicate changes");
        numeric.Key(Keys.Home); numeric.Key(Keys.Up);
        check(numeric.Value == -1.75m, "numeric keyboard uses range and increment");
        numeric.Key(Keys.End); numeric.Wheel(-120);
        check(numeric.Value == 1.75m, "numeric focused wheel steps value");
        numeric.Down(new Point(10, numeric.Height / 2)); numeric.Up();
        check(numeric.Value == 1.5m, "numeric left zone decrements");
        numeric.RightToLeft = RightToLeft.Yes;
        numeric.Down(new Point(10, numeric.Height / 2)); numeric.Up();
        check(numeric.Value == 1.75m, "numeric RTL mirrors action zones");
        numeric.Enabled = false; numeric.UpButton(); numeric.Key(Keys.Down);
        check(numeric.Value == 1.75m, "numeric disabled state blocks actions");
        numeric.Enabled = true;
        numeric.AccessibilityObject.GetChild(1)!.DoDefaultAction();
        check(numeric.Value == 2 && numeric.AccessibilityObject.Role == AccessibleRole.SpinButton
            && numeric.AccessibilityObject.GetChild(1)!.State.HasFlag(AccessibleStates.Unavailable), "numeric accessibility exposes value and bounded actions");
        numeric.Maximum = 1;
        check(numeric.Value == 1, "numeric reduced maximum clamps current value");
        numeric.Minimum = decimal.MinValue; numeric.Maximum = decimal.MaxValue; numeric.Increment = decimal.MaxValue;
        numeric.Value = 1; numeric.UpButton();
        check(numeric.Value == decimal.MaxValue, "numeric increment handles decimal overflow safely");
        foreach (var size in new[] { new Size(1, 1), new Size(90, 28), new Size(232, 58), new Size(400, 90) })
        {
            numeric.Size = size;
            using var image = new Bitmap(size.Width, size.Height); numeric.DrawToBitmap(image, numeric.ClientRectangle);
            check(numeric.Size == size && numeric.Controls.Count == 0, $"numeric supports overall size {size} without adding button controls");
        }
        using var surface = new DesignSurface(typeof(Form));
        var host = (IDesignerHost)surface.GetService(typeof(IDesignerHost))!;
        var designed = (KNumericUpDown)host.CreateComponent(typeof(KNumericUpDown), "quantity");
        designed.Minimum = -10; designed.Maximum = 500; designed.Value = 125.5m; designed.DecimalPlaces = 1;
        designed.Size = new Size(280, 70); designed.Appearance.Hover.FillColor = Color.Coral;
        var serializer = new CodeDomComponentSerializationService(surface);
        using var store = serializer.CreateStore(); serializer.Serialize(store, designed); store.Close();
        using var container = new Container(); serializer.DeserializeTo(store, container);
        var copy = container.Components.OfType<KNumericUpDown>().Single();
        check(store.Errors.Count == 0 && copy.Value == 125.5m && copy.Minimum == -10 && copy.Maximum == 500
            && copy.Size == designed.Size && copy.Appearance.Hover.FillColor == Color.Coral, "numeric designer round trip preserves range, value, size and appearance");
        form.Close();
    }
    private sealed class Probe : KNumericUpDown
    {
        internal void Key(Keys key) => OnKeyDown(new KeyEventArgs(key));
        internal void Wheel(int delta) => OnMouseWheel(new HandledMouseEventArgs(MouseButtons.None, 0, 0, 0, delta));
        internal void Down(Point point) => OnMouseDown(new MouseEventArgs(MouseButtons.Left, 1, point.X, point.Y, 0));
        internal void Up() => OnMouseUp(new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
    }
}
