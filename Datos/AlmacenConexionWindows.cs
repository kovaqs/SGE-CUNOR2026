using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json;
using Entidades;

namespace Datos;

public static class AlmacenConexionWindows
{
    private const string Destino = "SGE_CUNOR2026/MySQL";
    private const uint CredencialGenerica = 1;

    public static ConfiguracionBaseDatos? Leer()
    {
        ComprobarWindows();
        if (!CredRead(Destino, CredencialGenerica, 0, out var puntero))
        {
            if (Marshal.GetLastWin32Error() == 1168)
                return null;
            throw new InvalidOperationException("Windows no pudo leer la configuración de conexión.");
        }

        byte[]? contenido = null;
        try
        {
            var credencial = Marshal.PtrToStructure<Credencial>(puntero);
            contenido = new byte[checked((int)credencial.Tamano)];
            Marshal.Copy(credencial.Contenido, contenido, 0, contenido.Length);
            return JsonSerializer.Deserialize<ConfiguracionBaseDatos>(contenido)
                ?? throw new InvalidOperationException("La configuración local está incompleta.");
        }
        catch (JsonException)
        {
            throw new InvalidOperationException("La configuración local no es válida. Configura de nuevo la conexión.");
        }
        finally
        {
            if (contenido is not null)
                CryptographicOperations.ZeroMemory(contenido);
            CredFree(puntero);
        }
    }

    public static void Guardar(ConfiguracionBaseDatos configuracion)
    {
        ComprobarWindows();
        var contenido = JsonSerializer.SerializeToUtf8Bytes(configuracion);
        IntPtr puntero = IntPtr.Zero;
        try
        {
            if (contenido.Length > 2560)
                throw new ArgumentException("La configuración supera el tamaño admitido por Windows.");
            puntero = Marshal.AllocHGlobal(contenido.Length);
            Marshal.Copy(contenido, 0, puntero, contenido.Length);
            var credencial = new Credencial
            {
                Tipo = CredencialGenerica,
                Destino = Destino,
                Usuario = configuracion.Usuario,
                Tamano = (uint)contenido.Length,
                Contenido = puntero,
                Persistencia = 2
            };
            if (!CredWrite(ref credencial, 0))
                throw new InvalidOperationException("Windows no pudo guardar la conexión en el Administrador de credenciales.");
        }
        finally
        {
            CryptographicOperations.ZeroMemory(contenido);
            if (puntero != IntPtr.Zero)
            {
                Marshal.Copy(contenido, 0, puntero, contenido.Length);
                Marshal.FreeHGlobal(puntero);
            }
        }
    }

    private static void ComprobarWindows()
    {
        if (!OperatingSystem.IsWindows())
            throw new PlatformNotSupportedException("La configuración local requiere Windows.");
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    private struct Credencial
    {
        public uint Flags;
        public uint Tipo;
        public string? Destino;
        public string? Comentario;
        public System.Runtime.InteropServices.ComTypes.FILETIME UltimaEscritura;
        public uint Tamano;
        public IntPtr Contenido;
        public uint Persistencia;
        public uint CantidadAtributos;
        public IntPtr Atributos;
        public string? Alias;
        public string? Usuario;
    }

    [DllImport("advapi32.dll", EntryPoint = "CredReadW", CharSet = CharSet.Unicode, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool CredRead(string destino, uint tipo, uint flags, out IntPtr credencial);

    [DllImport("advapi32.dll", EntryPoint = "CredWriteW", CharSet = CharSet.Unicode, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool CredWrite(ref Credencial credencial, uint flags);

    [DllImport("advapi32.dll")]
    private static extern void CredFree(IntPtr credencial);
}
