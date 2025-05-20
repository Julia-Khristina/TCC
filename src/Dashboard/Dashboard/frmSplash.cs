using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            timer.Tick += timer_Tick; // Garante que o evento está vinculado
        }

        public class ColoredProgressBar : ProgressBar
        {
            public ColoredProgressBar()
            {
                this.SetStyle(ControlStyles.UserPaint, true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                using (SolidBrush backBrush = new SolidBrush(Color.FromArgb(65, 67, 106)))
                {
                    e.Graphics.FillRectangle(backBrush, 0, 0, this.Width, this.Height);
                }

                double percentage = (double)this.Value / this.Maximum;
                int width = (int)(this.Width * percentage);

                using (SolidBrush fillBrush = new SolidBrush(Color.FromArgb(96, 110, 253)))
                {
                    e.Graphics.FillRectangle(fillBrush, 0, 0, width, this.Height);
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
                this.Hide(); // Oculta a splash
                frmLogin objFLogin = new frmLogin();
                objFLogin.Show(); // Mostra a tela de login
            }

            lblPercentual.Visible = true;
            lblPercentual.Refresh();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            // Substitui a progressBar padrão pela customizada
            ColoredProgressBar customProgressBar = new ColoredProgressBar
            {
                Name = progressBar.Name,
                Location = progressBar.Location,
                Size = new Size(progressBar.Width, 20),
                Maximum = progressBar.Maximum,
                Value = progressBar.Value
            };

            this.Controls.Remove(progressBar);
            progressBar.Dispose();
            progressBar = customProgressBar;
            this.Controls.Add(progressBar);

            // Configura o label
            lblPercentual.Text = "0%";
            lblPercentual.Font = new Font("Segoe UI", 12);
            lblPercentual.ForeColor = Color.FromArgb(65, 67, 106);
            lblPercentual.BackColor = Color.Transparent;
            lblPercentual.Location = new Point(
                progressBar.Location.X + (progressBar.Width / 2) - 20,
                progressBar.Location.Y + progressBar.Height + 8
            );

            timer.Start();
        }
    }
}
