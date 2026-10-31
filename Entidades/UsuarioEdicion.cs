namespace Entidades;

public class UsuarioEdicion
{
    public uint IdUsuario
    {
        get; set;
    }
    public string NombreUsuario { get; set; } = "";
    public uint IdRol
    {
        get; set;
    }
    public uint? IdEmpleado
    {
        get; set;
    }
    public bool Activo
    {
        get; set;
    }
}
