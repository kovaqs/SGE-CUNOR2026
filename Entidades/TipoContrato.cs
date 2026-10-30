namespace Entidades;

public class TipoContrato
{
    public uint IdTipoContrato { get; set; }
    public string Nombre { get; set; } = "";
    public string? Descripcion { get; set; }
    public bool Activo { get; set; } = true;
}
