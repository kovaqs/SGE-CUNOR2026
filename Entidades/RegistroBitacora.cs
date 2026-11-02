namespace Entidades;

public class RegistroBitacora
{
    public DateTime Fecha { get; set; }
    public string Usuario { get; set; } = "";
    public string Operacion { get; set; } = "";
    public string Entidad { get; set; } = "";
    public string Registro { get; set; } = "";
    public string Descripcion { get; set; } = "";
}
