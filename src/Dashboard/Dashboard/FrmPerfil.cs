using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using prjTCC;
using System.Drawing.Drawing2D;

namespace Dashboard
{
    public partial class FrmPerfil : Form
    {
        private const int borderRadius = 25; // Mesma constante usada no frmLogin
        private bool isMouseOverBtnVoltar = false;
        private bool isMouseOverBtnAlterar = false;

        private readonly int cursoId;
        private string nomeTurmaAtual = string.Empty;
        public FrmPerfil()
        {
            InitializeComponent();

            // Configurações do btnVoltar
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.BackColor = ColorTranslator.FromHtml("#E9ECEF"); // Cinza claro
            btnVoltar.ForeColor = ColorTranslator.FromHtml("#212529"); // Texto escuro
            btnVoltar.Paint += (s, e) => RoundControl(btnVoltar, e, ref isMouseOverBtnVoltar);
            btnVoltar.Resize += (s, e) => btnVoltar.Invalidate();
            btnVoltar.MouseEnter += (s, e) => { isMouseOverBtnVoltar = true; btnVoltar.Invalidate(); };
            btnVoltar.MouseLeave += (s, e) => { isMouseOverBtnVoltar = false; btnVoltar.Invalidate(); };

            // Configurações do btnAlterar
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.BackColor = ColorTranslator.FromHtml("#5C6BC0"); // Azul principal
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Paint += (s, e) => RoundControl(btnAlterar, e, ref isMouseOverBtnAlterar);
            btnAlterar.Resize += (s, e) => btnAlterar.Invalidate();
            btnAlterar.MouseEnter += (s, e) => { isMouseOverBtnAlterar = true; btnAlterar.Invalidate(); };
            btnAlterar.MouseLeave += (s, e) => { isMouseOverBtnAlterar = false; btnAlterar.Invalidate(); };

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
                    if (control == btnVoltar)
                        currentBackColor = ColorTranslator.FromHtml("#D6D9DC"); // MouseOver cinza
                    else if (control == btnAlterar)
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


        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            // Cria o form de cadastro
            Cadastrar formCadastrar = new Cadastrar();

            // Esconde o FrmPerfil enquanto o formCadastrar está aberto
            this.Hide();

            // Quando o formCadastrar fechar, reexibe o FrmPerfil
            formCadastrar.FormClosed += (s, args) =>
            {
                this.Show();
            };

            // Mostra o formCadastrar
            formCadastrar.Show();
        }


        private void BTN_Relatorio_Direcionamento_Click(object sender, EventArgs e)
        {
            frmDashboard_Principal objFrmDashPrinc = new frmDashboard_Principal();
            objFrmDashPrinc.Show();
            this.Close();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            frmDashboard_Principal objFrmDashPrinc = new frmDashboard_Principal();
            objFrmDashPrinc.Show();
            this.Close();
        }

        private void Notificacao_Direcionamento_Click(object sender, EventArgs e)
        {
            frmNotificacao objfrmNotificacao = new frmNotificacao();
            objfrmNotificacao.Show();
            this.Close();
        }

        private void btnAddAuxiliar_Click(object sender, EventArgs e)
        {

        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmDashboard_Principal objFDashboard = new frmDashboard_Principal();
            objFDashboard.Show();
        }
    }
}
