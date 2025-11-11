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

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtgRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
