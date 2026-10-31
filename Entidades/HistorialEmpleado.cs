namespace Entidades;

public class HistorialEmpleado
{
    public uint IdHistorial
    {
        get; set;
    }
    public DateTime Inicio
    {
        get; set;
    }
    public DateTime? Fin
    {
        get; set;
    }
    public string Departamento { get; set; } = "";
    public string Puesto { get; set; } = "";
    public string Contrato { get; set; } = "";
    public string Horario { get; set; } = "";
    public decimal Salario
    {
        get; set;
    }
    public string Motivo { get; set; } = "";
}
