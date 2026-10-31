using Datos;
using Entidades;

namespace Negocios;

public class ServicioDepartamentos
{
    private readonly RepositorioDepartamentos repositorio = new();
    public Task<List<Departamento>> ListarAsync(string buscar, string estado, int pagina, int tamano) =>
        repositorio.ListarAsync(buscar.Trim(), estado, pagina, tamano);
    public Task GuardarAsync(Departamento departamento, SesionUsuario autor)
    {
        departamento.Nombre = departamento.Nombre.Trim();
        departamento.Descripcion = departamento.Descripcion?.Trim();
        if (departamento.Nombre.Length is 0 or > 100 || departamento.Descripcion?.Length > 500)
            throw new ArgumentException("El nombre es obligatorio (100 caracteres); la descripción admite 500.");
        return repositorio.GuardarAsync(departamento, autor);
    }
}
