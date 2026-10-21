using System.Data.Common;
using Datos;
using Entidades;

namespace Negocios;

public sealed class ServicioUsuarios
{
    private readonly RepositorioUsuarios usuarios = new();

    public async Task<List<UsuarioListado>> ListarAsync(CancellationToken cancellationToken = default)
    {
        try { return await usuarios.ListarAsync(cancellationToken); }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudieron cargar los usuarios. Revisa la conexión y vuelve a intentarlo.");
        }
    }
}
