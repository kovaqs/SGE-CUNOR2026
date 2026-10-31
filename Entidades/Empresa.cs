namespace Entidades;

public class Empresa
{
    public string Nombre { get; set; } = "";
    public string? Nit
    {
        get; set;
    }
    public string? Direccion
    {
        get; set;
    }
    public string? Telefono
    {
        get; set;
    }
    public string? Correo
    {
        get; set;
    }
    public string Moneda { get; set; } = "GTQ";
    public string ZonaHoraria { get; set; } = "America/Guatemala";
}
