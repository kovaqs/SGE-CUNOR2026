using Datos;
using Entidades;
using System.Data.Common;

namespace Negocios;

public class ServicioBitacora
{
    private readonly RepositorioBitacora repositorio = new();

    public async Task<List<RegistroBitacora>> ListarAsync(
        DateTime desde, DateTime hasta, string usuario,
        string operacion, string entidad)
    {
        if (desde.Date > hasta.Date)
            throw new ArgumentException("Revisa el intervalo de fechas.");
        if (usuario == "Todos") usuario = "";
        if (operacion == "Todas") operacion = "";
        if (entidad == "Todas") entidad = "";
        try
        {
            return await repositorio.ListarAsync(
                desde.Date.AddHours(6), hasta.Date.AddDays(1).AddHours(6),
                usuario.Trim(), operacion, entidad.Trim());
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo consultar la bitácora.");
        }
    }
}
