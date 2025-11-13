namespace pyRegistroAsistencia
{
    partial class SubFrmInicio
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
            picImagenEvento = new PictureBox();
            lblTituloEvento = new Label();
            lblCantidadAsistentes = new Label();
            ((System.ComponentModel.ISupportInitialize)picImagenEvento).BeginInit();
            SuspendLayout();
            // 
            // picImagenEvento
            // 
            picImagenEvento.Dock = DockStyle.Fill;
            picImagenEvento.Location = new Point(0, 0);
            picImagenEvento.Name = "picImagenEvento";
            picImagenEvento.Size = new Size(800, 450);
            picImagenEvento.TabIndex = 0;
            picImagenEvento.TabStop = false;
            // 
            // lblTituloEvento
            // 
            lblTituloEvento.AutoSize = true;
            lblTituloEvento.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloEvento.ForeColor = Color.Black;
            lblTituloEvento.Location = new Point(77, 121);
            lblTituloEvento.Name = "lblTituloEvento";
            lblTituloEvento.Size = new Size(324, 43);
            lblTituloEvento.TabIndex = 22;
            lblTituloEvento.Text = "Nombre del Evento";
            // 
            // lblCantidadAsistentes
            // 
            lblCantidadAsistentes.AutoSize = true;
            lblCantidadAsistentes.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold);
            lblCantidadAsistentes.ForeColor = Color.FromArgb(9, 15, 70);
            lblCantidadAsistentes.Location = new Point(371, 353);
            lblCantidadAsistentes.Name = "lblCantidadAsistentes";
            lblCantidadAsistentes.Size = new Size(21, 23);
            lblCantidadAsistentes.TabIndex = 23;
            lblCantidadAsistentes.Text = "0";
            // 
            // SubFrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCantidadAsistentes);
            Controls.Add(lblTituloEvento);
            Controls.Add(picImagenEvento);
            Name = "SubFrmInicio";
            Text = "SubFrmInicio";
            Load += SubFrmInicio_Load;
            ((System.ComponentModel.ISupportInitialize)picImagenEvento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagenEvento;
        private Label lblTituloEvento;
        private Label lblCantidadAsistentes;
    }
}