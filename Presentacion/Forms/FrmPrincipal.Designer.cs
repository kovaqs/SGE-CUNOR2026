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
            panel2 = new Panel();
            kButton6 = new KovaqsUI.Controls.KButton();
            kButton5 = new KovaqsUI.Controls.KButton();
            kButton4 = new KovaqsUI.Controls.KButton();
            panel5 = new Panel();
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
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 780);
            panel1.TabIndex = 0;
            // 
            // PanelSegmentado
            // 
            PanelSegmentado.Appearance.Normal.ForeColor = Color.FromArgb(71, 71, 71);
            PanelSegmentado.BackColor = Color.Transparent;
            PanelSegmentado.Dock = DockStyle.Top;
            PanelSegmentado.FillColor = Color.FromArgb(247, 247, 247);
            PanelSegmentado.ForeColor = Color.FromArgb(71, 71, 71);
            PanelSegmentado.Items.AddRange(new KovaqsUI.Controls.KSegmentItem[] { SEmpleados, SPuestos, SDepartamentos, SAsistencias, SReportes, SNomina, SUsuarios, SConfiguracion });
            PanelSegmentado.Location = new Point(0, 97);
            PanelSegmentado.Name = "PanelSegmentado";
            PanelSegmentado.Orientation = Orientation.Vertical;
            PanelSegmentado.SelectedAppearance.Normal.FillColor = Color.FromArgb(44, 44, 44);
            PanelSegmentado.SelectedAppearance.Normal.ForeColor = Color.WhiteSmoke;
            PanelSegmentado.SelectedFillColor = Color.FromArgb(44, 44, 44);
            PanelSegmentado.SelectedForeColor = Color.WhiteSmoke;
            PanelSegmentado.SelectedIndex = 0;
            PanelSegmentado.Size = new Size(224, 328);
            PanelSegmentado.Surface.FillColor = Color.FromArgb(247, 247, 247);
            PanelSegmentado.TabIndex = 4;
            PanelSegmentado.Text = "kSegmentedControl1";
            PanelSegmentado.TextAlign = ContentAlignment.MiddleLeft;
            PanelSegmentado.SelectedIndexChanged += PanelSegmentado_SelectedIndexChanged;
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
            SNomina.Text = "Nomina";
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
            panel4.Location = new Point(0, 705);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 75);
            panel4.TabIndex = 3;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Animation.Duration = 200;
            btnCerrarSesion.Animation.Easing = KovaqsUI.Styling.KEasing.Linear;
            btnCerrarSesion.Appearance.Normal.ForeColor = Color.Red;
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.CornerRadius = 0;
            btnCerrarSesion.Dock = DockStyle.Top;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Inter", 10F);
            btnCerrarSesion.ForeColor = Color.Red;
            btnCerrarSesion.Location = new Point(0, 28);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(12, 4, 12, 4);
            btnCerrarSesion.Size = new Size(224, 28);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Variant = KovaqsUI.Styling.KButtonVariant.Ghost;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Animation.Duration = 200;
            btnConfiguracion.Animation.Easing = KovaqsUI.Styling.KEasing.Linear;
            btnConfiguracion.Appearance.Normal.ForeColor = Color.FromArgb(71, 71, 71);
            btnConfiguracion.BackColor = Color.Transparent;
            btnConfiguracion.CornerRadius = 0;
            btnConfiguracion.Dock = DockStyle.Top;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Inter", 10F);
            btnConfiguracion.ForeColor = Color.FromArgb(71, 71, 71);
            btnConfiguracion.Location = new Point(0, 0);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Padding = new Padding(12, 4, 12, 4);
            btnConfiguracion.Size = new Size(224, 28);
            btnConfiguracion.TabIndex = 0;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracion.UseVisualStyleBackColor = false;
            btnConfiguracion.Variant = KovaqsUI.Styling.KButtonVariant.Ghost;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblRol);
            panel3.Controls.Add(lblNombre);
            panel3.Controls.Add(kPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 36);
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
            lblRol.Font = new Font("Inter", 9F, FontStyle.Bold);
            lblRol.ForeColor = Color.FromArgb(71, 71, 71);
            lblRol.Location = new Point(64, 33);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(149, 23);
            lblRol.TabIndex = 2;
            lblRol.TextAlign = ContentAlignment.MiddleLeft;
            lblRol.Click += lblRol_Click;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = false;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Inter Medium", 9F);
            lblNombre.ForeColor = Color.FromArgb(71, 71, 71);
            lblNombre.Location = new Point(64, 6);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(149, 23);
            lblNombre.TabIndex = 1;
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // kPanel1
            // 
            kPanel1.BackColor = Color.Transparent;
            kPanel1.BorderThickness = 0;
            kPanel1.Controls.Add(lblAvatar);
            kPanel1.CornerRadius = 25;
            kPanel1.FillColor = Color.Gray;
            kPanel1.ForeColor = Color.Gainsboro;
            kPanel1.GradientColor = Color.FromArgb(64, 64, 64);
            kPanel1.Location = new Point(8, 6);
            kPanel1.Name = "kPanel1";
            kPanel1.Padding = new Padding(12);
            kPanel1.Size = new Size(50, 50);
            kPanel1.Surface.FillColor = Color.Gray;
            kPanel1.Surface.GradientColor = Color.FromArgb(64, 64, 64);
            kPanel1.TabIndex = 0;
            kPanel1.Paint += kPanel1_Paint;
            // 
            // lblAvatar
            // 
            lblAvatar.AutoSize = false;
            lblAvatar.BackColor = Color.Transparent;
            lblAvatar.Dock = DockStyle.Fill;
            lblAvatar.Font = new Font("Inter", 9F, FontStyle.Bold);
            lblAvatar.ForeColor = Color.FromArgb(224, 224, 224);
            lblAvatar.Location = new Point(12, 12);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(26, 26);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "US";
            lblAvatar.TextAlign = ContentAlignment.MiddleCenter;
            lblAvatar.Click += kLabel1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(kButton6);
            panel2.Controls.Add(kButton5);
            panel2.Controls.Add(kButton4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 36);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // kButton6
            // 
            kButton6.Appearance.Normal.FillColor = Color.FromArgb(35, 202, 60);
            kButton6.BackColor = Color.Transparent;
            kButton6.BorderThickness = 0;
            kButton6.ClickAnimation = false;
            kButton6.FillColor = Color.FromArgb(35, 202, 60);
            kButton6.FlatStyle = FlatStyle.Flat;
            kButton6.Location = new Point(55, 9);
            kButton6.Name = "kButton6";
            kButton6.Padding = new Padding(12, 4, 12, 4);
            kButton6.Size = new Size(16, 16);
            kButton6.TabIndex = 2;
            kButton6.UseVisualStyleBackColor = false;
            // 
            // kButton5
            // 
            kButton5.Appearance.Normal.FillColor = Color.FromArgb(255, 188, 48);
            kButton5.BackColor = Color.Transparent;
            kButton5.BorderThickness = 0;
            kButton5.ClickAnimation = false;
            kButton5.FillColor = Color.FromArgb(255, 188, 48);
            kButton5.FlatStyle = FlatStyle.Flat;
            kButton5.Location = new Point(33, 9);
            kButton5.Name = "kButton5";
            kButton5.Padding = new Padding(12, 4, 12, 4);
            kButton5.Size = new Size(16, 16);
            kButton5.TabIndex = 1;
            kButton5.UseVisualStyleBackColor = false;
            // 
            // kButton4
            // 
            kButton4.Appearance.Normal.FillColor = Color.FromArgb(255, 96, 88);
            kButton4.BackColor = Color.Transparent;
            kButton4.BorderThickness = 0;
            kButton4.ClickAnimation = false;
            kButton4.FillColor = Color.FromArgb(255, 96, 88);
            kButton4.FlatStyle = FlatStyle.Flat;
            kButton4.Location = new Point(11, 9);
            kButton4.Name = "kButton4";
            kButton4.Padding = new Padding(12, 4, 12, 4);
            kButton4.Size = new Size(16, 16);
            kButton4.TabIndex = 0;
            kButton4.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(224, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1126, 780);
            panel5.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 780);
            Controls.Add(panel5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
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
        private Panel panel2;
        private KovaqsUI.Controls.KSegmentItem SDepartamentos;
        private KovaqsUI.Controls.KSegmentItem SAsistencias;
        private KovaqsUI.Controls.KSegmentItem SReportes;
        private KovaqsUI.Controls.KSegmentItem SNomina;
        private KovaqsUI.Controls.KSegmentItem SUsuarios;
        private KovaqsUI.Controls.KSegmentItem SConfiguracion;
        private Panel panel4;
        private KovaqsUI.Controls.KButton btnConfiguracion;
        private KovaqsUI.Controls.KButton kButton4;
        private KovaqsUI.Controls.KButton kButton6;
        private KovaqsUI.Controls.KButton kButton5;
        private KovaqsUI.Controls.KPanel kPanel1;
        private KovaqsUI.Controls.KButton btnCerrarSesion;
        private KovaqsUI.Controls.KSegmentedControl PanelSegmentado;
        private KovaqsUI.Controls.KLabel lblAvatar;
        private KovaqsUI.Controls.KLabel lblRol;
        private KovaqsUI.Controls.KLabel lblNombre;
        private Panel panel5;
    }
}