using Datos;
using Entidades;
using System.Data.Common;

namespace Negocios;

public class ServicioTiposContrato
{
    private readonly RepositorioTiposContrato repositorio = new();

    public async Task<List<TipoContrato>> ListarAsync()
    {
        try
        {
            return await repositorio.ListarAsync();
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudieron cargar los tipos de contrato.");
        }
    }

    public async Task<uint> CrearAsync(string nombre, string? descripcion, SesionUsuario autor, bool activo = true)
    {
        ArgumentNullException.ThrowIfNull(autor);
        Validar(nombre, descripcion);
        try
        {
            return await repositorio.CrearAsync(nombre.Trim(), descripcion?.Trim(), autor, activo);
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo crear el tipo de contrato.");
        }
    }

    public async Task ActualizarAsync(uint id, string nombre, string? descripcion, SesionUsuario autor, bool activo = true)
    {
        ArgumentNullException.ThrowIfNull(autor);
        if (id == 0)
            throw new ArgumentException("El ID debe ser mayor que cero.");
        Validar(nombre, descripcion);
        try
        {
            await repositorio.ActualizarAsync(id, nombre.Trim(), descripcion?.Trim(), autor, activo);
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo actualizar el tipo de contrato.");
        }
    }

    public async Task CambiarEstadoAsync(uint id, bool activo, SesionUsuario autor)
    {
        ArgumentNullException.ThrowIfNull(autor);
        if (id == 0)
            throw new ArgumentException("El ID debe ser mayor que cero.");
        try
        {
            await repositorio.CambiarEstadoAsync(id, activo, autor);
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo cambiar el estado.");
        }
    }

    private static void Validar(string nombre, string? descripcion)
    {
        if (string.IsNullOrWhiteSpace(nombre) || nombre.Trim().Length > 80)
            throw new ArgumentException("El nombre es obligatorio y admite 80 caracteres.");
        if (descripcion?.Length > 500)
            throw new ArgumentException("La descripción admite hasta 500 caracteres.");
    }
}
