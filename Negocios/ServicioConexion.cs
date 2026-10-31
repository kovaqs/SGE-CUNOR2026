using System.Data.Common;
using System.Text.RegularExpressions;
using Datos;
using Entidades;

namespace Negocios;

public sealed class ServicioConexion
{
    public long? VersionActual => AlmacenConexionWindows.LeerVersion();

    public bool EstaConfigurada => VersionActual is not null;

    public ConfiguracionBaseDatos? LeerConfiguracionLocal() => AlmacenConexionWindows.Leer();

    public async Task GuardarAsync(ConfiguracionBaseDatos configuracion, CancellationToken cancellationToken = default)
    {
        configuracion.Servidor = configuracion.Servidor.Trim();
        configuracion.BaseDatos = configuracion.BaseDatos.Trim();
        configuracion.Usuario = configuracion.Usuario.Trim();
        configuracion.HuellaCertificadoSha256 = configuracion.HuellaCertificadoSha256.Replace(":", "").Replace(" ", "").ToUpperInvariant();
        if (string.IsNullOrWhiteSpace(configuracion.Servidor) || configuracion.Servidor.Length > 253
            || string.IsNullOrWhiteSpace(configuracion.BaseDatos) || configuracion.BaseDatos.Length > 64
            || string.IsNullOrWhiteSpace(configuracion.Usuario) || configuracion.Usuario.Length > 128
            || string.IsNullOrEmpty(configuracion.Contrasena) || configuracion.Contrasena.Length > 256
            || configuracion.Puerto is 0 or > 65535)
            throw new ArgumentException("Completa los datos de conexión con los valores de Clever Cloud.");
        if (configuracion.HuellaCertificadoSha256.Length > 0
            && !Regex.IsMatch(configuracion.HuellaCertificadoSha256, "\\A[0-9A-F]{64}\\z"))
            throw new ArgumentException("La huella SHA-256 debe contener 64 caracteres hexadecimales.");
        try
        {
            await ConexionMySql.ComprobarAsync(configuracion, cancellationToken);
            AlmacenConexionWindows.Guardar(configuracion);
            ConexionMySql.LimpiarConexiones();
        }
        catch (DbException)
        {
            throw new InvalidOperationException("No se pudo conectar a MySQL. Revisa la conexión, las credenciales, el certificado y la disponibilidad del servicio.");
        }
    }
}
