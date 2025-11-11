namespace pyRegistroAsistencia
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            MenuVertical = new Panel();
            btnCerrar = new Button();
            btnEventos = new Button();
            btnAyuda = new Button();
            btnCrearUsuario = new Button();
            btnAjustes = new Button();
            BtnReportes = new Button();
            BtnLista = new Button();
            BtnPersonas = new Button();
            BtnMarcar = new Button();
            btnInicio = new Button();
            pictureBox1 = new PictureBox();
            BarraTitulo = new Panel();
            IconRestaurar = new PictureBox();
            IconMaximizar = new PictureBox();
            IconMinimizar = new PictureBox();
            IconSalir = new PictureBox();
            btnSlide = new PictureBox();
            PanelContenedor = new Panel();
            MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(9, 29, 70);
            MenuVertical.Controls.Add(btnCerrar);
            MenuVertical.Controls.Add(btnEventos);
            MenuVertical.Controls.Add(btnAyuda);
            MenuVertical.Controls.Add(btnCrearUsuario);
            MenuVertical.Controls.Add(btnAjustes);
            MenuVertical.Controls.Add(BtnReportes);
            MenuVertical.Controls.Add(BtnLista);
            MenuVertical.Controls.Add(BtnPersonas);
            MenuVertical.Controls.Add(BtnMarcar);
            MenuVertical.Controls.Add(btnInicio);
            MenuVertical.Controls.Add(pictureBox1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 650);
            MenuVertical.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.FromArgb(225, 225, 225);
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrar.Location = new Point(0, 593);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(250, 50);
            btnCerrar.TabIndex = 10;
            btnCerrar.Text = "Cerrar Sesión";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEventos
            // 
            btnEventos.FlatAppearance.BorderSize = 0;
            btnEventos.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            btnEventos.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            btnEventos.FlatStyle = FlatStyle.Flat;
            btnEventos.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEventos.ForeColor = Color.Gainsboro;
            btnEventos.Image = (Image)resources.GetObject("btnEventos.Image");
            btnEventos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEventos.Location = new Point(1, 386);
            btnEventos.Name = "btnEventos";
            btnEventos.Size = new Size(250, 50);
            btnEventos.TabIndex = 9;
            btnEventos.Text = "Eventos";
            btnEventos.UseVisualStyleBackColor = true;
            btnEventos.Click += btnEventos_Click;
            // 
            // btnAyuda
            // 
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            btnAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAyuda.ForeColor = Color.Gainsboro;
            btnAyuda.Image = (Image)resources.GetObject("btnAyuda.Image");
            btnAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAyuda.Location = new Point(0, 315);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(250, 50);
            btnAyuda.TabIndex = 8;
            btnAyuda.Text = "Ayuda";
            btnAyuda.UseVisualStyleBackColor = true;
            btnAyuda.Click += btnAyuda_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.FlatAppearance.BorderSize = 0;
            btnCrearUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            btnCrearUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            btnCrearUsuario.FlatStyle = FlatStyle.Flat;
            btnCrearUsuario.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearUsuario.ForeColor = Color.Gainsboro;
            btnCrearUsuario.Image = (Image)resources.GetObject("btnCrearUsuario.Image");
            btnCrearUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCrearUsuario.Location = new Point(0, 515);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(250, 50);
            btnCrearUsuario.TabIndex = 7;
            btnCrearUsuario.Text = "Usuarios";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // btnAjustes
            // 
            btnAjustes.FlatAppearance.BorderSize = 0;
            btnAjustes.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            btnAjustes.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            btnAjustes.FlatStyle = FlatStyle.Flat;
            btnAjustes.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjustes.ForeColor = Color.Gainsboro;
            btnAjustes.Image = (Image)resources.GetObject("btnAjustes.Image");
            btnAjustes.ImageAlign = ContentAlignment.MiddleLeft;
            btnAjustes.Location = new Point(1, 249);
            btnAjustes.Name = "btnAjustes";
            btnAjustes.Size = new Size(250, 50);
            btnAjustes.TabIndex = 6;
            btnAjustes.Text = "Ajustes";
            btnAjustes.UseVisualStyleBackColor = true;
            btnAjustes.Click += btnAjustes_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.FlatAppearance.BorderSize = 0;
            BtnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            BtnReportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            BtnReportes.FlatStyle = FlatStyle.Flat;
            BtnReportes.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnReportes.ForeColor = Color.Gainsboro;
            BtnReportes.Image = (Image)resources.GetObject("BtnReportes.Image");
            BtnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            BtnReportes.Location = new Point(0, 442);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(250, 50);
            BtnReportes.TabIndex = 5;
            BtnReportes.Text = "Reportes";
            BtnReportes.UseVisualStyleBackColor = true;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnLista
            // 
            BtnLista.FlatAppearance.BorderSize = 0;
            BtnLista.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            BtnLista.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            BtnLista.FlatStyle = FlatStyle.Flat;
            BtnLista.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLista.ForeColor = Color.Gainsboro;
            BtnLista.Image = (Image)resources.GetObject("BtnLista.Image");
            BtnLista.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLista.Location = new Point(0, 187);
            BtnLista.Name = "BtnLista";
            BtnLista.Size = new Size(250, 50);
            BtnLista.TabIndex = 4;
            BtnLista.Text = "Lista";
            BtnLista.UseVisualStyleBackColor = true;
            BtnLista.Click += BtnLista_Click;
            // 
            // BtnPersonas
            // 
            BtnPersonas.FlatAppearance.BorderSize = 0;
            BtnPersonas.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            BtnPersonas.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            BtnPersonas.FlatStyle = FlatStyle.Flat;
            BtnPersonas.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnPersonas.ForeColor = Color.Gainsboro;
            BtnPersonas.Image = (Image)resources.GetObject("BtnPersonas.Image");
            BtnPersonas.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPersonas.Location = new Point(0, 185);
            BtnPersonas.Name = "BtnPersonas";
            BtnPersonas.Size = new Size(250, 50);
            BtnPersonas.TabIndex = 3;
            BtnPersonas.Text = "Personas";
            BtnPersonas.UseVisualStyleBackColor = true;
            BtnPersonas.Click += BtnPersonas_Click;
            // 
            // BtnMarcar
            // 
            BtnMarcar.FlatAppearance.BorderSize = 0;
            BtnMarcar.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            BtnMarcar.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            BtnMarcar.FlatStyle = FlatStyle.Flat;
            BtnMarcar.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnMarcar.ForeColor = Color.Gainsboro;
            BtnMarcar.Image = (Image)resources.GetObject("BtnMarcar.Image");
            BtnMarcar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMarcar.Location = new Point(0, 128);
            BtnMarcar.Name = "BtnMarcar";
            BtnMarcar.Size = new Size(250, 50);
            BtnMarcar.TabIndex = 2;
            BtnMarcar.Text = "Marcar";
            BtnMarcar.UseVisualStyleBackColor = true;
            BtnMarcar.Click += BtnMarcar_Click;
            // 
            // btnInicio
            // 
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 53, 139);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(44, 53, 139);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.Gainsboro;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 67);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(250, 50);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            BarraTitulo.BackColor = Color.FromArgb(225, 225, 225);
            BarraTitulo.Controls.Add(IconRestaurar);
            BarraTitulo.Controls.Add(IconMaximizar);
            BarraTitulo.Controls.Add(IconMinimizar);
            BarraTitulo.Controls.Add(IconSalir);
            BarraTitulo.Controls.Add(btnSlide);
            BarraTitulo.Dock = DockStyle.Top;
            BarraTitulo.Location = new Point(250, 0);
            BarraTitulo.Name = "BarraTitulo";
            BarraTitulo.Size = new Size(1050, 50);
            BarraTitulo.TabIndex = 1;
            BarraTitulo.MouseDown += BarraTitulo_MouseDown;
            // 
            // IconRestaurar
            // 
            IconRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconRestaurar.Cursor = Cursors.Hand;
            IconRestaurar.Image = (Image)resources.GetObject("IconRestaurar.Image");
            IconRestaurar.Location = new Point(951, 9);
            IconRestaurar.Name = "IconRestaurar";
            IconRestaurar.Size = new Size(35, 35);
            IconRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            IconRestaurar.TabIndex = 4;
            IconRestaurar.TabStop = false;
            IconRestaurar.Visible = false;
            IconRestaurar.Click += IconRestaurar_Click;
            // 
            // IconMaximizar
            // 
            IconMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconMaximizar.Cursor = Cursors.Hand;
            IconMaximizar.Image = (Image)resources.GetObject("IconMaximizar.Image");
            IconMaximizar.Location = new Point(951, 9);
            IconMaximizar.Name = "IconMaximizar";
            IconMaximizar.Size = new Size(35, 35);
            IconMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            IconMaximizar.TabIndex = 3;
            IconMaximizar.TabStop = false;
            IconMaximizar.Click += IconMaximizar_Click;
            // 
            // IconMinimizar
            // 
            IconMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconMinimizar.Cursor = Cursors.Hand;
            IconMinimizar.Image = (Image)resources.GetObject("IconMinimizar.Image");
            IconMinimizar.Location = new Point(910, 7);
            IconMinimizar.Name = "IconMinimizar";
            IconMinimizar.Size = new Size(35, 35);
            IconMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            IconMinimizar.TabIndex = 2;
            IconMinimizar.TabStop = false;
            IconMinimizar.Click += IconMinimizar_Click;
            // 
            // IconSalir
            // 
            IconSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconSalir.Cursor = Cursors.Hand;
            IconSalir.Image = (Image)resources.GetObject("IconSalir.Image");
            IconSalir.Location = new Point(992, 9);
            IconSalir.Name = "IconSalir";
            IconSalir.Size = new Size(35, 35);
            IconSalir.SizeMode = PictureBoxSizeMode.Zoom;
            IconSalir.TabIndex = 1;
            IconSalir.TabStop = false;
            IconSalir.Click += IconSalir_Click;
            // 
            // btnSlide
            // 
            btnSlide.Cursor = Cursors.Hand;
            btnSlide.Image = (Image)resources.GetObject("btnSlide.Image");
            btnSlide.Location = new Point(6, 8);
            btnSlide.Name = "btnSlide";
            btnSlide.Size = new Size(35, 35);
            btnSlide.SizeMode = PictureBoxSizeMode.Zoom;
            btnSlide.TabIndex = 0;
            btnSlide.TabStop = false;
            btnSlide.Click += btnSlide_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.BackColor = Color.FromArgb(225, 225, 225);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(250, 50);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(1050, 600);
            PanelContenedor.TabIndex = 2;
            PanelContenedor.Paint += PanelContenedor_Paint;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(PanelContenedor);
            Controls.Add(BarraTitulo);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IconRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSlide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel BarraTitulo;
        private Panel PanelContenedor;
        private PictureBox btnSlide;
        private PictureBox pictureBox1;
        private PictureBox IconMinimizar;
        private PictureBox IconSalir;
        private PictureBox IconRestaurar;
        private PictureBox IconMaximizar;
        private Button btnInicio;
        private Button btnAjustes;
        private Button BtnReportes;
        private Button BtnLista;
        private Button BtnPersonas;
        private Button BtnMarcar;
        private Button btnCrearUsuario;
        private Button btnAyuda;
        private Button btnEventos;
        private Button btnCerrar;
    }
}
