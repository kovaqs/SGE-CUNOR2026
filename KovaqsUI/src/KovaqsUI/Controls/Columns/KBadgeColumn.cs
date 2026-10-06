using System.ComponentModel;
using System.Drawing.Drawing2D;
using KovaqsUI.Drawing;
using KovaqsUI.Styling;

namespace KovaqsUI.Controls;

/// <summary>Estilo de color para una insignia o píldora de estado.</summary>
public readonly record struct KBadgeStyle(Color BackColor, Color ForeColor, Color BorderColor = default)
{
    public static KBadgeStyle Success { get; } = new(Color.FromArgb(220, 252, 231), Color.FromArgb(22, 101, 52), Color.FromArgb(187, 247, 208));
    public static KBadgeStyle Warning { get; } = new(Color.FromArgb(254, 243, 199), Color.FromArgb(146, 64, 14), Color.FromArgb(253, 230, 138));
    public static KBadgeStyle Danger { get; } = new(Color.FromArgb(254, 226, 226), Color.FromArgb(153, 27, 27), Color.FromArgb(254, 202, 202));
    public static KBadgeStyle Neutral { get; } = new(Color.FromArgb(243, 244, 246), Color.FromArgb(55, 65, 81), Color.FromArgb(229, 231, 235));
    public static KBadgeStyle Info { get; } = new(Color.FromArgb(219, 234, 254), Color.FromArgb(30, 64, 175), Color.FromArgb(191, 219, 254));
}

/// <summary>Columna especializada que dibuja valores como insignias o píldoras redondeadas.</summary>
[ToolboxItem(false)]
public class KBadgeColumn : DataGridViewColumn
{
    private Func<object?, KBadgeStyle>? styleSelector;
    public KBadgeColumn() : base(new KBadgeCell())
    {
        ValueType = typeof(string);
        DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    }

    [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public Func<object?, KBadgeStyle>? StyleSelector
    {
        get => styleSelector;
        set { styleSelector = value; if (DataGridView is not null && Index >= 0) DataGridView.InvalidateColumn(Index); }
    }

    public override object Clone()
    {
        var copy = (KBadgeColumn)base.Clone();
        copy.StyleSelector = StyleSelector;
        return copy;
    }
}

/// <summary>Celda que dibuja su contenido con una píldora visual de estado.</summary>
public class KBadgeCell : DataGridViewTextBoxCell
{
    protected override void Paint(
        Graphics graphics,
        Rectangle clipBounds,
        Rectangle cellBounds,
        int rowIndex,
        DataGridViewElementStates cellState,
        object? value,
        object? formattedValue,
        string? errorText,
        DataGridViewCellStyle cellStyle,
        DataGridViewAdvancedBorderStyle advancedBorderStyle,
        DataGridViewPaintParts paintParts)
    {
        // Pinta fondo y bordes estándar de la fila/celda, omitiendo el texto nativo
        var partsWithoutText = paintParts & ~(DataGridViewPaintParts.ContentForeground | DataGridViewPaintParts.Focus | DataGridViewPaintParts.ErrorIcon);
        base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, partsWithoutText);

