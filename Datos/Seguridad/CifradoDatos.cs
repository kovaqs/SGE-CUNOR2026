using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace Datos.Seguridad;

public static class CifradoDatos
{
    private const int TamanoNonce = 12;
    private const int TamanoTag = 16;
    private const int Cabecera = 1 + TamanoNonce + TamanoTag;

    public static byte[] DerivarClave(string contrasenaMySql)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(contrasenaMySql);
        return Rfc2898DeriveBytes.Pbkdf2(contrasenaMySql, "SGE_CUNOR2026/datos"u8.ToArray(),
            100_000, HashAlgorithmName.SHA256, 32);
    }

    public static byte[] Cifrar(string valor, byte[] clave, string contexto)
    {
        ArgumentNullException.ThrowIfNull(valor);
        ArgumentException.ThrowIfNullOrWhiteSpace(contexto);
        ValidarClave(clave);
        if (Encoding.UTF8.GetByteCount(valor) > 4096 - Cabecera)
            throw new ArgumentException("El dato supera el tamaño admitido para el cifrado.");
        var texto = Encoding.UTF8.GetBytes(valor);
        try
        {
            var resultado = new byte[Cabecera + texto.Length];
            resultado[0] = 1;
            RandomNumberGenerator.Fill(resultado.AsSpan(1, TamanoNonce));
            using var aes = new AesGcm(clave, TamanoTag);
            aes.Encrypt(resultado.AsSpan(1, TamanoNonce), texto, resultado.AsSpan(Cabecera),
                resultado.AsSpan(1 + TamanoNonce, TamanoTag), Encoding.UTF8.GetBytes(contexto));
            return resultado;
        }
        finally { CryptographicOperations.ZeroMemory(texto); }
    }

    public static string Descifrar(byte[] valor, byte[] clave, string contexto)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(contexto);
        ValidarClave(clave);
        if (valor.Length < Cabecera || valor.Length > 4096 || valor[0] != 1)
            throw new InvalidOperationException("El dato no tiene un formato de cifrado válido. No se modificó su contenido.");
        var texto = new byte[valor.Length - Cabecera];
        try
        {
            using var aes = new AesGcm(clave, TamanoTag);
            aes.Decrypt(valor.AsSpan(1, TamanoNonce), valor.AsSpan(Cabecera),
                valor.AsSpan(1 + TamanoNonce, TamanoTag), texto, Encoding.UTF8.GetBytes(contexto));
            return Encoding.UTF8.GetString(texto);
        }
        catch (CryptographicException)
        {
            throw new InvalidOperationException("No se pudo descifrar el dato: la clave no corresponde o el contenido fue alterado.");
        }
        finally { CryptographicOperations.ZeroMemory(texto); }
    }

    public static byte[] CifrarImporte(decimal valor, byte[] clave, string contexto) =>
        Cifrar(valor.ToString(CultureInfo.InvariantCulture), clave, contexto);

    public static decimal DescifrarImporte(byte[] valor, byte[] clave, string contexto)
    {
        var texto = Descifrar(valor, clave, contexto);
        if (!decimal.TryParse(texto, NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint,
            CultureInfo.InvariantCulture, out var importe))
            throw new InvalidOperationException("El importe cifrado no es válido.");
        return importe;
    }

    private static void ValidarClave(byte[] clave)
    {
        if (clave.Length != 32)
            throw new ArgumentException("La clave de cifrado no es válida.");
    }
}
