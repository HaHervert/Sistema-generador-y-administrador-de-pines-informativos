namespace SGAPI
{
    partial class FormVistaPrevia
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
            label2 = new Label();
            label3 = new Label();
            txtVistaPrevia = new TextBox();
            panel1 = new Panel();
            btnExportarPDF = new Button();
            btnRegresarEdicion = new Button();
            btnExportar = new Button();
            btnCopiar = new Button();
            label4 = new Label();
            btnMenuPrincipal = new Button();
            panel2 = new Panel();
            label15 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 118);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 37);
            label1.TabIndex = 0;
            label1.Text = "Vista previa del pin final";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 155);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(342, 19);
            label2.TabIndex = 1;
            label2.Text = "Salida de texto lista para copiar, compartir o almacenar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 241);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(156, 19);
            label3.TabIndex = 2;
            label3.Text = "Vista previa generada";
            // 
            // txtVistaPrevia
            // 
            txtVistaPrevia.AcceptsReturn = true;
            txtVistaPrevia.AcceptsTab = true;
            txtVistaPrevia.BackColor = Color.FromArgb(45, 45, 48);
            txtVistaPrevia.BorderStyle = BorderStyle.FixedSingle;
            txtVistaPrevia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVistaPrevia.ForeColor = Color.White;
            txtVistaPrevia.Location = new Point(11, 223);
            txtVistaPrevia.Margin = new Padding(2);
            txtVistaPrevia.Multiline = true;
            txtVistaPrevia.Name = "txtVistaPrevia";
            txtVistaPrevia.ReadOnly = true;
            txtVistaPrevia.ScrollBars = ScrollBars.Vertical;
            txtVistaPrevia.Size = new Size(986, 747);
            txtVistaPrevia.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnExportarPDF);
            panel1.Controls.Add(btnRegresarEdicion);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(btnCopiar);
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            panel1.Location = new Point(1028, 252);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 327);
            panel1.TabIndex = 5;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = Color.FromArgb(0, 120, 215);
            btnExportarPDF.FlatAppearance.BorderSize = 0;
            btnExportarPDF.FlatStyle = FlatStyle.Flat;
            btnExportarPDF.ForeColor = Color.White;
            btnExportarPDF.Location = new Point(14, 178);
            btnExportarPDF.Margin = new Padding(2);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(500, 34);
            btnExportarPDF.TabIndex = 34;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            btnExportarPDF.Click += btnExportarPDF_Click_1;
            // 
            // btnRegresarEdicion
            // 
            btnRegresarEdicion.BackColor = Color.FromArgb(0, 120, 215);
            btnRegresarEdicion.FlatAppearance.BorderSize = 0;
            btnRegresarEdicion.FlatStyle = FlatStyle.Flat;
            btnRegresarEdicion.ForeColor = Color.White;
            btnRegresarEdicion.Location = new Point(14, 250);
            btnRegresarEdicion.Margin = new Padding(2);
            btnRegresarEdicion.Name = "btnRegresarEdicion";
            btnRegresarEdicion.Size = new Size(500, 34);
            btnRegresarEdicion.TabIndex = 8;
            btnRegresarEdicion.Text = "Regresar a edicion";
            btnRegresarEdicion.UseVisualStyleBackColor = false;
            btnRegresarEdicion.Click += btnRegresarEdicion_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.FromArgb(0, 120, 215);
            btnExportar.FlatAppearance.BorderSize = 0;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.ForeColor = Color.White;
            btnExportar.Location = new Point(14, 103);
            btnExportar.Margin = new Padding(2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(500, 34);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "Exportar .Text";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.BackColor = Color.FromArgb(0, 120, 215);
            btnCopiar.FlatAppearance.BorderSize = 0;
            btnCopiar.FlatStyle = FlatStyle.Flat;
            btnCopiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiar.ForeColor = Color.White;
            btnCopiar.Location = new Point(14, 26);
            btnCopiar.Margin = new Padding(2);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(500, 34);
            btnCopiar.TabIndex = 5;
            btnCopiar.Text = "Copiar al portapapeles";
            btnCopiar.UseVisualStyleBackColor = false;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1028, 223);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 6;
            label4.Text = "Opciones";
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
            panel2.Controls.Add(label15);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1920, 70);
            panel2.TabIndex = 32;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(562, 8);
            label15.Name = "label15";
            label15.Size = new Size(791, 37);
            label15.TabIndex = 0;
            label15.Text = "SGAPI | Sistema Generador y Administrador de Pines Informativos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 1014);
            label10.Name = "label10";
            label10.Size = new Size(453, 57);
            label10.TabIndex = 33;
            label10.Text = "SGAPI v1.0.0 | Sistema Generador y Administrador de Pines Informativos\r\n© 2026 Comisaría Vial del Estado de Jalisco | CEIPOL\r\nDesarrollado por Hazael Hervert\r\n";
            // 
            // FormVistaPrevia
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1920, 1061);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(txtVistaPrevia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormVistaPrevia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormVistaPrevia";
            WindowState = FormWindowState.Maximized;
            Load += FormVistaPrevia_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtVistaPrevia;
        private Panel panel1;
        private Button btnRegresarEdicion;
        private Button btnExportar;
        private Button btnCopiar;
        private Label label4;
        private Button btnMenuPrincipal;
        private Panel panel2;
        private Label label15;
        private Label label10;
        private Button btnExportarPDF;
    }
}