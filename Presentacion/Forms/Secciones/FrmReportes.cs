namespace Presentacion.Forms.Secciones;

public partial class FrmReportes : Form
{
    public FrmReportes()
    {
        InitializeComponent();
    }

    private void btnExportar_Click(object sender, EventArgs e)
    {
        cmsExportar.Show(btnExportar, new Point(0, btnExportar.Height));
    }

}
