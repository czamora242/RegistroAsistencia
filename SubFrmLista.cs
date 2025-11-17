using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pyRegistroAsistencia
{
    public partial class SubFrmLista : Form
    {
        //Conexión a tu base de datos MySQL
        string conexion = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";

        public SubFrmLista()
        {
            InitializeComponent();
        }

        //Evento al cargar el formulario
        private void SubFrmLista_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        //Cargar toda la lista de asistentes
        private void CargarDatos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.documento AS 'DNI',
                            CONCAT(p.nombres, ' ', p.apellidos) AS 'Nombre Completo',
                            e.nombre AS 'Evento',
                            a.estado AS 'Estado',
                            DATE_FORMAT(a.fecha_registro, '%d/%m/%Y %H:%i') AS 'Fecha de Registro'
                        FROM Asistencia a
                        INNER JOIN Persona p ON a.id_persona = p.id_persona
                        INNER JOIN Evento e ON a.id_evento = e.id_evento
                        ORDER BY a.fecha_registro DESC;";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);

                    dgvLista.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Buscar por nombre o DNI en tiempo real
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (texto == "")
            {
                CargarDatos();
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            p.documento AS 'DNI',
                            CONCAT(p.nombres, ' ', p.apellidos) AS 'Nombre Completo',
                            e.nombre AS 'Evento',
                            a.estado AS 'Estado',
                            DATE_FORMAT(a.fecha_registro, '%d/%m/%Y %H:%i') AS 'Fecha de Registro'
                        FROM Asistencia a
                        INNER JOIN Persona p ON a.id_persona = p.id_persona
                        INNER JOIN Evento e ON a.id_evento = e.id_evento
                        WHERE p.documento LIKE @texto 
                           OR p.nombres LIKE @texto 
                           OR p.apellidos LIKE @texto
                        ORDER BY a.fecha_registro DESC;";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@texto", "%" + texto + "%");

                    DataTable tabla = new DataTable();
                    da.Fill(tabla);

                    dgvLista.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Botón para recargar todo
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarDatos();
        }

        private void SubFrmLista_Load_1(object sender, EventArgs e)
        {

        }
    }
}
