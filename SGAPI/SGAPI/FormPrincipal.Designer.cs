namespace SGAPI
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            lblTituloPrincipal = new Label();
            lblSubtituloPrincipal = new Label();
            panelResumen = new Panel();
            panelAccesos = new Panel();
            btnReportes = new Button();
            btnHistorial = new Button();
            btnActualizarPin = new Button();
            btnNuevoPin = new Button();
            label5 = new Label();
            lblEstadoHoy = new Label();
            panelEstadoHoy = new PictureBox();
            panelPinesHoy = new Panel();
            lblPinesHoy = new Label();
            label4 = new Label();
            lblUsuario = new Label();
            label2 = new Label();
            label1 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            panelActividad = new Panel();
            lstActividad = new ListBox();
            label6 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            label7 = new Label();
            btnRestaurarBackup = new Button();
            label3 = new Label();
            lblBackup = new Label();
            panelResumen.SuspendLayout();
            panelAccesos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelEstadoHoy).BeginInit();
            panelPinesHoy.SuspendLayout();
            panelActividad.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.Location = new Point(12, 111);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(480, 37);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Pantalla principal / Panel de Control";
            // 
            // lblSubtituloPrincipal
            // 
            lblSubtituloPrincipal.AutoSize = true;
            lblSubtituloPrincipal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtituloPrincipal.ForeColor = SystemColors.ControlLightLight;
            lblSubtituloPrincipal.Location = new Point(12, 165);
            lblSubtituloPrincipal.Name = "lblSubtituloPrincipal";
            lblSubtituloPrincipal.Size = new Size(360, 20);
            lblSubtituloPrincipal.TabIndex = 1;
            lblSubtituloPrincipal.Text = "Acceso rápido a las funciones principales del sistema";
            // 
            // panelResumen
            // 
            panelResumen.BorderStyle = BorderStyle.FixedSingle;
            panelResumen.Controls.Add(panelAccesos);
            panelResumen.Controls.Add(lblEstadoHoy);
            panelResumen.Controls.Add(panelEstadoHoy);
            panelResumen.Controls.Add(panelPinesHoy);
            panelResumen.Controls.Add(lblUsuario);
            panelResumen.Controls.Add(label2);
            panelResumen.Controls.Add(label1);
            panelResumen.Location = new Point(26, 280);
            panelResumen.Name = "panelResumen";
            panelResumen.Size = new Size(1175, 643);
            panelResumen.TabIndex = 2;
            // 
            // panelAccesos
            // 
            panelAccesos.BorderStyle = BorderStyle.FixedSingle;
            panelAccesos.Controls.Add(btnReportes);
            panelAccesos.Controls.Add(btnHistorial);
            panelAccesos.Controls.Add(btnActualizarPin);
            panelAccesos.Controls.Add(btnNuevoPin);
            panelAccesos.Controls.Add(label5);
            panelAccesos.Location = new Point(14, 381);
            panelAccesos.Name = "panelAccesos";
            panelAccesos.Size = new Size(1131, 231);
            panelAccesos.TabIndex = 6;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(0, 120, 215);
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Location = new Point(841, 111);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(232, 66);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.BackColor = Color.FromArgb(0, 120, 215);
            btnHistorial.FlatAppearance.BorderSize = 0;
            btnHistorial.FlatStyle = FlatStyle.Flat;
            btnHistorial.Location = new Point(573, 111);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(232, 66);
            btnHistorial.TabIndex = 3;
            btnHistorial.Text = "Historial";
            btnHistorial.UseVisualStyleBackColor = false;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // btnActualizarPin
            // 
            btnActualizarPin.BackColor = Color.FromArgb(0, 120, 215);
            btnActualizarPin.FlatAppearance.BorderSize = 0;
            btnActualizarPin.FlatStyle = FlatStyle.Flat;
            btnActualizarPin.Location = new Point(288, 111);
            btnActualizarPin.Name = "btnActualizarPin";
            btnActualizarPin.Size = new Size(232, 66);
            btnActualizarPin.TabIndex = 2;
            btnActualizarPin.Text = "Actualizar pin";
            btnActualizarPin.UseVisualStyleBackColor = false;
            btnActualizarPin.Click += btnActualizarPin_Click;
            // 
            // btnNuevoPin
            // 
            btnNuevoPin.BackColor = Color.FromArgb(0, 120, 215);
            btnNuevoPin.FlatAppearance.BorderSize = 0;
            btnNuevoPin.FlatStyle = FlatStyle.Flat;
            btnNuevoPin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoPin.Location = new Point(26, 111);
            btnNuevoPin.Name = "btnNuevoPin";
            btnNuevoPin.Size = new Size(232, 66);
            btnNuevoPin.TabIndex = 1;
            btnNuevoPin.Text = "Nuevo pin";
            btnNuevoPin.UseVisualStyleBackColor = false;
            btnNuevoPin.Click += btnNuevoPin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 26);
            label5.Name = "label5";
            label5.Size = new Size(222, 37);
            label5.TabIndex = 0;
            label5.Text = "Accesos rápidos";
            // 
            // lblEstadoHoy
            // 
            lblEstadoHoy.AutoSize = true;
            lblEstadoHoy.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoHoy.Location = new Point(675, 109);
            lblEstadoHoy.Name = "lblEstadoHoy";
            lblEstadoHoy.Size = new Size(374, 225);
            lblEstadoHoy.TabIndex = 5;
            lblEstadoHoy.Text = "-----------Estado de Pines de hoy----------\r\n\r\nPreliminares: \r\n\r\nEn actualización: \r\n\r\nConcluidos: \r\n\r\nInformativos: ";
            lblEstadoHoy.Click += lblEstadoHoy_Click;
            // 
            // panelEstadoHoy
            // 
            panelEstadoHoy.BorderStyle = BorderStyle.FixedSingle;
            panelEstadoHoy.Location = new Point(621, 100);
            panelEstadoHoy.Name = "panelEstadoHoy";
            panelEstadoHoy.Size = new Size(524, 257);
            panelEstadoHoy.TabIndex = 4;
            panelEstadoHoy.TabStop = false;
            panelEstadoHoy.Click += panelEstadoHoy_Click;
            // 
            // panelPinesHoy
            // 
            panelPinesHoy.BorderStyle = BorderStyle.FixedSingle;
            panelPinesHoy.Controls.Add(lblPinesHoy);
            panelPinesHoy.Controls.Add(label4);
            panelPinesHoy.Location = new Point(14, 159);
            panelPinesHoy.Name = "panelPinesHoy";
            panelPinesHoy.Size = new Size(554, 204);
            panelPinesHoy.TabIndex = 3;
            // 
            // lblPinesHoy
            // 
            lblPinesHoy.AutoSize = true;
            lblPinesHoy.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPinesHoy.Location = new Point(26, 67);
            lblPinesHoy.Name = "lblPinesHoy";
            lblPinesHoy.Size = new Size(44, 51);
            lblPinesHoy.TabIndex = 1;
            lblPinesHoy.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(3, 10);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 0;
            label4.Text = "Pines generados hoy";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(976, 31);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 19);
            lblUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 52);
            label2.Name = "label2";
            label2.Size = new Size(223, 19);
            label2.TabIndex = 1;
            label2.Text = "Comisaría Vial del Estado de Jalisco";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(310, 19);
            label1.TabIndex = 0;
            label1.Text = "Sistema Generador y Administrador de Pines";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // panelActividad
            // 
            panelActividad.BorderStyle = BorderStyle.FixedSingle;
            panelActividad.Controls.Add(lstActividad);
            panelActividad.Controls.Add(label6);
            panelActividad.Location = new Point(1220, 280);
            panelActividad.Name = "panelActividad";
            panelActividad.Size = new Size(625, 643);
            panelActividad.TabIndex = 3;
            // 
            // lstActividad
            // 
            lstActividad.BackColor = Color.FromArgb(45, 45, 48);
            lstActividad.BorderStyle = BorderStyle.FixedSingle;
            lstActividad.ForeColor = Color.White;
            lstActividad.FormattingEnabled = true;
            lstActividad.Location = new Point(16, 70);
            lstActividad.Name = "lstActividad";
            lstActividad.Size = new Size(586, 529);
            lstActividad.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(16, 31);
            label6.Name = "label6";
            label6.Size = new Size(131, 19);
            label6.TabIndex = 0;
            label6.Text = "Actividad reciente";
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
            label7.Location = new Point(26, 1014);
            label7.Name = "label7";
            label7.Size = new Size(453, 57);
            label7.TabIndex = 31;
            label7.Text = "SGAPI v1.0.0 | Sistema Generador y Administrador de Pines Informativos\r\n© 2026 Comisaría Vial del Estado de Jalisco | CEIPOL\r\nDesarrollado por Hazael Hervert\r\n";
            // 
            // btnRestaurarBackup
            // 
            btnRestaurarBackup.BackColor = Color.Red;
            btnRestaurarBackup.FlatAppearance.BorderSize = 0;
            btnRestaurarBackup.FlatStyle = FlatStyle.Flat;
            btnRestaurarBackup.Location = new Point(1718, 1014);
            btnRestaurarBackup.Name = "btnRestaurarBackup";
            btnRestaurarBackup.Size = new Size(139, 33);
            btnRestaurarBackup.TabIndex = 32;
            btnRestaurarBackup.Text = "Respaldos";
            btnRestaurarBackup.UseVisualStyleBackColor = false;
            btnRestaurarBackup.Click += btnRestaurarBackup_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(1679, 939);
            label3.Name = "label3";
            label3.Size = new Size(229, 57);
            label3.TabIndex = 33;
            label3.Text = "Use solo en caso de emergencia,\r\nson copias de seguridad si se perdio\r\ninformacion por algun accidente.";
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.Location = new Point(1578, 73);
            lblBackup.Name = "lblBackup";
            lblBackup.Size = new Size(131, 19);
            lblBackup.TabIndex = 34;
            lblBackup.Text = "Último respaldo: ---";
            // 
            // FormPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1920, 1080);
            Controls.Add(lblBackup);
            Controls.Add(label3);
            Controls.Add(btnRestaurarBackup);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panelActividad);
            Controls.Add(panelResumen);
            Controls.Add(lblSubtituloPrincipal);
            Controls.Add(lblTituloPrincipal);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGAPI - Panel principal";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            panelResumen.ResumeLayout(false);
            panelResumen.PerformLayout();
            panelAccesos.ResumeLayout(false);
            panelAccesos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelEstadoHoy).EndInit();
            panelPinesHoy.ResumeLayout(false);
            panelPinesHoy.PerformLayout();
            panelActividad.ResumeLayout(false);
            panelActividad.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPrincipal;
        private Label lblSubtituloPrincipal;
        private Panel panelResumen;
        private Label label2;
        private Label label1;
        private Panel panelPinesHoy;
        private Label lblPinesHoy;
        private Label label4;
        private Label lblUsuario;
        private Panel panelAccesos;
        private Label label5;
        private Label lblEstadoHoy;
        private PictureBox panelEstadoHoy;
        private Button btnReportes;
        private Button btnHistorial;
        private Button btnActualizarPin;
        private Button btnNuevoPin;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panelActividad;
        private ListBox lstActividad;
        private Label label6;
        private Panel panel2;
        private Label label9;
        private Label label7;
        private Button btnRestaurarBackup;
        private Label label3;
        private Label lblBackup;
    }
}