namespace Presentacion.Forms.SubForms
{
    partial class FrmExpedientesDatosLaborales
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
            components = new System.ComponentModel.Container();
            notificador = new KovaqsUI.Components.KToastNotifier(components);
            notificador.OwnerForm = this;
            lblFechaContratacion = new KovaqsUI.Controls.KLabel();
            dtpFechaContratacion = new DateTimePicker();
            cboDepartamento = new KovaqsUI.Controls.KComboBox();
            lblDepartamento = new KovaqsUI.Controls.KLabel();
            lblPuesto = new KovaqsUI.Controls.KLabel();
            cboPuesto = new KovaqsUI.Controls.KComboBox();
            lblTipoContrato = new KovaqsUI.Controls.KLabel();
            cboTipoContrato = new KovaqsUI.Controls.KComboBox();
            lblHorario = new KovaqsUI.Controls.KLabel();
            cboHorario = new KovaqsUI.Controls.KComboBox();
            lblSalario = new KovaqsUI.Controls.KLabel();
            numSalario = new KovaqsUI.Controls.KNumericUpDown();
            lblInicioVigencia = new KovaqsUI.Controls.KLabel();
            dtpInicioVigencia = new DateTimePicker();
            txtMotivo = new KovaqsUI.Controls.KTextBox();
            lblMotivo = new KovaqsUI.Controls.KLabel();
            SuspendLayout();
            //
            // lblFechaContratacion
            //
            lblFechaContratacion.AutoSize = false;
            lblFechaContratacion.BackColor = Color.Transparent;
            lblFechaContratacion.ForeColor = Color.FromArgb(64, 64, 64);
            lblFechaContratacion.Location = new Point(16, 16);
            lblFechaContratacion.Font = new Font("Inter", 9F);
            lblFechaContratacion.TabStop = false;
            lblFechaContratacion.Name = "lblFechaContratacion";
            lblFechaContratacion.Size = new Size(423, 24);
            lblFechaContratacion.TabIndex = 0;
            lblFechaContratacion.Text = "Fecha de contratación";
            lblFechaContratacion.TextAlign = ContentAlignment.MiddleLeft;
            lblFechaContratacion.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // dtpFechaContratacion
            //
            dtpFechaContratacion.CalendarFont = new Font("Inter", 9F);
            dtpFechaContratacion.Location = new Point(16, 42);
            dtpFechaContratacion.Font = new Font("Inter", 10F);
            dtpFechaContratacion.Format = DateTimePickerFormat.Custom;
            dtpFechaContratacion.CustomFormat = "dd/MM/yyyy";
            dtpFechaContratacion.MinimumSize = new Size(0, 34);
            dtpFechaContratacion.Name = "dtpFechaContratacion";
            dtpFechaContratacion.Size = new Size(423, 34);
            dtpFechaContratacion.TabIndex = 2;
            //
            // cboDepartamento
            //
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.ItemHeight = 28;
            cboDepartamento.Location = new Point(456, 42);
            cboDepartamento.Font = new Font("Inter", 9F);
            cboDepartamento.CornerRadius = 8;
            cboDepartamento.FillColor = Color.White;
            cboDepartamento.ForeColor = Color.FromArgb(32, 38, 45);
            cboDepartamento.BorderColor = Color.FromArgb(218, 218, 218);
            cboDepartamento.GradientColor = Color.Empty;
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;

            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(423, 34);
            cboDepartamento.TabIndex = 3;
            //
            // lblDepartamento
            //
            lblDepartamento.AutoSize = false;
            lblDepartamento.BackColor = Color.Transparent;
            lblDepartamento.ForeColor = Color.FromArgb(64, 64, 64);
            lblDepartamento.Location = new Point(456, 16);
            lblDepartamento.Font = new Font("Inter", 9F);
            lblDepartamento.TabStop = false;
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new Size(423, 24);
            lblDepartamento.TabIndex = 1;
            lblDepartamento.Text = "Departamento";
            lblDepartamento.TextAlign = ContentAlignment.MiddleLeft;
            lblDepartamento.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // lblPuesto
            //
            lblPuesto.AutoSize = false;
            lblPuesto.BackColor = Color.Transparent;
            lblPuesto.ForeColor = Color.FromArgb(64, 64, 64);
            lblPuesto.Location = new Point(16, 86);
            lblPuesto.Font = new Font("Inter", 9F);
            lblPuesto.TabStop = false;
            lblPuesto.Name = "lblPuesto";
            lblPuesto.Size = new Size(423, 24);
            lblPuesto.TabIndex = 4;
            lblPuesto.Text = "Puesto de trabajo";
            lblPuesto.TextAlign = ContentAlignment.MiddleLeft;
            lblPuesto.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // cboPuesto
            //
            cboPuesto.FormattingEnabled = true;
            cboPuesto.ItemHeight = 28;
            cboPuesto.Location = new Point(16, 112);
            cboPuesto.Font = new Font("Inter", 9F);
            cboPuesto.CornerRadius = 8;
            cboPuesto.FillColor = Color.White;
            cboPuesto.ForeColor = Color.FromArgb(32, 38, 45);
            cboPuesto.BorderColor = Color.FromArgb(218, 218, 218);
            cboPuesto.GradientColor = Color.Empty;
            cboPuesto.DropDownStyle = ComboBoxStyle.DropDownList;

