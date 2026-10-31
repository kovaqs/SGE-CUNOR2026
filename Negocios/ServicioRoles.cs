using Datos;
using Entidades;

namespace Negocios;

public class ServicioRoles
{
    private readonly RepositorioRoles repositorio = new();
    public Task<List<RolAdministracion>> ListarAsync() => repositorio.ListarAsync();
    public Task<List<PermisoSistema>> PermisosAsync(SesionUsuario autor) => repositorio.PermisosAsync(autor);
    public Task GuardarAsync(RolAdministracion rol, SesionUsuario autor)
    {
        rol.Nombre = rol.Nombre.Trim();
        rol.Descripcion = rol.Descripcion?.Trim();
        if (rol.Nombre.Length is 0 or > 50 || rol.Descripcion?.Length > 250)
            throw new ArgumentException("Escribe el nombre (50 caracteres) y revisa la descripción (250).");
        return repositorio.GuardarAsync(rol, autor);
    }
}
