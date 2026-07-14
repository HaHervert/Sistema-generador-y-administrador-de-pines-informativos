using System;
using System.Collections.Generic;

namespace SGAPI
{
    public class PinInformativo
    {

        // encabezado principal
        public string Encabezado { get; set; }

        // usuario que creó el pin
        public string UsuarioCreador { get; set; }

        // estado actual del pin
        public string Estado { get; set; }

        // hora del reporte
        public string Hora { get; set; }

        // número de reporte
        public string NumeroReporte { get; set; }

        // fecha del pin
        public string Fecha { get; set; }

        // municipio
        public string Municipio { get; set; }

        // título principal
        public string Titulo { get; set; }

        // colonia
        public string Colonia { get; set; }

        // cruce de calles
        public string Cruce { get; set; }

        // narrativa inicial
        public string NovedadInicial { get; set; }

        // enlace de google maps
        public string Maps { get; set; }

        // texto manual editado
        public string TextoManualFinal { get; set; }

        // lista de actualizaciones
        public List<string> Actualizaciones { get; set; } = new List<string>();
    }
}