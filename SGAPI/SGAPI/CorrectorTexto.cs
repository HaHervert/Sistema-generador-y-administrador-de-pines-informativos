using System;
using System.Collections.Generic;

namespace SGAPI
{
    public static class CorrectorTexto
    {
        public static string CapitalizarPalabras(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            texto = texto.Trim().ToLower();

            string[] palabras = texto.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 0)
                {
                    palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1);
                }
            }

            return string.Join(" ", palabras);
        }

        public static string CorregirTextoBasico(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            Dictionary<string, string> correcciones = new Dictionary<string, string>()
            {
                { "ceipol", "CEIPOL" },
                { "c5", "C5" },
                { "c-5", "C5" },
                { "c5 jalisco", "C5 Jalisco" },

                { "imss", "IMSS" },
                { "cfe", "CFE" },
                { "conagua", "CONAGUA" },

                { "comisaria vial", "Comisaría Vial" },
                { "comisaria vial regional", "Comisaría Vial Regional" },

                { "ministerio publico", "Ministerio Público" },
                { "proteccion civil", "Protección Civil" },
                { "servicios medicos", "Servicios Médicos" },
                { "cruz verde", "Cruz Verde" },
                { "cruz roja", "Cruz Roja" },

                { "area operativa", "Área Operativa" },
                { "interno de telecomunicaciones", "Interno de Telecomunicaciones" },

                { "alcolimetria", "Alcoholimetría" },
                { "alcoholimetria", "Alcoholimetría" },
                { "alcoholimetro", "Alcoholímetro" },

                { "lazaro cardenas", "Lázaro Cárdenas" },
                { "lopez mateos", "López Mateos" },
                { "benito juarez", "Benito Juárez" },
                { "juarez", "Juárez" },
                { "periferico", "Periférico" },
                { "tonala", "Tonalá" },
                { "mexico", "México" },

                { "vehiculo", "vehículo" },
                { "vehiculos", "vehículos" },
                { "circulacion", "circulación" },
                { "actualizacion", "actualización" },
                { "conclusion", "conclusión" },
                { "transito", "tránsito" },
                { "publico", "público" },
                { "policia", "policía" },
                { "policias", "policías" },
                { "mando y conduccion", "mando y conducción" },
                { "via", "vía" },
                { "grua", "grúa" },
                { "gruas", "grúas" }
            };

            foreach (var item in correcciones)
            {
                texto = texto.Replace(item.Key, item.Value, StringComparison.OrdinalIgnoreCase);
            }

            return texto;
        }

        public static string PrepararCampoCorto(string texto)
        {
            return CorregirTextoBasico(CapitalizarPalabras(texto));
        }

        public static string PrepararNarrativa(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return texto;

            // limpiar texto
            texto = texto.Trim();

            // primera letra en mayúscula
            texto = char.ToUpper(texto[0]) + texto.Substring(1);

            // mayúscula después de punto, signo o pregunta
            for (int i = 0; i < texto.Length - 2; i++)
            {
                if (texto[i] == '.' || texto[i] == '!' || texto[i] == '?')
                {
                    if (texto[i + 1] == ' ')
                    {
                        texto = texto.Remove(i + 2, 1)
                                     .Insert(i + 2, texto[i + 2].ToString().ToUpper());
                    }
                }
            }

            // corregir palabras muy comunes
            texto = CorregirTextoBasico(texto);

            return texto;
        }
    }
}