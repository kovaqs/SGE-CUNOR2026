using Entidades;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos;

public class RepositorioTiposContrato
{
    public async Task<List<TipoContrato>> ListarAsync()
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            SELECT id_tipo_contrato, nombre, descripcion, activo
            FROM tipos_contrato ORDER BY nombre;
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        await using var lector = await comando.ExecuteReaderAsync();
        var lista = new List<TipoContrato>();
        int columnaDescripcion = lector.GetOrdinal("descripcion");

        while (await lector.ReadAsync())
        {
            lista.Add(new TipoContrato
            {
                IdTipoContrato = lector.GetUInt32("id_tipo_contrato"),
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
            INSERT INTO tipos_contrato (nombre, descripcion, activo)
            VALUES (@nombre, @descripcion, TRUE);
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 80).Value = nombre;
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
                "Ya existe un tipo de contrato con ese nombre.");
        }
    }

    public async Task ActualizarAsync(
        uint id, string nombre, string? descripcion)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            UPDATE tipos_contrato
            SET nombre = @nombre, descripcion = @descripcion
            WHERE id_tipo_contrato = @id;
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        comando.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
        comando.Parameters.Add("@nombre", MySqlDbType.VarChar, 80).Value = nombre;
        comando.Parameters.Add("@descripcion", MySqlDbType.VarChar, 500).Value =
            (object?)descripcion ?? DBNull.Value;
        try
        {
            if (await comando.ExecuteNonQueryAsync() == 0)
                throw new InvalidOperationException(
                    "El tipo de contrato no existe.");
        }
        catch (MySqlException ex) when (ex.Number == 1062)
        {
            throw new InvalidOperationException(
                "Ya existe un tipo de contrato con ese nombre.");
        }
    }

    public async Task CambiarEstadoAsync(uint id, bool activo)
    {
        await using var conexion = await ConexionMySql.AbrirAsync();
        const string sql = """
            UPDATE tipos_contrato SET activo = @activo
            WHERE id_tipo_contrato = @id;
            """;
        await using var comando = new MySqlCommand(sql, conexion);
        comando.Parameters.Add("@id", MySqlDbType.UInt32).Value = id;
        comando.Parameters.Add("@activo", MySqlDbType.Bool).Value = activo;
        if (await comando.ExecuteNonQueryAsync() == 0)
            throw new InvalidOperationException("El tipo de contrato no existe.");
    }
}