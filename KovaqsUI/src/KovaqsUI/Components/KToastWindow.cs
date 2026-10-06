using System.Drawing.Drawing2D;
using KovaqsUI.Core;
using KovaqsUI.Drawing;
using KovaqsUI.Styling;

namespace KovaqsUI.Components;

// Presentation only. Queue, lifetime and owner subscriptions belong to KToastNotifier.
internal sealed class KToastWindow : Form
{
    private readonly KToastNotifier notifier;
    private readonly Guid id;
    private readonly string title, message;
    private readonly KToastKind kind;
    private readonly Image? icon;
    private readonly KScalarTransition opacity;
    private float scale = 1;
    private bool closeHover, closePressed;
    private Size shapeSize;
    private int shapeRadius = -1;
    internal KToastWindow(KToastNotifier notifier, Guid id, string title, string message, KToastKind kind, Image? icon)
    {
        this.notifier = notifier; this.id = id; this.title = title; this.message = message; this.kind = kind; this.icon = icon;
        opacity = new(this);
        FormBorderStyle = FormBorderStyle.None; ShowInTaskbar = false; StartPosition = FormStartPosition.Manual; AutoScaleMode = AutoScaleMode.None;
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        AccessibleName = $"{title}. {message}"; AccessibleRole = AccessibleRole.Alert;
    }
    protected override bool ShowWithoutActivation => true;
    protected override CreateParams CreateParams { get { var p = base.CreateParams; p.ExStyle |= 0x08000000 | 0x80; return p; } }
    protected override void WndProc(ref Message m) { if (m.Msg == 0x21) { m.Result = new IntPtr(3); return; } base.WndProc(ref m); }
    internal void BeginAppearance(bool animate) => opacity.Reset(animate ? 0 : 1);
    internal float SampleOpacity(float target, KAnimationStyle options) => opacity.Sample(target, options);
    internal void UpdateShape(float dpiScale)
    {
        scale = dpiScale;
        int radius = (int)Math.Round(notifier.CornerRadius * scale);
        if (shapeSize == Size && shapeRadius == radius) return;
        shapeSize = Size; shapeRadius = radius;
        using var path = KRenderer.Path(ClientRectangle, radius, KShape.Rounded);
        var old = Region; Region = new Region(path); old?.Dispose();
    }
    private Rectangle CloseBounds => notifier.ShowCloseButton ? new Rectangle(Math.Max(0, Width - (int)(40 * scale)), (int)(8 * scale), (int)(32 * scale), (int)(32 * scale)) : Rectangle.Empty;
    internal static int Measure(KToastNotifier manager, string title, string message, int width, float scale)
    {
        int textWidth = Math.Max(1, width - (int)((manager.ShowCloseButton ? 108 : 76) * scale));
        var fonts = manager.RenderFonts(scale);
        const TextFormatFlags flags = TextFormatFlags.WordBreak | TextFormatFlags.NoPrefix;
        int titleHeight = string.IsNullOrEmpty(title) ? 0 : TextRenderer.MeasureText(title, fonts.Title, new Size(textWidth, int.MaxValue), flags).Height;
        int messageHeight = string.IsNullOrEmpty(message) ? 0 : TextRenderer.MeasureText(message, fonts.Body, new Size(textWidth, int.MaxValue), flags).Height;
        return Math.Min((int)(manager.MaximumHeight * scale), Math.Max((int)(80 * scale), titleHeight + messageHeight + (int)(38 * scale)));
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        var theme = notifier.Theme;
        var fonts = notifier.RenderFonts(scale);
        var kindStyle = kind switch { KToastKind.Success => notifier.SuccessAppearance, KToastKind.Warning => notifier.WarningAppearance, KToastKind.Error => notifier.ErrorAppearance, _ => notifier.InformationAppearance };
        var style = new PaintStyle(theme.Surface, Color.Empty, theme.TextPrimary, theme.Border, 90).Apply(notifier.Appearance).Apply(kindStyle);
        e.Graphics.Clear(style.Fill);
        KRenderer.Surface(e.Graphics, ClientRectangle, style, notifier.CornerRadius * scale, notifier.BorderThickness * scale, KShape.Rounded, scale, Color.Empty);
        var accent = kind switch { KToastKind.Success => Color.FromArgb(29, 151, 105), KToastKind.Warning => Color.FromArgb(193, 132, 18), KToastKind.Error => theme.Danger, _ => theme.Focus };
        if (!notifier.IconColor.IsEmpty) accent = notifier.IconColor;
        var iconBounds = new Rectangle((int)(16 * scale), (int)(19 * scale), (int)(24 * scale), (int)(24 * scale));
        if (icon is not null) e.Graphics.DrawImage(icon, iconBounds);
        else
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var pen = new Pen(accent, Math.Max(1, 1.8f * scale)) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            e.Graphics.DrawEllipse(pen, iconBounds);
            float x = iconBounds.Left, y = iconBounds.Top, s = scale;
            if (kind == KToastKind.Success) e.Graphics.DrawLines(pen, new PointF[] { new(x + 6*s, y + 12*s), new(x + 10*s, y + 16*s), new(x + 18*s, y + 8*s) });
            else if (kind == KToastKind.Error) { e.Graphics.DrawLine(pen, x+8*s,y+8*s,x+16*s,y+16*s); e.Graphics.DrawLine(pen,x+16*s,y+8*s,x+8*s,y+16*s); }
            else
            {
                bool info = kind == KToastKind.Information;
                e.Graphics.DrawLine(pen, x+12*s,y+(info ? 11 : 7)*s,x+12*s,y+(info ? 17 : 13)*s);
                using var dot = new SolidBrush(accent); e.Graphics.FillEllipse(dot,x+11*s,y+(info ? 6 : 17)*s,2*s,2*s);
            }
        }
        int left = (int)(54 * scale), right = notifier.ShowCloseButton ? CloseBounds.Left - (int)(6 * scale) : Width - (int)(16 * scale);
        int textWidth = Math.Max(0, right - left), top = (int)(16 * scale), bottom = Math.Max(top, Height - (int)(14 * scale));
        var flags = TextFormatFlags.WordBreak | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix | TextFormatFlags.PreserveGraphicsClipping;
        if (!string.IsNullOrEmpty(title) && textWidth > 0)
        {
            int h = Math.Min((bottom - top) / (string.IsNullOrEmpty(message) ? 1 : 2), TextRenderer.MeasureText(e.Graphics, title, fonts.Title, new Size(textWidth, int.MaxValue), flags).Height);
            TextRenderer.DrawText(e.Graphics, title, fonts.Title, new Rectangle(left, top, textWidth, Math.Max(0,h)), style.Text, flags);
            top += h + (int)(6 * scale);
        }
        if (textWidth > 0 && bottom > top) TextRenderer.DrawText(e.Graphics, message, fonts.Body, new Rectangle(left, top, textWidth, bottom - top), style.Text, flags);
        if (notifier.ShowCloseButton)
        {
            if (closeHover) { using var brush = new SolidBrush(closePressed ? theme.SurfacePressed : theme.SurfaceHover); e.Graphics.FillEllipse(brush, CloseBounds); }
            var r = CloseBounds; int inset = (int)(11 * scale);
            using var pen = new Pen(style.Text, Math.Max(1, 1.5f * scale));
            e.Graphics.DrawLine(pen, r.Left + inset, r.Top + inset, r.Right - inset, r.Bottom - inset);
            e.Graphics.DrawLine(pen, r.Right - inset, r.Top + inset, r.Left + inset, r.Bottom - inset);
        }
        base.OnPaint(e);
    }
    protected override void OnMouseMove(MouseEventArgs e) { base.OnMouseMove(e); bool over = CloseBounds.Contains(e.Location); if (closeHover != over) { closeHover = over; Cursor = over ? Cursors.Hand : Cursors.Default; Invalidate(); } }
    protected override void OnMouseLeave(EventArgs e) { closeHover = false; Invalidate(); base.OnMouseLeave(e); }
    protected override void OnMouseDown(MouseEventArgs e) { closePressed = e.Button == MouseButtons.Left && CloseBounds.Contains(e.Location); if (closePressed) Capture = true; base.OnMouseDown(e); Invalidate(); }
    protected override void OnMouseUp(MouseEventArgs e) { bool close = closePressed && e.Button == MouseButtons.Left && CloseBounds.Contains(e.Location); closePressed = false; Capture = false; base.OnMouseUp(e); Invalidate(); if (close) notifier.Close(id); }
    protected override void OnMouseCaptureChanged(EventArgs e) { if (!Capture) closePressed = false; base.OnMouseCaptureChanged(e); Invalidate(); }
    protected override void OnShown(EventArgs e) { base.OnShown(e); AccessibilityNotifyClients(AccessibleEvents.SystemAlert, -1); }
    protected override AccessibleObject CreateAccessibilityInstance() => new ToastAccessibleObject(this);
    private sealed class ToastAccessibleObject(KToastWindow window) : ControlAccessibleObject(window)
    {
        public override AccessibleRole Role => AccessibleRole.Alert;
        public override int GetChildCount() => window.notifier.ShowCloseButton ? 1 : 0;
        public override AccessibleObject? GetChild(int index) => index == 0 && window.notifier.ShowCloseButton ? new CloseAccessibleObject(window) : null;
    }
    private sealed class CloseAccessibleObject(KToastWindow window) : AccessibleObject
    {
        public override string? Name { get => "Cerrar notificación"; set { } }
        public override string DefaultAction => "Cerrar";
        public override AccessibleRole Role => AccessibleRole.PushButton;
        public override AccessibleObject Parent => window.AccessibilityObject;
        public override Rectangle Bounds => window.RectangleToScreen(window.CloseBounds);
        public override void DoDefaultAction() => window.notifier.Close(window.id);
    }
    protected override void Dispose(bool disposing) { if (disposing) opacity.Dispose(); base.Dispose(disposing); }
}
