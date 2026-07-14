using System.Collections.Generic;
using System.IO;
using Microsoft.Data.Sqlite;

namespace SGAPI
{
    public static class BaseDatosSQLite
    {
        // carpeta de datos
        private static string carpetaDatos = "Datos";

        // archivo de base de datos
        private static string rutaBD = Path.Combine(carpetaDatos, "sgapi.db");

        // conexión sqlite
        private static string cadenaConexion = $"Data Source={rutaBD}";

        public static void Inicializar()
        {
            // crear carpeta si no existe
            if (!Directory.Exists(carpetaDatos))
            {
                Directory.CreateDirectory(carpetaDatos);
            }

            using (SqliteConnection conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();

                // tabla pines
                string tablaPines = @"
                CREATE TABLE IF NOT EXISTS Pines (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    UsuarioCreador TEXT,
                    Encabezado TEXT,
                    Estado TEXT,
                    Hora TEXT,
                    NumeroReporte TEXT,
                    Fecha TEXT,
                    Municipio TEXT,
                    Titulo TEXT,
                    Colonia TEXT,
                    Cruce TEXT,
                    NovedadInicial TEXT,
                    Maps TEXT,
                    TextoManualFinal TEXT
                );";

                // tabla actualizaciones
                string tablaActualizaciones = @"
                CREATE TABLE IF NOT EXISTS Actualizaciones (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NumeroReporte TEXT,
                    Texto TEXT
                );";

                // tabla usuarios
                string tablaUsuarios = @"
                CREATE TABLE IF NOT EXISTS Usuarios (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    NombreUsuario TEXT NOT NULL UNIQUE,
                    Contrasena TEXT NOT NULL
                );";

                EjecutarComando(conexion, tablaPines);
                EjecutarComando(conexion, tablaActualizaciones);
                EjecutarComando(conexion, tablaUsuarios);
            }
        }

        public static void GuardarPines(List<PinInformativo> pines)
        {
            using (SqliteConnection conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();

                // limpiar tablas
                EjecutarComando(conexion, "DELETE FROM Actualizaciones;");
                EjecutarComando(conexion, "DELETE FROM Pines;");

                foreach (PinInformativo pin in pines)
                {
                    // guardar pin
                    string insertarPin = @"
                    INSERT INTO Pines
                    (
                        UsuarioCreador,
                        Encabezado,
                        Estado,
                        Hora,
                        NumeroReporte,
                        Fecha,
                        Municipio,
                        Titulo,
                        Colonia,
                        Cruce,
                        NovedadInicial,
                        Maps,
                        TextoManualFinal
                    )
                    VALUES
                    (
                        @UsuarioCreador,
                        @Encabezado,
                        @Estado,
                        @Hora,
                        @NumeroReporte,
                        @Fecha,
                        @Municipio,
                        @Titulo,
                        @Colonia,
                        @Cruce,
                        @NovedadInicial,
                        @Maps,
                        @TextoManualFinal
                    );";

                    using (SqliteCommand comando = new SqliteCommand(insertarPin, conexion))
                    {
                        comando.Parameters.AddWithValue("@UsuarioCreador", pin.UsuarioCreador ?? "");
                        comando.Parameters.AddWithValue("@Encabezado", pin.Encabezado ?? "");
                        comando.Parameters.AddWithValue("@Estado", pin.Estado ?? "");
                        comando.Parameters.AddWithValue("@Hora", pin.Hora ?? "");
                        comando.Parameters.AddWithValue("@NumeroReporte", pin.NumeroReporte ?? "");
                        comando.Parameters.AddWithValue("@Fecha", pin.Fecha ?? "");
                        comando.Parameters.AddWithValue("@Municipio", pin.Municipio ?? "");
                        comando.Parameters.AddWithValue("@Titulo", pin.Titulo ?? "");
                        comando.Parameters.AddWithValue("@Colonia", pin.Colonia ?? "");
                        comando.Parameters.AddWithValue("@Cruce", pin.Cruce ?? "");
                        comando.Parameters.AddWithValue("@NovedadInicial", pin.NovedadInicial ?? "");
                        comando.Parameters.AddWithValue("@Maps", pin.Maps ?? "");
                        comando.Parameters.AddWithValue("@TextoManualFinal", pin.TextoManualFinal ?? "");

                        comando.ExecuteNonQuery();
                    }

                    // guardar actualizaciones
                    foreach (string actualizacion in pin.Actualizaciones)
                    {
                        string insertarActualizacion = @"
                        INSERT INTO Actualizaciones
                        (NumeroReporte, Texto)
                        VALUES
                        (@NumeroReporte, @Texto);";

                        using (SqliteCommand comandoAct = new SqliteCommand(insertarActualizacion, conexion))
                        {
                            comandoAct.Parameters.AddWithValue("@NumeroReporte", pin.NumeroReporte ?? "");
                            comandoAct.Parameters.AddWithValue("@Texto", actualizacion ?? "");

                            comandoAct.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static List<PinInformativo> CargarPines()
        {
            List<PinInformativo> pines = new List<PinInformativo>();

            using (SqliteConnection conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();

                // cargar pines
                string consultaPines = @"
                SELECT
                    UsuarioCreador,
                    Encabezado,
                    Estado,
                    Hora,
                    NumeroReporte,
                    Fecha,
                    Municipio,
                    Titulo,
                    Colonia,
                    Cruce,
                    NovedadInicial,
                    Maps,
                    TextoManualFinal
                FROM Pines;";

                using (SqliteCommand comando = new SqliteCommand(consultaPines, conexion))
                {
                    using (SqliteDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PinInformativo pin = new PinInformativo();

                            pin.UsuarioCreador = reader.GetString(0);
                            pin.Encabezado = reader.GetString(1);
                            pin.Estado = reader.GetString(2);
                            pin.Hora = reader.GetString(3);
                            pin.NumeroReporte = reader.GetString(4);
                            pin.Fecha = reader.GetString(5);
                            pin.Municipio = reader.GetString(6);
                            pin.Titulo = reader.GetString(7);
                            pin.Colonia = reader.GetString(8);
                            pin.Cruce = reader.GetString(9);
                            pin.NovedadInicial = reader.GetString(10);
                            pin.Maps = reader.GetString(11);
                            pin.TextoManualFinal = reader.GetString(12);

                            pines.Add(pin);
                        }
                    }
                }

                // cargar actualizaciones
                foreach (PinInformativo pin in pines)
                {
                    string consultaAct = @"
                    SELECT Texto FROM Actualizaciones
                    WHERE NumeroReporte = @NumeroReporte;";

                    using (SqliteCommand comandoAct = new SqliteCommand(consultaAct, conexion))
                    {
                        comandoAct.Parameters.AddWithValue("@NumeroReporte", pin.NumeroReporte ?? "");

                        using (SqliteDataReader readerAct = comandoAct.ExecuteReader())
                        {
                            while (readerAct.Read())
                            {
                                pin.Actualizaciones.Add(readerAct.GetString(0));
                            }
                        }
                    }
                }
            }

            return pines;
        }

        private static void EjecutarComando(SqliteConnection conexion, string consulta)
        {
            using (SqliteCommand comando = new SqliteCommand(consulta, conexion))
            {
                comando.ExecuteNonQuery();
            }
        }
    }
}