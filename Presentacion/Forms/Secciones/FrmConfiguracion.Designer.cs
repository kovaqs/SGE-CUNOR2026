namespace Presentacion.Forms.Secciones;

partial class FrmConfiguracion
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblTitulo = new KovaqsUI.Controls.KLabel();
        lblEmpresa = new KovaqsUI.Controls.KLabel();
        lblNombreEmpresa = new KovaqsUI.Controls.KLabel();
        txtNombreEmpresa = new KovaqsUI.Controls.KTextBox();
        lblNit = new KovaqsUI.Controls.KLabel();
        txtNit = new KovaqsUI.Controls.KTextBox();
        lblDireccion = new KovaqsUI.Controls.KLabel();
        txtDireccion = new KovaqsUI.Controls.KTextBox();
        lblTelefono = new KovaqsUI.Controls.KLabel();
        txtTelefono = new KovaqsUI.Controls.KTextBox();
        lblCorreo = new KovaqsUI.Controls.KLabel();
        txtCorreo = new KovaqsUI.Controls.KTextBox();
        lblMoneda = new KovaqsUI.Controls.KLabel();
        cboMoneda = new KovaqsUI.Controls.KComboBox();
        lblZonaHoraria = new KovaqsUI.Controls.KLabel();
        cboZonaHoraria = new KovaqsUI.Controls.KComboBox();
        btnGuardarEmpresa = new KovaqsUI.Controls.KButton();
        lblCatalogos = new KovaqsUI.Controls.KLabel();
        btnTiposContrato = new KovaqsUI.Controls.KButton();
        btnHorarios = new KovaqsUI.Controls.KButton();
        btnRoles = new KovaqsUI.Controls.KButton();
        btnBitacora = new KovaqsUI.Controls.KButton();
        btnConexion = new KovaqsUI.Controls.KButton();
        notificador = new KovaqsUI.Components.KToastNotifier(components);
        SuspendLayout();
        //
        // lblTitulo
        //
        lblTitulo.AutoSize = false;
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.ForeColor = Color.FromArgb(32, 38, 45);
        lblTitulo.TextRole = KovaqsUI.Controls.KTextRole.Title;
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        lblTitulo.Text = "Configuración general y catálogos";
        lblTitulo.Font = new Font("Inter", 16F, FontStyle.Bold);
        lblTitulo.Location = new Point(16, 12);
        lblTitulo.Dock = DockStyle.None;
        lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1094, 40);
        lblTitulo.TabIndex = 0;
        lblTitulo.TabStop = false;
        //
        // lblEmpresa
        //
        lblEmpresa.AutoSize = false;
        lblEmpresa.BackColor = Color.Transparent;
        lblEmpresa.ForeColor = Color.FromArgb(64, 64, 64);
        lblEmpresa.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblEmpresa.TextAlign = ContentAlignment.MiddleLeft;
        lblEmpresa.Text = "Datos de la empresa";
        lblEmpresa.Font = new Font("Inter", 9F);
        lblEmpresa.Location = new Point(16, 64);
        lblEmpresa.Name = "lblEmpresa";
        lblEmpresa.Size = new Size(560, 26);
        lblEmpresa.TabIndex = 1;
        lblEmpresa.TabStop = false;
        //
        // lblNombreEmpresa
        //
        lblNombreEmpresa.AutoSize = false;
        lblNombreEmpresa.BackColor = Color.Transparent;
        lblNombreEmpresa.ForeColor = Color.FromArgb(64, 64, 64);
        lblNombreEmpresa.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNombreEmpresa.TextAlign = ContentAlignment.MiddleLeft;
        lblNombreEmpresa.Text = "Nombre de la empresa";
        lblNombreEmpresa.Location = new Point(16, 98);
        lblNombreEmpresa.Font = new Font("Inter", 9F);
        lblNombreEmpresa.Name = "lblNombreEmpresa";
        lblNombreEmpresa.Size = new Size(352, 24);
        lblNombreEmpresa.TabIndex = 3;
        lblNombreEmpresa.TabStop = false;
        //
        // txtNombreEmpresa
        //
        txtNombreEmpresa.BackColor = Color.Transparent;
        txtNombreEmpresa.CornerRadius = 8;
        txtNombreEmpresa.Font = new Font("Inter", 9F);
        txtNombreEmpresa.Padding = new Padding(10, 6, 10, 6);
        txtNombreEmpresa.MaxLength = 150;
        txtNombreEmpresa.Location = new Point(16, 124);
        txtNombreEmpresa.FillColor = Color.White;
        txtNombreEmpresa.ForeColor = Color.FromArgb(32, 38, 45);
        txtNombreEmpresa.BorderColor = Color.FromArgb(218, 218, 218);
        txtNombreEmpresa.GradientColor = Color.Empty;
        txtNombreEmpresa.BorderThickness = 1;
        txtNombreEmpresa.Name = "txtNombreEmpresa";
        txtNombreEmpresa.Size = new Size(352, 34);
        txtNombreEmpresa.TabIndex = 6;
        //
        // lblNit
        //
        lblNit.AutoSize = false;
        lblNit.BackColor = Color.Transparent;
        lblNit.ForeColor = Color.FromArgb(64, 64, 64);
        lblNit.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNit.TextAlign = ContentAlignment.MiddleLeft;
        lblNit.Text = "NIT";
        lblNit.Location = new Point(386, 98);
        lblNit.Font = new Font("Inter", 9F);
        lblNit.Name = "lblNit";
        lblNit.Size = new Size(352, 24);
        lblNit.TabIndex = 4;
        lblNit.TabStop = false;
        //
        // txtNit
        //
        txtNit.BackColor = Color.Transparent;
        txtNit.CornerRadius = 8;
        txtNit.Font = new Font("Inter", 9F);
        txtNit.Padding = new Padding(10, 6, 10, 6);
        txtNit.MaxLength = 25;
        txtNit.Location = new Point(386, 124);
        txtNit.FillColor = Color.White;
        txtNit.ForeColor = Color.FromArgb(32, 38, 45);
        txtNit.BorderColor = Color.FromArgb(218, 218, 218);
        txtNit.GradientColor = Color.Empty;
        txtNit.BorderThickness = 1;
        txtNit.Name = "txtNit";
        txtNit.Size = new Size(352, 34);
        txtNit.TabIndex = 7;
        //
        // lblDireccion
        //
        lblDireccion.AutoSize = false;
        lblDireccion.BackColor = Color.Transparent;
        lblDireccion.ForeColor = Color.FromArgb(64, 64, 64);
        lblDireccion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblDireccion.TextAlign = ContentAlignment.MiddleLeft;
        lblDireccion.Text = "Dirección";
        lblDireccion.Location = new Point(16, 168);
        lblDireccion.Font = new Font("Inter", 9F);
        lblDireccion.Name = "lblDireccion";
        lblDireccion.Size = new Size(352, 24);
        lblDireccion.TabIndex = 9;
        lblDireccion.TabStop = false;
        //
        // txtDireccion
        //
        txtDireccion.BackColor = Color.Transparent;
        txtDireccion.CornerRadius = 8;
        txtDireccion.Font = new Font("Inter", 9F);
        txtDireccion.Padding = new Padding(10, 6, 10, 6);
        txtDireccion.MaxLength = 250;
        txtDireccion.Location = new Point(16, 194);
        txtDireccion.FillColor = Color.White;
        txtDireccion.ForeColor = Color.FromArgb(32, 38, 45);
        txtDireccion.BorderColor = Color.FromArgb(218, 218, 218);
        txtDireccion.GradientColor = Color.Empty;
        txtDireccion.BorderThickness = 1;
        txtDireccion.Name = "txtDireccion";
        txtDireccion.Size = new Size(352, 34);
        txtDireccion.TabIndex = 11;
        //
        // lblTelefono
        //
        lblTelefono.AutoSize = false;
        lblTelefono.BackColor = Color.Transparent;
        lblTelefono.ForeColor = Color.FromArgb(64, 64, 64);
        lblTelefono.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
        lblTelefono.Text = "Teléfono";
        lblTelefono.Location = new Point(386, 168);
        lblTelefono.Font = new Font("Inter", 9F);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(352, 24);
        lblTelefono.TabIndex = 10;
        lblTelefono.TabStop = false;
        //
        // txtTelefono
        //
        txtTelefono.BackColor = Color.Transparent;
        txtTelefono.CornerRadius = 8;
        txtTelefono.Font = new Font("Inter", 9F);
        txtTelefono.Padding = new Padding(10, 6, 10, 6);
        txtTelefono.MaxLength = 25;
        txtTelefono.Location = new Point(386, 194);
        txtTelefono.FillColor = Color.White;
        txtTelefono.ForeColor = Color.FromArgb(32, 38, 45);
        txtTelefono.BorderColor = Color.FromArgb(218, 218, 218);
        txtTelefono.GradientColor = Color.Empty;
        txtTelefono.BorderThickness = 1;
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(352, 34);
        txtTelefono.TabIndex = 12;
        //
        // lblCorreo
        //
        lblCorreo.AutoSize = false;
        lblCorreo.BackColor = Color.Transparent;
        lblCorreo.ForeColor = Color.FromArgb(64, 64, 64);
        lblCorreo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblCorreo.TextAlign = ContentAlignment.MiddleLeft;
        lblCorreo.Text = "Correo electrónico";
        lblCorreo.Location = new Point(16, 238);
        lblCorreo.Font = new Font("Inter", 9F);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(352, 24);
        lblCorreo.TabIndex = 14;
        lblCorreo.TabStop = false;
        //
        // txtCorreo
        //
        txtCorreo.BackColor = Color.Transparent;
        txtCorreo.CornerRadius = 8;
        txtCorreo.Font = new Font("Inter", 9F);
        txtCorreo.Padding = new Padding(10, 6, 10, 6);
        txtCorreo.MaxLength = 254;
        txtCorreo.Location = new Point(16, 264);
        txtCorreo.FillColor = Color.White;
        txtCorreo.ForeColor = Color.FromArgb(32, 38, 45);
        txtCorreo.BorderColor = Color.FromArgb(218, 218, 218);
        txtCorreo.GradientColor = Color.Empty;
        txtCorreo.BorderThickness = 1;
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new Size(352, 34);
        txtCorreo.TabIndex = 16;
        //
        // lblMoneda
        //
        lblMoneda.AutoSize = false;
        lblMoneda.BackColor = Color.Transparent;
        lblMoneda.ForeColor = Color.FromArgb(64, 64, 64);
        lblMoneda.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblMoneda.TextAlign = ContentAlignment.MiddleLeft;
        lblMoneda.Text = "Moneda";
        lblMoneda.Location = new Point(386, 238);
        lblMoneda.Font = new Font("Inter", 9F);
        lblMoneda.Name = "lblMoneda";
        lblMoneda.Size = new Size(352, 24);
        lblMoneda.TabIndex = 15;
        lblMoneda.TabStop = false;
        //
        // cboMoneda
        //
        cboMoneda.Font = new Font("Inter", 9F);
        cboMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
        cboMoneda.FormattingEnabled = true;
        cboMoneda.Items.AddRange(new object[] { "GTQ" });
        cboMoneda.Location = new Point(386, 264);
        cboMoneda.CornerRadius = 8;
        cboMoneda.FillColor = Color.White;
        cboMoneda.ForeColor = Color.FromArgb(32, 38, 45);
        cboMoneda.BorderColor = Color.FromArgb(218, 218, 218);
        cboMoneda.GradientColor = Color.Empty;

        cboMoneda.Name = "cboMoneda";
        cboMoneda.Size = new Size(352, 34);
        cboMoneda.TabIndex = 17;
        //
        // lblZonaHoraria
        //
        lblZonaHoraria.AutoSize = false;
        lblZonaHoraria.BackColor = Color.Transparent;
        lblZonaHoraria.ForeColor = Color.FromArgb(64, 64, 64);
        lblZonaHoraria.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblZonaHoraria.TextAlign = ContentAlignment.MiddleLeft;
        lblZonaHoraria.Text = "Zona horaria";
        lblZonaHoraria.Location = new Point(16, 308);
        lblZonaHoraria.Font = new Font("Inter", 9F);
        lblZonaHoraria.Name = "lblZonaHoraria";
        lblZonaHoraria.Size = new Size(352, 24);
        lblZonaHoraria.TabIndex = 19;
        lblZonaHoraria.TabStop = false;
        //
        // cboZonaHoraria
        //
        cboZonaHoraria.Font = new Font("Inter", 9F);
        cboZonaHoraria.DropDownStyle = ComboBoxStyle.DropDownList;
        cboZonaHoraria.FormattingEnabled = true;
        cboZonaHoraria.Items.AddRange(new object[] { "America/Guatemala" });
        cboZonaHoraria.Location = new Point(16, 334);
        cboZonaHoraria.CornerRadius = 8;
        cboZonaHoraria.FillColor = Color.White;
        cboZonaHoraria.ForeColor = Color.FromArgb(32, 38, 45);
        cboZonaHoraria.BorderColor = Color.FromArgb(218, 218, 218);
        cboZonaHoraria.GradientColor = Color.Empty;

        cboZonaHoraria.Name = "cboZonaHoraria";
        cboZonaHoraria.Size = new Size(352, 34);
        cboZonaHoraria.TabIndex = 21;
        //
        // btnGuardarEmpresa
        //
        btnGuardarEmpresa.BackColor = Color.Transparent;
        btnGuardarEmpresa.CornerRadius = 8;
        btnGuardarEmpresa.FlatStyle = FlatStyle.Flat;
        btnGuardarEmpresa.Font = new Font("Inter", 9F);
        btnGuardarEmpresa.Padding = new Padding(10, 4, 10, 4);
        btnGuardarEmpresa.UseVisualStyleBackColor = false;
        btnGuardarEmpresa.Text = "Guardar empresa";
        btnGuardarEmpresa.Location = new Point(16, 388);
        btnGuardarEmpresa.BorderThickness = 1;
        btnGuardarEmpresa.Variant = KovaqsUI.Styling.KButtonVariant.Primary;
        btnGuardarEmpresa.FillColor = Color.FromArgb(49, 81, 107);
        btnGuardarEmpresa.ForeColor = Color.White;
        btnGuardarEmpresa.BorderColor = Color.FromArgb(49, 81, 107);
        btnGuardarEmpresa.GradientColor = Color.Empty;
        btnGuardarEmpresa.Appearance.Hover.FillColor = Color.FromArgb(41, 69, 93);
        btnGuardarEmpresa.Appearance.Pressed.FillColor = Color.FromArgb(33, 56, 77);
        btnGuardarEmpresa.FocusAppearance.Color = Color.FromArgb(221, 234, 244);
        btnGuardarEmpresa.Name = "btnGuardarEmpresa";
        btnGuardarEmpresa.Size = new Size(200, 40);
        btnGuardarEmpresa.TabIndex = 22;
        //
        // lblCatalogos
        //
        lblCatalogos.AutoSize = false;
        lblCatalogos.BackColor = Color.Transparent;
        lblCatalogos.ForeColor = Color.FromArgb(64, 64, 64);
        lblCatalogos.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblCatalogos.TextAlign = ContentAlignment.MiddleLeft;
        lblCatalogos.Text = "Catálogos y administración";
        lblCatalogos.Font = new Font("Inter", 9F);
        lblCatalogos.Location = new Point(792, 64);
        lblCatalogos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lblCatalogos.Name = "lblCatalogos";
        lblCatalogos.Size = new Size(318, 26);
        lblCatalogos.TabIndex = 2;
        lblCatalogos.TabStop = false;
        //
        // btnTiposContrato
        //
        btnTiposContrato.BackColor = Color.Transparent;
        btnTiposContrato.CornerRadius = 8;
        btnTiposContrato.FlatStyle = FlatStyle.Flat;
        btnTiposContrato.Font = new Font("Inter", 9F);
        btnTiposContrato.Padding = new Padding(10, 4, 10, 4);
        btnTiposContrato.UseVisualStyleBackColor = false;
        btnTiposContrato.Text = "Tipos de contrato";
        btnTiposContrato.Location = new Point(792, 106);
        btnTiposContrato.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnTiposContrato.BorderThickness = 1;
        btnTiposContrato.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnTiposContrato.FillColor = Color.White;
        btnTiposContrato.ForeColor = Color.FromArgb(32, 38, 45);
        btnTiposContrato.BorderColor = Color.FromArgb(218, 218, 218);
        btnTiposContrato.GradientColor = Color.Empty;
        btnTiposContrato.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnTiposContrato.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnTiposContrato.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnTiposContrato.Name = "btnTiposContrato";
        btnTiposContrato.Size = new Size(318, 40);
        btnTiposContrato.TabIndex = 5;
        //
        // btnHorarios
        //
        btnHorarios.BackColor = Color.Transparent;
        btnHorarios.CornerRadius = 8;
        btnHorarios.FlatStyle = FlatStyle.Flat;
        btnHorarios.Font = new Font("Inter", 9F);
        btnHorarios.Padding = new Padding(10, 4, 10, 4);
        btnHorarios.UseVisualStyleBackColor = false;
        btnHorarios.Text = "Horarios";
        btnHorarios.Location = new Point(792, 162);
        btnHorarios.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnHorarios.BorderThickness = 1;
        btnHorarios.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnHorarios.FillColor = Color.White;
        btnHorarios.ForeColor = Color.FromArgb(32, 38, 45);
        btnHorarios.BorderColor = Color.FromArgb(218, 218, 218);
        btnHorarios.GradientColor = Color.Empty;
        btnHorarios.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnHorarios.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnHorarios.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnHorarios.Name = "btnHorarios";
        btnHorarios.Size = new Size(318, 40);
        btnHorarios.TabIndex = 8;
        //
        // btnRoles
        //
        btnRoles.BackColor = Color.Transparent;
        btnRoles.CornerRadius = 8;
        btnRoles.FlatStyle = FlatStyle.Flat;
        btnRoles.Font = new Font("Inter", 9F);
        btnRoles.Padding = new Padding(10, 4, 10, 4);
        btnRoles.UseVisualStyleBackColor = false;
        btnRoles.Text = "Roles y permisos";
        btnRoles.Location = new Point(792, 218);
        btnRoles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnRoles.BorderThickness = 1;
        btnRoles.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnRoles.FillColor = Color.White;
        btnRoles.ForeColor = Color.FromArgb(32, 38, 45);
        btnRoles.BorderColor = Color.FromArgb(218, 218, 218);
        btnRoles.GradientColor = Color.Empty;
        btnRoles.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnRoles.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnRoles.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnRoles.Name = "btnRoles";
        btnRoles.Size = new Size(318, 40);
        btnRoles.TabIndex = 13;
        //
        // btnBitacora
        //
        btnBitacora.BackColor = Color.Transparent;
        btnBitacora.CornerRadius = 8;
        btnBitacora.FlatStyle = FlatStyle.Flat;
        btnBitacora.Font = new Font("Inter", 9F);
        btnBitacora.Padding = new Padding(10, 4, 10, 4);
        btnBitacora.UseVisualStyleBackColor = false;
        btnBitacora.Text = "Bitácora";
        btnBitacora.Location = new Point(792, 274);
        btnBitacora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnBitacora.BorderThickness = 1;
        btnBitacora.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnBitacora.FillColor = Color.White;
        btnBitacora.ForeColor = Color.FromArgb(32, 38, 45);
        btnBitacora.BorderColor = Color.FromArgb(218, 218, 218);
        btnBitacora.GradientColor = Color.Empty;
        btnBitacora.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnBitacora.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnBitacora.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnBitacora.Name = "btnBitacora";
        btnBitacora.Size = new Size(318, 40);
        btnBitacora.TabIndex = 18;
        //
        // btnConexion
        //
        btnConexion.BackColor = Color.Transparent;
        btnConexion.CornerRadius = 8;
        btnConexion.FlatStyle = FlatStyle.Flat;
        btnConexion.Font = new Font("Inter", 9F);
        btnConexion.Padding = new Padding(10, 4, 10, 4);
        btnConexion.UseVisualStyleBackColor = false;
        btnConexion.Text = "Conexión a MySQL";
        btnConexion.Location = new Point(792, 330);
        btnConexion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnConexion.BorderThickness = 1;
        btnConexion.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnConexion.FillColor = Color.White;
        btnConexion.ForeColor = Color.FromArgb(32, 38, 45);
        btnConexion.BorderColor = Color.FromArgb(218, 218, 218);
        btnConexion.GradientColor = Color.Empty;
        btnConexion.Appearance.Hover.FillColor = Color.FromArgb(244, 246, 248);
        btnConexion.Appearance.Pressed.FillColor = Color.FromArgb(233, 237, 241);
        btnConexion.FocusAppearance.Color = Color.FromArgb(49, 81, 107);
        btnConexion.Name = "btnConexion";
        btnConexion.Size = new Size(318, 40);
        btnConexion.TabIndex = 20;
        btnConexion.Click += btnConexion_Click;
        notificador.OwnerForm = this;
        //
        // FrmConfiguracion
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1126, 744);
        Controls.Add(lblTitulo);
        Controls.Add(lblEmpresa);
        Controls.Add(lblNombreEmpresa);
        Controls.Add(txtNombreEmpresa);
        Controls.Add(lblNit);
        Controls.Add(txtNit);
        Controls.Add(lblDireccion);
        Controls.Add(txtDireccion);
        Controls.Add(lblTelefono);
        Controls.Add(txtTelefono);
        Controls.Add(lblCorreo);
        Controls.Add(txtCorreo);
        Controls.Add(lblMoneda);
        Controls.Add(cboMoneda);
        Controls.Add(lblZonaHoraria);
        Controls.Add(cboZonaHoraria);
        Controls.Add(btnGuardarEmpresa);
        Controls.Add(lblCatalogos);
        Controls.Add(btnTiposContrato);
        Controls.Add(btnHorarios);
        Controls.Add(btnRoles);
        Controls.Add(btnBitacora);
        Controls.Add(btnConexion);
        MinimumSize = new Size(1126, 744);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3);
        Font = new Font("Segoe UI", 9F);
        Icon = Properties.Resources.sgeicon;
        Name = "FrmConfiguracion";
        Text = "Configuración general y catálogos";
        ResumeLayout(false);
    }

    #endregion


    private KovaqsUI.Controls.KLabel lblTitulo;
    private KovaqsUI.Controls.KLabel lblEmpresa;
    private KovaqsUI.Controls.KLabel lblNombreEmpresa;
    private KovaqsUI.Controls.KTextBox txtNombreEmpresa;
    private KovaqsUI.Controls.KLabel lblNit;
    private KovaqsUI.Controls.KTextBox txtNit;
    private KovaqsUI.Controls.KLabel lblDireccion;
    private KovaqsUI.Controls.KTextBox txtDireccion;
    private KovaqsUI.Controls.KLabel lblTelefono;
    private KovaqsUI.Controls.KTextBox txtTelefono;
    private KovaqsUI.Controls.KLabel lblCorreo;
    private KovaqsUI.Controls.KTextBox txtCorreo;
    private KovaqsUI.Controls.KLabel lblMoneda;
    private KovaqsUI.Controls.KComboBox cboMoneda;
    private KovaqsUI.Controls.KLabel lblZonaHoraria;
    private KovaqsUI.Controls.KComboBox cboZonaHoraria;
    private KovaqsUI.Controls.KButton btnGuardarEmpresa;
    private KovaqsUI.Controls.KLabel lblCatalogos;
    private KovaqsUI.Controls.KButton btnTiposContrato;
    private KovaqsUI.Controls.KButton btnHorarios;
    private KovaqsUI.Controls.KButton btnRoles;
    private KovaqsUI.Controls.KButton btnBitacora;
    private KovaqsUI.Controls.KButton btnConexion;
    private KovaqsUI.Components.KToastNotifier notificador;
}
