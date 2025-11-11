namespace pyRegistroAsistencia
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnAcceder = new Button();
            linkPassword = new LinkLabel();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnProbarConexion = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 29, 70);
            panel1.Controls.Add(pictureBox3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(9, 29, 70);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(244, 327);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(214, 214, 214);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.FromArgb(9, 29, 70);
            txtUser.Location = new Point(313, 77);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(408, 18);
            txtUser.TabIndex = 1;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(214, 214, 214);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(9, 29, 70);
            txtPassword.Location = new Point(313, 124);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(408, 18);
            txtPassword.TabIndex = 2;
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(9, 29, 70);
            label1.Location = new Point(492, 32);
            label1.Name = "label1";
            label1.Size = new Size(62, 23);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(9, 29, 70);
            btnAcceder.FlatAppearance.BorderSize = 0;
            btnAcceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAcceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.FromArgb(214, 214, 214);
            btnAcceder.Location = new Point(313, 199);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(408, 50);
            btnAcceder.TabIndex = 3;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // linkPassword
            // 
            linkPassword.ActiveLinkColor = Color.FromArgb(55, 108, 156);
            linkPassword.AutoSize = true;
            linkPassword.LinkColor = Color.FromArgb(9, 29, 70);
            linkPassword.Location = new Point(432, 263);
            linkPassword.Name = "linkPassword";
            linkPassword.Size = new Size(178, 20);
            linkPassword.TabIndex = 5;
            linkPassword.TabStop = true;
            linkPassword.Text = "¿Olvidaste tu contraseña?";
            // 
            // btnCerrar
            // 
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(738, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 6;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(702, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 7;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(315, 163);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(406, 29);
            btnProbarConexion.TabIndex = 8;
            btnProbarConexion.Text = "Probar conexión";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 214, 214);
            ClientSize = new Size(780, 330);
            Controls.Add(btnProbarConexion);
            Controls.Add(btnMinimizar);
            Controls.Add(btnCerrar);
            Controls.Add(linkPassword);
            Controls.Add(btnAcceder);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            Paint += FrmLogin_Paint;
            MouseDown += FrmLogin_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label1;
        private Button btnAcceder;
        private LinkLabel linkPassword;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox pictureBox3;
        private Button btnProbarConexion;
    }
}