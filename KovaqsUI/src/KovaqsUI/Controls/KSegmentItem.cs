using System.Collections.ObjectModel;
using System.ComponentModel;

namespace KovaqsUI.Controls;

/// <summary>An editable option with a string identifier. An item belongs to at most one control.</summary>
[ToolboxItem(false), DesignTimeVisible(false), TypeConverter(typeof(ExpandableObjectConverter))]
public sealed class KSegmentItem : Component, INotifyPropertyChanged
{
    private string text = string.Empty, value = string.Empty;
    private bool enabled = true;
    internal KSegmentedControl? Owner { get; set; }

    public KSegmentItem() { }
    public KSegmentItem(string text, string value = "") { this.text = text ?? string.Empty; this.value = value ?? string.Empty; }

    [DefaultValue("")]
    public string Text { get => text; set { value ??= string.Empty; if (text == value) return; text = value; Changed(nameof(Text)); } }
    [DefaultValue("")]
    public string Value { get => value; set { value ??= string.Empty; if (this.value == value) return; this.value = value; Changed(nameof(Value)); } }
    [DefaultValue(true)]
    public bool Enabled { get => enabled; set { if (enabled == value) return; enabled = value; Changed(nameof(Enabled)); } }
    public event PropertyChangedEventHandler? PropertyChanged;
    private void Changed(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    public override string ToString() => string.IsNullOrEmpty(Text) ? "Segmento" : Text;
}

/// <summary>Designer-serializable collection that updates layout and selection on every mutation.</summary>
public sealed class KSegmentItemCollection : Collection<KSegmentItem>
{
    private readonly KSegmentedControl owner;
    internal KSegmentItemCollection(KSegmentedControl owner) => this.owner = owner;
    public void AddRange(params KSegmentItem[] items)
    {
        ArgumentNullException.ThrowIfNull(items);
        foreach (var item in items) Add(item);
    }
    private void Validate(KSegmentItem item)
    {
        ArgumentNullException.ThrowIfNull(item);
        if (item.Owner is not null) throw new ArgumentException("El elemento ya pertenece a un control.", nameof(item));
    }
    private void Attach(KSegmentItem item) { item.Owner = owner; item.PropertyChanged += owner.ItemChanged; }
    private void Detach(KSegmentItem item) { item.PropertyChanged -= owner.ItemChanged; item.Owner = null; }
    protected override void InsertItem(int index, KSegmentItem item)
    {
        Validate(item); base.InsertItem(index, item); Attach(item); owner.ItemsChanged();
    }
    protected override void SetItem(int index, KSegmentItem item)
    {
        if (ReferenceEquals(this[index], item)) return;
        Validate(item); var previous = this[index]; base.SetItem(index, item); Detach(previous); Attach(item); owner.ItemsChanged();
    }
    protected override void RemoveItem(int index)
    {
        var previous = this[index]; base.RemoveItem(index); Detach(previous); owner.ItemsChanged();
    }
    protected override void ClearItems()
    {
        foreach (var item in this) Detach(item);
        base.ClearItems(); owner.ItemsChanged();
    }
    internal void DetachAll() { foreach (var item in this) Detach(item); }
}
