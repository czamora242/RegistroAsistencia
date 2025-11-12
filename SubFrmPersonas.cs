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
    public partial class SubFrmPersonas : Form
    {
        string cadenaConexion = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";
        MySqlConnection conexion;
        public SubFrmPersonas()
        {
            InitializeComponent();
            conexion = new MySqlConnection(cadenaConexion);
        }

        private void SubFrmPersonas_Load(object sender, EventArgs e)
        {
            // Aquí puedes llamar a un método para cargar los datos, por ejemplo:
            CargarPersonas();
            CargarTipos();
            CargarProgramas();
        }

        private void CargarProgramas()
        {
            string query = "SELECT id_programa, nombre FROM ProgramaAcademico";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbPrograma.DataSource = dt;
            cbPrograma.DisplayMember = "nombre";
            cbPrograma.ValueMember = "id_programa";
        }

        private void CargarTipos()
        {
            string query = "SELECT id_tipo_persona, nombre FROM TipoPersona";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbTipo.DataSource = dt;
            cbTipo.DisplayMember = "nombre";
            cbTipo.ValueMember = "id_tipo_persona";
        }



        private void CargarPersonas()
        {
            string query = @"
        SELECT p.id_persona, p.nombres, p.apellidos, p.documento, p.correo, p.telefono,
               tp.nombre AS tipo, pr.nombre AS programa
        FROM Persona p
        INNER JOIN TipoPersona tp ON p.id_tipo_persona = tp.id_tipo_persona
        LEFT JOIN PersonaPrograma pp ON p.id_persona = pp.id_persona
        LEFT JOIN ProgramaAcademico pr ON pp.id_programa = pr.id_programa";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgRegistro.DataSource = dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = @"INSERT INTO Persona (nombres, apellidos, documento, correo, telefono, id_tipo_persona)
                         VALUES (@nombres, @apellidos, @documento, @correo, @telefono, @id_tipo_persona)";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@nombres", txtNombre.Text);
                cmd.Parameters.AddWithValue("@apellidos", txtApellido.Text);
                cmd.Parameters.AddWithValue("@documento", txtDNI.Text);
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@id_tipo_persona", cbTipo.SelectedValue);

                cmd.ExecuteNonQuery();

                // Obtener el ID recién insertado para asignarle su programa
                long idPersona = cmd.LastInsertedId;

                string query2 = "INSERT INTO PersonaPrograma (id_persona, id_programa, ciclo) VALUES (@idp, @idprog, NULL)";
                MySqlCommand cmd2 = new MySqlCommand(query2, conexion);
                cmd2.Parameters.AddWithValue("@idp", idPersona);
                cmd2.Parameters.AddWithValue("@idprog", cbPrograma.SelectedValue);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Persona registrada correctamente.");
                CargarPersonas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            cbTipo.SelectedIndex = -1;
            cbPrograma.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dtgRegistro.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una persona para actualizar.");
                return;
            }

            int id = Convert.ToInt32(dtgRegistro.CurrentRow.Cells["id"].Value);

            try
            {
                conexion.Open();
                string query = "UPDATE personas SET nombres=@nombres, apellidos=@apellidos, documento=@documento, " +
                               "correo=@correo, telefono=@telefono, tipo=@tipo, programa=@programa WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombres", txtNombre.Text);
                cmd.Parameters.AddWithValue("@apellidos", txtApellido.Text);
                cmd.Parameters.AddWithValue("@documento", txtDNI.Text);
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                cmd.Parameters.AddWithValue("@tipo", cbTipo.Text);
                cmd.Parameters.AddWithValue("@programa", cbPrograma.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado correctamente.");
                CargarPersonas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgRegistro.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una persona para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dtgRegistro.CurrentRow.Cells["id"].Value);

            if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    conexion.Open();
                    string query = "DELETE FROM personas WHERE id=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Persona eliminada correctamente.");
                    CargarPersonas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
        }
    }
}
