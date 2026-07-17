using System;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Controls;
using System.Collections.Generic;

namespace SGAPI
{
    public partial class FormRegistroPin : Form
    {
        private PinInformativo pinEditando = null;

        private System.Windows.Controls.TextBox txtNovedadWpf;
        private Dictionary<string, string> plantillas =
    new Dictionary<string, string>();

        public FormRegistroPin()
        {
            InitializeComponent();
        }

        public FormRegistroPin(PinInformativo pin)
        {
            InitializeComponent();

            pinEditando = pin;

            cboEncabezado.Text = pin.Encabezado;
            cboEstado.Text = pin.Estado;
            txtHora.Text = pin.Hora;
            txtReporte.Text = pin.NumeroReporte;
            txtFecha.Text = pin.Fecha;
            cboMunicipio.Text = pin.Municipio;
            cboTitulo.Text = pin.Titulo;
            txtColonia.Text = pin.Colonia;
            txtCruce.Text = pin.Cruce;
            txtNovedad.Text = pin.NovedadInicial;
            txtMaps.Text = pin.Maps;
        }

        private void btnGuardarPin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboMunicipio.Text) ||
                string.IsNullOrWhiteSpace(cboTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtNovedadWpf.Text))
            {
                MessageBox.Show("No puedes guardar sin municipio, título y novedad inicial.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReporte.Text))
            {
                MessageBox.Show("El número de reporte es obligatorio.");
                return;
            }

            if (!int.TryParse(txtReporte.Text, out _))
            {
                MessageBox.Show("El número de reporte debe contener solo números.");
                return;
            }

            PinInformativo pin;

            if (pinEditando != null)
                pin = pinEditando;
            else
                pin = new PinInformativo();

            if (string.IsNullOrWhiteSpace(pin.UsuarioCreador))
            {
                pin.UsuarioCreador = Sesion.UsuarioActual;
            }

            pin.Encabezado = cboEncabezado.Text;
            pin.Estado = cboEstado.Text;
            pin.Hora = txtHora.Text;
            pin.NumeroReporte = txtReporte.Text;
            pin.Fecha = txtFecha.Text;

            pin.Municipio =
                CorrectorTexto.PrepararCampoCorto(cboMunicipio.Text);

            pin.Titulo =
                CorrectorTexto.PrepararCampoCorto(
                    CatalogoIncidentes.LimpiarTituloParaPin(cboTitulo.Text)
                );

            pin.Colonia =
                CorrectorTexto.PrepararCampoCorto(txtColonia.Text);

            pin.Cruce =
                CorrectorTexto.PrepararCampoCorto(txtCruce.Text);

            pin.NovedadInicial =
                CorrectorTexto.PrepararNarrativa(txtNovedadWpf.Text);

            pin.Maps = txtMaps.Text;

            if (pinEditando == null)
            {
                BaseDatos.Pines.Add(pin);
            }

            BaseDatosSQLite.GuardarPines(BaseDatos.Pines);

            string pinFinal =
                $"*{pin.Encabezado}*\r\n\r\n" +
                $"{pin.Hora} horas ({pin.Estado})\r\n" +
                $"Rep.-{pin.NumeroReporte} de CEIPOL\r\n" +
                $"{pin.Fecha}\r\n\r\n" +
                $"*{pin.Municipio}*\r\n\r\n" +
                $"*{pin.Titulo}*\r\n\r\n" +
                $"{pin.Cruce}, col. {pin.Colonia}\r\n\r\n" +
                $"{pin.NovedadInicial}\r\n\r\n" +
                $"{pin.Maps}";

            FormVistaPrevia vista = new FormVistaPrevia(pinFinal, pin, this);
            vista.ShowDialog();

            if (pinEditando != null)
                MessageBox.Show("Pin actualizado correctamente.");
            else
                MessageBox.Show("Pin guardado correctamente.");
        }

        private void FormRegistroPin_Load(object sender, EventArgs e)
        {
            cboEncabezado.Items.Clear();
            cboEstado.Items.Clear();

            cboEncabezado.Items.Add("Comisaría Vial");
            cboEncabezado.Items.Add("Comisaría Vial Regional");
            cboEncabezado.Items.Add("Comisaría Estatal Preventiva");

            cboEstado.Items.Add("Preliminar");
            cboEstado.Items.Add("Actualizacion");
            cboEstado.Items.Add("Conclusion");
            cboEstado.Items.Add("Informativo");

            CargarMunicipios();
            CargarTitulosIncidentes();
            plantillas = PlantillasNarrativas.CargarPlantillas();

            if (pinEditando == null)
            {
                cboEncabezado.SelectedIndex = 0;
                cboEstado.SelectedIndex = 0;
                txtHora.Text = DateTime.Now.ToString("HH:mm");
                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }

            ActivarCorrectorEnNovedad();
        }

        private void CargarTitulosIncidentes()
        {
            cboTitulo.Items.Clear();

            try
            {
                var titulos = CatalogoIncidentes.CargarTitulos();

                cboTitulo.BeginUpdate();

                foreach (string titulo in titulos)
                {
                    if (!string.IsNullOrWhiteSpace(titulo))
                    {
                        cboTitulo.Items.Add(titulo.Trim());
                    }
                }

                cboTitulo.EndUpdate();

                cboTitulo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboTitulo.AutoCompleteSource = AutoCompleteSource.ListItems;
                cboTitulo.DropDownStyle = ComboBoxStyle.DropDown;
                cboTitulo.DrawMode = DrawMode.Normal;
            }
            catch (Exception ex)
            {
                Logger.GuardarError(ex, "CargarTitulosIncidentes");
                MessageBox.Show("No se pudo cargar el catálogo de incidentes.");
            }
        }

        private void CargarMunicipios()
        {
            cboMunicipio.Items.Clear();

            string[] municipios =
            {
                "Guadalajara",
                "Zapopan",
                "Tonalá",
                "San Pedro Tlaquepaque",
                "Tlajomulco de Zúñiga",
                "El Salto",
                "Juanacatlán",
                "Ixtlahuacán de los Membrillos",
                "Acatic",
                "Acatlán de Juárez",
                "Ahualulco de Mercado",
                "Amacueca",
                "Amatitán",
                "Ameca",
                "San Juanito de Escobedo",
                "Arandas",
                "El Arenal",
                "Atemajac de Brizuela",
                "Atengo",
                "Atenguillo",
                "Atotonilco el Alto",
                "Atoyac",
                "Autlán de Navarro",
                "Ayotlán",
                "Ayutla",
                "La Barca",
                "Bolaños",
                "Cabo Corrientes",
                "Casimiro Castillo",
                "Cihuatlán",
                "Zapotlán el Grande",
                "San Gabriel",
                "Cocula",
                "Colotlán",
                "Concepción de Buenos Aires",
                "Cuautitlán de García Barragán",
                "Cuautla",
                "Cuquío",
                "Chapala",
                "Chimaltitán",
                "Chiquilistlán",
                "Degollado",
                "Ejutla",
                "Encarnación de Díaz",
                "Etzatlán",
                "Gómez Farías",
                "Hostotipaquillo",
                "Huejúcar",
                "Huejuquilla el Alto",
                "La Huerta",
                "Ixtlahuacán del Río",
                "Jalostotitlán",
                "Jamay",
                "Jesús María",
                "Jilotlán de los Dolores",
                "Jocotepec",
                "Lagos de Moreno",
                "El Limón",
                "Magdalena",
                "Santa María del Oro",
                "La Manzanilla de la Paz",
                "Mascota",
                "Mazamitla",
                "Mexticacán",
                "Mezquitic",
                "Mixtlán",
                "Ocotlán",
                "Ojuelos de Jalisco",
                "Pihuamo",
                "Poncitlán",
                "Puerto Vallarta",
                "Villa Purificación",
                "Quitupan",
                "San Cristóbal de la Barranca",
                "San Diego de Alejandría",
                "San Juan de los Lagos",
                "San Julián",
                "San Marcos",
                "San Martín de Bolaños",
                "San Martín Hidalgo",
                "San Miguel el Alto",
                "San Sebastián del Oeste",
                "Santa María de los Ángeles",
                "Sayula",
                "Tala",
                "Talpa de Allende",
                "Tamazula de Gordiano",
                "Tapalpa",
                "Tecalitlán",
                "Tecolotlán",
                "Techaluta de Montenegro",
                "Tenamaxtlán",
                "Teocaltiche",
                "Teocuitatlán de Corona",
                "Tepatitlán de Morelos",
                "Tequila",
                "Teuchitlán",
                "Tizapán el Alto",
                "Tolimán",
                "Tomatlán",
                "Tonaya",
                "Tonila",
                "Totatiche",
                "Tototlán",
                "Tuxcacuesco",
                "Tuxcueca",
                "Tuxpan",
                "Unión de San Antonio",
                "Unión de Tula",
                "Valle de Guadalupe",
                "Valle de Juárez",
                "Villa Corona",
                "Villa Guerrero",
                "Villa Hidalgo",
                "Cañadas de Obregón",
                "Yahualica de González Gallo",
                "Zacoalco de Torres",
                "Zapotiltic",
                "Zapotitlán de Vadillo",
                "Zapotlán del Rey",
                "Zapotlanejo",
                "San Ignacio Cerro Gordo"
            };

            cboMunicipio.Items.AddRange(municipios);

            cboMunicipio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboMunicipio.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMunicipio.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActivarCorrectorEnNovedad()
        {
            txtNovedadWpf = new System.Windows.Controls.TextBox();

            txtNovedadWpf.AcceptsReturn = true;
            txtNovedadWpf.TextWrapping =
                System.Windows.TextWrapping.Wrap;

            txtNovedadWpf.VerticalScrollBarVisibility =
                ScrollBarVisibility.Auto;

            try
            {
                SpellCheck.SetIsEnabled(txtNovedadWpf, true);
            }
            catch (Exception ex)
            {
                Logger.GuardarError(ex, "FormRegistroPin");
            }

            txtNovedadWpf.Language =
                System.Windows.Markup.XmlLanguage.GetLanguage("es-MX");

            txtNovedadWpf.Background =
                new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Color.FromRgb(45, 45, 48));

            txtNovedadWpf.Foreground =
                new System.Windows.Media.SolidColorBrush(
                    System.Windows.Media.Colors.White);

            txtNovedadWpf.Text = txtNovedad.Text;

            ElementHost host = new ElementHost();

            host.Location = txtNovedad.Location;
            host.Size = txtNovedad.Size;
            host.Child = txtNovedadWpf;

            txtNovedad.Visible = false;

            this.Controls.Add(host);
            host.BringToFront();
        }

        private void cboEncabezado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboTitulo_SelectedIndexChanged(
    object sender,
    EventArgs e)
        {
            try
            {
                string tituloSeleccionado =
                    CatalogoIncidentes.LimpiarTituloParaPin(
                        cboTitulo.Text);

                if (plantillas.ContainsKey(tituloSeleccionado))
                {
                    if (string.IsNullOrWhiteSpace(txtNovedadWpf.Text))
                    {
                        txtNovedadWpf.Text =
                            plantillas[tituloSeleccionado];
                    }
                    else
                    {
                        DialogResult resultado =
                            MessageBox.Show(
                                "Ya existe texto en la narrativa. ¿Deseas reemplazarlo por la plantilla?",
                                "Plantilla",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            txtNovedadWpf.Text =
                                plantillas[tituloSeleccionado];
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
}