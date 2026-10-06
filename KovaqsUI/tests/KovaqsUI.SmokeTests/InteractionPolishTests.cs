using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using KovaqsUI.Controls;
using KovaqsUI.Styling;

internal static class InteractionPolishTests
{
    [DllImport("user32.dll")] private static extern IntPtr SendMessage(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);
    internal static void Run(Action<bool, string> check)
    {
        KAnimationSettings.Enabled = true;
        try { Segments(check); Buttons(check); Fields(check); }
        finally { KAnimationSettings.Enabled = false; }
    }
    private static void Segments(Action<bool, string> check)
    {
        using var form = new Form { BackColor = Color.Magenta, ClientSize = new Size(600, 400) };
        using var control = new KSegmentedControl { Size = new Size(480, 64), BackColor = Color.Magenta,
            FillColor = Color.Gray, SelectedFillColor = Color.White };
        control.Items.AddRange(new KSegmentItem(), new KSegmentItem(), new KSegmentItem());
        control.Animation.Duration = 400; control.Animation.Easing = KEasing.Linear; control.SelectedIndex = 0;
        form.Controls.Add(control); form.Show(); Pump(40);
        check(!control.FocusAppearance.Visible && control.FocusAppearance.Inset == 0 && control.FocusAppearance.Thickness == 0
            && control.FocusAppearance.Color.IsEmpty && TypeDescriptor.GetProperties(control.FocusAppearance).Cast<PropertyDescriptor>()
                .All(p => !p.ShouldSerializeValue(control.FocusAppearance)), "segmented focus has no initial stroke, inset, color or serialized override");
        var initial = WhiteBounds(control);
        control.SelectedIndex = 2; var firstFrame = WhiteBounds(control); Pump(120); var middle = WhiteBounds(control);
        check(Math.Abs(firstFrame.Left - initial.Left) < 10 && middle.Left > initial.Left + 10 && middle.Left < control.GetItemBounds(2).Left - 10,
            "segmented pill travels through intermediate horizontal positions");
        check(middle.Width <= control.GetItemBounds(0).Width, "segmented animation paints one pill without a ghost at the previous selection");
        control.SelectedIndex = 0; var reverse = WhiteBounds(control);
        check(Math.Abs(reverse.Left - middle.Left) < 12, "segmented rapid retarget begins at current visual position");
        Pump(450); check(Math.Abs(WhiteBounds(control).Left - initial.Left) < 3, "segmented pill reaches exact target after reversing");
        control.Orientation = Orientation.Vertical; control.Size = new Size(220, 330); WhiteBounds(control);
        control.SelectedIndex = 2; WhiteBounds(control); Pump(110);
        var vertical = WhiteBounds(control);
        check(vertical.Top > control.GetItemBounds(0).Top + 10 && vertical.Top < control.GetItemBounds(2).Top - 10,
            "segmented pill animates along vertical orientation");
        control.Animation.Enabled = false;
        check(Math.Abs(WhiteBounds(control).Top - control.GetItemBounds(2).Top) < 3, "segmented motion switch snaps current movement to selected option");
        control.Orientation = Orientation.Horizontal; control.Size = new Size(480, 64); control.RightToLeft = RightToLeft.Yes;
        control.SelectedIndex = 0;
        check(Math.Abs(WhiteBounds(control).Left - control.GetItemBounds(0).Left) < 3, "segmented pill follows RTL layout after orientation and size changes");
        control.Items[1].Text = "Una opción más larga"; control.ItemSizeMode = KSegmentSizeMode.Content; control.SelectedIndex = 1;
        check(Math.Abs(WhiteBounds(control).Width - control.GetItemBounds(1).Width) < 4, "segmented pill adapts to content-based segment widths");
        control.SelectedIndex = -1;
        check(WhiteBounds(control).IsEmpty, "segmented clearing selection removes the animated surface");
        form.Close();
    }
    private static void Buttons(Action<bool, string> check)
    {
        using var form = new Form();
        using var button = new ButtonProbe { Size = new Size(200, 60), Text = "", FillColor = Color.Black, ForeColor = Color.White,
            BorderThickness = 0, CornerRadius = 0, ClickOpacity = 180, PressOpacity = 0 };
        button.Appearance.Disabled.FillColor = Color.Black;
        button.Animation.Duration = 400; button.Animation.Easing = KEasing.Linear;
        form.Controls.Add(button); form.Show(); Pump(30);
        button.ClickAt(new Point(12, 30));
        Pump(90);
        using (var image = Render(button))
            check(image.GetPixel(12, 30).R > 0 && image.GetPixel(160, 30).R == 0, "button click wave starts at the pointer location supplied by Click");
        button.ClickAnimation = false;
        using (var image = Render(button)) check(image.GetPixel(12, 30).R == 0, "button ClickAnimation=false cancels an in-flight wave immediately");
        button.ClickAnimation = true; button.PerformClick(); Pump(80); button.Enabled = false;
        using (var image = Render(button)) check(image.GetPixel(100, 30).R == 0, "button disabling cancels an in-flight wave");
        button.Enabled = true; button.PerformClick(); Pump(60); button.Hide(); button.Show();
        using (var image = Render(button)) check(image.GetPixel(100, 30).R == 0, "button hidden and shown does not resurrect previous click wave");
        button.PerformClick(); Pump(80); button.Animation.Duration = 0;
        using (var image = Render(button)) check(image.GetPixel(100, 30).R == 0, "button duration zero suppresses current wave without waiting for a timer tick");
        button.Animation.Duration = 200; button.ClickAnimation = false; button.PressOpacity = 255;
        button.Animation.Enabled = false;
        int clicks = 0; button.Click += (_, _) => clicks++;
        var down = new IntPtr(30 << 16 | 20);
        SendMessage(button.Handle, 0x201, new IntPtr(1), down);
        using (var image = Render(button)) check(image.GetPixel(100, 30).R == 255, "native mouse down applies button pressed feedback");
        button.MoveForTest(new Point(260, 30));
        using (var image = Render(button)) check(image.GetPixel(100, 30).R == 0, "button drag outside removes pressure while retaining capture");
        button.MoveForTest(new Point(20, 30));
        using (var image = Render(button)) check(image.GetPixel(100, 30).R == 255, "button drag back inside restores pressure");
        SendMessage(button.Handle, 0x202, IntPtr.Zero, new IntPtr(30 << 16 | 260));
        check(clicks == 0, "button release outside cancels native click");
        using (var image = Render(button)) check(image.GetPixel(100, 30).R == 0, "button release outside clears pressure");
        button.Animation.Enabled = true; button.ClickAnimation = true; button.PressOpacity = 0;
        button.ClickAt(new Point(20, 30)); Pump(30);
        button.ClickAt(new Point(170, 30));
        var origin = (PointF)typeof(KButton).GetField("clickOrigin", BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(button)!;
        check(origin == new PointF(170, 30) && clicks == 2, "rapid clicks restart one wave at latest origin without duplicating Click");
        button.ClickAnimation = false;
        SendMessage(button.Handle, 0x201, new IntPtr(1), down);
        button.Capture = false;
        using (var image = Render(button)) check(image.GetPixel(100, 30).R == 0, "button losing native capture cancels pressure");
        button.ClickAnimation = true; button.PerformClick(); Pump(30); KAnimationSettings.Enabled = false;
        using (var image = Render(button)) check(image.GetPixel(100, 30).R == 0, "global motion preference suppresses current button ripple immediately");
        KAnimationSettings.Enabled = true;
        form.Close();
    }
    private static void Fields(Action<bool, string> check)
    {
        using var form = new Form { ClientSize = new Size(620, 400) };
        using var icon = new Bitmap(18, 18);
        using (var g = Graphics.FromImage(icon)) g.Clear(Color.Coral);
        using var field = new KTextBox { Text = "Texto de prueba", IconLeft = icon, IconRight = icon };
        field.Animation.Enabled = false;
        form.Controls.Add(field); form.Show(); Application.DoEvents();
        foreach (bool multiline in new[] { false, true })
        foreach (var size in new[] { new Size(1, 1), new Size(24, 16), new Size(110, 28), new Size(320, 100) })
        {
            field.Multiline = multiline; field.Size = size;
            using var image = Render(field);
            check(field.Editor.Left >= 0 && field.Editor.Top >= 0 && field.Editor.Right <= field.Width && field.Editor.Bottom <= field.Height,
                $"text native editor remains inside frame at {size}, multiline={multiline}");
        }
        field.Size = new Size(300, 90); field.Multiline = false; field.Editor.Multiline = true;
        check(field.Editor.Height == field.Height - field.Padding.Vertical, "text direct native Multiline change updates frame layout");
        field.Editor.Multiline = false;
        using var largeFont = new Font("Arial", 22);
        field.Editor.Font = largeFont;
        check(field.Editor.Height == field.Editor.PreferredHeight && field.Editor.Top == (field.Height - field.Editor.Height) / 2,
            "text direct native font change recenters the editor");
        using var bodyFont = KTypography.Body;
        field.Font = bodyFont;
        foreach (var mode in new[] { "normal", "readonly", "password", "multiline", "rtl", "disabled" })
        {
            field.ReadOnly = mode == "readonly"; field.UseSystemPasswordChar = mode == "password";
            field.Multiline = mode == "multiline"; field.RightToLeft = mode == "rtl" ? RightToLeft.Yes : RightToLeft.No;
            field.Enabled = mode != "disabled"; field.Text = mode == "multiline" ? "Primera\r\nSegunda" : "Texto de prueba";
            field.Select(1, 3); var handle = field.Editor.Handle;
            field.Theme = KTheme.Dark; field.Appearance.Hover.FillColor = Color.Navy;
            using var image = Render(field);
            check(field.Editor.Handle == handle && field.SelectionStart == 1 && field.SelectionLength == 3,
                $"text {mode} preserves native editor and selection across repaint/theme changes");
        }
        form.Close();
    }
    private static Bitmap Render(Control c) { var image = new Bitmap(c.Width, c.Height); c.DrawToBitmap(image, c.ClientRectangle); return image; }
    private sealed class ButtonProbe : KButton
    {
        internal void ClickAt(Point point) => OnClick(new MouseEventArgs(MouseButtons.Left, 1, point.X, point.Y, 0));
        internal void MoveForTest(Point point) => OnMouseMove(new MouseEventArgs(MouseButtons.Left, 0, point.X, point.Y, 0));
    }
    private static Rectangle WhiteBounds(Control c)
    {
        using var image = Render(c);
        int left = image.Width, top = image.Height, right = -1, bottom = -1;
        for (int y = 0; y < image.Height; y++) for (int x = 0; x < image.Width; x++)
            if (image.GetPixel(x, y).ToArgb() == Color.White.ToArgb()) { left = Math.Min(left, x); top = Math.Min(top, y); right = Math.Max(right, x); bottom = Math.Max(bottom, y); }
        return right < 0 ? Rectangle.Empty : Rectangle.FromLTRB(left, top, right + 1, bottom + 1);
    }
    private static void Pump(int ms) { var watch = Stopwatch.StartNew(); while (watch.ElapsedMilliseconds < ms) { Application.DoEvents(); Thread.Sleep(5); } }
}
