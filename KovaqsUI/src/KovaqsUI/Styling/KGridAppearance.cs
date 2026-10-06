using System.ComponentModel;

namespace KovaqsUI.Styling;

/// <summary>Niveles de densidad predeterminados para KDataGridView.</summary>
public enum KGridDensity { Compact, Normal, Comfortable, Custom }

/// <summary>Estilos de divisores de celda para KDataGridView.</summary>
public enum KGridLines { None, Horizontal, Both }

/// <summary>Estilo configurable para los encabezados de columna de KDataGridView.</summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class KGridHeaderStyle
{
    private Color backColor = Color.Empty;
    private Color foreColor = Color.Empty;
    private Color borderColor = Color.Empty;
    private int height;
    internal event EventHandler? Changed;

    [DefaultValue(typeof(Color), "")]
    [Description("Color de fondo del encabezado. Vacío hereda del tema.")]
    public Color BackColor { get => backColor; set { if (backColor == value) return; backColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(typeof(Color), "")]
    [Description("Color de texto del encabezado. Vacío hereda del tema.")]
    public Color ForeColor { get => foreColor; set { if (foreColor == value) return; foreColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(typeof(Color), "")]
    [Description("Color de la línea divisoria inferior del encabezado. Vacío hereda del tema.")]
    public Color BorderColor { get => borderColor; set { if (borderColor == value) return; borderColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(0)]
    [Description("Altura explícita en píxeles lógicos. Cero utiliza la altura según la densidad.")]
    public int Height { get => height; set { ArgumentOutOfRangeException.ThrowIfNegative(value); if (height == value) return; height = value; Changed?.Invoke(this, EventArgs.Empty); } }

    public void ResetBackColor() => BackColor = Color.Empty;
    public bool ShouldSerializeBackColor() => !backColor.IsEmpty;

    public void ResetForeColor() => ForeColor = Color.Empty;
    public bool ShouldSerializeForeColor() => !foreColor.IsEmpty;

    public void ResetBorderColor() => BorderColor = Color.Empty;
    public bool ShouldSerializeBorderColor() => !borderColor.IsEmpty;

    public void ResetHeight() => Height = 0;
    public bool ShouldSerializeHeight() => height != 0;

    public override string ToString() => "Encabezados";
}

/// <summary>Estilo configurable para las filas de datos de KDataGridView.</summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class KGridRowStyle
{
    private Color backColor = Color.Empty;
    private Color foreColor = Color.Empty;
    private Color gridColor = Color.Empty;
    private int height;
    internal event EventHandler? Changed;

    [DefaultValue(typeof(Color), "")]
    [Description("Color de fondo de las filas. Vacío hereda del tema.")]
    public Color BackColor { get => backColor; set { if (backColor == value) return; backColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(typeof(Color), "")]
    [Description("Color de texto principal de las filas. Vacío hereda del tema.")]
    public Color ForeColor { get => foreColor; set { if (foreColor == value) return; foreColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(typeof(Color), "")]
    [Description("Color de las líneas divisorias de las filas. Vacío hereda del tema.")]
    public Color GridColor { get => gridColor; set { if (gridColor == value) return; gridColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(0)]
    [Description("Altura explícita en píxeles lógicos. Cero utiliza la altura según la densidad.")]
    public int Height { get => height; set { ArgumentOutOfRangeException.ThrowIfNegative(value); if (height == value) return; height = value; Changed?.Invoke(this, EventArgs.Empty); } }

    public void ResetBackColor() => BackColor = Color.Empty;
    public bool ShouldSerializeBackColor() => !backColor.IsEmpty;

    public void ResetForeColor() => ForeColor = Color.Empty;
    public bool ShouldSerializeForeColor() => !foreColor.IsEmpty;

    public void ResetGridColor() => GridColor = Color.Empty;
    public bool ShouldSerializeGridColor() => !gridColor.IsEmpty;

    public void ResetHeight() => Height = 0;
    public bool ShouldSerializeHeight() => height != 0;

    public override string ToString() => "Filas";
}

/// <summary>Estilo configurable para filas alternas de KDataGridView.</summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class KGridAlternateRowStyle
{
    private bool enabled;
    private Color backColor = Color.Empty;
    private Color foreColor = Color.Empty;
    internal event EventHandler? Changed;

    [DefaultValue(false)]
    [Description("Indica si se aplica un color diferenciado en filas alternas.")]
    public bool Enabled { get => enabled; set { if (enabled == value) return; enabled = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(typeof(Color), "")]
    [Description("Color de fondo de filas alternas. Vacío deriva un matiz sutil del tema.")]
    public Color BackColor { get => backColor; set { if (backColor == value) return; backColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(typeof(Color), "")]
    [Description("Color de texto de filas alternas. Vacío hereda del estilo de fila.")]
    public Color ForeColor { get => foreColor; set { if (foreColor == value) return; foreColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    public void ResetEnabled() => Enabled = false;
    public bool ShouldSerializeEnabled() => enabled;

    public void ResetBackColor() => BackColor = Color.Empty;
    public bool ShouldSerializeBackColor() => !backColor.IsEmpty;

    public void ResetForeColor() => ForeColor = Color.Empty;
    public bool ShouldSerializeForeColor() => !foreColor.IsEmpty;

    public override string ToString() => enabled ? "Filas alternas (activo)" : "Filas alternas";
}

/// <summary>Estilo de resaltado interactivo al pasar el cursor sobre las filas.</summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class KGridHoverStyle
{
    private bool enabled = true;
    private Color backColor = Color.Empty;
    private Color foreColor = Color.Empty;
    internal event EventHandler? Changed;

    [DefaultValue(true)]
    [Description("Activa el resaltado de la fila bajo el cursor.")]
    public bool Enabled { get => enabled; set { if (enabled == value) return; enabled = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(typeof(Color), "")]
    [Description("Color de fondo al pasar el cursor. Vacío deriva del tema.")]
    public Color BackColor { get => backColor; set { if (backColor == value) return; backColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(typeof(Color), "")]
    [Description("Color de texto al pasar el cursor. Vacío conserva el texto de la fila.")]
    public Color ForeColor { get => foreColor; set { if (foreColor == value) return; foreColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    public void ResetEnabled() => Enabled = true;
    public bool ShouldSerializeEnabled() => !enabled;

    public void ResetBackColor() => BackColor = Color.Empty;
    public bool ShouldSerializeBackColor() => !backColor.IsEmpty;

    public void ResetForeColor() => ForeColor = Color.Empty;
    public bool ShouldSerializeForeColor() => !foreColor.IsEmpty;

    public override string ToString() => enabled ? "Hover (activo)" : "Hover";
}

/// <summary>Estilo de selección para celdas y filas.</summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class KGridSelectionStyle
{
    private Color backColor = Color.Empty;
    private Color foreColor = Color.Empty;
    internal event EventHandler? Changed;

    [DefaultValue(typeof(Color), "")]
    [Description("Color de fondo de selección. Vacío aplica un tono sutil del tema.")]
    public Color BackColor { get => backColor; set { if (backColor == value) return; backColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    [DefaultValue(typeof(Color), "")]
    [Description("Color de texto de selección. Vacío conserva el contraste adecuado.")]
    public Color ForeColor { get => foreColor; set { if (foreColor == value) return; foreColor = value; Changed?.Invoke(this, EventArgs.Empty); } }

    public void ResetBackColor() => BackColor = Color.Empty;
    public bool ShouldSerializeBackColor() => !backColor.IsEmpty;

    public void ResetForeColor() => ForeColor = Color.Empty;
    public bool ShouldSerializeForeColor() => !foreColor.IsEmpty;

    public override string ToString() => "Selección";
}

/// <summary>Agrupa la configuración visual de KDataGridView.</summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class KGridAppearance
{
    public KGridAppearance()
    {
        Header.Changed += (_, _) => Changed?.Invoke(this, EventArgs.Empty);
        Rows.Changed += (_, _) => Changed?.Invoke(this, EventArgs.Empty);
        AlternateRows.Changed += (_, _) => Changed?.Invoke(this, EventArgs.Empty);
        Hover.Changed += (_, _) => Changed?.Invoke(this, EventArgs.Empty);
        Selection.Changed += (_, _) => Changed?.Invoke(this, EventArgs.Empty);
    }

    internal event EventHandler? Changed;

    [Category("Kova Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public KGridHeaderStyle Header { get; } = new();

    [Category("Kova Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public KGridRowStyle Rows { get; } = new();

    [Category("Kova Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public KGridAlternateRowStyle AlternateRows { get; } = new();

    [Category("Kova Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public KGridHoverStyle Hover { get; } = new();

    [Category("Kova Appearance")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    public KGridSelectionStyle Selection { get; } = new();

    public override string ToString() => "Apariencia de tabla";
}
