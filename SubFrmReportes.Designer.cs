namespace pyRegistroAsistencia
{
    partial class SubFrmReportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            cboEventos = new ComboBox();
            btnBuscar = new Button();
            dgvReporte = new DataGridView();
            btnExcel = new Button();
            btnPDF = new Button();
            btnImprimir = new Button();
            label2 = new Label();
            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.Text = "Reportes";

            // label2
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Text = "Seleccione un evento:";

            // cboEventos
            cboEventos.Location = new Point(180, 55);
            cboEventos.Size = new Size(300, 28);

            // btnBuscar
            btnBuscar.Location = new Point(500, 55);
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += new EventHandler(btnBuscar_Click);

            // dgvReporte
            dgvReporte.Location = new Point(20, 110);
            dgvReporte.Size = new Size(760, 260);
            dgvReporte.ReadOnly = true;
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // btnExcel
            btnExcel.Location = new Point(20, 390);
            btnExcel.Size = new Size(120, 35);
            btnExcel.Text = "Exportar Excel";
            btnExcel.Click += new EventHandler(btnExcel_Click);

            // btnPDF
            btnPDF.Location = new Point(160, 390);
            btnPDF.Size = new Size(120, 35);
            btnPDF.Text = "Exportar PDF";
            btnPDF.Click += new EventHandler(btnPDF_Click);

            // btnImprimir
            btnImprimir.Location = new Point(300, 390);
            btnImprimir.Size = new Size(120, 35);
            btnImprimir.Text = "Imprimir";
            btnImprimir.Click += new EventHandler(btnImprimir_Click);

            // SubFrmReportes
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cboEventos);
            Controls.Add(btnBuscar);
            Controls.Add(dgvReporte);
            Controls.Add(btnExcel);
            Controls.Add(btnPDF);
            Controls.Add(btnImprimir);
            Name = "SubFrmReportes";
            Text = "SubFrmReportes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cboEventos;
        private Button btnBuscar;
        private DataGridView dgvReporte;
        private Button btnExcel;
        private Button btnPDF;
        private Button btnImprimir;
    }
}
