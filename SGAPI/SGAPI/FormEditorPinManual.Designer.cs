namespace SGAPI
{
    partial class FormEditorPinManual
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
            txtEditorPin = new TextBox();
            btnGuardarManual = new Button();
            btnCopiarManual = new Button();
            btnMenuPrincipal = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtEditorPin
            // 
            txtEditorPin.BackColor = Color.FromArgb(45, 45, 48);
            txtEditorPin.BorderStyle = BorderStyle.FixedSingle;
            txtEditorPin.Font = new Font("Segoe UI", 11F);
            txtEditorPin.ForeColor = Color.White;
            txtEditorPin.Location = new Point(8, 156);
            txtEditorPin.Margin = new Padding(2);
            txtEditorPin.Multiline = true;
            txtEditorPin.Name = "txtEditorPin";
            txtEditorPin.ScrollBars = ScrollBars.Vertical;
            txtEditorPin.Size = new Size(898, 799);
            txtEditorPin.TabIndex = 0;
            // 
            // btnGuardarManual
            // 
            btnGuardarManual.BackColor = Color.FromArgb(0, 120, 215);
            btnGuardarManual.FlatAppearance.BorderSize = 0;
            btnGuardarManual.FlatStyle = FlatStyle.Flat;
            btnGuardarManual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarManual.Location = new Point(935, 243);
            btnGuardarManual.Margin = new Padding(2);
            btnGuardarManual.Name = "btnGuardarManual";
            btnGuardarManual.Size = new Size(169, 54);
            btnGuardarManual.TabIndex = 1;
            btnGuardarManual.Text = "Guardar cambios manuales";
            btnGuardarManual.UseVisualStyleBackColor = false;
            btnGuardarManual.Click += btnGuardarManual_Click;
            // 
            // btnCopiarManual
            // 
            btnCopiarManual.BackColor = Color.FromArgb(0, 120, 215);
            btnCopiarManual.FlatAppearance.BorderSize = 0;
            btnCopiarManual.FlatStyle = FlatStyle.Flat;
            btnCopiarManual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiarManual.ForeColor = Color.White;
            btnCopiarManual.Location = new Point(935, 156);
            btnCopiarManual.Margin = new Padding(2);
            btnCopiarManual.Name = "btnCopiarManual";
            btnCopiarManual.Size = new Size(169, 54);
            btnCopiarManual.TabIndex = 2;
            btnCopiarManual.Text = "Copiar";
            btnCopiarManual.UseVisualStyleBackColor = false;
            btnCopiarManual.Click += btnCopiarManual_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 95);
            label1.Name = "label1";
            label1.Size = new Size(483, 37);
            label1.TabIndex = 28;
            label1.Text = "Editor manual de pines informativos";
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
            panel2.TabIndex = 29;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 1014);
            label5.Name = "label5";
            label5.Size = new Size(453, 57);
            label5.TabIndex = 30;
            label5.Text = "SGAPI v1.0.0 | Sistema Generador y Administrador de Pines Informativos\r\n© 2026 Comisaría Vial del Estado de Jalisco | CEIPOL\r\nDesarrollado por Hazael Hervert\r\n";
            // 
            // FormEditorPinManual
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            CancelButton = btnMenuPrincipal;
            ClientSize = new Size(1920, 1080);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(btnCopiarManual);
            Controls.Add(btnGuardarManual);
            Controls.Add(txtEditorPin);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormEditorPinManual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEditorPinManual";
            WindowState = FormWindowState.Maximized;
            Load += FormEditorPinManual_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEditorPin;
        private Button btnGuardarManual;
        private Button btnCopiarManual;
        private Button btnMenuPrincipal;
        private Label label1;
        private Panel panel2;
        private Label label9;
        private Label label5;
    }
}