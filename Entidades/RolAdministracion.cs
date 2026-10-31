namespace Entidades;

public class RolAdministracion
{
    public uint IdRol
    {
        get; set;
    }
    public string Nombre { get; set; } = "";
    public string? Descripcion
    {
        get; set;
    }
    public bool Activo { get; set; } = true;
    public List<uint> Permisos { get; set; } = new();
}

public class PermisoSistema
{
    public uint Id
    {
        get; set;
    }
    public string Nombre { get; set; } = "";
}
