using Entidades;
using Negocios;
using Presentacion.Forms.SubForms;
using Presentacion.Forms.SubForms.Puestos;
namespace Presentacion.Forms.Secciones;

public partial class FrmPuestos : Form
{
    public FrmPuestos()
    {
        InitializeComponent();
        VisibleChanged += Seccion_VisibleChanged;
        Load += Listado_Load;
        btnAgregarPuesto.Click += Agregar_Click;
        mnuEditarPuesto.Click += Editar_Click;
        mnuEliminarPuesto.Click += Eliminar_Click;
        txtBuscar.KeyDown += Buscar_KeyDown;
        cboEstado.SelectedIndexChanged += Filtro_Changed;
        cbotamanoPagina.SelectedIndexChanged += Filtro_Changed;
        btnAnterior.Click += Anterior_Click;
        btnSiguiente.Click += Siguiente_Click;
        cboDepartamento.SelectedIndexChanged += Filtro_Changed;
    }

    private void dgvPuestos_SelectionChanged(object sender, EventArgs e)
    {
        btnAcciones.Enabled = dgvPuestos.CurrentRow is not null && !dgvPuestos.CurrentRow.IsNewRow && dgvPuestos.CurrentRow.Selected;
    }

    private void FrmPuestos_Load(object sender, EventArgs e)
    {

    }

    private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void lblPuestos_Click(object sender, EventArgs e)
    {

    }

    private void btnAcciones_Click(object sender, EventArgs e)
    {
        cmsPuestos.Show(btnAcciones, new Point(0, btnAcciones.Height));
    }

    private void dgvPuestos_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var celda = dgvPuestos.HitTest(e.X, e.Y);
        var columna = dgvPuestos.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
        dgvPuestos.ClearSelection();

        if (celda.RowIndex < 0 || columna is null || dgvPuestos.Rows[celda.RowIndex].IsNewRow)
        {
            dgvPuestos.CurrentCell = null;
            return;
        }

        dgvPuestos.CurrentCell = dgvPuestos.Rows[celda.RowIndex].Cells[columna.Index];
        dgvPuestos.Rows[celda.RowIndex].Selected = true;
    }

    private void cmsPuestos_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = dgvPuestos.CurrentRow is null || dgvPuestos.CurrentRow.IsNewRow || !dgvPuestos.CurrentRow.Selected;
    }

    private void dgvPuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !dgvPuestos.Rows[e.RowIndex].IsNewRow)
            mnuEditarPuesto.PerformClick();
    }


    private SesionUsuario? sesion;
    private int pagina;
    private bool cargando;
    public void EstablecerSesion(SesionUsuario sesion)
    {
        this.sesion = sesion;
        bool administrar = sesion.Puede("catalogos");
        btnAgregarPuesto.Enabled = mnuEditarPuesto.Enabled = mnuEliminarPuesto.Enabled = administrar;
    }
    private Puesto? Seleccionado => dgvPuestos.CurrentRow?.Tag as Puesto;
    private async void Listado_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        cargando = true;
        try
        {

            AyudaFormulario.CargarCombo(cboDepartamento, await new ServicioCatalogos().OpcionesAsync("departamentos", 0, true), "Todos");
            cboEstado.Items.Clear();
            cboEstado.Items.AddRange(new object[] { "Todos", "Activos", "Inactivos" });

            cboEstado.SelectedIndex = 0;
            cbotamanoPagina.SelectedIndex = 0;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; }
        await CargarAsync();
    }
    private async Task CargarAsync()
    {
        if (cargando || IsDisposed || cbotamanoPagina.SelectedIndex < 0)
            return;
        cargando = true;
        dgvPuestos.Enabled = false;
        cboEstado.Enabled = cbotamanoPagina.Enabled = cboDepartamento.Enabled = false;
        btnAnterior.Enabled = btnSiguiente.Enabled = false;
        try
        {
            int limite = int.Parse(cbotamanoPagina.Text);
            var registros = await new ServicioCatalogos().ListarPuestosAsync(txtBuscar.Text, AyudaFormulario.IdSeleccionado(cboDepartamento), cboEstado.Text, pagina, limite);
            if (IsDisposed)
                return;
            bool siguiente = registros.Count > limite;
            if (siguiente)
                registros.RemoveAt(limite);
            dgvPuestos.Rows.Clear();
            foreach (var registro in registros)
            {
                int fila = dgvPuestos.Rows.Add(registro.Nombre, registro.Departamento, registro.Descripcion, registro.Activo);
                dgvPuestos.Rows[fila].Tag = registro;
            }
            lblPagina.Text = "Página " + (pagina + 1);
            btnAnterior.Enabled = pagina > 0;
            btnSiguiente.Enabled = siguiente;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; if (!IsDisposed) { dgvPuestos.Enabled = true; cboEstado.Enabled = cbotamanoPagina.Enabled = cboDepartamento.Enabled = true; } }
    }
    private async Task AbrirAsync(Puesto? registro)
    {
        if (sesion is null || cargando)
            return;
        using var formulario = new FrmPuesto();
        formulario.Configurar(sesion, registro);
        if (formulario.ShowDialog(TopLevelControl as Form ?? this) == DialogResult.OK)
            await CargarAsync();
    }
    private async void Agregar_Click(object? sender, EventArgs e)
    {
        await AbrirAsync(null);
    }
    private async void Editar_Click(object? sender, EventArgs e)
    {
        if (Seleccionado is { } registro)
            await AbrirAsync(registro);
    }
    private async void Eliminar_Click(object? sender, EventArgs e)
    {
        if (sesion is null || Seleccionado is not { } registro || cargando)
            return;
        if (!AyudaFormulario.Confirmar(this, "¿Eliminar " + registro.Nombre + "?"))
            return;
        try
        {
            await new ServicioCatalogos().EliminarAsync("puestos", registro.IdPuesto, sesion);
            pagina = 0;
            await CargarAsync();
        }
        catch (Exception ex) { AyudaFormulario.Error(notificador, ex); }
    }
    private async void Buscar_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && !cargando)
        {
            e.SuppressKeyPress = true;
            pagina = 0;
            await CargarAsync();
        }
    }
    private async void Filtro_Changed(object? sender, EventArgs e)
    {
        if (!cargando)
        {
            pagina = 0;
            await CargarAsync();
        }
    }
    private async void Anterior_Click(object? sender, EventArgs e)
    {
        if (!cargando && pagina > 0)
        {
            pagina--;
            await CargarAsync();
        }
    }
    private async void Siguiente_Click(object? sender, EventArgs e)
    {
        if (!cargando)
        {
            pagina++;
            await CargarAsync();
        }
    }

    private async void Seccion_VisibleChanged(object? sender, EventArgs e)
    {
        if (!Visible || !IsHandleCreated || cargando || cbotamanoPagina.SelectedIndex < 0)
            return;
        cargando = true;
        try
        {

            uint departamento = AyudaFormulario.IdSeleccionado(cboDepartamento);
            AyudaFormulario.CargarCombo(cboDepartamento, await new ServicioCatalogos().OpcionesAsync("departamentos", 0, true), "Todos");
            if (IsDisposed)
                return;
            cboDepartamento.SelectedValue = departamento;

            pagina = 0;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; }
        if (!IsDisposed)
            await CargarAsync();
    }
}
