using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Dashboard
{
    public partial class PanelSombra : Panel
    {
        // Propriedades para customizar a sombra
        public int ShadowSize { get; set; } = 5;
        public Color ShadowColor { get; set; } = Color.FromArgb(50, 0, 0, 0); // Sombra preta com 50 de opacidade
        public int BorderRadius { get; set; } = 15;
        public PanelSombra()
        {
            // Redesenha o painel quando o tamanho mudar
            this.Resize += (sender, e) => this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Área do painel principal (o conteúdo)
            Rectangle contentRect = new Rectangle(
                0,
                0,
                this.ClientSize.Width - ShadowSize,
                this.ClientSize.Height - ShadowSize
            );

            // Desenha a sombra
            using (GraphicsPath shadowPath = GetRoundedRect(new Rectangle(ShadowSize, ShadowSize, contentRect.Width, contentRect.Height), BorderRadius))
            {
                using (Brush shadowBrush = new SolidBrush(ShadowColor))
                {
                    e.Graphics.FillPath(shadowBrush, shadowPath);
                }
            }

            // Desenha o painel de conteúdo por cima da sombra
            using (GraphicsPath contentPath = GetRoundedRect(contentRect, BorderRadius))
            {
                using (Brush contentBrush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPath(contentBrush, contentPath);
                }
            }
        }

        // Função auxiliar para criar um retângulo com cantos arredondados
        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
