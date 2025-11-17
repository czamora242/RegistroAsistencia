using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System;
using ClosedXML.Excel; // Para exportar a Excel
using MySql.Data.MySqlClient; // Para conectarte a MySQL
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pyRegistroAsistencia
{
    public partial class SubFrmReportes : Form
    {
        string conexion = "Server=localhost;Database=AsistenciaUniversitaria;Uid=root;Pwd=123456;";


        DataTable tablaReporte = new DataTable();

        public SubFrmReportes()
        {
            InitializeComponent();
            CargarEventos();
        }

        // CARGAR EVENTOS EN COMBOBOX
        private void CargarEventos()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(conexion))
                {
                    cn.Open();
                    string query = "SELECT id_evento, nombre FROM evento";
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboEventos.DataSource = dt;
                    cboEventos.DisplayMember = "nombre";
                    cboEventos.ValueMember = "id_evento";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando eventos: " + ex.Message);
            }
        }

        // CONSULTA PRINCIPAL
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(conexion))
                {
                    cn.Open();
                    string query = @"
                    SELECT 
                        a.id_asistencia,
                        e.nombre AS evento,
                        a.id_persona,
                        a.fecha_registro,
                        a.estado,
                        e.lugar,
                        e.tipo_evento
                    FROM asistencia a
                    INNER JOIN evento e ON a.id_evento = e.id_evento
                    WHERE a.id_evento = @id_evento";

                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id_evento", cboEventos.SelectedValue);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    tablaReporte = new DataTable();
                    da.Fill(tablaReporte);

                    dgvReporte.DataSource = tablaReporte;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar reporte: " + ex.Message);
            }
        }

        // EXPORTAR EXCEL
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (tablaReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel (*.xlsx)|*.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(tablaReporte, "Reporte");
                    wb.SaveAs(save.FileName);
                }

                MessageBox.Show("Exportado correctamente.");
            }
        }

        // EXPORTAR PDF (versión simple usando PrintDocument -> PDF)
        private void btnPDF_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            pd.PrintPage += (s, ev) =>
            {
                Font font = new Font("Arial", 10);
                float y = 20;

                // TÍTULO
                ev.Graphics.DrawString("Reporte de Asistencia", new Font("Arial", 14, FontStyle.Bold),
                    Brushes.Black, 20, y);
                y += 40;

                // COLUMNAS
                string columnas = "ID  | Persona | Fecha | Estado | Lugar | Tipo";
                ev.Graphics.DrawString(columnas, font, Brushes.Black, 20, y);
                y += 25;

                // DATOS
                foreach (DataRow row in tablaReporte.Rows)
                {
                    string linea = $"{row["id_asistencia"]} | {row["id_persona"]} | {row["fecha_registro"]} | {row["estado"]} | {row["lugar"]} | {row["tipo_evento"]}";
                    ev.Graphics.DrawString(linea, font, Brushes.Black, 20, y);
                    y += 20;
                }
            };

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF (*.pdf)|*.pdf";

            if (save.ShowDialog() == DialogResult.OK)
            {
                pd.PrinterSettings.PrintToFile = true;
                pd.PrinterSettings.PrintFileName = save.FileName;
                pd.Print();
                MessageBox.Show("PDF generado.");
            }
        }

        // IMPRIMIR
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += (s, ev) =>
            {
                Font font = new Font("Arial", 10);
                float y = 20;

                ev.Graphics.DrawString("Reporte de Asistencia", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 20, y);
                y += 40;

                foreach (DataRow row in tablaReporte.Rows)
                {
                    string linea = $"{row["id_asistencia"]}  {row["id_persona"]}  {row["fecha_registro"]}  {row["estado"]}";
                    ev.Graphics.DrawString(linea, font, Brushes.Black, 20, y);
                    y += 20;
                }
            };

            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}