using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SGAPI
{
    public partial class FormRegistroUsuario : Form
    {
        public FormRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            // validar usuario
            if (string.IsNullOrWhiteSpace(txtNuevoUsuario.Text))
            {
                MessageBox.Show("Ingresa un nombre de usuario.");
                return;
            }

            // validar contraseña
            if (string.IsNullOrWhiteSpace(txtNuevaContrasena.Text))
            {
                MessageBox.Show("Ingresa una contraseña.");
                return;
            }

            // confirmar contraseña
            if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // cargar usuarios
            List<Usuario> usuarios = UsuariosHelper.Cargar();

            // revisar si ya existe
            bool yaExiste = usuarios.Any(u =>
                u.NombreUsuario.ToLower() == txtNuevoUsuario.Text.ToLower()
            );

            if (yaExiste)
            {
                MessageBox.Show("Ese usuario ya existe.");
                return;
            }

            // crear usuario
            Usuario nuevo = new Usuario()
            {
                NombreUsuario = txtNuevoUsuario.Text.Trim(),
                Contrasena = txtNuevaContrasena.Text
            };

            // guardar usuario
            usuarios.Add(nuevo);
            UsuariosHelper.Guardar(usuarios);

            MessageBox.Show("Usuario registrado correctamente.");

            // cerrar ventana
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // cerrar ventana
            this.Close();
        }
    }
}