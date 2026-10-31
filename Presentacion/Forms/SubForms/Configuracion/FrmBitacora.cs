namespace Presentacion.Forms.SubForms.Configuracion;

public partial class FrmBitacora : Form
{
    public FrmBitacora()
    {
        InitializeComponent();
        PrepararConsulta();
    }

    private readonly Negocios.ServicioBitacora consulta = new();
    private bool consultando;

    private void PrepararConsulta()
    {
        if (System.ComponentModel.LicenseManager.UsageMode ==
            System.ComponentModel.LicenseUsageMode.Designtime) return;
        dtpDesde.Value = DateTime.Today.AddMonths(-1);
        dtpHasta.Value = DateTime.Today;
        cboUsuario.DropDownStyle = ComboBoxStyle.DropDown;
        cboEntidad.DropDownStyle = ComboBoxStyle.DropDown;
        cboEntidad.Items.Clear();
        cboEntidad.Items.AddRange(new object[]
        {
            "Todas", "usuarios", "empleados", "departamentos", "puestos",
            "tipos_contrato", "historial_laboral", "permisos_laborales",
            "asistencias", "periodos_nomina", "detalle_nomina"
        });
        cboOperacion.Items.Clear();
        cboOperacion.Items.AddRange(new object[]
        {
            "Todas", "INSERT", "UPDATE", "DELETE", "LOGIN", "LOGOUT",
            "AUTORIZACION", "CIERRE", "ANULACION"
        });
        cboUsuario.SelectedIndex = 0;
        cboOperacion.SelectedIndex = 0;
        cboEntidad.SelectedIndex = 0;
        colBitacoraFechayhora.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        Load += Consulta_Inicio;
        btnConsultar.Click += Consulta_Inicio;
        btnLimpiarFiltros.Click += Consulta_Limpiar;
        btnCerrar.Click += Consulta_Cerrar;
        dgvBitacora.SelectionChanged += Consulta_Seleccion;
    }

    private async void Consulta_Inicio(object? sender, EventArgs e)
    {
        if (consultando) return;
        consultando = true;
        btnConsultar.Enabled = btnLimpiarFiltros.Enabled = false;
        try
        {
            var registros = await consulta.ListarAsync(
                dtpDesde.Value, dtpHasta.Value, cboUsuario.Text,
                cboOperacion.Text, cboEntidad.Text);
            if (IsDisposed) return;
            dgvBitacora.Rows.Clear();
            txtDescripcion.Text = "";
            foreach (var registro in registros)
            {
                int fila = dgvBitacora.Rows.Add(registro.Fecha, registro.Usuario,
                    registro.Operacion, registro.Entidad, registro.Registro);
                dgvBitacora.Rows[fila].Tag = registro;
            }
            Consulta_Seleccion(this, EventArgs.Empty);
        }
        catch (Exception ex)
        {
            if (!IsDisposed)
                notificador.Show("Bitácora", ex.Message,
                    KovaqsUI.Components.KToastKind.Warning);
        }
        finally
        {
            consultando = false;
            if (!IsDisposed)
                btnConsultar.Enabled = btnLimpiarFiltros.Enabled = true;
        }
    }

    private void Consulta_Seleccion(object? sender, EventArgs e)
    {
        var registro = dgvBitacora.CurrentRow?.Tag as Entidades.RegistroBitacora;
        txtDescripcion.Text = registro?.Descripcion ?? "";
    }

    private void Consulta_Limpiar(object? sender, EventArgs e)
    {
        dtpDesde.Value = DateTime.Today.AddMonths(-1);
        dtpHasta.Value = DateTime.Today;
        cboUsuario.SelectedIndex = 0;
        cboOperacion.SelectedIndex = 0;
        cboEntidad.SelectedIndex = 0;
        Consulta_Inicio(sender, e);
    }

    private void Consulta_Cerrar(object? sender, EventArgs e)
    {
        Close();
    }
}
