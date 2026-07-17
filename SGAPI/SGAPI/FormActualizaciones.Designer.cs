namespace SGAPI
{
    partial class FormActualizaciones
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
            txtBuscarReporte = new TextBox();
            btnBuscar = new Button();
            txtHoraActualizacion = new TextBox();
            txtDetalle = new TextBox();
            btnAgregarActualizacion = new Button();
            btnAgregarConclusion = new Button();
            lstActualizaciones = new ListBox();
            panel2 = new Panel();
            label9 = new Label();
            label5 = new Label();
            btnMenuPrincipal = new Button();
            label1 = new Label();
            txtPinSeleccionado = new RichTextBox();
            lblSubtituloPrincipal = new Label();
            lblTituloPrincipal = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscarReporte
            // 
            txtBuscarReporte.BackColor = Color.FromArgb(45, 45, 48);
            txtBuscarReporte.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarReporte.ForeColor = Color.White;
            txtBuscarReporte.Location = new Point(14, 281);
            txtBuscarReporte.Margin = new Padding(3, 4, 3, 4);
            txtBuscarReporte.Name = "txtBuscarReporte";
            txtBuscarReporte.Size = new Size(137, 27);
            txtBuscarReporte.TabIndex = 0;
            txtBuscarReporte.TextChanged += txtBuscarReporte_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(167, 281);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtHoraActualizacion
            // 
            txtHoraActualizacion.BackColor = Color.FromArgb(45, 45, 48);
            txtHoraActualizacion.BorderStyle = BorderStyle.FixedSingle;
            txtHoraActualizacion.ForeColor = Color.White;
            txtHoraActualizacion.Location = new Point(1193, 331);
            txtHoraActualizacion.Margin = new Padding(3, 4, 3, 4);
            txtHoraActualizacion.Name = "txtHoraActualizacion";
            txtHoraActualizacion.Size = new Size(243, 27);
            txtHoraActualizacion.TabIndex = 3;
            txtHoraActualizacion.TextChanged += txtHoraActualizacion_TextChanged;
            // 
            // txtDetalle
            // 
            txtDetalle.BackColor = Color.FromArgb(45, 45, 48);
            txtDetalle.BorderStyle = BorderStyle.FixedSingle;
            txtDetalle.ForeColor = Color.White;
            txtDetalle.Location = new Point(1193, 423);
            txtDetalle.Margin = new Padding(3, 4, 3, 4);
            txtDetalle.Multiline = true;
            txtDetalle.Name = "txtDetalle";
            txtDetalle.ScrollBars = ScrollBars.Vertical;
            txtDetalle.Size = new Size(955, 351);
            txtDetalle.TabIndex = 4;
            txtDetalle.TextChanged += txtDetalle_TextChanged;
            // 
            // btnAgregarActualizacion
            // 
            btnAgregarActualizacion.BackColor = SystemColors.Highlight;
            btnAgregarActualizacion.FlatAppearance.BorderSize = 0;
            btnAgregarActualizacion.FlatStyle = FlatStyle.Flat;
            btnAgregarActualizacion.ForeColor = SystemColors.ControlLightLight;
            btnAgregarActualizacion.Location = new Point(1203, 820);
            btnAgregarActualizacion.Margin = new Padding(3, 4, 3, 4);
            btnAgregarActualizacion.Name = "btnAgregarActualizacion";
            btnAgregarActualizacion.Size = new Size(178, 59);
            btnAgregarActualizacion.TabIndex = 5;
            btnAgregarActualizacion.Text = "Agregar Actualizacion";
            btnAgregarActualizacion.UseVisualStyleBackColor = false;
            btnAgregarActualizacion.Click += btnAgregarActualizacion_Click;
            // 
            // btnAgregarConclusion
            // 
            btnAgregarConclusion.BackColor = Color.FromArgb(192, 0, 0);
            btnAgregarConclusion.FlatAppearance.BorderSize = 0;
            btnAgregarConclusion.FlatStyle = FlatStyle.Flat;
            btnAgregarConclusion.ForeColor = SystemColors.ControlLightLight;
            btnAgregarConclusion.Location = new Point(1970, 820);
            btnAgregarConclusion.Margin = new Padding(3, 4, 3, 4);
            btnAgregarConclusion.Name = "btnAgregarConclusion";
            btnAgregarConclusion.Size = new Size(178, 59);
            btnAgregarConclusion.TabIndex = 6;
            btnAgregarConclusion.Text = "Agregar conclusion";
            btnAgregarConclusion.UseVisualStyleBackColor = false;
            btnAgregarConclusion.Click += btnAgregarConclusion_Click;
            // 
            // lstActualizaciones
            // 
            lstActualizaciones.BackColor = Color.FromArgb(45, 45, 48);
            lstActualizaciones.BorderStyle = BorderStyle.FixedSingle;
            lstActualizaciones.ForeColor = Color.White;
            lstActualizaciones.FormattingEnabled = true;
            lstActualizaciones.IntegralHeight = false;
            lstActualizaciones.Location = new Point(1203, 896);
            lstActualizaciones.Margin = new Padding(3, 4, 3, 4);
            lstActualizaciones.Name = "lstActualizaciones";
            lstActualizaciones.Size = new Size(945, 302);
            lstActualizaciones.TabIndex = 7;
            lstActualizaciones.SelectedIndexChanged += lstActualizaciones_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 24, 24);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(2176, 93);
            panel2.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(642, 11);
            label9.Name = "label9";
            label9.Size = new Size(998, 46);
            label9.TabIndex = 0;
            label9.Text = "SGAPI | Sistema Generador y Administrador de Pines Informativos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(14, 1288);
            label5.Name = "label5";
            label5.Size = new Size(484, 60);
            label5.TabIndex = 31;
            label5.Text = "SGAPI v1.0.0 | Sistema Generador y Administrador de Pines Informativos\r\n© 2026 Comisaría Vial del Estado de Jalisco | CEIPOL\r\nDesarrollado por Hazael Hervert\r\n";
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMenuPrincipal.BackColor = Color.Red;
            btnMenuPrincipal.FlatAppearance.BorderSize = 0;
            btnMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnMenuPrincipal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuPrincipal.ForeColor = SystemColors.ControlLightLight;
            btnMenuPrincipal.Location = new Point(2002, 1288);
            btnMenuPrincipal.Margin = new Padding(2, 3, 2, 3);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(146, 47);
            btnMenuPrincipal.TabIndex = 32;
            btnMenuPrincipal.Text = "Regresar al menú principal";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 244);
            label1.Name = "label1";
            label1.Size = new Size(267, 20);
            label1.TabIndex = 33;
            label1.Text = "Numero de reporte del pin a actualizar";
            // 
            // txtPinSeleccionado
            // 
            txtPinSeleccionado.BackColor = Color.FromArgb(45, 45, 48);
            txtPinSeleccionado.BorderStyle = BorderStyle.FixedSingle;
            txtPinSeleccionado.Font = new Font("Segoe UI", 10F);
            txtPinSeleccionado.ForeColor = Color.White;
            txtPinSeleccionado.Location = new Point(14, 331);
            txtPinSeleccionado.Margin = new Padding(3, 4, 3, 4);
            txtPinSeleccionado.Name = "txtPinSeleccionado";
            txtPinSeleccionado.ReadOnly = true;
            txtPinSeleccionado.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtPinSeleccionado.Size = new Size(1156, 867);
            txtPinSeleccionado.TabIndex = 34;
            txtPinSeleccionado.Text = "";
            // 
            // lblSubtituloPrincipal
            // 
            lblSubtituloPrincipal.AutoSize = true;
            lblSubtituloPrincipal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtituloPrincipal.ForeColor = SystemColors.ButtonHighlight;
            lblSubtituloPrincipal.Location = new Point(0, 159);
            lblSubtituloPrincipal.Name = "lblSubtituloPrincipal";
            lblSubtituloPrincipal.Size = new Size(675, 25);
            lblSubtituloPrincipal.TabIndex = 36;
            lblSubtituloPrincipal.Text = "Pantalla para agregar multiples actualizaciones o conclusion a un pin existente\r\n";
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.ForeColor = SystemColors.ButtonHighlight;
            lblTituloPrincipal.Location = new Point(0, 97);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(440, 46);
            lblTituloPrincipal.TabIndex = 35;
            lblTituloPrincipal.Text = "Gestion de actualizaciones\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(1569, 241);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 37;
            label2.Text = "Nueva actualizacion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(1193, 292);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 38;
            label3.Text = "Hora de Actualizacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(1193, 379);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 39;
            label4.Text = "Detalle\r\n";
            // 
            // FormActualizaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            CancelButton = btnMenuPrincipal;
            ClientSize = new Size(2176, 1388);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSubtituloPrincipal);
            Controls.Add(lblTituloPrincipal);
            Controls.Add(txtPinSeleccionado);
            Controls.Add(label1);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(lstActualizaciones);
            Controls.Add(btnAgregarConclusion);
            Controls.Add(btnAgregarActualizacion);
            Controls.Add(txtDetalle);
            Controls.Add(txtHoraActualizacion);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarReporte);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormActualizaciones";
            Text = "FormActualizaciones";
            WindowState = FormWindowState.Maximized;
            Load += FormActualizaciones_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void FormActualizaciones_Load(object sender, EventArgs e)
        {
            txtHoraActualizacion.Text = DateTime.Now.ToString("HH:mm");
        }

        #endregion

        private TextBox txtBuscarReporte;
        private Button btnBuscar;
        private TextBox txtHoraActualizacion;
        private TextBox txtDetalle;
        private Button btnAgregarActualizacion;
        private Button btnAgregarConclusion;
        private ListBox lstActualizaciones;
        private Button btnMenuPrincipal;
        private Label label1;
        private Panel panel2;
        private Label label9;
        private Label label5;
        private RichTextBox txtPinSeleccionado;
        private Label lblSubtituloPrincipal;
        private Label lblTituloPrincipal;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}