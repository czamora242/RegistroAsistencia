using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace pyRegistroAsistencia
{
    internal class LineControl : Control
    {
        public Color LineColor { get; set; } = Color.Black;
        public int LineWidth { get; set; } = 2;
        public bool Vertical { get; set; } = false;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(LineColor, LineWidth))
            {
                if (Vertical)
                    e.Graphics.DrawLine(pen, Width / 2, 0, Width / 2, Height);
                else
                    e.Graphics.DrawLine(pen, 0, Height / 2, Width, Height / 2);
            }
        }
    }
}
