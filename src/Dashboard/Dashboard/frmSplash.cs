using System;
using System.ComponentModel; 
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            timer.Tick += timer_Tick;
        }

        public class ColoredProgressBar : ProgressBar
        {
            public ColoredProgressBar()
            {
                this.SetStyle(ControlStyles.UserPaint, true);

                this.DoubleBuffered = true;
            }

            private static GraphicsPath GetRoundedRect(Rectangle bounds, int radius)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
                path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
                path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                return path;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                // Modo Design pra evitar erros no editor
                if (this.DesignMode)
                {
                    using (var brush = new SolidBrush(Color.FromArgb(96, 110, 253)))
                    {
                        e.Graphics.FillRectangle(brush, ClientRectangle);
                        TextRenderer.DrawText(e.Graphics, "ProgressBar Customizada", Font, ClientRectangle, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                    }
                    return;
                }

                // Configurações de desenho pra execução
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // pontas redondas
                int cornerRadius = this.Height / 2;

                // fundo arredondado 
                using (GraphicsPath clipPath = GetRoundedRect(ClientRectangle, cornerRadius))
                {
                    // fundo cinza
                    using (SolidBrush backBrush = new SolidBrush(Color.Transparent))
                    {
                        e.Graphics.FillPath(backBrush, clipPath);
                    }

                    // largura do preenchimento (progresso)
                    double percentage = (double)this.Value / this.Maximum;
                    int fillWidth = (int)(this.Width * percentage);

                    // Só desenha o preenchimento 
                    if (fillWidth > 0)
                    {
                        e.Graphics.SetClip(clipPath);

                        // preenchimento azul
                        using (SolidBrush fillBrush = new SolidBrush(Color.FromArgb(63, 81, 181)))

                        {
                            e.Graphics.FillRectangle(fillBrush, 0, 0, fillWidth, this.Height);
                        }

                        // Limpa a máscara para não afetar outros desenhos.
                        e.Graphics.ResetClip();
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
                lblPercentual.Text = $"{progressBar.Value}%";
            }
            else
            {
                timer.Enabled = false;
                this.Hide();
                frmLogin objFLogin = new frmLogin();
                objFLogin.Show();
            }
            // Centraliza o label novamente a cada tick, caso o texto mude de tamanho
            lblPercentual.Location = new Point(
                (this.ClientSize.Width - lblPercentual.Width) / 2,
                progressBar.Location.Y + progressBar.Height + 10
            );
            lblPercentual.Refresh();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            // Substitui a progressBar padrão pela customizada
            ColoredProgressBar customProgressBar = new ColoredProgressBar
            {
                Name = "progressBar",
                Location = progressBar.Location,
                Size = new Size(progressBar.Width, 20),
                Maximum = progressBar.Maximum,
                Value = progressBar.Value,
                ForeColor = Color.FromArgb(96, 110, 253),
                BackColor = Color.FromArgb(224, 224, 224)
            };

            this.Controls.Remove(progressBar);
            progressBar.Dispose();
            progressBar = customProgressBar;
            this.Controls.Add(progressBar);

            // Configura o label
            lblPercentual.Text = "0%";
            lblPercentual.Font = new Font("Microsoft Sans Serif", 10);
            lblPercentual.ForeColor = Color.Gray;
            lblPercentual.BackColor = Color.Transparent;
            lblPercentual.AutoSize = true;
            lblPercentual.Location = new Point(
                (this.ClientSize.Width - lblPercentual.Width) / 2,
                progressBar.Location.Y + progressBar.Height + 10
            );

            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
