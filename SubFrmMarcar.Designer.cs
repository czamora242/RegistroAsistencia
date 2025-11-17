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
            dgvRegistradas = new DataGridView();
            lblResultado = new Label();
            btnEliminar = new Button();
            cmbFiltro = new ComboBox();

            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistradas).BeginInit();
            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(9, 15, 70);
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 0;
            label1.Text = "Marcar Asistencia (DNI)";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            label2.ForeColor = Color.FromArgb(9, 15, 70);
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su DNI aquí:";

            // txtDni
            txtDni.Location = new Point(140, 51);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(180, 23);
            txtDni.TabIndex = 2;

            // btnMarcar
            btnMarcar.BackColor = Color.FromArgb(9, 15, 70);
            btnMarcar.FlatAppearance.BorderColor = Color.Silver;
            btnMarcar.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            btnMarcar.FlatStyle = FlatStyle.Flat;
            btnMarcar.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold);
            btnMarcar.ForeColor = Color.FromArgb(225, 225, 225);
            btnMarcar.Location = new Point(341, 46);
            btnMarcar.Name = "btnMarcar";
            btnMarcar.Size = new Size(156, 32);
            btnMarcar.TabIndex = 3;
            btnMarcar.Text = "Marcar Asistencia";
            btnMarcar.UseVisualStyleBackColor = false;
            btnMarcar.Click += btnMarcar_Click;

            // dgvAsistencias
            dgvAsistencias.AllowUserToAddRows = false;
            dgvAsistencias.AllowUserToDeleteRows = false;
            dgvAsistencias.Anchor = AnchorStyles.None;
            dgvAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsistencias.BackgroundColor = Color.FromArgb(65, 92, 149);
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencias.Location = new Point(20, 118);
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.ReadOnly = true;
            dgvAsistencias.RowHeadersVisible = false;
            dgvAsistencias.Size = new Size(550, 250);
            dgvAsistencias.TabIndex = 4;

            // dgvRegistradas
            dgvRegistradas.AllowUserToAddRows = false;
            dgvRegistradas.AllowUserToDeleteRows = false;
            dgvRegistradas.Anchor = AnchorStyles.None;
            dgvRegistradas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistradas.BackgroundColor = Color.FromArgb(65, 149, 92);
            dgvRegistradas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegistradas.Location = new Point(580, 118);
            dgvRegistradas.Name = "dgvRegistradas";
            dgvRegistradas.ReadOnly = true;
            dgvRegistradas.RowHeadersVisible = false;
            dgvRegistradas.Size = new Size(500, 250);
            dgvRegistradas.TabIndex = 5;

            // lblResultado
            lblResultado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResultado.Location = new Point(20, 85);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(600, 30);
            lblResultado.TabIndex = 6;

            // btnEliminar
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(520, 46);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 32);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar Asistencia";
            btnEliminar.Click += btnEliminar_Click;

            // cmbFiltro
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.Items.AddRange(new object[] { "Asistió", "No asistió", "Todos" });
            cmbFiltro.SelectedIndex = 0;
            cmbFiltro.Location = new Point(660, 46);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(120, 23);
            cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;

            // SubFrmMarcar
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(1100, 420);
            Controls.Add(cmbFiltro);
            Controls.Add(btnEliminar);
            Controls.Add(dgvRegistradas);
            Controls.Add(dgvAsistencias);
            Controls.Add(lblResultado);
            Controls.Add(btnMarcar);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SubFrmMarcar";
            Text = "Marcar Asistencia";
            Load += SubFrmMarcar_Load;

            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistradas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDni;
        private Button btnMarcar;
        private DataGridView dgvAsistencias;
        private DataGridView dgvRegistradas;
        private Label lblResultado;
        private Button btnEliminar;
        private ComboBox cmbFiltro;
    }
}
