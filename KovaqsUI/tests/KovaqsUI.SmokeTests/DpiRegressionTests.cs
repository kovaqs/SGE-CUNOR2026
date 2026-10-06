using System.Runtime.InteropServices;
using KovaqsUI.Controls;
using KovaqsUI.Components;

internal static class DpiRegressionTests
{
    [StructLayout(LayoutKind.Sequential)]
    private struct NativeRect { public int Left, Top, Right, Bottom; }
    [DllImport("user32.dll")] private static extern IntPtr SendMessage(IntPtr hwnd, uint message, IntPtr wParam, ref NativeRect rectangle);
    internal static void Run(Action<bool, string> check)
    {
        using var form = new Form { AutoScaleMode = AutoScaleMode.Dpi, ClientSize = new Size(500, 250) };
        using var button = new KButton { Text = "Scale", Location = new Point(20, 20) };
        using var field = new KTextBox { Text = "Text", Location = new Point(20, 80) };
        using var segments = new KSegmentedControl { Location = new Point(20, 150), Size = new Size(400, 64) };
        segments.Items.AddRange(new KSegmentItem("Día", "day"), new KSegmentItem("Mes", "month"));
        segments.SelectedIndex = 0;
        using var slider = new KSlider { Location = new Point(300, 20), Size = new Size(180, 36), Value = 60 };
        using var toggle = new KSwitch { Location = new Point(300, 65), Text = "Escala", Checked = true };
        form.Controls.AddRange([slider, toggle]);
        form.Controls.AddRange([button, field, segments]); form.Show(); Application.DoEvents();
        using var notifier = new KToastNotifier { OwnerForm = form, Duration = 0, ToastWidth = 180 };
        notifier.Show("DPI", "Aviso escalado");
        int originalDpi = form.DeviceDpi;
        var originalField = field.Size;
        var originalButton = button.Size;
        Console.WriteLine($"Environment: {Screen.AllScreens.Length} screen(s), native initial DPI={originalDpi}.");
        foreach (int dpi in new[] { 120, 144, 192, 96, originalDpi })
        {
            float ratio = (float)dpi / form.DeviceDpi;
            var bounds = form.Bounds;
            var suggested = new NativeRect { Left = bounds.Left, Top = bounds.Top, Right = bounds.Left + (int)(bounds.Width * ratio), Bottom = bounds.Top + (int)(bounds.Height * ratio) };
            SendMessage(form.Handle, 0x02E0, new IntPtr(dpi | (dpi << 16)), ref suggested);
            Application.DoEvents();
            Console.WriteLine($"DPI message {dpi}: form={form.DeviceDpi}, button={button.DeviceDpi}, field={field.DeviceDpi}, editor={field.Editor.DeviceDpi}; field={field.Size}, editor={field.Editor.Bounds}");
            check(form.DeviceDpi == dpi, $"WinForms processes synthetic WM_DPICHANGED ({dpi})");
            using var image = new Bitmap(segments.Width, segments.Height);
            segments.DrawToBitmap(image, segments.ClientRectangle);
            check(segments.GetItemBounds(0).Right < segments.GetItemBounds(1).Left && segments.GetItemBounds(1).Right <= segments.Width,
                $"segmented layout and paint survive DPI message ({dpi})");
            check(field.Editor.Right <= field.ClientSize.Width && field.Editor.Bottom <= field.ClientSize.Height,
                $"native editor remains inside frame after DPI message ({dpi})");
            using var sliderImage = new Bitmap(slider.Width, slider.Height);
            using var switchImage = new Bitmap(toggle.Width, toggle.Height);
            slider.DrawToBitmap(sliderImage, slider.ClientRectangle); toggle.DrawToBitmap(switchImage, toggle.ClientRectangle);
            check(slider.ClientRectangle.Contains(slider.ThumbBounds) && slider.Value == 60 && toggle.Checked,
                $"slider and switch preserve geometry and state after DPI message ({dpi})");
            var toast = form.OwnedForms.Single();
            using var toastImage = new Bitmap(toast.Width, toast.Height); toast.DrawToBitmap(toastImage, toast.ClientRectangle);
            var available = Rectangle.Intersect(form.RectangleToScreen(form.ClientRectangle), Screen.FromControl(form).WorkingArea);
            check(available.Contains(toast.Bounds), $"toast remains in owner working area after DPI message ({dpi})");
        }
        check(Math.Abs(field.Width - originalField.Width) <= 2 && Math.Abs(field.Height - originalField.Height) <= 2
            && Math.Abs(button.Width - originalButton.Width) <= 2 && Math.Abs(button.Height - originalButton.Height) <= 2,
            "synthetic DPI round trip restores control sizes within rounding tolerance");
        Console.WriteLine("Synthetic DPI messages do not change the monitor DPI; child DeviceDpi may remain at the native value. Physical monitor migration remains unverified.");
        form.Close();
    }
}
