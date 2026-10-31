using System.Data.Common;
using Datos;
using Entidades;
using Negocios.Seguridad;

namespace Negocios;

public sealed class ServicioUsuarios
{
    private readonly RepositorioUsuarios usuarios = new();

    public async Task<List<UsuarioListado>> ListarAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            return await usuarios.ListarAsync(cancellationToken);
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudieron cargar los usuarios. Revisa la conexión y vuelve a intentarlo.");
        }
    }

    public async Task<List<Rol>> ListarRolesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            return await usuarios.ListarRolesAsync(cancellationToken);
        }
        catch (DbException) { throw new InvalidOperationException("No se pudieron cargar los roles."); }
    }

    public async Task<List<EmpleadoSeleccion>> ListarEmpleadosDisponiblesAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            return await usuarios.ListarEmpleadosDisponiblesAsync(cancellationToken);
        }
        catch (DbException) { throw new InvalidOperationException("No se pudieron cargar los empleados."); }
    }

    public async Task CrearAsync(string nombreUsuario, string contrasena, uint idRol, uint? idEmpleado, bool activo,
        SesionUsuario autor, CancellationToken cancellationToken = default)
    {
        nombreUsuario = nombreUsuario.Trim();
        if (nombreUsuario.Length is 0 or > 50)
            throw new ArgumentException("Introduce un usuario de hasta 50 caracteres.");
        if (string.IsNullOrWhiteSpace(contrasena) || contrasena.Length is < 12 or > 128)
            throw new ArgumentException("Usa una contraseña de 12 a 128 caracteres.");
        if (idRol == 0 || idEmpleado == 0)
            throw new ArgumentException("Selecciona un rol y un empleado válidos.");
        if (!autor.Puede("usuarios"))
            throw new InvalidOperationException("Solo un administrador puede crear usuarios.");

        var hash = await Task.Run(() => HashContrasenas.Crear(contrasena), cancellationToken);
        try
        {
            await usuarios.CrearAsync(nombreUsuario, hash, idRol, idEmpleado, activo, autor, cancellationToken);
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo guardar. Revisa la conexión.");
        }
    }

    public async Task<SesionUsuario> ActualizarCuentaAsync(SesionUsuario sesion, string nombreUsuario,
        string contrasenaActual, string contrasenaNueva, CancellationToken cancellationToken = default)
    {
        nombreUsuario = nombreUsuario.Trim();
        if (nombreUsuario.Length is 0 or > 50)
            throw new ArgumentException("Introduce un nombre de usuario de hasta 50 caracteres.");
        if (contrasenaActual.Length is 0 or > 128)
            throw new ArgumentException("Introduce tu contraseña actual para guardar los cambios.");
        if (contrasenaNueva.Length > 0 && (string.IsNullOrWhiteSpace(contrasenaNueva) || contrasenaNueva.Length is < 12 or > 128))
            throw new ArgumentException("La contraseña nueva debe tener de 12 a 128 caracteres.");
        try
        {
            var credencial = await usuarios.BuscarPorIdAsync(sesion.IdUsuario, cancellationToken);
            var coincide = await Task.Run(() => HashContrasenas.Verificar(contrasenaActual,
                credencial?.Hash ?? HashContrasenas.HashSinUsuario), cancellationToken);
            if (!coincide || credencial is null || !credencial.Activo)
                throw new InvalidOperationException("La contraseña actual no coincide o la cuenta ya no está activa.");
            if (nombreUsuario == credencial.Sesion.NombreUsuario && contrasenaNueva.Length == 0)
                throw new ArgumentException("No hay cambios para guardar.");
            var hashNuevo = contrasenaNueva.Length == 0 ? null
                : await Task.Run(() => HashContrasenas.Crear(contrasenaNueva), cancellationToken);
            var actual = await usuarios.ActualizarCuentaAsync(credencial.Sesion, nombreUsuario,
                credencial.Hash, hashNuevo, cancellationToken);
            return actual with
            {
                Permisos = sesion.Permisos
            };
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudieron guardar los cambios. Revisa la conexión.");
        }
    }

    public Task<UsuarioEdicion> LeerEdicionAsync(uint id) => usuarios.LeerEdicionAsync(id);
    public Task GuardarEdicionAsync(UsuarioEdicion usuario, SesionUsuario autor)
    {
        usuario.NombreUsuario = usuario.NombreUsuario.Trim();
        if (usuario.IdUsuario == autor.IdUsuario)
            throw new InvalidOperationException("Para cambiar tu propia cuenta usa Mi cuenta. Otro administrador puede modificar tu rol.");
        if (usuario.IdRol == 0 || usuario.NombreUsuario.Length is 0 or > 50)
            throw new ArgumentException("Escribe el usuario (50 caracteres) y selecciona un rol activo.");
        return usuarios.GuardarEdicionAsync(usuario, autor);
    }
    public async Task RestablecerAsync(uint usuario, string contrasena, SesionUsuario autor)
    {
        if (usuario == autor.IdUsuario)
            throw new InvalidOperationException("Para cambiar tu contraseña usa Mi cuenta.");
        if (string.IsNullOrWhiteSpace(contrasena) || contrasena.Length is < 12 or > 128)
            throw new ArgumentException("Usa una contraseña de 12 a 128 caracteres.");
        var hash = await Task.Run(() => HashContrasenas.Crear(contrasena));
        await usuarios.RestablecerAsync(usuario, hash, autor);
    }
}
