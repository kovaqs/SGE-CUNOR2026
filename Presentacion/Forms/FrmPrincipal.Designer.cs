namespace Presentacion.Forms
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNavegacion = new Panel();
            PanelSegmentado = new KovaqsUI.Controls.KSegmentedControl();
            SInicio = new KovaqsUI.Controls.KSegmentItem();
            SEmpleados = new KovaqsUI.Controls.KSegmentItem();
            SPuestos = new KovaqsUI.Controls.KSegmentItem();
            SDepartamentos = new KovaqsUI.Controls.KSegmentItem();
            SAsistencias = new KovaqsUI.Controls.KSegmentItem();
            SReportes = new KovaqsUI.Controls.KSegmentItem();
            SNomina = new KovaqsUI.Controls.KSegmentItem();
            SUsuarios = new KovaqsUI.Controls.KSegmentItem();
            SConfiguracion = new KovaqsUI.Controls.KSegmentItem();
            panelOpcionesUsuario = new Panel();
            btnCerrarSesion = new KovaqsUI.Controls.KButton();
            btnConfiguracion = new KovaqsUI.Controls.KButton();
            panelUsuario = new Panel();
            lblRol = new KovaqsUI.Controls.KLabel();
            lblNombre = new KovaqsUI.Controls.KLabel();
            panelAvatar = new KovaqsUI.Controls.KPanel();
            lblAvatar = new KovaqsUI.Controls.KLabel();
            panelMargenSuperior = new Panel();
            panelContenedor = new Panel();
            panelVentana = new Panel();
            btnMaximizar = new KovaqsUI.Controls.KButton();
            btnMinimizar = new KovaqsUI.Controls.KButton();
            btnCerrar = new KovaqsUI.Controls.KButton();
            panelNavegacion.SuspendLayout();
            panelOpcionesUsuario.SuspendLayout();
            panelUsuario.SuspendLayout();
            panelAvatar.SuspendLayout();
            panelVentana.SuspendLayout();
            SuspendLayout();
            //
            // panelNavegacion
            //
            panelNavegacion.BackColor = Color.FromArgb(247, 247, 247);
            panelNavegacion.Controls.Add(PanelSegmentado);
            panelNavegacion.Controls.Add(panelOpcionesUsuario);
            panelNavegacion.Controls.Add(panelUsuario);
            panelNavegacion.Controls.Add(panelMargenSuperior);
            panelNavegacion.Dock = DockStyle.Left;
            panelNavegacion.Location = new Point(1, 1);
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Size = new Size(224, 769);
            panelNavegacion.TabIndex = 0;
            //
            // PanelSegmentado
            //
            PanelSegmentado.Appearance.Normal.ForeColor = Color.FromArgb(71, 71, 71);
            PanelSegmentado.BackColor = Color.Transparent;
            PanelSegmentado.Dock = DockStyle.Top;
            PanelSegmentado.FillColor = Color.FromArgb(247, 247, 247);
            PanelSegmentado.Font = new Font("Inter", 9F);
            PanelSegmentado.ForeColor = Color.FromArgb(71, 71, 71);
            PanelSegmentado.Items.AddRange(new KovaqsUI.Controls.KSegmentItem[] { SInicio, SEmpleados, SPuestos, SDepartamentos, SAsistencias, SReportes, SNomina, SUsuarios, SConfiguracion });
            PanelSegmentado.Location = new Point(0, 86);
            PanelSegmentado.Name = "PanelSegmentado";
            PanelSegmentado.Orientation = Orientation.Vertical;
            PanelSegmentado.SelectedAppearance.Normal.FillColor = Color.FromArgb(49, 81, 107);
            PanelSegmentado.SelectedAppearance.Normal.ForeColor = Color.WhiteSmoke;
            PanelSegmentado.SelectedFillColor = Color.FromArgb(49, 81, 107);
            PanelSegmentado.SelectedForeColor = Color.WhiteSmoke;
            PanelSegmentado.Size = new Size(224, 328);
            PanelSegmentado.Surface.FillColor = Color.FromArgb(247, 247, 247);
            PanelSegmentado.TabIndex = 2;
            PanelSegmentado.Text = "kSegmentedControl1";
            PanelSegmentado.TextAlign = ContentAlignment.MiddleLeft;
            PanelSegmentado.SelectedIndexChanged += PanelSegmentado_SelectedIndexChanged;
            //
            // SInicio
            //
            SInicio.Text = "Inicio";
            //
            // SEmpleados
            //
            SEmpleados.Text = "Empleados";
            //
            // SPuestos
            //
            SPuestos.Text = "Puestos";
            //
            // SDepartamentos
            //
            SDepartamentos.Text = "Departamentos";
            //
            // SAsistencias
            //
            SAsistencias.Text = "Control de Asistencias";
            //
            // SReportes
            //
            SReportes.Text = "Reportes";
            //
            // SNomina
            //
            SNomina.Text = "Nómina";
            //
            // SUsuarios
            //
            SUsuarios.Text = "Usuarios";
            //
            // SConfiguracion
            //
            SConfiguracion.Text = "Configuración del Sistema";
            //
            // panelOpcionesUsuario
            //
            panelOpcionesUsuario.Controls.Add(btnCerrarSesion);
            panelOpcionesUsuario.Controls.Add(btnConfiguracion);
            panelOpcionesUsuario.Dock = DockStyle.Bottom;
            panelOpcionesUsuario.Location = new Point(0, 694);
            panelOpcionesUsuario.Name = "panelOpcionesUsuario";
            panelOpcionesUsuario.Size = new Size(224, 75);
            panelOpcionesUsuario.TabIndex = 3;
            //
            // btnCerrarSesion
            //
            btnCerrarSesion.Animation.Duration = 200;
            btnCerrarSesion.Animation.Easing = KovaqsUI.Styling.KEasing.Linear;
            btnCerrarSesion.Appearance.Hover.FillColor = Color.FromArgb(250, 235, 235);
            btnCerrarSesion.Appearance.Normal.BorderColor = Color.FromArgb(204, 148, 150);
            btnCerrarSesion.Appearance.Normal.FillColor = Color.FromArgb(255, 248, 248);
            btnCerrarSesion.Appearance.Normal.ForeColor = Color.FromArgb(166, 61, 64);
            btnCerrarSesion.Appearance.Pressed.FillColor = Color.FromArgb(244, 219, 220);
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.BorderColor = Color.FromArgb(204, 148, 150);
            btnCerrarSesion.BorderThickness = 0;
            btnCerrarSesion.CornerRadius = 8;
            btnCerrarSesion.Dock = DockStyle.Top;
            btnCerrarSesion.FillColor = Color.FromArgb(255, 248, 248);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.FocusAppearance.Color = Color.FromArgb(166, 61, 64);
            btnCerrarSesion.Font = new Font("Inter", 9F);
            btnCerrarSesion.ForeColor = Color.FromArgb(166, 61, 64);
            btnCerrarSesion.Location = new Point(0, 28);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(10, 4, 10, 4);
            btnCerrarSesion.Size = new Size(224, 28);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Variant = KovaqsUI.Styling.KButtonVariant.Danger;
            //
            // btnConfiguracion
            //
            btnConfiguracion.Animation.Duration = 200;
            btnConfiguracion.Animation.Easing = KovaqsUI.Styling.KEasing.Linear;
            btnConfiguracion.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
            btnConfiguracion.Appearance.Normal.BorderColor = Color.Transparent;
            btnConfiguracion.Appearance.Normal.FillColor = Color.Transparent;
            btnConfiguracion.Appearance.Normal.ForeColor = Color.FromArgb(32, 38, 45);
            btnConfiguracion.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
            btnConfiguracion.BackColor = Color.Transparent;
            btnConfiguracion.BorderColor = Color.Transparent;
            btnConfiguracion.BorderThickness = 0;
            btnConfiguracion.CornerRadius = 8;
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FillColor = Color.Transparent;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            btnConfiguracion.Font = new Font("Inter", 9F);
            btnConfiguracion.ForeColor = Color.FromArgb(32, 38, 45);
            btnConfiguracion.Location = new Point(0, 0);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(10, 4, 10, 4);
            btnConfiguracion.Size = new Size(224, 28);
            btnConfiguracion.TabIndex = 0;
            btnConfiguracion.Text = "Mi cuenta";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Variant = KovaqsUI.Styling.KButtonVariant.Ghost;
            btnConfiguracion.Click += Configuracion_Click;
            //
            // panelUsuario
            //
            panelUsuario.Controls.Add(lblRol);
            panelUsuario.Controls.Add(lblNombre);
            panelUsuario.Controls.Add(panelAvatar);
            panelUsuario.Dock = DockStyle.Top;
            panelUsuario.Location = new Point(0, 25);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(224, 61);
            panelUsuario.TabIndex = 1;
            panelUsuario.Paint += panelUsuario_Paint;
            //
            // lblRol
            //
            lblRol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblRol.AutoSize = false;
            lblRol.BackColor = Color.Transparent;
            lblRol.Font = new Font("Inter", 9F);
            lblRol.ForeColor = Color.FromArgb(64, 64, 64);
            lblRol.Location = new Point(64, 33);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(149, 23);
            lblRol.TabIndex = 2;
            lblRol.TextAlign = ContentAlignment.MiddleLeft;
            lblRol.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblRol.Click += lblRol_Click;
            //
            // lblNombre
            //
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = false;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Inter", 9F);
            lblNombre.ForeColor = Color.FromArgb(64, 64, 64);
            lblNombre.Location = new Point(64, 6);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(149, 23);
            lblNombre.TabIndex = 1;
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            lblNombre.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // panelAvatar
            //
            panelAvatar.BackColor = Color.Transparent;
            panelAvatar.BorderThickness = 0;
            panelAvatar.Controls.Add(lblAvatar);
            panelAvatar.CornerRadius = 25;
            panelAvatar.FillColor = Color.FromArgb(49, 81, 107);
            panelAvatar.ForeColor = Color.Gainsboro;
            panelAvatar.GradientColor = Color.Black;
            panelAvatar.Location = new Point(8, 6);
            panelAvatar.Name = "panelAvatar";
            panelAvatar.Padding = new Padding(12);
            panelAvatar.Size = new Size(50, 50);
            panelAvatar.Surface.FillColor = Color.FromArgb(49, 81, 107);
            panelAvatar.Surface.GradientColor = Color.Black;
            panelAvatar.TabIndex = 0;
            panelAvatar.Paint += panelAvatar_Paint;
            //
            // lblAvatar
            //
            lblAvatar.AutoSize = false;
            lblAvatar.BackColor = Color.Transparent;
            lblAvatar.Dock = DockStyle.Fill;
            lblAvatar.Font = new Font("Inter", 9F);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(12, 12);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(26, 26);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "US";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            lblAvatar.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            lblAvatar.Click += kLabel1_Click;
            //
            // panelMargenSuperior
            //
            panelMargenSuperior.Dock = DockStyle.Top;
            panelMargenSuperior.Location = new Point(0, 0);
            panelMargenSuperior.Name = "panelMargenSuperior";
            panelMargenSuperior.Size = new Size(224, 25);
            panelMargenSuperior.TabIndex = 0;
            //
            // panelContenedor
            //
            panelContenedor.BackColor = Color.White;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(225, 26);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1126, 744);
            panelContenedor.TabIndex = 2;
            panelContenedor.Paint += panelContenedor_Paint;
            //
            // panelVentana
            //
            panelVentana.BackColor = Color.White;
            panelVentana.Controls.Add(btnMaximizar);
            panelVentana.Controls.Add(btnMinimizar);
            panelVentana.Controls.Add(btnCerrar);
            panelVentana.Dock = DockStyle.Top;
            panelVentana.Location = new Point(225, 1);
            panelVentana.Name = "panelVentana";
            panelVentana.Size = new Size(1126, 25);
            panelVentana.TabIndex = 1;
            //
            // btnMaximizar
            //
            btnMaximizar.AccessibleName = "Maximizar o restaurar";
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Appearance.Normal.FillColor = Color.FromArgb(82, 139, 110);
            btnMaximizar.BackColor = Color.Transparent;
            btnMaximizar.BorderThickness = 0;
            btnMaximizar.ClickAnimation = false;
            btnMaximizar.FillColor = Color.FromArgb(82, 139, 110);
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            btnMaximizar.Location = new Point(1082, 5);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Padding = new Padding(12, 4, 12, 4);
            btnMaximizar.Size = new Size(16, 16);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            //
            // btnMinimizar
            //
            btnMinimizar.AccessibleName = "Minimizar";
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Appearance.Normal.FillColor = Color.FromArgb(198, 159, 86);
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.BorderThickness = 0;
            btnMinimizar.ClickAnimation = false;
            btnMinimizar.FillColor = Color.FromArgb(198, 159, 86);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            btnMinimizar.Location = new Point(1060, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Padding = new Padding(12, 4, 12, 4);
            btnMinimizar.Size = new Size(16, 16);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            //
            // btnCerrar
            //
            btnCerrar.AccessibleName = "Cerrar";
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Appearance.Normal.FillColor = Color.Chocolate;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.BorderThickness = 0;
            btnCerrar.ClickAnimation = false;
            btnCerrar.FillColor = Color.Chocolate;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            btnCerrar.Location = new Point(1104, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Padding = new Padding(12, 4, 12, 4);
            btnCerrar.Size = new Size(16, 16);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            //
            // FrmPrincipal
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1352, 771);
            Controls.Add(panelContenedor);
            Controls.Add(panelVentana);
            Controls.Add(panelNavegacion);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1352, 771);
            Icon = Properties.Resources.sgeicon;
            Name = "FrmPrincipal";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            panelNavegacion.ResumeLayout(false);
            panelOpcionesUsuario.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            panelAvatar.ResumeLayout(false);
            panelVentana.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavegacion;
        private KovaqsUI.Controls.KSegmentItem SEmpleados;
        private KovaqsUI.Controls.KSegmentItem SPuestos;
        private Panel panelUsuario;
        private KovaqsUI.Controls.KSegmentItem SDepartamentos;
        private KovaqsUI.Controls.KSegmentItem SAsistencias;
        private KovaqsUI.Controls.KSegmentItem SReportes;
        private KovaqsUI.Controls.KSegmentItem SNomina;
        private KovaqsUI.Controls.KSegmentItem SUsuarios;
        private KovaqsUI.Controls.KSegmentItem SConfiguracion;
        private Panel panelOpcionesUsuario;
        private KovaqsUI.Controls.KButton btnConfiguracion;
        private KovaqsUI.Controls.KPanel panelAvatar;
        private KovaqsUI.Controls.KButton btnCerrarSesion;
        private KovaqsUI.Controls.KSegmentedControl PanelSegmentado;
        private KovaqsUI.Controls.KLabel lblAvatar;
        private KovaqsUI.Controls.KLabel lblRol;
        private KovaqsUI.Controls.KLabel lblNombre;
        private Panel panelContenedor;
        private Panel panelVentana;
        private KovaqsUI.Controls.KButton btnMaximizar;
        private KovaqsUI.Controls.KButton btnMinimizar;
        private KovaqsUI.Controls.KButton btnCerrar;
        private Panel panelMargenSuperior;
        private KovaqsUI.Controls.KSegmentItem SInicio;
    }
}
