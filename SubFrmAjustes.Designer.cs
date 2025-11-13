namespace pyRegistroAsistencia
{
    partial class SubFrmAjustes
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
            label3 = new Label();
            label1 = new Label();
            btnSeleccionarImagen = new Button();
            lblRegistroUsuarios = new Label();
            cmbEventoPrincipal = new ComboBox();
            picImagenEvento = new PictureBox();
            btnGuardarCambios = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picImagenEvento).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 102);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 62;
            label3.Text = "Evento Principal:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 227);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 59;
            label1.Text = "IMAGEN";
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.BackColor = Color.FromArgb(9, 15, 70);
            btnSeleccionarImagen.ForeColor = SystemColors.HighlightText;
            btnSeleccionarImagen.Location = new Point(68, 161);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(204, 29);
            btnSeleccionarImagen.TabIndex = 57;
            btnSeleccionarImagen.Text = "CAMBIAR IMAGEN";
            btnSeleccionarImagen.UseVisualStyleBackColor = false;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // lblRegistroUsuarios
            // 
            lblRegistroUsuarios.AutoSize = true;
            lblRegistroUsuarios.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            lblRegistroUsuarios.ForeColor = Color.FromArgb(9, 15, 70);
            lblRegistroUsuarios.Location = new Point(175, 34);
            lblRegistroUsuarios.Name = "lblRegistroUsuarios";
            lblRegistroUsuarios.Size = new Size(191, 23);
            lblRegistroUsuarios.TabIndex = 50;
            lblRegistroUsuarios.Text = "AJUSTES DEL SISTEMA";
            // 
            // cmbEventoPrincipal
            // 
            cmbEventoPrincipal.FormattingEnabled = true;
            cmbEventoPrincipal.Location = new Point(192, 99);
            cmbEventoPrincipal.Name = "cmbEventoPrincipal";
            cmbEventoPrincipal.Size = new Size(250, 28);
            cmbEventoPrincipal.TabIndex = 72;
            // 
            // picImagenEvento
            // 
            picImagenEvento.Location = new Point(79, 265);
            picImagenEvento.Name = "picImagenEvento";
            picImagenEvento.Size = new Size(385, 176);
            picImagenEvento.TabIndex = 73;
            picImagenEvento.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.FromArgb(9, 15, 70);
            btnGuardarCambios.ForeColor = SystemColors.HighlightText;
            btnGuardarCambios.Location = new Point(299, 161);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(204, 29);
            btnGuardarCambios.TabIndex = 74;
            btnGuardarCambios.Text = "GUARDAR CAMBIOS";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // SubFrmAjustes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 505);
            Controls.Add(btnGuardarCambios);
            Controls.Add(picImagenEvento);
            Controls.Add(cmbEventoPrincipal);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnSeleccionarImagen);
            Controls.Add(lblRegistroUsuarios);
            Name = "SubFrmAjustes";
            Text = "SubFrmAjustes";
            Load += SubFrmAjustes_Load;
            ((System.ComponentModel.ISupportInitialize)picImagenEvento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnAgregar;
        private Label label6;
        private DateTimePicker dtpFin;
        private Label label5;
        private DateTimePicker dtpInicio;
        private Label label4;
        private TextBox txtLugar;
        private Label label3;
        private Label label1;
        private Button btnEliminar;
        private Button btnSeleccionarImagen;
        private Label lblRol;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox txtTipoEvento;
        private ComboBox cmbFacultad;
        private TextBox txtDescripcion;
        private Label lblRegistroUsuarios;
        private ComboBox cmbEventoPrincipal;
        private PictureBox picImagenEvento;
        private Button btnGuardarCambios;
        private OpenFileDialog openFileDialog1;
    }
}