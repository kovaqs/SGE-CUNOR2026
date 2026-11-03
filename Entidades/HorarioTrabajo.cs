namespace Entidades;

public class HorarioTrabajo
{
    public uint IdHorario
    {
        get; set;
    }
    public string Nombre { get; set; } = "";
    public bool Activo { get; set; } = true;
    public List<DiaHorario> Dias { get; set; } = new();
}

public class DiaHorario
{
    public int DiaSemana
    {
        get; set;
    }
    public TimeSpan Entrada
    {
        get; set;
    }
    public TimeSpan Salida
    {
        get; set;
    }
    public bool DiaSiguiente
    {
        get; set;
    }
    public int Tolerancia
    {
        get; set;
    }
}
