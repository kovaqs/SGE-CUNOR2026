using Datos;
using Entidades;

namespace Negocios;

public class ServicioNomina
{
    private readonly RepositorioNomina repositorio = new();
    public Task<PeriodoPago> LeerPeriodoAsync(uint id) => repositorio.LeerPeriodoAsync(id);
    public Task<uint> BuscarPeriodoIdAsync(DateTime desde, DateTime hasta) => repositorio.BuscarPeriodoIdAsync(desde, hasta);
    public Task GenerarAsync(uint id, SesionUsuario autor) => repositorio.GenerarAsync(id, autor);
    public Task<List<PagoEmpleado>> PagosAsync(uint periodo, uint departamento, string buscar, int pagina, int tamano, SesionUsuario autor) =>
        repositorio.PagosAsync(periodo, departamento, buscar.Trim(), pagina, tamano, autor);
    public Task<PagoEmpleado> LeerPagoAsync(uint detalle, SesionUsuario autor) => repositorio.LeerPagoAsync(detalle, autor);
    public Task<List<PagoEmpleado>> BoletasAsync(uint periodo, uint departamento, SesionUsuario autor) => repositorio.BoletasAsync(periodo, departamento, autor);
    public Task<List<MovimientoPago>> MovimientosAsync(uint detalle, SesionUsuario autor) => repositorio.MovimientosAsync(detalle, autor);
    public Task EliminarMovimientoAsync(uint movimiento, uint detalle, SesionUsuario autor) => repositorio.EliminarMovimientoAsync(movimiento, detalle, autor);
    public Task<uint> CrearPeriodoAsync(PeriodoPago periodo, SesionUsuario autor)
    {
        periodo.Nombre = periodo.Nombre.Trim();
        if (periodo.Nombre.Length is 0 or > 100 || periodo.Observaciones?.Length > 500)
            throw new ArgumentException("Completa el nombre del período (100) y revisa observaciones (500).");
        if (periodo.Inicio.Day != 1 || periodo.Fin.Date != periodo.Inicio.Date.AddMonths(1).AddDays(-1))
            throw new ArgumentException("La nómina mensual debe abarcar desde el primer hasta el último día del mes.");
        return repositorio.CrearPeriodoAsync(periodo, autor);
    }
    public Task GuardarMovimientoAsync(MovimientoPago movimiento, SesionUsuario autor)
    {
        movimiento.Concepto = movimiento.Concepto.Trim();
        if (movimiento.Tipo == "Deducción")
            movimiento.Tipo = "Deduccion";
        if (movimiento.IdDetalle == 0 || movimiento.Tipo is not ("Ingreso" or "Deduccion") || movimiento.Concepto.Length is 0 or > 150
            || movimiento.Cantidad <= 0 || movimiento.Cantidad > 99999999.99m || decimal.Round(movimiento.Cantidad, 2) != movimiento.Cantidad
            || movimiento.Importe <= 0 || movimiento.Importe > 999999999999.99m || decimal.Round(movimiento.Importe, 2) != movimiento.Importe
            || movimiento.Total > 999999999999.99m)
            throw new ArgumentException("Revisa tipo, concepto, cantidad e importe (positivos, con hasta dos decimales).");
        return repositorio.GuardarMovimientoAsync(movimiento, autor);
    }
    public Task CambiarEstadoAsync(uint id, string estado, SesionUsuario autor)
    {
        if (estado is not ("Cerrado" or "Anulado"))
            throw new ArgumentException("Selecciona un estado válido para el período.");
        return repositorio.CambiarEstadoAsync(id, estado, autor);
    }
}
