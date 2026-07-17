namespace SGAPI
{
    partial class FormReportes
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
            txtFechaReporte = new TextBox();
            btnGenerarReporte = new Button();
            btnMenuPrincipal = new Button();
            btnExportarReporte = new Button();
            txtReporteGenerado = new TextBox();
            panel2 = new Panel();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTituloPrincipal = new Label();
            lblSubtituloPrincipal = new Label();
            label16 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtFechaReporte
            // 
            txtFechaReporte.BackColor = Color.FromArgb(45, 45, 48);
            txtFechaReporte.BorderStyle = BorderStyle.FixedSingle;
            txtFechaReporte.ForeColor = Color.White;
            txtFechaReporte.Location = new Point(11, 312);
            txtFechaReporte.Margin = new Padding(0);
            txtFechaReporte.Name = "txtFechaReporte";
            txtFechaReporte.Size = new Size(167, 23);
            txtFechaReporte.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = SystemColors.Highlight;
            btnGenerarReporte.FlatAppearance.BorderSize = 0;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarReporte.Location = new Point(232, 300);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(186, 43);
            btnGenerarReporte.TabIndex = 1;
            btnGenerarReporte.Text = "Generar";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMenuPrincipal.BackColor = Color.Red;
            btnMenuPrincipal.FlatAppearance.BorderSize = 0;
            btnMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnMenuPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuPrincipal.Location = new Point(1781, 1030);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(128, 35);
            btnMenuPrincipal.TabIndex = 2;
            btnMenuPrincipal.Text = "Regresar al menú principal";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // btnExportarReporte
            // 
            btnExportarReporte.BackColor = SystemColors.Highlight;
            btnExportarReporte.FlatAppearance.BorderSize = 0;
            btnExportarReporte.FlatStyle = FlatStyle.Flat;
            btnExportarReporte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportarReporte.Location = new Point(490, 300);
            btnExportarReporte.Name = "btnExportarReporte";
            btnExportarReporte.Size = new Size(186, 43);
            btnExportarReporte.TabIndex = 3;
            btnExportarReporte.Text = "Exportar";
            btnExportarReporte.UseVisualStyleBackColor = false;
            btnExportarReporte.Click += btnExportarReporte_Click;
            // 
            // txtReporteGenerado
            // 
            txtReporteGenerado.BackColor = Color.FromArgb(30, 30, 30);
            txtReporteGenerado.BorderStyle = BorderStyle.FixedSingle;
            txtReporteGenerado.ForeColor = Color.White;
            txtReporteGenerado.Location = new Point(11, 365);
            txtReporteGenerado.Multiline = true;
            txtReporteGenerado.Name = "txtReporteGenerado";
            txtReporteGenerado.ReadOnly = true;
            txtReporteGenerado.ScrollBars = ScrollBars.Vertical;
            txtReporteGenerado.Size = new Size(1840, 510);
            txtReporteGenerado.TabIndex = 4;
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
            panel2.TabIndex = 31;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(11, 257);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 33;
            label1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(232, 257);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 34;
            label2.Text = "Generar reporte:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(490, 257);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 35;
            label3.Text = "Exportar:";
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.Location = new Point(0, 82);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(378, 37);
            lblTituloPrincipal.TabIndex = 36;
            lblTituloPrincipal.Text = "Pantalla de Reportes diarios\r\n";
            // 
            // lblSubtituloPrincipal
            // 
            lblSubtituloPrincipal.AutoSize = true;
            lblSubtituloPrincipal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtituloPrincipal.ForeColor = SystemColors.ControlDarkDark;
            lblSubtituloPrincipal.Location = new Point(0, 132);
            lblSubtituloPrincipal.Name = "lblSubtituloPrincipal";
            lblSubtituloPrincipal.Size = new Size(211, 20);
            lblSubtituloPrincipal.TabIndex = 37;
            lblSubtituloPrincipal.Text = "Generador de reportes por dia\r\n";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(11, 1014);
            label16.Name = "label16";
            label16.Size = new Size(568, 51);
            label16.TabIndex = 38;
            label16.Text = "SGAPI v1.0.0 | Sistema Generador y Administrador de Pines Informativos\r\n© 2026 Comisaría Vial del Estado de Jalisco | CEIPOL\r\nDesarrollado por Hazael Hervert\r\n";
            // 
            // FormReportes
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            CancelButton = btnMenuPrincipal;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label16);
            Controls.Add(lblSubtituloPrincipal);
            Controls.Add(lblTituloPrincipal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(txtReporteGenerado);
            Controls.Add(btnExportarReporte);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(btnGenerarReporte);
            Controls.Add(txtFechaReporte);
            Font = new Font("Consolas", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReportes";
            WindowState = FormWindowState.Maximized;
            Load += FormReportes_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFechaReporte;
        private Button btnGenerarReporte;
        private Button btnMenuPrincipal;
        private Button btnExportarReporte;
        private TextBox txtReporteGenerado;
        private Panel panel2;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTituloPrincipal;
        private Label lblSubtituloPrincipal;
        private Label label16;
    }
}