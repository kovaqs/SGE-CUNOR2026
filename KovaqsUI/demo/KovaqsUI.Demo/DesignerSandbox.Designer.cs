namespace KovaqsUI.Demo;

partial class DesignerSandbox
{
    private System.ComponentModel.IContainer components = new System.ComponentModel.Container();
    private Controls.KButton actionButton = null!;
    private Controls.KTextBox nameField = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        actionButton = new KovaqsUI.Controls.KButton();
        nameField = new KovaqsUI.Controls.KTextBox();
        slider = new Controls.KSlider();
        toggle = new Controls.KSwitch();
        toastNotifier = new Components.KToastNotifier(components);
        toastNotifier.OwnerForm = this;
        slider.Location = new Point(28, 480); slider.Size = new Size(440, 36); slider.Value = 40; slider.Name = "slider"; slider.TabIndex = 6;
        toggle.Location = new Point(540, 350); toggle.Text = "Notificaciones"; toggle.Size = new Size(250, 36); toggle.Name = "toggle"; toggle.TabIndex = 7;
        kButton1 = new KovaqsUI.Controls.KButton();
        kTextBox1 = new KovaqsUI.Controls.KTextBox();
        horizontalSegments = new Controls.KSegmentedControl();
        verticalSegments = new Controls.KSegmentedControl();
        segmentOne = new Controls.KSegmentItem();
        segmentTwo = new Controls.KSegmentItem();
        segmentThree = new Controls.KSegmentItem();
        segmentFour = new Controls.KSegmentItem();
        segmentOne.Text = "Opción 1"; segmentOne.Value = "one";
        segmentTwo.Text = "Opción 2"; segmentTwo.Value = "two";
        segmentThree.Text = "Opción 3"; segmentThree.Value = "three";
        segmentFour.Text = "Opción 4"; segmentFour.Value = "four"; segmentFour.Enabled = false;
        components.Add(segmentOne, "segmentOne"); components.Add(segmentTwo, "segmentTwo");
        components.Add(segmentThree, "segmentThree"); components.Add(segmentFour, "segmentFour");
        horizontalSegments.Items.AddRange(segmentOne, segmentTwo);
        horizontalSegments.Location = new Point(28, 390); horizontalSegments.Size = new Size(460, 64);
        horizontalSegments.Name = "horizontalSegments"; horizontalSegments.SelectedIndex = 0; horizontalSegments.TabIndex = 4;
        verticalSegments.Items.AddRange(segmentThree, segmentFour);
        verticalSegments.Orientation = Orientation.Vertical; verticalSegments.Location = new Point(540, 40); verticalSegments.Size = new Size(250, 260);
        verticalSegments.Name = "verticalSegments"; verticalSegments.SelectedIndex = 0; verticalSegments.TabIndex = 5;
        SuspendLayout();
        // 
        // actionButton
        // 
        actionButton.BackColor = Color.Transparent;
        actionButton.FlatStyle = FlatStyle.Flat;
        actionButton.Location = new Point(27, 32);
        actionButton.Margin = new Padding(3, 4, 3, 4);
        actionButton.Name = "actionButton";
        actionButton.Padding = new Padding(14, 5, 14, 5);
        actionButton.Size = new Size(160, 53);
        actionButton.TabIndex = 0;
        actionButton.Text = "Continuar";
        actionButton.UseVisualStyleBackColor = false;
        // 
        // nameField
        // 
        nameField.BackColor = Color.Transparent;
        nameField.Location = new Point(27, 126);
        nameField.Margin = new Padding(3, 4, 3, 4);
        nameField.Name = "nameField";
        nameField.Padding = new Padding(14, 11, 14, 11);
        nameField.PlaceholderText = "Escribe aquí";
        nameField.Size = new Size(297, 44);
        nameField.TabIndex = 1;
        nameField.TabStop = false;
        // 
        // kButton1
        // 
        kButton1.Animation.Duration = 180;
        kButton1.Animation.Easing = Styling.KEasing.Linear;
        kButton1.Appearance.Normal.BorderColor = Color.Black;
        kButton1.BackColor = Color.Transparent;
        kButton1.BorderColor = Color.Black;
        kButton1.FlatStyle = FlatStyle.Flat;
        kButton1.Location = new Point(117, 301);
        kButton1.Name = "kButton1";
        kButton1.Padding = new Padding(12, 4, 12, 4);
        kButton1.Size = new Size(140, 50);
        kButton1.TabIndex = 2;
        kButton1.Text = "kButton1";
        kButton1.UseVisualStyleBackColor = false;
        // 
        // kTextBox1
        // 
        kTextBox1.BackColor = Color.Transparent;
        kTextBox1.Lines = new string[]
{
    "kTextBox1"
};
        kTextBox1.Location = new Point(183, 202);
        kTextBox1.Name = "kTextBox1";
        kTextBox1.Padding = new Padding(12, 8, 12, 8);
        kTextBox1.Size = new Size(325, 50);
        kTextBox1.TabIndex = 3;
        kTextBox1.TabStop = false;
        kTextBox1.Text = "kTextBox1";
        // 
        // DesignerSandbox
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(840, 550);
        Controls.Add(slider);
        Controls.Add(toggle);
        Controls.Add(horizontalSegments);
        Controls.Add(verticalSegments);
        Controls.Add(kTextBox1);
        Controls.Add(kButton1);
        Controls.Add(actionButton);
        Controls.Add(nameField);
        Margin = new Padding(3, 4, 3, 4);
        Name = "DesignerSandbox";
        Text = "KovaqsUI · Designer sandbox";
        ResumeLayout(false);
    }

    private Controls.KButton kButton1;
    private Controls.KSlider slider;
    private Controls.KSwitch toggle;
    private Components.KToastNotifier toastNotifier;
    private Controls.KTextBox kTextBox1;
    private Controls.KSegmentedControl horizontalSegments;
    private Controls.KSegmentedControl verticalSegments;
    private Controls.KSegmentItem segmentOne;
    private Controls.KSegmentItem segmentTwo;
    private Controls.KSegmentItem segmentThree;
    private Controls.KSegmentItem segmentFour;
}

