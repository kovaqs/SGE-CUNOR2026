using System.Globalization;
using System.Security.Cryptography;

namespace Negocios.Seguridad;

internal static class HashContrasenas
{
    private const int Iteraciones = 600_000;
    internal const string HashSinUsuario = "PBKDF2-SHA256$600000$AAAAAAAAAAAAAAAAAAAAAA==$AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=";

    public static string Crear(string contrasena)
    {
        var sal = RandomNumberGenerator.GetBytes(16);
        var hash = Rfc2898DeriveBytes.Pbkdf2(contrasena, sal, Iteraciones, HashAlgorithmName.SHA256, 32);
        try
        {
            return string.Join('$', "PBKDF2-SHA256", Iteraciones.ToString(CultureInfo.InvariantCulture),
                Convert.ToBase64String(sal), Convert.ToBase64String(hash));
        }
        finally
        {
            CryptographicOperations.ZeroMemory(hash);
        }
    }

    public static bool Verificar(string contrasena, string codificado)
    {
        var partes = codificado.Split('$');
        if (partes.Length != 4 || partes[0] != "PBKDF2-SHA256"
            || !int.TryParse(partes[1], NumberStyles.None, CultureInfo.InvariantCulture, out var iteraciones)
            || iteraciones is < 100_000 or > 1_000_000)
            return false;
        try
        {
            var sal = Convert.FromBase64String(partes[2]);
            var esperado = Convert.FromBase64String(partes[3]);
            if (sal.Length != 16 || esperado.Length != 32)
                return false;
            var calculado = Rfc2898DeriveBytes.Pbkdf2(contrasena, sal, iteraciones, HashAlgorithmName.SHA256, 32);
            try
            {
                return CryptographicOperations.FixedTimeEquals(calculado, esperado);
            }
            finally
            {
                CryptographicOperations.ZeroMemory(calculado);
            }
        }
        catch (FormatException)
        {
            return false;
        }
    }
}
