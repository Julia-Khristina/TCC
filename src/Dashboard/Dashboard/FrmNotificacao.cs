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
    public partial class frmNotificacao : Form
    {

        //adicionar as váriaveis de controle de conexão
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        private System.Windows.Forms.Timer notificationTimer;
        public class NotificacaoAluno
        {
            public string NomeAluno { get; set; }
            public string NomeSerie { get; set; }
            public string NomeCurso { get; set; }
            public int TotalAtrasosMes { get; set; }

            public string Titulo
            {
                get => $"{NomeAluno} - {NomeSerie} + {NomeCurso}";
            }

            public string Descricao
            {
                get => $"O(a) estudante registrou {TotalAtrasosMes} faltas no mês atual.";
            }
        }

        private readonly int cursoId;
        private string nomeTurmaAtual = string.Empty;
        private readonly string _conexao;
        public frmNotificacao()
        {
            InitializeComponent();

            _conexao = "Server=localhost;Port=3306;Database=Db_Pontualize;User=root";

            // Configuração do Timer
            notificationTimer = new System.Windows.Forms.Timer();
            notificationTimer.Interval = 300000; // 5 minutos em milissegundos
            notificationTimer.Tick += new EventHandler(NotificationTimer_Tick);
            notificationTimer.Start();

            // 1. Turma Selecionada
            menuPrincipal2.TurmaSelecionada += (sender, novoCursoId) => {
                AbrirNovoFormularioTurma(novoCursoId);
            };

            // 2. Notificação Clicada (MANTENHA APENAS ESTA)
            menuPrincipal2.NotificacaoClicada += (sender, e) => {
                frmNotificacao formNotificacao = new frmNotificacao();
                formNotificacao.Show();
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };

            // 4. Sair Clicado
            menuPrincipal2.SairClicado += (sender, e) => {
                Application.Exit();
            };

            // 5. Relatório Clicado
            menuPrincipal2.RelatorioClicado += (sender, e) => {
                var dashboard = Application.OpenForms.OfType<frmDashboard_Principal>().FirstOrDefault();
                if (dashboard != null)
                {
                    dashboard.Show();
                }
                else
                {
                    new frmDashboard_Principal().Show();
                }
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };
   
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (notificationTimer != null)
            {
                notificationTimer.Stop();
                notificationTimer.Dispose();
            }
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate { CarregarNotificacoes(); });
        }

        private void frmNotificacao_Load(object sender, EventArgs e)
        {
            Maximizar_Tela();
            CarregarNotificacoes();

        }

        private void Maximizar_Tela()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            // Obtém a área de trabalho do monitor onde a janela está.
            Rectangle workingArea = Screen.FromHandle(this.Handle).WorkingArea;

            // Define a posição e o tamanho do formulário para preencher a área de trabalho.
            this.Location = workingArea.Location;
            this.Size = workingArea.Size;

            this.WindowState = FormWindowState.Normal;
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPerfil objfrmPerfil = new FrmPerfil();
            objfrmPerfil.Show();
            this.Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            FrmPerfil objfrmPerfil = new FrmPerfil();
            objfrmPerfil.Show();
            this.Close();
        }

        private void AbrirNovoFormularioTurma(int novoCursoId)
        {
            Form? ownerForm = this.Owner ?? Application.OpenForms.OfType<frmDashboard_Principal>().FirstOrDefault();
            bool ownerWasOriginallyVisible = ownerForm?.Visible ?? false; // Guarda estado inicial do dashboard

            try
            {
                // 1. Cria a nova instância do formulário da turma
                frmTurma newForm = new frmTurma(novoCursoId);

                // 2. Define o Owner (Dashboard) se ele existir
                if (ownerForm != null && !ownerForm.IsDisposed)
                {
                    newForm.Owner = ownerForm;
                }

                // 3. Garante que o Owner (Dashboard) esteja oculto ANTES de mostrar o novo form
                if (ownerForm != null && ownerForm.Visible)
                {
                    ownerForm.Hide();
                }

                // 4. Mostra o NOVO formulário da turma. Ele deve vir para a frente.
                newForm.Show();

                // 5. Esconde o formulário da turma ANTIGA, logo APÓS mostrar o novo.
                this.Hide();

                // 6. Agenda o fechamento seguro do formulário ANTIGO.
                this.BeginInvoke(new MethodInvoker(this.Close));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar trocar de turma: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Tratamento de erro: Tenta fechar este form com segurança
                try { this.BeginInvoke(new MethodInvoker(this.Close)); } catch { }
                // E tenta restaurar a visibilidade do dashboard se ele estava visível originalmente
                if (ownerForm != null && !ownerForm.IsDisposed && ownerWasOriginallyVisible)
                {
                    ownerForm.Show();
                }
            }
            // Não reexibimos o ownerForm aqui em caso de sucesso, pois a navegação é entre Turmas.
        }

        public class Notificacao_Dados
        {
            private readonly string _conexao;

            public Notificacao_Dados(string connectionString)
            {
                _conexao = connectionString;
            }
            public List<NotificacaoAluno> GetNotificacoesAtrasos()
            {
                List<NotificacaoAluno> notificacoes = new List<NotificacaoAluno>();

                // A consulta SQL que busca os alunos com 3+ atrasos no mês atual
                string sqlQuery = @"
                SELECT
                    A.nm_Aluno,
                    S.nm_Serie,
                    C.nm_Curso,
                    COUNT(RA.cd_Registro) AS total_atrasos_mes
                FROM
                    RegistroAtraso RA
                JOIN
                    Aluno A ON RA.cd_Aluno = A.cd_Aluno
                JOIN
                    Serie S ON A.Serie_Aluno = S.cd_Serie
                JOIN
                    Curso C ON A.Curso_Aluno = C.cd_Curso
                WHERE
                    YEAR(RA.data_registro) = YEAR(CURDATE()) AND MONTH(RA.data_registro) = MONTH(CURDATE())
                GROUP BY
                    A.cd_Aluno, A.nm_Aluno, S.nm_Serie, C.nm_Curso
                HAVING
                    COUNT(RA.cd_Registro) >= 3;";

                using (MySqlConnection connection = new MySqlConnection(_conexao))
                {
                    MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                notificacoes.Add(new NotificacaoAluno
                                {
                                    NomeAluno = reader.GetString("nm_Aluno"),
                                    NomeSerie = reader.GetString("nm_Serie"),
                                    NomeCurso = reader.GetString("nm_Curso"),
                                    TotalAtrasosMes = reader.GetInt32("total_atrasos_mes")
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Em um ambiente de produção, registre o erro.
                        MessageBox.Show("Erro ao carregar notificações: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return notificacoes;
            }
        }

        private void CarregarNotificacoes()
        {
            FlowLayoutPanel flowLayoutPanelNotificacoes = this.Controls.Find("flowLayoutPanelNotificacoes", true).OfType<FlowLayoutPanel>().FirstOrDefault();

            if (flowLayoutPanelNotificacoes == null)
            {
                MessageBox.Show("Erro: FlowLayoutPanel 'flowLayoutPanelNotificacoes' não encontrado.", "Erro de Componente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CustomControls.ArredondamentoCard cardModelo = flowLayoutPanelNotificacoes.Controls.OfType<CustomControls.ArredondamentoCard>().FirstOrDefault(c => c.Name == "Card_Notificacao");

            if (cardModelo == null)
            {
                MessageBox.Show("Erro: Card de modelo 'Card_Notificacao' não encontrado.", "Erro de Componente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cardModelo.Visible = false; // Mantenha o modelo oculto

            Notificacao_Dados dao = new Notificacao_Dados(_conexao);
            List<NotificacaoAluno> listaNotificacoes = dao.GetNotificacoesAtrasos();

            // 1. Limpe os cards antigos SOMENTE antes de adicionar os novos
            //    Isso evita que o card modelo seja removido se não houver novas notificações
            flowLayoutPanelNotificacoes.Controls.Clear();
            flowLayoutPanelNotificacoes.Controls.Add(cardModelo); // Adicione o modelo de volta, mas invisível

            if (listaNotificacoes.Count == 0)
            {
                // Opcional: Exibir uma mensagem de que não há notificações
                Label lblSemNotificacoes = new Label();
                lblSemNotificacoes.Text = "Nenhuma notificação encontrada.";
                lblSemNotificacoes.AutoSize = true;
                flowLayoutPanelNotificacoes.Controls.Add(lblSemNotificacoes);
                return;
            }

            foreach (var notificacao in listaNotificacoes)
            {
                CustomControls.ArredondamentoCard novoCard = new CustomControls.ArredondamentoCard();

                // Copie as propriedades do modelo
                novoCard.Width = cardModelo.Width;
                novoCard.Height = cardModelo.Height;
                novoCard.Margin = cardModelo.Margin;
                novoCard.BackColor = cardModelo.BackColor;
                // ... copie outras propriedades de estilo conforme necessário

                // 2. Encontre os labels dentro do novo card e preencha com os dados
                Label lblTitulo = novoCard.Controls.Find("lblTitulo", true).OfType<Label>().FirstOrDefault();
                Label lblDescricao = novoCard.Controls.Find("lblDescricao", true).OfType<Label>().FirstOrDefault();

                if (lblTitulo != null)
                {
                    lblTitulo.Text = notificacao.Titulo;
                }

                if (lblDescricao != null)
                {
                    lblDescricao.Text = notificacao.Descricao;
                }

                // 3. Torne o novo card visível
                novoCard.Visible = true;

                // Adicione o novo card ao painel
                flowLayoutPanelNotificacoes.Controls.Add(novoCard);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
