namespace Entidades;

public class PermisoTrabajo
{
    public uint IdPermiso
    {
        get; set;
    }
    public uint IdEmpleado
    {
        get; set;
    }
    public string Empleado { get; set; } = "";
    public DateTime Inicio { get; set; } = DateTime.Today;
    public DateTime Fin { get; set; } = DateTime.Today.AddHours(1);
    public string Motivo { get; set; } = "";
    public bool ConGoce
    {
        get; set;
    }
    public string Estado { get; set; } = "Pendiente";
    public string? Observaciones
    {
        get; set;
    }
}
