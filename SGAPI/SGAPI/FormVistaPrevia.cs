using System;
using System.IO;
using System.Windows.Forms;

namespace SGAPI
{
    public partial class FormVistaPrevia : Form
    {
        // texto que se muestra
        private string pinFinal;

        // pin actual
        private PinInformativo pinActual;

        // formulario anterior
        private Form formularioAnterior;

        public FormVistaPrevia()
        {
            InitializeComponent();
        }

        public FormVistaPrevia(string textoPin)
        {
            InitializeComponent();

            // guardar texto recibido
            pinFinal = textoPin;
        }

        public FormVistaPrevia(string textoPin, PinInformativo pin, Form anterior)
        {
            InitializeComponent();

            // guardar datos recibidos
            pinFinal = textoPin;
            pinActual = pin;
            formularioAnterior = anterior;
        }

        private string NormalizarSaltos(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            // arreglar saltos de línea pegados
            return texto
                .Replace("\r\n", "\n")
                .Replace("\r", "\n")
                .Replace("\n", Environment.NewLine);
        }

        private void FormVistaPrevia_Load(object sender, EventArgs e)
        {
            // configurar vista previa
            txtVistaPrevia.Multiline = true;
            txtVistaPrevia.WordWrap = true;
            txtVistaPrevia.AcceptsReturn = true;
            txtVistaPrevia.ScrollBars = ScrollBars.Vertical;

            // mostrar pin con saltos corregidos
            pinFinal = NormalizarSaltos(pinFinal);
            txtVistaPrevia.Text = pinFinal;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            // revisar texto
            if (string.IsNullOrWhiteSpace(txtVistaPrevia.Text))
            {
                MessageBox.Show("No hay texto para copiar.");
                return;
            }

            // copiar texto
            Clipboard.SetText(NormalizarSaltos(txtVistaPrevia.Text));

            MessageBox.Show("Texto copiado al portapapeles.");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // revisar texto
            if (string.IsNullOrWhiteSpace(txtVistaPrevia.Text))
            {
                MessageBox.Show("No hay texto para exportar.");
                return;
            }

            string reporte = "SinReporte";
            string municipio = "SinMunicipio";

            if (pinActual != null)
            {
                reporte = pinActual.NumeroReporte;
                municipio = pinActual.Municipio;
            }

            reporte = reporte.Replace(" ", "_");
            municipio = municipio.Replace(" ", "_");

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Archivo de texto (*.txt)|*.txt";

            save.FileName =
                $"SGAPI_Rep-{reporte}_{municipio}_{DateTime.Now:yyyyMMdd_HHmm}.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(
                    save.FileName,
                    NormalizarSaltos(txtVistaPrevia.Text)
                );

                MessageBox.Show(
                    "Archivo TXT exportado correctamente.",
                    "SGAPI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnRegresarEdicion_Click(object sender, EventArgs e)
        {
            // revisar pin
            if (pinActual == null)
            {
                MessageBox.Show("No se encontró el pin para editar.");
                return;
            }

            // abrir editor
            FormEditorPinManual editor = new FormEditorPinManual(pinActual);
            editor.ShowDialog();

            // cerrar vista previa
            this.Close();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            // cerrar ventanas
            formularioAnterior?.Close();
            this.Close();
        }

        private void btnExportarPDF_Click_1(object sender, EventArgs e)
        {
            if (pinActual == null)
            {
                MessageBox.Show("No se encontró el pin para exportar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVistaPrevia.Text))
            {
                MessageBox.Show("No hay texto para exportar.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Archivo PDF (*.pdf)|*.pdf";

            save.FileName =
                $"SGAPI_Rep-{pinActual.NumeroReporte}_{pinActual.Municipio}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                ExportadorPDF.ExportarPin(
                    save.FileName,
                    pinActual,
                    NormalizarSaltos(txtVistaPrevia.Text)
                );

                MessageBox.Show(
                    "PDF exportado correctamente.",
                    "SGAPI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}