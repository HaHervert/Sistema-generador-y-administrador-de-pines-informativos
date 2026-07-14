using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGAPI
{
    public partial class FormReportes : Form
    {
        public FormReportes()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            // poner fecha actual
            txtFechaReporte.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            // generar reporte
            GenerarReporte();
        }

        private void GenerarReporte()
        {
            // obtener fecha escrita
            string fecha = txtFechaReporte.Text.Trim();

            // validar fecha vacía
            if (string.IsNullOrWhiteSpace(fecha))
            {
                MessageBox.Show("Ingresa una fecha para generar el reporte.");
                return;
            }

            // filtrar pines por fecha
            List<PinInformativo> pinesFiltrados = BaseDatos.Pines
                .Where(p => p.Fecha == fecha)
                .ToList();

            // contar estados
            int total = pinesFiltrados.Count;

            int preliminares =
                pinesFiltrados.Count(p => p.Estado == "Preliminar");

            int actualizacion =
                pinesFiltrados.Count(p => p.Estado == "Actualizacion");

            int conclusion =
                pinesFiltrados.Count(p => p.Estado == "Conclusion");

            int informativo =
                pinesFiltrados.Count(p => p.Estado == "Informativo");

            // crear texto del reporte
            StringBuilder reporte = new StringBuilder();

            reporte.AppendLine("REPORTE SGAPI");
            reporte.AppendLine("Sistema Generador y Administrador de Pines Informativos");
            reporte.AppendLine("CEIPOL - Comisaría Vial del Estado de Jalisco");
            reporte.AppendLine("------------------------------------------------------------");

            reporte.AppendLine($"Fecha del reporte: {fecha}");
            reporte.AppendLine($"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm} horas");

            reporte.AppendLine();

            // resumen general
            reporte.AppendLine("RESUMEN GENERAL");

            reporte.AppendLine($"Total de pines generados: {total}");
            reporte.AppendLine($"Preliminares: {preliminares}");
            reporte.AppendLine($"En actualización: {actualizacion}");
            reporte.AppendLine($"Concluidos: {conclusion}");
            reporte.AppendLine($"Informativos: {informativo}");

            reporte.AppendLine();

            // reporte por municipio
            reporte.AppendLine("REPORTE POR MUNICIPIO");
            reporte.AppendLine("------------------------------------------------------------");

            var porMunicipio = pinesFiltrados
                .GroupBy(p => p.Municipio)
                .Select(g => new
                {
                    Municipio = g.Key,
                    Total = g.Count()
                })
                .OrderByDescending(x => x.Total);

            if (!porMunicipio.Any())
            {
                reporte.AppendLine("No hay registros por municipio.");
            }
            else
            {
                foreach (var item in porMunicipio)
                {
                    reporte.AppendLine($"{item.Municipio}: {item.Total}");
                }
            }

            reporte.AppendLine();

            // detalle de pines
            reporte.AppendLine("DETALLE DE PINES");
            reporte.AppendLine("------------------------------------------------------------");

            if (total == 0)
            {
                reporte.AppendLine("No se encontraron pines registrados en esta fecha.");
            }
            else
            {
                foreach (PinInformativo pin in pinesFiltrados)
                {
                    reporte.AppendLine($"Rep.-{pin.NumeroReporte} de CEIPOL");
                    reporte.AppendLine($"Hora: {pin.Hora} horas");
                    reporte.AppendLine($"Municipio: {pin.Municipio}");
                    reporte.AppendLine($"Título: {pin.Titulo}");
                    reporte.AppendLine($"Estado: {pin.Estado}");
                    reporte.AppendLine($"Actualizaciones: {pin.Actualizaciones.Count}");

                    reporte.AppendLine("------------------------------------------------------------");
                }
            }

            // mostrar reporte
            txtReporteGenerado.Text = reporte.ToString();
        }

        private void btnExportarReporte_Click(object sender, EventArgs e)
        {
            // validar si hay reporte
            if (string.IsNullOrWhiteSpace(txtReporteGenerado.Text))
            {
                MessageBox.Show("Primero genera un reporte.");
                return;
            }

            // guardar archivo
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Archivo de texto (*.txt)|*.txt";

            save.FileName =
                "Reporte_SGAPI_" +
                DateTime.Now.ToString("yyyyMMdd_HHmm") +
                ".txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, txtReporteGenerado.Text);

                MessageBox.Show("Reporte exportado correctamente.");
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            // cerrar ventana
            this.Close();
        }
    }
}