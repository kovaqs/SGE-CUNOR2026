namespace Presentacion.Forms.Secciones;

partial class FrmPuestos
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        SuspendLayout();
        // lblTitulo
        lblTitulo.AutoSize = true;
        lblTitulo.Location = new Point(12, 9);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Puestos";
        // FrmPuestos
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblTitulo);
        Name = "FrmPuestos";
        Text = "Puestos";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo = null!;
}
