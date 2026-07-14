using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SGAPI
{
    public static class PlantillasNarrativas
    {
        public static Dictionary<string, string> CargarPlantillas()
        {
            Dictionary<string, string> plantillas =
                new Dictionary<string, string>();

            string ruta =
                Path.Combine(
                    Application.StartupPath,
                    "Datos",
                    "PlantillasNarrativas.txt");

            if (!File.Exists(ruta))
            {
                return plantillas;
            }

            string[] lineas = File.ReadAllLines(ruta);

            string tituloActual = "";
            string textoActual = "";

            bool leyendoTexto = false;

            foreach (string linea in lineas)
            {
                if (linea == "[TITULO]")
                {
                    leyendoTexto = false;
                    continue;
                }

                if (string.IsNullOrWhiteSpace(tituloActual) &&
                    !leyendoTexto &&
                    linea != "[TEXTO]" &&
                    linea != "[FIN]")
                {
                    tituloActual = linea.Trim();
                    continue;
                }

                if (linea == "[TEXTO]")
                {
                    leyendoTexto = true;
                    textoActual = "";
                    continue;
                }

                if (linea == "[FIN]")
                {
                    if (!plantillas.ContainsKey(tituloActual))
                    {
                        plantillas.Add(tituloActual, textoActual.Trim());
                    }

                    tituloActual = "";
                    textoActual = "";
                    leyendoTexto = false;

                    continue;
                }

                if (leyendoTexto)
                {
                    textoActual += linea + "\r\n";
                }
            }

            return plantillas;
        }
    }
}