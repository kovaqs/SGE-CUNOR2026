using Datos;
using Entidades;

namespace Negocios;

public class ServicioPermisosTrabajo
{
    private readonly RepositorioPermisosTrabajo repositorio = new();
    public Task<PermisoTrabajo> BuscarAsync(string empleado, DateTime inicio) => repositorio.BuscarAsync(empleado, inicio);
    public Task GuardarAsync(PermisoTrabajo permiso, SesionUsuario autor)
    {
        permiso.Motivo = permiso.Motivo.Trim();
        if (permiso.IdEmpleado == 0 || permiso.Fin <= permiso.Inicio || permiso.Motivo.Length is 0 or > 500)
            throw new ArgumentException("Completa empleado, motivo (500 caracteres) y un intervalo de fechas válido.");
        return repositorio.GuardarAsync(permiso, autor);
    }
    public Task ResolverAsync(uint id, string estado, string observaciones, SesionUsuario autor)
    {
        if (id == 0 || estado is not ("Aprobado" or "Rechazado" or "Cancelado") || observaciones.Length > 500)
            throw new ArgumentException("Revisa la resolución y observaciones (500 caracteres).");
        return repositorio.ResolverAsync(id, estado, observaciones.Trim(), autor);
    }
}
