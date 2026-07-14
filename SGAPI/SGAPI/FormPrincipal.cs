using SGAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SGAPI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosPanel();

            // mostrar usuario activo
            lblUsuario.Text = "Usuario: " + Sesion.UsuarioActual;

            // mostrar último respaldo
            lblBackup.Text =
                "Último respaldo: " +
                BackupHelper.ObtenerUltimoBackup();
        }

        private void CargarDatosPanel()
        {
            string fechaHoy = DateTime.Now.ToString("dd/MM/yyyy");

            int totalHoy = BaseDatos.Pines.FindAll(
                p => p.Fecha == fechaHoy).Count;

            int preliminares = BaseDatos.Pines.FindAll(
                p => p.Fecha == fechaHoy &&
                p.Estado == "Preliminar").Count;

            int actualizacion = BaseDatos.Pines.FindAll(
                p => p.Fecha == fechaHoy &&
                p.Estado == "Actualizacion").Count;

            int conclusion = BaseDatos.Pines.FindAll(
                p => p.Fecha == fechaHoy &&
                p.Estado == "Conclusion").Count;

            int informativo = BaseDatos.Pines.FindAll(
                p => p.Fecha == fechaHoy &&
                p.Estado == "Informativo").Count;

            lblPinesHoy.Text = totalHoy.ToString();

            lblEstadoHoy.Text =
                "----------Estado de Pines de hoy----------\r\n\n" +
                $"Preliminares: {preliminares}\r\n" +
                $"En actualización: {actualizacion}\r\n" +
                $"Concluidos: {conclusion}\r\n" +
                $"Informativos: {informativo}";

            lstActividad.Items.Clear();

            foreach (PinInformativo pin in BaseDatos.Pines)
            {
                if (pin.Fecha == fechaHoy)
                {
                    lstActividad.Items.Add(
                        $"Rep.-{pin.NumeroReporte} de CEIPOL - {pin.Estado} - {pin.Hora} horas"
                    );
                }
            }
        }

        private void btnNuevoPin_Click(object sender, EventArgs e)
        {
            FormRegistroPin registro = new FormRegistroPin();
            registro.ShowDialog();
            CargarDatosPanel();
        }

        private void btnActualizarPin_Click(object sender, EventArgs e)
        {
            FormActualizaciones form = new FormActualizaciones();
            form.ShowDialog();
            CargarDatosPanel();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            FormHistorial form = new FormHistorial();
            form.ShowDialog();
            CargarDatosPanel();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.ShowDialog();
            CargarDatosPanel();
        }

        private void panelEstadoHoy_Click(object sender, EventArgs e)
        {

        }

        private void lblEstadoHoy_Click(object sender, EventArgs e)
        {

        }

            private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show(
                "¿Seguro que deseas restaurar un respaldo?\n\n" +
                "Los datos actuales serán reemplazados por el respaldo seleccionado.",
                "Restaurar respaldo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmar != DialogResult.Yes)
            {
                return;
            }

            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Seleccionar respaldo SGAPI";
            open.Filter = "Base de datos SQLite (*.db)|*.db";
            open.InitialDirectory = Path.Combine(
                Application.StartupPath,
                "Datos",
                "Backups"
            );

            if (open.ShowDialog() == DialogResult.OK)
            {
                bool restaurado = BackupHelper.RestaurarBackup(open.FileName);

                if (restaurado)
                {
                    BaseDatos.Pines = BaseDatosSQLite.CargarPines();

                    MessageBox.Show(
                        "Respaldo restaurado correctamente.\n\nReinicia SGAPI para asegurar que todos los módulos se actualicen.",
                        "SGAPI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo restaurar el respaldo.",
                        "SGAPI",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
    }

