using System.ComponentModel;
using KovaqsUI.Core;
using KovaqsUI.Drawing;
using KovaqsUI.Styling;

namespace KovaqsUI.Controls;

/// <summary>Animated two-state switch retaining native CheckBox input, binding and accessibility.</summary>
[ToolboxItem(true), DefaultProperty(nameof(Checked)), DefaultEvent(nameof(CheckedChanged)), DefaultBindingProperty(nameof(Checked))]
public class KSwitch : CheckBox, IKThemeControl
{
    private KTheme theme = KTheme.Light;
    private Font? defaultFont;
    private readonly KScalarTransition motion;
    private readonly KStateTransition surfaceTransition, thumbTransition;
    private bool hover, pressed, mousePress;
    private Size switchSize = new(48, 26);
    private int thumbSize, thumbInset = 3, radius = 13, thumbRadius = 12, border = 1, thumbBorder, gap = 10;
    private Color normalForeColor;
    public KSwitch()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);
        motion = new(this); surfaceTransition = new(this); thumbTransition = new(this);
        BackColor = Color.Transparent; Size = new Size(160, 34); Padding = new Padding(3); base.ThreeState = false;
        base.Font = defaultFont = KTypography.Label;
        AppearanceStates.Changed += Changed; CheckedAppearance.Changed += Changed; ThumbAppearance.Changed += Changed; FocusAppearance.Changed += Changed;
        base.Paint += PaintFace;
    }
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new bool ThreeState { get => false; set { if (value) throw new ArgumentException("KSwitch utiliza solo dos estados.", nameof(value)); base.ThreeState = false; } }
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public new CheckState CheckState { get => base.CheckState; set { if (value == CheckState.Indeterminate) throw new ArgumentException("KSwitch utiliza solo dos estados.", nameof(value)); base.CheckState = value; } }
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAppearance AppearanceStates { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAppearance CheckedAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAppearance ThumbAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KFocusStyle FocusAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAnimationStyle Animation { get; } = new();
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public KTheme Theme { get => theme; set { theme = value ?? throw new ArgumentNullException(nameof(value)); Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(typeof(Size), "48, 26")]
    public Size SwitchSize { get => switchSize; set { if (value.Width < 1 || value.Height < 1 || value.Width > 4096 || value.Height > 4096) throw new ArgumentOutOfRangeException(nameof(value)); switchSize = value; LayoutChanged(); } }
    [Category("Kova Appearance"), DefaultValue(0), Description("Cero ajusta el thumb al alto interior del switch.")]
    public int ThumbSize { get => thumbSize; set { Dimension(value); thumbSize = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(3)] public int ThumbInset { get => thumbInset; set { Dimension(value); thumbInset = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(13)] public int CornerRadius { get => radius; set { Dimension(value); radius = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(12)] public int ThumbCornerRadius { get => thumbRadius; set { Dimension(value); thumbRadius = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(1)] public int BorderThickness { get => border; set { Dimension(value); border = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(0)] public int ThumbBorderThickness { get => thumbBorder; set { Dimension(value); thumbBorder = value; Invalidate(); } }
    [Category("Kova Appearance"), DefaultValue(10)] public int TextSpacing { get => gap; set { Dimension(value); gap = value; LayoutChanged(); } }
    [TypeConverter(typeof(KFontConverter)), System.Diagnostics.CodeAnalysis.AllowNull]
    public override Font Font { get => base.Font; set => base.Font = KFontManager.ResolveFont(value, defaultFont); }
    public override void ResetFont() => Font = null;
    private bool ShouldSerializeFont() => !Equals(Font, defaultFont);
    public override Color ForeColor
    {
        get => base.ForeColor;
        set { if (AppearanceStates is null) base.ForeColor = value; else AppearanceStates.Normal.ForeColor = value; }
    }
    protected override Cursor DefaultCursor => Cursors.Hand;
    protected override Padding DefaultPadding => new(3);
    private float DpiScale => DeviceDpi / 96f;
    private static void Dimension(int value) { if (value < 0 || value > 4096) throw new ArgumentOutOfRangeException(nameof(value)); }
    private void LayoutChanged() { Parent?.PerformLayout(this, nameof(SwitchSize)); Invalidate(); }
    private void Changed(object? sender, EventArgs e)
    {
        if (normalForeColor != AppearanceStates.Normal.ForeColor)
        { normalForeColor = AppearanceStates.Normal.ForeColor; base.ForeColor = normalForeColor; }
        Invalidate();
    }
    private PaintStyle Resolve(KAppearance appearance, Color fill, Color ink)
    {
        var style = new PaintStyle(fill, Color.Empty, ink, theme.Border, 90).Apply(appearance.Normal);
        if (!Enabled) return (style with { Fill = ReferenceEquals(appearance, ThumbAppearance) ? theme.DisabledText : theme.DisabledFill, Text = theme.DisabledText, Border = theme.DisabledBorder }).Apply(appearance.Disabled);
        bool pushing = pressed && (!mousePress || hover);
        if (appearance.Normal.FillColor.IsEmpty && !ReferenceEquals(appearance, ThumbAppearance))
        {
            if (hover) style = style with { Fill = Checked ? theme.PrimaryHover : theme.TextSecondary };
            if (pushing) style = style with { Fill = Checked ? theme.PrimaryPressed : theme.TextSecondary };
        }
        if (Focused) style = style.Apply(appearance.Focused);
        if (hover) style = style.Apply(appearance.Hover);
        if (pushing) style = style.Apply(appearance.Pressed);
        return style;
    }
    private void PaintFace(object? sender, PaintEventArgs e)
    {
        base.OnPaintBackground(e);
        var area = Rectangle.FromLTRB(Math.Min(Width, Padding.Left), Math.Min(Height, Padding.Top), Math.Max(Padding.Left, Width - Padding.Right), Math.Max(Padding.Top, Height - Padding.Bottom));
        area.Intersect(ClientRectangle);
        bool rtl = RightToLeft == RightToLeft.Yes;
        int width = Math.Max(0, Math.Min(area.Width, (int)Math.Round(switchSize.Width * DpiScale)));
        int height = Math.Max(0, Math.Min(area.Height, (int)Math.Round(switchSize.Height * DpiScale)));
        var track = new Rectangle(rtl ? area.Right - width : area.Left, area.Top + (area.Height - height) / 2, width, height);
        var appearance = Checked ? CheckedAppearance : AppearanceStates;
        Color ink = AppearanceStates.Normal.ForeColor.IsEmpty ? theme.TextPrimary : AppearanceStates.Normal.ForeColor;
        var style = surfaceTransition.Sample(Resolve(appearance, Checked ? theme.Primary : theme.Border, ink), Animation);
        KRenderer.Surface(e.Graphics, track, style, radius * DpiScale, border * DpiScale, KShape.Rounded, DpiScale,
            Focused && Enabled ? FocusAppearance.Resolve(appearance.Focused.BorderColor, theme.Focus) : Color.Empty, FocusAppearance.Thickness, FocusAppearance.Inset);
        int inset = Math.Min(Math.Min(width, height) / 2, (int)Math.Round((thumbInset + border) * DpiScale));
        int diameter = Math.Max(0, Math.Min(Math.Min(width, height) - inset * 2, thumbSize == 0 ? height : (int)Math.Round(thumbSize * DpiScale)));
        float fraction = motion.Sample(Checked ? 1 : 0, Animation);
        if (rtl) fraction = 1 - fraction;
        var thumb = new Rectangle(track.Left + inset + (int)MathF.Round(Math.Max(0, width - inset * 2 - diameter) * fraction), track.Top + (height - diameter) / 2, diameter, diameter);
        var knob = thumbTransition.Sample(Resolve(ThumbAppearance, theme.OnSecondary, theme.TextPrimary), Animation);
        KRenderer.Surface(e.Graphics, thumb, knob, thumbRadius * DpiScale, thumbBorder * DpiScale, KShape.Rounded, DpiScale, Color.Empty);
        int textGap = string.IsNullOrEmpty(Text) ? 0 : (int)Math.Round(gap * DpiScale);
        var textArea = rtl ? Rectangle.FromLTRB(area.Left, area.Top, Math.Max(area.Left, track.Left - textGap), area.Bottom)
            : Rectangle.FromLTRB(Math.Min(area.Right, track.Right + textGap), area.Top, area.Right, area.Bottom);
        var flags = TextFormatFlags.EndEllipsis | TextFormatFlags.PreserveGraphicsClipping;
        bool centered = TextAlign is ContentAlignment.TopCenter or ContentAlignment.MiddleCenter or ContentAlignment.BottomCenter;
        bool right = TextAlign is ContentAlignment.TopRight or ContentAlignment.MiddleRight or ContentAlignment.BottomRight;
        if (centered) flags |= TextFormatFlags.HorizontalCenter;
        else if (right != rtl) flags |= TextFormatFlags.Right;
        if (TextAlign is ContentAlignment.MiddleLeft or ContentAlignment.MiddleCenter or ContentAlignment.MiddleRight) flags |= TextFormatFlags.VerticalCenter;
        else if (TextAlign is ContentAlignment.BottomLeft or ContentAlignment.BottomCenter or ContentAlignment.BottomRight) flags |= TextFormatFlags.Bottom;
        flags |= UseMnemonic ? (ShowKeyboardCues ? 0 : TextFormatFlags.HidePrefix) : TextFormatFlags.NoPrefix;
        if (rtl) flags |= TextFormatFlags.RightToLeft;
        if (textArea.Width > 0 && textArea.Height > 0) TextRenderer.DrawText(e.Graphics, Text, Font, textArea, style.Text, flags);
    }
    public override Size GetPreferredSize(Size proposedSize)
    {
        var text = string.IsNullOrEmpty(Text) ? Size.Empty : TextRenderer.MeasureText(Text, Font);
        return new Size((int)Math.Ceiling(switchSize.Width * DpiScale) + (text.Width == 0 ? 0 : text.Width + (int)(gap * DpiScale)) + Padding.Horizontal,
            Math.Max((int)Math.Ceiling(switchSize.Height * DpiScale), text.Height) + Padding.Vertical);
    }
    protected override void OnCheckedChanged(EventArgs e) { base.OnCheckedChanged(e); Invalidate(); }
    protected override void OnMouseEnter(EventArgs e) { hover = true; base.OnMouseEnter(e); Invalidate(); }
    protected override void OnMouseLeave(EventArgs e) { hover = false; base.OnMouseLeave(e); Invalidate(); }
    protected override void OnMouseDown(MouseEventArgs e) { if (Enabled && e.Button == MouseButtons.Left) { mousePress = pressed = true; hover = ClientRectangle.Contains(e.Location); } base.OnMouseDown(e); Invalidate(); }
    protected override void OnMouseMove(MouseEventArgs e) { bool over = ClientRectangle.Contains(e.Location); if (hover != over) { hover = over; Invalidate(); } base.OnMouseMove(e); }
    protected override void OnMouseUp(MouseEventArgs e) { pressed = mousePress = false; base.OnMouseUp(e); Invalidate(); }
    protected override void OnMouseCaptureChanged(EventArgs e) { if (!Capture) pressed = mousePress = false; base.OnMouseCaptureChanged(e); Invalidate(); }
    protected override void OnKeyDown(KeyEventArgs e) { if (Enabled && e.KeyCode == Keys.Space && e.Modifiers == Keys.None) { pressed = true; mousePress = false; } base.OnKeyDown(e); Invalidate(); }
    protected override void OnKeyUp(KeyEventArgs e) { pressed = false; base.OnKeyUp(e); Invalidate(); }
    protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); Invalidate(); }
    protected override void OnLostFocus(EventArgs e) { pressed = mousePress = false; base.OnLostFocus(e); Invalidate(); }
    protected override void OnEnabledChanged(EventArgs e) { pressed = mousePress = hover = false; base.OnEnabledChanged(e); Invalidate(); }
    protected override void OnVisibleChanged(EventArgs e) { if (!Visible) { pressed = mousePress = hover = false; motion?.Reset(Checked ? 1 : 0); } base.OnVisibleChanged(e); }
    protected override void OnDpiChangedAfterParent(EventArgs e) { base.OnDpiChangedAfterParent(e); LayoutChanged(); }
    protected override void OnStyleChanged(EventArgs e) { SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true); base.OnStyleChanged(e); }
    protected override CreateParams CreateParams
    {
        get
        {
            if (base.FlatStyle == FlatStyle.System) base.FlatStyle = FlatStyle.Flat;
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            return base.CreateParams;
        }
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing) { base.Paint -= PaintFace; motion.Dispose(); surfaceTransition.Dispose(); thumbTransition.Dispose(); AppearanceStates.Changed -= Changed; CheckedAppearance.Changed -= Changed; ThumbAppearance.Changed -= Changed; FocusAppearance.Changed -= Changed; }
        base.Dispose(disposing); if (disposing) { defaultFont?.Dispose(); defaultFont = null; }
    }
}
