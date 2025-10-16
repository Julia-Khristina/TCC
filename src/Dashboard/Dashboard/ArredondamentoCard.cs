using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    public class ArredondamentoCard : Panel
    {
        private int borderRadius = 15;
        private Color borderColor = Color.Transparent;
        private int borderSize = 0;

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public ArredondamentoCard()
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // suavizar as bordas em controles maiores.
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rectSurface = this.ClientRectangle;

            // Ajusta o retângulo para o desenho da borda interna
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);

            // Fundo do Painel
            if (borderRadius > 1)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                {
                    // Define a região de recorte para que o painel e seus filhos sejam desenhados
                    this.Region = new Region(pathSurface);

                    // Preenche o fundo do painel com a cor BackColor
                    using (SolidBrush brushSurface = new SolidBrush(this.BackColor))
                    {
                        e.Graphics.FillPath(brushSurface, pathSurface);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                using (SolidBrush brushSurface = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillRectangle(brushSurface, rectSurface);
                }
            }

            // Desenho da Borda
            if (borderSize >= 1)
            {
                
                int borderRadiusAdjusted = borderRadius > borderSize ? borderRadius - borderSize : 1;

                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadiusAdjusted))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Center;

                    e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
        }

        // Garante que o painel seja redesenhado quando o tamanho mudar
        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Invalidate();
        }
    }
}
