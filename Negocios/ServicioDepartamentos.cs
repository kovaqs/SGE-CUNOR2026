using Datos;
using Entidades;
using System.Data.Common;

namespace Negocios;

public class ServicioDepartamentos
{
    private readonly RepositorioDepartamentos repositorio = new();

    public async Task<List<Departamento>> ListarAsync()
    {
        try { return await repositorio.ListarAsync(); }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudieron cargar los departamentos.");
        }
    }

    public async Task<uint> CrearAsync(string nombre, string? descripcion)
    {
        Validar(nombre, descripcion);
        try { return await repositorio.CrearAsync(nombre.Trim(), descripcion?.Trim()); }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo crear el departamento.");
        }
    }

    public async Task ActualizarAsync(uint id, string nombre, string? descripcion)
    {
        if (id == 0) throw new ArgumentException("El ID debe ser mayor que cero.");
        Validar(nombre, descripcion);
        try { await repositorio.ActualizarAsync(id, nombre.Trim(), descripcion?.Trim()); }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo actualizar el departamento.");
        }
    }

    public async Task CambiarEstadoAsync(uint id, bool activo)
    {
        if (id == 0) throw new ArgumentException("El ID debe ser mayor que cero.");
        try { await repositorio.CambiarEstadoAsync(id, activo); }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo cambiar el estado.");
        }
    }

    private static void Validar(string nombre, string? descripcion)
    {
        if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length > 100)
            throw new ArgumentException("El nombre es obligatorio y admite 100 caracteres.");
        if (descripcion?.Length > 500)
            throw new ArgumentException("La descripción admite hasta 500 caracteres.");
    }
}
