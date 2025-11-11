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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubFrmCrearUsuario));
            lblRegistroUsuarios = new Label();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            lblUsuario = new Label();
            lblContraseña = new Label();
            lblRol = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            usuario = new DataGridViewTextBoxColumn();
            rol = new DataGridViewComboBoxColumn();
            estado = new DataGridViewComboBoxColumn();
            fecha_creacion = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // textBox1
            // 
            textBox1.Location = new Point(170, 253);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 27);
            textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 192);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 28);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 309);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 27);
            textBox2.TabIndex = 4;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(9, 15, 70);
            button1.ForeColor = SystemColors.HighlightText;
            button1.Location = new Point(31, 391);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 10;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(9, 15, 70);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(181, 391);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 11;
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(9, 15, 70);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Location = new Point(331, 391);
            button3.Name = "button3";
            button3.Size = new Size(119, 29);
            button3.TabIndex = 12;
            button3.Text = "LIMPIAR";
            button3.UseVisualStyleBackColor = false;
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
            // button4
            // 
            button4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(553, 108);
            button4.Name = "button4";
            button4.Size = new Size(83, 29);
            button4.TabIndex = 14;
            button4.Text = "TODOS";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 8F);
            button5.Location = new Point(768, 108);
            button5.Name = "button5";
            button5.Size = new Size(118, 29);
            button5.TabIndex = 15;
            button5.Text = "REGISTRADOR";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 8F);
            button6.Location = new Point(892, 108);
            button6.Name = "button6";
            button6.Size = new Size(118, 29);
            button6.TabIndex = 16;
            button6.Text = "CONSULTOR";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { usuario, rol, estado, fecha_creacion });
            dataGridView1.Location = new Point(517, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(503, 188);
            dataGridView1.TabIndex = 17;
            // 
            // usuario
            // 
            usuario.HeaderText = "Usuario";
            usuario.MinimumWidth = 6;
            usuario.Name = "usuario";
            usuario.Width = 125;
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.Resizable = DataGridViewTriState.True;
            rol.SortMode = DataGridViewColumnSortMode.Automatic;
            rol.Width = 125;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.Width = 125;
            // 
            // fecha_creacion
            // 
            fecha_creacion.HeaderText = "Fecha Creación";
            fecha_creacion.MinimumWidth = 6;
            fecha_creacion.Name = "fecha_creacion";
            fecha_creacion.Resizable = DataGridViewTriState.True;
            fecha_creacion.SortMode = DataGridViewColumnSortMode.NotSortable;
            fecha_creacion.Width = 125;
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
            // button7
            // 
            button7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(644, 108);
            button7.Name = "button7";
            button7.Size = new Size(118, 29);
            button7.TabIndex = 20;
            button7.Text = "ADMINISTRADOR";
            button7.UseVisualStyleBackColor = true;
            // 
            // SubFrmCrearUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 553);
            Controls.Add(button7);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblRol);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(lblRegistroUsuarios);
            Name = "SubFrmCrearUsuario";
            Text = "SubFrmCrearUsuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistroUsuarios;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label lblUsuario;
        private Label lblContraseña;
        private Label lblRol;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewComboBoxColumn rol;
        private DataGridViewComboBoxColumn estado;
        private DataGridViewTextBoxColumn fecha_creacion;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button7;
    }
}