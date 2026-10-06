using System.ComponentModel;
using System.Diagnostics;
using KovaqsUI.Core;
using KovaqsUI.Styling;

namespace KovaqsUI.Components;

public enum KToastKind { Success, Information, Warning, Error }
public enum KToastPosition { TopLeft, TopCenter, TopRight, BottomLeft, BottomCenter, BottomRight }

/// <summary>UI-thread component that owns, arranges and disposes transient notification windows.</summary>
[ToolboxItem(true), DefaultProperty(nameof(OwnerForm))]
public sealed class KToastNotifier : Component, IKThemeControl
{
    private readonly int uiThread = Environment.CurrentManagedThreadId;
    private readonly List<Entry> entries = [];
    private Form? owner;
    private KTheme theme = KTheme.Light;
    private readonly Font defaultFont = KTypography.Body, defaultTitleFont = KTypography.Button;
    private Font font, titleFont;
    private Font? renderFont, renderTitleFont;
    private float fontScale;
    private bool disposed, arranging, clockRunning, showCloseButton = true;
    private long lastTick;
    private int duration = 4000, width = 340, maximumHeight = 180, spacing = 8, margin = 16, radius = 12, border = 1, maxVisible = 3, capacity = 100;
    private KToastPosition position = KToastPosition.BottomRight;
    private Color iconColor;
    public KToastNotifier()
    {
        font = defaultFont; titleFont = defaultTitleFont;
        Appearance.Changed += StyleChanged; SuccessAppearance.Changed += StyleChanged; InformationAppearance.Changed += StyleChanged;
        WarningAppearance.Changed += StyleChanged; ErrorAppearance.Changed += StyleChanged;
    }
    public KToastNotifier(IContainer container) : this() { ArgumentNullException.ThrowIfNull(container); container.Add(this); }
    [Category("Behavior"), DefaultValue(null)]
    public Form? OwnerForm
    {
        get => owner;
        set
        {
            VerifyThread(); if (ReferenceEquals(owner, value)) return;
            if (value is { IsDisposed: true }) throw new ObjectDisposedException(nameof(value));
            if (value is { IsHandleCreated: true } && value.InvokeRequired) throw new InvalidOperationException("El propietario debe pertenecer al mismo hilo UI.");
            ClearEntries(); Unsubscribe(); owner = value;
            if (owner is not null)
            {
                owner.LocationChanged += OwnerChanged; owner.SizeChanged += OwnerChanged; owner.VisibleChanged += OwnerChanged;
                owner.DpiChanged += OwnerDpiChanged; owner.FormClosed += OwnerClosed; owner.Disposed += OwnerDisposed; owner.HandleDestroyed += OwnerHandleDestroyed;
            }
        }
    }
    [Category("Layout"), DefaultValue(KToastPosition.BottomRight)]
    public KToastPosition Position { get => position; set { VerifyThread(); if (!Enum.IsDefined(value)) throw new InvalidEnumArgumentException(nameof(value), (int)value, typeof(KToastPosition)); position = value; Arrange(); } }
    [Category("Behavior"), DefaultValue(4000), Description("Duración visible en milisegundos; cero mantiene el aviso hasta cerrarlo.")]
    public int Duration { get => duration; set { VerifyThread(); ValidateDuration(value); duration = value; } }
    [Category("Layout"), DefaultValue(340)] public int ToastWidth { get => width; set { VerifyThread(); Range(value, 120, 2000); width = value; Arrange(); } }
    [Category("Layout"), DefaultValue(180)] public int MaximumHeight { get => maximumHeight; set { VerifyThread(); Range(value, 80, 1000); maximumHeight = value; Arrange(); } }
    [Category("Layout"), DefaultValue(8)] public int Spacing { get => spacing; set { VerifyThread(); Range(value, 0, 200); spacing = value; Arrange(); } }
    [Category("Layout"), DefaultValue(16)] public int EdgeMargin { get => margin; set { VerifyThread(); Range(value, 0, 1000); margin = value; Arrange(); } }
    [Category("Behavior"), DefaultValue(3)] public int MaximumVisible { get => maxVisible; set { VerifyThread(); Range(value, 1, 10); maxVisible = value; Arrange(); } }
    [Category("Behavior"), DefaultValue(100)] public int Capacity { get => capacity; set { VerifyThread(); Range(value, 1, 1000); if (value < entries.Count) throw new ArgumentException("La capacidad es menor que los avisos pendientes."); capacity = value; } }
    [Category("Kova Appearance"), DefaultValue(12)] public int CornerRadius { get => radius; set { VerifyThread(); Range(value, 0, 1000); radius = value; Arrange(); } }
    [Category("Kova Appearance"), DefaultValue(1)] public int BorderThickness { get => border; set { VerifyThread(); Range(value, 0, 20); border = value; RefreshWindows(); } }
    [Category("Kova Appearance"), DefaultValue(true)] public bool ShowCloseButton { get => showCloseButton; set { VerifyThread(); showCloseButton = value; Arrange(); } }
    [Category("Kova Appearance"), DefaultValue(typeof(Color), "")]
    public Color IconColor { get => iconColor; set { VerifyThread(); iconColor = value; RefreshWindows(); } }
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KStateStyle Appearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KStateStyle SuccessAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KStateStyle InformationAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KStateStyle WarningAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KStateStyle ErrorAppearance { get; } = new();
    [Category("Kova Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)] public KAnimationStyle Animation { get; } = new();
    [Category("Appearance"), TypeConverter(typeof(KFontConverter))]
    public Font Font { get => font; set { VerifyThread(); font = KFontManager.ResolveFont(value, defaultFont); ResetRenderFonts(); Arrange(); } }
    public void ResetFont() => Font = defaultFont;
    private bool ShouldSerializeFont() => !Equals(font, defaultFont);
    [Category("Appearance"), TypeConverter(typeof(KFontConverter))]
    public Font TitleFont { get => titleFont; set { VerifyThread(); titleFont = KFontManager.ResolveFont(value, defaultTitleFont); ResetRenderFonts(); Arrange(); } }
    public void ResetTitleFont() => TitleFont = defaultTitleFont;
    private bool ShouldSerializeTitleFont() => !Equals(titleFont, defaultTitleFont);
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public KTheme Theme { get => theme; set { VerifyThread(); theme = value ?? throw new ArgumentNullException(nameof(value)); RefreshWindows(); } }
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public int ActiveCount => entries.Count(e => e.Window?.Visible == true);
    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public int PendingCount => entries.Count - ActiveCount;

    /// <summary>Enqueues a toast. Call on the owner's UI thread after its window is visible.</summary>
    public Guid Show(string title, string message, KToastKind kind = KToastKind.Information, Image? icon = null, int? duration = null)
    {
        VerifyThread();
        if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime) throw new InvalidOperationException("Los avisos se muestran solo durante la ejecución.");
        if (owner is null || !owner.IsHandleCreated || owner.IsDisposed || !owner.Visible) throw new InvalidOperationException("Asigne un OwnerForm visible antes de mostrar avisos.");
        if (!Enum.IsDefined(kind)) throw new InvalidEnumArgumentException(nameof(kind), (int)kind, typeof(KToastKind));
        if (string.IsNullOrWhiteSpace(title) && string.IsNullOrWhiteSpace(message)) throw new ArgumentException("El aviso necesita título o mensaje.");
        int lifetime = duration ?? Duration; ValidateDuration(lifetime);
        if (entries.Count >= capacity) throw new InvalidOperationException("Se alcanzó la capacidad de notificaciones.");
        var entry = new Entry(title ?? string.Empty, message ?? string.Empty, kind, icon, lifetime);
        entries.Add(entry); Arrange(); return entry.Id;
    }
    public bool Close(Guid id)
    {
        VerifyThread(); var entry = entries.Find(e => e.Id == id); if (entry is null) return false;
        if (entry.Window?.Visible != true || !Animate) { Remove(entry); Arrange(); }
        else { entry.Closing = true; StartClock(); }
        return true;
    }
    public void CloseAll() { VerifyThread(); ClearEntries(); }
    private bool Animate => Animation.Enabled && Animation.Duration > 0 && KAnimationSettings.Enabled;
    // Components do not participate in Control.ScaleFont. Cache one pair for the owner's DPI.
    internal (Font Body, Font Title) RenderFonts(float scale)
    {
        if (renderFont is null || fontScale != scale)
        {
            ResetRenderFonts(); fontScale = scale;
            renderFont = font.WithSize(font.Size * scale);
            renderTitleFont = titleFont.WithSize(titleFont.Size * scale);
        }
        return (renderFont, renderTitleFont!);
    }
    private void ResetRenderFonts() { renderFont?.Dispose(); renderTitleFont?.Dispose(); renderFont = renderTitleFont = null; }
    private static void ValidateDuration(int value) => Range(value, 0, 86400000);
    private static void Range(int value, int minimum, int maximum) { if (value < minimum || value > maximum) throw new ArgumentOutOfRangeException(nameof(value)); }
    private void VerifyThread()
    {
        ObjectDisposedException.ThrowIf(disposed, this);
        if (Environment.CurrentManagedThreadId != uiThread) throw new InvalidOperationException("Use el hilo UI del formulario; desde otro hilo utilice OwnerForm.BeginInvoke.");
    }
    private void StyleChanged(object? sender, EventArgs e) { VerifyThread(); RefreshWindows(); }
    private void RefreshWindows() { foreach (var entry in entries) entry.Window?.Invalidate(); }
    private void OwnerChanged(object? sender, EventArgs e) => Arrange();
    private void OwnerDpiChanged(object? sender, DpiChangedEventArgs e) => Arrange();
    private void OwnerClosed(object? sender, FormClosedEventArgs e) => ClearEntries();
    private void OwnerDisposed(object? sender, EventArgs e) { ClearEntries(); Unsubscribe(); owner = null; }
    private void OwnerHandleDestroyed(object? sender, EventArgs e) => ClearEntries();
    private void Unsubscribe()
    {
        if (owner is null) return;
        owner.LocationChanged -= OwnerChanged; owner.SizeChanged -= OwnerChanged; owner.VisibleChanged -= OwnerChanged;
        owner.DpiChanged -= OwnerDpiChanged; owner.FormClosed -= OwnerClosed; owner.Disposed -= OwnerDisposed; owner.HandleDestroyed -= OwnerHandleDestroyed;
    }
    private void Arrange()
    {
        if (arranging || disposed || owner is null || !owner.IsHandleCreated) return;
        arranging = true;
        try
        {
            float scale = owner.DeviceDpi / 96f;
            var area = Rectangle.Intersect(owner.RectangleToScreen(owner.ClientRectangle), Screen.FromControl(owner).WorkingArea);
            int edge = Math.Min((int)(margin * scale), Math.Max(0, Math.Min(area.Width, area.Height) / 2));
            area.Inflate(-edge, -edge);
            bool visible = owner.Visible && owner.WindowState != FormWindowState.Minimized && area.Width >= 80 * scale && area.Height >= 60 * scale;
            bool bottom = position is KToastPosition.BottomLeft or KToastPosition.BottomCenter or KToastPosition.BottomRight;
            int used = 0, count = 0;
            bool blocked = false;
            foreach (var entry in entries)
            {
                int w = Math.Min((int)(width * scale), Math.Max(0, area.Width));
                int h = KToastWindow.Measure(this, entry.Title, entry.Message, w, scale);
                h = Math.Min(h, Math.Max(0, area.Height));
                bool fits = !blocked && visible && count < maxVisible && used + h <= area.Height;
                if (!fits)
                {
                    blocked = true;
                    if (entry.Window is not null) { entry.Window.Dispose(); entry.Window = null; }
                    continue;
                }
                int x = position is KToastPosition.TopLeft or KToastPosition.BottomLeft ? area.Left
                    : position is KToastPosition.TopCenter or KToastPosition.BottomCenter ? area.Left + (area.Width - w) / 2 : area.Right - w;
                int y = bottom ? area.Bottom - used - h : area.Top + used;
                if (entry.Window is null)
                {
                    entry.Window = new KToastWindow(this, entry.Id, entry.Title, entry.Message, entry.Kind, entry.Icon);
                    entry.Window.Bounds = new Rectangle(x, y, w, h);
                    entry.Window.UpdateShape(scale);
                    entry.Window.Opacity = Animate ? .01 : 1;
                    entry.Window.Show(owner);
                    entry.Window.BeginAppearance(Animate);
                }
                else entry.Window.Bounds = new Rectangle(x, y, w, h);
                entry.Window.UpdateShape(scale);
                entry.Window.Invalidate();
                used += h + (int)(spacing * scale); count++;
            }
            if (ActiveCount > 0) StartClock(); else StopClock();
        }
        finally { arranging = false; }
    }
    private void StartClock() { if (clockRunning) return; clockRunning = true; lastTick = Stopwatch.GetTimestamp(); KAnimationClock.Add(Tick); }
    private void StopClock() { clockRunning = false; KAnimationClock.Remove(Tick); }
    private void Tick()
    {
        if (disposed) { StopClock(); return; }
        long now = Stopwatch.GetTimestamp(); double elapsed = Stopwatch.GetElapsedTime(lastTick, now).TotalMilliseconds; lastTick = now;
        bool keepClock = false, changed = false;
        foreach (var entry in entries.ToArray())
        {
            var window = entry.Window; if (window?.Visible != true) continue;
            entry.Elapsed += elapsed;
            if (entry.Duration > 0 && entry.Elapsed >= entry.Duration) entry.Closing = true;
            float opacity = window.SampleOpacity(entry.Closing ? 0 : 1, Animation);
            if (entry.Closing && opacity <= 0) { Remove(entry); changed = true; continue; }
            window.Opacity = Math.Clamp(opacity, .01, 1);
            keepClock |= entry.Duration > 0 || entry.Closing || opacity < 1;
        }
        if (changed) Arrange();
        else if (!keepClock) StopClock();
    }
    private void Remove(Entry entry) { entries.Remove(entry); entry.Window?.Dispose(); entry.Window = null; }
    private void ClearEntries() { StopClock(); foreach (var entry in entries.ToArray()) Remove(entry); }
    protected override void Dispose(bool disposing)
    {
        if (disposing && !disposed)
        {
            VerifyThread(); ClearEntries(); Unsubscribe(); owner = null; disposed = true;
            Appearance.Changed -= StyleChanged; SuccessAppearance.Changed -= StyleChanged; InformationAppearance.Changed -= StyleChanged;
            WarningAppearance.Changed -= StyleChanged; ErrorAppearance.Changed -= StyleChanged;
            ResetRenderFonts(); defaultFont.Dispose(); defaultTitleFont.Dispose();
        }
        base.Dispose(disposing);
    }
    private sealed class Entry(string title, string message, KToastKind kind, Image? icon, int duration)
    {
        internal readonly Guid Id = Guid.NewGuid();
        internal readonly string Title = title, Message = message;
        internal readonly KToastKind Kind = kind;
        internal readonly Image? Icon = icon;
        internal readonly int Duration = duration;
        internal double Elapsed;
        internal bool Closing;
        internal KToastWindow? Window;
    }
}
