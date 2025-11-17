using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyRegistroAsistencia
{
    public partial class SubFrmAjustes : Form
    {

        string conexionString = "server=localhost; database=AsistenciaUniversitaria; uid=root; pwd=123456;";
        string rutaImagenSeleccionada = "";

        public SubFrmAjustes()
        {
            InitializeComponent();
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaImagenSeleccionada = openFileDialog1.FileName;
                picImagenEvento.Image = Image.FromFile(rutaImagenSeleccionada);
                picImagenEvento.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void SubFrmAjustes_Load(object sender, EventArgs e)
        {
            CargarEventos();
           CargarConfiguracionActual();
        }

        private void CargarConfiguracionActual()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "SELECT ruta_imagen FROM Configuracion LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string rutaImagen = result.ToString();

                        if (File.Exists(rutaImagen))
                        {
                            picImagenEvento.Image = Image.FromFile(rutaImagen);
                            picImagenEvento.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar configuración: " + ex.Message);
            }
        }

        private void CargarEventos()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "SELECT id_evento, nombre FROM Evento ORDER BY fecha_inicio DESC;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbEventoPrincipal.DataSource = dt;
                    cmbEventoPrincipal.DisplayMember = "nombre";
                    cmbEventoPrincipal.ValueMember = "id_evento";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar eventos: " + ex.Message);
            }
        }



        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (cmbEventoPrincipal.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un evento.");
                return;
            }

            int idEvento = Convert.ToInt32(cmbEventoPrincipal.SelectedValue);

            try
            {
                string carpetaImg = Path.Combine(Application.StartupPath, "img");
                if (!Directory.Exists(carpetaImg))
                    Directory.CreateDirectory(carpetaImg);

                string rutaDestino = rutaImagenSeleccionada;

                // Si se seleccionó una nueva imagen, la copiamos
                if (!string.IsNullOrEmpty(rutaImagenSeleccionada) && File.Exists(rutaImagenSeleccionada))
                {
                    string nombreArchivo = $"evento_{idEvento}_" +
                        DateTime.Now.ToString("yyyyMMdd_HHmmss") +
                        Path.GetExtension(rutaImagenSeleccionada);

                    rutaDestino = Path.Combine(carpetaImg, nombreArchivo);

                    File.Copy(rutaImagenSeleccionada, rutaDestino, true);
                }

                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();

                    string updateQuery = "UPDATE Evento SET imagen = @img WHERE id_evento = @id;";
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conexion);
                    cmd.Parameters.AddWithValue("@img", rutaDestino);
                    cmd.Parameters.AddWithValue("@id", idEvento);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Imagen del evento actualizada correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen del evento: " + ex.Message);
            }
        }
    }
}
