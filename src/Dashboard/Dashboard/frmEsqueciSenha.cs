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
    }
}
