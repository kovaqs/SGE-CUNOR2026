using System.Security.Cryptography;
using Entidades;
using MySqlConnector;

namespace Datos;

public static class ConexionMySql
{
    public static Task<MySqlConnection> AbrirAsync(CancellationToken cancellationToken = default)
    {
        var configuracion = AlmacenConexionWindows.Leer()
            ?? throw new InvalidOperationException("Configura la conexión a MySQL antes de iniciar sesión.");
        return AbrirAsync(configuracion, cancellationToken);
    }

    public static async Task ComprobarAsync(ConfiguracionBaseDatos configuracion, CancellationToken cancellationToken = default)
    {
        await using var conexion = await AbrirAsync(configuracion, cancellationToken, agrupar: false);
        await using var comando = new MySqlCommand("SELECT id_usuario FROM usuarios LIMIT 1;", conexion);
        await comando.ExecuteScalarAsync(cancellationToken);
    }

    public static void LimpiarConexiones() => MySqlConnection.ClearAllPools();

    private static async Task<MySqlConnection> AbrirAsync(ConfiguracionBaseDatos configuracion, CancellationToken cancellationToken, bool agrupar = true)
    {
        var huella = configuracion.HuellaCertificadoSha256;
        var cadena = new MySqlConnectionStringBuilder
        {
            Server = configuracion.Servidor,
            Port = configuracion.Puerto,
            Database = configuracion.BaseDatos,
            UserID = configuracion.Usuario,
            Password = configuracion.Contrasena,
            SslMode = string.IsNullOrEmpty(huella) ? MySqlSslMode.VerifyFull : MySqlSslMode.Required,
            PersistSecurityInfo = false,
            AllowPublicKeyRetrieval = false,
            AllowLoadLocalInfile = false,
            Pooling = agrupar,
            MinimumPoolSize = 0,
            MaximumPoolSize = 1,
            ConnectionIdleTimeout = 5,
            ConnectionTimeout = 10,
            DefaultCommandTimeout = 15,
            DateTimeKind = MySqlDateTimeKind.Utc
        };
        var conexion = new MySqlConnection(cadena.ConnectionString);
        if (!string.IsNullOrEmpty(huella))
        {
            var esperada = Convert.FromHexString(huella);
            conexion.RemoteCertificateValidationCallback = (_, certificado, _, _) =>
            {
                if (certificado is null)
                    return false;
                using var servidor = new System.Security.Cryptography.X509Certificates.X509Certificate2(certificado);
                return DateTime.UtcNow >= servidor.NotBefore.ToUniversalTime()
                    && DateTime.UtcNow <= servidor.NotAfter.ToUniversalTime()
                    && CryptographicOperations.FixedTimeEquals(esperada, servidor.GetCertHash(HashAlgorithmName.SHA256));
            };
        }

        try
        {
            await conexion.OpenAsync(cancellationToken);
            await using var zonaHoraria = new MySqlCommand("SET SESSION time_zone = '+00:00';", conexion);
            await zonaHoraria.ExecuteNonQueryAsync(cancellationToken);
            return conexion;
        }
        catch
        {
            await conexion.DisposeAsync();
            throw;
        }
    }
}
