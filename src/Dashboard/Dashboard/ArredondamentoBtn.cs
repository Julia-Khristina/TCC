using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class ArredondamentoBtn : Button
    {
        private int borderRadius = 10;
        private Color borderColor = Color.Transparent;
        private int borderSize = 0;

        // Propriedades para personalização
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

        private bool disableHoverEffect = false;
        public bool DisableHoverEffect
        {
            get { return disableHoverEffect; }
            set
            {
                disableHoverEffect = value;
                // Se o efeito de hover for desabilitado, garantimos que a cor de hover seja a mesma do fundo.
                if (disableHoverEffect)
                {
                    this.FlatAppearance.MouseOverBackColor = this.BackColor;
                }
                
            }
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                // Se o hover estiver desabilitado, garante que a cor de hover
                // seja SEMPRE a mesma da cor de fundo.
                if (disableHoverEffect)
                {
                    this.FlatAppearance.MouseOverBackColor = value;
                }
            }
        }

        // Construtor
        public ArredondamentoBtn()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            // Define a cor padrão, que será interceptada pelo override acima.
            this.BackColor = Color.MidnightBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
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

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) // Botão arredondado
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    // Superfície do botão
                    this.Region = new Region(pathSurface);
                    // Desenhar superfície da borda para suavizar
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Borda do botão
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Botão normal
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                // Superfície do botão
                this.Region = new Region(rectSurface);
                // Borda do botão
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
