using Entidades;
using MySqlConnector;

namespace Datos;

public class RepositorioDepartamentos
{
    public async Task<List<Departamento>> ListarAsync()
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            SELECT id_departamento, nombre, descripcion, activo
            FROM departamentos ORDER BY nombre;
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        await using var lector = await comando.ExecuteReaderAsync();
        var lista = new List<Departamento>();
        int columnaDescripcion = lector.GetOrdinal("descripcion");
        while (await lector.ReadAsync())
        {
            lista.Add(new Departamento
            {
                IdDepartamento = lector.GetUInt32("id_departamento"),
                Nombre = lector.GetString("nombre"),
                Descripcion = lector.IsDBNull(columnaDescripcion)
                    ? null : lector.GetString("descripcion"),
                Activo = lector.GetBoolean("activo")
            });
        }
        return lista;
    }

    public async Task<uint> CrearAsync(string nombre, string? descripcion)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            INSERT INTO departamentos (nombre, descripcion, activo)
            VALUES (@nombre, @descripcion, TRUE);
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 100).Value = nombre;
        comando.Parameters.Add("@descripcion", MySqlDbType.VarChar, 500).Value =
            (object?)descripcion ?? DBNull.Value;
        try
        {
            await comando.ExecuteNonQueryAsync();
            return checked((uint)comando.LastInsertedId);
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            throw new InvalidOperationException(
                "Ya existe un departamento con ese nombre.");
        }
    }

    public async Task ActualizarAsync(
        uint id, string nombre, string? descripcion)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            UPDATE departamentos
            SET nombre = @nombre, descripcion = @descripcion
            WHERE id_departamento = @id;
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        comando.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 100).Value = nombre;
        comando.Parameters.Add("@descripcion", MySqlDbType.VarChar, 500).Value =
            (object?)descripcion ?? DBNull.Value;
        try
        {
            if (await comando.ExecuteNonQueryAsync() == 0)
                throw new InvalidOperationException(
                    "El departamento no existe.");
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            throw new InvalidOperationException(
                "Ya existe un departamento con ese nombre.");
        }
    }

    public async Task CambiarEstadoAsync(uint id, bool activo)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            UPDATE departamentos SET activo = @activo
            WHERE id_departamento = @id;
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        comando.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
        comando.Parameters.Add("@activo", MySqlDbType.Bool).Value = activo;
        if (await comando.ExecuteNonQueryAsync() == 0)
            throw new InvalidOperationException("El departamento no existe.");
    }
}
