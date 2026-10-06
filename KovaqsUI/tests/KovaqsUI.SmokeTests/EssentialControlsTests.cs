using System.ComponentModel;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using KovaqsUI.Components;
using KovaqsUI.Controls;
using KovaqsUI.Styling;

internal static class EssentialControlsTests
{
    private const BindingFlags Hidden = BindingFlags.Instance | BindingFlags.NonPublic;
    [DllImport("user32.dll")] private static extern IntPtr SendMessage(IntPtr hwnd, uint message, IntPtr wParam, IntPtr lParam);
    [DllImport("user32.dll")] private static extern int GetGuiResources(IntPtr process, uint flags);
    internal static void Run(Action<bool, string> check)
    {
        bool enabled = KAnimationSettings.Enabled;
        try
        {
            KAnimationSettings.Enabled = false;
            Slider(check); Switch(check); Designer(check); Toasts(check); Motion(check); Resources(check); Demo(check);
        }
        finally { KAnimationSettings.Enabled = enabled; }
    }
    private static void Slider(Action<bool, string> check)
    {
        using var form = new Form { ClientSize = new Size(600, 400) };
        using var slider = new SliderProbe { Location = new Point(20, 50), Width = 400, AccessibleName = "Volumen", TabIndex = 1 };
        using var next = new Button { Top = 250, TabIndex = 2 };
        form.Controls.AddRange([slider, next]); form.Show(); Pump(20);
        check(slider.Controls.Count == 0 && slider.TabStop && slider.Value == 0, "slider uses one drawn surface and is a Tab stop");
        int changes = 0; slider.ValueChanged += (_, _) => changes++;
        slider.Value = 25; slider.Value = 25;
        check(changes == 1, "slider ValueChanged fires once for a new value");
        slider.Minimum = 30; check(slider.Value == 30 && changes == 2, "slider clamps and notifies when its range shrinks");
        slider.Maximum = 10; check(slider.Minimum == 10 && slider.Value == 10, "slider repairs crossed range bounds");
        slider.Down(new Point(300, 10)); slider.Up(new Point(300, 10));
        check(slider.Value == 10, "slider degenerate range remains stable under input");
        slider.Minimum = int.MinValue; slider.Maximum = int.MaxValue; slider.Value = 0;
        slider.SmallChange = int.MaxValue; slider.Key(Keys.Right); slider.Key(Keys.Right);
        check(slider.Value == int.MaxValue, "slider handles full integer range without step overflow");
        slider.Key(Keys.Home); check(slider.Value == int.MinValue, "slider Home reaches Minimum");
        slider.Key(Keys.End); check(slider.Value == int.MaxValue, "slider End reaches Maximum");
        slider.Minimum = 0; slider.Maximum = 100; slider.SmallChange = 2; slider.LargeChange = 20; slider.Value = 50;
        slider.Key(Keys.PageUp); slider.Key(Keys.Left); check(slider.Value == 68, "slider PageUp and arrow use separate increments");
        check(Throws<ArgumentOutOfRangeException>(() => slider.Value = 101) && Throws<ArgumentOutOfRangeException>(() => slider.SmallChange = 0), "slider rejects invalid explicit values and steps");
        slider.Down(new Point(399, 18)); slider.Up(new Point(399, 18)); check(slider.Value == 100, "slider track click selects its endpoint");
        slider.Value = 50; var center = Center(slider.ThumbBounds);
        slider.Down(new Point(center.X + 3, center.Y)); slider.MoveTo(new Point(center.X + 3, center.Y));
        check(slider.Value == 50 && slider.Capture, "slider dragging preserves the point grabbed inside the thumb");
        slider.MoveTo(new Point(-200, center.Y)); slider.Up(new Point(-200, center.Y)); check(slider.Value == 0 && !slider.Capture, "slider clamps drag outside its bounds and releases capture");
        slider.RightToLeft = RightToLeft.Yes; slider.Value = 0;
        check(slider.ThumbBounds.Left > 300, "slider horizontal RTL mirrors the minimum endpoint");
        slider.Key(Keys.Left); check(slider.Value == 2, "slider RTL arrow follows visual direction");
        slider.Orientation = Orientation.Vertical; slider.Size = new Size(40, 180); slider.Value = 0;
        check(slider.ThumbBounds.Top > 140, "slider vertical minimum is at the bottom regardless of RTL");
        slider.Key(Keys.Up); check(slider.Value == 2, "slider vertical Up increases value");
        slider.Down(new Point(20, 0)); slider.Up(new Point(20, 0)); check(slider.Value == 100, "slider vertical mouse mapping reaches Maximum");
        slider.Enabled = false; slider.Key(Keys.Home); slider.Down(Point.Empty); check(slider.Value == 100 && !slider.Capture, "slider disabled ignores keyboard and mouse"); slider.Enabled = true;
        check(slider.AccessibilityObject.Role == AccessibleRole.Slider && slider.AccessibilityObject.Name == "Volumen", "slider publishes accessible role and name");
        slider.AccessibilityObject.Value = "42"; check(slider.Value == 42, "slider accessibility exposes and updates its value");
        slider.Focus(); form.SelectNextControl(slider, true, true, true, true); check(next.Focused, "slider allows normal Tab navigation to next control");
        var model = new Model { Number = 30 };
        slider.DataBindings.Add(nameof(KSlider.Value), model, nameof(Model.Number), false, DataSourceUpdateMode.OnPropertyChanged);
        slider.Value = 60; check(model.Number == 60, "slider ValueChanged updates data binding");
        model.Number = 20; slider.DataBindings[0].ReadValue(); check(slider.Value == 20, "slider binding reads model updates"); slider.DataBindings.Clear();
        foreach (var size in new[] { new Size(1, 1), new Size(14, 10), new Size(40, 280), new Size(500, 36) })
        {
            slider.Size = size; slider.Padding = new Padding(20); Paint(slider);
            check(slider.ThumbBounds.Width >= 0 && slider.ThumbBounds.Height >= 0, $"slider clips safely at {size}");
        }
        form.Close();
    }
    private static void Switch(Action<bool, string> check)
    {
        using var form = new Form(); using var toggle = new SwitchProbe { Text = "&Activar", AutoSize = true };
        form.Controls.Add(toggle); form.Show(); Pump(20);
        int changes = 0; toggle.CheckedChanged += (_, _) => changes++;
        toggle.Checked = true; toggle.Checked = true; check(changes == 1, "switch preserves native CheckedChanged semantics");
        toggle.Focus(); SendMessage(toggle.Handle, 0x100, (IntPtr)Keys.Space, IntPtr.Zero); SendMessage(toggle.Handle, 0x101, (IntPtr)Keys.Space, IntPtr.Zero);
        check(!toggle.Checked && changes == 2, "switch Space uses native CheckBox activation");
        toggle.ClickForTest(); check(toggle.Checked && changes == 3, "switch native Click toggles once");
        toggle.AutoCheck = false; toggle.ClickForTest(); check(toggle.Checked && changes == 3, "switch preserves AutoCheck=false"); toggle.AutoCheck = true;
        check(toggle.Mnemonic('a') && !toggle.Checked, "switch mnemonic uses native behavior");
        check(toggle.AccessibilityObject.Role == AccessibleRole.CheckButton, "switch keeps native checkbox accessibility");
        check(Throws<ArgumentException>(() => toggle.ThreeState = true), "switch disallows a third state in its public API");
        toggle.Checked = true; toggle.Enabled = false; Paint(toggle);
        check(toggle.Checked && toggle.Controls.Count == 0, "switch disabled keeps selected state and uses one surface"); toggle.Enabled = true;
        toggle.AppearanceStates.Normal.ForeColor = Color.Coral; check(toggle.ForeColor == Color.Coral, "switch normal appearance synchronizes ForeColor");
        toggle.ForeColor = Color.Teal; check(toggle.AppearanceStates.Normal.ForeColor == Color.Teal, "switch ForeColor updates nested appearance");
        toggle.ResetForeColor(); toggle.Theme = KTheme.Dark; form.BackColor = KTheme.Dark.Background; Paint(toggle);
        var resolved = typeof(KSwitch).GetMethod("Resolve", Hidden)!.Invoke(toggle, [toggle.CheckedAppearance, KTheme.Dark.Primary, KTheme.Dark.TextPrimary])!;
        check((Color)resolved.GetType().GetProperty("Text")!.GetValue(resolved)! == KTheme.Dark.TextPrimary, "switch dark theme resolves readable text");
        toggle.Enabled = false; toggle.CheckedAppearance.Disabled.ForeColor = Color.Orange;
        resolved = typeof(KSwitch).GetMethod("Resolve", Hidden)!.Invoke(toggle, [toggle.CheckedAppearance, KTheme.Dark.Primary, KTheme.Dark.TextPrimary])!;
        check((Color)resolved.GetType().GetProperty("Text")!.GetValue(resolved)! == Color.Orange, "switch disabled text honors local appearance");
        foreach (var flat in Enum.GetValues<FlatStyle>()) { toggle.FlatStyle = flat; Paint(toggle); }
        check(toggle.Font.Name.StartsWith("Inter"), "switch uses embedded typography across native flat styles");
        toggle.AutoSize = false;
        foreach (var size in new[] { new Size(1, 1), new Size(20, 12), new Size(240, 70) }) { toggle.Size = size; toggle.ThumbInset = 100; Paint(toggle); }
        check(true, "switch extreme inset and small bounds paint without invalid geometry");
        form.Close();
    }
    private static void Designer(Action<bool, string> check)
    {
        using var surface = new DesignSurface(typeof(Form));
        var host = (IDesignerHost)surface.GetService(typeof(IDesignerHost))!;
        var owner = (Form)host.RootComponent!;
        owner.Site!.Name = "owner";
        var slider = (KSlider)host.CreateComponent(typeof(KSlider), "slider");
        var toggle = (KSwitch)host.CreateComponent(typeof(KSwitch), "toggle");
        var notifier = (KToastNotifier)host.CreateComponent(typeof(KToastNotifier), "notifier");
        owner.Controls.AddRange([slider, toggle]); notifier.OwnerForm = owner;
        slider.Minimum = -50; slider.Maximum = -10; slider.Value = -25; slider.Orientation = Orientation.Vertical; slider.ThumbAppearance.Pressed.FillColor = Color.Coral;
        toggle.Checked = true; toggle.SwitchSize = new Size(60, 28); toggle.CheckedAppearance.Normal.FillColor = Color.Teal;
        notifier.Position = KToastPosition.TopCenter; notifier.Duration = 2500; notifier.ErrorAppearance.ForeColor = Color.Maroon;
        using var grid = new PropertyGrid();
        foreach (var component in new IComponent[] { slider, toggle, notifier })
        {
            grid.SelectedObject = component; grid.CreateControl();
            check(host.GetDesigner(component) is not null && component.Site!.DesignMode, $"{component.GetType().Name} has a designer and property-grid support");
            check(((ToolboxItemAttribute)TypeDescriptor.GetAttributes(component)[typeof(ToolboxItemAttribute)]!).ToolboxItemType is not null, $"{component.GetType().Name} is available in Toolbox");
        }
        check(Throws<InvalidOperationException>(() => notifier.Show("Design", "No popup")), "toast component cannot open windows in designer");
        var serializer = new CodeDomComponentSerializationService(surface);
        using var store = serializer.CreateStore();
        serializer.Serialize(store, notifier); serializer.Serialize(store, slider); serializer.Serialize(store, toggle); store.Close();
        check(store.Errors.Count == 0, "essential components serialize with CodeDOM without errors");
        using var restored = new Container();
        // CodeDOM resolves the design root as an existing component, as Visual Studio does.
        restored.Add(new Form(), owner.Site!.Name);
        restored.Add(new KToastNotifier(), "notifier");
        serializer.DeserializeTo(store, restored);
        var s = restored.Components.OfType<KSlider>().Single(); var t = restored.Components.OfType<KSwitch>().Single(); var n = restored.Components.OfType<KToastNotifier>().Single();
        check(s.Minimum == -50 && s.Maximum == -10 && s.Value == -25 && s.Orientation == Orientation.Vertical && s.ThumbAppearance.Pressed.FillColor == Color.Coral, "slider designer round trip preserves negative range, value and nested states");
        check(t.Checked && t.SwitchSize.Width == 60 && t.CheckedAppearance.Normal.FillColor == Color.Teal, "switch designer round trip preserves checked, geometry and styles");
        check(store.Errors.Count == 0, "essential components restore without CodeDOM errors");
        check(n.OwnerForm == restored.Components.OfType<Form>().Single() && n.Position == KToastPosition.TopCenter && n.Duration == 2500 && n.ErrorAppearance.ForeColor == Color.Maroon, "toast designer round trip preserves owner reference and appearance");
    }
    private static void Toasts(Action<bool, string> check)
    {
        using var form = new Form { ClientSize = new Size(700, 500), StartPosition = FormStartPosition.CenterScreen };
        using var input = new TextBox(); form.Controls.Add(input); form.Show(); input.Focus(); Pump(20);
        using var container = new Container(); var notifier = new KToastNotifier(container) { OwnerForm = form, Duration = 0, MaximumVisible = 2 };
        var first = notifier.Show("Primero", "Mensaje", KToastKind.Success);
        var second = notifier.Show("Segundo", "Mensaje", KToastKind.Warning);
        var third = notifier.Show("Tercero", "Mensaje", KToastKind.Error);
        check(notifier.ActiveCount == 2 && notifier.PendingCount == 1, "toasts cap simultaneous windows and queue remaining entries");
        check(form.ActiveControl == input && input.Focused, "toasts do not steal input focus");
        var windows = ToastWindows(form);
        check(!windows[0].Bounds.IntersectsWith(windows[1].Bounds), "toast stack never overlaps");
        check(windows.All(w => w.AccessibilityObject.Role == AccessibleRole.Alert && !w.ShowInTaskbar), "toasts expose alerts without taskbar windows");
        foreach (var position in Enum.GetValues<KToastPosition>())
        {
            notifier.Position = position; windows = ToastWindows(form);
            var client = Rectangle.Intersect(form.RectangleToScreen(form.ClientRectangle), Screen.FromControl(form).WorkingArea);
            check(windows.All(w => client.Contains(w.Bounds)) && !windows[0].Bounds.IntersectsWith(windows[1].Bounds), $"toast {position} stays inside owner and working area");
        }
        notifier.Close(first); check(notifier.ActiveCount == 2 && notifier.PendingCount == 0 && ToastWindows(form).Any(w => w.AccessibleName!.StartsWith("Tercero")), "closing toast promotes oldest queued notification");
        check(!notifier.Close(first), "closing an unknown toast is harmless");
        notifier.CloseAll(); check(notifier.ActiveCount == 0 && notifier.PendingCount == 0 && ToastWindows(form).Length == 0, "CloseAll disposes visible and queued entries");
        notifier.Capacity = 2; notifier.MaximumVisible = 1; first = notifier.Show("Uno", ""); second = notifier.Show("Dos", "");
        check(Throws<InvalidOperationException>(() => notifier.Show("Tres", "")) && notifier.PendingCount == 1, "toast capacity is bounded and rejects overflow without losing existing items");
        notifier.Close(second); check(notifier.PendingCount == 0, "queued toast can be cancelled by ID");
        form.Hide(); Pump(20); check(notifier.ActiveCount == 0 && notifier.PendingCount == 1, "hidden owner suspends toast windows without losing queue");
        form.Show(); Pump(20); check(notifier.ActiveCount == 1, "owner restore shows suspended toast");
        form.ClientSize = new Size(90, 70); Pump(20); check(notifier.ActiveCount == 0, "insufficient owner area queues notifications");
        form.ClientSize = new Size(700, 500); Pump(20); check(notifier.ActiveCount == 1, "owner resize promotes waiting toast");
        notifier.CloseAll(); notifier.Capacity = 100; notifier.MaximumVisible = 3;
        var failure = Task.Run(() => { try { notifier.Show("Worker", ""); return false; } catch (InvalidOperationException) { return true; } }).GetAwaiter().GetResult();
        check(failure && notifier.ActiveCount == 0, "toast cross-thread access fails explicitly before queue mutation");
        notifier.Show("Temporal", "Se cierra", duration: 65); Pump(160); check(notifier.ActiveCount == 0, "toast expires automatically via shared UI clock");
        notifier.Show("Persistente", "No expira", duration: 0); Pump(120); check(notifier.ActiveCount == 1, "zero-duration toast remains visible");
        var close = ToastWindows(form).Single().AccessibilityObject.GetChild(0)!; close.DoDefaultAction(); check(notifier.ActiveCount == 0, "toast accessible close action removes window");
        using var icon = new Bitmap(20, 20); notifier.Show("Personalizado", "Mensaje largo " + new string('x', 600), icon: icon);
        notifier.ShowCloseButton = false; notifier.Theme = KTheme.Dark; notifier.Appearance.FillColor = Color.FromArgb(44, 49, 54); notifier.CornerRadius = 32;
        var window = ToastWindows(form).Single(); Paint(window);
        check(window.Height <= notifier.MaximumHeight * form.DeviceDpi / 96f && window.AccessibilityObject.GetChildCount() == 0, "toast long content is bounded and close button can be hidden");
        using var secondOwner = new Form { ClientSize = new Size(500, 400) }; secondOwner.Show();
        using var other = new KToastNotifier { OwnerForm = secondOwner, Duration = 0 }; other.Show("Otra ventana", "Independiente");
        check(notifier.ActiveCount == 1 && other.ActiveCount == 1 && ToastWindows(secondOwner).Length == 1, "independent owners maintain independent notification queues");
        secondOwner.Close(); check(other.ActiveCount == 0 && other.PendingCount == 0, "owner close removes notifications");
        notifier.MaximumVisible = 1; notifier.Show("En cola", ""); form.Close();
        check(notifier.ActiveCount == 0 && notifier.PendingCount == 0 && icon.Width == 20, "owner disposal clears queued toasts without disposing caller images");
        container.Dispose(); check(Throws<ObjectDisposedException>(() => notifier.Show("Disposed", "")), "component container owns notifier lifecycle");
    }
    private static void Motion(Action<bool, string> check)
    {
        KAnimationSettings.Enabled = true;
        using var form = new Form { ClientSize = new Size(500, 380) }; using var toggle = new KSwitch(); form.Controls.Add(toggle); form.Show(); Pump(30);
        toggle.Animation.Duration = 250; toggle.Animation.Easing = KEasing.Linear; toggle.Checked = true; toggle.Refresh(); Pump(55);
        float progress = Scalar(toggle, "motion"); check(progress > 0 && progress < 1, "switch thumb moves through intermediate positions");
        toggle.Checked = false; toggle.Refresh(); float reversed = Scalar(toggle, "motion"); check(Math.Abs(progress - reversed) < .15, "switch reverses from its current position without jumping");
        toggle.Animation.Enabled = false; toggle.Checked = true; toggle.Refresh(); check(Scalar(toggle, "motion") == 1, "switch animation can be disabled immediately");
        using var notifier = new KToastNotifier { OwnerForm = form, Duration = 0 }; notifier.Animation.Duration = 180; notifier.Animation.Easing = KEasing.Linear;
        var id = notifier.Show("Animado", "Transición breve"); Pump(70); var window = ToastWindows(form).Single();
        check(window.Opacity > .01 && window.Opacity < 1, "toast fade-in has intermediate opacity"); Pump(200);
        notifier.Close(id); Pump(55); check(notifier.ActiveCount == 1 && window.Opacity < 1, "toast close fades before disposing"); Pump(220);
        check(notifier.ActiveCount == 0 && window.IsDisposed, "toast fade-out finishes and disposes its window");
        notifier.Show("Sin movimiento", ""); KAnimationSettings.Enabled = false; Pump(40); window = ToastWindows(form).Single();
        check(window.Opacity == 1, "global motion preference stops toast fade immediately"); notifier.CloseAll(); form.Close();
        check(ClockCount() == 0, "all animation and lifetime callbacks stop after closure");
    }
    private static void Resources(Action<bool, string> check)
    {
        using var form = new Form { ClientSize = new Size(500, 380) }; form.Show();
        int before = GetGuiResources(Process.GetCurrentProcess().Handle, 0);
        for (int i = 0; i < 35; i++)
        {
            using var notifier = new KToastNotifier { OwnerForm = form, Duration = 0 };
            using var slider = new KSlider(); using var toggle = new KSwitch(); form.Controls.AddRange([slider, toggle]);
            foreach (var kind in Enum.GetValues<KToastKind>()) notifier.Show(kind.ToString(), "Prueba", kind);
            foreach (var window in ToastWindows(form)) Paint(window);
            Paint(slider); Paint(toggle); notifier.CloseAll();
        }
        Pump(40);
        check(GetGuiResources(Process.GetCurrentProcess().Handle, 0) <= before + 12 && ToastWindows(form).Length == 0, "repeated creation and rendering releases GDI objects and owned windows");
        form.Close();
    }
    private static void Demo(Action<bool, string> check)
    {
        var type = typeof(KovaqsUI.Demo.DesignerSandbox).Assembly.GetType("KovaqsUI.Demo.EssentialsDemoForm")!;
        using var form = (Form)Activator.CreateInstance(type)!; form.Show(); Pump(30);
        check(Descendants(form).OfType<KSlider>().Count() == 4 && Descendants(form).OfType<KSwitch>().Count() == 5, "essentials demo includes orientations, dimensions and disabled variants");
        var notifier = (KToastNotifier)type.GetField("notifier", Hidden)!.GetValue(form)!;
        check(notifier.OwnerForm == form, "demo toast component is attached to its form");
        var position = Descendants(form).OfType<KComboBox>().Single();
        check(Equals(position.SelectedItem, notifier.Position), "demo position selector agrees with notifier on first display");
        position.SelectedItem = KToastPosition.TopCenter;
        check(notifier.Position == KToastPosition.TopCenter, "demo position selector updates notifier");
        type.GetMethod("ApplyDark", Hidden)!.Invoke(form, null); Paint(form);
        check(notifier.Theme == KTheme.Dark && Descendants(form).OfType<KSwitch>().All(s => s.Theme == KTheme.Dark), "demo theme changes include nonvisual notifier");
        form.Size = form.MinimumSize; Paint(form); form.Close();
    }
    private static IEnumerable<Control> Descendants(Control control) { foreach (Control child in control.Controls) { yield return child; foreach (var nested in Descendants(child)) yield return nested; } }
    private static float Scalar(object control, string field) { var scalar = control.GetType().GetField(field, Hidden)!.GetValue(control)!; return (float)scalar.GetType().GetProperty("Value", Hidden)!.GetValue(scalar)!; }
    private static int ClockCount() { var type = typeof(KSlider).Assembly.GetType("KovaqsUI.Core.KAnimationClock")!; return (type.GetField("callbacks", BindingFlags.Static | BindingFlags.NonPublic)!.GetValue(null) as System.Collections.Generic.HashSet<System.Action>)?.Count ?? 0; }
    private static Form[] ToastWindows(Form owner) => owner.OwnedForms.Where(f => f.GetType().Name == "KToastWindow" && !f.IsDisposed).ToArray();
    private static bool Throws<T>(System.Action action) where T : Exception { try { action(); return false; } catch (T) { return true; } }
    private static Point Center(Rectangle r) => new(r.Left + r.Width / 2, r.Top + r.Height / 2);
    private static void Paint(Control c) { using var bitmap = new Bitmap(Math.Max(1, c.Width), Math.Max(1, c.Height)); c.DrawToBitmap(bitmap, new Rectangle(Point.Empty, c.Size)); }
    private static void Pump(int ms) { var watch = Stopwatch.StartNew(); do { Application.DoEvents(); Thread.Sleep(4); } while (watch.ElapsedMilliseconds < ms); }
    private sealed class SliderProbe : KSlider
    {
        internal void Key(Keys key) => OnKeyDown(new KeyEventArgs(key));
        internal void Down(Point p) => OnMouseDown(new MouseEventArgs(MouseButtons.Left, 1, p.X, p.Y, 0));
        internal void MoveTo(Point p) => OnMouseMove(new MouseEventArgs(MouseButtons.Left, 0, p.X, p.Y, 0));
        internal void Up(Point p) => OnMouseUp(new MouseEventArgs(MouseButtons.Left, 1, p.X, p.Y, 0));
    }
    private sealed class SwitchProbe : KSwitch { internal void ClickForTest() => OnClick(EventArgs.Empty); internal bool Mnemonic(char c) => ProcessMnemonic(c); }
    private sealed class Model : INotifyPropertyChanged
    {
        private int number; public int Number { get => number; set { number = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Number))); } }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
