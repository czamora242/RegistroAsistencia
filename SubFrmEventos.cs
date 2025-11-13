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
    public partial class SubFrmEventos : Form
    {

        // 🔗 Cadena de conexión a la base de datos
        string conexionString = "server=localhost;database=AsistenciaUniversitaria;user=root;password=123456;";

        // Variable para guardar el id del evento seleccionado
        int idSeleccionado = -1;

        public SubFrmEventos()
        {
            InitializeComponent();
        }

        private void SubFrmEventos_Load(object sender, EventArgs e)
        {
            CargarFacultades();
            CargarEventos();
            LimpiarCampos();
        }

        private void CargarFacultades()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT id_facultad, nombre FROM Facultad", conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbFacultad.DataSource = dt;
                    cmbFacultad.DisplayMember = "nombre";
                    cmbFacultad.ValueMember = "id_facultad";
                    cmbFacultad.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar facultades: " + ex.Message);
            }
        }

        private void CargarEventos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexionString))
                {
                    conn.Open();

                    // 👇 Solo traemos las columnas que nos interesan
                    string sql = @"SELECT 
                            e.id_evento,
                            e.nombre AS 'Nombre del Evento',
                            e.fecha_inicio AS 'Fecha de Inicio',
                            e.tipo_evento AS 'Tipo de Evento'
                           FROM Evento e";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvEventos.DataSource = dt;

                    // 👇 Ajustes visuales del DataGrid
                    dgvEventos.Columns["id_evento"].Visible = false; // ocultar ID interno
                    dgvEventos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvEventos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvEventos.MultiSelect = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar eventos: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || cmbFacultad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Nombre y Facultad).");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Evento (nombre, descripcion, fecha_inicio, fecha_fin, lugar, tipo_evento, id_facultad)
                                   VALUES (@nombre, @descripcion, @fi, @ff, @lugar, @tipo, @facultad)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@fi", dtpInicio.Value);
                    cmd.Parameters.AddWithValue("@ff", dtpFin.Value);
                    cmd.Parameters.AddWithValue("@lugar", txtLugar.Text);
                    cmd.Parameters.AddWithValue("@tipo", txtTipoEvento.Text);
                    cmd.Parameters.AddWithValue("@facultad", cmbFacultad.SelectedValue);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Evento agregado correctamente.");
                    CargarEventos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar evento: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un evento para editar.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexionString))
                {
                    conn.Open();
                    string sql = @"UPDATE Evento SET nombre=@nombre, descripcion=@descripcion, fecha_inicio=@fi, 
                                   fecha_fin=@ff, lugar=@lugar, tipo_evento=@tipo, id_facultad=@facultad
                                   WHERE id_evento=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("@fi", dtpInicio.Value);
                    cmd.Parameters.AddWithValue("@ff", dtpFin.Value);
                    cmd.Parameters.AddWithValue("@lugar", txtLugar.Text);
                    cmd.Parameters.AddWithValue("@tipo", txtTipoEvento.Text);
                    cmd.Parameters.AddWithValue("@facultad", cmbFacultad.SelectedValue);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Evento actualizado correctamente.");
                    CargarEventos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar evento: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Seleccione un evento para eliminar.");
                return;
            }

            DialogResult dr = MessageBox.Show("¿Seguro que desea eliminar este evento?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM Evento WHERE id_evento=@id", conn);
                    cmd.Parameters.AddWithValue("@id", idSeleccionado);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Evento eliminado correctamente.");
                    CargarEventos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar evento: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtLugar.Text = "Centro Cultural “TILSA TSUCHIYA CASTILLO”";
            txtTipoEvento.Clear();
            dtpInicio.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;
            cmbFacultad.SelectedIndex = -1;
            idSeleccionado = -1;
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 🔒 Verificar que el clic sea en una fila válida con datos
            if (e.RowIndex < 0 || dgvEventos.Rows.Count == 0)
                return;

            DataGridViewRow fila = dgvEventos.Rows[e.RowIndex];

            // 🧩 Verificar que la fila tenga un valor válido de ID
            if (fila.Cells["id_evento"].Value == null || fila.Cells["id_evento"].Value == DBNull.Value)
                return;

            idSeleccionado = Convert.ToInt32(fila.Cells["id_evento"].Value);

            // 🔁 Cargar los datos completos del evento seleccionado
            CargarEventoPorId(idSeleccionado);
        }

        private void CargarEventoPorId(int idEvento)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Evento WHERE id_evento = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idEvento);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtNombre.Text = dr["nombre"].ToString();
                        txtDescripcion.Text = dr["descripcion"].ToString();
                        dtpInicio.Value = Convert.ToDateTime(dr["fecha_inicio"]);
                        dtpFin.Value = Convert.ToDateTime(dr["fecha_fin"]);
                        txtLugar.Text = dr["lugar"].ToString();
                        txtTipoEvento.Text = dr["tipo_evento"].ToString();
                        cmbFacultad.SelectedValue = dr["id_facultad"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar evento seleccionado: " + ex.Message);
            }
        }

    }
}
