namespace Entidades;

public sealed class ConfiguracionBaseDatos
{
    public string Servidor { get; set; } = "";
    public uint Puerto { get; set; } = 3306;
    public string BaseDatos { get; set; } = "";
    public string Usuario { get; set; } = "";
    public string Contrasena { get; set; } = "";
    public string HuellaCertificadoSha256 { get; set; } = "";
}
