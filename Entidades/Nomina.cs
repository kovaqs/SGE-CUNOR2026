namespace Entidades;

public class PeriodoPago
{
    public uint IdPeriodo
    {
        get; set;
    }
    public string Nombre { get; set; } = "";
    public DateTime Inicio
    {
        get; set;
    }
    public DateTime Fin
    {
        get; set;
    }
    public string Estado { get; set; } = "Borrador";
    public string? Observaciones
    {
        get; set;
    }
}

public class PagoEmpleado
{
    public uint IdDetalle
    {
        get; set;
    }
    public uint IdPeriodo
    {
        get; set;
    }
    public uint IdEmpleado
    {
        get; set;
    }
    public uint IdDepartamento
    {
        get; set;
    }
    public uint IdPuesto
    {
        get; set;
    }
    public string Codigo { get; set; } = "";
    public string Empleado { get; set; } = "";
    public string Departamento { get; set; } = "";
    public string Puesto { get; set; } = "";
    public string Contrato { get; set; } = "";
    public string Periodo { get; set; } = "";
    public string EstadoPeriodo { get; set; } = "";
    public decimal Dias
    {
        get; set;
    }
    public decimal SalarioBase
    {
        get; set;
    }
    public decimal Ingresos
    {
        get; set;
    }
    public decimal Deducciones
    {
        get; set;
    }
    public decimal Neto
    {
        get; set;
    }
    public List<MovimientoPago> Movimientos { get; set; } = new();
}

public class MovimientoPago
{
    public uint IdMovimiento
    {
        get; set;
    }
    public uint IdDetalle
    {
        get; set;
    }
    public int Orden
    {
        get; set;
    }
    public string Tipo { get; set; } = "Ingreso";
    public string Concepto { get; set; } = "";
    public decimal Cantidad { get; set; } = 1;
    public decimal Importe
    {
        get; set;
    }
    public decimal Total => decimal.Round(Cantidad * Importe, 2, MidpointRounding.AwayFromZero);
}
