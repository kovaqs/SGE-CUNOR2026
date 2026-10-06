using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using KovaqsUI.Components;
using KovaqsUI.Controls;

internal static class ToolboxDiscoveryTests
{
    internal static void Run(Action<bool, string> check)
    {
        Type[] types = [typeof(KButton), typeof(KTextBox), typeof(KCheckBox), typeof(KRadioButton),
            typeof(KComboBox), typeof(KProgressBar), typeof(KPanel), typeof(KLabel), typeof(KSegmentedControl),
            typeof(KNumericUpDown), typeof(KDataGridView), typeof(KSlider), typeof(KSwitch), typeof(KToastNotifier)];
        using var surface = new DesignSurface(typeof(Form));
        var host = (IDesignerHost)surface.GetService(typeof(IDesignerHost))!;
        foreach (var type in types)
        {
            check(type.IsPublic && !type.IsAbstract && !type.ContainsGenericParameters && typeof(IComponent).IsAssignableFrom(type)
                && type.GetConstructor(Type.EmptyTypes) is not null, $"{type.Name}: public concrete component with default constructor");
            var toolbox = (ToolboxItemAttribute)TypeDescriptor.GetAttributes(type)[typeof(ToolboxItemAttribute)]!;
            check(!toolbox.Equals(ToolboxItemAttribute.None) && toolbox.ToolboxItemType is not null
                && type.GetCustomAttribute<DesignTimeVisibleAttribute>(inherit: false)?.Visible != false,
                $"{type.Name}: not excluded from Toolbox or design time");
            var instance = host.CreateComponent(type);
            if (instance is Control control) ((Form)host.RootComponent!).Controls.Add(control);
            check(instance.Site?.DesignMode == true, $"{type.Name}: constructor loads on DesignSurface");
            if (type == typeof(KDataGridView))
            {
                // The runtime DesignSurface does not ship every Visual Studio OOP designer.
                var nativeGrid = host.CreateComponent(typeof(DataGridView));
                check((host.GetDesigner(instance) is not null) == (host.GetDesigner(nativeGrid) is not null),
                    "KDataGridView designer availability matches native DataGridView in this runtime host");
            }
            else check(host.GetDesigner(instance) is not null, $"{type.Name}: stock designer resolves in runtime host");
        }
        check(typeof(KToastNotifier).GetConstructor([typeof(IContainer)]) is not null, "toast supports component tray container constructor");
        check(((ToolboxItemAttribute)TypeDescriptor.GetAttributes(typeof(KSegmentItem))[typeof(ToolboxItemAttribute)]!).Equals(ToolboxItemAttribute.None),
            "segment item stays excluded intentionally; edit via Items collection");
    }
}
