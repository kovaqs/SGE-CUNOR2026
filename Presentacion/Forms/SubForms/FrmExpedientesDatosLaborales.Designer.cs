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
            kLabel5 = new KovaqsUI.Controls.KLabel();
            dtpFechaContratacion = new DateTimePicker();
            cboDepartamento = new KovaqsUI.Controls.KComboBox();
            kLabel1 = new KovaqsUI.Controls.KLabel();
            kLabel2 = new KovaqsUI.Controls.KLabel();
            cboPuesto = new KovaqsUI.Controls.KComboBox();
            kLabel3 = new KovaqsUI.Controls.KLabel();
            cboTipoContrato = new KovaqsUI.Controls.KComboBox();
            kLabel4 = new KovaqsUI.Controls.KLabel();
            cboHorario = new KovaqsUI.Controls.KComboBox();
            kLabel6 = new KovaqsUI.Controls.KLabel();
            numSalario = new KovaqsUI.Controls.KNumericUpDown();
            kLabel7 = new KovaqsUI.Controls.KLabel();
            dtpInicioVigencia = new DateTimePicker();
            txtMotivo = new KovaqsUI.Controls.KTextBox();
            kLabel8 = new KovaqsUI.Controls.KLabel();
            SuspendLayout();
            //
            // kLabel5
            //
            kLabel5.AutoSize = false;
            kLabel5.BackColor = Color.Transparent;
            kLabel5.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel5.Location = new Point(16, 16);
            kLabel5.Font = new Font("Inter", 9F);
            kLabel5.TabStop = false;
            kLabel5.Name = "kLabel5";
            kLabel5.Size = new Size(423, 24);
            kLabel5.TabIndex = 0;
            kLabel5.Text = "Fecha de contratación";
            kLabel5.TextAlign = ContentAlignment.MiddleLeft;
            kLabel5.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
            // kLabel1
            //
            kLabel1.AutoSize = false;
            kLabel1.BackColor = Color.Transparent;
            kLabel1.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel1.Location = new Point(456, 16);
            kLabel1.Font = new Font("Inter", 9F);
            kLabel1.TabStop = false;
            kLabel1.Name = "kLabel1";
            kLabel1.Size = new Size(423, 24);
            kLabel1.TabIndex = 1;
            kLabel1.Text = "Departamento";
            kLabel1.TextAlign = ContentAlignment.MiddleLeft;
            kLabel1.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // kLabel2
            //
            kLabel2.AutoSize = false;
            kLabel2.BackColor = Color.Transparent;
            kLabel2.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel2.Location = new Point(16, 86);
            kLabel2.Font = new Font("Inter", 9F);
            kLabel2.TabStop = false;
            kLabel2.Name = "kLabel2";
            kLabel2.Size = new Size(423, 24);
            kLabel2.TabIndex = 4;
            kLabel2.Text = "Puesto de trabajo";
            kLabel2.TextAlign = ContentAlignment.MiddleLeft;
            kLabel2.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
            // kLabel3
            //
            kLabel3.AutoSize = false;
            kLabel3.BackColor = Color.Transparent;
            kLabel3.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel3.Location = new Point(456, 86);
            kLabel3.Font = new Font("Inter", 9F);
            kLabel3.TabStop = false;
            kLabel3.Name = "kLabel3";
            kLabel3.Size = new Size(423, 24);
            kLabel3.TabIndex = 5;
            kLabel3.Text = "Tipo de contrato";
            kLabel3.TextAlign = ContentAlignment.MiddleLeft;
            kLabel3.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
            // kLabel4
            //
            kLabel4.AutoSize = false;
            kLabel4.BackColor = Color.Transparent;
            kLabel4.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel4.Location = new Point(16, 156);
            kLabel4.Font = new Font("Inter", 9F);
            kLabel4.TabStop = false;
            kLabel4.Name = "kLabel4";
            kLabel4.Size = new Size(423, 24);
            kLabel4.TabIndex = 8;
            kLabel4.Text = "Horario";
            kLabel4.TextAlign = ContentAlignment.MiddleLeft;
            kLabel4.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
            // kLabel6
            //
            kLabel6.AutoSize = false;
            kLabel6.BackColor = Color.Transparent;
            kLabel6.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel6.Location = new Point(456, 156);
            kLabel6.Font = new Font("Inter", 9F);
            kLabel6.TabStop = false;
            kLabel6.Name = "kLabel6";
            kLabel6.Size = new Size(423, 24);
            kLabel6.TabIndex = 9;
            kLabel6.Text = "Salario base (Q)";
            kLabel6.TextAlign = ContentAlignment.MiddleLeft;
            kLabel6.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
            // kLabel7
            //
            kLabel7.AutoSize = false;
            kLabel7.BackColor = Color.Transparent;
            kLabel7.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel7.Location = new Point(16, 226);
            kLabel7.Font = new Font("Inter", 9F);
            kLabel7.TabStop = false;
            kLabel7.Name = "kLabel7";
            kLabel7.Size = new Size(423, 24);
            kLabel7.TabIndex = 12;
            kLabel7.Text = "Inicio de vigencia";
            kLabel7.TextAlign = ContentAlignment.MiddleLeft;
            kLabel7.TextRole = KovaqsUI.Controls.KTextRole.Caption;
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
            // kLabel8
            //
            kLabel8.AutoSize = false;
            kLabel8.BackColor = Color.Transparent;
            kLabel8.ForeColor = Color.FromArgb(64, 64, 64);
            kLabel8.Location = new Point(456, 226);
            kLabel8.Font = new Font("Inter", 9F);
            kLabel8.TabStop = false;
            kLabel8.Name = "kLabel8";
            kLabel8.Size = new Size(423, 24);
            kLabel8.TabIndex = 13;
            kLabel8.Text = "Motivo de la condición laboral";
            kLabel8.TextAlign = ContentAlignment.MiddleLeft;
            kLabel8.TextRole = KovaqsUI.Controls.KTextRole.Caption;
            //
            // FrmExpedientesDatosLaborales
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 450);
            Controls.Add(kLabel8);
            Controls.Add(txtMotivo);
            Controls.Add(kLabel7);
            Controls.Add(dtpInicioVigencia);
            Controls.Add(numSalario);
            Controls.Add(kLabel6);
            Controls.Add(kLabel4);
            Controls.Add(cboHorario);
            Controls.Add(kLabel3);
            Controls.Add(cboTipoContrato);
            Controls.Add(kLabel2);
            Controls.Add(cboPuesto);
            Controls.Add(kLabel1);
            Controls.Add(cboDepartamento);
            Controls.Add(kLabel5);
            Controls.Add(dtpFechaContratacion);
            FormBorderStyle = FormBorderStyle.None;
            Font = new Font("Segoe UI", 9F);
            Name = "FrmExpedientesDatosLaborales";
            Text = "FrmExpedientesDatosLaborales";
            ResumeLayout(false);
        }

        #endregion
        private KovaqsUI.Controls.KLabel kLabel5;
        private DateTimePicker dtpFechaContratacion;
        private KovaqsUI.Controls.KComboBox cboDepartamento;
        private KovaqsUI.Controls.KLabel kLabel1;
        private KovaqsUI.Controls.KLabel kLabel2;
        private KovaqsUI.Controls.KComboBox cboPuesto;
        private KovaqsUI.Controls.KLabel kLabel3;
        private KovaqsUI.Controls.KComboBox cboTipoContrato;
        private KovaqsUI.Controls.KLabel kLabel4;
        private KovaqsUI.Controls.KComboBox cboHorario;
        private KovaqsUI.Controls.KLabel kLabel6;
        private KovaqsUI.Controls.KNumericUpDown numSalario;
        private KovaqsUI.Controls.KLabel kLabel7;
        private DateTimePicker dtpInicioVigencia;
        private KovaqsUI.Controls.KTextBox txtMotivo;
        private KovaqsUI.Controls.KLabel kLabel8;
    }
}
