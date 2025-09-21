using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using System.Drawing.Drawing2D;

namespace Dashboard
{
    public partial class frmLogin : Form
    {
        // Variáveis de controle de conexão
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        private bool isMouseOverBtnEntrar = false;

        // Constante para o raio do arredondamento, como no código fornecido
        private const int borderRadius = 25;

        public frmLogin()
        {
            InitializeComponent();
            conexao = new MySqlConnection("Server=localhost;Port=3306;Database=Db_Pontualize;User=root");

            PicMostrarSenha.Visible = false;

            // Configurações básicas do botão
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.BackColor = ColorTranslator.FromHtml("#303F9F");

            // Assina o evento Paint para arredondar o botão
            btnEntrar.Paint += (sender, e) => RoundControl(btnEntrar, e);
            // Força o redesenho do botão quando o tamanho muda
            btnEntrar.Resize += (sender, e) => btnEntrar.Invalidate();

            // Eventos para controle de MouseOver (se desejar manter o efeito de cor)
            btnEntrar.MouseEnter += (s, e) => { isMouseOverBtnEntrar = true; btnEntrar.Invalidate(); };
            btnEntrar.MouseLeave += (s, e) => { isMouseOverBtnEntrar = false; btnEntrar.Invalidate(); };
            btnEntrar.BackColor = ColorTranslator.FromHtml("#303F9F");
            btnEntrar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#5C6BC0");
            btnEntrar.ForeColor = Color.White; // Ou outra cor
            btnBarra.FlatStyle = FlatStyle.Flat;
            btnBarra.FlatAppearance.BorderSize = 0;

            // Configurações do TextBox Usuário
            txtUsuario.BorderStyle = BorderStyle.None; // Remove a borda padrão
            txtUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point); // Tamanho e estilo adequado
            txtUsuario.Height = txtUsuario.PreferredHeight + 8; // Aumenta levemente a altura

            // Garante que o status do email fique à frente
            lblStatusEmail.BringToFront();

            // esqueci senha
            lblEsqueciSenha.ForeColor = ColorTranslator.FromHtml("#3F51B5");
            lblEsqueciSenha.BackColor = Color.Transparent;
            lblEsqueciSenha.Cursor = Cursors.Hand;

            // Configurações do TextBox Senha
            txtSenha.BorderStyle = BorderStyle.None; // Remove a borda padrão
            txtSenha.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point); // Tamanho e estilo adequado
            txtSenha.Height = txtSenha.PreferredHeight + 8; // Aumenta levemente a altura

            // Garante que o status do email fique à frente
            lblStatusSenha.BringToFront();

        }
        private void RoundControl(Control? control, PaintEventArgs e)
        {
            if (control == null || e == null || control.IsDisposed || !control.IsHandleCreated)
                return;

            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (var path = new GraphicsPath())
                {
                    // Ajusta o retângulo para dentro para evitar que a borda seja cortada pela suavização
                    Rectangle bounds = new Rectangle(0, 0, control.Width - 1, control.Height - 1);

                    path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
                    path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
                    path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
                    path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
                    path.CloseAllFigures();

                    if (!control.IsDisposed && control.IsHandleCreated)
                    {
                        control.Region = new Region(path);
                    }

                    // Cor de fundo do botão (considerando o MouseOver)
                    Color currentBackColor = control.BackColor;
                    if (control is Button button && isMouseOverBtnEntrar) // Verifica se é o btnEntrar e se o mouse está sobre ele
                    {
                        currentBackColor = ColorTranslator.FromHtml("#5C6BC0"); // Cor de MouseOver
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
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no RoundControl: {ex.Message}");
            }
        }

        private void lblEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Visible = false; // Oculta o formulário atual
            frmEsqueciSenha objfEsqueciSenha = new frmEsqueciSenha();
            objfEsqueciSenha.ShowDialog(); // Abre o novo formulário como modal
            this.Close();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                lblStatusEmail.Text = "Campo obrigatório!";
                lblStatusSenha.Text = "";
                txtUsuario.Focus();
                return;
            }
            if (txtSenha.Text == "")
            {
                lblStatusSenha.Text = "Campo obrigatório!";
                lblStatusEmail.Text = "";
                txtSenha.Focus();
                return;
            }

            try
            {
                strSQL = "SELECT senha_Administrador FROM Administrador WHERE email_Administrador = @parUsuario";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@parUsuario", txtUsuario.Text);
                conexao.Open();

                // ExecuteScalar pode retornar null se o usuário não for encontrado
                var senhaDoBancoComHash = comando.ExecuteScalar() as string;

                if (senhaDoBancoComHash == null)
                {
                    lblStatusEmail.Text = "Email ou senha incorretos!";
                    lblStatusSenha.Text = "";
                }
                else
                {
                    // VERIFICA A SENHA DIGITADA CONTRA O HASH DO BANCO
                    bool senhaCorreta = PasswordHash.VerifyPassword(txtSenha.Text, senhaDoBancoComHash);

                    if (!senhaCorreta)
                    {
                        lblStatusEmail.Text = "Email ou senha incorretos!";
                        lblStatusSenha.Text = "";
                        txtSenha.Focus();
                    }
                    else
                    {
                        // Login bem-sucedido!
                        this.Visible = false;
                        frmDashboard_Principal objfDashboard = new frmDashboard_Principal();
                        objfDashboard.ShowDialog();
                        this.Close(); // Fechar o formulário de login após abrir o dashboard
                    }
                }
            }
            catch (MySqlException Erro)
            {
                MessageBox.Show("Erro ao consultar o banco de dados: " + Erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
            }
        }

        private void PicMostrarSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '●') // Se a senha está mascarada
            {
                txtSenha.PasswordChar = '\0'; // Mostra a senha (caractere nulo)
                PicMostrarSenha.Image = Properties.Resources.olho_aberto; // Muda para olho aberto
            }
            else // Se a senha está visível
            {
                txtSenha.PasswordChar = '●'; // Mascara a senha novamente
                PicMostrarSenha.Image = Properties.Resources.olho_fechado; // Muda para olho fechado
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                // Se estiver vazio, esconde o botão de olho
                PicMostrarSenha.Visible = false; // Ou picTogglePassword.Visible = false;
            }
            else
            {
                // Se NÃO estiver vazio, mostra o botão de olho
                PicMostrarSenha.Visible = true; // Ou picTogglePassword.Visible = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
