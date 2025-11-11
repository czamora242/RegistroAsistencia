namespace pyRegistroAsistencia
{
    partial class SubFrmAyuda
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
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnGuardar = new Button();
            cbPrograma = new ComboBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cbTipo = new ComboBox();
            label2 = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblDocumento = new Label();
            lblApellidos = new Label();
            lblNombre = new Label();
            label4 = new Label();
            dtgRegistro = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellidos = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            programa = new DataGridViewTextBoxColumn();
            button4 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgRegistro).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1144, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Ayuda";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(9, 15, 70);
            button3.FlatAppearance.BorderColor = Color.Silver;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(225, 225, 225);
            button3.Location = new Point(494, 477);
            button3.Name = "button3";
            button3.Size = new Size(134, 32);
            button3.TabIndex = 37;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(9, 15, 70);
            button2.FlatAppearance.BorderColor = Color.Silver;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(225, 225, 225);
            button2.Location = new Point(342, 477);
            button2.Name = "button2";
            button2.Size = new Size(134, 32);
            button2.TabIndex = 36;
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(9, 15, 70);
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(225, 225, 225);
            button1.Location = new Point(184, 477);
            button1.Name = "button1";
            button1.Size = new Size(134, 32);
            button1.TabIndex = 35;
            button1.Text = "LIMPIAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(9, 15, 70);
            btnGuardar.FlatAppearance.BorderColor = Color.Silver;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.FromArgb(225, 225, 225);
            btnGuardar.Location = new Point(29, 477);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 32);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cbPrograma
            // 
            cbPrograma.FormattingEnabled = true;
            cbPrograma.Items.AddRange(new object[] { "Pregrado", "Posgrado" });
            cbPrograma.Location = new Point(454, 369);
            cbPrograma.Name = "cbPrograma";
            cbPrograma.Size = new Size(165, 28);
            cbPrograma.TabIndex = 33;
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(9, 15, 70);
            label3.Location = new Point(364, 370);
            label3.Name = "label3";
            label3.Size = new Size(113, 39);
            label3.TabIndex = 32;
            label3.Text = "Programa:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(175, 314);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(361, 27);
            txtTelefono.TabIndex = 31;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(175, 264);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(361, 27);
            txtCorreo.TabIndex = 30;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(175, 215);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(361, 27);
            txtDNI.TabIndex = 29;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(175, 164);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(361, 27);
            txtApellido.TabIndex = 28;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 27);
            txtNombre.TabIndex = 27;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Estudiante", "Docente", "Invitado" });
            cbTipo.Location = new Point(119, 369);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(179, 28);
            cbTipo.TabIndex = 26;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(9, 15, 70);
            label2.Location = new Point(49, 369);
            label2.Name = "label2";
            label2.Size = new Size(113, 39);
            label2.TabIndex = 25;
            label2.Text = "Tipo:";
            // 
            // lblTelefono
            // 
            lblTelefono.ForeColor = Color.FromArgb(9, 15, 70);
            lblTelefono.Location = new Point(70, 317);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(113, 39);
            lblTelefono.TabIndex = 24;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreo
            // 
            lblCorreo.ForeColor = Color.FromArgb(9, 15, 70);
            lblCorreo.Location = new Point(70, 266);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(113, 39);
            lblCorreo.TabIndex = 23;
            lblCorreo.Text = "Correo:";
            // 
            // lblDocumento
            // 
            lblDocumento.ForeColor = Color.FromArgb(9, 15, 70);
            lblDocumento.Location = new Point(70, 217);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(113, 39);
            lblDocumento.TabIndex = 22;
            lblDocumento.Text = "Documento:";
            // 
            // lblApellidos
            // 
            lblApellidos.ForeColor = Color.FromArgb(9, 15, 70);
            lblApellidos.Location = new Point(70, 168);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(113, 39);
            lblApellidos.TabIndex = 21;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            lblNombre.ForeColor = Color.FromArgb(9, 15, 70);
            lblNombre.Location = new Point(70, 114);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 39);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombres:";
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(9, 15, 70);
            label4.Location = new Point(184, 47);
            label4.Name = "label4";
            label4.Size = new Size(326, 50);
            label4.TabIndex = 19;
            label4.Text = "REGISTRO DE LAS PERSONAS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgRegistro
            // 
            dtgRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRegistro.Columns.AddRange(new DataGridViewColumn[] { nombre, apellidos, dni, correo, telefono, tipo, programa });
            dtgRegistro.Location = new Point(657, 149);
            dtgRegistro.Name = "dtgRegistro";
            dtgRegistro.RowHeadersWidth = 51;
            dtgRegistro.Size = new Size(564, 401);
            dtgRegistro.TabIndex = 42;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombres";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // apellidos
            // 
            apellidos.HeaderText = "Apellidos";
            apellidos.MinimumWidth = 6;
            apellidos.Name = "apellidos";
            apellidos.Width = 125;
            // 
            // dni
            // 
            dni.HeaderText = "Documento";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            dni.Width = 125;
            // 
            // correo
            // 
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.Width = 125;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.Width = 125;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.Width = 125;
            // 
            // programa
            // 
            programa.HeaderText = "Programa Académico";
            programa.MinimumWidth = 6;
            programa.Name = "programa";
            programa.Width = 125;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(9, 15, 70);
            button4.FlatAppearance.BorderColor = Color.Silver;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(225, 225, 225);
            button4.Location = new Point(1099, 88);
            button4.Name = "button4";
            button4.Size = new Size(134, 32);
            button4.TabIndex = 38;
            button4.Text = "BUSCAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(719, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 27);
            textBox1.TabIndex = 39;
            // 
            // label5
            // 
            label5.ForeColor = Color.FromArgb(9, 15, 70);
            label5.Location = new Point(695, 58);
            label5.Name = "label5";
            label5.Size = new Size(113, 39);
            label5.TabIndex = 40;
            label5.Text = "Buscar:";
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(9, 15, 70);
            label6.Location = new Point(777, 42);
            label6.Name = "label6";
            label6.Size = new Size(326, 50);
            label6.TabIndex = 41;
            label6.Text = "BUSQUEDA ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubFrmAyuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 626);
            Controls.Add(dtgRegistro);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(cbPrograma);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(cbTipo);
            Controls.Add(label2);
            Controls.Add(lblTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblDocumento);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "SubFrmAyuda";
            Text = "SubFrmAyuda";
            ((System.ComponentModel.ISupportInitialize)dtgRegistro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btnGuardar;
        private ComboBox cbPrograma;
        private Label label3;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private ComboBox cbTipo;
        private Label label2;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblDocumento;
        private Label lblApellidos;
        private Label lblNombre;
        private Label label4;
        private DataGridView dtgRegistro;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellidos;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn programa;
        private Button button4;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
    }
}