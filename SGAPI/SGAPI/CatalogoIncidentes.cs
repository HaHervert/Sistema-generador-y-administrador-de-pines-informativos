using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SGAPI
{
    public static class CatalogoIncidentes
    {
        public static List<string> CargarTitulos()
        {
            string ruta =
                Path.Combine(Application.StartupPath, "Datos", "CatalogoIncidentes.txt");

            if (!File.Exists(ruta))
            {
                return new List<string>();
            }

            return File.ReadAllLines(ruta)
                .Where(linea => !string.IsNullOrWhiteSpace(linea))
                .Select(linea => linea.Trim())
                .Distinct()
                .ToList();
        }

        public static string LimpiarTituloParaPin(string titulo)
        {
            if (string.IsNullOrWhiteSpace(titulo))
                return "";

            int posicionSeparador = titulo.IndexOf(" | ");

            if (posicionSeparador >= 0)
            {
                return titulo.Substring(0, posicionSeparador).Trim();
            }

            int posicionGuion = titulo.IndexOf(" - ");

            if (posicionGuion >= 0)
            {
                return titulo.Substring(posicionGuion + 3).Trim();
            }

            return titulo.Trim();
        }
    }
}