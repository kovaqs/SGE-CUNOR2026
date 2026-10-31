namespace Entidades;

public sealed record SesionUsuario(uint IdUsuario, string NombreUsuario, string Nombre, string Rol)
{
    public List<string> Permisos { get; init; } = new();
    public bool Puede(string permiso) => Rol == "Administrador" || Permisos.Contains(permiso);
}
