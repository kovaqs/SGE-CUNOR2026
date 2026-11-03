namespace Entidades;

public class Puesto
{
    public uint IdPuesto
    {
        get; set;
    }
    public uint IdDepartamento
    {
        get; set;
    }
    public string Departamento { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string? Descripcion
    {
        get; set;
    }
    public bool Activo { get; set; } = true;
}
