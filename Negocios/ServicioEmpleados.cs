using Datos;
using Entidades;

namespace Negocios;

public class ServicioEmpleados
{
    private readonly RepositorioEmpleados repositorio = new();
    public Task<List<EmpleadoListado>> ListarAsync(string buscar, uint departamento, uint contrato, string estado, int pagina, int tamano) =>
        repositorio.ListarAsync(buscar.Trim(), departamento, contrato, estado, pagina, tamano);
    public Task<Empleado> BuscarAsync(uint id, SesionUsuario autor) => repositorio.BuscarAsync(id, autor);
    public Task<List<HistorialEmpleado>> HistorialAsync(uint id, SesionUsuario autor) => repositorio.HistorialAsync(id, autor);
    public Task EliminarAsync(uint id, SesionUsuario autor) => repositorio.EliminarAsync(id, autor);
    public Task CambiarEstadoAsync(uint id, string estado, DateTime? baja, SesionUsuario autor)
    {
        if (estado is not ("Activo" or "Suspendido" or "Inactivo"))
            throw new ArgumentException("Selecciona un estado válido.");
        return repositorio.CambiarEstadoAsync(id, estado, estado == "Inactivo" ? baja : null, autor);
    }

    public Task<uint> GuardarAsync(Empleado empleado, SesionUsuario autor)
    {
        empleado.Codigo = empleado.Codigo.Trim();
        empleado.Dpi = empleado.Dpi.Trim();
        empleado.Nombres = empleado.Nombres.Trim();
        empleado.Apellidos = empleado.Apellidos.Trim();
        if (empleado.Codigo.Length is 0 or > 20 || empleado.Dpi.Length != 13 || !empleado.Dpi.All(char.IsAsciiDigit)
            || empleado.Nombres.Length is 0 or > 100 || empleado.Apellidos.Length is 0 or > 100)
            throw new ArgumentException("Completa código (20), DPI de 13 dígitos, nombres y apellidos (100).");
        if (empleado.FechaNacimiento?.Date > empleado.FechaContratacion.Date || empleado.FechaNacimiento?.Date > DateTime.Today)
            throw new ArgumentException("La fecha de nacimiento no puede ser posterior a la contratación o al día de hoy.");
        if (empleado.Telefono?.Length > 25 || empleado.Correo?.Length > 254 || empleado.Direccion?.Length > 250)
            throw new ArgumentException("Revisa la longitud del teléfono, correo y dirección.");
        if (!string.IsNullOrWhiteSpace(empleado.Correo) && !System.Net.Mail.MailAddress.TryCreate(empleado.Correo, out _))
            throw new ArgumentException("Escribe un correo electrónico válido.");
        if (empleado.Fotografia?.Length > 65535)
            throw new ArgumentException("La fotografía reducida todavía supera 64 KB.");
        var banco = empleado.DatosBancarios;
        banco.Banco = string.IsNullOrWhiteSpace(banco.Banco) ? null : banco.Banco.Trim();
        banco.Cuenta = string.IsNullOrWhiteSpace(banco.Cuenta) ? null : banco.Cuenta.Trim();
        if (banco.Banco?.Length > 100 || banco.Cuenta?.Length > 100 || (banco.Cuenta is not null && banco.Banco is null))
            throw new ArgumentException("Revisa el banco y número de cuenta (hasta 100 caracteres).");
        if (empleado.IdEmpleado == 0)
        {
            var condicion = empleado.Condicion;
            condicion.Motivo = condicion.Motivo.Trim();
            if (condicion.IdPuesto == 0 || condicion.IdTipoContrato == 0 || condicion.IdHorario == 0 || condicion.Salario <= 0
                || condicion.Salario > 999999999999.99m || decimal.Round(condicion.Salario, 2) != condicion.Salario
                || condicion.FechaInicio.Date < empleado.FechaContratacion.Date || condicion.Motivo.Length is 0 or > 500)
                throw new ArgumentException("Completa puesto, contrato, horario, salario, vigencia y motivo de la contratación.");
        }
        return repositorio.GuardarAsync(empleado, autor);
    }
}
