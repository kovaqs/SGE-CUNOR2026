namespace Entidades;

public class RegistroAsistencia
{
    public uint IdAsistencia
    {
        get; set;
    }
    public uint IdEmpleado
    {
        get; set;
    }
    public string Empleado { get; set; } = "";
    public string Departamento { get; set; } = "";
    public DateTime Fecha { get; set; } = DateTime.Today;
    public bool EsLaborable { get; set; } = true;
    public DateTime? EntradaPrevista
    {
        get; set;
    }
    public DateTime? SalidaPrevista
    {
        get; set;
    }
    public int Tolerancia
    {
        get; set;
    }
    public DateTime? Entrada
    {
        get; set;
    }
    public DateTime? Salida
    {
        get; set;
    }
    public string Estado { get; set; } = "Pendiente";
    public string? Observaciones
    {
        get; set;
    }
    public int Tardanza => Entrada is not null && EntradaPrevista is not null
        ? Math.Max(0, (int)(Entrada.Value - EntradaPrevista.Value).TotalMinutes - Tolerancia) : 0;
}
