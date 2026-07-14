using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SGAPI
{
    public static class BackupHelper
    {
        // carpeta datos
        private static string carpetaDatos = "Datos";

        // carpeta backups
        private static string carpetaBackups =
            Path.Combine(carpetaDatos, "Backups");

        // ruta sqlite
        private static string rutaBD =
            Path.Combine(carpetaDatos, "sgapi.db");

        // máximo backups
        private static int maximoBackups = 24;

        // timer
        private static System.Windows.Forms.Timer timerBackup;

        public static void IniciarSistemaBackups()
        {
            // crear carpeta backups
            if (!Directory.Exists(carpetaBackups))
            {
                Directory.CreateDirectory(carpetaBackups);
            }

            // crear timer
            timerBackup = new System.Windows.Forms.Timer();

            // 1 hora
            timerBackup.Interval = 1000 * 60 * 60;

            // evento
            timerBackup.Tick += TimerBackup_Tick;

            // iniciar
            timerBackup.Start();

            // crear primer backup
            CrearBackup();
        }

        private static void TimerBackup_Tick(
            object sender,
            EventArgs e)
        {
            CrearBackup();
        }

        public static void CrearBackup()
        {
            try
            {
                // revisar base
                if (!File.Exists(rutaBD))
                {
                    return;
                }

                // nombre backup
                string nombreBackup =
                    $"backup_{DateTime.Now:yyyy-MM-dd_HH-mm}.db";

                // ruta backup
                string rutaBackup =
                    Path.Combine(carpetaBackups, nombreBackup);

                // copiar
                File.Copy(rutaBD, rutaBackup, true);

                // limpiar backups viejos
                LimpiarBackupsViejos();
            }
            catch (Exception ex)
            {
                Logger.GuardarError(ex, "NombreDelModulo");
            }
        }

        private static void LimpiarBackupsViejos()
        {
            DirectoryInfo carpeta =
                new DirectoryInfo(carpetaBackups);

            FileInfo[] backups =
                carpeta.GetFiles("*.db")
                .OrderByDescending(f => f.CreationTime)
                .ToArray();

            // eliminar extras
            if (backups.Length > maximoBackups)
            {
                for (
                    int i = maximoBackups;
                    i < backups.Length;
                    i++)
                {
                    try
                    {
                        backups[i].Delete();
                    }
                    catch (Exception ex)
                    {
                        Logger.GuardarError(ex, "NombreDelModulo");
                    }
                }
            }
        }
        public static bool RestaurarBackup(string rutaBackup)
        {
            try
            {
                // revisar backup
                if (!File.Exists(rutaBackup))
                {
                    return false;
                }

                // revisar carpeta datos
                if (!Directory.Exists(carpetaDatos))
                {
                    Directory.CreateDirectory(carpetaDatos);
                }

                // respaldo antes de restaurar
                if (File.Exists(rutaBD))
                {
                    string respaldoAntes =
                        Path.Combine(
                            carpetaBackups,
                            $"antes_restaurar_{DateTime.Now:yyyy-MM-dd_HH-mm}.db"
                        );

                    File.Copy(rutaBD, respaldoAntes, true);
                }

                // copiar backup a base principal
                File.Copy(rutaBackup, rutaBD, true);

                return true;
            }
            catch (Exception ex)
            {
                Logger.GuardarError(ex, "RestaurarBackup");
                return false;
            }
        }
        public static string ObtenerUltimoBackup()
        {
            try
            {
                // revisar carpeta
                if (!Directory.Exists(carpetaBackups))
                {
                    return "Sin respaldos";
                }

                DirectoryInfo carpeta =
                    new DirectoryInfo(carpetaBackups);

                FileInfo ultimo =
                    carpeta.GetFiles("*.db")
                    .OrderByDescending(f => f.CreationTime)
                    .FirstOrDefault();

                if (ultimo == null)
                {
                    return "Sin respaldos";
                }

                return ultimo.CreationTime
                    .ToString("dd/MM/yyyy HH:mm");
            }
            catch
            {
                return "Error";
            }
        }
    }
}