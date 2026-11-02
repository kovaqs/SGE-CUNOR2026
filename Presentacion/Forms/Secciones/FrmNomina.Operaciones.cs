using Entidades;
using Negocios;
using Presentacion.Forms.SubForms.Nomina;

namespace Presentacion.Forms.Secciones;

public partial class FrmNomina
{
    private SesionUsuario? sesionOperaciones;
    private bool operacionesPreparadas;
    public event EventHandler? DatosActualizados;
    public void EstablecerSesion(SesionUsuario sesion)
    {
        sesionOperaciones = sesion;
        if (operacionesPreparadas)
            return;
        operacionesPreparadas = true;
        btnNuevoPeriodo.Click += NuevoPeriodo_Click;
        btnBoletas.Click += Boletas_Click;
        mnuVerPeriodo.Click += VerPeriodo_Click;
    }
    private void NuevoPeriodo_Click(object? sender, EventArgs e)
    {
        if (sesionOperaciones is null)
            return;
        using var formulario = new FrmPeriodoNomina();
        formulario.Configurar(sesionOperaciones);
        if (formulario.ShowDialog(TopLevelControl as Form ?? this) == DialogResult.OK)
        {
            DatosActualizados?.Invoke(this, EventArgs.Empty);
            AbrirPeriodo(formulario.IdCreado);
        }
    }
    private void VerPeriodo_Click(object? sender, EventArgs e)
    {
        if (consultando || dgvPeriodos.CurrentRow?.Tag is not PeriodoNominaListado periodo)
            return;
        try
        {
            AbrirPeriodo(periodo.IdPeriodo);
        }
        catch (Exception ex) { AyudaFormulario.Error(notificador, ex); }
    }
    private void AbrirPeriodo(uint id)
    {
        if (sesionOperaciones is null)
            return;
        using var formulario = new FrmPeriodoNominaDetalle();
        formulario.Configurar(sesionOperaciones, id);
        formulario.ShowDialog(TopLevelControl as Form ?? this);
        DatosActualizados?.Invoke(this, EventArgs.Empty);
    }
    private void Boletas_Click(object? sender, EventArgs e)
    {
        if (sesionOperaciones is null)
            return;
        using var formulario = new FrmBoletasNomina();
        formulario.Configurar(sesionOperaciones);
        formulario.ShowDialog(TopLevelControl as Form ?? this);
    }
}
