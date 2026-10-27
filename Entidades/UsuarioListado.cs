namespace Entidades;

public sealed record UsuarioListado(uint IdUsuario, string NombreUsuario, string? NombreEmpleado,
    string Rol, bool Activo, DateTime? UltimoAcceso);
