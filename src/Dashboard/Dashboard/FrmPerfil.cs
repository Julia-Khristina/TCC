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
using MySql.Data.MySqlClient;

namespace Dashboard
{
    public partial class FrmPerfil : Form
    {
        //adicionar as váriaveis de controle de conexão
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        private const int borderRadius = 25; // Mesma constante usada no frmLogin
        private bool isMouseOverBtnVoltar = false;
        private bool isMouseOverBtnSalvar = false;
        private bool isMouseOverBtnCancelar = false;

        public FrmPerfil()
        {
            InitializeComponent();

            conexao = new MySqlConnection("Server=localhost;Port=3306;Database=Db_Pontualize;User=root");

            // Configurações do btnVoltar
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.BackColor = ColorTranslator.FromHtml("#E9ECEF"); // Cinza claro
            btnVoltar.ForeColor = ColorTranslator.FromHtml("#212529"); // Texto escuro
            btnVoltar.Paint += (s, e) => RoundControl(btnVoltar, e, ref isMouseOverBtnVoltar);
            btnVoltar.Resize += (s, e) => btnVoltar.Invalidate();
            btnVoltar.MouseEnter += (s, e) => { isMouseOverBtnVoltar = true; btnVoltar.Invalidate(); };
            btnVoltar.MouseLeave += (s, e) => { isMouseOverBtnVoltar = false; btnVoltar.Invalidate(); };

            // Configurações do btnCancelar
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.BackColor = ColorTranslator.FromHtml("#E9ECEF"); // Cinza claro
            btnCancelar.ForeColor = ColorTranslator.FromHtml("#212529"); // Texto escuro
            btnCancelar.Paint += (s, e) => RoundControl(btnCancelar, e, ref isMouseOverBtnCancelar);
            btnCancelar.Resize += (s, e) => btnCancelar.Invalidate();
            btnCancelar.MouseEnter += (s, e) => { isMouseOverBtnCancelar = true; btnVoltar.Invalidate(); };
            btnCancelar.MouseLeave += (s, e) => { isMouseOverBtnCancelar = false; btnVoltar.Invalidate(); };

            // Configurações do btnSalvar
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.BackColor = ColorTranslator.FromHtml("#5C6BC0"); // Azul principal
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Paint += (s, e) => RoundControl(btnSalvar, e, ref isMouseOverBtnSalvar);
            btnSalvar.Resize += (s, e) => btnSalvar.Invalidate();
            btnSalvar.MouseEnter += (s, e) => { isMouseOverBtnSalvar = true; btnSalvar.Invalidate(); };
            btnSalvar.MouseLeave += (s, e) => { isMouseOverBtnSalvar = false; btnSalvar.Invalidate(); };

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
                    else if (control == btnSalvar)
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
            CarregarDadosAdministrador();
            AlternarModoEdicao(false);
        }

        private void AlternarModoEdicao(bool edicaoHabilitada)
        {
            // Habilita/desabilita a edição dos TextBoxes
            txtNome.ReadOnly = !edicaoHabilitada;
            txtEmail.ReadOnly = !edicaoHabilitada;
            txtTelefone.ReadOnly = !edicaoHabilitada;

            var textBoxes = new[] { txtNome, txtEmail, txtTelefone };
            foreach (var txt in textBoxes)
            {
                txt.BorderStyle = BorderStyle.None;      // NUNCA terá borda.
                txt.BackColor = txt.Parent.BackColor;    // O fundo será SEMPRE o do container pai.
            }

            // Requisito 2: Controla a visibilidade dos botões e do link para trocar imagem
            btnEditar.Visible = !edicaoHabilitada;
            btnSalvar.Visible = edicaoHabilitada;
            btnCancelar.Visible = edicaoHabilitada;
            lblTrocarImagem.Visible = edicaoHabilitada;
        }

