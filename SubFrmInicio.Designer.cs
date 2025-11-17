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
            lblTituloEvento = new Label();
            label1 = new Label();
            flowEventos = new FlowLayoutPanel();
            lblEventoHoy = new Label();
            lblDescripcionHoy = new Label();
            lblFechaHoy = new Label();
            picHoy = new PictureBox();
            btnAsistenciaHoy = new Button();
            panelHoy = new Panel();
            ((System.ComponentModel.ISupportInitialize)picHoy).BeginInit();
            panelHoy.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloEvento
            // 
            lblTituloEvento.AutoSize = true;
            lblTituloEvento.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloEvento.ForeColor = Color.Black;
            lblTituloEvento.Location = new Point(53, 9);
            lblTituloEvento.Name = "lblTituloEvento";
            lblTituloEvento.Size = new Size(224, 36);
            lblTituloEvento.TabIndex = 22;
            lblTituloEvento.Text = "EVENTO DE HOY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(53, 217);
            label1.Name = "label1";
            label1.Size = new Size(274, 36);
            label1.TabIndex = 23;
            label1.Text = "PROXIMOS EVENTOS";
            // 
            // flowEventos
            // 
            flowEventos.AutoScroll = true;
            flowEventos.Location = new Point(86, 256);
            flowEventos.Name = "flowEventos";
            flowEventos.Size = new Size(909, 291);
            flowEventos.TabIndex = 32;
            // 
            // lblEventoHoy
            // 
            lblEventoHoy.AutoSize = true;
            lblEventoHoy.Location = new Point(337, 21);
            lblEventoHoy.Name = "lblEventoHoy";
            lblEventoHoy.Size = new Size(50, 20);
            lblEventoHoy.TabIndex = 31;
            lblEventoHoy.Text = "label8";
            // 
            // lblDescripcionHoy
            // 
            lblDescripcionHoy.AutoSize = true;
            lblDescripcionHoy.Location = new Point(287, 17);
            lblDescripcionHoy.Name = "lblDescripcionHoy";
            lblDescripcionHoy.Size = new Size(50, 20);
            lblDescripcionHoy.TabIndex = 33;
            lblDescripcionHoy.Text = "label2";
            // 
            // lblFechaHoy
            // 
            lblFechaHoy.AutoSize = true;
            lblFechaHoy.Location = new Point(287, 70);
            lblFechaHoy.Name = "lblFechaHoy";
            lblFechaHoy.Size = new Size(50, 20);
            lblFechaHoy.TabIndex = 34;
            lblFechaHoy.Text = "label2";
            // 
            // picHoy
            // 
            picHoy.Location = new Point(10, 11);
            picHoy.Name = "picHoy";
            picHoy.Size = new Size(236, 135);
            picHoy.TabIndex = 35;
            picHoy.TabStop = false;
            // 
            // btnAsistenciaHoy
            // 
            btnAsistenciaHoy.Location = new Point(287, 117);
            btnAsistenciaHoy.Name = "btnAsistenciaHoy";
            btnAsistenciaHoy.Size = new Size(129, 29);
            btnAsistenciaHoy.TabIndex = 36;
            btnAsistenciaHoy.Text = "ASISTENCIA";
            btnAsistenciaHoy.UseVisualStyleBackColor = true;
            btnAsistenciaHoy.Click += btnAsistenciaHoy_Click;
            // 
            // panelHoy
            // 
            panelHoy.Controls.Add(btnAsistenciaHoy);
            panelHoy.Controls.Add(picHoy);
            panelHoy.Controls.Add(lblFechaHoy);
            panelHoy.Controls.Add(lblDescripcionHoy);
            panelHoy.Location = new Point(76, 57);
            panelHoy.Name = "panelHoy";
            panelHoy.Size = new Size(535, 160);
            panelHoy.TabIndex = 37;
            // 
            // SubFrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1032, 553);
            Controls.Add(label1);
            Controls.Add(lblTituloEvento);
            Controls.Add(flowEventos);
            Controls.Add(panelHoy);
            Controls.Add(lblEventoHoy);
            Name = "SubFrmInicio";
            Text = "SubFrmInicio";
            ((System.ComponentModel.ISupportInitialize)picHoy).EndInit();
            panelHoy.ResumeLayout(false);
            panelHoy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTituloEvento;
        private Label label1;
        private PictureBox picImagenEvento;
        private FlowLayoutPanel flowEventos;
        private Label lblEventoHoy;
        private Label lblDescripcionHoy;
        private Label lblFechaHoy;
        private PictureBox picHoy;
        private Button btnAsistenciaHoy;
        private Panel panelHoy;
    }
}