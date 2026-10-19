namespace Presentacion.Navegacion;


/// Muestra una única sección a la vez y conserva una instancia por tipo de formulario.
/// Debe crearse y utilizarse desde el hilo de la interfaz.

public sealed class GestorFormularios : IDisposable
{
    private readonly Control contenedor;
    private readonly Dictionary<Type, Form> formularios = new();
    private readonly int hiloInterfaz = Environment.CurrentManagedThreadId;
    private Form? formularioActivo;
    private bool disposed;

    public GestorFormularios(Control contenedor)
    {
        ArgumentNullException.ThrowIfNull(contenedor);
        ObjectDisposedException.ThrowIf(contenedor.IsDisposed || contenedor.Disposing, contenedor);
        if (contenedor.InvokeRequired)
            throw new InvalidOperationException("El gestor debe crearse en el hilo del contenedor.");

        this.contenedor = contenedor;
        contenedor.Disposed += Contenedor_Disposed;
    }


    /// Crea el formulario en su primera visita; las siguientes reutilizan su estado.
    /// Solo se vuelve a crear si fue cerrado o eliminado explícitamente.

    public T Mostrar<T>() where T : Form, new()
    {
        ObjectDisposedException.ThrowIf(disposed || contenedor.IsDisposed || contenedor.Disposing, this);
        if (Environment.CurrentManagedThreadId != hiloInterfaz)
            throw new InvalidOperationException("Los formularios deben mostrarse en el hilo de la interfaz.");

        if (!formularios.TryGetValue(typeof(T), out var formulario))
        {
            var nuevo = new T();
            try
            {
                nuevo.TopLevel = false;
                nuevo.FormBorderStyle = FormBorderStyle.None;
                nuevo.ShowInTaskbar = false;
                nuevo.Dock = DockStyle.Fill;
                contenedor.Controls.Add(nuevo);
                nuevo.Disposed += Formulario_Disposed;
                formularios.Add(typeof(T), nuevo);
                formulario = nuevo;
            }
            catch
            {
                nuevo.Dispose();
                throw;
            }
        }

        if (ReferenceEquals(formularioActivo, formulario) && formulario.Visible)
            return (T)formulario;

        contenedor.SuspendLayout();
        try
        {
            formulario.Show();
            formulario.BringToFront();
            if (!ReferenceEquals(formularioActivo, formulario))
                formularioActivo?.Hide();

            formularioActivo = formulario;
        }
        finally
        {
            contenedor.ResumeLayout(true);
        }

        return (T)formulario;
    }

    private void Formulario_Disposed(object? sender, EventArgs e)
    {
        if (sender is not Form formulario)
            return;

        formulario.Disposed -= Formulario_Disposed;
        formularios.Remove(formulario.GetType());
        if (ReferenceEquals(formularioActivo, formulario))
            formularioActivo = null;
    }

    private void Contenedor_Disposed(object? sender, EventArgs e) => Dispose();

    public void Dispose()
    {
        if (disposed)
            return;

        disposed = true;
        contenedor.Disposed -= Contenedor_Disposed;
        foreach (var formulario in formularios.Values.ToArray())
        {
            formulario.Disposed -= Formulario_Disposed;
            formulario.Dispose();
        }

        formularios.Clear();
        formularioActivo = null;
    }
}
