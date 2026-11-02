using Datos;
using Entidades;
using System.Data.Common;

namespace Negocios;

public class ServicioPeriodosNomina
{
    private readonly RepositorioPeriodosNomina repositorio = new();

    public async Task<List<PeriodoNominaListado>> ListarAsync(
        DateTime desde, DateTime hasta, string estado, int pagina, int tamano)
    {
        if (desde.Date > hasta.Date)
            throw new ArgumentException("Revisa el intervalo de fechas.");
        if (pagina < 0 || tamano is < 1 or > 100)
            throw new ArgumentException("Revisa la página y su tamaño.");
        if (estado == "Todos")
            estado = "";
        try
        {
            return await repositorio.ListarAsync(desde.Date, hasta.Date, estado, pagina, tamano);
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudieron consultar los períodos de nómina.");
        }
    }
}
