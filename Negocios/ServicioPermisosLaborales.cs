using Datos;
using Entidades;
using System.Data.Common;

namespace Negocios;

public class ServicioPermisosLaborales
{
    private readonly RepositorioPermisosLaborales repositorio = new();

    public async Task<List<PermisoLaboralListado>> ListarAsync(
        DateTime desde, DateTime hasta, string estado,
        string buscar, int pagina, int tamano)
    {
        if (desde.Date > hasta.Date)
            throw new ArgumentException("Revisa el intervalo de fechas.");
        if (pagina < 0 || tamano < 1 || tamano > 100)
            throw new ArgumentException("Revisa la página y su tamaño.");
        if (estado == "Todos") estado = "";

        try
        {
            return await repositorio.ListarAsync(
                desde.Date.AddHours(6), hasta.Date.AddDays(1).AddHours(6),
                estado, buscar.Trim(), pagina, tamano);
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo completar la consulta.");
        }
    }
}