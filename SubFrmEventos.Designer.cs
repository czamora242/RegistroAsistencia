namespace pyRegistroAsistencia
{
    partial class SubFrmEventos
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmEventos));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            lblRol = new Label();
            lblContraseña = new Label();
            lblUsuario = new Label();
            txtTipoEvento = new TextBox();
            cmbFacultad = new ComboBox();
            txtDescripcion = new TextBox();
            lblRegistroUsuarios = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtLugar = new TextBox();
            dtpInicio = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dtpFin = new DateTimePicker();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            dgvEventos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(528, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 39);
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(582, 90);
            label1.Name = "label1";
            label1.Size = new Size(192, 22);
            label1.TabIndex = 31;
            label1.Text = "MOSTRAR EVENTOS";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(9, 15, 70);
            btnEliminar.ForeColor = SystemColors.HighlightText;
            btnEliminar.Location = new Point(282, 454);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 29);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(9, 15, 70);
            btnEditar.ForeColor = SystemColors.HighlightText;
            btnEditar.Location = new Point(157, 454);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 29);
            btnEditar.TabIndex = 29;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(111, 316);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(67, 20);
            lblRol.TabIndex = 27;
            lblRol.Text = "Facultad:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(66, 260);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(112, 20);
            lblContraseña.TabIndex = 26;
            lblContraseña.Text = "Tipo de Evento:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(88, 165);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(90, 20);
            lblUsuario.TabIndex = 25;
            lblUsuario.Text = "Descripcion:";
            // 
            // txtTipoEvento
            // 
            txtTipoEvento.Location = new Point(184, 253);
            txtTipoEvento.Name = "txtTipoEvento";
            txtTipoEvento.Size = new Size(250, 27);
            txtTipoEvento.TabIndex = 24;
            // 
            // cmbFacultad
            // 
            cmbFacultad.FormattingEnabled = true;
            cmbFacultad.Location = new Point(184, 308);
            cmbFacultad.Name = "cmbFacultad";
            cmbFacultad.Size = new Size(250, 28);
            cmbFacultad.TabIndex = 23;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(184, 158);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 27);
            txtDescripcion.TabIndex = 22;
            // 
            // lblRegistroUsuarios
            // 
            lblRegistroUsuarios.AutoSize = true;
            lblRegistroUsuarios.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            lblRegistroUsuarios.ForeColor = Color.FromArgb(9, 15, 70);
            lblRegistroUsuarios.Location = new Point(167, 46);
            lblRegistroUsuarios.Name = "lblRegistroUsuarios";
            lblRegistroUsuarios.Size = new Size(200, 23);
            lblRegistroUsuarios.TabIndex = 21;
            lblRegistroUsuarios.Text = "REGISTRO DE EVENTOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 114);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 40;
            label3.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 213);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 42;
            label4.Text = "Lugar:";
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(184, 206);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(250, 27);
            txtLugar.TabIndex = 41;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(184, 354);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(250, 27);
            dtpInicio.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 359);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 44;
            label5.Text = "Inicio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 398);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 46;
            label6.Text = "Final:";
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(184, 393);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(250, 27);
            dtpFin.TabIndex = 45;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(9, 15, 70);
            btnAgregar.ForeColor = SystemColors.HighlightText;
            btnAgregar.Location = new Point(32, 454);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 29);
            btnAgregar.TabIndex = 47;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(9, 15, 70);
            btnLimpiar.ForeColor = SystemColors.HighlightText;
            btnLimpiar.Location = new Point(416, 454);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 29);
            btnLimpiar.TabIndex = 48;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvEventos
            // 
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(499, 133);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.RowHeadersWidth = 51;
            dgvEventos.Size = new Size(518, 262);
            dgvEventos.TabIndex = 49;
            dgvEventos.CellClick += dgvEventos_CellClick;
            // 
            // SubFrmEventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 526);
            Controls.Add(dgvEventos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(label6);
            Controls.Add(dtpFin);
            Controls.Add(label5);
            Controls.Add(dtpInicio);
            Controls.Add(label4);
            Controls.Add(txtLugar);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(lblRol);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtTipoEvento);
            Controls.Add(cmbFacultad);
            Controls.Add(txtDescripcion);
            Controls.Add(lblRegistroUsuarios);
            Name = "SubFrmEventos";
            Text = "SubFrmEventos";
            Load += SubFrmEventos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnEliminar;
        private Button btnEditar;
        private Label lblRol;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox txtTipoEvento;
        private ComboBox cmbFacultad;
        private TextBox txtDescripcion;
        private Label lblRegistroUsuarios;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtLugar;
        private DateTimePicker dtpInicio;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpFin;
        private Button btnAgregar;
        private Button btnLimpiar;
        private DataGridView dgvEventos;
    }
}