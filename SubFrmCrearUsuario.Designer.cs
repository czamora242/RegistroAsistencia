namespace pyRegistroAsistencia
{
    partial class SubFrmCrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmCrearUsuario));
            lblRegistroUsuarios = new Label();
            txtUsuario = new TextBox();
            cmbRol = new ComboBox();
            txtClave = new TextBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblRol = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            btnTodos = new Button();
            btnRegistrador = new Button();
            btnConsultor = new Button();
            dgvUsuarios = new DataGridView();
            id_usuario = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            clave = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            btnAdministrador = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRegistroUsuarios
            // 
            lblRegistroUsuarios.AutoSize = true;
            lblRegistroUsuarios.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            lblRegistroUsuarios.ForeColor = Color.FromArgb(9, 15, 70);
            lblRegistroUsuarios.Location = new Point(151, 105);
            lblRegistroUsuarios.Name = "lblRegistroUsuarios";
            lblRegistroUsuarios.Size = new Size(206, 23);
            lblRegistroUsuarios.TabIndex = 0;
            lblRegistroUsuarios.Text = "REGISTRO DE USUARIOS";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(170, 253);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(232, 27);
            txtUsuario.TabIndex = 1;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(170, 192);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(232, 28);
            cmbRol.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(170, 309);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(232, 27);
            txtClave.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(95, 260);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(62, 20);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(71, 316);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(86, 20);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(123, 200);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(34, 20);
            lblRol.TabIndex = 7;
            lblRol.Text = "Rol:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(9, 15, 70);
            btnGuardar.ForeColor = SystemColors.HighlightText;
            btnGuardar.Location = new Point(31, 391);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(9, 15, 70);
            btnActualizar.ForeColor = SystemColors.HighlightText;
            btnActualizar.Location = new Point(181, 391);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(119, 29);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(9, 15, 70);
            btnLimpiar.ForeColor = SystemColors.HighlightText;
            btnLimpiar.Location = new Point(331, 391);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(119, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(569, 63);
            label1.Name = "label1";
            label1.Size = new Size(188, 22);
            label1.TabIndex = 13;
            label1.Text = "FILTRAR USUARIOS:";
            // 
            // btnTodos
            // 
            btnTodos.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTodos.Location = new Point(553, 108);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(83, 29);
            btnTodos.TabIndex = 14;
            btnTodos.Text = "TODOS";
            btnTodos.UseVisualStyleBackColor = true;
            // 
            // btnRegistrador
            // 
            btnRegistrador.Font = new Font("Segoe UI", 8F);
            btnRegistrador.Location = new Point(768, 108);
            btnRegistrador.Name = "btnRegistrador";
            btnRegistrador.Size = new Size(118, 29);
            btnRegistrador.TabIndex = 15;
            btnRegistrador.Text = "REGISTRADOR";
            btnRegistrador.UseVisualStyleBackColor = true;
            // 
            // btnConsultor
            // 
            btnConsultor.Font = new Font("Segoe UI", 8F);
            btnConsultor.Location = new Point(892, 108);
            btnConsultor.Name = "btnConsultor";
            btnConsultor.Size = new Size(118, 29);
            btnConsultor.TabIndex = 16;
            btnConsultor.Text = "CONSULTOR";
            btnConsultor.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { id_usuario, usuario, clave, rol, estado });
            dgvUsuarios.Location = new Point(466, 161);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(554, 188);
            dgvUsuarios.TabIndex = 17;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // id_usuario
            // 
            id_usuario.DataPropertyName = "id_usuario";
            id_usuario.HeaderText = "ID";
            id_usuario.MinimumWidth = 6;
            id_usuario.Name = "id_usuario";
            id_usuario.Width = 50;
            // 
            // usuario
            // 
            usuario.DataPropertyName = "usuario";
            usuario.HeaderText = "Usuario";
            usuario.MinimumWidth = 6;
            usuario.Name = "usuario";
            usuario.Width = 125;
            // 
            // clave
            // 
            clave.DataPropertyName = "clave";
            clave.HeaderText = "Contraseña";
            clave.MinimumWidth = 6;
            clave.Name = "clave";
            clave.Width = 125;
            // 
            // rol
            // 
            rol.DataPropertyName = "rol";
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.Resizable = DataGridViewTriState.True;
            rol.Width = 125;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.Resizable = DataGridViewTriState.True;
            estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            estado.Width = 125;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(515, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 39);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(511, 117);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 19;
            label2.Text = "Rol:";
            // 
            // btnAdministrador
            // 
            btnAdministrador.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdministrador.Location = new Point(644, 108);
            btnAdministrador.Name = "btnAdministrador";
            btnAdministrador.Size = new Size(118, 29);
            btnAdministrador.TabIndex = 20;
            btnAdministrador.Text = "ADMINISTRADOR";
            btnAdministrador.UseVisualStyleBackColor = true;
            // 
            // SubFrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 553);
            Controls.Add(btnAdministrador);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnConsultor);
            Controls.Add(btnRegistrador);
            Controls.Add(btnTodos);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(lblRol);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtClave);
            Controls.Add(cmbRol);
            Controls.Add(txtUsuario);
            Controls.Add(lblRegistroUsuarios);
            Name = "SubFrmCrearUsuario";
            Text = "SubFrmCrearUsuario";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroUsuarios;
        private TextBox txtUsuario;
        private ComboBox cmbRol;
        private TextBox txtClave;
        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblRol;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnLimpiar;
        private Label label1;
        private Button btnTodos;
        private Button btnRegistrador;
        private Button btnConsultor;
        private DataGridView dgvUsuarios;
        private PictureBox pictureBox1;
        private Label label2;
        private Button btnAdministrador;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn clave;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn estado;
    }
}