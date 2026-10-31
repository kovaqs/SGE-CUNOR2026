using Entidades;
using Negocios;
using Presentacion.Forms.SubForms;
using Presentacion.Forms.SubForms.Puestos;
namespace Presentacion.Forms.Secciones;

public partial class FrmDepartamentos : Form
{
    public FrmDepartamentos()
    {
        InitializeComponent();
        VisibleChanged += Seccion_VisibleChanged;
        Load += Listado_Load;
        btnAgregarDepartamento.Click += Agregar_Click;
        mnuEditarDepartamento.Click += Editar_Click;
        mnuEliminarDepartamento.Click += Eliminar_Click;
        txtBuscar.KeyDown += Buscar_KeyDown;
        cboEstado.SelectedIndexChanged += Filtro_Changed;
        cboTamanoPagina.SelectedIndexChanged += Filtro_Changed;
        btnAnterior.Click += Anterior_Click;
        btnSiguiente.Click += Siguiente_Click;
    }

    private void btnAcciones_Click(object sender, EventArgs e)
    {
        cmsDepartamentos.Show(btnAcciones, new Point(0, btnAcciones.Height));
    }

    private void dgvDepartamentos_SelectionChanged(object sender, EventArgs e)
    {
        btnAcciones.Enabled = dgvDepartamentos.CurrentRow is not null && !dgvDepartamentos.CurrentRow.IsNewRow && dgvDepartamentos.CurrentRow.Selected;
    }

    private void dgvDepartamentos_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button != MouseButtons.Right)
            return;

        var celda = dgvDepartamentos.HitTest(e.X, e.Y);
        var columna = dgvDepartamentos.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
        dgvDepartamentos.ClearSelection();

        if (celda.RowIndex < 0 || columna is null || dgvDepartamentos.Rows[celda.RowIndex].IsNewRow)
        {
            dgvDepartamentos.CurrentCell = null;
            return;
        }

        dgvDepartamentos.CurrentCell = dgvDepartamentos.Rows[celda.RowIndex].Cells[columna.Index];
        dgvDepartamentos.Rows[celda.RowIndex].Selected = true;
    }

    private void cmsDepartamentos_Opening(object sender, System.ComponentModel.CancelEventArgs e)
    {
        e.Cancel = dgvDepartamentos.CurrentRow is null || dgvDepartamentos.CurrentRow.IsNewRow || !dgvDepartamentos.CurrentRow.Selected;
    }

    private void dgvDepartamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && !dgvDepartamentos.Rows[e.RowIndex].IsNewRow)
            mnuEditarDepartamento.PerformClick();
    }


    private SesionUsuario? sesion;
    private int pagina;
    private bool cargando;
    public void EstablecerSesion(SesionUsuario sesion)
    {
        this.sesion = sesion;
        bool administrar = sesion.Puede("catalogos");
        btnAgregarDepartamento.Enabled = mnuEditarDepartamento.Enabled = mnuEliminarDepartamento.Enabled = administrar;
    }
    private Departamento? Seleccionado => dgvDepartamentos.CurrentRow?.Tag as Departamento;
    private async void Listado_Load(object? sender, EventArgs e)
    {
        if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
            return;
        cargando = true;
        try
        {

            cboEstado.SelectedIndex = 0;
            cboTamanoPagina.SelectedIndex = 0;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; }
        await CargarAsync();
    }
    private async Task CargarAsync()
    {
        if (cargando || IsDisposed || cboTamanoPagina.SelectedIndex < 0)
            return;
        cargando = true;
        dgvDepartamentos.Enabled = false;
        cboEstado.Enabled = cboTamanoPagina.Enabled = false;
        btnAnterior.Enabled = btnSiguiente.Enabled = false;
        try
        {
            int limite = int.Parse(cboTamanoPagina.Text);
            var registros = await new ServicioDepartamentos().ListarAsync(txtBuscar.Text, cboEstado.Text, pagina, limite);
            if (IsDisposed)
                return;
            bool siguiente = registros.Count > limite;
            if (siguiente)
                registros.RemoveAt(limite);
            dgvDepartamentos.Rows.Clear();
            foreach (var registro in registros)
            {
                int fila = dgvDepartamentos.Rows.Add(registro.Nombre, registro.Descripcion, registro.Activo);
                dgvDepartamentos.Rows[fila].Tag = registro;
            }
            lblPagina.Text = "Página " + (pagina + 1);
            btnAnterior.Enabled = pagina > 0;
            btnSiguiente.Enabled = siguiente;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; if (!IsDisposed) { dgvDepartamentos.Enabled = true; cboEstado.Enabled = cboTamanoPagina.Enabled = true; } }
    }
    private async Task AbrirAsync(Departamento? registro)
    {
        if (sesion is null || cargando)
            return;
        using var formulario = new FrmDepartamento();
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
            await new ServicioCatalogos().EliminarAsync("departamentos", registro.IdDepartamento, sesion);
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
        if (!Visible || !IsHandleCreated || cargando || cboTamanoPagina.SelectedIndex < 0)
            return;
        cargando = true;
        try
        {

            pagina = 0;
        }
        catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
        finally { cargando = false; }
        if (!IsDisposed)
            await CargarAsync();
    }
}
