using System.ComponentModel;
using System.Drawing.Drawing2D;
using KovaqsUI.Styling;

namespace KovaqsUI.Controls;

/// <summary>Cuadrícula de datos que combina la base nativa de WinForms con el sistema visual y tipográfico de KovaqsUI.</summary>
[ToolboxItem(true)]
[DefaultEvent(nameof(SelectionChanged))]
[DefaultProperty(nameof(DataSource))]
public class KDataGridView : DataGridView, IKThemeControl
{
    private KTheme theme = KTheme.Light;
    private KGridDensity density = KGridDensity.Normal;
    private KGridLines gridLines = KGridLines.Horizontal;
    private int hoverRowIndex = -1;
    private Font? defaultFont;
    private int appliedRowHeight, appliedHeaderHeight;
    private int presetRowHeight = 42, presetHeaderHeight = 38;
    private Color managedBackground = Color.Empty;
    private Color managedGridColor = Color.Empty;
    private bool stylesInitialized;
    private readonly Dictionary<DataGridViewCellStyle, Dictionary<string, Color>> managedColors = new(ReferenceEqualityComparer.Instance);

    [TypeConverter(typeof(KFontConverter))]
    [System.Diagnostics.CodeAnalysis.AllowNull]
    public override Font Font
    {
        get => base.Font;
        set
        {
            base.Font = KFontManager.ResolveFont(value, defaultFont);
        }
    }

    public override void ResetFont() => Font = null;
    private bool ShouldSerializeFont() => !Equals(Font, defaultFont);

