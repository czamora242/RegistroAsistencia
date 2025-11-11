using System.Runtime.InteropServices;

namespace pyRegistroAsistencia
{
    public partial class FrmPrincipal : Form
    {
        private string rolUsuario;

        public FrmPrincipal(string rol)
        {
            InitializeComponent();
            rolUsuario = rol;
        }


        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarPorRol();
        }

        private void ConfigurarPorRol()
        {
            if (rolUsuario == "Registrador")
            {
                btnCrearUsuario.Visible = false;
                BtnReportes.Visible = false;
                BtnLista.Visible = false;
            }
            else if (rolUsuario == "Administrador")
            {
                //btnCrearUsuario.Visible = false;
                //BtnReportes.Visible = false;
                //btnAjustes.Visible = false;
                BtnLista.Visible = false;

            }
            else if (rolUsuario == "Consultor")
            {
                btnCrearUsuario.Visible = false;
                BtnReportes.Visible = false;
                BtnPersonas.Visible = false;
            }
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void IconSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconRestaurar.Visible = true;
            IconMaximizar.Visible = false;
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurar.Visible = false;
            IconMaximizar.Visible = true;
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            // Limpiar el contenido previo
            if (PanelContenedor.Controls.Count > 0)
                PanelContenedor.Controls.RemoveAt(0);

            // Configurar el formulario hijo
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // Agregarlo al panel
            PanelContenedor.Controls.Add(formularioHijo);
            PanelContenedor.Tag = formularioHijo;

            // Mostrarlo
            formularioHijo.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SubFrmInicio());
        }

        private void BtnMarcar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SubFrmMarcar());
        }

        private void BtnPersonas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SubFrmPersonas());
        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SubFrmAjustes());
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SubFrmLista());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SubFrmReportes());
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SubFrmCrearUsuario());
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SubFrmAyuda());
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SubFrmEventos());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.Show();
        }
    }
}
