using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Crypto.Generators;
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
    public partial class SubFrmCrearUsuario : Form
    {
        private readonly string cadenaConexion = "server=localhost;database=AsistenciaUniversitaria;user=root;pwd=123456;";
        private Button botonActivo = null;

        public SubFrmCrearUsuario()
        {
            InitializeComponent();
            CargarUsuarios();

            cmbRol.Items.AddRange(new string[] { "Administrador", "Registrador", "Consultor" });
            cmbEstado.Items.AddRange(new string[] { "Activo", "Inactivo" });
            cmbRol.SelectedIndex = 0;

            // Eventos para los botones de filtro
            btnTodos.Click += btnTodos_Click;
            btnAdministrador.Click += btnAdministrador_Click;
            btnRegistrador.Click += btnRegistrador_Click;
            btnConsultor.Click += btnConsultor_Click;

            // Color inicial del botón “TODOS”
            botonActivo = btnTodos;
            ResaltarBoton(btnTodos);
        }

        // --- BOTONES DE FILTRO ---
        private void btnTodos_Click(object sender, EventArgs e)
        {
            CargarUsuarios("TODOS");
            ResaltarBoton(btnTodos);
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            CargarUsuarios("Administrador");
            ResaltarBoton(btnAdministrador);
        }

        private void btnRegistrador_Click(object sender, EventArgs e)
        {
            CargarUsuarios("Registrador");
            ResaltarBoton(btnRegistrador);
        }

        private void btnConsultor_Click(object sender, EventArgs e)
        {
            CargarUsuarios("Consultor");
            ResaltarBoton(btnConsultor);
        }

        // --- MÉTODO PARA CAMBIAR COLOR DE BOTÓN ACTIVO ---
        private void ResaltarBoton(Button boton)
        {
            // Restaurar el color de los demás botones
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && (btn == btnTodos || btn == btnAdministrador || btn == btnRegistrador || btn == btnConsultor))
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }
            }

            // Resaltar el botón seleccionado
            boton.BackColor = Color.FromArgb(51, 102, 204); // azul
            boton.ForeColor = Color.White;
            botonActivo = boton;
        }

        // --- GUARDAR USUARIO ---
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();
            string rol = cmbRol.SelectedItem?.ToString() ?? "";
            string estado = cmbEstado.SelectedItem.ToString() ?? "" ;

            if (usuario == "" || clave == "" || rol == "")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = @"INSERT INTO usuariosistema (usuario, clave, rol, estado)
                       VALUES (@usuario, @clave, @rol, @estado)";

                MySqlCommand cmd = new MySqlCommand(sql, conexion);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@clave", clave);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@estado", estado);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Usuario creado correctamente.");
            LimpiarCampos();
            CargarUsuarios();
        }


        // --- ACTUALIZAR USUARIO ---

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            int id_usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id_usuario"].Value);
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();
            string rol = cmbRol.SelectedItem.ToString();
            string estado = cmbEstado.SelectedItem.ToString();

            string sql = "UPDATE usuariosistema SET usuario=@usuario, rol=@rol, estado=@estado WHERE id_usuario=@id";

            string sqlFinal = clave != "" ? string.Format(sql, ", clave=@clave") : string.Format(sql, "");

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(sqlFinal, conexion);

                cmd.Parameters.AddWithValue("@id", id_usuario);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@estado", estado);
               

                if (clave != "")
                    cmd.Parameters.AddWithValue("@clave", clave);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Usuario actualizado.");
            LimpiarCampos();
            CargarUsuarios();
        }


        // --- CARGAR USUARIOS ---
        private void CargarUsuarios(string filtroRol = "TODOS")
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "SELECT id_usuario, usuario, clave, rol, estado, fecha_creacion FROM usuariosistema";

                if (filtroRol != "TODOS")
                    sql += " WHERE rol = @rol";

                using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                {
                    if (filtroRol != "TODOS")
                        cmd.Parameters.AddWithValue("@rol", filtroRol);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUsuarios.DataSource = dt;
                    }
                }
            }
        }

        // --- LIMPIAR CAMPOS ---
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtClave.Clear();
            cmbRol.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            dgvUsuarios.ClearSelection();
        }

        // --- AL SELECCIONAR UNA FILA ---
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
            txtClave.Text = dgvUsuarios.Rows[e.RowIndex].Cells["clave"].Value.ToString();
            cmbRol.Text = dgvUsuarios.Rows[e.RowIndex].Cells["rol"].Value.ToString();
            cmbEstado.Text = dgvUsuarios.Rows[e.RowIndex].Cells["estado"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id_usuario"].Value);

            DialogResult dr = MessageBox.Show("¿Seguro que deseas eliminar este usuario?",
                                              "Confirmación",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Warning);

            if (dr == DialogResult.No) return;

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "DELETE FROM usuariosistema WHERE id_usuario=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuario eliminado correctamente.");
            CargarUsuarios();
        }

    }
}
