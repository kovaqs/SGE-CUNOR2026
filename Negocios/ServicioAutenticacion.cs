using System.Data.Common;
using Datos;
using Entidades;
using Negocios.Seguridad;

namespace Negocios;

public sealed class ServicioAutenticacion
{
    private readonly RepositorioUsuarios usuarios = new();

    public async Task<bool> HayUsuariosAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            return await usuarios.HayUsuariosAsync(cancellationToken);
        }
        catch (DbException) { throw ErrorConexion(); }
    }

    public async Task CrearAdministradorAsync(string contrasena, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(contrasena) || contrasena.Length is < 12 or > 128)
            throw new ArgumentException("Utiliza una contraseña de 12 a 128 caracteres.");
        var hash = await Task.Run(() => HashContrasenas.Crear(contrasena), cancellationToken);
        try
        {
            await usuarios.CrearAdministradorAsync(hash, cancellationToken);
        }
        catch (DbException) { throw ErrorConexion(); }
    }

    public async Task<SesionUsuario?> IniciarSesionAsync(string nombreUsuario, string contrasena,
        CancellationToken cancellationToken = default)
    {
        nombreUsuario = nombreUsuario.Trim();
        if (nombreUsuario.Length is 0 or > 50 || contrasena.Length is 0 or > 128)
            throw new ArgumentException("Introduce tu usuario y contraseña.");
        try
        {
            var credencial = await usuarios.BuscarAsync(nombreUsuario, cancellationToken);
            var coincide = await Task.Run(() => HashContrasenas.Verificar(contrasena,
                credencial?.Hash ?? HashContrasenas.HashSinUsuario), cancellationToken);
            if (!coincide || credencial is null || !credencial.Activo)
                return null;
            if (!await usuarios.RegistrarAccesoAsync(credencial.Sesion, cancellationToken))
                return null;
            return credencial.Sesion with
            {
                Permisos = await usuarios.PermisosAsync(credencial.Sesion.IdUsuario)
            };
        }
        catch (DbException) { throw ErrorConexion(); }
    }

    public async Task CerrarSesionAsync(SesionUsuario sesion, CancellationToken cancellationToken = default)
    {
        try
        {
            await usuarios.RegistrarSalidaAsync(sesion, cancellationToken);
        }
        catch (DbException) { throw ErrorConexion(); }
    }

    public async Task<bool> ConfirmarClaveAsync(SesionUsuario sesion, string contrasena,
        CancellationToken cancellationToken = default)
    {
        if (contrasena.Length is 0 or > 128)
            return false;
        try
        {
            var credencial = await usuarios.BuscarAsync(sesion.NombreUsuario, cancellationToken);
            var coincide = await Task.Run(() => HashContrasenas.Verificar(contrasena,
                credencial?.Hash ?? HashContrasenas.HashSinUsuario), cancellationToken);
            return coincide && credencial is not null && credencial.Activo
                && credencial.Sesion.IdUsuario == sesion.IdUsuario;
        }
        catch (DbException) { throw ErrorConexion(); }
    }

    private static InvalidOperationException ErrorConexion() => new(
        "No se pudo completar la operación con MySQL. Revisa la conexión y vuelve a intentarlo.");
}
