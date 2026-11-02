using Datos;
using Entidades;
using System.Data.Common;

namespace Negocios;

public class ServicioHorarios
{
    private readonly RepositorioHorarios repositorio = new();

    public async Task<List<Horariolistado>> ListarAsync()
    {
        try
        {
            return await repositorio.ListarAsync();
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudieron consultar los horarios.");
        }
    }
}