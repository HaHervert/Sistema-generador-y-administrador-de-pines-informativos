using System;
using System.IO;

namespace SGAPI
{
    public static class Logger
    {
        public static void GuardarError(Exception ex, string origen)
        {
            try
            {
                string carpeta = "Datos";
                string archivo = Path.Combine(carpeta, "errores.log");

                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }

                string texto =
                    "------------------------------\r\n" +
                    $"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\r\n" +
                    $"Origen: {origen}\r\n" +
                    $"Error: {ex.Message}\r\n" +
                    $"Detalle: {ex}\r\n\r\n";

                File.AppendAllText(archivo, texto);
            }
            catch
            {
                // evitar que el logger rompa el programa
            }
        }
    }
}