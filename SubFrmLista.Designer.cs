namespace pyRegistroAsistencia
{
    partial class SubFrmLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            txtBuscar = new TextBox();
            btnMostrarTodo = new Button();
            dgvLista = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
             
            // label1
            
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(9, 15, 70);
            label1.Location = new Point(300, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Lista de Asistencia";
             
            // txtBuscar
             
            txtBuscar.Location = new Point(30, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre o DNI...";
            txtBuscar.Size = new Size(480, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
             
            // btnMostrarTodo
            
            btnMostrarTodo.BackColor = Color.FromArgb(9, 15, 70);
            btnMostrarTodo.FlatStyle = FlatStyle.Flat;
            btnMostrarTodo.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Bold);
            btnMostrarTodo.ForeColor = Color.FromArgb(225, 225, 225);
            btnMostrarTodo.Location = new Point(527, 43);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(117, 34);
            btnMostrarTodo.TabIndex = 2;
            btnMostrarTodo.Text = "Mostrar Todo";
            btnMostrarTodo.UseVisualStyleBackColor = false;
            btnMostrarTodo.Click += btnMostrarTodo_Click;
             
            // dgvLista
             
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLista.BackgroundColor = Color.White;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(30, 90);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.RowHeadersVisible = false;
            dgvLista.Size = new Size(680, 260);
            dgvLista.TabIndex = 3;
             
            // SubFrmLista

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 225, 225);
            ClientSize = new Size(748, 376);
            Controls.Add(dgvLista);
            Controls.Add(btnMostrarTodo);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SubFrmLista";
            Text = "Lista de Asistencia";
            Load += SubFrmLista_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscar;
        private Button btnMostrarTodo;
        private DataGridView dgvLista;
    }
}
