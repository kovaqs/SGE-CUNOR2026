using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KovaqsUI.Controls;
using Presentacion.Forms.Secciones;
using Presentacion.Navegacion;
using Entidades;

namespace Presentacion.Forms
{
    public partial class FrmPrincipal : Form
    {
        private GestorFormularios? gestorFormularios;
        private SesionUsuario? sesion;
        public SesionUsuario? SesionActual => sesion;
        public bool SalirDeAplicacion { get; private set; }
        private readonly Dictionary<KSegmentItem, Action> secciones = new();

        public FrmPrincipal()
        {
            InitializeComponent();
            btnCerrarSesion.Click += (_, _) => Close();
        }

        public FrmPrincipal(SesionUsuario sesion) : this()
        {
            this.sesion = sesion;
            lblNombre.Text = sesion.Nombre;
            lblRol.Text = sesion.Rol;
            lblAvatar.Text = sesion.NombreUsuario[..Math.Min(2, sesion.NombreUsuario.Length)].ToUpperInvariant();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            if (gestorFormularios is null)
            {
                gestorFormularios = new GestorFormularios(panelContenedor);
                secciones.Add(SInicio, () => gestorFormularios.Mostrar<FrmInicio>());   
                secciones.Add(SEmpleados, () => gestorFormularios.Mostrar<FrmEmpleados>());
                secciones.Add(SPuestos, () => gestorFormularios.Mostrar<FrmPuestos>());
                secciones.Add(SDepartamentos, () => gestorFormularios.Mostrar<FrmDepartamentos>());
                secciones.Add(SAsistencias, () => gestorFormularios.Mostrar<FrmAsistencias>());
                secciones.Add(SReportes, () => gestorFormularios.Mostrar<FrmReportes>());
                secciones.Add(SNomina, () => gestorFormularios.Mostrar<FrmNomina>());
                secciones.Add(SUsuarios, () => 
                {
                    var usuarios = gestorFormularios.Mostrar<FrmUsuarios>();
                    if (sesion is not null)
                        usuarios.EstablecerSesion(sesion);
                });
                secciones.Add(SConfiguracion, () =>
                {
                    var configuracion = gestorFormularios.Mostrar<FrmConfiguracion>();
                    if (sesion is not null)
                        configuracion.EstablecerSesion(sesion);
                });
            }

            MostrarSeccionSeleccionada();
        }

        private void MostrarSeccionSeleccionada()
        {
            if (PanelSegmentado.SelectedItem is { } seleccion && secciones.TryGetValue(seleccion, out var mostrar))
                mostrar();
        }

        private void Configuracion_Click(object? sender, EventArgs e)
        {
            if (gestorFormularios is null || sesion is null)
                return;
            PanelSegmentado.SelectedIndex = -1;
            var cuenta = gestorFormularios.Mostrar<FrmMiCuenta>();
            cuenta.EstablecerSesion(sesion);
            cuenta.CuentaActualizada -= MiCuenta_CuentaActualizada;
            cuenta.CuentaActualizada += MiCuenta_CuentaActualizada;
        }

        private void MiCuenta_CuentaActualizada(object? sender, EventArgs e)
        {
            if (sender is not FrmMiCuenta cuenta || cuenta.SesionActual is null)
                return;
            sesion = cuenta.SesionActual;
            lblNombre.Text = sesion.Nombre;
            lblRol.Text = sesion.Rol;
            lblAvatar.Text = sesion.NombreUsuario[..Math.Min(2, sesion.NombreUsuario.Length)].ToUpperInvariant();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        { }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblRol_Click(object sender, EventArgs e)
        {

        }

        private void PanelSegmentado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarSeccionSeleccionada();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
            {
                MaximizedBounds = Screen.FromControl(this).WorkingArea;
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            SalirDeAplicacion = true;
            Close();
        }
    }
}
