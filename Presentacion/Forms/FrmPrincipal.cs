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
        private readonly SesionUsuario? sesion;
        private readonly Dictionary<KSegmentItem, Action> secciones = new();

        public FrmPrincipal()
        {
            InitializeComponent();
            btnCerrarSesion.Click += (_, _) => Close();
            //btnConfiguracion.Click += Configuracion_Click;
        }

        public FrmPrincipal(SesionUsuario sesion) : this()
        {
            this.sesion = sesion;
            lblNombre.Text = sesion.Nombre;
            lblRol.Text = sesion.Rol;
            lblAvatar.Text = sesion.NombreUsuario[..Math.Min(2, sesion.NombreUsuario.Length)].ToUpperInvariant();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            if (gestorFormularios is null)
            {
                gestorFormularios = new GestorFormularios(panelContenedor);
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
                secciones.Add(SConfiguracion, () => gestorFormularios.Mostrar<FrmConfigurarConexion>());
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
            //using var configuracion = new FrmConfigurarConexion();
            //gestorFormularios.Mostrar<FrmConfigurarConexion>();
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
    }
}
