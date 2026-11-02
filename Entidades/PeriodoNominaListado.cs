namespace Entidades;

public class PeriodoNominaListado
{
    public uint IdPeriodo { get; set; }
    public string Nombre { get; set; } = "";
    public DateTime Desde { get; set; }
    public DateTime Hasta { get; set; }
    public string Estado { get; set; } = "";
    public string GeneradoPor { get; set; } = "";
    public DateTime? FechaCierre { get; set; }
}
