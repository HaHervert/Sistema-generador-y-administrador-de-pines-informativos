using System;
using System.Drawing;
using System.Windows.Forms;

namespace SGAPI
{
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            // limpiar opciones
            cboEstadoFiltro.Items.Clear();

            // estados disponibles
            cboEstadoFiltro.Items.Add("Todos");
            cboEstadoFiltro.Items.Add("Preliminar");
            cboEstadoFiltro.Items.Add("Actualizacion");
            cboEstadoFiltro.Items.Add("Conclusion");
            cboEstadoFiltro.Items.Add("Informativo");

            cboEstadoFiltro.SelectedIndex = 0;

            // limpiar columnas
            dgvHistorial.Columns.Clear();

            // crear columnas
            dgvHistorial.Columns.Add("Usuario", "Usuario");
            dgvHistorial.Columns.Add("Hora", "Hora");
            dgvHistorial.Columns.Add("Fecha", "Fecha");
            dgvHistorial.Columns.Add("Reporte", "Reporte");
            dgvHistorial.Columns.Add("Municipio", "Municipio");
            dgvHistorial.Columns.Add("Titulo", "Título");
            dgvHistorial.Columns.Add("Estado", "Estado");
            dgvHistorial.Columns.Add("Actualizaciones", "Actualizaciones");
            dgvHistorial.Columns.Add("EditarDatos", "Editar datos");
            dgvHistorial.Columns.Add("Acciones", "Editar texto");
            dgvHistorial.Columns.Add("Eliminar", "Eliminar");

            // colores y estilo
            dgvHistorial.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.GridColor = Color.FromArgb(63, 63, 70);

            dgvHistorial.EnableHeadersVisualStyles = false;

            dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgvHistorial.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dgvHistorial.DefaultCellStyle.ForeColor = Color.White;
            dgvHistorial.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 90, 158);
            dgvHistorial.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvHistorial.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 40);

            dgvHistorial.RowHeadersVisible = false;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.ReadOnly = true;

            dgvHistorial.RowTemplate.Height = 28;
            dgvHistorial.ColumnHeadersHeight = 36;
        }

        private void btnBuscarHistorial_Click(object sender, EventArgs e)
        {
            // limpiar tabla
            dgvHistorial.Rows.Clear();

            // recorrer todos los pines
            foreach (PinInformativo pin in BaseDatos.Pines)
            {
                // filtros
                bool coincideFecha =
                    string.IsNullOrWhiteSpace(txtFecha.Text) ||
                    pin.Fecha.Contains(txtFecha.Text);

                bool coincideReporte =
                    string.IsNullOrWhiteSpace(txtReporte.Text) ||
                    pin.NumeroReporte.Contains(txtReporte.Text);

                bool coincideMunicipio =
                    string.IsNullOrWhiteSpace(txtMunicipio.Text) ||
                    pin.Municipio.ToLower().Contains(txtMunicipio.Text.ToLower());

                bool coincideEstado =
                    cboEstadoFiltro.Text == "Todos" ||
                    pin.Estado == cboEstadoFiltro.Text;

                // agregar fila si coincide
                if (coincideFecha &&
                    coincideReporte &&
                    coincideMunicipio &&
                    coincideEstado)
                {
                    dgvHistorial.Rows.Add(
                        pin.UsuarioCreador,
                        pin.Hora,
                        pin.Fecha,
                        pin.NumeroReporte,
                        pin.Municipio,
                        pin.Titulo,
                        pin.Estado,
                        pin.Actualizaciones.Count,
                        "Editar datos",
                        "Editar texto",
                        "Eliminar"
                    );
                }
            }
        }

        private void dgvHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // evitar errores
            if (e.RowIndex < 0)
                return;

            // obtener número de reporte
            string numeroReporte =
                dgvHistorial.Rows[e.RowIndex]
                .Cells["Reporte"]
                .Value
                .ToString();

            // buscar pin
            PinInformativo pin =
                BaseDatos.Pines.Find(p => p.NumeroReporte == numeroReporte);

            if (pin == null)
            {
                MessageBox.Show("No se encontró el pin seleccionado.");
                return;
            }

            // eliminar pin
            if (dgvHistorial.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Seguro que deseas eliminar este pin?\n\n" +
                    "Reporte: " + pin.NumeroReporte + "\n" +
                    "Municipio: " + pin.Municipio + "\n\n" +
                    "Esta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // cancelar
                if (respuesta != DialogResult.Yes)
                {
                    return;
                }

                // eliminar de memoria
                BaseDatos.Pines.Remove(pin);

                // guardar sqlite
                BaseDatosSQLite.GuardarPines(BaseDatos.Pines);

                // quitar fila visual
                dgvHistorial.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show(
                    "Pin eliminado correctamente.",
                    "SGAPI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            // abrir editor de datos
            if (dgvHistorial.Columns[e.ColumnIndex].Name == "EditarDatos")
            {
                FormRegistroPin editorDatos = new FormRegistroPin(pin);
                editorDatos.ShowDialog();

                // actualizar tabla
                btnBuscarHistorial_Click(null, null);

                return;
            }

            // abrir editor manual
            if (dgvHistorial.Columns[e.ColumnIndex].Name == "Acciones")
            {
                FormEditorPinManual editor = new FormEditorPinManual(pin);
                editor.ShowDialog();

                return;
            }

            // usar texto manual si existe
            string pinFinal;

            if (!string.IsNullOrWhiteSpace(pin.TextoManualFinal))
            {
                pinFinal = pin.TextoManualFinal;
            }
            else
            {
                // generar texto normal
                pinFinal =
                    $"*{pin.Encabezado}*\r\n\r\n" +
                    $"{pin.Hora} horas ({pin.Estado})\r\n" +
                    $"Rep.-{pin.NumeroReporte} de CEIPOL\r\n" +
                    $"{pin.Fecha}\r\n\r\n" +
                    $"*{pin.Municipio}*\r\n\r\n" +
                    $"*{pin.Titulo}*\r\n\r\n" +
                    $"{pin.Cruce}, col. {pin.Colonia}\r\n\r\n" +
                    $"{pin.NovedadInicial}\r\n\r\n";

                // agregar actualizaciones
                foreach (string actualizacion in pin.Actualizaciones)
                {
                    pinFinal += actualizacion + "\r\n\r\n";
                }

                // agregar maps
                pinFinal += pin.Maps;
            }

            // abrir vista previa
            FormVistaPrevia vista = new FormVistaPrevia(pinFinal, pin, this);
            vista.ShowDialog();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            // cerrar ventana
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}