    public KDataGridView()
    {
        SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        DoubleBuffered = true;
        EnableHeadersVisualStyles = false;
        BorderStyle = BorderStyle.None;
        CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        RowHeadersVisible = false;
        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        AutoGenerateColumns = true;
        base.Font = defaultFont = KTypography.Body;
        ColumnHeadersDefaultCellStyle.Font = null;
        RowHeadersDefaultCellStyle.Font = null;

        Appearance.Changed += AppearanceChanged;
        ApplyDensityPreset(KGridDensity.Normal);
        ApplyThemeStyles();
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public KTheme Theme
    {
        get => theme;
        set
        {
            theme = value ?? throw new ArgumentNullException(nameof(value));
            ApplyThemeStyles();
        }
    }

    [Category("Kova Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public KGridAppearance Appearance { get; } = new();

    [Category("Kova Layout")]
    [DefaultValue(KGridDensity.Normal)]
    [Description("Nivel de densidad inicial para alturas y espaciados de filas.")]
    public KGridDensity Density
    {
        get => density;
        set
        {
            if (!Enum.IsDefined(value)) throw new InvalidEnumArgumentException(nameof(value), (int)value, typeof(KGridDensity));
            density = value;
            if (value != KGridDensity.Custom) ApplyDensityPreset(value);
        }
    }

    [Category("Kova Layout")]
    [DefaultValue(KGridLines.Horizontal)]
    [Description("Configuración de líneas divisorias entre filas y columnas.")]
    public KGridLines GridLines
    {
        get => gridLines;
        set
        {
            if (!Enum.IsDefined(value)) throw new InvalidEnumArgumentException(nameof(value), (int)value, typeof(KGridLines));
            gridLines = value;
            CellBorderStyle = value switch
            {
                KGridLines.None => DataGridViewCellBorderStyle.None,
                KGridLines.Both => DataGridViewCellBorderStyle.Single,
                _ => DataGridViewCellBorderStyle.SingleHorizontal
            };
        }
    }

    private float DpiScale => DeviceDpi / 96f;
    private int Px(int logical) => (int)Math.Clamp(Math.Round(logical * (double)DpiScale), 1, int.MaxValue);

    private void ApplyDensityPreset(KGridDensity preset)
    {
        int rowHeight = preset switch
        {
            KGridDensity.Compact => Px(32),
            KGridDensity.Comfortable => Px(56),
            _ => Px(42)
        };

        int headerHeight = preset switch
        {
            KGridDensity.Compact => Px(32),
            KGridDensity.Comfortable => Px(46),
            _ => Px(38)
        };

        var padding = preset switch
        {
            KGridDensity.Compact => new Padding(Px(6), Px(2), Px(6), Px(2)),
            KGridDensity.Comfortable => new Padding(Px(10), Px(6), Px(10), Px(6)),
            _ => new Padding(Px(8), Px(4), Px(8), Px(4))
        };

        presetRowHeight = rowHeight;
        presetHeaderHeight = headerHeight;
        RowTemplate.Height = Appearance.Rows.Height > 0 ? RowPixels(Appearance.Rows.Height) : rowHeight;
        ColumnHeadersHeight = Appearance.Header.Height > 0 ? HeaderPixels(Appearance.Header.Height) : headerHeight;
        DefaultCellStyle.Padding = padding;

        foreach (DataGridViewRow row in Rows)
        {
            row.Height = Math.Max(row.MinimumHeight, RowTemplate.Height);
        }
    }

    private int RowPixels(int height) => Math.Clamp(Px(height), 2, 65536);
    private int HeaderPixels(int height) => Math.Clamp(Px(height), 4, 32768);
    private void AppearanceChanged(object? sender, EventArgs e)
    {
        if (!Appearance.Hover.Enabled) ClearHover();
        ApplyThemeStyles();
        // A color change must not reset manually resized rows or scan all data.
        if (appliedRowHeight != Appearance.Rows.Height)
        {
            RowTemplate.Height = Appearance.Rows.Height > 0 ? RowPixels(Appearance.Rows.Height) : presetRowHeight;
            foreach (DataGridViewRow row in Rows) row.Height = Math.Max(row.MinimumHeight, RowTemplate.Height);
            appliedRowHeight = Appearance.Rows.Height;
        }
        if (appliedHeaderHeight != Appearance.Header.Height)
        {
            ColumnHeadersHeight = Appearance.Header.Height > 0 ? HeaderPixels(Appearance.Header.Height) : presetHeaderHeight;
            appliedHeaderHeight = Appearance.Header.Height;
        }
        Invalidate();
    }

    // Preserve direct native overrides while updating values still managed by the theme.
    private void ApplyColor(DataGridViewCellStyle style, string property, Color desired, bool explicitOverride = false)
    {
        var descriptor = TypeDescriptor.GetProperties(style)[property]!;
        var current = (Color)descriptor.GetValue(style)!;
        if (!managedColors.TryGetValue(style, out var colors)) managedColors[style] = colors = [];
        bool managed = colors.TryGetValue(property, out var previous);
        if (explicitOverride || current.IsEmpty || !stylesInitialized || (managed && current == previous))
        {
            descriptor.SetValue(style, desired);
            colors[property] = desired;
        }
    }

    private static Color Blend(Color a, Color b, float amount) => Color.FromArgb(
        (int)(a.R + (b.R - a.R) * amount), (int)(a.G + (b.G - a.G) * amount), (int)(a.B + (b.B - a.B) * amount));

    private void ApplyThemeStyles()
    {
        foreach (var obsolete in managedColors.Keys.Where(style => !ReferenceEquals(style, DefaultCellStyle)
            && !ReferenceEquals(style, ColumnHeadersDefaultCellStyle) && !ReferenceEquals(style, RowHeadersDefaultCellStyle)
            && !ReferenceEquals(style, AlternatingRowsDefaultCellStyle)).ToArray()) managedColors.Remove(obsolete);
        var headerBack = Appearance.Header.BackColor.IsEmpty ? theme.SurfaceHover : Appearance.Header.BackColor;
        var headerFore = Appearance.Header.ForeColor.IsEmpty ? theme.TextSecondary : Appearance.Header.ForeColor;
        foreach (var style in new[] { ColumnHeadersDefaultCellStyle, RowHeadersDefaultCellStyle })
        {
            ApplyColor(style, nameof(style.BackColor), headerBack, !Appearance.Header.BackColor.IsEmpty);
            ApplyColor(style, nameof(style.ForeColor), headerFore, !Appearance.Header.ForeColor.IsEmpty);
            ApplyColor(style, nameof(style.SelectionBackColor), headerBack, !Appearance.Header.BackColor.IsEmpty);
            ApplyColor(style, nameof(style.SelectionForeColor), headerFore, !Appearance.Header.ForeColor.IsEmpty);
        }
        ApplyColor(DefaultCellStyle, nameof(DefaultCellStyle.BackColor), Appearance.Rows.BackColor.IsEmpty ? theme.Surface : Appearance.Rows.BackColor, !Appearance.Rows.BackColor.IsEmpty);
        ApplyColor(DefaultCellStyle, nameof(DefaultCellStyle.ForeColor), Appearance.Rows.ForeColor.IsEmpty ? theme.TextPrimary : Appearance.Rows.ForeColor, !Appearance.Rows.ForeColor.IsEmpty);
        ApplyColor(DefaultCellStyle, nameof(DefaultCellStyle.SelectionBackColor), Appearance.Selection.BackColor.IsEmpty ? Blend(theme.Surface, theme.Focus, .15f) : Appearance.Selection.BackColor, !Appearance.Selection.BackColor.IsEmpty);
        ApplyColor(DefaultCellStyle, nameof(DefaultCellStyle.SelectionForeColor), Appearance.Selection.ForeColor.IsEmpty ? theme.TextPrimary : Appearance.Selection.ForeColor, !Appearance.Selection.ForeColor.IsEmpty);

        var alternate = AlternatingRowsDefaultCellStyle;
        ApplyColor(alternate, nameof(alternate.BackColor), !Appearance.AlternateRows.Enabled ? Color.Empty
            : Appearance.AlternateRows.BackColor.IsEmpty ? Blend(theme.Surface, theme.SurfaceHover, .5f) : Appearance.AlternateRows.BackColor, !Appearance.AlternateRows.BackColor.IsEmpty);
        ApplyColor(alternate, nameof(alternate.ForeColor), Appearance.AlternateRows.Enabled ? Appearance.AlternateRows.ForeColor : Color.Empty, !Appearance.AlternateRows.ForeColor.IsEmpty);
        // Selection and font inherit naturally, including explicit column/cell overrides.
        if (!Appearance.Rows.GridColor.IsEmpty || managedGridColor.IsEmpty || GridColor == managedGridColor)
        {
            managedGridColor = Appearance.Rows.GridColor.IsEmpty ? theme.Border : Appearance.Rows.GridColor;
            GridColor = managedGridColor;
        }
        if (managedBackground.IsEmpty || BackgroundColor == managedBackground)
        {
            managedBackground = DefaultCellStyle.BackColor;
            BackgroundColor = managedBackground;
        }
        stylesInitialized = true;
        Invalidate();
    }
    private void InvalidateRowSafely(int index)
    {
        if (index >= 0 && index < RowCount)
        {
            InvalidateRow(index);
        }
    }

    protected override void OnCellMouseEnter(DataGridViewCellEventArgs e)
    {
        base.OnCellMouseEnter(e);
        if (!Enabled || !Appearance.Hover.Enabled) return;

        if (e.RowIndex >= 0 && e.RowIndex < RowCount)
        {
            if (hoverRowIndex != e.RowIndex)
            {
                int prev = hoverRowIndex;
                hoverRowIndex = e.RowIndex;
                InvalidateRowSafely(prev);
                InvalidateRowSafely(hoverRowIndex);
            }
        }
        else if (e.RowIndex == -1 && hoverRowIndex != -1)
        {
            int prev = hoverRowIndex;
            hoverRowIndex = -1;
            InvalidateRowSafely(prev);
        }
    }

    protected override void OnCellMouseLeave(DataGridViewCellEventArgs e)
    {
        base.OnCellMouseLeave(e);
        if (!Enabled || !Appearance.Hover.Enabled) return;

        // Si el puntero se aleja de la cuadrícula o entra al margen
        if (hoverRowIndex != -1 && !ClientRectangle.Contains(PointToClient(MousePosition)))
        {
            int prev = hoverRowIndex;
            hoverRowIndex = -1;
            InvalidateRowSafely(prev);
        }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        if (hoverRowIndex != -1)
        {
            int prev = hoverRowIndex;
            hoverRowIndex = -1;
            InvalidateRowSafely(prev);
        }
    }

    protected override void OnScroll(ScrollEventArgs e)
    {
        base.OnScroll(e);
        if (hoverRowIndex != -1)
        {
            int prev = hoverRowIndex;
            hoverRowIndex = -1;
            InvalidateRowSafely(prev);
        }
    }

    protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
    {
        // Let the native cell renderer paint the hover style, including checkboxes,
        // badges and editable cells. Never store transient colors on shared rows.
        if (e.CellStyle is not null && Enabled && Appearance.Hover.Enabled && e.RowIndex >= 0 && e.RowIndex == hoverRowIndex
            && e.ColumnIndex >= 0 && (Rows.SharedRow(e.RowIndex).Cells[e.ColumnIndex].GetInheritedState(e.RowIndex) & DataGridViewElementStates.Selected) == 0)
        {
            e.CellStyle.BackColor = Appearance.Hover.BackColor.IsEmpty ? theme.SurfaceHover : Appearance.Hover.BackColor;
            if (!Appearance.Hover.ForeColor.IsEmpty) e.CellStyle.ForeColor = Appearance.Hover.ForeColor;
        }
        base.OnCellFormatting(e);
    }

    protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
    {
        base.OnCellPainting(e);
        if (e.Handled || e.Graphics is null || e.RowIndex != -1 || e.ColumnIndex < 0) return;
        // Native content preserves wrapping, alignment, RTL, per-column styles,
        // sorting glyphs and consumer CellPainting handlers.
        using (var background = new SolidBrush(e.CellStyle?.BackColor ?? ColumnHeadersDefaultCellStyle.BackColor))
            e.Graphics.FillRectangle(background, Rectangle.Intersect(e.CellBounds, e.ClipBounds));
        e.Paint(e.ClipBounds, e.PaintParts & ~DataGridViewPaintParts.Border);
        if ((e.PaintParts & DataGridViewPaintParts.Border) != 0)
        {
            var state = e.Graphics.Save();
            try
            {
                e.Graphics.SetClip(Rectangle.Intersect(e.CellBounds, e.ClipBounds), CombineMode.Intersect);
                using var pen = new Pen(Appearance.Header.BorderColor.IsEmpty ? GridColor : Appearance.Header.BorderColor, Math.Max(1f, DpiScale));
                e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
            }
            finally { e.Graphics.Restore(state); }
        }
        e.Handled = true;
    }

    private void ClearHover()
    {
        int previous = hoverRowIndex; hoverRowIndex = -1; InvalidateRowSafely(previous);
    }
    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        var hit = HitTest(e.X, e.Y);
        if (!Enabled || !Appearance.Hover.Enabled || hit.RowIndex < 0) ClearHover();
        else if (hoverRowIndex != hit.RowIndex)
        {
            ClearHover(); hoverRowIndex = hit.RowIndex; InvalidateRowSafely(hoverRowIndex);
        }
    }
    protected override void OnEnabledChanged(EventArgs e) { base.OnEnabledChanged(e); ClearHover(); Invalidate(); }
    protected override void OnRowsRemoved(DataGridViewRowsRemovedEventArgs e) { ClearHover(); base.OnRowsRemoved(e); }
    protected override void OnSorted(EventArgs e) { ClearHover(); base.OnSorted(e); }
    protected override void OnDataSourceChanged(EventArgs e) { ClearHover(); base.OnDataSourceChanged(e); }
    protected override void OnDpiChangedAfterParent(EventArgs e)
    {
        base.OnDpiChangedAfterParent(e);
        if (density != KGridDensity.Custom) ApplyDensityPreset(density);
        else
        {
            if (Appearance.Header.Height > 0) ColumnHeadersHeight = HeaderPixels(Appearance.Header.Height);
            if (Appearance.Rows.Height > 0)
            {
                RowTemplate.Height = RowPixels(Appearance.Rows.Height);
                foreach (DataGridViewRow row in Rows) row.Height = Math.Max(row.MinimumHeight, RowTemplate.Height);
            }
        }
        ApplyThemeStyles();
        Invalidate();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Appearance.Changed -= AppearanceChanged;
            managedColors.Clear();
        }
        base.Dispose(disposing);
        if (disposing) { defaultFont?.Dispose(); defaultFont = null; }
    }
}
