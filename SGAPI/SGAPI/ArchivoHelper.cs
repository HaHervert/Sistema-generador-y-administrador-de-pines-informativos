using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SGAPI
{
    public static class ArchivoHelper
    {
        // carpeta donde se guardan los datos
        private static string carpetaDatos = "Datos";

        // archivo principal
        private static string ruta = Path.Combine(carpetaDatos, "pines.json");

        // archivo de respaldo
        private static string rutaRespaldo = Path.Combine(carpetaDatos, "respaldo_pines.json");

        public static void Guardar(List<PinInformativo> pines)
        {
            // crear carpeta si no existe
            if (!Directory.Exists(carpetaDatos))
            {
                Directory.CreateDirectory(carpetaDatos);
            }

            // si ya existe archivo anterior, hacer respaldo
            if (File.Exists(ruta))
            {
                File.Copy(ruta, rutaRespaldo, true);
            }

            // convertir lista a json
            string json = JsonSerializer.Serialize(pines);

            // guardar archivo principal
            File.WriteAllText(ruta, json);
        }

        public static List<PinInformativo> Cargar()
        {
            // crear carpeta si no existe
            if (!Directory.Exists(carpetaDatos))
            {
                Directory.CreateDirectory(carpetaDatos);
            }

            // si no existe archivo principal
            if (!File.Exists(ruta))
            {
                return new List<PinInformativo>();
            }

            try
            {
                // leer archivo
                string json = File.ReadAllText(ruta);

                // convertir json a lista
                List<PinInformativo> pines =
                    JsonSerializer.Deserialize<List<PinInformativo>>(json);

                // si por algo viene vacío
                if (pines == null)
                    return new List<PinInformativo>();

                return pines;
            }
            catch
            {
                // si falla el archivo principal, intentar respaldo
                if (File.Exists(rutaRespaldo))
                {
                    string jsonRespaldo = File.ReadAllText(rutaRespaldo);

                    List<PinInformativo> pinesRespaldo =
                        JsonSerializer.Deserialize<List<PinInformativo>>(jsonRespaldo);

                    if (pinesRespaldo != null)
                        return pinesRespaldo;
                }

                return new List<PinInformativo>();
            }
        }
    }
}