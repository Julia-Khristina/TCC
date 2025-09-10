using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dashboard
{
    public partial class frmEsqueciSenha : Form
    {
        // Variáveis de controle de conexão
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public frmEsqueciSenha()
        {
            InitializeComponent();
            conexao = new MySqlConnection("Server=localhost;Port=3306;Database=Db_Pontualize;User=root");

            PicMostrarSenha.Visible = false;
            PicMostrarSenha2.Visible = false;

            // Estilizar o botão sem borda
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.FlatAppearance.BorderSize = 0;
            btnAlterar.BackColor = ColorTranslator.FromHtml("#606EFD");
            btnAlterar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#41436A");

            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.BackColor = ColorTranslator.FromHtml("#606EFD");
            btnVoltar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#41436A");

            btnBarra.FlatStyle = FlatStyle.Flat;
            btnBarra.FlatAppearance.BorderSize = 0;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin objFLogin = new frmLogin();
            objFLogin.Show();
        }

        private void frmEsqueciSenha_Activated(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConfirmacao.Focus();
            }
        }

        private void txtConfirmacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAlterar.Focus();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string senha = txtSenha.Text.Trim();
            string confirmacao = txtConfirmacao.Text.Trim();

            if (txtEmail.Text == "")
            {
                lblStatusEmail.Text = "Campo obrigatório!";
                lblStatusSenha.Text = "";
                txtEmail.Focus();
                return;
            }

            if (senha != confirmacao)
            {
                lblStatusSenha.Text = "As senhas não coincidem!";
                lblStatusEmail.Text = "";
                txtConfirmacao.Focus();
                return;
            }

            try
            {
                strSQL = "SELECT COUNT(*) FROM Administrador WHERE email_Administrador = @email";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@email", txtEmail.Text.Trim()); // <- ESSA LINHA É NECESSÁRIA!
                conexao.Open();

                int existe = Convert.ToInt32(comando.ExecuteScalar());
                conexao.Close();


                // Atualiza a senha
                strSQL = "UPDATE Administrador SET senha_Administrador = @senha WHERE email_Administrador = @email";
                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();

                MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                new frmLogin().Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao alterar senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void frmEsqueciSenha_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtConfirmacao_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmacao.Text))
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

        private void PicMostrarSenha2_Click(object sender, EventArgs e)
        {
            if (txtConfirmacao.PasswordChar == '●') // Se a senha está mascarada
            {
                txtConfirmacao.PasswordChar = '\0'; // Mostra a senha (caractere nulo)
                PicMostrarSenha.Image = Properties.Resources.olho_aberto; // Muda para olho aberto
            }
            else // Se a senha está visível
            {
                txtConfirmacao.PasswordChar = '●'; // Mascara a senha novamente
                PicMostrarSenha.Image = Properties.Resources.olho_fechado; // Muda para olho fechado
            }
        }
    }
}
