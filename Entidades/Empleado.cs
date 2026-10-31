namespace Entidades;

public class Empleado
{
    public uint IdEmpleado
    {
        get; set;
    }
    public string Codigo { get; set; } = "";
    public string Dpi { get; set; } = "";
    public string Nombres { get; set; } = "";
    public string Apellidos { get; set; } = "";
    public DateTime? FechaNacimiento
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
    public string? Direccion
    {
        get; set;
    }
    public byte[]? Fotografia
    {
        get; set;
    }
    public string? FotografiaTipo
    {
        get; set;
    }
    public DateTime FechaContratacion { get; set; } = DateTime.Today;
    public DateTime? FechaBaja
    {
        get; set;
    }
    public string Estado { get; set; } = "Activo";
    public DatosBancarios DatosBancarios { get; set; } = new();
    public CondicionLaboral Condicion { get; set; } = new();
}
