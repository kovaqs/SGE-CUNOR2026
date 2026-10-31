using Datos;
using Entidades;

namespace Negocios;

public class ServicioAsistencias
{
    private readonly RepositorioAsistencias repositorio = new();
    public Task<List<RegistroAsistencia>> ListarAsync(DateTime desde, DateTime hasta, uint departamento, string buscar, string estado, int pagina, int tamano)
    {
        if (desde.Date > hasta.Date)
            throw new ArgumentException("Revisa el intervalo de fechas.");
        return repositorio.ListarAsync(desde, hasta, departamento, buscar.Trim(), estado, pagina, tamano);
    }
    public Task<RegistroAsistencia> JornadaAsync(uint empleado, DateTime fecha) => repositorio.JornadaAsync(empleado, fecha);
    public Task GuardarAsync(RegistroAsistencia asistencia, SesionUsuario autor)
    {
        if (asistencia.IdEmpleado == 0 || asistencia.Observaciones?.Length > 500 || asistencia.Tolerancia is < 0 or > 1440)
            throw new ArgumentException("Selecciona un empleado y revisa la tolerancia y observaciones (500 caracteres).");
        if (asistencia.Estado is not ("Pendiente" or "Presente" or "Falta" or "Justificada" or "NoLaborable"))
            throw new ArgumentException("Selecciona un estado válido.");
        if (asistencia.EsLaborable && (asistencia.EntradaPrevista is null || asistencia.SalidaPrevista is null
            || asistencia.SalidaPrevista <= asistencia.EntradaPrevista || asistencia.Estado == "NoLaborable"))
            throw new ArgumentException("Indica las horas previstas de una jornada laborable.");
        if (!asistencia.EsLaborable && (asistencia.Estado != "NoLaborable" || asistencia.EntradaPrevista is not null
            || asistencia.SalidaPrevista is not null || asistencia.Entrada is not null || asistencia.Salida is not null))
            throw new ArgumentException("Un día no laborable no debe tener marcas ni jornada prevista.");
        if (asistencia.Salida is not null && (asistencia.Entrada is null || asistencia.Salida < asistencia.Entrada)
            || asistencia.Estado == "Presente" && asistencia.Entrada is null
            || asistencia.Estado == "Falta" && (asistencia.Entrada is not null || asistencia.Salida is not null))
            throw new ArgumentException("Revisa las marcas: presente requiere entrada, falta no lleva marcas y salida debe ser posterior a entrada.");
        if (asistencia.EntradaPrevista?.Date != asistencia.Fecha.Date && asistencia.EsLaborable)
            throw new ArgumentException("La entrada prevista debe corresponder a la fecha de la jornada.");
        return repositorio.GuardarAsync(asistencia, autor);
    }
}
