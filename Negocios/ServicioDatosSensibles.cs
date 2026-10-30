using Datos;
using Entidades;

namespace Negocios;

public sealed class ServicioDatosSensibles
{
    private readonly RepositorioDatosSensibles repositorio = new();

    public Task<DatosBancarios> LeerCuentaAsync(uint empleado, SesionUsuario sesion) => repositorio.LeerCuentaAsync(empleado, sesion);
    public Task<decimal> LeerSalarioAsync(uint historial, SesionUsuario sesion) => repositorio.LeerSalarioAsync(historial, sesion);

    public Task GuardarCuentaAsync(uint empleado, DatosBancarios datos, SesionUsuario sesion)
    {
        datos.Banco = string.IsNullOrWhiteSpace(datos.Banco) ? null : datos.Banco.Trim();
        datos.Cuenta = string.IsNullOrWhiteSpace(datos.Cuenta) ? null : datos.Cuenta.Trim();
        if (empleado == 0 || datos.Banco?.Length > 100 || datos.Cuenta?.Length > 100)
            throw new ArgumentException("Selecciona el empleado y usa hasta 100 caracteres para banco y cuenta.");
        if (datos.Cuenta is not null && datos.Banco is null)
            throw new ArgumentException("Indica el banco de la cuenta.");
        return repositorio.GuardarCuentaAsync(empleado, datos, sesion);
    }

    public async Task<uint> RegistrarCondicionAsync(CondicionLaboral condicion, SesionUsuario sesion, string contrasena)
    {
        condicion.Motivo = condicion.Motivo.Trim();
        if (condicion.IdEmpleado == 0 || condicion.IdPuesto == 0 || condicion.IdTipoContrato == 0 || condicion.IdHorario == 0
            || condicion.Motivo.Length is 0 or > 500 || condicion.Salario <= 0 || condicion.FechaInicio == default)
            throw new ArgumentException("Completa la condición laboral, su fecha y un salario mayor que cero.");
        ValidarImporte(condicion.Salario);
        if (!await new ServicioAutenticacion().ConfirmarClaveAsync(sesion, contrasena))
            throw new InvalidOperationException("Confirma tu contraseña antes de registrar el cambio de salario.");
        return await repositorio.RegistrarCondicionAsync(condicion, sesion);
    }

    private static void ValidarImporte(decimal importe)
    {
        if (importe < 0 || importe > 999_999_999_999.99m || decimal.Round(importe, 2) != importe)
            throw new ArgumentException("Usa un importe no negativo con hasta dos decimales.");
    }
}
