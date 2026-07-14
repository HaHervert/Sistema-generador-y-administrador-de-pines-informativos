using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Controls;

namespace SGAPI
{
    public partial class FormActualizaciones : Form
    {
        // pin encontrado
        private PinInformativo pinEncontrado;

        // textbox WPF con corrector
        private System.Windows.Controls.TextBox txtDetalleWpf;

        public FormActualizaciones()
        {
            InitializeComponent();

            // activar corrector en detalle
            ActivarCorrectorDetalle();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pinEncontrado =
                BaseDatos.Pines
                .FirstOrDefault(p =>
                    p.NumeroReporte == txtBuscarReporte.Text);

            if (pinEncontrado == null)
            {
                MessageBox.Show("No se encontró ningún pin.");
                return;
            }

            txtPinSeleccionado.Text =
                $"*{pinEncontrado.Encabezado}*\r\n\r\n" +
                $"{pinEncontrado.Hora} horas ({pinEncontrado.Estado})\r\n" +
                $"Rep.-{pinEncontrado.NumeroReporte} de CEIPOL\r\n" +
                $"{pinEncontrado.Fecha}\r\n\r\n" +
                $"*{pinEncontrado.Municipio}*\r\n\r\n" +
                $"*{pinEncontrado.Titulo}*\r\n\r\n" +
                $"{pinEncontrado.Cruce}, col. {pinEncontrado.Colonia}\r\n\r\n" +
                $"{pinEncontrado.NovedadInicial}\r\n\r\n" +
                $"{pinEncontrado.Maps}";

            lstActualizaciones.Items.Clear();

            foreach (string act in pinEncontrado.Actualizaciones)
            {
                lstActualizaciones.Items.Add(act);
            }

            txtHoraActualizacion.Text =
                DateTime.Now.ToString("HH:mm");
        }

        private void btnAgregarActualizacion_Click(object sender, EventArgs e)
        {
            if (pinEncontrado == null)
            {
                MessageBox.Show("Primero busca un pin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDetalleWpf.Text))
            {
                MessageBox.Show("Escribe una actualización.");
                return;
            }

            string detalle =
                CorrectorTexto.PrepararNarrativa(txtDetalleWpf.Text);

            string nuevaActualizacion =
            $"*{txtHoraActualizacion.Text} horas*\r\n" +
                $"{detalle}";

            pinEncontrado.Actualizaciones.Add(nuevaActualizacion);
            pinEncontrado.Estado = "Actualizacion";
            pinEncontrado.TextoManualFinal = "";

            BaseDatosSQLite.GuardarPines(BaseDatos.Pines);

            lstActualizaciones.Items.Add(nuevaActualizacion);

            txtDetalleWpf.Clear();
            txtHoraActualizacion.Text = DateTime.Now.ToString("HH:mm");

            MessageBox.Show("Actualización agregada.");
        }

        private void btnAgregarConclusion_Click(object sender, EventArgs e)
        {
            if (pinEncontrado == null)
            {
                MessageBox.Show("Primero busca un pin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDetalleWpf.Text))
            {
                MessageBox.Show("Escribe la conclusión.");
                return;
            }

            string detalle =
                CorrectorTexto.PrepararNarrativa(txtDetalleWpf.Text);

            string conclusion =
               $"*{txtHoraActualizacion.Text} horas*\r\n" +
                $"{detalle}";

            pinEncontrado.Actualizaciones.Add(conclusion);
            pinEncontrado.Estado = "Conclusion";
            pinEncontrado.TextoManualFinal = "";

            BaseDatosSQLite.GuardarPines(BaseDatos.Pines);

            lstActualizaciones.Items.Add(conclusion);

            txtDetalleWpf.Clear();
            txtHoraActualizacion.Text = DateTime.Now.ToString("HH:mm");

            MessageBox.Show("Conclusión agregada.");
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActivarCorrectorDetalle()
        {
            txtDetalleWpf = new System.Windows.Controls.TextBox();

            txtDetalleWpf.AcceptsReturn = true;
            txtDetalleWpf.TextWrapping =
                System.Windows.TextWrapping.Wrap;

            txtDetalleWpf.VerticalScrollBarVisibility =
                ScrollBarVisibility.Auto;

            try
            {
                SpellCheck.SetIsEnabled(txtDetalleWpf, true);
            }
            catch (Exception ex)
            {
                Logger.GuardarError(ex, "FormActualizaciones");
            }

            txtDetalleWpf.Language =
                System.Windows.Markup.XmlLanguage.GetLanguage("es-MX");

            txtDetalleWpf.Background =
                new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Color.FromRgb(45, 45, 48));

            txtDetalleWpf.Foreground =
                new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Colors.White);

            txtDetalleWpf.CaretBrush =
                new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Colors.White);

            txtDetalleWpf.FontFamily =
                new System.Windows.Media.FontFamily("Segoe UI");

            txtDetalleWpf.FontSize = 14;
            txtDetalleWpf.BorderThickness = new System.Windows.Thickness(0);
            txtDetalleWpf.Padding = new System.Windows.Thickness(8);

            txtDetalleWpf.Text = txtDetalle.Text;

            ElementHost host = new ElementHost();
            host.Location = txtDetalle.Location;
            host.Size = txtDetalle.Size;
            host.Child = txtDetalleWpf;

            System.Windows.Forms.Control contenedor = txtDetalle.Parent;

            txtDetalle.Visible = false;

            contenedor.Controls.Add(host);
            host.BringToFront();
        }

        private void txtBuscarReporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPinSeleccionado_Click(object sender, EventArgs e)
        {

        }

        private void txtHoraActualizacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstActualizaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}