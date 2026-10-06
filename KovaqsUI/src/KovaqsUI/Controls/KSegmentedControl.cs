using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using KovaqsUI.Core;
using KovaqsUI.Drawing;
using KovaqsUI.Styling;

namespace KovaqsUI.Controls;

public enum KSegmentSizeMode { Equal, Content }

/// <summary>Single-selection segmented input with owner drawing and accessible child options.</summary>
[ToolboxItem(true), DefaultEvent(nameof(SelectedIndexChanged)), DefaultProperty(nameof(Items)), DefaultBindingProperty(nameof(SelectedValue))]
public class KSegmentedControl : Control, IKThemeControl
{
    private KTheme theme = KTheme.Light;
    private Font? defaultFont;
    private Color normalForeColor;
    private int selectedIndex = -1, focusedIndex = -1, hoverIndex = -1, pressedIndex = -1;
    private KSegmentItem? selectedItem;
    private string? selectedValue;
    private Keys pressedKey;
    private Orientation orientation;
    private KSegmentSizeMode sizeMode;
    private ContentAlignment textAlign = ContentAlignment.MiddleCenter;
    private int radius = 12, segmentRadius = -1, border, segmentBorder, spacing = 4;
    private Size minimumItemSize = new(40, 32);
    private Padding itemPadding = new(12, 6, 12, 6);
    private bool autoEllipsis = true, layoutDirty = true;
    private Rectangle[] itemBounds = [];
    private readonly Dictionary<KSegmentItem, KStateTransition> transitions = [];
    private readonly Dictionary<KSegmentItem, SegmentAccessibleObject> accessibleItems = [];
    private readonly KScalarTransition pillX, pillY, pillWidth, pillHeight;
    private readonly KStateTransition pillStyle;
    private bool pillInitialized;

