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
            string query = @"SELECT p.id_persona, p.nombres, p.apellidos, p.documento, p.correo, p.telefono,
                     tp.nombre AS tipo, pr.nombre AS programa
                     FROM Persona p
                     INNER JOIN TipoPersona tp ON p.id_tipo_persona = tp.id_tipo_persona
                     LEFT JOIN PersonaPrograma pp ON p.id_persona = pp.id_persona
                     LEFT JOIN ProgramaAcademico pr ON pp.id_programa = pr.id_programa
                     ORDER BY p.id_persona ASC";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conexion);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dtgRegistro.AutoGenerateColumns = true;
            dtgRegistro.Columns.Clear();
            dtgRegistro.DataSource = dt;

            dtgRegistro.Columns["id_persona"].HeaderText = "ID";
            dtgRegistro.Columns["nombres"].HeaderText = "Nombres";
            dtgRegistro.Columns["apellidos"].HeaderText = "Apellidos";
            dtgRegistro.Columns["documento"].HeaderText = "Documento";
            dtgRegistro.Columns["correo"].HeaderText = "Correo";
            dtgRegistro.Columns["telefono"].HeaderText = "Teléfono";
            dtgRegistro.Columns["tipo"].HeaderText = "Tipo";
            dtgRegistro.Columns["programa"].HeaderText = "Programa";

            // Ocultar la columna ID si no quieres mostrarla
            dtgRegistro.Columns["id_persona"].Visible = true;
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
                MessageBox.Show("Selecciona una fila para actualizar.");
                return;
            }

            int idPersona;
            try
            {
                idPersona = Convert.ToInt32(dtgRegistro.CurrentRow.Cells["id_persona"].Value);
            }
            catch
            {
                MessageBox.Show("No se pudo leer el ID de la fila seleccionada.");
                return;
            }

            try
            {
                conexion.Open();

                // 1) Actualizar tabla Persona
                string q1 = @"UPDATE Persona SET 
                        nombres = @nombres,
                        apellidos = @apellidos,
                        documento = @documento,
                        correo = @correo,
                        telefono = @telefono,
                        id_tipo_persona = @id_tipo
                      WHERE id_persona = @idp";
                using (MySqlCommand cmd = new MySqlCommand(q1, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombres", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@apellidos", txtApellido.Text.Trim());
                    cmd.Parameters.AddWithValue("@documento", txtDNI.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@id_tipo", cbTipo.SelectedValue ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idp", idPersona);
                    cmd.ExecuteNonQuery();
                }

                // 2) Actualizar o insertar en PersonaPrograma
                // Comprobamos si ya existe una fila en PersonaPrograma para esta persona
                string qCheck = "SELECT COUNT(*) FROM PersonaPrograma WHERE id_persona = @idp";
                using (MySqlCommand cmdCheck = new MySqlCommand(qCheck, conexion))
                {
                    cmdCheck.Parameters.AddWithValue("@idp", idPersona);
                    long count = Convert.ToInt64(cmdCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        // UPDATE
                        string qUpdPP = "UPDATE PersonaPrograma SET id_programa = @idprog WHERE id_persona = @idp";
                        using (MySqlCommand cmdUpd = new MySqlCommand(qUpdPP, conexion))
                        {
                            cmdUpd.Parameters.AddWithValue("@idprog", cbPrograma.SelectedValue ?? DBNull.Value);
                            cmdUpd.Parameters.AddWithValue("@idp", idPersona);
                            cmdUpd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // INSERT (si se seleccionó un programa)
                        if (cbPrograma.SelectedValue != null)
                        {
                            string qInsPP = "INSERT INTO PersonaPrograma (id_persona, id_programa, ciclo) VALUES (@idp, @idprog, NULL)";
                            using (MySqlCommand cmdIns = new MySqlCommand(qInsPP, conexion))
                            {
                                cmdIns.Parameters.AddWithValue("@idp", idPersona);
                                cmdIns.Parameters.AddWithValue("@idprog", cbPrograma.SelectedValue);
                                cmdIns.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarPersonas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgRegistro.CurrentRow != null)
            {
                // Obtener el id_persona de la fila seleccionada
                int idPersona = Convert.ToInt32(dtgRegistro.CurrentRow.Cells["id_persona"].Value);

                // Confirmar antes de eliminar
                DialogResult confirm = MessageBox.Show("¿Estás seguro de eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        string query = "DELETE FROM Persona WHERE id_persona = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conexion);
                        cmd.Parameters.AddWithValue("@id", idPersona);
                        conexion.Open();
                        cmd.ExecuteNonQuery();
                        conexion.Close();

                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPersonas(); // refresca el datagridview
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                        conexion.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila primero.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                // Si el campo de búsqueda está vacío, cargamos todos los datos
                CargarPersonas();
                return;
            }

            try
            {
                string query = @"
            SELECT p.id_persona, p.nombres, p.apellidos, p.documento, p.correo, p.telefono,
                   tp.nombre AS tipo, pr.nombre AS programa
            FROM Persona p
            INNER JOIN TipoPersona tp ON p.id_tipo_persona = tp.id_tipo_persona
            LEFT JOIN PersonaPrograma pp ON p.id_persona = pp.id_persona
            LEFT JOIN ProgramaAcademico pr ON pp.id_programa = pr.id_programa
            WHERE p.nombres LIKE @filtro
               OR p.apellidos LIKE @filtro
               OR p.documento LIKE @filtro
               OR p.correo LIKE @filtro
            ORDER BY p.id_persona ASC";

                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conexion))
                {
                    da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgRegistro.AutoGenerateColumns = true;
                    dtgRegistro.Columns.Clear();
                    dtgRegistro.DataSource = dt;

                    // Reasignamos encabezados bonitos
                    dtgRegistro.Columns["id_persona"].HeaderText = "ID";
                    dtgRegistro.Columns["nombres"].HeaderText = "Nombres";
                    dtgRegistro.Columns["apellidos"].HeaderText = "Apellidos";
                    dtgRegistro.Columns["documento"].HeaderText = "Documento";
                    dtgRegistro.Columns["correo"].HeaderText = "Correo";
                    dtgRegistro.Columns["telefono"].HeaderText = "Teléfono";
                    dtgRegistro.Columns["tipo"].HeaderText = "Tipo";
                    dtgRegistro.Columns["programa"].HeaderText = "Programa";

                    // Opcional: centramos ID y ajustamos columnas
                    dtgRegistro.Columns["id_persona"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtgRegistro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // header
            DataGridViewRow fila = dtgRegistro.Rows[e.RowIndex];

            // Asume que las columnas se llaman así en el DataTable (como en tu SELECT)
            txtNombre.Text = fila.Cells["nombres"].Value?.ToString() ?? "";
            txtApellido.Text = fila.Cells["apellidos"].Value?.ToString() ?? "";
            txtDNI.Text = fila.Cells["documento"].Value?.ToString() ?? "";
            txtCorreo.Text = fila.Cells["correo"].Value?.ToString() ?? "";
            txtTelefono.Text = fila.Cells["telefono"].Value?.ToString() ?? "";

            // Para los combobox, seleccionamos por ValueMember o por texto:
            // Si cbTipo está cargado con ValueMember = id_tipo_persona, buscamos el id.
            if (fila.Cells["tipo"].Value != null)
            {
                // Intentamos seleccionar por texto primero (porque el SELECT devuelve el nombre)
                string nombreTipo = fila.Cells["tipo"].Value.ToString();
                cbTipo.Text = nombreTipo;
            }

            if (fila.Cells["programa"].Value != null)
            {
                string nombreProg = fila.Cells["programa"].Value.ToString();
                cbPrograma.Text = nombreProg;
            }
        }

        private void SubFrmPersonas_Resize(object sender, EventArgs e)
        {

        }

        private void panelContenido_Resize(object sender, EventArgs e)
        {

        }

        private void panelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
