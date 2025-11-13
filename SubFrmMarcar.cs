using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pyRegistroAsistencia
{
    public partial class SubFrmMarcar : Form
    {
        // usa tu cadena definitiva
        string conexion = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";

        public SubFrmMarcar()
        {
            InitializeComponent();
        }

        // Al cargar el formulario se muestran personas y asistencias
        private void SubFrmMarcar_Load(object sender, EventArgs e)
        {
            CargarPersonas();
            CargarAsistencias();
        }

        // Carga la lista de personas en dgvPersonas
        private void CargarPersonas()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = @"
                        SELECT 
                            id_persona AS 'ID',
                            documento AS 'DNI',
                            CONCAT(nombres, ' ', apellidos) AS 'Nombre'
                        FROM Persona
                        ORDER BY nombres, apellidos;";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPersonas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar personas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Carga la lista de asistencias en dgvAsistencias
        private void CargarAsistencias()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = @"
                        SELECT 
                            a.id_asistencia AS 'ID',
                            p.documento AS 'DNI',
                            CONCAT(p.nombres, ' ', p.apellidos) AS 'Nombre Completo',
                            e.nombre AS 'Evento',
                            a.estado AS 'Estado',
                            DATE_FORMAT(a.fecha_registro, '%d/%m/%Y %H:%i:%s') AS 'Fecha y Hora'
                        FROM Asistencia a
                        LEFT JOIN Persona p ON a.id_persona = p.id_persona
                        LEFT JOIN Evento e ON a.id_evento = e.id_evento
                        ORDER BY a.fecha_registro DESC;";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAsistencias.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asistencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón marcar: verifica si existe la persona y registra asistencia
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            string documento = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Ingrese el documento (DNI).", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    // 1) Buscar id_persona por documento
                    string sqlPersona = "SELECT id_persona, CONCAT(nombres,' ',apellidos) AS nombre FROM Persona WHERE documento = @doc LIMIT 1;";
                    using (MySqlCommand cmd = new MySqlCommand(sqlPersona, conn))
                    {
                        cmd.Parameters.AddWithValue("@doc", documento);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                lblResultado.ForeColor = Color.Red;
                                lblResultado.Text = "❌ DNI no registrado en Persona.";
                                return;
                            }

                            int idPersona = reader.GetInt32("id_persona");
                            string nombrePersona = reader.GetString("nombre");
                            reader.Close();

                            // 2) Verificar si ya registró asistencia hoy para evitar duplicados (opcional)
                            string sqlVerifica = @"SELECT COUNT(*) FROM Asistencia 
                                                   WHERE id_persona = @idPersona 
                                                   AND DATE(fecha_registro) = CURDATE()
                                                   AND id_evento = 1;"; // si manejas evento dinámico cambia el 1
                            using (MySqlCommand cmdVer = new MySqlCommand(sqlVerifica, conn))
                            {
                                cmdVer.Parameters.AddWithValue("@idPersona", idPersona);
                                int count = Convert.ToInt32(cmdVer.ExecuteScalar());
                                if (count > 0)
                                {
                                    lblResultado.ForeColor = Color.Orange;
                                    lblResultado.Text = $"⚠️ {nombrePersona} ya registró asistencia hoy.";
                                    return;
                                }
                            }

                            // 3) Insertar en Asistencia — usar exactamente los valores válidos del enum (tu DB usa 'Asistió'/'No Asistió')
                            string sqlInsert = @"INSERT INTO Asistencia (id_persona, id_evento, estado, fecha_registro)
                                                 VALUES (@idPersona, @idEvento, @estado, NOW());";
                            using (MySqlCommand cmdIns = new MySqlCommand(sqlInsert, conn))
                            {
                                cmdIns.Parameters.AddWithValue("@idPersona", idPersona);
                                cmdIns.Parameters.AddWithValue("@idEvento", 1); // cambiar si manejas evento seleccionado
                                cmdIns.Parameters.AddWithValue("@estado", "Asistió"); // usar valor válido según tu ENUM
                                cmdIns.ExecuteNonQuery();
                            }

                            lblResultado.ForeColor = Color.Green;
                            lblResultado.Text = $"✅ Asistencia registrada: {nombrePersona}";

                            // refrescar vistas
                            CargarAsistencias();
                            CargarPersonas(); // opcional: refresca lista de personas si hay cambios
                            txtDni.Clear();
                            txtDni.Focus();
                        }
                    }
                }
            }
            catch (MySqlException mex)
            {
                MessageBox.Show("Error MySQL: " + mex.Message, "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
