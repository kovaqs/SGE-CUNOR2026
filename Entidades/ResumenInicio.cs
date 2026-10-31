namespace Entidades;

public class ResumenInicio
{
    public int EmpleadosActivos
    {
        get; set;
    }
    public string[] Meses { get; set; } = new string[6];
    public int[] Faltas { get; set; } = new int[6];
    public int[] Tardanzas { get; set; } = new int[6];
    public List<SalarioDepartamento> Salarios { get; set; } = new();
}

public class SalarioDepartamento
{
    public string Nombre { get; set; } = "";
    public decimal Importe
    {
        get; set;
    }
}
