using Entidades;

namespace Presentacion.Forms.Secciones;

public partial class FrmConfiguracion : Form
{
    private SesionUsuario? sesion;

    public FrmConfiguracion()
    {
        InitializeComponent();
    }

    public void EstablecerSesion(SesionUsuario sesion)
    {
        this.sesion = sesion;
        btnConexion.Enabled = sesion.Rol == "Administrador";
    }

    private void btnConexion_Click(object sender, EventArgs e)
    {
        if (sesion?.Rol != "Administrador")
            return;
        using var configuracion = new FrmConfigurarConexion();
        configuracion.ShowDialog(this);
    }
}
