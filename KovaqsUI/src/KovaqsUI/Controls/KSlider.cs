using System.ComponentModel;
using System.Globalization;
using KovaqsUI.Core;
using KovaqsUI.Drawing;
using KovaqsUI.Styling;

namespace KovaqsUI.Controls;

/// <summary>Single-value, keyboard accessible slider with a DPI-scaled track and thumb.</summary>
[ToolboxItem(true), DefaultProperty(nameof(Value)), DefaultEvent(nameof(ValueChanged)), DefaultBindingProperty(nameof(Value))]
public class KSlider : Control, IKThemeControl
{
    private int minimum, maximum = 100, value, smallChange = 1, largeChange = 10;
    private int trackThickness = 4, thumbSize = 20, trackRadius = 2, thumbRadius = 10, borderThickness = 1, trackBorder;
    private Orientation orientation;
    private bool hover, pressed;
    private int dragOffset;
    private KTheme theme = KTheme.Light;
    private Font? defaultFont;
    private readonly KStateTransition trackTransition, fillTransition, thumbTransition;

    public KSlider()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.Selectable, true);
        trackTransition = new(this); fillTransition = new(this); thumbTransition = new(this);
        BackColor = Color.Transparent; Size = new Size(240, 36); TabStop = true; Padding = new Padding(4);
        base.Font = defaultFont = KTypography.Body;
        TrackAppearance.Changed += Changed; FillAppearance.Changed += Changed; ThumbAppearance.Changed += Changed; FocusAppearance.Changed += Changed;
    }
    [Category("Behavior"), DefaultValue(0)]
    public int Minimum { get => minimum; set { minimum = value; if (maximum < value) maximum = value; Value = Math.Clamp(this.value, minimum, maximum); Invalidate(); } }
    [Category("Behavior"), DefaultValue(100)]
    public int Maximum { get => maximum; set { maximum = value; if (minimum > value) minimum = value; Value = Math.Clamp(this.value, minimum, maximum); Invalidate(); } }
    [Category("Behavior"), DefaultValue(0), Bindable(true)]
    public int Value
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
    [Category("Behavior"), DefaultValue(1)] public int SmallChange { get => smallChange; set { ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value); smallChange = value; } }
    [Category("Behavior"), DefaultValue(10)] public int LargeChange { get => largeChange; set { ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value); largeChange = value; } }
    [Category("Action")] public event EventHandler? ValueChanged;
    protected virtual void OnValueChanged(EventArgs e) => ValueChanged?.Invoke(this, e);
    [Category("Layout"), DefaultValue(Orientation.Horizontal)]
    public Orientation Orientation { get => orientation; set { if (!Enum.IsDefined(value)) throw new InvalidEnumArgumentException(nameof(value), (int)value, typeof(Orientation)); orientation = value; CancelDrag(); Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(4)] public int TrackThickness { get => trackThickness; set { Dimension(value); trackThickness = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(20)] public int ThumbSize { get => thumbSize; set { Dimension(value); thumbSize = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(2)] public int TrackCornerRadius { get => trackRadius; set { Dimension(value, true); trackRadius = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(10)] public int ThumbCornerRadius { get => thumbRadius; set { Dimension(value, true); thumbRadius = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(1)] public int BorderThickness { get => borderThickness; set { Dimension(value, true); borderThickness = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(0)] public int TrackBorderThickness { get => trackBorder; set { Dimension(value, true); trackBorder = value; Invalidate(); } }
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAppearance TrackAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAppearance FillAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAppearance ThumbAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KFocusStyle FocusAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAnimationStyle Animation { get; } = new();
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public KTheme Theme { get => theme; set { theme = value ?? throw new ArgumentNullException(nameof(value)); Invalidate(); } }
    [TypeConverter(typeof(KFontConverter)), System.Diagnostics.CodeAnalysis.AllowNull]
    public override Font Font { get => base.Font; set => base.Font = KFontManager.ResolveFont(value, defaultFont); }
    public override void ResetFont() => Font = null;
    private bool ShouldSerializeFont() => !Equals(Font, defaultFont);
    protected override Cursor DefaultCursor => Cursors.Hand;
    protected override Padding DefaultPadding => new(4);
    private static void Dimension(int value, bool zero = false) { if (value < (zero ? 0 : 1) || value > 4096) throw new ArgumentOutOfRangeException(nameof(value)); }
    private void Changed(object? sender, EventArgs e) => Invalidate();
    private float ScaleFactor => DeviceDpi / 96f;
    private Rectangle Area
    {
        get
        {
            int x = Math.Clamp(Padding.Left, 0, Width), y = Math.Clamp(Padding.Top, 0, Height);
            return new Rectangle(x, y, Math.Max(0, Width - x - Padding.Right), Math.Max(0, Height - y - Padding.Bottom));
        }
    }
    private (Rectangle Track, Rectangle Thumb, int Start, int End) Geometry()
    {
        var area = Area;
        bool horizontal = orientation == Orientation.Horizontal;
        int diameter = Math.Max(0, Math.Min((int)Math.Round(thumbSize * ScaleFactor), Math.Min(area.Width, area.Height)));
        int start = (horizontal ? area.Left : area.Top) + diameter / 2;
        int end = Math.Max(start, (horizontal ? area.Right : area.Bottom) - (diameter - diameter / 2));
        double fraction = maximum == minimum ? 0 : ((double)value - minimum) / ((double)maximum - minimum);
        if (!horizontal || RightToLeft == RightToLeft.Yes) fraction = 1 - fraction;
        int center = start + (int)Math.Round((end - start) * fraction);
        int thickness = Math.Max(0, Math.Min((int)Math.Round(trackThickness * ScaleFactor), horizontal ? area.Height : area.Width));
        var track = horizontal ? new Rectangle(start, area.Top + (area.Height - thickness) / 2, end - start, thickness)
            : new Rectangle(area.Left + (area.Width - thickness) / 2, start, thickness, end - start);
        var thumb = horizontal ? new Rectangle(center - diameter / 2, area.Top + (area.Height - diameter) / 2, diameter, diameter)
            : new Rectangle(area.Left + (area.Width - diameter) / 2, center - diameter / 2, diameter, diameter);
        return (track, thumb, start, end);
    }
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public Rectangle ThumbBounds => Geometry().Thumb;
    private PaintStyle Resolve(KAppearance appearance, Color fill, Color border)
    {
        var style = new PaintStyle(fill, Color.Empty, theme.TextPrimary, border, 90).Apply(appearance.Normal);
        if (!Enabled) return (style with { Fill = ReferenceEquals(appearance, ThumbAppearance) ? theme.DisabledText : ReferenceEquals(appearance, FillAppearance) ? theme.DisabledBorder : theme.DisabledFill, Text = theme.DisabledText, Border = theme.DisabledBorder }).Apply(appearance.Disabled);
        if (ReferenceEquals(appearance, ThumbAppearance) && appearance.Normal.FillColor.IsEmpty)
        {
            if (hover) style = style with { Fill = theme.PrimaryHover };
            if (pressed) style = style with { Fill = theme.PrimaryPressed };
        }
        if (Focused) style = style.Apply(appearance.Focused);
        if (hover) style = style.Apply(appearance.Hover);
        if (pressed) style = style.Apply(appearance.Pressed);
        return style;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        var (track, thumb, start, end) = Geometry();
        var normal = trackTransition.Sample(Resolve(TrackAppearance, theme.Border, theme.Border), Animation);
        var fill = fillTransition.Sample(Resolve(FillAppearance, theme.Primary, theme.Primary), Animation);
        var knob = thumbTransition.Sample(Resolve(ThumbAppearance, theme.OnSecondary, theme.Border), Animation);
        KRenderer.Surface(e.Graphics, track, normal, trackRadius * ScaleFactor, trackBorder * ScaleFactor, KShape.Rounded, ScaleFactor, Color.Empty);
        int center = orientation == Orientation.Horizontal ? thumb.Left + thumb.Width / 2 : thumb.Top + thumb.Height / 2;
        var filled = track;
        if (orientation == Orientation.Horizontal)
        {
            if (RightToLeft == RightToLeft.Yes) filled = Rectangle.FromLTRB(center, track.Top, end, track.Bottom);
            else filled.Width = Math.Max(0, center - start);
        }
        else filled = Rectangle.FromLTRB(track.Left, center, track.Right, end);
        KRenderer.Surface(e.Graphics, filled, fill, trackRadius * ScaleFactor, trackBorder * ScaleFactor, KShape.Rounded, ScaleFactor, Color.Empty);
        KRenderer.Surface(e.Graphics, thumb, knob, thumbRadius * ScaleFactor, borderThickness * ScaleFactor, KShape.Rounded, ScaleFactor,
            Enabled && Focused ? FocusAppearance.Resolve(ThumbAppearance.Focused.BorderColor, theme.Focus) : Color.Empty, FocusAppearance.Thickness, FocusAppearance.Inset);
        base.OnPaint(e);
    }
    private void SetFromPoint(Point point)
    {
        var (_, _, start, end) = Geometry();
        if (end <= start || minimum == maximum) return;
        double fraction = Math.Clamp(((orientation == Orientation.Horizontal ? point.X : point.Y) - dragOffset - start) / (double)(end - start), 0, 1);
        if (orientation == Orientation.Vertical || RightToLeft == RightToLeft.Yes) fraction = 1 - fraction;
        Value = (int)Math.Clamp(Math.Round(minimum + fraction * ((double)maximum - minimum)), minimum, maximum);
    }
    private void Step(long amount) => Value = (int)Math.Clamp((long)value + amount, minimum, maximum);
    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        if (!Enabled || e.Button != MouseButtons.Left || !Focus()) return;
        var thumb = ThumbBounds;
        dragOffset = thumb.Contains(e.Location) ? (orientation == Orientation.Horizontal ? e.X - thumb.Left - thumb.Width / 2 : e.Y - thumb.Top - thumb.Height / 2) : 0;
        pressed = hover = true; Capture = true; SetFromPoint(e.Location); Invalidate();
    }
    protected override void OnMouseMove(MouseEventArgs e) { base.OnMouseMove(e); hover = Enabled && ClientRectangle.Contains(e.Location); if (pressed) SetFromPoint(e.Location); Invalidate(); }
    protected override void OnMouseUp(MouseEventArgs e) { if (e.Button == MouseButtons.Left) CancelDrag(); base.OnMouseUp(e); }
    protected override void OnMouseEnter(EventArgs e) { hover = Enabled; base.OnMouseEnter(e); Invalidate(); }
    protected override void OnMouseLeave(EventArgs e) { hover = false; base.OnMouseLeave(e); Invalidate(); }
    private void CancelDrag() { pressed = false; if (Capture) Capture = false; Invalidate(); }
    protected override void OnMouseCaptureChanged(EventArgs e) { if (!Capture) pressed = false; base.OnMouseCaptureChanged(e); Invalidate(); }
    protected override void OnLostFocus(EventArgs e) { CancelDrag(); base.OnLostFocus(e); }
    protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); Invalidate(); }
    protected override void OnEnabledChanged(EventArgs e) { CancelDrag(); hover = false; base.OnEnabledChanged(e); }
    protected override void OnVisibleChanged(EventArgs e) { if (!Visible) { CancelDrag(); hover = false; } base.OnVisibleChanged(e); }
    protected override void OnHandleDestroyed(EventArgs e) { CancelDrag(); hover = false; base.OnHandleDestroyed(e); }
    protected override void OnRightToLeftChanged(EventArgs e) { CancelDrag(); base.OnRightToLeftChanged(e); }
    protected override void OnDpiChangedAfterParent(EventArgs e) { CancelDrag(); base.OnDpiChangedAfterParent(e); }
    protected override bool IsInputKey(Keys keyData) => (keyData & Keys.Modifiers) == 0 && (keyData & Keys.KeyCode) is Keys.Left or Keys.Right or Keys.Up or Keys.Down or Keys.PageUp or Keys.PageDown or Keys.Home or Keys.End || base.IsInputKey(keyData);
    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e); if (e.Handled || !Enabled || e.Modifiers != Keys.None) return;
        switch (e.KeyCode)
        {
            case Keys.Home: Value = minimum; break;
            case Keys.End: Value = maximum; break;
            case Keys.PageUp: Step(largeChange); break;
            case Keys.PageDown: Step(-(long)largeChange); break;
            case Keys.Up: Step(smallChange); break;
            case Keys.Down: Step(-(long)smallChange); break;
            case Keys.Right: Step(RightToLeft == RightToLeft.Yes && orientation == Orientation.Horizontal ? -(long)smallChange : smallChange); break;
            case Keys.Left: Step(RightToLeft == RightToLeft.Yes && orientation == Orientation.Horizontal ? smallChange : -(long)smallChange); break;
            default: return;
        }
        e.Handled = e.SuppressKeyPress = true;
    }
    protected override AccessibleObject CreateAccessibilityInstance() => new SliderAccessibleObject(this);
    private sealed class SliderAccessibleObject(KSlider owner) : ControlAccessibleObject(owner)
    {
        public override AccessibleRole Role => AccessibleRole.Slider;
        public override string? Value { get => owner.Value.ToString(CultureInfo.CurrentCulture); set { if (owner.Enabled && int.TryParse(value, out int number)) owner.Value = Math.Clamp(number, owner.Minimum, owner.Maximum); } }
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing) { trackTransition.Dispose(); fillTransition.Dispose(); thumbTransition.Dispose(); TrackAppearance.Changed -= Changed; FillAppearance.Changed -= Changed; ThumbAppearance.Changed -= Changed; FocusAppearance.Changed -= Changed; }
        base.Dispose(disposing); if (disposing) { defaultFont?.Dispose(); defaultFont = null; }
    }
}
