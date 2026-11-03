using System.Drawing.Imaging;
using Entidades;

namespace Presentacion.Forms.SubForms;

public partial class FrmExpedientesDatosPersonales : Form
{
    private byte[]? fotografia;
    private string? tipoFotografia;
    public FrmExpedientesDatosPersonales()
    {
        InitializeComponent();
        btnSeleccionarFoto.Click += SeleccionarFoto_Click;
        btnQuitarFoto.Click += QuitarFoto_Click;
        picFotografia.AllowDrop = true;
        picFotografia.DragEnter += Fotografia_DragEnter;
        picFotografia.DragDrop += Fotografia_DragDrop;
        dtpFechaNacimiento.ShowCheckBox = true;
        dtpFechaNacimiento.Checked = false;
        Disposed += LiberarFoto;
    }

    public void Cargar(Empleado empleado)
    {
        txtCodigo.Text = empleado.Codigo;
        txtDpi.Text = empleado.Dpi;
        txtNombres.Text = empleado.Nombres;
        txtApellidos.Text = empleado.Apellidos;
        txtTelefono.Text = empleado.Telefono;
        txtCorreo.Text = empleado.Correo;
        txtDireccion.Text = empleado.Direccion;
        dtpFechaNacimiento.Value = empleado.FechaNacimiento ?? DateTime.Today.AddYears(-18);
        dtpFechaNacimiento.Checked = empleado.FechaNacimiento is not null;
        fotografia = empleado.Fotografia;
        tipoFotografia = empleado.FotografiaTipo;
        if (fotografia is not null)
        {
            using var memoria = new MemoryStream(fotografia);
            using var imagen = Image.FromStream(memoria);
            picFotografia.Image = new Bitmap(imagen);
        }
    }

    public void Leer(Empleado empleado)
    {
        empleado.Codigo = txtCodigo.Text;
        empleado.Dpi = txtDpi.Text;
        empleado.Nombres = txtNombres.Text;
        empleado.Apellidos = txtApellidos.Text;
        empleado.Telefono = txtTelefono.Text;
        empleado.Correo = txtCorreo.Text;
        empleado.Direccion = txtDireccion.Text;
        empleado.FechaNacimiento = dtpFechaNacimiento.Checked ? dtpFechaNacimiento.Value.Date : null;
        empleado.Fotografia = fotografia;
        empleado.FotografiaTipo = tipoFotografia;
    }

    private void SeleccionarFoto_Click(object? sender, EventArgs e)
    {
        using var dialogo = new OpenFileDialog { Filter = "Imágenes JPEG y PNG|*.jpg;*.jpeg;*.png", CheckFileExists = true };
        if (dialogo.ShowDialog(this) == DialogResult.OK)
            CargarFoto(dialogo.FileName);
    }

    private void CargarFoto(string archivo)
    {
        try
        {
            if (new FileInfo(archivo).Length > 5 * 1024 * 1024)
                throw new ArgumentException("Selecciona una imagen de hasta 5 MB.");
            using var original = Image.FromFile(archivo);
            double escala = Math.Min(1, 300.0 / Math.Max(original.Width, original.Height));
            using var reducida = new Bitmap(Math.Max(1, (int)(original.Width * escala)), Math.Max(1, (int)(original.Height * escala)));
            using (var dibujo = Graphics.FromImage(reducida))
            {
                dibujo.Clear(Color.White);
                dibujo.DrawImage(original, 0, 0, reducida.Width, reducida.Height);
            }
            using var memoria = new MemoryStream();
            reducida.Save(memoria, ImageFormat.Jpeg);
            if (memoria.Length > 65535)
                throw new ArgumentException("La imagen tiene demasiado detalle; selecciona una más pequeña.");
            fotografia = memoria.ToArray();
            tipoFotografia = "image/jpeg";
            picFotografia.Image?.Dispose();
            picFotografia.Image = new Bitmap(reducida);
        }
        catch (Exception ex) { AyudaFormulario.Error(notificador, ex); }
    }

    private void Fotografia_DragEnter(object? sender, DragEventArgs e)
    {
        e.Effect = e.Data?.GetDataPresent(DataFormats.FileDrop) == true ? DragDropEffects.Copy : DragDropEffects.None;
    }
    private void Fotografia_DragDrop(object? sender, DragEventArgs e)
    {
        if (e.Data?.GetData(DataFormats.FileDrop) is string[] archivos && archivos.Length == 1)
            CargarFoto(archivos[0]);
    }
    private void QuitarFoto_Click(object? sender, EventArgs e)
    {
        fotografia = null;
        tipoFotografia = null;
        picFotografia.Image?.Dispose();
        picFotografia.Image = null;
    }
    private void LiberarFoto(object? sender, EventArgs e)
    {
        picFotografia.Image?.Dispose();
    }
}
