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
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
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
            panelContenido.Margin = new Padding(3, 2, 3, 2);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1122, 452);
            panelContenido.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgRegistro);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(638, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 452);
            panel1.TabIndex = 1;
            // 
            // dtgRegistro
            // 
            dtgRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRegistro.Columns.AddRange(new DataGridViewColumn[] { nombre, apellidos, dni, correo, telefono, tipo, programa });
            dtgRegistro.Location = new Point(32, 116);
            dtgRegistro.Margin = new Padding(3, 2, 3, 2);
            dtgRegistro.Name = "dtgRegistro";
            dtgRegistro.RowHeadersWidth = 51;
            dtgRegistro.Size = new Size(494, 301);
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
            button4.Location = new Point(419, 70);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(117, 24);
            button4.TabIndex = 43;
            button4.Text = "BUSCAR";
            button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 72);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 23);
            textBox1.TabIndex = 44;
            // 
            // label5
            // 
            label5.ForeColor = Color.FromArgb(9, 15, 70);
            label5.Location = new Point(33, 70);
            label5.Name = "label5";
            label5.Size = new Size(99, 29);
            label5.TabIndex = 45;
            label5.Text = "Buscar:";
            // 
            // label6
            // 
            label6.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(9, 15, 70);
            label6.Location = new Point(137, 35);
            label6.Name = "label6";
            label6.Size = new Size(285, 38);
            label6.TabIndex = 46;
            label6.Text = "BUSQUEDA ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRegistro
            // 
            panelRegistro.Controls.Add(btnEliminar);
            panelRegistro.Controls.Add(btnActualizar);
            panelRegistro.Controls.Add(btnLimpiar);
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
            panelRegistro.Margin = new Padding(3, 2, 3, 2);
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(638, 452);
            panelRegistro.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(9, 15, 70);
            btnEliminar.FlatAppearance.BorderColor = Color.Silver;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.FromArgb(225, 225, 225);
            btnEliminar.Location = new Point(466, 363);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 24);
            btnEliminar.TabIndex = 56;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(9, 15, 70);
            btnActualizar.FlatAppearance.BorderColor = Color.Silver;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.FromArgb(225, 225, 225);
            btnActualizar.Location = new Point(332, 363);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(117, 24);
            btnActualizar.TabIndex = 55;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(9, 15, 70);
            btnLimpiar.FlatAppearance.BorderColor = Color.Silver;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.FromArgb(225, 225, 225);
            btnLimpiar.Location = new Point(194, 363);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(117, 24);
            btnLimpiar.TabIndex = 54;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
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
            btnGuardar.Location = new Point(59, 363);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 24);
            btnGuardar.TabIndex = 53;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbPrograma
            // 
            cbPrograma.FormattingEnabled = true;
            cbPrograma.Items.AddRange(new object[] { "Pregrado", "Posgrado" });
            cbPrograma.Location = new Point(430, 282);
            cbPrograma.Margin = new Padding(3, 2, 3, 2);
            cbPrograma.Name = "cbPrograma";
            cbPrograma.Size = new Size(145, 23);
            cbPrograma.TabIndex = 52;
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(9, 15, 70);
            label3.Location = new Point(352, 283);
            label3.Name = "label3";
            label3.Size = new Size(99, 29);
            label3.TabIndex = 51;
            label3.Text = "Programa:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(186, 241);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(316, 23);
            txtTelefono.TabIndex = 50;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(186, 203);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(316, 23);
            txtCorreo.TabIndex = 49;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(186, 166);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(316, 23);
            txtDNI.TabIndex = 48;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(186, 128);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(316, 23);
            txtApellido.TabIndex = 47;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 88);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(316, 23);
            txtNombre.TabIndex = 46;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Estudiante", "Docente", "Invitado" });
            cbTipo.Location = new Point(137, 282);
            cbTipo.Margin = new Padding(3, 2, 3, 2);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(157, 23);
            cbTipo.TabIndex = 45;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(9, 15, 70);
            label2.Location = new Point(76, 282);
            label2.Name = "label2";
            label2.Size = new Size(99, 29);
            label2.TabIndex = 44;
            label2.Text = "Tipo:";
            // 
            // lblTelefono
            // 
            lblTelefono.ForeColor = Color.FromArgb(9, 15, 70);
            lblTelefono.Location = new Point(94, 243);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(99, 29);
            lblTelefono.TabIndex = 43;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblCorreo
            // 
            lblCorreo.ForeColor = Color.FromArgb(9, 15, 70);
            lblCorreo.Location = new Point(94, 205);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(99, 29);
            lblCorreo.TabIndex = 42;
            lblCorreo.Text = "Correo:";
            // 
            // lblDocumento
            // 
            lblDocumento.ForeColor = Color.FromArgb(9, 15, 70);
            lblDocumento.Location = new Point(94, 168);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(99, 29);
            lblDocumento.TabIndex = 41;
            lblDocumento.Text = "Documento:";
            // 
            // lblApellidos
            // 
            lblApellidos.ForeColor = Color.FromArgb(9, 15, 70);
            lblApellidos.Location = new Point(94, 131);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(99, 29);
            lblApellidos.TabIndex = 40;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            lblNombre.ForeColor = Color.FromArgb(9, 15, 70);
            lblNombre.Location = new Point(94, 91);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(99, 29);
            lblNombre.TabIndex = 39;
            lblNombre.Text = "Nombres:";
            // 
            // label4
            // 
            label4.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(9, 15, 70);
            label4.Location = new Point(194, 40);
            label4.Name = "label4";
            label4.Size = new Size(285, 38);
            label4.TabIndex = 38;
            label4.Text = "REGISTRO DE LAS PERSONAS";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubFrmPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1122, 452);
            ControlBox = false;
            Controls.Add(panelContenido);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnLimpiar;
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