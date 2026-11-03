using Entidades;
using Negocios;

namespace Presentacion.Forms.SubForms.Asistencias;

public partial class FrmPermisosLaborales
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
        btnNuevoPermiso.Click += NuevoPermiso_Click;
        mnuEditarPermiso.Click += EditarPermiso_Click;
        mnuResolverPermiso.Click += ResolverPermiso_Click;
        mnuCancelarPermiso.Click += CancelarPermiso_Click;
    }
    private Task<PermisoTrabajo> PermisoSeleccionadoAsync()
    {
        if (dgvPermisos.CurrentRow is not { } fila || fila.Cells[1].Value is not DateTime inicio)
            throw new InvalidOperationException("Selecciona un permiso.");
        return new ServicioPermisosTrabajo().BuscarAsync(Convert.ToString(fila.Cells[0].Value) ?? "", inicio);
    }
    private void NuevoPermiso_Click(object? sender, EventArgs e)
    {
        AbrirPermiso(null);
    }
    private async void EditarPermiso_Click(object? sender, EventArgs e)
    {
        try
        {
            var permiso = await PermisoSeleccionadoAsync();
            if (permiso.Estado != "Pendiente")
                throw new InvalidOperationException("Solo puedes editar permisos pendientes.");
            AbrirPermiso(permiso);
        }
        catch (Exception ex) { AyudaFormulario.Error(notificador, ex); }
    }
    private void AbrirPermiso(PermisoTrabajo? permiso)
    {
        if (sesionOperaciones is null)
            return;
        using var formulario = new FrmPermisoLaboral();
        formulario.Configurar(sesionOperaciones, permiso);
        if (formulario.ShowDialog(this) == DialogResult.OK)
            DatosActualizados?.Invoke(this, EventArgs.Empty);
    }
    private async void ResolverPermiso_Click(object? sender, EventArgs e)
    {
        if (sesionOperaciones is null)
            return;
        try
        {
            var permiso = await PermisoSeleccionadoAsync();
            if (permiso.Estado != "Pendiente")
                throw new InvalidOperationException("El permiso ya fue resuelto.");
            using var formulario = new FrmResolverPermiso();
            formulario.Configurar(sesionOperaciones, permiso);
            if (formulario.ShowDialog(this) == DialogResult.OK)
                DatosActualizados?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception ex) { AyudaFormulario.Error(notificador, ex); }
    }
    private async void CancelarPermiso_Click(object? sender, EventArgs e)
    {
        if (sesionOperaciones is null || !AyudaFormulario.Confirmar(this, "¿Cancelar el permiso seleccionado?"))
            return;
        try
        {
            var permiso = await PermisoSeleccionadoAsync();
            await new ServicioPermisosTrabajo().ResolverAsync(permiso.IdPermiso, "Cancelado", "Cancelado desde el listado.", sesionOperaciones);
            DatosActualizados?.Invoke(this, EventArgs.Empty);
        }
        catch (Exception ex) { AyudaFormulario.Error(notificador, ex); }
    }
}
