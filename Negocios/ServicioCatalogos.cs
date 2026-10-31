using Datos;
using Entidades;

namespace Negocios;

public class ServicioCatalogos
{
    private readonly RepositorioCatalogos repositorio = new();
    public Task<List<OpcionCatalogo>> OpcionesAsync(string catalogo, uint departamento = 0, bool incluirInactivos = false) => repositorio.OpcionesAsync(catalogo, departamento, incluirInactivos);
    public Task<List<Puesto>> ListarPuestosAsync(string buscar, uint departamento, string estado, int pagina, int tamano) =>
        repositorio.ListarPuestosAsync(buscar.Trim(), departamento, estado, pagina, tamano);
    public Task<HorarioTrabajo> LeerHorarioAsync(uint id) => repositorio.LeerHorarioAsync(id);
    public Task<Empresa> LeerEmpresaAsync() => repositorio.LeerEmpresaAsync();
    public Task EliminarAsync(string catalogo, uint id, SesionUsuario autor) => repositorio.EliminarAsync(catalogo, id, autor);

    public Task GuardarPuestoAsync(Puesto puesto, SesionUsuario autor)
    {
        puesto.Nombre = puesto.Nombre.Trim();
        puesto.Descripcion = puesto.Descripcion?.Trim();
        if (puesto.IdDepartamento == 0 || puesto.Nombre.Length is 0 or > 100 || puesto.Descripcion?.Length > 500)
            throw new ArgumentException("Selecciona un departamento y completa el nombre (100) y descripción (500).");
        return repositorio.GuardarPuestoAsync(puesto, autor);
    }

    public Task GuardarHorarioAsync(HorarioTrabajo horario, SesionUsuario autor)
    {
        horario.Nombre = horario.Nombre.Trim();
        if (horario.Nombre.Length is 0 or > 100 || horario.Dias.Count == 0)
            throw new ArgumentException("Escribe el nombre y aplica al menos un día de trabajo.");
        foreach (var dia in horario.Dias)
        {
            if (dia.DiaSemana is < 1 or > 7 || dia.Tolerancia is < 0 or > 1440
                || dia.Entrada < TimeSpan.Zero || dia.Entrada >= TimeSpan.FromDays(1)
                || dia.Salida < TimeSpan.Zero || dia.Salida >= TimeSpan.FromDays(1)
                || (!dia.DiaSiguiente && dia.Salida <= dia.Entrada)
                || (dia.DiaSiguiente && dia.Salida >= dia.Entrada))
                throw new ArgumentException("Revisa las horas, el día siguiente y la tolerancia.");
        }
        return repositorio.GuardarHorarioAsync(horario, autor);
    }

    public Task GuardarEmpresaAsync(Empresa empresa, SesionUsuario autor)
    {
        empresa.Nombre = empresa.Nombre.Trim();
        if (empresa.Nombre.Length is 0 or > 150 || empresa.Nit?.Length > 25
            || empresa.Direccion?.Length > 250 || empresa.Telefono?.Length > 25 || empresa.Correo?.Length > 254)
            throw new ArgumentException("Revisa los datos de la empresa y la longitud de los campos.");
        if (!string.IsNullOrWhiteSpace(empresa.Correo) && !System.Net.Mail.MailAddress.TryCreate(empresa.Correo, out _))
            throw new ArgumentException("Escribe un correo válido.");
        return repositorio.GuardarEmpresaAsync(empresa, autor);
    }
}
