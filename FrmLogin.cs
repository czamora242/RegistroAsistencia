using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pyRegistroAsistencia
{
    public partial class FrmLogin : Form
    {
        private readonly string cadenaConexion = "server=localhost;database=AsistenciaUniversitaria;user=root;pwd=123456;";

        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(9, 29, 70), 2))
            {
                e.Graphics.DrawLine(pen, 310, 150, 715, 150);
                e.Graphics.DrawLine(pen, 310, 100, 715, 100);
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string clave = txtPassword.Text.Trim();

            // Validación previa
            if (usuario == "" || clave == "" || usuario == "USUARIO" || clave == "CONTRASEÑA")
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = "SELECT rol, estado FROM usuariosistema WHERE usuario = @usuario AND clave = @clave";

            try
            {
                using (MySqlConnection miConexion = new MySqlConnection(cadenaConexion))
                {
                    miConexion.Open();
                    using (var cmd = new MySqlCommand(sql, miConexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@clave", clave);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string estado = reader["estado"].ToString();
                                string rol = reader["rol"].ToString();

                                if (estado == "Inactivo")
                                {
                                    MessageBox.Show("El usuario está inactivo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    return;
                                }

                                MessageBox.Show($"Bienvenido {usuario} 👋\nRol: {rol}", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FrmPrincipal frmPrincipal = new FrmPrincipal(rol);
                                frmPrincipal.Show();
                                this.Hide();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos ❌", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection miConexion = new MySqlConnection(cadenaConexion))
                {
                    miConexion.Open();
                    MessageBox.Show("✅ Conexión exitosa con la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Application.Exit();

        private void btnMinimizar_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.FromArgb(9, 29, 70);
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.FromArgb(9, 29, 70);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.FromArgb(9, 29, 70);
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.FromArgb(9, 29, 70);
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