        private void CarregarDadosAdministrador()
        {
            try
            {
                conexao.Open();
                strSQL = "SELECT nm_Administrador, email_Administrador, telefone_Administrador, imagem_perfil FROM Administrador LIMIT 1";
                comando = new MySqlCommand(strSQL, conexao);
                dr = comando.ExecuteReader();

                if (dr.Read())
                {
                    txtNome.Text = dr["nm_Administrador"].ToString();
                    txtEmail.Text = dr["email_Administrador"].ToString();
                    txtTelefone.Text = dr["telefone_Administrador"].ToString();

                    // Carregar imagem de perfil 
                    if (dr["imagem_perfil"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])dr["imagem_perfil"];

                        // verifica se o array de bytes não está vazio
                        if (imgBytes != null && imgBytes.Length > 0)
                        {
                            try
                            {
                                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imgBytes))
                                {
                                    Imagem_Perfil.Image = Image.FromStream(ms);
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                MessageBox.Show("Erro ao carregar a imagem de perfil: O formato da imagem é inválido ou está corrompido. Detalhes: " + ex.Message, "Erro de Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Imagem_Perfil.Image = null; // Limpa a imagem ou define uma padrão
                            }
                            catch (Exception ex)
                            {
                                // Captura outras exceções inesperadas durante o carregamento da imagem
                                MessageBox.Show("Erro inesperado ao carregar a imagem de perfil: " + ex.Message, "Erro de Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Imagem_Perfil.Image = null; // Limpa a imagem ou define uma padrão
                            }
                        }
                        else
                        {
                            // Caso o array de bytes esteja vazio, mas não seja DBNull
                            Imagem_Perfil.Image = null; // Limpa a imagem ou define uma padrão
                        }
                    }
                    else
                    {
                        // Se o valor no banco de dados for nenhuma imagem cadastrada
                        Imagem_Perfil.Image = null; // Limpa a imagem ou define uma padrão
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum administrador encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do administrador: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza de que deseja salvar as alterações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conexao.Open();
                    strSQL = "UPDATE Administrador SET nm_Administrador=@nome, email_Administrador=@email, telefone_Administrador=@telefone, imagem_perfil=@imagem, ult_atualizacao=CURRENT_TIMESTAMP WHERE cd_Administrador=1";

                    comando = new MySqlCommand(strSQL, conexao);
                    comando.Parameters.AddWithValue("@nome", txtNome.Text);
                    comando.Parameters.AddWithValue("@email", txtEmail.Text);
                    comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                    // Converte a imagem do PictureBox para um array de bytes
                    if (Imagem_Perfil.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            Imagem_Perfil.Image.Save(ms, Imagem_Perfil.Image.RawFormat);
                            comando.Parameters.AddWithValue("@imagem", ms.ToArray());
                        }
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@imagem", DBNull.Value);
                    }

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AlternarModoEdicao(false); // Volta para o modo de visualização
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar alterações: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexao.State == ConnectionState.Open) conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Alterações canceladas.", "Ação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.DialogResult = DialogResult.OK; 
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AlternarModoEdicao(true);
            txtNome.Focus();
        }

        private void lblTrocarImagem_Click(object sender, EventArgs e)
        {
            // janela "Abrir Arquivo"
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // título da janela
            openFileDialog.Title = "Selecione uma imagem de perfil";

            // filtro de arquivos para mostrar apenas imagens
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg; *.jpeg; *.png; *.gif)|*.jpg; *.jpeg; *.png; *.gif";

            // abre a janela e verifica se o usuário clicou em "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // usuário selecionou um arquivo, pega o caminho completo dele
                    string caminhoDoArquivo = openFileDialog.FileName;

                    // carrega a imagem do caminho selecionado 
                    Imagem_Perfil.Image = Image.FromFile(caminhoDoArquivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CarregarDadosAdministrador(); // Restaura os dados originais
            AlternarModoEdicao(false);    // Volta ao modo de visualização
            this.DialogResult = DialogResult.Cancel; // Define o resultado como "Cancel"
            this.Close();
        }

        private void Imagem_Perfil_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 10;

            // controle que está sendo desenhado
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // retângulo que define a área do PictureBox
            Rectangle rect = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);

            // cria o molde com cantos arredondados
            using (GraphicsPath path = GetRoundedRectPath(rect, borderRadius))
            {
                // Aplica o molde ao PictureBox, cortando os cantos
                pictureBox.Region = new Region(path);

                // Desenha a imagem dentro da nova região arredondada
                if (pictureBox.Image != null)
                {
                    // Usar o ClientRectangle garante que a imagem seja desenhada na área visível
                    e.Graphics.DrawImage(pictureBox.Image, pictureBox.ClientRectangle);
                }
            }
        }
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            radius = Math.Max(1, Math.Min(radius, Math.Min(rect.Width / 2, rect.Height / 2)));
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(rect.Right - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(rect.Right - (radius * 2), rect.Bottom - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddArc(rect.X, rect.Bottom - (radius * 2), radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}
