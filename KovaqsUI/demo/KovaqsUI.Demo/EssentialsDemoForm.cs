using System.ComponentModel;
using KovaqsUI.Components;
using KovaqsUI.Controls;
using KovaqsUI.Styling;

namespace KovaqsUI.Demo;

internal sealed class EssentialsDemoForm : Form
{
    private readonly IContainer components = new Container();
    private readonly KToastNotifier notifier;
    private readonly KLabel status = new() { AutoSize = true, Text = "Tab · Flechas / RePág / AvPág · Espacio para alternar", TextRole = KTextRole.Caption };
    private readonly KSlider level = new() { Dock = DockStyle.Top, Value = 40, AccessibleName = "Volumen" };
    private readonly KSwitch darkSwitch = new() { Text = "Tema oscuro", AutoSize = true };
    private readonly KSwitch motionSwitch = new() { Text = "Animaciones", Checked = true, AutoSize = true };
    private readonly Font demoFont = KTypography.Body;
    private readonly List<object> samples = [];
    private readonly List<KPanel> cards = [];

    public EssentialsDemoForm()
    {
        Text = "KovaqsUI · Slider, switch y notificaciones";
        AutoScaleMode = AutoScaleMode.Dpi; Font = demoFont;
        ClientSize = new Size(1060, 760); MinimumSize = new Size(850, 680);
        notifier = new KToastNotifier(components) { OwnerForm = this };
        var root = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(24), ColumnCount = 2, RowCount = 4 };
        root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52)); root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48));
        root.RowStyles.Add(new RowStyle(SizeType.Absolute, 66)); root.RowStyles.Add(new RowStyle(SizeType.Percent, 55));
        root.RowStyles.Add(new RowStyle(SizeType.Percent, 45)); root.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
        Controls.Add(root);
        var heading = new KLabel { Text = "Controles esenciales", TextRole = KTextRole.Title, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
        root.Controls.Add(heading, 0, 0); root.SetColumnSpan(heading, 2);

        var sliderCard = Card("01 / SLIDERS", out var sliderBody); root.Controls.Add(sliderCard, 0, 1);
        var sliderLayout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2 };
        sliderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 76)); sliderLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        sliderBody.Controls.Add(sliderLayout);
        var vertical = new KSlider { Dock = DockStyle.Fill, Orientation = Orientation.Vertical, Value = 65, AccessibleName = "Nivel vertical", TabIndex = 0 };
        vertical.FillAppearance.Normal.FillColor = Color.Teal;
        sliderLayout.Controls.Add(vertical, 0, 0);
        var sliders = Stack(); sliderLayout.Controls.Add(sliders, 1, 0);
        var valueLabel = Caption("Volumen · 40 / 100"); sliders.Controls.Add(valueLabel); sliders.Controls.Add(level);
        level.ValueChanged += (_, _) => { valueLabel.Text = $"Volumen · {level.Value} / 100"; status.Text = $"ValueChanged: {level.Value}"; };
        var square = new KSlider { Width = 310, Value = 25, Minimum = -50, Maximum = 50, SmallChange = 5, TrackThickness = 8, ThumbSize = 22, ThumbCornerRadius = 4, TrackCornerRadius = 4, AccessibleName = "Balance" };
        square.FillAppearance.Normal.FillColor = Color.SlateBlue; square.ThumbAppearance.Normal.FillColor = Color.SlateBlue;
        square.ThumbAppearance.Hover.FillColor = Color.MediumSlateBlue; square.ThumbAppearance.Pressed.FillColor = Color.DarkSlateBlue;
        sliders.Controls.Add(Caption("Balance · −50 a 50 · pasos de 5")); sliders.Controls.Add(square);
        sliders.Controls.Add(Caption("Deshabilitado")); sliders.Controls.Add(new KSlider { Width = 310, Value = 70, Enabled = false });
        sliders.SizeChanged += (_, _) => { foreach (Control c in sliders.Controls) if (c is KSlider) c.Width = Math.Max(40, sliders.ClientSize.Width - 12); };
        samples.AddRange([level, vertical, square]);

        var switchCard = Card("02 / SWITCHES", out var switchBody); root.Controls.Add(switchCard, 1, 1);
        var switches = Stack(); switchBody.Controls.Add(switches);
        switches.Controls.Add(darkSwitch); switches.Controls.Add(motionSwitch);
        var compact = new KSwitch { Text = "Sincronización", Checked = true, SwitchSize = new Size(36, 20), ThumbInset = 2, Height = 30, AutoSize = true };
        compact.CheckedAppearance.Normal.FillColor = Color.Teal;
        var squareSwitch = new KSwitch { Text = "Thumb cuadrado", SwitchSize = new Size(58, 30), CornerRadius = 7, ThumbCornerRadius = 4, AutoSize = true };
        squareSwitch.CheckedAppearance.Normal.FillColor = Color.SlateBlue;
        var disabled = new KSwitch { Text = "Activado · deshabilitado", Checked = true, Enabled = false, AutoSize = true };
        switches.Controls.AddRange([compact, squareSwitch, disabled]);
        foreach (var sample in new[] { compact, squareSwitch }) sample.CheckedChanged += (_, _) => status.Text = $"{sample.Text}: {(sample.Checked ? "On" : "Off")}";
        samples.AddRange([darkSwitch, motionSwitch, compact, squareSwitch, disabled]);

        var toastCard = Card("03 / NOTIFICACIONES", out var toastBody); root.Controls.Add(toastCard, 0, 2); root.SetColumnSpan(toastCard, 2);
        var toastStack = Stack(); toastBody.Controls.Add(toastStack);
        toastStack.Controls.Add(Caption("Avisos ligados a esta ventana; se apilan y el excedente espera su turno."));
        var options = Row(); toastStack.Controls.Add(options);
        var position = new KComboBox { Width = 180, AccessibleName = "Posición de los avisos" };
        position.Items.AddRange(Enum.GetValues<KToastPosition>().Cast<object>().ToArray());
        position.SelectedItem = notifier.Position; position.SelectedIndexChanged += (_, _) => notifier.Position = (KToastPosition)position.SelectedItem!;
        var lifetime = new KNumericUpDown { Width = 135, Minimum = 0, Maximum = 15, Value = 4, AccessibleName = "Duración en segundos" };
        lifetime.ValueChanged += (_, _) => notifier.Duration = (int)lifetime.Value * 1000;
        options.Controls.AddRange([position, lifetime, Caption("segundos · 0 = persistente")]);
        var actions = Row(); toastStack.Controls.Add(actions);
        foreach (var kind in Enum.GetValues<KToastKind>())
        {
            var button = Action(kind.ToString(), () => ShowToast(kind)); actions.Controls.Add(button);
        }
        var extras = Row(); toastStack.Controls.Add(extras);
        extras.Controls.Add(Action("Probar cola × 5", () => { for (int i = 0; i < 5; i++) ShowToast((KToastKind)(i % 4)); }));
        extras.Controls.Add(Action("Cerrar avisos", notifier.CloseAll));
        extras.Controls.Add(Action("Otra ventana", () => new EssentialsDemoForm().Show(this)));
        samples.Add(notifier);

        var footer = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoScroll = true, WrapContents = true };
        footer.Controls.Add(Action("Personalizar…", OpenInspector)); footer.Controls.Add(status);
        root.Controls.Add(footer, 0, 3); root.SetColumnSpan(footer, 2);
        darkSwitch.CheckedChanged += (_, _) => ApplyTheme(darkSwitch.Checked ? KTheme.Dark : KTheme.Light);
        motionSwitch.CheckedChanged += (_, _) =>
        {
            foreach (var item in samples)
            {
                if (item is KSlider slider) slider.Animation.Enabled = motionSwitch.Checked;
                if (item is KSwitch toggle) toggle.Animation.Enabled = motionSwitch.Checked;
            }
            notifier.Animation.Enabled = motionSwitch.Checked;
            Invalidate(true);
        };
        ApplyTheme(KTheme.Light);
    }
    private void ShowToast(KToastKind kind)
    {
        try
        {
            notifier.Show(kind switch { KToastKind.Success => "Cambios guardados", KToastKind.Warning => "Revisa los datos", KToastKind.Error => "No se pudo completar", _ => "Información disponible" },
                kind switch { KToastKind.Success => "La operación terminó correctamente.", KToastKind.Warning => "Hay campos que necesitan tu atención.", KToastKind.Error => "Puedes volver a intentarlo en un momento.", _ => "Este aviso conserva el foco en tu tarea." }, kind);
            status.Text = $"Visibles: {notifier.ActiveCount} · En cola: {notifier.PendingCount}";
        }
        catch (InvalidOperationException e) { status.Text = e.Message; }
    }
    internal void ApplyDark() => darkSwitch.Checked = true;
    internal void ShowToastPreview()
    {
        notifier.Duration = 0; notifier.MaximumVisible = 4;
        foreach (var kind in Enum.GetValues<KToastKind>()) ShowToast(kind);
    }
    private void ApplyTheme(KTheme value)
    {
        BackColor = value.Background; notifier.Theme = value; KThemeManager.Apply(this, value);
        foreach (var card in cards) card.BackColor = Color.Transparent;
    }
    private KPanel Card(string title, out Panel body)
    {
        var card = new KPanel { Dock = DockStyle.Fill, Padding = new Padding(16), Margin = new Padding(0, 0, 12, 14) };
        var label = new KLabel { Text = title, TextRole = KTextRole.Section, Dock = DockStyle.Top, Height = 32 };
        body = new Panel { Dock = DockStyle.Fill, BackColor = Color.Transparent };
        card.Controls.Add(body); card.Controls.Add(label); cards.Add(card); return card;
    }
    private static FlowLayoutPanel Stack() => new() { Dock = DockStyle.Fill, FlowDirection = FlowDirection.TopDown, WrapContents = false, AutoScroll = true };
    private static FlowLayoutPanel Row() => new() { AutoSize = true, WrapContents = true, Margin = new Padding(0, 3, 0, 3) };
    private static KLabel Caption(string text) => new() { Text = text, AutoSize = true, TextRole = KTextRole.Caption, Margin = new Padding(3, 5, 3, 5) };
    private static KButton Action(string text, System.Action click)
    {
        var button = new KButton { Text = text, Variant = KButtonVariant.Outline, Size = new Size(148, 36), Margin = new Padding(3) };
        button.Click += (_, _) => click(); return button;
    }
    private void OpenInspector()
    {
        var form = new Form { Text = "KovaqsUI · Personalización", ClientSize = new Size(450, 640), ShowInTaskbar = false };
        var grid = new PropertyGrid { Dock = DockStyle.Fill };
        var selector = new ComboBox { Dock = DockStyle.Top, DropDownStyle = ComboBoxStyle.DropDownList };
        foreach (var item in samples) selector.Items.Add(item is Control c ? $"{c.GetType().Name} · {c.AccessibleName ?? c.Text}" : nameof(KToastNotifier));
        selector.SelectedIndexChanged += (_, _) => grid.SelectedObject = samples[selector.SelectedIndex];
        form.Controls.Add(grid); form.Controls.Add(selector); selector.SelectedIndex = 0; form.Show(this);
    }
    protected override void Dispose(bool disposing)
    {
        if (disposing) components.Dispose();
        base.Dispose(disposing);
        if (disposing) demoFont.Dispose();
    }
}
