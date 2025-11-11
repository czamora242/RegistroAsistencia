namespace pyRegistroAsistencia
{
    partial class SubFrmPersonas
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
            panelContenido = new Panel();
            panel1 = new Panel();
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
            panelRegistro = new Panel();
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
            panelContenido.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgRegistro).BeginInit();
            panelRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.AutoScroll = true;
            panelContenido.AutoScrollMinSize = new Size(1200, 0);
            panelContenido.BackColor = Color.FromArgb(225, 225, 225);
            panelContenido.Controls.Add(panel1);
            panelContenido.Controls.Add(panelRegistro);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1282, 603);
            panelContenido.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgRegistro);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(729, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 603);
            panel1.TabIndex = 1;
            // 
            // dtgRegistro
            // 
            dtgRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRegistro.Columns.AddRange(new DataGridViewColumn[] { nombre, apellidos, dni, correo, telefono, tipo, programa });
            dtgRegistro.Location = new Point(37, 154);
            dtgRegistro.Name = "dtgRegistro";
            dtgRegistro.RowHeadersWidth = 51;
            dtgRegistro.Size = new Size(564, 401);
            dtgRegistro.TabIndex = 47;
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
            button4.Location = new Point(479, 93);
            button4.Name = "button4";
            button4.Size = new Size(134, 32);
            button4.TabIndex = 43;
            button4.Text = "BUSCAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 27);
            textBox1.TabIndex = 44;
            // 
            // label5
            // 
            label5.ForeColor = Color.FromArgb(9, 15, 70);
            label5.Location = new Point(38, 93);
            label5.Name = "label5";
            label5.Size = new Size(113, 39);
            label5.TabIndex = 45;
            label5.Text = "Buscar:";
            label5.Click += label5_Click_1;
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(9, 15, 70);
            label6.Location = new Point(157, 47);
            label6.Name = "label6";
            label6.Size = new Size(326, 50);
            label6.TabIndex = 46;
            label6.Text = "BUSQUEDA ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRegistro
            // 
            panelRegistro.Controls.Add(button3);
            panelRegistro.Controls.Add(button2);
            panelRegistro.Controls.Add(button1);
            panelRegistro.Controls.Add(btnGuardar);
            panelRegistro.Controls.Add(cbPrograma);
            panelRegistro.Controls.Add(label3);
            panelRegistro.Controls.Add(txtTelefono);
            panelRegistro.Controls.Add(txtCorreo);
            panelRegistro.Controls.Add(txtDNI);
            panelRegistro.Controls.Add(txtApellido);
            panelRegistro.Controls.Add(txtNombre);
            panelRegistro.Controls.Add(cbTipo);
            panelRegistro.Controls.Add(label2);
            panelRegistro.Controls.Add(lblTelefono);
            panelRegistro.Controls.Add(lblCorreo);
            panelRegistro.Controls.Add(lblDocumento);
            panelRegistro.Controls.Add(lblApellidos);
            panelRegistro.Controls.Add(lblNombre);
            panelRegistro.Controls.Add(label4);
            panelRegistro.Dock = DockStyle.Left;
            panelRegistro.Location = new Point(0, 0);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(729, 603);
            panelRegistro.TabIndex = 0;
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
            button3.Location = new Point(532, 484);
            button3.Name = "button3";
            button3.Size = new Size(134, 32);
            button3.TabIndex = 56;
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
            button2.Location = new Point(380, 484);
            button2.Name = "button2";
            button2.Size = new Size(134, 32);
            button2.TabIndex = 55;
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
            button1.Location = new Point(222, 484);
            button1.Name = "button1";
            button1.Size = new Size(134, 32);
            button1.TabIndex = 54;
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
            btnGuardar.Location = new Point(67, 484);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 32);
            btnGuardar.TabIndex = 53;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cbPrograma
            // 
            cbPrograma.FormattingEnabled = true;
            cbPrograma.Items.AddRange(new object[] { "Pregrado", "Posgrado" });
            cbPrograma.Location = new Point(492, 376);
            cbPrograma.Name = "cbPrograma";
            cbPrograma.Size = new Size(165, 28);
            cbPrograma.TabIndex = 52;
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(9, 15, 70);
            label3.Location = new Point(402, 377);
            label3.Name = "label3";
            label3.Size = new Size(113, 39);
            label3.TabIndex = 51;
            label3.Text = "Programa:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(213, 321);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(361, 27);
            txtTelefono.TabIndex = 50;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(213, 271);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(361, 27);
            txtCorreo.TabIndex = 49;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(213, 222);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(361, 27);
            txtDNI.TabIndex = 48;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(213, 171);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(361, 27);
            txtApellido.TabIndex = 47;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(213, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(361, 27);
            txtNombre.TabIndex = 46;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Estudiante", "Docente", "Invitado" });
            cbTipo.Location = new Point(157, 376);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(179, 28);
            cbTipo.TabIndex = 45;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(9, 15, 70);
            label2.Location = new Point(87, 376);
            label2.Name = "label2";
            label2.Size = new Size(113, 39);
            label2.TabIndex = 44;
            label2.Text = "Tipo:";
            // 
            // lblTelefono
            // 
            lblTelefono.ForeColor = Color.FromArgb(9, 15, 70);
            lblTelefono.Location = new Point(108, 324);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(113, 39);
            lblTelefono.TabIndex = 43;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreo
            // 
            lblCorreo.ForeColor = Color.FromArgb(9, 15, 70);
            lblCorreo.Location = new Point(108, 273);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(113, 39);
            lblCorreo.TabIndex = 42;
            lblCorreo.Text = "Correo:";
            // 
            // lblDocumento
            // 
            lblDocumento.ForeColor = Color.FromArgb(9, 15, 70);
            lblDocumento.Location = new Point(108, 224);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(113, 39);
            lblDocumento.TabIndex = 41;
            lblDocumento.Text = "Documento:";
            // 
            // lblApellidos
            // 
            lblApellidos.ForeColor = Color.FromArgb(9, 15, 70);
            lblApellidos.Location = new Point(108, 175);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(113, 39);
            lblApellidos.TabIndex = 40;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            lblNombre.ForeColor = Color.FromArgb(9, 15, 70);
            lblNombre.Location = new Point(108, 121);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 39);
            lblNombre.TabIndex = 39;
            lblNombre.Text = "Nombres:";
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(9, 15, 70);
            label4.Location = new Point(222, 54);
            label4.Name = "label4";
            label4.Size = new Size(326, 50);
            label4.TabIndex = 38;
            label4.Text = "REGISTRO DE LAS PERSONAS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubFrmPersonas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1282, 603);
            ControlBox = false;
            Controls.Add(panelContenido);
            Name = "SubFrmPersonas";
            Text = "SubFrmPersonas";
            Load += SubFrmPersonas_Load;
            panelContenido.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgRegistro).EndInit();
            panelRegistro.ResumeLayout(false);
            panelRegistro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
        private Panel panel1;
        private Panel panelRegistro;
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