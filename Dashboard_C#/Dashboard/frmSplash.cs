using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        public class CustomProgressBar : ProgressBar
        {
            public CustomProgressBar()
            {
                this.SetStyle(ControlStyles.UserPaint, true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Rectangle rect = e.ClipRectangle;
                rect.Height = 5; // Defina a altura desejada

                using (SolidBrush brush = new SolidBrush(Color.Blue))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, (int)(rect.Width * ((double)Value / Maximum)), rect.Height);
                }
            }
        }

        public class ColoredProgressBar : ProgressBar
        {
            public ColoredProgressBar()
            {
                this.SetStyle(ControlStyles.UserPaint, true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                // Fundo azul escuro personalizado (#41436A)
                using (SolidBrush backBrush = new SolidBrush(Color.FromArgb(65, 67, 106)))
                {
                    e.Graphics.FillRectangle(backBrush, 0, 0, this.Width, this.Height);
                }

                double percentage = (double)this.Value / this.Maximum;
                int width = (int)(this.Width * percentage);

                // Barra azul clara personalizada (#606EFD)
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
                lblPercentual.Text = $"{progressBar.Value}%"; // Atualiza o texto fora da barra
            }
            else
            {
                timer.Enabled = false;
                this.Visible = false;
                frmLogin objFLogin = new frmLogin();
                objFLogin.Show();
            }

            // Verifique se lblPercentual é visível e se a posição está correta
            lblPercentual.Visible = true;
            lblPercentual.Refresh(); // Força a atualização do label
        }


        private void Pontualize_Load(object sender, EventArgs e)
        {
            ColoredProgressBar customProgressBar = new ColoredProgressBar
            {
                Name = progressBar.Name,
                Location = progressBar.Location,
                Size = new Size(progressBar.Width, 14),
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
            lblPercentual.ForeColor = Color.FromArgb(65, 67, 106); // Azul escuro personalizado
            lblPercentual.BackColor = Color.Transparent;
            lblPercentual.Location = new Point(
                progressBar.Location.X + (progressBar.Width / 2) - 20,
                progressBar.Location.Y + progressBar.Height + 8
            );


            timer.Start();
        }
    }
}
