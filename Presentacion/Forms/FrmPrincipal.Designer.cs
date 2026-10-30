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
            panel1 = new Panel();
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
            panel4 = new Panel();
            btnCerrarSesion = new KovaqsUI.Controls.KButton();
            btnConfiguracion = new KovaqsUI.Controls.KButton();
            panel3 = new Panel();
            lblRol = new KovaqsUI.Controls.KLabel();
            lblNombre = new KovaqsUI.Controls.KLabel();
            kPanel1 = new KovaqsUI.Controls.KPanel();
            lblAvatar = new KovaqsUI.Controls.KLabel();
            panel5 = new Panel();
            panelContenedor = new Panel();
            panel2 = new Panel();
            btnMaximizar = new KovaqsUI.Controls.KButton();
            btnMinimizar = new KovaqsUI.Controls.KButton();
            btnCerrar = new KovaqsUI.Controls.KButton();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            kPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 247, 247);
            panel1.Controls.Add(PanelSegmentado);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 769);
            panel1.TabIndex = 0;
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
            PanelSegmentado.SelectedIndex = 0;
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
            SUsuarios.Text = "Usuarios y Permisos";
            // 
            // SConfiguracion
            // 
            SConfiguracion.Text = "Configuración del Sistema";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCerrarSesion);
            panel4.Controls.Add(btnConfiguracion);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 694);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 75);
            panel4.TabIndex = 3;
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
            // panel3
            // 
            panel3.Controls.Add(lblRol);
            panel3.Controls.Add(lblNombre);
            panel3.Controls.Add(kPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 61);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
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
            // kPanel1
            // 
            kPanel1.BackColor = Color.Transparent;
            kPanel1.BorderThickness = 0;
            kPanel1.Controls.Add(lblAvatar);
            kPanel1.CornerRadius = 25;
            kPanel1.FillColor = Color.FromArgb(49, 81, 107);
            kPanel1.ForeColor = Color.Gainsboro;
            kPanel1.GradientColor = Color.Black;
            kPanel1.Location = new Point(8, 6);
            kPanel1.Name = "kPanel1";
            kPanel1.Padding = new Padding(12);
            kPanel1.Size = new Size(50, 50);
            kPanel1.Surface.FillColor = Color.FromArgb(49, 81, 107);
            kPanel1.Surface.GradientColor = Color.Black;
            kPanel1.TabIndex = 0;
            kPanel1.Paint += kPanel1_Paint;
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
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(224, 25);
            panel5.TabIndex = 0;
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
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnMaximizar);
            panel2.Controls.Add(btnMinimizar);
            panel2.Controls.Add(btnCerrar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(225, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1126, 25);
            panel2.TabIndex = 1;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Appearance.Normal.FillColor = Color.FromArgb(82, 139, 110);
            btnMaximizar.BackColor = Color.Transparent;
            btnMaximizar.BorderThickness = 0;
            btnMaximizar.ClickAnimation = false;
            btnMaximizar.FillColor = Color.FromArgb(82, 139, 110);
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            btnMaximizar.Location = new Point(1060, 5);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Padding = new Padding(12, 4, 12, 4);
            btnMaximizar.Size = new Size(16, 16);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.AccessibleName = "Maximizar o restaurar";
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Appearance.Normal.FillColor = Color.FromArgb(198, 159, 86);
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.BorderThickness = 0;
            btnMinimizar.ClickAnimation = false;
            btnMinimizar.FillColor = Color.FromArgb(198, 159, 86);
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
            btnMinimizar.Location = new Point(1082, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Padding = new Padding(12, 4, 12, 4);
            btnMinimizar.Size = new Size(16, 16);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.AccessibleName = "Minimizar";
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
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
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.AccessibleName = "Cerrar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1352, 771);
            Controls.Add(panelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1352, 771);
            Name = "FrmPrincipal";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            kPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private KovaqsUI.Controls.KSegmentItem SEmpleados;
        private KovaqsUI.Controls.KSegmentItem SPuestos;
        private Panel panel3;
        private KovaqsUI.Controls.KSegmentItem SDepartamentos;
        private KovaqsUI.Controls.KSegmentItem SAsistencias;
        private KovaqsUI.Controls.KSegmentItem SReportes;
        private KovaqsUI.Controls.KSegmentItem SNomina;
        private KovaqsUI.Controls.KSegmentItem SUsuarios;
        private KovaqsUI.Controls.KSegmentItem SConfiguracion;
        private Panel panel4;
        private KovaqsUI.Controls.KButton btnConfiguracion;
        private KovaqsUI.Controls.KPanel kPanel1;
        private KovaqsUI.Controls.KButton btnCerrarSesion;
        private KovaqsUI.Controls.KSegmentedControl PanelSegmentado;
        private KovaqsUI.Controls.KLabel lblAvatar;
        private KovaqsUI.Controls.KLabel lblRol;
        private KovaqsUI.Controls.KLabel lblNombre;
        private Panel panelContenedor;
        private Panel panel2;
        private KovaqsUI.Controls.KButton btnMaximizar;
        private KovaqsUI.Controls.KButton btnMinimizar;
        private KovaqsUI.Controls.KButton btnCerrar;
        private Panel panel5;
        private KovaqsUI.Controls.KSegmentItem SInicio;
    }
}
