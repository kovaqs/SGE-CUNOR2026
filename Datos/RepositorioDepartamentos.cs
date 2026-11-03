using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioDepartamentos
{
    public async Task<List<Departamento>> ListarAsync(string buscar, string estado, int pagina, int tamano)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var comando = new MySqlCommand("""
            SELECT id_departamento,nombre,descripcion,activo FROM departamentos
            WHERE nombre LIKE @buscar AND (@estado='Todos' OR activo=(@estado='Activo'))
            ORDER BY nombre,id_departamento LIMIT @limite OFFSET @inicio;
            """, conexion);
        comando.Parameters.AddWithValue("@buscar", "%" + buscar + "%");
        comando.Parameters.AddWithValue("@estado", estado);
        comando.Parameters.AddWithValue("@limite", tamano + 1);
        comando.Parameters.AddWithValue("@inicio", pagina * tamano);
        await using var lector = await comando.ExecuteReaderAsync();
        var lista = new List<Departamento>();
        while (await lector.ReadAsync())
            lista.Add(new Departamento
            {
                IdDepartamento = lector.GetUInt32(0),
                Nombre = lector.GetString(1),
                Descripcion = lector.IsDBNull(2) ? null : lector.GetString(2),
                Activo = lector.GetBoolean(3)
            });
        return lista;
    }
    public async Task GuardarAsync(Departamento departamento, SesionUsuario autor)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        await using var transaccion = await conexion.BeginTransactionAsync();
        await SeguridadDatos.ValidarPermisoAsync(conexion, transaccion, autor, "catalogos");
        bool nuevo = departamento.IdDepartamento == 0;
        await using var comando = new MySqlCommand(nuevo
            ? "INSERT INTO departamentos (nombre,descripcion,activo) VALUES (@nombre,@descripcion,@activo);"
            : "UPDATE departamentos SET nombre=@nombre,descripcion=@descripcion,activo=@activo WHERE id_departamento=@id;", conexion, transaccion);
        comando.Parameters.AddWithValue("@id", departamento.IdDepartamento);
        comando.Parameters.AddWithValue("@nombre", departamento.Nombre);
        comando.Parameters.AddWithValue("@descripcion", (object?)departamento.Descripcion ?? DBNull.Value);
        comando.Parameters.AddWithValue("@activo", departamento.Activo);
        try
        {
            if (await comando.ExecuteNonQueryAsync() != 1)
                throw new InvalidOperationException("El departamento ya no existe.");
            uint id = nuevo ? checked((uint)comando.LastInsertedId) : departamento.IdDepartamento;
            await SeguridadDatos.RegistrarOperacionAsync(conexion, transaccion, autor, nuevo ? "INSERT" : "UPDATE", "departamentos", id, "Registro de departamento.");
            await transaccion.CommitAsync();
        }
        catch (MySqlException ex) when (ex.Number == 1062) { throw new InvalidOperationException("Ya existe un departamento con ese nombre."); }
    }
}
