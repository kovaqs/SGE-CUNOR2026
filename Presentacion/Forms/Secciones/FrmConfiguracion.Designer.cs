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
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(870, 40);
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
        lblEmpresa.Font = new Font("Inter", 10F, FontStyle.Bold);
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
        lblNombreEmpresa.Name = "lblNombreEmpresa";
        lblNombreEmpresa.Size = new Size(271, 24);
        lblNombreEmpresa.TabIndex = 2;
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
        txtNombreEmpresa.Name = "txtNombreEmpresa";
        txtNombreEmpresa.Size = new Size(271, 34);
        txtNombreEmpresa.TabIndex = 3;
        //
        // lblNit
        //
        lblNit.AutoSize = false;
        lblNit.BackColor = Color.Transparent;
        lblNit.ForeColor = Color.FromArgb(64, 64, 64);
        lblNit.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblNit.TextAlign = ContentAlignment.MiddleLeft;
        lblNit.Text = "NIT";
        lblNit.Location = new Point(305, 98);
        lblNit.Name = "lblNit";
        lblNit.Size = new Size(271, 24);
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
        txtNit.Location = new Point(305, 124);
        txtNit.Name = "txtNit";
        txtNit.Size = new Size(271, 34);
        txtNit.TabIndex = 5;
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
        lblDireccion.Name = "lblDireccion";
        lblDireccion.Size = new Size(271, 24);
        lblDireccion.TabIndex = 6;
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
        txtDireccion.Name = "txtDireccion";
        txtDireccion.Size = new Size(271, 34);
        txtDireccion.TabIndex = 7;
        //
        // lblTelefono
        //
        lblTelefono.AutoSize = false;
        lblTelefono.BackColor = Color.Transparent;
        lblTelefono.ForeColor = Color.FromArgb(64, 64, 64);
        lblTelefono.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
        lblTelefono.Text = "Teléfono";
        lblTelefono.Location = new Point(305, 168);
        lblTelefono.Name = "lblTelefono";
        lblTelefono.Size = new Size(271, 24);
        lblTelefono.TabIndex = 8;
        lblTelefono.TabStop = false;
        //
        // txtTelefono
        //
        txtTelefono.BackColor = Color.Transparent;
        txtTelefono.CornerRadius = 8;
        txtTelefono.Font = new Font("Inter", 9F);
        txtTelefono.Padding = new Padding(10, 6, 10, 6);
        txtTelefono.MaxLength = 25;
        txtTelefono.Location = new Point(305, 194);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(271, 34);
        txtTelefono.TabIndex = 9;
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
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(271, 24);
        lblCorreo.TabIndex = 10;
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
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new Size(271, 34);
        txtCorreo.TabIndex = 11;
        //
        // lblMoneda
        //
        lblMoneda.AutoSize = false;
        lblMoneda.BackColor = Color.Transparent;
        lblMoneda.ForeColor = Color.FromArgb(64, 64, 64);
        lblMoneda.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblMoneda.TextAlign = ContentAlignment.MiddleLeft;
        lblMoneda.Text = "Moneda";
        lblMoneda.Location = new Point(305, 238);
        lblMoneda.Name = "lblMoneda";
        lblMoneda.Size = new Size(271, 24);
        lblMoneda.TabIndex = 12;
        lblMoneda.TabStop = false;
        //
        // cboMoneda
        //
        cboMoneda.Font = new Font("Inter", 9F);
        cboMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
        cboMoneda.FormattingEnabled = true;
        cboMoneda.Items.AddRange(new object[] { "GTQ" });
        cboMoneda.Location = new Point(305, 264);
        cboMoneda.Name = "cboMoneda";
        cboMoneda.Size = new Size(271, 34);
        cboMoneda.TabIndex = 13;
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
        lblZonaHoraria.Name = "lblZonaHoraria";
        lblZonaHoraria.Size = new Size(271, 24);
        lblZonaHoraria.TabIndex = 14;
        lblZonaHoraria.TabStop = false;
        //
        // cboZonaHoraria
        //
        cboZonaHoraria.Font = new Font("Inter", 9F);
        cboZonaHoraria.DropDownStyle = ComboBoxStyle.DropDownList;
        cboZonaHoraria.FormattingEnabled = true;
        cboZonaHoraria.Items.AddRange(new object[] { "America/Guatemala" });
        cboZonaHoraria.Location = new Point(16, 334);
        cboZonaHoraria.Name = "cboZonaHoraria";
        cboZonaHoraria.Size = new Size(271, 34);
        cboZonaHoraria.TabIndex = 15;
        //
        // btnGuardarEmpresa
        //
        btnGuardarEmpresa.BackColor = Color.Transparent;
        btnGuardarEmpresa.CornerRadius = 8;
        btnGuardarEmpresa.FlatStyle = FlatStyle.Flat;
        btnGuardarEmpresa.Font = new Font("Inter", 9F);
        btnGuardarEmpresa.Padding = new Padding(10, 4, 10, 4);
        btnGuardarEmpresa.UseVisualStyleBackColor = false;
        btnGuardarEmpresa.Variant = KovaqsUI.Styling.KButtonVariant.Secondary;
        btnGuardarEmpresa.Text = "Guardar empresa";
        btnGuardarEmpresa.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardarEmpresa.ForeColor = Color.White;
        btnGuardarEmpresa.Appearance.Normal.FillColor = Color.FromArgb(32, 38, 45);
        btnGuardarEmpresa.Appearance.Normal.ForeColor = Color.White;
        btnGuardarEmpresa.Location = new Point(16, 388);
        btnGuardarEmpresa.Name = "btnGuardarEmpresa";
        btnGuardarEmpresa.Size = new Size(200, 40);
        btnGuardarEmpresa.TabIndex = 16;
        //
        // lblCatalogos
        //
        lblCatalogos.AutoSize = false;
        lblCatalogos.BackColor = Color.Transparent;
        lblCatalogos.ForeColor = Color.FromArgb(64, 64, 64);
        lblCatalogos.TextRole = KovaqsUI.Controls.KTextRole.Caption;
        lblCatalogos.TextAlign = ContentAlignment.MiddleLeft;
        lblCatalogos.Text = "Catálogos y administración";
        lblCatalogos.Font = new Font("Inter", 10F, FontStyle.Bold);
        lblCatalogos.Location = new Point(620, 64);
        lblCatalogos.Name = "lblCatalogos";
        lblCatalogos.Size = new Size(266, 26);
        lblCatalogos.TabIndex = 17;
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
        btnTiposContrato.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnTiposContrato.Text = "Tipos de contrato";
        btnTiposContrato.Location = new Point(620, 106);
        btnTiposContrato.Name = "btnTiposContrato";
        btnTiposContrato.Size = new Size(266, 40);
        btnTiposContrato.TabIndex = 18;
        //
        // btnHorarios
        //
        btnHorarios.BackColor = Color.Transparent;
        btnHorarios.CornerRadius = 8;
        btnHorarios.FlatStyle = FlatStyle.Flat;
        btnHorarios.Font = new Font("Inter", 9F);
        btnHorarios.Padding = new Padding(10, 4, 10, 4);
        btnHorarios.UseVisualStyleBackColor = false;
        btnHorarios.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnHorarios.Text = "Horarios";
        btnHorarios.Location = new Point(620, 162);
        btnHorarios.Name = "btnHorarios";
        btnHorarios.Size = new Size(266, 40);
        btnHorarios.TabIndex = 19;
        //
        // btnRoles
        //
        btnRoles.BackColor = Color.Transparent;
        btnRoles.CornerRadius = 8;
        btnRoles.FlatStyle = FlatStyle.Flat;
        btnRoles.Font = new Font("Inter", 9F);
        btnRoles.Padding = new Padding(10, 4, 10, 4);
        btnRoles.UseVisualStyleBackColor = false;
        btnRoles.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnRoles.Text = "Roles y permisos";
        btnRoles.Location = new Point(620, 218);
        btnRoles.Name = "btnRoles";
        btnRoles.Size = new Size(266, 40);
        btnRoles.TabIndex = 20;
        //
        // btnBitacora
        //
        btnBitacora.BackColor = Color.Transparent;
        btnBitacora.CornerRadius = 8;
        btnBitacora.FlatStyle = FlatStyle.Flat;
        btnBitacora.Font = new Font("Inter", 9F);
        btnBitacora.Padding = new Padding(10, 4, 10, 4);
        btnBitacora.UseVisualStyleBackColor = false;
        btnBitacora.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnBitacora.Text = "Bitácora";
        btnBitacora.Location = new Point(620, 274);
        btnBitacora.Name = "btnBitacora";
        btnBitacora.Size = new Size(266, 40);
        btnBitacora.TabIndex = 21;
        //
        // btnConexion
        //
        btnConexion.BackColor = Color.Transparent;
        btnConexion.CornerRadius = 8;
        btnConexion.FlatStyle = FlatStyle.Flat;
        btnConexion.Font = new Font("Inter", 9F);
        btnConexion.Padding = new Padding(10, 4, 10, 4);
        btnConexion.UseVisualStyleBackColor = false;
        btnConexion.Variant = KovaqsUI.Styling.KButtonVariant.Outline;
        btnConexion.Text = "Conexión a MySQL";
        btnConexion.Location = new Point(620, 330);
        btnConexion.Name = "btnConexion";
        btnConexion.Size = new Size(266, 40);
        btnConexion.TabIndex = 22;
        notificador.OwnerForm = this;
        //
        // FrmConfiguracion
        //
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(902, 669);
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
        MinimumSize = new Size(902, 669);
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
