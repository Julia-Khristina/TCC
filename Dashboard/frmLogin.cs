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

        public frmLogin()
        {
            InitializeComponent();
            conexao = new MySqlConnection("Server=localhost;Port=3306;Database=Db_Pontualize;User=root");

            // Estilizar o botão sem borda
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.BackColor = ColorTranslator.FromHtml("#41436A");
            btnEntrar.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#606EFD");

            btnBarra.FlatStyle = FlatStyle.Flat;
            btnBarra.FlatAppearance.BorderSize = 0;

            // Configurações do TextBox Usuário
            txtUsuario.BorderStyle = BorderStyle.None; // Remove a borda padrão
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point); // Tamanho e estilo adequado
            txtUsuario.Height = txtUsuario.PreferredHeight + 8; // Aumenta levemente a altura

            // Garante que o status do email fique à frente
            lblStatusEmail.BringToFront();

            // Configurações do TextBox Senha
            txtSenha.BorderStyle = BorderStyle.None; // Remove a borda padrão
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point); // Tamanho e estilo adequado
            txtSenha.Height = txtSenha.PreferredHeight + 8; // Aumenta levemente a altura

            // Garante que o status do email fique à frente
            lblStatusSenha.BringToFront();

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
                comando.ExecuteScalar(); // uma info que retorna
            }
            catch (MySqlException Erro)
            {
                MessageBox.Show("Erro ==>" + Erro.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally
            {
                if (comando.ExecuteScalar() == null)
                {
                    lblStatusEmail.Text = "Email incorreto!";
                    lblStatusSenha.Text = "";
                    conexao.Close();
                    comando = null;
                }
                else
                {
                    if (Convert.ToString(comando.ExecuteScalar()) != txtSenha.Text) // comando para verificar se a senha é igual
                    {
                        lblStatusSenha.Text = "Senha incorreta!";
                        lblStatusEmail.Text = "";
                        txtSenha.Focus();
                        conexao.Close();
                        comando = null;
                    }
                    else
                    {
                        conexao.Close();
                        comando = null;

                        this.Visible = false;
                        frmDashboard_Principal objfDashboard = new frmDashboard_Principal();
                        objfDashboard.ShowDialog();
                    }
                }
            }
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