            cboPuesto.Name = "cboPuesto";
            cboPuesto.Size = new Size(423, 34);
            cboPuesto.TabIndex = 6;
            //
            // lblTipoContrato
            //
            lblTipoContrato.AutoSize = false;
            lblTipoContrato.BackColor = Color.Transparent;
            lblTipoContrato.ForeColor = Color.FromArgb(64, 64, 64);
            lblTipoContrato.Location = new Point(456, 86);
            lblTipoContrato.Font = new Font("Inter", 9F);
            lblTipoContrato.TabStop = false;
            lblTipoContrato.Name = "lblTipoContrato";
            lblTipoContrato.Size = new Size(423, 24);
            lblTipoContrato.TabIndex = 5;
            lblTipoContrato.Text = "Tipo de contrato";
            lblTipoContrato.TextAlign = ContentAlignment.MiddleLeft;
            lblTipoContrato.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // cboTipoContrato
            //
            cboTipoContrato.FormattingEnabled = true;
            cboTipoContrato.ItemHeight = 28;
            cboTipoContrato.Location = new Point(456, 112);
            cboTipoContrato.Font = new Font("Inter", 9F);
            cboTipoContrato.CornerRadius = 8;
            cboTipoContrato.FillColor = Color.White;
            cboTipoContrato.ForeColor = Color.FromArgb(32, 38, 45);
            cboTipoContrato.BorderColor = Color.FromArgb(218, 218, 218);
            cboTipoContrato.GradientColor = Color.Empty;
            cboTipoContrato.DropDownStyle = ComboBoxStyle.DropDownList;

            cboTipoContrato.Name = "cboTipoContrato";
            cboTipoContrato.Size = new Size(423, 34);
            cboTipoContrato.TabIndex = 7;
            //
            // lblHorario
            //
            lblHorario.AutoSize = false;
            lblHorario.BackColor = Color.Transparent;
            lblHorario.ForeColor = Color.FromArgb(64, 64, 64);
            lblHorario.Location = new Point(16, 156);
            lblHorario.Font = new Font("Inter", 9F);
            lblHorario.TabStop = false;
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(423, 24);
            lblHorario.TabIndex = 8;
            lblHorario.Text = "Horario";
            lblHorario.TextAlign = ContentAlignment.MiddleLeft;
            lblHorario.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // cboHorario
            //
            cboHorario.FormattingEnabled = true;
            cboHorario.ItemHeight = 28;
            cboHorario.Location = new Point(16, 182);
            cboHorario.Font = new Font("Inter", 9F);
            cboHorario.CornerRadius = 8;
            cboHorario.FillColor = Color.White;
            cboHorario.ForeColor = Color.FromArgb(32, 38, 45);
            cboHorario.BorderColor = Color.FromArgb(218, 218, 218);
            cboHorario.GradientColor = Color.Empty;
            cboHorario.DropDownStyle = ComboBoxStyle.DropDownList;

            cboHorario.Name = "cboHorario";
            cboHorario.Size = new Size(423, 34);
            cboHorario.TabIndex = 10;
            //
            // lblSalario
            //
            lblSalario.AutoSize = false;
            lblSalario.BackColor = Color.Transparent;
            lblSalario.ForeColor = Color.FromArgb(64, 64, 64);
            lblSalario.Location = new Point(456, 156);
            lblSalario.Font = new Font("Inter", 9F);
            lblSalario.TabStop = false;
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(423, 24);
            lblSalario.TabIndex = 9;
            lblSalario.Text = "Salario base (Q)";
            lblSalario.TextAlign = ContentAlignment.MiddleLeft;
            lblSalario.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // numSalario
            //
            numSalario.BackColor = Color.Transparent;
            numSalario.CornerRadius = 8;
            numSalario.FocusAppearance.Inset = 3F;
            numSalario.FocusAppearance.Thickness = 1.5F;
            numSalario.FocusAppearance.Visible = true;
            numSalario.Location = new Point(456, 182);
            numSalario.Font = new Font("Inter", 9F);
            numSalario.ForeColor = Color.FromArgb(64, 64, 64);

