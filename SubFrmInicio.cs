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
using System.IO;



namespace pyRegistroAsistencia
{
    public partial class SubFrmInicio : Form

    {
        string conexion = "server=localhost;database=AsistenciaUniversitaria;user=root;pwd=123456;";

        public SubFrmInicio()
        {
            InitializeComponent();
            CargarEventoDelDia();
            CargarProximosEventos();
        }

        private DataTable EjecutarConsulta(string query)
        {
            using (MySqlConnection con = new MySqlConnection(conexion))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        private void CargarEventoDelDia()
        {
            string query = @"
            SELECT id_evento, nombre, descripcion, fecha_inicio, imagen 
            FROM evento 
            WHERE DATE(fecha_inicio) = CURDATE() 
            ORDER BY fecha_inicio ASC
            LIMIT 1
        ";

            DataTable dt = EjecutarConsulta(query);

            if (dt.Rows.Count == 0)
            {
                lblEventoHoy.Text = "No hay eventos programados para hoy.";
                panelHoy.Visible = false;
                return;
            }

            DataRow row = dt.Rows[0];
            panelHoy.Visible = true;
            lblEventoHoy.Text = row["nombre"].ToString();
            lblDescripcionHoy.Text = row["descripcion"].ToString();
            lblFechaHoy.Text = Convert.ToDateTime(row["fecha_inicio"]).ToString("dd/MM/yyyy HH:mm");

            // Imagen guardada como ruta o base64
            string nombreArchivo = row["imagen"].ToString();
            string rutaImagen = Path.Combine(Application.StartupPath, "imagenes", nombreArchivo);

            if (File.Exists(rutaImagen))
                picHoy.Image = Image.FromFile(rutaImagen);
                picHoy.SizeMode = PictureBoxSizeMode.Zoom;

        }


        private void CargarProximosEventos()
        {
            string query = @"
        SELECT id_evento, nombre, descripcion, fecha_inicio, imagen 
        FROM evento
        WHERE fecha_inicio > CURDATE()
        ORDER BY fecha_inicio ASC
        LIMIT 10
    ";

            DataTable dt = EjecutarConsulta(query);

            flowEventos.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                // ----- Tarjeta principal -----
                Panel card = new Panel();
                card.Width = 420;
                card.Height = 250;
                card.BackColor = Color.White;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Margin = new Padding(12);
                card.Padding = new Padding(10);

                // Sombra o borde suave
                card.BackColor = Color.WhiteSmoke;

                // ----- Imagen -----
                PictureBox pic = new PictureBox();
                pic.Width = 180;
                pic.Height = 200;
                pic.Location = new Point(10, 10);
                pic.SizeMode = PictureBoxSizeMode.Zoom;

                string nombreArchivo = row["imagen"].ToString();
                string rutaImagen = Path.Combine(Application.StartupPath, "imagenes", nombreArchivo);

                if (File.Exists(rutaImagen))
                    pic.Image = Image.FromFile(rutaImagen);

                // ----- Título -----
                Label titulo = new Label();
                titulo.Text = row["nombre"].ToString();
                titulo.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                titulo.Location = new Point(200, 10);
                titulo.AutoSize = true;
                titulo.MaximumSize = new Size(200, 60);

                // ----- Fecha -----
                Label fecha = new Label();
                fecha.Text = "Fecha: " + Convert.ToDateTime(row["fecha_inicio"]).ToString("dd/MM/yyyy HH:mm");
                fecha.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                fecha.Location = new Point(200, 70);
                fecha.AutoSize = true;

                // ----- Descripción -----
                Label descripcion = new Label();
                descripcion.Text = row["descripcion"].ToString();
                descripcion.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                descripcion.Location = new Point(200, 100);
                descripcion.AutoSize = false;
                descripcion.Size = new Size(200, 60);
                descripcion.MaximumSize = new Size(200, 120);

                // ----- Botón -----
                Button btn = new Button();
                btn.Text = "Lista de asistencia";
                btn.Location = new Point(200, 160);
                btn.Tag = row["id_evento"];
                btn.Height = 35;
                btn.Width = 160;
                btn.BackColor = Color.DodgerBlue;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;
                btn.Click += BtnAbrirListaAsistencia_Click;

                // ----- Agregar controles a tarjeta -----
                card.Controls.Add(pic);
                card.Controls.Add(titulo);
                card.Controls.Add(fecha);
                card.Controls.Add(descripcion);
                card.Controls.Add(btn);

                // ----- Agregar tarjeta al FlowLayoutPanel -----
                flowEventos.Controls.Add(card);
            }
        }

        private void BtnAbrirListaAsistencia_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int idEvento = Convert.ToInt32(btn.Tag);

            // Abrir tu formulario de asistencia
            SubFrmMarcar frm = new SubFrmMarcar();
            frm.ShowDialog();
        }

        private void btnAsistenciaHoy_Click(object sender, EventArgs e)
        {
            SubFrmMarcar frm = new SubFrmMarcar();
            frm.ShowDialog();
        }
    }

}