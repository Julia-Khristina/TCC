using DPFP;
using DPFP.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTCC
{
    delegate void Function();

    public partial class main : Form
    {

        private const int borderRadius = 25; // Mesma constante usada no frmLogin
        private bool isMouseOverBtnVerify = false;
        private bool isMouseOverBtnReroll = false;

        public main()
        {
            InitializeComponent();
           

            // Configurações do verify
            verify.FlatStyle = FlatStyle.Flat;
            verify.FlatAppearance.BorderSize = 0;
            verify.BackColor = ColorTranslator.FromHtml("#5C6BC0"); // Azul principal
            verify.ForeColor = Color.White;
            verify.Paint += (s, e) => RoundControl(verify, e, ref isMouseOverBtnVerify);
            verify.Resize += (s, e) => verify.Invalidate();
            verify.MouseEnter += (s, e) => { isMouseOverBtnVerify = true; verify.Invalidate(); };
            verify.MouseLeave += (s, e) => { isMouseOverBtnVerify = false; verify.Invalidate(); };


            btnBarra.FlatStyle = FlatStyle.Flat;
            btnBarra.FlatAppearance.BorderSize = 0;

        }

        private void RoundControl(Control control, PaintEventArgs e, ref bool isMouseOver)
        {
            if (control == null || e == null || control.IsDisposed || !control.IsHandleCreated)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = new GraphicsPath())
            {
                Rectangle bounds = new Rectangle(0, 0, control.Width - 1, control.Height - 1);
                path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();

                control.Region = new Region(path);

                // Define a cor considerando MouseOver
                Color currentBackColor = control.BackColor;
                if (isMouseOver)
                {
                    if (control == verify)
                        currentBackColor = ColorTranslator.FromHtml("#7986CB"); // MouseOver azul mais claro
                }

                e.Graphics.FillPath(new SolidBrush(currentBackColor), path);
                e.Graphics.DrawPath(new Pen(control.Parent?.BackColor ?? Color.Transparent, 1), path);

                if (control is Button btn)
                {
                    TextRenderer.DrawText(
                        e.Graphics,
                        btn.Text,
                        btn.Font,
                        control.ClientRectangle,
                        btn.ForeColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }


        //COLOCAR na Dashboard
        private void reroll_Click(object sender, EventArgs e)
        {
            Cadastrar EnFrm = new Cadastrar();
            EnFrm.OnTemplate += SeuMetodoHandler;
            EnFrm.Show();


        }

        private void SeuMetodoHandler(DPFP.Template template)
        {
            if (template != null)
            {
                MessageBox.Show("Digital cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar a digital.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verify_Click(object sender, EventArgs e)
        {
            Verificarform verificarForm = new Verificarform();
            verificarForm.Show(); 

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
