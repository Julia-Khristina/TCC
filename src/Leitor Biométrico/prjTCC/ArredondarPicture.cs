using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class ArredondarPicture : PictureBox
    {
        private int borderRadius = 25;

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        public ArredondarPicture()
        {
            this.DoubleBuffered = true;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseAllFigures();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // Configuração de Anti-Aliasing
            pe.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rectSurface = this.ClientRectangle;

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            {
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    pe.Graphics.FillPath(brush, pathSurface);
                }

                if (this.Image != null)
                {
                    Image img = this.Image;

                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.SmoothingMode = SmoothingMode.HighQuality;

                        g.SetClip(pathSurface);

                        g.DrawImage(img, 0, 0, this.Width, this.Height);

                        pe.Graphics.DrawImage(bmp, 0, 0);
                    }
                }

                // 5. Desenha a Borda (Opcional)

                /*
                using (Pen borderPen = new Pen(Color.Black, 2))
                {
                    borderPen.Alignment = PenAlignment.Center;
                    pe.Graphics.DrawPath(borderPen, pathSurface);
                }
                */
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Invalidate();
        }
    }
}
