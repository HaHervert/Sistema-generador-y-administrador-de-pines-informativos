namespace SGAPI
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            PanelLogin = new Panel();
            btnNuevoUsuario = new Button();
            label5 = new Label();
            PanelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(378, 16);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(233, 89);
            label1.TabIndex = 0;
            label1.Text = "SGAPI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(212, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(527, 25);
            label2.TabIndex = 1;
            label2.Text = "Sistema Generador y Administrador de pines informativos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(458, 191);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 2;
            label3.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(45, 45, 48);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(408, 225);
            txtUsuario.Margin = new Padding(2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(171, 25);
            txtUsuario.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(443, 268);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 4;
            label4.Text = "Contraseña:";
            label4.Click += label4_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(45, 45, 48);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(408, 305);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 25);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(432, 351);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // PanelLogin
            // 
            PanelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelLogin.BackColor = Color.FromArgb(37, 37, 40);
            PanelLogin.Controls.Add(btnNuevoUsuario);
            PanelLogin.Controls.Add(label1);
            PanelLogin.Controls.Add(btnLogin);
            PanelLogin.Controls.Add(label2);
            PanelLogin.Controls.Add(txtPassword);
            PanelLogin.Controls.Add(txtUsuario);
            PanelLogin.Controls.Add(label4);
            PanelLogin.Controls.Add(label3);
            PanelLogin.Location = new Point(433, 218);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(1004, 690);
            PanelLogin.TabIndex = 7;
            // 
            // btnNuevoUsuario
            // 
            btnNuevoUsuario.BackColor = Color.FromArgb(0, 120, 215);
            btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            btnNuevoUsuario.FlatStyle = FlatStyle.Flat;
            btnNuevoUsuario.ForeColor = Color.White;
            btnNuevoUsuario.Location = new Point(850, 608);
            btnNuevoUsuario.Margin = new Padding(2);
            btnNuevoUsuario.Name = "btnNuevoUsuario";
            btnNuevoUsuario.Size = new Size(133, 40);
            btnNuevoUsuario.TabIndex = 9;
            btnNuevoUsuario.Text = "Nuevo usuario";
            btnNuevoUsuario.UseVisualStyleBackColor = false;
            btnNuevoUsuario.Click += btnNuevoUsuario_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 1014);
            label5.Name = "label5";
            label5.Size = new Size(453, 57);
            label5.TabIndex = 8;
            label5.Text = "SGAPI v1.0.0 | Sistema Generador y Administrador de Pines Informativos\r\n© 2026 Comisaría Vial del Estado de Jalisco | CEIPOL\r\nDesarrollado por Hazael Hervert\r\n";
            // 
            // FormLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1920, 1080);
            Controls.Add(label5);
            Controls.Add(PanelLogin);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGAPI - Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private Label label4;
        private TextBox txtPassword;
        private Button btnLogin;
        private Panel PanelLogin;
        private Label label5;
        private Button btnNuevoUsuario;
    }
}
