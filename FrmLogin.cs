using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace pyRegistroAsistencia
{
    public partial class FrmLogin : Form
    {
        string connectionString = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=60417779;";
        public FrmLogin()
        {
            InitializeComponent();

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Hi, i am Ari
            //ola ola
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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

        private void FrmLogin_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(9, 29, 70), 2); // grosor = 2 px

            // Ejemplo: dos líneas horizontales
            e.Graphics.DrawLine(pen, 310, 150, 715, 150); // línea 1
            e.Graphics.DrawLine(pen, 310, 100, 715, 100); // línea 2

            pen.Dispose();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string clave = txtPassword.Text.Trim();

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usuario == "admin" && clave == "admin123")
            {
                MessageBox.Show("Bienvenido, Administrador", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmPrincipal principal = new FrmPrincipal("Administrador");
                principal.Show();
                return;
            }

            if (usuario == "registrador" && clave == "reg123")
            {
                MessageBox.Show("Bienvenido, Registrador", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmPrincipal principal = new FrmPrincipal("Registrador");
                principal.Show();
                return;
            }

            if (usuario == "consultor" && clave == "con123")
            {
                MessageBox.Show("Bienvenido, Consultor", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmPrincipal principal = new FrmPrincipal("Consultor");
                principal.Show();
                return;
            }

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT usuario, rol, estado FROM UsuarioSistema " +
                                   "WHERE usuario = @usuario AND clave = SHA2(@clave, 256);";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string estado = reader["estado"].ToString();
                        string rol = reader["rol"].ToString();

                        if (estado == "Inactivo")
                        {
                            MessageBox.Show("El usuario está inactivo.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }

                        MessageBox.Show($"Bienvenido, {usuario} ({rol})", "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        FrmPrincipal principal = new FrmPrincipal(rol);
                        principal.Show();

                        // 👉 Aquí puedes abrir tu formulario principal (por ejemplo, menú o panel)
                        // this.Hide();
                        // new FrmPrincipal(rol).Show();

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            //string connectionString = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=60417779;";
            string connectionString = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    MessageBox.Show("✅ Conexión exitosa con la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al conectar:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
