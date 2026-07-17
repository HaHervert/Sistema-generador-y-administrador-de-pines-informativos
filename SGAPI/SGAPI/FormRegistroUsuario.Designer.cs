namespace SGAPI
{
    partial class FormRegistroUsuario
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar recursos.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el diseñador

        private void InitializeComponent()
        {
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtConfirmarContrasena = new TextBox();
            txtNuevaContrasena = new TextBox();
            txtNuevoUsuario = new TextBox();
            btnRegistrarUsuario = new Button();
            btnCancelar = new Button();

            SuspendLayout();

            // label usuario
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.Text = "Usuario:";

            // label contraseña
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(11, 114);
            label3.Name = "label3";
            label3.Size = new Size(154, 21);
            label3.Text = "Nueva Contraseña:";

            // label confirmar
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(11, 237);
            label2.Name = "label2";
            label2.Size = new Size(181, 21);
            label2.Text = "Confirmar Contraseña:";

            // txt usuario
            txtNuevoUsuario.BackColor = Color.FromArgb(45, 45, 48);
            txtNuevoUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtNuevoUsuario.ForeColor = Color.White;
            txtNuevoUsuario.Location = new Point(11, 46);
            txtNuevoUsuario.Name = "txtNuevoUsuario";
            txtNuevoUsuario.Size = new Size(495, 23);

            // txt contraseña
            txtNuevaContrasena.BackColor = Color.FromArgb(45, 45, 48);
            txtNuevaContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtNuevaContrasena.ForeColor = Color.White;
            txtNuevaContrasena.Location = new Point(11, 150);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.Size = new Size(495, 23);
            txtNuevaContrasena.UseSystemPasswordChar = true;

            // txt confirmar
            txtConfirmarContrasena.BackColor = Color.FromArgb(45, 45, 48);
            txtConfirmarContrasena.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContrasena.ForeColor = Color.White;
            txtConfirmarContrasena.Location = new Point(11, 273);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(495, 23);
            txtConfirmarContrasena.UseSystemPasswordChar = true;

            // boton registrar
            btnRegistrarUsuario.BackColor = Color.FromArgb(0, 120, 215);
            btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            btnRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistrarUsuario.ForeColor = Color.White;
            btnRegistrarUsuario.Location = new Point(373, 361);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(133, 40);
            btnRegistrarUsuario.Text = "Registrar";
            btnRegistrarUsuario.UseVisualStyleBackColor = false;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;

            // boton cancelar
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(11, 361);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 40);
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;

            // form
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(528, 434);

            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrarUsuario);
            Controls.Add(txtNuevoUsuario);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(txtConfirmarContrasena);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);

            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de usuario";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;

        private TextBox txtConfirmarContrasena;
        private TextBox txtNuevaContrasena;
        private TextBox txtNuevoUsuario;

        private Button btnRegistrarUsuario;
        private Button btnCancelar;
    }
}

