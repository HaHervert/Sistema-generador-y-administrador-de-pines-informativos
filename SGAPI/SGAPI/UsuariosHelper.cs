using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace SGAPI
{
    public static class UsuariosHelper
    {
        // conexión sqlite
        private static string cadenaConexion =
            "Data Source=Datos/sgapi.db";

        public static List<Usuario> Cargar()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqliteConnection conexion =
                new SqliteConnection(cadenaConexion))
            {
                conexion.Open();

                // revisar si existe admin
                string revisarAdmin = @"
                SELECT COUNT(*) FROM Usuarios
                WHERE NombreUsuario = 'admin';";

                using (SqliteCommand comandoAdmin =
                    new SqliteCommand(revisarAdmin, conexion))
                {
                    long cantidad =
                        (long)comandoAdmin.ExecuteScalar();

                    // si no existe admin, crearlo
                    if (cantidad == 0)
                    {
                        string insertarAdmin = @"
                        INSERT INTO Usuarios
                        (NombreUsuario, Contrasena)
                        VALUES
                        ('admin', '1234');";

                        using (SqliteCommand comandoInsertar =
                            new SqliteCommand(insertarAdmin, conexion))
                        {
                            comandoInsertar.ExecuteNonQuery();
                        }
                    }
                }

                // cargar usuarios
                string consulta =
                    "SELECT NombreUsuario, Contrasena FROM Usuarios";

                using (SqliteCommand comando =
                    new SqliteCommand(consulta, conexion))
                {
                    using (SqliteDataReader reader =
                        comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario();

                            usuario.NombreUsuario =
                                reader.GetString(0);

                            usuario.Contrasena =
                                reader.GetString(1);

                            usuarios.Add(usuario);
                        }
                    }
                }
            }

            return usuarios;
        }

        public static void Guardar(List<Usuario> usuarios)
        {
            using (SqliteConnection conexion =
                new SqliteConnection(cadenaConexion))
            {
                conexion.Open();

                // borrar usuarios actuales
                string borrar =
                    "DELETE FROM Usuarios";

                using (SqliteCommand comandoBorrar =
                    new SqliteCommand(borrar, conexion))
                {
                    comandoBorrar.ExecuteNonQuery();
                }

                // volver a insertar
                foreach (Usuario usuario in usuarios)
                {
                    string insertar = @"
                    INSERT INTO Usuarios
                    (NombreUsuario, Contrasena)
                    VALUES
                    (@usuario, @contrasena)";

                    using (SqliteCommand comandoInsertar =
                        new SqliteCommand(insertar, conexion))
                    {
                        comandoInsertar.Parameters.AddWithValue(
                            "@usuario",
                            usuario.NombreUsuario);

                        comandoInsertar.Parameters.AddWithValue(
                            "@contrasena",
                            usuario.Contrasena);

                        comandoInsertar.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}