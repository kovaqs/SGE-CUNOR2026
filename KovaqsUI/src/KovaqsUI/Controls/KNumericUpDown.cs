using System.ComponentModel;
using System.Globalization;
using KovaqsUI.Core;
using KovaqsUI.Drawing;
using KovaqsUI.Styling;

namespace KovaqsUI.Controls;

/// <summary>A single painted numeric stepper with one exterior border and no child buttons.</summary>
[ToolboxItem(true), DefaultProperty(nameof(Value)), DefaultEvent(nameof(ValueChanged)), DefaultBindingProperty(nameof(Value))]
public class KNumericUpDown : Control, IKThemeControl
{
    private decimal value, minimum, maximum = 100, increment = 1;
    private int decimals, radius = 12, border = 1, hover, pressed, wheelDelta;
    private KTheme theme = KTheme.Light;
    private Font? defaultFont;
    private readonly KStateTransition transition;
    private readonly System.Windows.Forms.Timer repeat = new() { Interval = 400 };
    private Color separatorColor = Color.Empty;
    private bool thousands;

    public KNumericUpDown()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.Selectable, true);
        transition = new KStateTransition(this);
        Size = new Size(232, 58); BackColor = Color.Transparent; TabStop = true;
        Appearance.Changed += AppearanceChanged; FocusAppearance.Changed += AppearanceChanged;
        FocusAppearance.Visible = true; FocusAppearance.Thickness = 1.5f; FocusAppearance.Inset = 3;
        base.Font = defaultFont = KTypography.Body;
        repeat.Tick += RepeatTick;
    }
    [Category("Data"), DefaultValue(typeof(decimal), "0"), Bindable(true)]
    public decimal Value
    {
        get => value;
        set
        {
            if (value < minimum || value > maximum) throw new ArgumentOutOfRangeException(nameof(value));
            if (this.value == value) return;
            this.value = value; Invalidate();
            if (IsHandleCreated) AccessibilityNotifyClients(AccessibleEvents.ValueChange, -1);
            OnValueChanged(EventArgs.Empty);
        }
    }
    [Category("Data"), DefaultValue(typeof(decimal), "0")]
    public decimal Minimum { get => minimum; set { minimum = value; if (maximum < value) maximum = value; Value = Math.Clamp(this.value, minimum, maximum); Invalidate(); } }
    [Category("Data"), DefaultValue(typeof(decimal), "100")]
    public decimal Maximum { get => maximum; set { maximum = value; if (minimum > value) minimum = value; Value = Math.Clamp(this.value, minimum, maximum); Invalidate(); } }
    [Category("Data"), DefaultValue(typeof(decimal), "1")]
    public decimal Increment { get => increment; set { if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value)); increment = value; } }
    [Category("Appearance"), DefaultValue(0)]
    public int DecimalPlaces { get => decimals; set { if (value < 0 || value > 28) throw new ArgumentOutOfRangeException(nameof(value)); decimals = value; Invalidate(); } }
    [Category("Appearance"), DefaultValue(false)]
    public bool ThousandsSeparator { get => thousands; set { thousands = value; Invalidate(); } }
    [Category("Action")] public event EventHandler? ValueChanged;
    protected virtual void OnValueChanged(EventArgs e) => ValueChanged?.Invoke(this, e);
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public KTheme Theme { get => theme; set { theme = value ?? throw new ArgumentNullException(nameof(value)); Invalidate(); } }
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAppearance Appearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KFocusStyle FocusAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAnimationStyle Animation { get; } = new();
    [Category("Kova Appearance"), DefaultValue(12)] public int CornerRadius { get => radius; set { ArgumentOutOfRangeException.ThrowIfNegative(value); radius = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(1)] public int BorderThickness { get => border; set { ArgumentOutOfRangeException.ThrowIfNegative(value); border = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(typeof(Color), "")] public Color FillColor { get => Appearance.Normal.FillColor; set => Appearance.Normal.FillColor = value; }
    [Category("Kova Appearance"), DefaultValue(typeof(Color), "")] public Color BorderColor { get => Appearance.Normal.BorderColor; set => Appearance.Normal.BorderColor = value; }
    [Category("Kova Appearance"), DefaultValue(typeof(Color), "")] public Color SeparatorColor { get => separatorColor; set { separatorColor = value; Invalidate(); } }
    public override Color ForeColor { get => base.ForeColor; set { if (Appearance is null) base.ForeColor = value; else Appearance.Normal.ForeColor = value; } }
    public override void ResetForeColor() => ForeColor = Color.Empty;
    private bool ShouldSerializeForeColor() => !Appearance.Normal.ForeColor.IsEmpty;
    [TypeConverter(typeof(KFontConverter)), System.Diagnostics.CodeAnalysis.AllowNull]
    public override Font Font { get => base.Font; set => base.Font = KFontManager.ResolveFont(value, defaultFont); }
    public override void ResetFont() => Font = null;
    private bool ShouldSerializeFont() => !Equals(Font, defaultFont);
    protected override Cursor DefaultCursor => Cursors.Hand;
    private void AppearanceChanged(object? sender, EventArgs e) { base.ForeColor = Appearance.Normal.ForeColor; Invalidate(); }
    private string FormattedValue => value.ToString((thousands ? "N" : "F") + decimals, CultureInfo.CurrentCulture);
    private int ZoneWidth => Math.Min(Width / 3, Math.Max(0, Height));
    private Rectangle Zone(int direction)
    {
        bool left = (direction < 0) != (RightToLeft == RightToLeft.Yes);
        return new Rectangle(left ? 0 : Width - ZoneWidth, 0, ZoneWidth, Height);
    }
    private bool CanStep(int direction) => Enabled && (direction < 0 ? value > minimum : value < maximum);
    private int Hit(Point point)
    {
        if (!ClientRectangle.Contains(point) || Width < 2 || Height < 2) return 0;
        using var path = KRenderer.Path(ClientRectangle, radius * DeviceDpi / 96f, KShape.Rounded);
        if (!path.IsVisible(point)) return 0;
        return Zone(-1).Contains(point) ? -1 : Zone(1).Contains(point) ? 1 : 0;
    }
    public void UpButton() => Step(1);
    public void DownButton() => Step(-1);
    private void Step(int direction)
    {
        if (!CanStep(direction)) return;
        decimal next;
        try { next = direction > 0 ? checked(value + increment) : checked(value - increment); }
        catch (OverflowException) { next = direction > 0 ? maximum : minimum; }
        Value = Math.Clamp(next, minimum, maximum);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        float scale = DeviceDpi / 96f;
        var style = transition.Sample(KRenderer.Resolve(theme, Appearance, KButtonVariant.Outline, true, Enabled, hover != 0, pressed != 0, Focused), Animation);
        var focus = Focused && Enabled ? FocusAppearance.Resolve(Appearance.Focused.BorderColor, theme.Focus) : Color.Empty;
        KRenderer.Surface(e.Graphics, ClientRectangle, style, radius * scale, border * scale, KShape.Rounded, scale,
            focus, FocusAppearance.Thickness, FocusAppearance.Inset);
        if (Width > 2 && Height > 2)
        {
            var saved = e.Graphics.Save();
            try
            {
                using var path = KRenderer.Path(ClientRectangle, radius * scale, KShape.Rounded);
                e.Graphics.SetClip(path, System.Drawing.Drawing2D.CombineMode.Intersect);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using var separator = new Pen(separatorColor.IsEmpty ? style.Border : separatorColor, scale);
                int inset = Math.Min(Height / 2, Math.Max((int)(10 * scale), Height / 4));
                e.Graphics.DrawLine(separator, ZoneWidth, inset, ZoneWidth, Height - inset);
                e.Graphics.DrawLine(separator, Width - ZoneWidth, inset, Width - ZoneWidth, Height - inset);
                foreach (int direction in new[] { -1, 1 })
                {
                    var zone = Zone(direction);
                    using var pen = new Pen(CanStep(direction) ? style.Text : theme.DisabledText, Math.Max(1, 1.5f * scale));
                    float x = zone.Left + zone.Width / 2f, y = Height / 2f;
                    float half = Math.Max(0, Math.Min(5 * scale, Math.Min(zone.Width, Height) / 4f));
                    e.Graphics.DrawLine(pen, x - half, y, x + half, y);
                    if (direction > 0) e.Graphics.DrawLine(pen, x, y - half, x, y + half);
                }
                var text = new Rectangle(ZoneWidth + 2, 0, Math.Max(0, Width - 2 * ZoneWidth - 4), Height);
                if (text.Width > 0) TextRenderer.DrawText(e.Graphics, FormattedValue, Font, text, style.Text,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis | TextFormatFlags.PreserveGraphicsClipping);
            }
            finally { e.Graphics.Restore(saved); }
        }
        base.OnPaint(e);
    }
    protected override void OnMouseMove(MouseEventArgs e) { base.OnMouseMove(e); hover = Enabled ? Hit(e.Location) : 0; Invalidate(); }
    protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); hover = 0; Invalidate(); }
    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        if (e.Button != MouseButtons.Left || !Enabled || !Focus()) return;
        int direction = Hit(e.Location);
        if (direction == 0 || !CanStep(direction)) return;
        hover = pressed = direction; Capture = true; Step(direction); repeat.Interval = 400; repeat.Start(); Invalidate();
    }
    private void RepeatTick(object? sender, EventArgs e) { repeat.Interval = 75; if (pressed != 0 && hover == pressed) Step(pressed); }
    private void StopPress() { repeat.Stop(); pressed = 0; if (Capture) Capture = false; Invalidate(); }
    protected override void OnMouseUp(MouseEventArgs e) { if (e.Button == MouseButtons.Left) StopPress(); base.OnMouseUp(e); }
    protected override void OnMouseCaptureChanged(EventArgs e) { base.OnMouseCaptureChanged(e); if (!Capture) StopPress(); }
    protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); Invalidate(); }
    protected override void OnLostFocus(EventArgs e) { StopPress(); wheelDelta = 0; base.OnLostFocus(e); }
    protected override void OnEnabledChanged(EventArgs e) { base.OnEnabledChanged(e); if (!Enabled) { StopPress(); hover = 0; } Invalidate(); }
    protected override void OnRightToLeftChanged(EventArgs e) { base.OnRightToLeftChanged(e); StopPress(); Invalidate(); }
    protected override void OnDpiChangedAfterParent(EventArgs e) { base.OnDpiChangedAfterParent(e); Invalidate(); }
    protected override bool IsInputKey(Keys keyData) => (keyData & Keys.Modifiers) == 0 && (keyData & Keys.KeyCode) is Keys.Up or Keys.Down or Keys.Home or Keys.End || base.IsInputKey(keyData);
    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e); if (e.Handled || !Enabled || e.Alt || e.Control) return;
        switch (e.KeyCode)
        {
            case Keys.Up: case Keys.Add: case Keys.Oemplus: Step(1); break;
            case Keys.Down: case Keys.Subtract: case Keys.OemMinus: Step(-1); break;
            case Keys.Home: Value = minimum; break;
            case Keys.End: Value = maximum; break;
            default: return;
        }
        e.Handled = e.SuppressKeyPress = true;
    }
    protected override void OnMouseWheel(MouseEventArgs e)
    {
        if (Focused && Enabled)
        {
            wheelDelta += e.Delta;
            while (Math.Abs((long)wheelDelta) >= 120) { int direction = Math.Sign(wheelDelta); Step(direction); wheelDelta -= direction * 120; }
            if (e is HandledMouseEventArgs handled) handled.Handled = true;
        }
        base.OnMouseWheel(e);
    }
    protected override AccessibleObject CreateAccessibilityInstance() => new NumericAccessibleObject(this);
    private sealed class NumericAccessibleObject(KNumericUpDown owner) : ControlAccessibleObject(owner)
    {
        public override AccessibleRole Role => AccessibleRole.SpinButton;
        public override string? Value { get => owner.FormattedValue; set { if (owner.Enabled && decimal.TryParse(value, NumberStyles.Number, CultureInfo.CurrentCulture, out var number)) owner.Value = Math.Clamp(number, owner.Minimum, owner.Maximum); } }
        public override int GetChildCount() => 2;
        public override AccessibleObject? GetChild(int index) => index is 0 or 1 ? new StepAccessibleObject(owner, index == 0 ? -1 : 1) : null;
    }
    private sealed class StepAccessibleObject(KNumericUpDown owner, int direction) : AccessibleObject
    {
        public override string? Name { get => direction < 0 ? "Disminuir" : "Aumentar"; set { } }
        public override string DefaultAction => Name!;
        public override AccessibleRole Role => AccessibleRole.PushButton;
        public override AccessibleObject Parent => owner.AccessibilityObject;
        public override Rectangle Bounds => owner.IsHandleCreated ? owner.RectangleToScreen(owner.Zone(direction)) : Rectangle.Empty;
        public override AccessibleStates State => (owner.CanStep(direction) ? AccessibleStates.None : AccessibleStates.Unavailable) | (owner.Visible ? AccessibleStates.None : AccessibleStates.Invisible);
        public override void DoDefaultAction() => owner.Step(direction);
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing) { repeat.Stop(); repeat.Dispose(); transition.Dispose(); Appearance.Changed -= AppearanceChanged; FocusAppearance.Changed -= AppearanceChanged; }
        base.Dispose(disposing);
        if (disposing) { defaultFont?.Dispose(); defaultFont = null; }
    }
}
