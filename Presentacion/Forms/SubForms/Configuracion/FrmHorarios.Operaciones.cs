using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Configuracion;

public partial class FrmHorarios
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
        btnNuevoHorario.Click += NuevoHorario_Click;
        mnuEditarHorario.Click += EditarHorario_Click;
        mnuEliminarHorario.Click += EliminarHorario_Click;
    }
    private async Task<uint> IdHorarioSeleccionadoAsync()
    {
        if (dgvHorarios.CurrentRow?.Cells[0].Value is not string nombre)
            return 0;
        var opciones = await new ServicioCatalogos().OpcionesAsync("horarios", 0, true);
        foreach (var opcion in opciones)
            if (opcion.Nombre == nombre)
                return opcion.Id;
        return 0;
    }
    private void NuevoHorario_Click(object? sender, EventArgs e)
    {
        AbrirHorario(0);
    }
    private async void EditarHorario_Click(object? sender, EventArgs e)
    {
        try
        {
            uint id = await IdHorarioSeleccionadoAsync();
            if (id != 0)
                AbrirHorario(id);
        }
        catch (Exception ex) { AyudaFormulario.Error(notificador, ex); }
    }
    private void AbrirHorario(uint id)
    {
        if (sesionOperaciones is null)
            return;
        using var formulario = new FrmHorario();
        formulario.Configurar(sesionOperaciones, id);
        if (formulario.ShowDialog(this) == DialogResult.OK)
        {
            DatosActualizados?.Invoke(this, EventArgs.Empty);
            notificador.Show("Horarios", "Horario guardado.", KovaqsUI.Components.KToastKind.Success);
        }
    }
    private async void EliminarHorario_Click(object? sender, EventArgs e)
    {
        if (sesionOperaciones is null || !AyudaFormulario.Confirmar(this, "¿Eliminar el horario seleccionado?"))
            return;
        try
        {
            uint id = await IdHorarioSeleccionadoAsync();
            if (id == 0)
                return;
            await new ServicioCatalogos().EliminarAsync("horarios", id, sesionOperaciones);
            DatosActualizados?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception ex) { AyudaFormulario.Error(notificador, ex); }
    }
}
