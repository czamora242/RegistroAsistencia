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
            openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
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

        private void CargarConfiguracionActual()
        {
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = "SELECT id_evento_actual, ruta_imagen FROM Configuracion LIMIT 1;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        if (!dr.IsDBNull(0))
                            cmbEventoPrincipal.SelectedValue = dr.GetInt32("id_evento_actual");

                        if (!dr.IsDBNull(1))
                        {
                            string rutaImagen = dr.GetString("ruta_imagen");
                            if (File.Exists(rutaImagen))
                            {
                                picImagenEvento.Image = Image.FromFile(rutaImagen);
                                picImagenEvento.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar configuración: " + ex.Message);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (cmbEventoPrincipal.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un evento antes de guardar.");
                return;
            }

            try
            {
                // === 1. Crear carpeta img si no existe ===
                string carpetaImg = Path.Combine(Application.StartupPath, "img");
                if (!Directory.Exists(carpetaImg))
                    Directory.CreateDirectory(carpetaImg);

                // === 2. Guardar imagen seleccionada en la carpeta ===
                string rutaDestino = "";
                if (!string.IsNullOrEmpty(rutaImagenSeleccionada))
                {
                    string nombreArchivo = "ajuste_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + Path.GetExtension(rutaImagenSeleccionada);
                    rutaDestino = Path.Combine(carpetaImg, nombreArchivo);
                    File.Copy(rutaImagenSeleccionada, rutaDestino, true);
                }

                int idEvento = Convert.ToInt32(cmbEventoPrincipal.SelectedValue);

                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();

                    // === 3. Verificar si hay registro existente ===
                    string checkQuery = "SELECT COUNT(*) FROM Configuracion;";
                    MySqlCommand cmdCheck = new MySqlCommand(checkQuery, conexion);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (count == 0)
                    {
                        // === Insertar nuevo ===
                        string insertQuery = "INSERT INTO Configuracion (id_evento_actual, ruta_imagen) VALUES (@id, @ruta);";
                        MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conexion);
                        cmdInsert.Parameters.AddWithValue("@id", idEvento);
                        cmdInsert.Parameters.AddWithValue("@ruta", rutaDestino);
                        cmdInsert.ExecuteNonQuery();
                    }
                    else
                    {
                        // === Actualizar existente ===
                        string updateQuery = "UPDATE Configuracion SET id_evento_actual = @id, ruta_imagen = @ruta LIMIT 1;";
                        MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conexion);
                        cmdUpdate.Parameters.AddWithValue("@id", idEvento);
                        cmdUpdate.Parameters.AddWithValue("@ruta", rutaDestino);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Configuración guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
