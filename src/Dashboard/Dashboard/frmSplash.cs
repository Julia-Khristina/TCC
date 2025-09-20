using System;
using System.ComponentModel; // <-- ADICIONADO: Necessário para a propriedade DesignMode
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
                // -----------------------------
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
                // 1. Código para o modo Design (para evitar erros no editor)
                if (this.DesignMode)
                {
                    using (var brush = new SolidBrush(Color.FromArgb(96, 110, 253)))
                    {
                        e.Graphics.FillRectangle(brush, ClientRectangle);
                        TextRenderer.DrawText(e.Graphics, "ProgressBar Customizada", Font, ClientRectangle, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                    }
                    return;
                }

                // 2. Configurações de desenho para a aplicação em execução
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Raio dinâmico para garantir pontas perfeitamente redondas
                int cornerRadius = this.Height / 2;

                // 3. Cria o caminho arredondado para o fundo, que também servirá como máscara (Clip)
                using (GraphicsPath clipPath = GetRoundedRect(ClientRectangle, cornerRadius))
                {
                    // 4. Desenha o fundo cinza
                    using (SolidBrush backBrush = new SolidBrush(Color.FromArgb(224, 224, 224)))
                    {
                        e.Graphics.FillPath(backBrush, clipPath);
                    }

                    // 5. Calcula a largura do preenchimento (progresso)
                    double percentage = (double)this.Value / this.Maximum;
                    int fillWidth = (int)(this.Width * percentage);

                    // Só desenha o preenchimento se houver progresso
                    if (fillWidth > 0)
                    {
                        // 6. Define a máscara. Tudo desenhado a seguir só aparecerá dentro desta forma.
                        e.Graphics.SetClip(clipPath);

                        // 7. Desenha o preenchimento azul como um retângulo simples.
                        // A máscara (Clip) se encarrega de dar o formato arredondado.
                        using (SolidBrush fillBrush = new SolidBrush(Color.FromArgb(96, 110, 253)))
                        {
                            e.Graphics.FillRectangle(fillBrush, 0, 0, fillWidth, this.Height);
                        }

                        // 8. Limpa a máscara para não afetar outros desenhos.
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
                lblPercentual.Text = $"Carregando! Aguarde... {progressBar.Value}%";
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
            lblPercentual.Text = "Carregando! Aguarde... 0%";
            lblPercentual.Font = new Font("Segoe UI", 10);
            lblPercentual.ForeColor = Color.Gray;
            lblPercentual.BackColor = Color.Transparent;
            lblPercentual.AutoSize = true;
            lblPercentual.Location = new Point(
                (this.ClientSize.Width - lblPercentual.Width) / 2,
                progressBar.Location.Y + progressBar.Height + 10
            );

            timer.Start();
        }
    }
}
