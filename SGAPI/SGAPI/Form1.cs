using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SGAPI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cargar usuarios
            UsuariosHelper.Cargar();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // cargar usuarios guardados
            List<Usuario> usuarios = UsuariosHelper.Cargar();

            // buscar usuario
            Usuario usuarioEncontrado = usuarios.FirstOrDefault(u =>
                u.NombreUsuario == txtUsuario.Text &&
                u.Contrasena == txtPassword.Text
            );

            if (usuarioEncontrado != null)
            {
                // guardar usuario activo
                Sesion.UsuarioActual = usuarioEncontrado.NombreUsuario;

                // abrir menú principal
                FormPrincipal form = new FormPrincipal();
                form.Show();

                // ocultar login
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            // pedir clave secreta
            string clave = Interaction.InputBox(
                "Ingresa la clave de autorización",
                "Registro de usuarios"
            );

            // revisar clave
            if (clave == "CEIPOL1812")
            {
                FormRegistroUsuario form = new FormRegistroUsuario();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Clave incorrecta.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}