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
    public partial class SubFrmInicio : Form
    {

        string conexionString = "server=localhost; database=AsistenciaUniversitaria; uid=root; pwd=123456;"; // ajusta tus datos


        public SubFrmInicio()
        {
            InitializeComponent();
        }

        private int ObtenerCantidadAsistentesPorId(int idEvento)
        {
            int cantidad = 0;
            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = @"SELECT COUNT(a.id_asistencia)
                                     FROM Asistencia a
                                     WHERE a.id_evento = @idEvento AND a.estado = 'Asistió';";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@idEvento", idEvento);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        cantidad = Convert.ToInt32(result);
                }
            }
            catch
            {
                // opcional: log del error
                cantidad = 0;
            }

            return cantidad;
        }

        private class ConfiguracionDto
        {
            public int? IdEvento { get; set; }
            public string NombreEvento { get; set; }
            public string RutaImagen { get; set; }
        }

        // Devuelve la configuración (si existe). Si no, devuelve nulls en las propiedades.
        private ConfiguracionDto ObtenerConfiguracion()
        {
            var cfg = new ConfiguracionDto
            {
                IdEvento = null,
                NombreEvento = "Sin evento configurado",
                RutaImagen = null
            };

            try
            {
                using (MySqlConnection conexion = new MySqlConnection(conexionString))
                {
                    conexion.Open();
                    string query = @"SELECT c.id_evento_actual, e.nombre AS nombre_evento, c.ruta_imagen
                                     FROM Configuracion c
                                     LEFT JOIN Evento e ON e.id_evento = c.id_evento_actual
                                     LIMIT 1;";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            if (!dr.IsDBNull(dr.GetOrdinal("id_evento_actual")))
                                cfg.IdEvento = dr.GetInt32("id_evento_actual");

                            if (!dr.IsDBNull(dr.GetOrdinal("nombre_evento")))
                                cfg.NombreEvento = dr.GetString("nombre_evento");

                            if (!dr.IsDBNull(dr.GetOrdinal("ruta_imagen")))
                                cfg.RutaImagen = dr.GetString("ruta_imagen");
                        }
                    }
                }
            }
            catch
            {
                // opcional: log
            }

            return cfg;
        }

        // Carga imagen desde archivo de forma segura (evita bloqueo)
        private void CargarImagenEnPictureBox(string ruta, PictureBox pic)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ruta) || !File.Exists(ruta))
                {
                    pic.Image = null;
                    return;
                }

                using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        fs.CopyTo(ms);
                        ms.Position = 0;
                        Image img = Image.FromStream(ms);
                        pic.Image = (Image)img.Clone(); // clonar para asegurarnos independencia del stream
                    }
                }
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                pic.Image = null;
            }
        }



        private void SubFrmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                var cfg = ObtenerConfiguracion();

                // Título / nombre del evento
                lblTituloEvento.Text = "Evento actual: " + (cfg?.NombreEvento ?? "Sin evento configurado");

                // Si hay un evento configurado, obtener asistentes por id
                if (cfg != null && cfg.IdEvento.HasValue)
                {
                    int asistentes = ObtenerCantidadAsistentesPorId(cfg.IdEvento.Value);
                    lblCantidadAsistentes.Text = $"Asistentes registrados: {asistentes}";
                }
                else
                {
                    lblCantidadAsistentes.Text = "Asistentes registrados: 0";
                }

                // Cargar imagen configurada si existe; si no, intentar imagen por defecto
                bool cargada = false;
                if (cfg != null && !string.IsNullOrWhiteSpace(cfg.RutaImagen))
                {
                    CargarImagenEnPictureBox(cfg.RutaImagen, picImagenEvento);
                    if (picImagenEvento.Image != null) cargada = true;
                }

                if (!cargada)
                {
                    // buscar imagen por defecto en carpeta img\default.jpg dentro del proyecto
                    string rutaDefault = Path.Combine(Application.StartupPath, "img", "default.jpg");
                    if (File.Exists(rutaDefault))
                    {
                        CargarImagenEnPictureBox(rutaDefault, picImagenEvento);
                    }
                    else
                    {
                        // alternativa: intenta recursos internos si tienes uno (uncomment si existe)
                        // picImagenEvento.Image = Properties.Resources.fondo_evento;
                        picImagenEvento.Image = null; // o deja en null si no tienes recurso
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar inicio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
