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
        string conexion = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";

        public SubFrmMarcar()
        {
            InitializeComponent();
        }

        private void SubFrmMarcar_Load(object sender, EventArgs e)
        {
            CargarAsistencias();
            dgvAsistencias.DataBindingComplete += DgvAsistencias_DataBindingComplete;
        }

        //Carga asistencias y marca todas como "No asistió" inicialmente
        private void CargarAsistencias()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = @"SELECT 
                    p.id_persona AS 'ID',
                    p.documento AS 'DNI',
                    CONCAT(p.nombres, ' ', p.apellidos) AS 'Nombre',
                    'No asistió' AS 'Estado'
                FROM Persona p
                ORDER BY p.nombres, p.apellidos;";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAsistencias.DataSource = dt;

                    // Numerar filas
                    foreach (DataGridViewRow row in dgvAsistencias.Rows)
                    {
                        row.HeaderCell.Value = (row.Index + 1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar asistencias: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Pinta las celdas "No asistió" de rojo
        private void DgvAsistencias_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAsistencias.Rows)
            {
                string estado = row.Cells["Estado"].Value?.ToString();
                if (estado == "No asistió")
                {
                    row.Cells["Estado"].Style.BackColor = Color.Red;
                    row.Cells["Estado"].Style.ForeColor = Color.White;
                }
            }
        }

        //Botón marcar asistencia
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            string documento = txtDni.Text.Trim();

            if (string.IsNullOrEmpty(documento))
            {
                lblResultado.ForeColor = Color.OrangeRed;
                lblResultado.Text = "⚠️ Ingrese el documento (DNI).";
                return;
            }

            try
            {
                bool encontrado = false;

                foreach (DataGridViewRow row in dgvAsistencias.Rows)
                {
                    string dniFila = row.Cells["DNI"].Value.ToString();

                    if (dniFila == documento)
                    {
                        encontrado = true;

                        string estadoActual = row.Cells["Estado"].Value.ToString();

                        if (estadoActual == "Asistió")
                        {
                            lblResultado.ForeColor = Color.Orange;
                            lblResultado.Text = "⚠️ Esta persona ya fue marcada como presente.";
                            return;
                        }

                        //Cambiar solo esa celda a verde
                        row.Cells["Estado"].Value = "Asistió";
                        row.Cells["Estado"].Style.BackColor = Color.Green;
                        row.Cells["Estado"].Style.ForeColor = Color.White;

                        lblResultado.ForeColor = Color.Green;
                        lblResultado.Text = "✅ Asistencia registrada correctamente.";

                        txtDni.Clear();
                        txtDni.Focus();
                        break;
                    }
                }

                if (!encontrado)
                {
                    lblResultado.ForeColor = Color.Red;
                    lblResultado.Text = "❌ El DNI ingresado no existe en la lista.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al marcar asistencia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}