using Entidades;
using Negocios;
using Presentacion.Forms.SubForms;
using Presentacion.Forms.SubForms.Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms.Secciones
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
            VisibleChanged += Seccion_VisibleChanged;
            btnAgregarEmpleado.Click += Agregar_Click;
            mnuEditarEmpleado.Click += Editar_Click;
            mnuConstanciaLaboral.Click += Constancia_Click;
            mnuHistorialLaboral.Click += Historial_Click;
            mnuEstadoEmpleado.Click += Estado_Click;
            mnuEliminarEmpleado.Click += Eliminar_Click;
            txtBuscar.KeyDown += Buscar_KeyDown;
            cboDepartamento.SelectedIndexChanged += Filtro_Changed;
            cboTipoContrato.SelectedIndexChanged += Filtro_Changed;
            cboEstado.SelectedIndexChanged += Filtro_Changed;
            kComboBox3.SelectedIndexChanged += Filtro_Changed;
            kButton6.Click += Anterior_Click;
            kButton5.Click += Siguiente_Click;
        }

        private async void FrmEmpleados_Load(object sender, EventArgs e)
        {
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;
            cargando = true;
            try
            {
                var catalogos = new ServicioCatalogos();
                AyudaFormulario.CargarCombo(cboDepartamento, await catalogos.OpcionesAsync("departamentos", 0, true), "Todos");
                AyudaFormulario.CargarCombo(cboTipoContrato, await catalogos.OpcionesAsync("contratos", 0, true), "Todos");
                cboEstado.Items.Clear();
                cboEstado.Items.AddRange(new object[] { "Todos", "Activo", "Suspendido", "Inactivo" });
                cboEstado.SelectedIndex = 0;
                kComboBox3.SelectedIndex = 0;
            }
            catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
            finally { cargando = false; }
            await CargarAsync();
        }

        private void btnAcciones_Click(object sender, EventArgs e)
        {
            cmsEmpleados.Show(btnAcciones, new Point(0, btnAcciones.Height));
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            btnAcciones.Enabled = dgvEmpleados.CurrentRow is not null && !dgvEmpleados.CurrentRow.IsNewRow && dgvEmpleados.CurrentRow.Selected;
        }

        private void dgvEmpleados_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            var celda = dgvEmpleados.HitTest(e.X, e.Y);
            var columna = dgvEmpleados.Columns.GetFirstColumn(DataGridViewElementStates.Visible);
            dgvEmpleados.ClearSelection();

            if (celda.RowIndex < 0 || columna is null || dgvEmpleados.Rows[celda.RowIndex].IsNewRow)
            {
                dgvEmpleados.CurrentCell = null;
                return;
            }

            dgvEmpleados.CurrentCell = dgvEmpleados.Rows[celda.RowIndex].Cells[columna.Index];
            dgvEmpleados.Rows[celda.RowIndex].Selected = true;
        }

        private void cmsEmpleados_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = dgvEmpleados.CurrentRow is null || dgvEmpleados.CurrentRow.IsNewRow || !dgvEmpleados.CurrentRow.Selected;
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgvEmpleados.Rows[e.RowIndex].IsNewRow)
                mnuEditarEmpleado.PerformClick();
        }


        private readonly ServicioEmpleados servicio = new();
        private SesionUsuario? sesion;
        private bool cargando;
        private int pagina;
        public void EstablecerSesion(SesionUsuario sesion)
        {
            this.sesion = sesion;
            bool administrar = sesion.Puede("empleados");
            btnAgregarEmpleado.Enabled = administrar;
            mnuEditarEmpleado.Enabled = mnuHistorialLaboral.Enabled = mnuEstadoEmpleado.Enabled = mnuEliminarEmpleado.Enabled = administrar;
        }
        private EmpleadoListado? Seleccionado => dgvEmpleados.CurrentRow?.Tag as EmpleadoListado;
        private async Task CargarAsync()
        {
            if (cargando || IsDisposed || kComboBox3.SelectedIndex < 0)
                return;
            cargando = true;
            dgvEmpleados.Enabled = false;
            cboDepartamento.Enabled = cboTipoContrato.Enabled = cboEstado.Enabled = kComboBox3.Enabled = false;
            kButton5.Enabled = kButton6.Enabled = false;
            try
            {
                int tamano = int.Parse(kComboBox3.Text);
                var empleados = await servicio.ListarAsync(txtBuscar.Text, AyudaFormulario.IdSeleccionado(cboDepartamento),
                    AyudaFormulario.IdSeleccionado(cboTipoContrato), cboEstado.Text, pagina, tamano);
                if (IsDisposed)
                    return;
                bool siguiente = empleados.Count > tamano;
                if (siguiente)
                    empleados.RemoveAt(tamano);
                dgvEmpleados.Rows.Clear();
                foreach (var empleado in empleados)
                {
                    int fila = dgvEmpleados.Rows.Add(empleado.Codigo, empleado.Dpi, empleado.Nombre, empleado.Departamento, empleado.Puesto, empleado.Estado);
                    dgvEmpleados.Rows[fila].Tag = empleado;
                }
                kLabel8.Text = "Página " + (pagina + 1);
                kButton6.Enabled = pagina > 0;
                kButton5.Enabled = siguiente;
            }
            catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
            finally
            {
                cargando = false;
                if (!IsDisposed)
                {
                    dgvEmpleados.Enabled = true;
                    cboDepartamento.Enabled = cboTipoContrato.Enabled = cboEstado.Enabled = kComboBox3.Enabled = true;
                }
            }
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
            if (pagina > 0 && !cargando)
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
        private async Task AbrirExpedienteAsync(uint id)
        {
            if (sesion is null || cargando)
                return;
            using var formulario = new FrmExpedientes();
            formulario.Configurar(sesion, id);
            if (formulario.ShowDialog(TopLevelControl as Form ?? this) == DialogResult.OK)
            {
                await CargarAsync();
                notificador.Show("Empleados", "Expediente guardado.", KovaqsUI.Components.KToastKind.Success);
            }
        }
        private async void Agregar_Click(object? sender, EventArgs e)
        {
            await AbrirExpedienteAsync(0);
        }
        private async void Editar_Click(object? sender, EventArgs e)
        {
            if (Seleccionado is { } empleado)
                await AbrirExpedienteAsync(empleado.IdEmpleado);
        }
        private async void Historial_Click(object? sender, EventArgs e)
        {
            if (sesion is null || Seleccionado is not { } empleado || cargando)
                return;
            using var formulario = new FrmHistorialLaboral();
            formulario.Configurar(sesion, empleado.IdEmpleado, empleado.Nombre);
            formulario.ShowDialog(TopLevelControl as Form ?? this);
            await CargarAsync();
        }
        private async void Estado_Click(object? sender, EventArgs e)
        {
            if (sesion is null || Seleccionado is not { } empleado || cargando)
                return;
            using var formulario = new FrmEstadoEmpleado();
            formulario.Configurar(sesion, empleado);
            if (formulario.ShowDialog(TopLevelControl as Form ?? this) == DialogResult.OK)
                await CargarAsync();
        }
        private async void Eliminar_Click(object? sender, EventArgs e)
        {
            if (sesion is null || Seleccionado is not { } empleado || cargando)
                return;
            if (!AyudaFormulario.Confirmar(this, "¿Eliminar el expediente de " + empleado.Nombre + " y su historial?"))
                return;
            try
            {
                await servicio.EliminarAsync(empleado.IdEmpleado, sesion);
                pagina = 0;
                await CargarAsync();
            }
            catch (Exception ex) { AyudaFormulario.Error(notificador, ex); }
        }


        private void Constancia_Click(object? sender, EventArgs e)
        {
            if (sesion is null || Seleccionado is not { } empleado)
                return;
            using var formulario = new Presentacion.Forms.SubForms.Reportes.FrmConstanciaLaboral();
            formulario.Configurar(sesion, empleado.IdEmpleado);
            formulario.ShowDialog(TopLevelControl as Form ?? this);
        }

        private async void Seccion_VisibleChanged(object? sender, EventArgs e)
        {
            if (!Visible || !IsHandleCreated || cargando || kComboBox3.SelectedIndex < 0)
                return;
            cargando = true;
            try
            {

                uint departamento = AyudaFormulario.IdSeleccionado(cboDepartamento);
                AyudaFormulario.CargarCombo(cboDepartamento, await new ServicioCatalogos().OpcionesAsync("departamentos", 0, true), "Todos");
                if (IsDisposed)
                    return;
                cboDepartamento.SelectedValue = departamento;

                uint contrato = AyudaFormulario.IdSeleccionado(cboTipoContrato);
                AyudaFormulario.CargarCombo(cboTipoContrato, await new ServicioCatalogos().OpcionesAsync("contratos", 0, true), "Todos");
                if (IsDisposed)
                    return;
                cboTipoContrato.SelectedValue = contrato;

                pagina = 0;
            }
            catch (Exception ex) { if (!IsDisposed) AyudaFormulario.Error(notificador, ex); }
            finally { cargando = false; }
            if (!IsDisposed)
                await CargarAsync();
        }
    }
}
