using Entidades;

namespace Presentacion.Forms.SubForms;

public partial class FrmExpedientesDatosBancarios : Form
{
    public FrmExpedientesDatosBancarios()
    {
        InitializeComponent();
        txtCuentaBancaria.UseSystemPasswordChar = true;
        chkMostrarCuenta.CheckedChanged += MostrarCuenta_CheckedChanged;
    }
    public void Cargar(Empleado empleado)
    {
        txtBanco.Text = empleado.DatosBancarios.Banco;
        txtCuentaBancaria.Text = empleado.DatosBancarios.Cuenta;
    }
    public void Leer(Empleado empleado)
    {
        empleado.DatosBancarios = new DatosBancarios { Banco = txtBanco.Text, Cuenta = txtCuentaBancaria.Text };
    }
    private void MostrarCuenta_CheckedChanged(object? sender, EventArgs e)
    {
        txtCuentaBancaria.UseSystemPasswordChar = !chkMostrarCuenta.Checked;
    }
}
