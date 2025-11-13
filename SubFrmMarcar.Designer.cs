namespace pyRegistroAsistencia
{
    partial class SubFrmMarcar
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
            label2 = new Label();
            txtDni = new TextBox();
            btnMarcar = new Button();
            dgvAsistencias = new DataGridView();
            dgvPersonas = new DataGridView();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 12);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 0;
            label1.Text = "Marcar Asistencia (DNI)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Documento (DNI):";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(120, 52);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(180, 23);
            txtDni.TabIndex = 2;
            // 
            // btnMarcar
            // 
            btnMarcar.Location = new Point(320, 51);
            btnMarcar.Name = "btnMarcar";
            btnMarcar.Size = new Size(120, 25);
            btnMarcar.TabIndex = 3;
            btnMarcar.Text = "Marcar Asistencia";
            btnMarcar.UseVisualStyleBackColor = true;
            btnMarcar.Click += btnMarcar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = false;
            lblResultado.Size = new Size(420, 30);
            lblResultado.Location = new Point(20, 85);
            lblResultado.Name = "lblResultado";
            lblResultado.Text = "";
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(20, 125);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowHeadersVisible = false;
            dgvPersonas.Size = new Size(420, 200);
            dgvPersonas.TabIndex = 4;
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.AllowUserToAddRows = false;
            dgvAsistencias.AllowUserToDeleteRows = false;
            dgvAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencias.Location = new Point(460, 125);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.ReadOnly = true;
            dgvAsistencias.RowHeadersVisible = false;
            dgvAsistencias.Size = new Size(620, 200);
            dgvAsistencias.TabIndex = 5;
            // 
            // SubFrmMarcar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 350);
            Controls.Add(dgvAsistencias);
            Controls.Add(dgvPersonas);
            Controls.Add(lblResultado);
            Controls.Add(btnMarcar);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SubFrmMarcar";
            Text = "Marcar Asistencia";
            Load += SubFrmMarcar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDni;
        private Button btnMarcar;
        private DataGridView dgvAsistencias;
        private DataGridView dgvPersonas;
        private Label lblResultado;
    }
}
