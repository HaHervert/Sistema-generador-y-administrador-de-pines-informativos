using System;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Controls;

namespace SGAPI
{
    public partial class FormEditorPinManual : Form
    {
        // guardar el pin actual
        private PinInformativo pinActual;

        // textbox WPF con corrector
        private System.Windows.Controls.TextBox txtEditorPinWpf;

        public FormEditorPinManual(PinInformativo pin)
        {
            InitializeComponent();

            // guardar pin recibido
            pinActual = pin;
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

        private void FormEditorPinManual_Load(object sender, EventArgs e)
        {
            string textoPin;

            // revisar si ya había texto manual
            if (!string.IsNullOrWhiteSpace(pinActual.TextoManualFinal))
            {
                textoPin = pinActual.TextoManualFinal;
            }
            else
            {
                // generar pin automático
                textoPin =
                    $"*{pinActual.Encabezado}*\r\n\r\n" +
                    $"{pinActual.Hora} horas ({pinActual.Estado})\r\n" +
                    $"Rep.-{pinActual.NumeroReporte} de CEIPOL\r\n" +
                    $"{pinActual.Fecha}\r\n\r\n" +
                    $"*{pinActual.Municipio}*\r\n\r\n" +
                    $"*{pinActual.Titulo}*\r\n\r\n" +
                    $"{pinActual.Cruce}, col. {pinActual.Colonia}\r\n\r\n" +
                    $"{pinActual.NovedadInicial}\r\n\r\n";

                // agregar actualizaciones
                foreach (string act in pinActual.Actualizaciones)
                {
                    textoPin += act + "\r\n\r\n";
                }

                // agregar maps
                textoPin += pinActual.Maps;
            }

            // pasar texto corregido al textbox viejo
            txtEditorPin.Text = NormalizarSaltos(textoPin);

            // activar corrector
            ActivarCorrectorEditor();
        }

        private void btnGuardarManual_Click(object sender, EventArgs e)
        {
            // guardar texto manual
            pinActual.TextoManualFinal =
                NormalizarSaltos(txtEditorPinWpf.Text);

            // guardar archivo
            BaseDatosSQLite.GuardarPines(BaseDatos.Pines);

            MessageBox.Show("Cambios manuales guardados.");
        }

        private void btnCopiarManual_Click(object sender, EventArgs e)
        {
            // copiar texto
            Clipboard.SetText(
                NormalizarSaltos(txtEditorPinWpf.Text)
            );

            MessageBox.Show("Texto copiado al portapapeles.");
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            // cerrar ventana
            this.Close();
        }

        private void ActivarCorrectorEditor()
        {
            // crear textbox WPF
            txtEditorPinWpf = new System.Windows.Controls.TextBox();

            // multilinea
            txtEditorPinWpf.AcceptsReturn = true;

            // wrap
            txtEditorPinWpf.TextWrapping =
                System.Windows.TextWrapping.Wrap;

            // scroll
            txtEditorPinWpf.VerticalScrollBarVisibility =
                ScrollBarVisibility.Auto;

            // corrector
            try
            {
                SpellCheck.SetIsEnabled(txtEditorPinWpf, true);
            }
            catch (Exception ex)
            {
                Logger.GuardarError(ex, "FormEditorPinManual");
            }

            // idioma español
            txtEditorPinWpf.Language =
                System.Windows.Markup.XmlLanguage.GetLanguage("es-MX");

            // colores
            txtEditorPinWpf.Background =
                new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Color.FromRgb(45, 45, 48));

            txtEditorPinWpf.Foreground =
                new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Colors.White);

            txtEditorPinWpf.CaretBrush =
                new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Colors.White);

            txtEditorPinWpf.FontFamily =
                new System.Windows.Media.FontFamily("Segoe UI");

            txtEditorPinWpf.FontSize = 14;
            txtEditorPinWpf.BorderThickness = new System.Windows.Thickness(0);
            txtEditorPinWpf.Padding = new System.Windows.Thickness(8);

            // copiar texto viejo
            txtEditorPinWpf.Text = NormalizarSaltos(txtEditorPin.Text);

            // crear host
            ElementHost host = new ElementHost();

            // tamaño y posición
            host.Location = txtEditorPin.Location;
            host.Size = txtEditorPin.Size;

            // meter textbox
            host.Child = txtEditorPinWpf;

            // guardar contenedor original
            System.Windows.Forms.Control contenedor = txtEditorPin.Parent;

            // ocultar viejo
            txtEditorPin.Visible = false;

            // agregar al mismo contenedor
            contenedor.Controls.Add(host);

            // enfrente
            host.BringToFront();
        }
    }
}