    public KSegmentedControl()
    {
        pillX = new(this); pillY = new(this); pillWidth = new(this); pillHeight = new(this); pillStyle = new(this);
        Items = new KSegmentItemCollection(this);
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
            ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.Selectable, true);
        BackColor = Color.Transparent; TabStop = true; Size = new Size(320, 48); Padding = new Padding(6);
        Surface.Changed += AppearanceStyleChanged; Appearance.Changed += AppearanceChanged;
        SelectedAppearance.Changed += AppearanceStyleChanged; FocusAppearance.Changed += AppearanceStyleChanged;
        base.Font = defaultFont = KTypography.Button;
    }

    [Category("Data"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [Editor(typeof(CollectionEditor), typeof(UITypeEditor)), MergableProperty(false)]
    public KSegmentItemCollection Items { get; }

    [Category("Data"), DefaultValue(-1), Bindable(true)]
    public int SelectedIndex
    {
        get => selectedIndex;
        set
        {
            if (value < -1 || value >= Items.Count) throw new ArgumentOutOfRangeException(nameof(value));
            if (value >= 0 && !Items[value].Enabled) throw new ArgumentException("No se puede seleccionar un elemento deshabilitado.", nameof(value));
            ChangeSelection(value < 0 ? null : Items[value]);
        }
    }
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Bindable(true)]
    public KSegmentItem? SelectedItem
    {
        get => selectedItem;
        set
        {
            if (value is null) { SelectedIndex = -1; return; }
            int index = Items.IndexOf(value);
            if (index < 0) throw new ArgumentException("El elemento no pertenece al control.", nameof(value));
            SelectedIndex = index;
        }
    }
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Bindable(true)]
    public string? SelectedValue
    {
        get => selectedItem?.Value;
        set => SelectedIndex = value is null ? -1 : Enumerable.Range(0, Items.Count).FirstOrDefault(i => Items[i].Enabled && Items[i].Value == value, -1);
    }
    [Category("Action")] public event EventHandler? SelectedIndexChanged;
    [Category("Action")] public event EventHandler? SelectedItemChanged;
    [Category("Action")] public event EventHandler? SelectedValueChanged;
    protected virtual void OnSelectedIndexChanged(EventArgs e) => SelectedIndexChanged?.Invoke(this, e);
    protected virtual void OnSelectedItemChanged(EventArgs e) => SelectedItemChanged?.Invoke(this, e);
    protected virtual void OnSelectedValueChanged(EventArgs e) => SelectedValueChanged?.Invoke(this, e);

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public KTheme Theme { get => theme; set { theme = value ?? throw new ArgumentNullException(nameof(value)); Invalidate(); } }
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KStateStyle Surface { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAppearance Appearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAppearance SelectedAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KFocusStyle FocusAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAnimationStyle Animation { get; } = new();
    [Category("Kova Appearance"), DefaultValue(typeof(Color), "")]
    public Color FillColor { get => Surface.FillColor; set => Surface.FillColor = value; }
    [Category("Kova Appearance"), DefaultValue(typeof(Color), "")]
    public Color BorderColor { get => Surface.BorderColor; set => Surface.BorderColor = value; }
    [Category("Kova Appearance"), DefaultValue(typeof(Color), "")]
    public Color SelectedFillColor { get => SelectedAppearance.Normal.FillColor; set => SelectedAppearance.Normal.FillColor = value; }
    [Category("Kova Appearance"), DefaultValue(typeof(Color), "")]
    public Color SelectedForeColor { get => SelectedAppearance.Normal.ForeColor; set => SelectedAppearance.Normal.ForeColor = value; }
    public override Color ForeColor
    {
        get => base.ForeColor;
        set { if (Appearance is null) base.ForeColor = value; else Appearance.Normal.ForeColor = value; }
    }
    [TypeConverter(typeof(KFontConverter)), System.Diagnostics.CodeAnalysis.AllowNull]
    public override Font Font { get => base.Font; set => base.Font = KFontManager.ResolveFont(value, defaultFont); }
    public override void ResetFont() => Font = null;
    private bool ShouldSerializeFont() => !Equals(Font, defaultFont);
    protected override Padding DefaultPadding => new(6);
    protected override Cursor DefaultCursor => Cursors.Hand;

    [Category("Layout"), DefaultValue(Orientation.Horizontal)]
    public Orientation Orientation { get => orientation; set { ValidateEnum(value); if (orientation == value) return; orientation = value; ResetInteraction(); LayoutChanged(); } }
    [Category("Layout"), DefaultValue(KSegmentSizeMode.Equal)]
    public KSegmentSizeMode ItemSizeMode { get => sizeMode; set { ValidateEnum(value); sizeMode = value; LayoutChanged(); } }
    [Category("Layout"), DefaultValue(4)]
    public int ItemSpacing { get => spacing; set { ArgumentOutOfRangeException.ThrowIfNegative(value); spacing = value; LayoutChanged(); } }
    [Category("Layout"), DefaultValue(typeof(Size), "40, 32")]
    public Size MinimumItemSize { get => minimumItemSize; set { if (value.Width < 0 || value.Height < 0) throw new ArgumentOutOfRangeException(nameof(value)); minimumItemSize = value; LayoutChanged(); } }
    [Category("Layout"), DefaultValue(typeof(Padding), "12, 6, 12, 6")]
    public Padding ItemPadding { get => itemPadding; set { if (value.Left < 0 || value.Top < 0 || value.Right < 0 || value.Bottom < 0) throw new ArgumentOutOfRangeException(nameof(value)); itemPadding = value; LayoutChanged(); } }
    [Category("Kova Appearance"), DefaultValue(12)]
    public int CornerRadius { get => radius; set { ArgumentOutOfRangeException.ThrowIfNegative(value); radius = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(-1), Description("-1 calcula el radio interior a partir del radio exterior y Padding. Medida lógica a 96 DPI.")]
    public int SegmentCornerRadius { get => segmentRadius; set { if (value < -1) throw new ArgumentOutOfRangeException(nameof(value)); segmentRadius = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(0)]
    public int BorderThickness { get => border; set { ArgumentOutOfRangeException.ThrowIfNegative(value); border = value; LayoutChanged(); } }
    [Category("Kova Appearance"), DefaultValue(0)]
    public int SegmentBorderThickness { get => segmentBorder; set { ArgumentOutOfRangeException.ThrowIfNegative(value); segmentBorder = value; LayoutChanged(); } }
    [Category("Appearance"), DefaultValue(ContentAlignment.MiddleCenter)]
    public ContentAlignment TextAlign { get => textAlign; set { ValidateEnum(value); textAlign = value; Invalidate(); } }
    [Category("Appearance"), DefaultValue(true)]
    public bool AutoEllipsis { get => autoEllipsis; set { autoEllipsis = value; Invalidate(); } }
    private static void ValidateEnum<T>(T value) where T : struct, Enum
    {
        if (!Enum.IsDefined(value)) throw new InvalidEnumArgumentException(nameof(value), Convert.ToInt32(value), typeof(T));
    }

    private void ChangeSelection(KSegmentItem? item)
    {
        int next = item is null ? -1 : Items.IndexOf(item);
        if (next < 0 || item?.Enabled == false) { next = -1; item = null; }
        bool indexChanged = selectedIndex != next || !ReferenceEquals(selectedItem, item);
        bool itemChanged = !ReferenceEquals(selectedItem, item);
        string? nextValue = item?.Value;
        bool valueChanged = selectedValue != nextValue;
        selectedIndex = next; selectedItem = item; selectedValue = nextValue;
        if (next >= 0) focusedIndex = next;
        Invalidate();
        if (IsHandleCreated && indexChanged) AccessibilityNotifyClients(AccessibleEvents.Selection, next < 0 ? -1 : next);
        if (indexChanged) OnSelectedIndexChanged(EventArgs.Empty);
        if (itemChanged) OnSelectedItemChanged(EventArgs.Empty);
        if (valueChanged) OnSelectedValueChanged(EventArgs.Empty);
    }
    internal void ItemChanged(object? sender, PropertyChangedEventArgs e)
    {
        if (IsDisposed) return;
        ChangeSelection(selectedItem);
        if (focusedIndex >= 0 && !IsEnabledItem(focusedIndex)) focusedIndex = FirstEnabled();
        ResetInteraction(); LayoutChanged();
        if (IsHandleCreated) AccessibilityNotifyClients(AccessibleEvents.NameChange, sender is KSegmentItem item ? Items.IndexOf(item) : -1);
    }
    internal void ItemsChanged()
    {
        foreach (var item in transitions.Keys.Where(item => !Items.Contains(item)).ToArray()) { transitions[item].Dispose(); transitions.Remove(item); accessibleItems.Remove(item); }
        foreach (var item in accessibleItems.Keys.Where(item => !Items.Contains(item)).ToArray()) accessibleItems.Remove(item);
        ChangeSelection(selectedItem);
        focusedIndex = selectedIndex >= 0 ? selectedIndex : FirstEnabled();
        ResetInteraction(); LayoutChanged();
        if (IsHandleCreated) AccessibilityNotifyClients(AccessibleEvents.Reorder, -1);
    }
    private void AppearanceStyleChanged(object? sender, EventArgs e) => Invalidate();
    private void AppearanceChanged(object? sender, EventArgs e)
    {
        if (normalForeColor != Appearance.Normal.ForeColor) { normalForeColor = Appearance.Normal.ForeColor; base.ForeColor = normalForeColor; }
        Invalidate();
    }
    private void LayoutChanged() { layoutDirty = true; Invalidate(); Parent?.PerformLayout(this, nameof(Items)); }
    protected override void OnLayout(LayoutEventArgs e) { layoutDirty = true; base.OnLayout(e); Invalidate(); }
    protected override void OnSizeChanged(EventArgs e) { layoutDirty = true; base.OnSizeChanged(e); }
    protected override void OnFontChanged(EventArgs e) { base.OnFontChanged(e); LayoutChanged(); }
    protected override void OnDpiChangedAfterParent(EventArgs e) { base.OnDpiChangedAfterParent(e); LayoutChanged(); }
    protected override void OnRightToLeftChanged(EventArgs e) { base.OnRightToLeftChanged(e); LayoutChanged(); }
    protected override void OnEnabledChanged(EventArgs e) { base.OnEnabledChanged(e); ResetInteraction(); Invalidate(); }
    private float DpiScale => DeviceDpi / 96f;
    private int Px(int logical) => (int)Math.Min(int.MaxValue, Math.Round(logical * (double)DpiScale));
    private Rectangle Interior
    {
        get
        {
            int b = Math.Min(Px(border), Math.Min(ClientSize.Width, ClientSize.Height) / 2);
            int left = (int)Math.Min(ClientSize.Width, (long)Padding.Left + b), top = (int)Math.Min(ClientSize.Height, (long)Padding.Top + b);
            int right = (int)Math.Max(left, (long)ClientSize.Width - Padding.Right - b), bottom = (int)Math.Max(top, (long)ClientSize.Height - Padding.Bottom - b);
            return Rectangle.FromLTRB(left, top, right, bottom);
        }
    }
    private Size PreferredItem(KSegmentItem item)
    {
        var text = TextRenderer.MeasureText(item.Text.Length == 0 ? " " : item.Text, Font, Size.Empty, TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine | TextFormatFlags.NoPadding);
        return new Size((int)Math.Min(int.MaxValue, Math.Max(Px(minimumItemSize.Width), (long)text.Width + Px(itemPadding.Left) + Px(itemPadding.Right) + 2L * Px(segmentBorder))),
            (int)Math.Min(int.MaxValue, Math.Max(Px(minimumItemSize.Height), (long)text.Height + Px(itemPadding.Top) + Px(itemPadding.Bottom) + 2L * Px(segmentBorder))));
    }
    public override Size GetPreferredSize(Size proposedSize)
    {
        if (Items is null || Items.Count == 0) return new Size(Padding.Horizontal + 2 * Px(border), Padding.Vertical + 2 * Px(border));
        var sizes = Items.Select(PreferredItem).ToArray();
        bool horizontal = orientation == Orientation.Horizontal;
        double major = sizeMode == KSegmentSizeMode.Equal ? sizes.Max(s => horizontal ? s.Width : s.Height) * (double)sizes.Length : sizes.Sum(s => (double)(horizontal ? s.Width : s.Height));
        major += Px(spacing) * (double)(sizes.Length - 1);
        double minor = sizes.Max(s => horizontal ? s.Height : s.Width);
        return new Size((int)Math.Min(int.MaxValue, (horizontal ? major : minor) + Padding.Horizontal + 2d * Px(border)),
            (int)Math.Min(int.MaxValue, (horizontal ? minor : major) + Padding.Vertical + 2d * Px(border)));
    }
    private void EnsureLayout()
    {
        if (!layoutDirty) return;
        layoutDirty = false; pillInitialized = false; itemBounds = new Rectangle[Items.Count];
        if (Items.Count == 0) return;
        var area = Interior; bool horizontal = orientation == Orientation.Horizontal;
        int length = horizontal ? area.Width : area.Height;
        int gap = Items.Count <= 1 ? 0 : Math.Min(Px(spacing), length / (Items.Count - 1));
        int available = Math.Max(0, length - gap * (Items.Count - 1));
        var weights = Items.Select(item => sizeMode == KSegmentSizeMode.Equal ? 1d : Math.Max(1, horizontal ? PreferredItem(item).Width : PreferredItem(item).Height)).ToArray();
        double total = weights.Sum(), accumulated = 0;
        int previous = 0;
        for (int i = 0; i < Items.Count; i++)
        {
            accumulated += weights[i]; int end = i == Items.Count - 1 ? available : (int)Math.Round(available * accumulated / total);
            int start = previous + gap * i, extent = Math.Max(0, end - previous);
            itemBounds[i] = horizontal
                ? new Rectangle(RightToLeft == RightToLeft.Yes ? area.Right - start - extent : area.Left + start, area.Top, extent, area.Height)
                : new Rectangle(area.Left, area.Top + start, area.Width, extent);
            previous = end;
        }
    }
    /// <summary>Returns a segment rectangle in device pixels relative to the client area.</summary>
    public Rectangle GetItemBounds(int index) { if (index < 0 || index >= Items.Count) throw new ArgumentOutOfRangeException(nameof(index)); EnsureLayout(); return itemBounds[index]; }
    /// <summary>Returns the item at a client point, including disabled items, or -1 for gaps and padding.</summary>
    public int HitTest(Point point)
    {
        if (!ClientRectangle.Contains(point)) return -1;
        using var outline = KRenderer.Path(ClientRectangle, radius * DpiScale, KShape.Rounded);
        if (!outline.IsVisible(point)) return -1;
        EnsureLayout();
        for (int i = 0; i < itemBounds.Length; i++) if (itemBounds[i].Contains(point)) return i;
        return -1;
    }
    private PaintStyle ItemStyle(int index, bool selected)
    {
        bool enabled = Enabled && Items[index].Enabled;
        var appearance = selected ? SelectedAppearance : Appearance;
        var style = new PaintStyle(selected ? theme.Surface : Color.Transparent, Color.Empty,
            Appearance.Normal.ForeColor.IsEmpty ? theme.TextPrimary : Appearance.Normal.ForeColor, theme.Border, 90).Apply(appearance.Normal);
        if (!enabled) return (style with { Fill = selected ? theme.DisabledFill : Color.Transparent, End = Color.Empty, Text = theme.DisabledText, Border = theme.DisabledBorder }).Apply(appearance.Disabled);
        if (index == focusedIndex && Focused) style = style.Apply(appearance.Focused);
        if (index == hoverIndex) style = (style with { Fill = appearance.Hover.FillColor.IsEmpty && !selected ? theme.SurfaceHover : style.Fill }).Apply(appearance.Hover);
        if (index == pressedIndex) style = (style with { Fill = appearance.Pressed.FillColor.IsEmpty ? theme.SurfacePressed : style.Fill }).Apply(appearance.Pressed);
        return style;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        EnsureLayout(); float scale = DpiScale;
        var surface = new PaintStyle(Enabled ? theme.Border : theme.DisabledBorder, Color.Empty, theme.TextPrimary, theme.Border, 90).Apply(Surface);
        KRenderer.Surface(e.Graphics, ClientRectangle, surface, radius * scale, border * scale, KShape.Rounded, scale, Color.Empty);
        var saved = e.Graphics.Save();
        try
        {
            using var outer = KRenderer.Path(ClientRectangle, radius * scale, KShape.Rounded);
            e.Graphics.SetClip(outer, CombineMode.Intersect);
            e.Graphics.SetClip(Interior, CombineMode.Intersect);
            float innerRadius = segmentRadius >= 0 ? segmentRadius * scale : Math.Max(0, radius * scale - Math.Min(Math.Min(Padding.Left, Padding.Right), Math.Min(Padding.Top, Padding.Bottom)) - border * scale);
            var moving = Rectangle.Empty;
            Color selectedInk = Color.Empty;
            // Backgrounds first, then one moving selection surface, then stable text.
            for (int i = 0; i < Items.Count; i++)
            {
                if (!transitions.TryGetValue(Items[i], out var transition)) transitions[Items[i]] = transition = new KStateTransition(this);
                var background = transition.Sample(ItemStyle(i, false), Animation);
                KRenderer.Surface(e.Graphics, itemBounds[i], background, innerRadius, segmentBorder * scale, KShape.Rounded, scale, Color.Empty);
            }
            if (selectedIndex >= 0)
            {
                var target = itemBounds[selectedIndex];
                if (!pillInitialized)
                {
                    pillX.Reset(target.X); pillY.Reset(target.Y); pillWidth.Reset(target.Width); pillHeight.Reset(target.Height);
                    pillInitialized = true;
                }
                moving = new Rectangle((int)MathF.Round(pillX.Sample(target.X, Animation)), (int)MathF.Round(pillY.Sample(target.Y, Animation)),
                    Math.Max(0, (int)MathF.Round(pillWidth.Sample(target.Width, Animation))), Math.Max(0, (int)MathF.Round(pillHeight.Sample(target.Height, Animation))));
                var selectedStyle = pillStyle.Sample(ItemStyle(selectedIndex, true), Animation);
                selectedInk = selectedStyle.Text;
                KRenderer.Surface(e.Graphics, moving, selectedStyle, innerRadius, segmentBorder * scale, KShape.Rounded, scale, Color.Empty);
            }
            else
            {
                pillInitialized = false; pillX.Reset(); pillY.Reset(); pillWidth.Reset(); pillHeight.Reset();
            }
            for (int i = 0; i < Items.Count; i++)
            {
                var bounds = itemBounds[i]; if (bounds.Width < 2 || bounds.Height < 2) continue;
                var style = ItemStyle(i, false);
                var appearance = i == selectedIndex ? SelectedAppearance : Appearance;
                Color focus = Focused && Enabled && i == focusedIndex && Items[i].Enabled
                    ? FocusAppearance.Resolve(appearance.Focused.BorderColor, theme.Focus) : Color.Empty;
                if (!focus.IsEmpty)
                    KRenderer.Surface(e.Graphics, bounds, style with { Fill = Color.Transparent, End = Color.Empty }, innerRadius, 0, KShape.Rounded, scale,
                        focus, FocusAppearance.Thickness, FocusAppearance.Inset);
                int inset = Math.Min(Px(segmentBorder), Math.Min(bounds.Width, bounds.Height) / 2);
                int left = (int)Math.Min(bounds.Right, (long)bounds.Left + Px(itemPadding.Left) + inset);
                int top = (int)Math.Min(bounds.Bottom, (long)bounds.Top + Px(itemPadding.Top) + inset);
                var textBounds = Rectangle.FromLTRB(left, top, (int)Math.Max(left, (long)bounds.Right - Px(itemPadding.Right) - inset), (int)Math.Max(top, (long)bounds.Bottom - Px(itemPadding.Bottom) - inset));
                if (textBounds.Width > 0 && textBounds.Height > 0)
                {
                    TextRenderer.DrawText(e.Graphics, Items[i].Text, Font, textBounds, style.Text, TextFlags());
                    if (!selectedInk.IsEmpty && moving.IntersectsWith(textBounds))
                    {
                        var textState = e.Graphics.Save();
                        try
                        {
                            using var pillClip = KRenderer.Path(moving, innerRadius, KShape.Rounded);
                            e.Graphics.SetClip(pillClip, CombineMode.Intersect);
                            TextRenderer.DrawText(e.Graphics, Items[i].Text, Font, textBounds, selectedInk, TextFlags());
                        }
                        finally { e.Graphics.Restore(textState); }
                    }
                }
            }
        }
        finally { e.Graphics.Restore(saved); }
        base.OnPaint(e);
    }
    private TextFormatFlags TextFlags()
    {
        var flags = TextFormatFlags.SingleLine | TextFormatFlags.NoPrefix | TextFormatFlags.NoPadding | TextFormatFlags.PreserveGraphicsClipping;
        if (autoEllipsis) flags |= TextFormatFlags.EndEllipsis;
        bool left = textAlign is ContentAlignment.TopLeft or ContentAlignment.MiddleLeft or ContentAlignment.BottomLeft;
        bool right = textAlign is ContentAlignment.TopRight or ContentAlignment.MiddleRight or ContentAlignment.BottomRight;
        if (RightToLeft == RightToLeft.Yes) { flags |= TextFormatFlags.RightToLeft; (left, right) = (right, left); }
        flags |= left ? TextFormatFlags.Left : right ? TextFormatFlags.Right : TextFormatFlags.HorizontalCenter;
        flags |= textAlign is ContentAlignment.TopLeft or ContentAlignment.TopCenter or ContentAlignment.TopRight ? TextFormatFlags.Top
            : textAlign is ContentAlignment.BottomLeft or ContentAlignment.BottomCenter or ContentAlignment.BottomRight ? TextFormatFlags.Bottom : TextFormatFlags.VerticalCenter;
        return flags;
    }

    private bool IsEnabledItem(int index) => index >= 0 && index < Items.Count && Items[index].Enabled;
    private int FirstEnabled() => Enumerable.Range(0, Items.Count).FirstOrDefault(IsEnabledItem, -1);
    private void ResetInteraction() { hoverIndex = pressedIndex = -1; pressedKey = Keys.None; if (Capture) Capture = false; Invalidate(); }
    protected override void OnMouseMove(MouseEventArgs e) { base.OnMouseMove(e); int next = HitTest(e.Location); if (!Enabled || !IsEnabledItem(next)) next = -1; if (hoverIndex != next) { hoverIndex = next; Invalidate(); } }
    protected override void OnMouseLeave(EventArgs e) { base.OnMouseLeave(e); hoverIndex = -1; Invalidate(); }
    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e); if (e.Button != MouseButtons.Left || !Enabled) return;
        int index = HitTest(e.Location); if (!IsEnabledItem(index)) return;
        if (!Focus()) return;
        focusedIndex = index; NotifyFocus(); Capture = true; pressedIndex = index; Invalidate();
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        int previous = pressedIndex;
        if (e.Button == MouseButtons.Left) { pressedIndex = -1; Capture = false; if (Enabled && IsEnabledItem(previous) && HitTest(e.Location) == previous) SelectedIndex = previous; Invalidate(); }
        base.OnMouseUp(e);
    }
    protected override void OnMouseCaptureChanged(EventArgs e) { base.OnMouseCaptureChanged(e); if (!Capture) { pressedIndex = -1; Invalidate(); } }
    protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); focusedIndex = IsEnabledItem(selectedIndex) ? selectedIndex : FirstEnabled(); Invalidate(); NotifyFocus(); }
    protected override void OnLostFocus(EventArgs e) { base.OnLostFocus(e); ResetInteraction(); }
    private void NotifyFocus() { if (IsHandleCreated && focusedIndex >= 0) AccessibilityNotifyClients(AccessibleEvents.Focus, focusedIndex); }
    protected override bool IsInputKey(Keys keyData)
    {
        if ((keyData & (Keys.Alt | Keys.Control)) == 0)
        {
            var key = keyData & Keys.KeyCode;
            if (key is Keys.Space or Keys.Enter or Keys.Home or Keys.End ||
                (orientation == Orientation.Horizontal ? key is Keys.Left or Keys.Right : key is Keys.Up or Keys.Down)) return true;
        }
        return base.IsInputKey(keyData);
    }
    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e); if (e.Handled || !Enabled || e.Alt || e.Control) return;
        int direction = orientation == Orientation.Horizontal ? e.KeyCode == Keys.Right ? 1 : e.KeyCode == Keys.Left ? -1 : 0
            : e.KeyCode == Keys.Down ? 1 : e.KeyCode == Keys.Up ? -1 : 0;
        if (orientation == Orientation.Horizontal && RightToLeft == RightToLeft.Yes) direction = -direction;
        if (e.KeyCode is Keys.Home or Keys.End || direction != 0)
        {
            ResetInteraction(); int target = -1;
            if (e.KeyCode == Keys.Home) target = FirstEnabled();
            else if (e.KeyCode == Keys.End) target = Enumerable.Range(0, Items.Count).LastOrDefault(IsEnabledItem, -1);
            else
            {
                int start = focusedIndex < 0 ? direction > 0 ? -1 : Items.Count : focusedIndex;
                for (int i = start + direction; i >= 0 && i < Items.Count; i += direction) if (IsEnabledItem(i)) { target = i; break; }
            }
            if (target >= 0) { SelectedIndex = target; NotifyFocus(); }
            e.Handled = e.SuppressKeyPress = true;
        }
        else if (e.KeyCode is Keys.Space or Keys.Enter)
        {
            if (IsEnabledItem(focusedIndex)) { pressedIndex = focusedIndex; pressedKey = e.KeyCode; Invalidate(); }
            e.Handled = e.SuppressKeyPress = true;
        }
    }
    protected override void OnKeyUp(KeyEventArgs e)
    {
        base.OnKeyUp(e);
        if (e.KeyCode != pressedKey) return;
        int target = pressedIndex; pressedKey = Keys.None; pressedIndex = -1;
        if (!e.Handled && Enabled && Focused && IsEnabledItem(target)) SelectedIndex = target;
        e.Handled = true; Invalidate();
    }

    protected override AccessibleObject CreateAccessibilityInstance() => new SegmentedAccessibleObject(this);
    private SegmentAccessibleObject AccessibleItem(KSegmentItem item)
    {
        if (!accessibleItems.TryGetValue(item, out var result)) accessibleItems[item] = result = new SegmentAccessibleObject(this, item);
        return result;
    }
    private sealed class SegmentedAccessibleObject(KSegmentedControl owner) : ControlAccessibleObject(owner)
    {
        public override AccessibleRole Role => AccessibleRole.List;
        public override int GetChildCount() => owner.Items.Count;
        public override AccessibleObject? GetChild(int index) => index >= 0 && index < owner.Items.Count ? owner.AccessibleItem(owner.Items[index]) : null;
        public override AccessibleObject? GetSelected() => owner.selectedItem is null ? null : owner.AccessibleItem(owner.selectedItem);
        public override AccessibleObject? GetFocused() => owner.Focused && owner.IsEnabledItem(owner.focusedIndex) ? GetChild(owner.focusedIndex) : null;
        public override AccessibleObject? HitTest(int x, int y) { int index = owner.HitTest(owner.PointToClient(new Point(x, y))); return index >= 0 ? GetChild(index) : base.HitTest(x, y); }
    }
    private sealed class SegmentAccessibleObject(KSegmentedControl owner, KSegmentItem item) : AccessibleObject
    {
        private int Index => owner.Items.IndexOf(item);
        public override string? Name { get => item.Text; set => item.Text = value ?? string.Empty; }
        public override string? Value { get => item.Value; set => item.Value = value ?? string.Empty; }
        public override string DefaultAction => "Seleccionar";
        public override AccessibleRole Role => AccessibleRole.ListItem;
        public override AccessibleObject Parent => owner.AccessibilityObject;
        public override Rectangle Bounds => Index >= 0 && owner.IsHandleCreated ? owner.RectangleToScreen(owner.GetItemBounds(Index)) : Rectangle.Empty;
        public override AccessibleStates State => AccessibleStates.Selectable | AccessibleStates.Focusable
            | (Index < 0 || !owner.Enabled || !item.Enabled ? AccessibleStates.Unavailable : AccessibleStates.None)
            | (ReferenceEquals(owner.selectedItem, item) ? AccessibleStates.Selected : AccessibleStates.None)
            | (owner.Focused && owner.focusedIndex == Index ? AccessibleStates.Focused : AccessibleStates.None)
            | (!owner.Visible || Index < 0 ? AccessibleStates.Invisible : AccessibleStates.None);
        public override void DoDefaultAction() { if (owner.Enabled && item.Enabled && Index >= 0) { owner.Focus(); owner.SelectedItem = item; owner.NotifyFocus(); } }
        public override void Select(AccessibleSelection flags)
        {
            if (!owner.Enabled || !item.Enabled || Index < 0) return;
            if ((flags & AccessibleSelection.TakeFocus) != 0) { owner.Focus(); owner.focusedIndex = Index; owner.NotifyFocus(); owner.Invalidate(); }
            if ((flags & (AccessibleSelection.TakeSelection | AccessibleSelection.AddSelection)) != 0) owner.SelectedItem = item;
            if ((flags & AccessibleSelection.RemoveSelection) != 0 && ReferenceEquals(owner.SelectedItem, item)) owner.SelectedIndex = -1;
        }
        public override AccessibleObject? Navigate(AccessibleNavigation navdir)
        {
            int next = navdir is AccessibleNavigation.Next or AccessibleNavigation.Down or AccessibleNavigation.Right ? Index + 1
                : navdir is AccessibleNavigation.Previous or AccessibleNavigation.Up or AccessibleNavigation.Left ? Index - 1 : -1;
            return next >= 0 && next < owner.Items.Count ? owner.AccessibleItem(owner.Items[next]) : null;
        }
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            pillX.Dispose(); pillY.Dispose(); pillWidth.Dispose(); pillHeight.Dispose(); pillStyle.Dispose();
            Items.DetachAll(); foreach (var transition in transitions.Values) transition.Dispose(); transitions.Clear(); accessibleItems.Clear();
            Surface.Changed -= AppearanceStyleChanged; Appearance.Changed -= AppearanceChanged; SelectedAppearance.Changed -= AppearanceStyleChanged; FocusAppearance.Changed -= AppearanceStyleChanged;
        }
        base.Dispose(disposing);
        if (disposing) { defaultFont?.Dispose(); defaultFont = null; }
    }
}