            numSalario.Name = "numSalario";
            numSalario.Size = new Size(423, 34);
            numSalario.TabIndex = 11;
            numSalario.Text = "kNumericUpDown1";
            //
            // lblInicioVigencia
            //
            lblInicioVigencia.AutoSize = false;
            lblInicioVigencia.BackColor = Color.Transparent;
            lblInicioVigencia.ForeColor = Color.FromArgb(64, 64, 64);
            lblInicioVigencia.Location = new Point(16, 226);
            lblInicioVigencia.Font = new Font("Inter", 9F);
            lblInicioVigencia.TabStop = false;
            lblInicioVigencia.Name = "lblInicioVigencia";
            lblInicioVigencia.Size = new Size(423, 24);
            lblInicioVigencia.TabIndex = 12;
            lblInicioVigencia.Text = "Inicio de vigencia";
            lblInicioVigencia.TextAlign = ContentAlignment.MiddleLeft;
            lblInicioVigencia.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // dtpInicioVigencia
            //
            dtpInicioVigencia.CalendarFont = new Font("Inter", 9F);
            dtpInicioVigencia.Location = new Point(16, 252);
            dtpInicioVigencia.Font = new Font("Inter", 10F);
            dtpInicioVigencia.Format = DateTimePickerFormat.Custom;
            dtpInicioVigencia.CustomFormat = "dd/MM/yyyy";
            dtpInicioVigencia.MinimumSize = new Size(0, 34);
            dtpInicioVigencia.Name = "dtpInicioVigencia";
            dtpInicioVigencia.Size = new Size(423, 34);
            dtpInicioVigencia.TabIndex = 14;
            //
            // txtMotivo
            //
            txtMotivo.BackColor = Color.Transparent;
            txtMotivo.Location = new Point(456, 252);
            txtMotivo.Font = new Font("Inter", 9F);
            txtMotivo.CornerRadius = 8;
            txtMotivo.FillColor = Color.White;
            txtMotivo.ForeColor = Color.FromArgb(32, 38, 45);
            txtMotivo.BorderColor = Color.FromArgb(218, 218, 218);
            txtMotivo.GradientColor = Color.Empty;
            txtMotivo.BorderThickness = 1;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Padding = new Padding(12, 8, 12, 8);
            txtMotivo.PlaceholderText = "Ingreso inicial / motivo del cambio";
            txtMotivo.Size = new Size(423, 80);
            txtMotivo.TabIndex = 15;
            //
            // lblMotivo
            //
            lblMotivo.AutoSize = false;
            lblMotivo.BackColor = Color.Transparent;
            lblMotivo.ForeColor = Color.FromArgb(64, 64, 64);
            lblMotivo.Location = new Point(456, 226);
            lblMotivo.Font = new Font("Inter", 9F);
            lblMotivo.TabStop = false;
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(423, 24);
            lblMotivo.TabIndex = 13;
            lblMotivo.Text = "Motivo de la condición laboral";
            lblMotivo.TextAlign = ContentAlignment.MiddleLeft;
            lblMotivo.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // FrmExpedientesDatosLaborales
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 450);
            Controls.Add(lblMotivo);
            Controls.Add(txtMotivo);
            Controls.Add(lblInicioVigencia);
            Controls.Add(dtpInicioVigencia);
            Controls.Add(numSalario);
            Controls.Add(lblSalario);
            Controls.Add(lblHorario);
            Controls.Add(cboHorario);
            Controls.Add(lblTipoContrato);
            Controls.Add(cboTipoContrato);
            Controls.Add(lblPuesto);
            Controls.Add(cboPuesto);
            Controls.Add(lblDepartamento);
            Controls.Add(cboDepartamento);
            Controls.Add(lblFechaContratacion);
            Controls.Add(dtpFechaContratacion);
            FormBorderStyle = FormBorderStyle.None;
            Font = new Font("Segoe UI", 9F);
            Icon = Properties.Resources.sgeicon;
            Name = "FrmExpedientesDatosLaborales";
            Text = "FrmExpedientesDatosLaborales";
            ResumeLayout(false);
        }

        #endregion
        private KovaqsUI.Controls.KLabel lblFechaContratacion;
        private DateTimePicker dtpFechaContratacion;
        private KovaqsUI.Controls.KComboBox cboDepartamento;
        private KovaqsUI.Controls.KLabel lblDepartamento;
        private KovaqsUI.Controls.KLabel lblPuesto;
        private KovaqsUI.Controls.KComboBox cboPuesto;
        private KovaqsUI.Controls.KLabel lblTipoContrato;
        private KovaqsUI.Controls.KComboBox cboTipoContrato;
        private KovaqsUI.Controls.KLabel lblHorario;
        private KovaqsUI.Controls.KComboBox cboHorario;
        private KovaqsUI.Controls.KLabel lblSalario;
        private KovaqsUI.Controls.KNumericUpDown numSalario;
        private KovaqsUI.Controls.KLabel lblInicioVigencia;
        private DateTimePicker dtpInicioVigencia;
        private KovaqsUI.Controls.KTextBox txtMotivo;
        private KovaqsUI.Controls.KLabel lblMotivo;
        private KovaqsUI.Components.KToastNotifier notificador;
    }
}
