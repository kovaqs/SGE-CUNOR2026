using KovaqsUI.Controls;
using KovaqsUI.Styling;

namespace KovaqsUI.Demo;

internal sealed class SegmentedDemoForm : Form
{
    private readonly List<Control> samples = [];
    private readonly KLabel status = new() { AutoSize = true, Text = "Tab para entrar · flechas para elegir · Enter / Espacio para confirmar" };
    private readonly Font optionFont = KFonts.Inter(12);
    private bool dark;
    private int nextItem = 6;

    public SegmentedDemoForm()
    {
        Text = "KovaqsUI · Selector segmentado"; AutoScaleMode = AutoScaleMode.Dpi;
        ClientSize = new Size(980, 820); MinimumSize = new Size(760, 640); BackColor = KTheme.Light.Background;
        var flow = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true, Padding = new Padding(28) };
        Controls.Add(flow);
        flow.Controls.Add(new KLabel { Text = "Selector segmentado", TextRole = KTextRole.Title, Margin = new Padding(0, 0, 0, 18) });
        flow.Controls.Add(new KLabel { Text = "Horizontal · dos opciones", TextRole = KTextRole.Subtitle });
        var horizontal = Make(2, new Size(880, 72));
        horizontal.FillColor = Color.FromArgb(218, 218, 218); horizontal.SelectedFillColor = Color.White;
        horizontal.ForeColor = horizontal.SelectedForeColor = Color.Black; flow.Controls.Add(horizontal);

        var row = new FlowLayoutPanel { Size = new Size(890, 340), Margin = new Padding(0, 16, 0, 8), WrapContents = false };
        flow.Controls.Add(row);
        var verticalPanel = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, WrapContents = false, Size = new Size(295, 335) };
        row.Controls.Add(verticalPanel);
        verticalPanel.Controls.Add(new KLabel { Text = "Vertical · cuatro opciones", TextRole = KTextRole.Subtitle });
        var vertical = Make(4, new Size(270, 300)); vertical.Orientation = Orientation.Vertical;
        vertical.FillColor = Color.FromArgb(218, 218, 218); vertical.SelectedFillColor = Color.White;
        vertical.ForeColor = vertical.SelectedForeColor = Color.Black; verticalPanel.Controls.Add(vertical);

        var variants = new FlowLayoutPanel { FlowDirection = FlowDirection.TopDown, WrapContents = false, Size = new Size(570, 330), Padding = new Padding(18, 0, 0, 0) };
        row.Controls.Add(variants);
        variants.Controls.Add(new KLabel { Text = "Color, cápsulas y bordes", TextRole = KTextRole.Subtitle });
        var colored = Make(3, new Size(525, 62)); colored.CornerRadius = 30; colored.SegmentCornerRadius = 24;
        colored.FillColor = Color.FromArgb(228, 235, 251); colored.SelectedFillColor = Color.FromArgb(45, 82, 184);
        colored.SelectedForeColor = Color.White; colored.ForeColor = Color.FromArgb(35, 52, 89);
        colored.SelectedAppearance.Hover.FillColor = Color.FromArgb(62, 103, 215);
        colored.SelectedAppearance.Pressed.FillColor = Color.FromArgb(28, 59, 145);
        colored.BorderThickness = 1; colored.BorderColor = Color.FromArgb(174, 193, 236); variants.Controls.Add(colored);
        variants.Controls.Add(new KLabel { Text = "Tamaños por contenido · opción deshabilitada", TextRole = KTextRole.Subtitle, Margin = new Padding(3, 18, 3, 3) });
        var content = Make(0, new Size(525, 62));
        content.Items.AddRange(new KSegmentItem("Día", "day"), new KSegmentItem("Semana", "week"), new KSegmentItem("Todo el período", "all"), new KSegmentItem("Pro", "pro") { Enabled = false });
        content.ItemSizeMode = KSegmentSizeMode.Content; content.SelectedIndex = 1; content.CornerRadius = 8; content.SegmentCornerRadius = 4;
        content.SelectedFillColor = Color.FromArgb(255, 202, 147); content.SelectedForeColor = Color.FromArgb(54, 32, 11); variants.Controls.Add(content);
        variants.Controls.Add(new KLabel { Text = "Control deshabilitado", TextRole = KTextRole.Subtitle, Margin = new Padding(3, 18, 3, 3) });
        var disabled = Make(3, new Size(525, 58)); disabled.Enabled = false; variants.Controls.Add(disabled);

        flow.Controls.Add(new KLabel { Text = "Colección dinámica · agrega, elimina o edita", TextRole = KTextRole.Subtitle });
        var dynamic = Make(5, new Size(880, 60)); dynamic.SelectedIndex = 2; flow.Controls.Add(dynamic);
        var actions = new FlowLayoutPanel { Size = new Size(895, 96), Margin = new Padding(0, 8, 0, 0), WrapContents = true };
        flow.Controls.Add(actions);
        AddAction("Agregar", () => { int id = nextItem++; dynamic.Items.Add(new KSegmentItem($"Opción {id}", $"option-{id}")); });
        AddAction("Eliminar seleccionada", () => { if (dynamic.SelectedIndex >= 0) dynamic.Items.RemoveAt(dynamic.SelectedIndex); });
        AddAction("Editar texto", () => { if (dynamic.SelectedItem is { } item) item.Text = item.Text.EndsWith(" ✓") ? item.Text[..^2] : item.Text + " ✓"; });
        AddAction("Claro / oscuro", () => { dark = !dark; var theme = dark ? KTheme.Dark : KTheme.Light; BackColor = theme.Background; KThemeManager.Apply(this, theme); });
        AddAction("Personalizar…", () => new AppearanceInspector(samples).Show(this));
        AddAction("Animación sí / no", () =>
        {
            foreach (var sample in samples.OfType<KSegmentedControl>()) { sample.Animation.Enabled = !sample.Animation.Enabled; sample.Invalidate(); }
        });
        flow.Controls.Add(status);
        void AddAction(string text, Action action)
        {
            var button = new KButton { Text = text, Variant = KButtonVariant.Outline, Size = new Size(text.Length > 15 ? 195 : 150, 38) };
            button.Click += (_, _) => action(); actions.Controls.Add(button);
        }
    }
    private KSegmentedControl Make(int count, Size size)
    {
        var control = new KSegmentedControl { Size = size, Font = optionFont, Padding = new Padding(10), CornerRadius = 14, SegmentCornerRadius = 12,
            MinimumItemSize = new Size(44, 32), ItemPadding = new Padding(8, 4, 8, 4), AccessibleName = $"Selector de {count} opciones" };
        for (int i = 1; i <= count; i++) control.Items.Add(new KSegmentItem($"Opción {i}", $"option-{i}"));
        control.Animation.Duration = 240;
        if (count > 0) control.SelectedIndex = 0;
        control.SelectedIndexChanged += (_, _) => status.Text = $"Índice: {control.SelectedIndex} · texto: {control.SelectedItem?.Text ?? "sin selección"} · valor: {control.SelectedValue ?? "—"}";
        samples.Add(control); return control;
    }
    protected override void Dispose(bool disposing) { base.Dispose(disposing); if (disposing) optionFont.Dispose(); }
}
