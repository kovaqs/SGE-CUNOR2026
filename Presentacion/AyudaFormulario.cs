using System.Data.Common;
using System.Security.Cryptography;
using Entidades;
using KovaqsUI.Components;

namespace Presentacion;

internal static class AyudaFormulario
{
    public static void CargarCombo(ComboBox combo, List<OpcionCatalogo> opciones, string? primera = null)
    {
        if (primera is not null)
            opciones.Insert(0, new OpcionCatalogo { Nombre = primera });
        combo.DisplayMember = nameof(OpcionCatalogo.Nombre);
        combo.ValueMember = nameof(OpcionCatalogo.Id);
        combo.DataSource = opciones;
    }

    public static uint IdSeleccionado(ComboBox combo) =>
        combo.SelectedItem is OpcionCatalogo opcion ? opcion.Id : 0;

    public static void Error(KToastNotifier notificador, Exception error)
    {
        string mensaje = error is DbException ? "No se pudo completar la operación. Revisa la conexión."
            : error is CryptographicException ? "No se pudieron descifrar los datos. Revisa la configuración de MySQL."
            : error is ArgumentException or InvalidOperationException ? error.Message
            : "No se pudo completar la operación. Revisa los datos y vuelve a intentarlo.";
        notificador.Show("Sistema", mensaje, KToastKind.Warning);
    }

    public static bool Confirmar(Form propietario, string mensaje) =>
        MessageBox.Show(propietario, mensaje, "Confirmar", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes;
}