        if ((paintParts & DataGridViewPaintParts.ContentForeground) != 0)
            PaintBadge(graphics, clipBounds, cellBounds, value, formattedValue, cellStyle, advancedBorderStyle);
        base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle,
            advancedBorderStyle, paintParts & (DataGridViewPaintParts.Focus | DataGridViewPaintParts.ErrorIcon));
    }

    private void PaintBadge(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, object? value,
        object? formattedValue, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle)
    {


        string text = formattedValue?.ToString() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(text) || cellBounds.Width <= 4 || cellBounds.Height <= 4) return;

        var badgeStyle = ResolveStyle(value ?? formattedValue);
        float scale = DataGridView?.DeviceDpi / 96f ?? 1f;
        Font font = cellStyle.Font ?? Control.DefaultFont;

        var textSize = TextRenderer.MeasureText(graphics, text, font, Size.Empty, TextFormatFlags.NoPrefix | TextFormatFlags.SingleLine);
        int padH = Math.Max(4, (int)(10 * scale));
        var borders = BorderWidths(advancedBorderStyle);
        var padding = cellStyle.Padding;
        var content = new Rectangle(cellBounds.Left + borders.Left + padding.Left,
            cellBounds.Top + borders.Top + padding.Top,
            Math.Max(0, cellBounds.Width - borders.X - borders.Width - padding.Horizontal),
            Math.Max(0, cellBounds.Height - borders.Y - borders.Height - padding.Vertical));
        content.Inflate(-(int)Math.Ceiling(2 * scale), -(int)Math.Ceiling(scale));
        int badgeWidth = Math.Min(content.Width, textSize.Width + padH * 2);
        int badgeHeight = Math.Min(content.Height, Math.Max((int)(20 * scale), textSize.Height + (int)(4 * scale)));

        if (badgeWidth <= 2 || badgeHeight <= 2) return;

        var alignment = cellStyle.Alignment;
        bool rtl = DataGridView?.RightToLeft == RightToLeft.Yes;
        bool left = alignment is DataGridViewContentAlignment.TopLeft or DataGridViewContentAlignment.MiddleLeft or DataGridViewContentAlignment.BottomLeft;
        bool right = alignment is DataGridViewContentAlignment.TopRight or DataGridViewContentAlignment.MiddleRight or DataGridViewContentAlignment.BottomRight;
        if (rtl) (left, right) = (right, left);
        int x = left ? content.Left : right ? content.Right - badgeWidth : content.Left + (content.Width - badgeWidth) / 2;
        int y = alignment switch
        {
            DataGridViewContentAlignment.TopLeft or DataGridViewContentAlignment.TopCenter or DataGridViewContentAlignment.TopRight
                => content.Top,
            DataGridViewContentAlignment.BottomLeft or DataGridViewContentAlignment.BottomCenter or DataGridViewContentAlignment.BottomRight
                => content.Bottom - badgeHeight,
            _ => content.Top + (content.Height - badgeHeight) / 2
        };

        var badgeRect = new RectangleF(x, y, badgeWidth, badgeHeight);
        var state = graphics.Save();
        try
        {
            graphics.SetClip(Rectangle.Intersect(clipBounds, cellBounds), CombineMode.Intersect);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var path = KRenderer.Path(badgeRect, badgeHeight / 2f, KShape.Capsule);
            using var fillBrush = new SolidBrush(badgeStyle.BackColor);
            graphics.FillPath(fillBrush, path);

            if (!badgeStyle.BorderColor.IsEmpty)
            {
                using var borderPen = new Pen(badgeStyle.BorderColor, Math.Max(1f, scale));
                graphics.DrawPath(borderPen, path);
            }

            int textInset = Math.Min(padH / 2, badgeWidth / 3);
            var textRect = new Rectangle(x + textInset, y, Math.Max(0, badgeWidth - textInset * 2), badgeHeight);
            TextRenderer.DrawText(
                graphics,
                text,
                font,
                textRect,
                badgeStyle.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix | TextFormatFlags.EndEllipsis
                | TextFormatFlags.PreserveGraphicsClipping | (rtl ? TextFormatFlags.RightToLeft : 0));
        }
        finally
        {
            graphics.Restore(state);
        }
    }

    private KBadgeStyle ResolveStyle(object? value)
    {
        if (OwningColumn is KBadgeColumn column && column.StyleSelector is not null)
        {
            return column.StyleSelector(value);
        }

        string str = value?.ToString()?.Trim().ToLowerInvariant() ?? string.Empty;
        // Negative states must be resolved before "activ", which also occurs in "inactivo".
        if (str.Contains("rechaz") || str.Contains("inactiv") || str.Contains("cancel") || str.Contains("suspend") || str.Contains("fall"))
            return KBadgeStyle.Danger;
        if (str.Contains("aprob") || str.Contains("activ") || str.Contains("complet") || str.Contains("success") || str.Contains("vigente"))
            return KBadgeStyle.Success;
        if (str.Contains("pend") || str.Contains("espera") || str.Contains("revis") || str.Contains("warn"))
            return KBadgeStyle.Warning;
        if (str.Contains("info") || str.Contains("nuevo") || str.Contains("proceso"))
            return KBadgeStyle.Info;

        return KBadgeStyle.Neutral;
    }
}
