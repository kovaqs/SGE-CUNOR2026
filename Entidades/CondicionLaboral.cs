namespace Entidades;

public sealed class CondicionLaboral
{
    public uint IdEmpleado { get; set; }
    public uint IdPuesto { get; set; }
    public uint IdTipoContrato { get; set; }
    public uint IdHorario { get; set; }
    public DateTime FechaInicio { get; set; }
    public decimal Salario { get; set; }
    public string Motivo { get; set; } = "";
}
