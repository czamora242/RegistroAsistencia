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
            btnBuscar = new Button();
            txtBuscar = new TextBox();
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
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1282, 603);
            panelContenido.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgRegistro);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(729, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 603);
            panel1.TabIndex = 1;
            // 
            // dtgRegistro
            // 
            dtgRegistro.BackgroundColor = Color.FromArgb(65, 92, 149);
            dtgRegistro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRegistro.Location = new Point(37, 154);
            dtgRegistro.Name = "dtgRegistro";
            dtgRegistro.RowHeadersWidth = 51;
            dtgRegistro.Size = new Size(564, 401);
            dtgRegistro.TabIndex = 47;
            dtgRegistro.CellClick += dtgRegistro_CellClick;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(9, 15, 70);
            btnBuscar.FlatAppearance.BorderColor = Color.Silver;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(156, 156, 156);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.FromArgb(225, 225, 225);
            btnBuscar.Location = new Point(479, 93);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 32);
            btnBuscar.TabIndex = 43;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(106, 96);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(361, 27);
            txtBuscar.TabIndex = 44;
            // 
            // label5
            // 
            label5.ForeColor = Color.FromArgb(9, 15, 70);
            label5.Location = new Point(38, 93);
            label5.Name = "label5";
            label5.Size = new Size(113, 39);
            label5.TabIndex = 45;
            label5.Text = "Buscar:";
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
            panelRegistro.Name = "panelRegistro";
            panelRegistro.Size = new Size(729, 603);
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
            btnEliminar.Location = new Point(532, 484);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(134, 32);
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
            btnActualizar.Location = new Point(380, 484);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(134, 32);
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
            btnLimpiar.Location = new Point(222, 484);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(134, 32);
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
            btnGuardar.Location = new Point(67, 484);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 32);
            btnGuardar.TabIndex = 53;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label5;
        private Label label6;
    }
}