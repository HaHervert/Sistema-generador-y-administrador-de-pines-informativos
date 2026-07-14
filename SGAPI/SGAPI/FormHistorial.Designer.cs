namespace SGAPI
{
    partial class FormHistorial
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
            label1 = new Label();
            txtFecha = new TextBox();
            txtReporte = new TextBox();
            txtMunicipio = new TextBox();
            cboEstadoFiltro = new ComboBox();
            btnBuscarHistorial = new Button();
            dgvHistorial = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnMenuPrincipal = new Button();
            panel2 = new Panel();
            label9 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 0;
            label1.Text = "Consulta e historial";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.FromArgb(45, 45, 48);
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.ForeColor = Color.White;
            txtFecha.Location = new Point(11, 241);
            txtFecha.Margin = new Padding(2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(200, 25);
            txtFecha.TabIndex = 1;
            // 
            // txtReporte
            // 
            txtReporte.BackColor = Color.FromArgb(45, 45, 48);
            txtReporte.BorderStyle = BorderStyle.FixedSingle;
            txtReporte.ForeColor = Color.White;
            txtReporte.Location = new Point(273, 241);
            txtReporte.Margin = new Padding(2);
            txtReporte.Name = "txtReporte";
            txtReporte.Size = new Size(200, 25);
            txtReporte.TabIndex = 2;
            // 
            // txtMunicipio
            // 
            txtMunicipio.BackColor = Color.FromArgb(45, 45, 48);
            txtMunicipio.BorderStyle = BorderStyle.FixedSingle;
            txtMunicipio.ForeColor = Color.White;
            txtMunicipio.Location = new Point(533, 241);
            txtMunicipio.Margin = new Padding(2);
            txtMunicipio.Name = "txtMunicipio";
            txtMunicipio.Size = new Size(200, 25);
            txtMunicipio.TabIndex = 3;
            // 
            // cboEstadoFiltro
            // 
            cboEstadoFiltro.BackColor = Color.FromArgb(45, 45, 48);
            cboEstadoFiltro.FlatStyle = FlatStyle.Flat;
            cboEstadoFiltro.ForeColor = Color.White;
            cboEstadoFiltro.FormattingEnabled = true;
            cboEstadoFiltro.Location = new Point(783, 241);
            cboEstadoFiltro.Margin = new Padding(0);
            cboEstadoFiltro.Name = "cboEstadoFiltro";
            cboEstadoFiltro.Size = new Size(200, 25);
            cboEstadoFiltro.TabIndex = 4;
            // 
            // btnBuscarHistorial
            // 
            btnBuscarHistorial.BackColor = Color.FromArgb(0, 120, 215);
            btnBuscarHistorial.FlatAppearance.BorderSize = 0;
            btnBuscarHistorial.FlatStyle = FlatStyle.Flat;
            btnBuscarHistorial.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarHistorial.ForeColor = Color.White;
            btnBuscarHistorial.Location = new Point(1023, 233);
            btnBuscarHistorial.Margin = new Padding(2);
            btnBuscarHistorial.Name = "btnBuscarHistorial";
            btnBuscarHistorial.Size = new Size(200, 34);
            btnBuscarHistorial.TabIndex = 5;
            btnBuscarHistorial.Text = "Buscar";
            btnBuscarHistorial.UseVisualStyleBackColor = false;
            btnBuscarHistorial.Click += btnBuscarHistorial_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(8, 301);
            dgvHistorial.Margin = new Padding(2);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 62;
            dgvHistorial.Size = new Size(1848, 643);
            dgvHistorial.TabIndex = 6;
            dgvHistorial.CellDoubleClick += dgvHistorial_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1, 124);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(360, 19);
            label2.TabIndex = 7;
            label2.Text = "Busqueda de pines por fecha, reporte, municipio o estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 208);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 19);
            label3.TabIndex = 8;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 208);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 19);
            label4.TabIndex = 9;
            label4.Text = "Reporte";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(533, 208);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 10;
            label5.Text = "Municipio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(783, 208);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 19);
            label6.TabIndex = 11;
            label6.Text = "Estado del reporte";
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMenuPrincipal.BackColor = Color.Red;
            btnMenuPrincipal.FlatAppearance.BorderSize = 0;
            btnMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnMenuPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuPrincipal.ForeColor = SystemColors.ControlLightLight;
            btnMenuPrincipal.Location = new Point(1765, 991);
            btnMenuPrincipal.Margin = new Padding(2);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(128, 35);
            btnMenuPrincipal.TabIndex = 27;
            btnMenuPrincipal.Text = "Regresar al menú principal";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 24, 24);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1920, 70);
            panel2.TabIndex = 30;
            panel2.Paint += panel2_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(562, 8);
            label9.Name = "label9";
            label9.Size = new Size(791, 37);
            label9.TabIndex = 0;
            label9.Text = "SGAPI | Sistema Generador y Administrador de Pines Informativos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 1014);
            label7.Name = "label7";
            label7.Size = new Size(453, 57);
            label7.TabIndex = 31;
            label7.Text = "SGAPI v1.0.0 | Sistema Generador y Administrador de Pines Informativos\r\n© 2026 Comisaría Vial del Estado de Jalisco | CEIPOL\r\nDesarrollado por Hazael Hervert\r\n";
            // 
            // FormHistorial
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            CancelButton = btnMenuPrincipal;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvHistorial);
            Controls.Add(btnBuscarHistorial);
            Controls.Add(cboEstadoFiltro);
            Controls.Add(txtMunicipio);
            Controls.Add(txtReporte);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormHistorial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHistorial";
            WindowState = FormWindowState.Maximized;
            Load += FormHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFecha;
        private TextBox txtReporte;
        private TextBox txtMunicipio;
        private ComboBox cboEstadoFiltro;
        private Button btnBuscarHistorial;
        private DataGridView dgvHistorial;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnMenuPrincipal;
        private Panel panel2;
        private Label label9;
        private Label label7;
    }
}