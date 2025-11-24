using MySql.Data.MySqlClient;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dashboard.Notificacao_Dados;
using static Dashboard.NotificacaoAluno;
using static Peg.Base.PegBaseParser;

namespace Dashboard
{
    public partial class frmNotificacao : Form
    {

        // Bloco antigo com problemas
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public event EventHandler<int> TurmaSelecionada;
        private readonly string connectionString = "Server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;";

        private string nomeCursoAtual = string.Empty;
        private string nomeSerieAtual = string.Empty;
        private System.Windows.Forms.Timer notificationTimer;

        public frmNotificacao()
        {
            InitializeComponent();

            // Configuração do Timer
            notificationTimer = new System.Windows.Forms.Timer();
            notificationTimer.Interval = 300000; // 5 minutos em milissegundos
            notificationTimer.Tick += new EventHandler(NotificationTimer_Tick);
            notificationTimer.Start();


            
            // 1. Turma Selecionada
            menuPrincipal2.TurmaSelecionada += (sender, novoCursoId) =>
            {
                AbrirNovoFormularioTurma(novoCursoId);
            };



            // 2. Notificação Clicada (MANTENHA APENAS ESTA)
            menuPrincipal2.NotificacaoClicada += (sender, e) =>
            {
                frmNotificacao formNotificacao = new frmNotificacao();
                formNotificacao.Show();
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };

            // 4. Sair Clicado
            menuPrincipal2.SairClicado += (sender, e) =>
            {
                Application.Exit();
            };

            // 5. Relatório Clicado
            menuPrincipal2.RelatorioClicado += (sender, e) =>
            {
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

            ConfigureEventHandlers();

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
            lblTurma.Text = "  Turmas";
            lblAno.Text = "  Anos";

            CarregarNotificacoes();

            CarregarTurmas();
            CarregarSerie();

            AtualizarLabelsNotificacoesTurma();

            NotificacaoEmail notificacao = new NotificacaoEmail();
            notificacao.VerificarNotificacoesAtrasosPendentes();
            timer1.Interval = 300000; // 5 minutos (300.000 milissegundos)
            timer1.Start();

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
                try { this.BeginInvoke(new MethodInvoker(this.Close)); } catch { }
                if (ownerForm != null && !ownerForm.IsDisposed && ownerWasOriginallyVisible)
                {
                    ownerForm.Show();
                }
            }
        }

        private void ConfigureEventHandlers()
        {
            lblTurma.Click += btnTurma_Click; // Evento de clique para abrir o ComboBox

            // Eventos do ComboBox real (invisível)
            Turmas_Direcionamento.SelectedIndexChanged += Turmas_Direcionamento_SelectedIndexChanged;
            Turmas_Direcionamento.DrawItem += ComboBox_DrawItem_Custom;

            cbAno.SelectedIndexChanged += cbAno_SelectedIndexChanged;
            cbAno.DrawItem += ComboBox_DrawItem_Custom;
        }

        private void ComboBox_DrawItem_Custom(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || sender is not ComboBox comboBox) return;

            // Define as cores
            Color backgroundColor = Color.MidnightBlue;
            Color itemTextColor = Color.White;

            // Muda a cor de fundo se o item estiver selecionado ou com o mouse em cima
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected ||
                (e.State & DrawItemState.HotLight) == DrawItemState.HotLight)
            {
                backgroundColor = Color.FromArgb(195, 205, 235);
                itemTextColor = Color.MidnightBlue;
            }

            // Pinta o fundo do item
            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

            // Pega o texto do item
            string text = comboBox.Items[e.Index].ToString() ?? "";

            // Desenha o texto dentro dos limites do item (e.Bounds)
            TextRenderer.DrawText(e.Graphics, text, comboBox.Font, e.Bounds, itemTextColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

            // 6. Desenha o retângulo de foco (útil para acessibilidade)
            e.DrawFocusRectangle();
        }

        private void Turmas_Direcionamento_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void btnTurma_Click(object? sender, EventArgs e)
        {
            Turmas_Direcionamento.DroppedDown = true;
        }


        private void Turmas_Direcionamento_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (Turmas_Direcionamento.SelectedIndex != -1 && Turmas_Direcionamento.SelectedItem != null)
            {
                // Atualiza o texto do botão
                lblTurma.Text = Turmas_Direcionamento.SelectedItem.ToString()!;

                // Altera o ícone do botão para o índice 4
                lblTurma.ImageIndex = 4;
            }
            else
            {
                // Volta o texto para o padrão
                lblTurma.Text = "  Turmas";

                // Volta o ícone para o índice da seta para baixo 
                lblTurma.ImageIndex = 3;
            }
            Turmas_Direcionamento.Visible = false;

            // Recarrega as notificações com o novo filtro
            CarregarNotificacoes();
        }

        // A função ObterCodigoCursoERedirecionar não é mais necessária para a filtragem de notificação
        // e foi removida do fluxo de Turmas_Direcionamento_SelectedIndexChanged.

        private void ObterCodigoCursoERedirecionar(string nomeTurma)
        {
            try
            {
                using (var tempConnection = new MySqlConnection(connectionString))
                {
                    tempConnection.Open();
                    string query = "SELECT cd_Curso FROM Curso WHERE nm_Curso = @nomeTurma";
                    using (MySqlCommand cmd = new MySqlCommand(query, tempConnection))
                    {
                        cmd.Parameters.AddWithValue("@nomeTurma", nomeTurma);
                        object? result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int cd_Curso = Convert.ToInt32(result);
                            // Dispara o evento com o ID encontrado
                            TurmaSelecionada?.Invoke(this, cd_Curso);
                        }
                        else
                        {
                            MessageBox.Show("Curso não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter ID da turma: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarTurmas()
        {
            try
            {
                using (var tempConnection = new MySqlConnection(connectionString))
                {
                    tempConnection.Open();

                    string query = "SELECT nm_Curso FROM Curso";
                    using (MySqlCommand cmd = new MySqlCommand(query, tempConnection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Turmas_Direcionamento.BeginUpdate();
                        try
                        {
                            Turmas_Direcionamento.Items.Clear();
                            while (reader.Read())
                            {
                                string? curso = reader["nm_Curso"]?.ToString();
                                if (!string.IsNullOrEmpty(curso))
                                {
                                    Turmas_Direcionamento.Items.Add(curso);
                                }
                            }
                        }
                        finally
                        {
                            Turmas_Direcionamento.EndUpdate();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro no MySQL: {ex.Message}", "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar turmas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Turmas_Direcionamento_Leave(object sender, EventArgs e)
        {
            Turmas_Direcionamento.Visible = false;
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

            string cursoFiltro = lblTurma.Text == "  Turmas" ? null : lblTurma.Text;
            string serieFiltro = lblAno.Text == "  Anos" ? null : lblAno.Text;

            // 2. Chama a função de dados com os filtros
            Notificacao_Dados dao = new Notificacao_Dados(connectionString);
            List<NotificacaoAluno> listaNotificacoes = dao.GetNotificacoesAtrasos(cursoFiltro, serieFiltro);

            // Limpa os cards antigos apenas antes de adicionar os novos
            flowLayoutPanelNotificacoes.Controls.Clear();
            flowLayoutPanelNotificacoes.Controls.Add(cardModelo); // Adiciona o modelo de volta, mas invisível

            if (listaNotificacoes.Count == 0)
            {
                Label lblSemNotificacoes = new Label();
                lblSemNotificacoes.Text = "Nenhuma notificação encontrada para os filtros selecionados.";
                lblSemNotificacoes.AutoSize = true;
                flowLayoutPanelNotificacoes.Controls.Add(lblSemNotificacoes);
                return;
            }

            foreach (var notificacao in listaNotificacoes)
            {
                CustomControls.ArredondamentoCard novoCard = CloneCard(cardModelo);

                // Encontra os labels dentro do novo card e preenche com os dados
                Label lblTitulo = novoCard.Controls.Find("lblTitulo_Notificacao", true).OfType<Label>().FirstOrDefault();
                Label lblDescricao = novoCard.Controls.Find("lblDescricao_Notificacao", true).OfType<Label>().FirstOrDefault();
                PictureBox pictureBoxIcone = novoCard.Controls.Find("img_sino", true).OfType<PictureBox>().FirstOrDefault();
                Control molduraSino = novoCard.Controls.Find("molduraSino", true).FirstOrDefault();

                if (lblTitulo != null)
                {
                    lblTitulo.Text = notificacao.Titulo;
                    lblTitulo.Visible = true;
                }

                if (lblDescricao != null)
                {
                    lblDescricao.Text = notificacao.Descricao;
                    lblDescricao.Visible = true;
                }

                if (pictureBoxIcone != null)
                {
                    pictureBoxIcone.Visible = true;
                }

                if (molduraSino != null)
                {
                    molduraSino.Visible = true;
                }

                // Torna o novo card visível
                novoCard.Visible = true;
                // Adiciona o novo card ao painel
                flowLayoutPanelNotificacoes.Controls.Add(novoCard);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private CustomControls.ArredondamentoCard CloneCard(CustomControls.ArredondamentoCard originalCard)
        {
            CustomControls.ArredondamentoCard newCard = new CustomControls.ArredondamentoCard();

            // propriedades visuais e de layout
            newCard.Width = originalCard.Width;
            newCard.Height = originalCard.Height;
            newCard.Margin = originalCard.Margin;
            newCard.Padding = originalCard.Padding;
            newCard.BackColor = originalCard.BackColor;
            newCard.Dock = originalCard.Dock;
            newCard.Anchor = originalCard.Anchor;
            newCard.Location = originalCard.Location;

            // Clona os controles filhos
            foreach (Control control in originalCard.Controls)
            {
                Control newControl = null;
                if (control is Label originalLabel)
                {
                    Label newLabel = new Label();
                    newLabel.Text = originalLabel.Text;
                    newLabel.Font = originalLabel.Font;
                    newLabel.ForeColor = originalLabel.ForeColor;
                    newLabel.AutoSize = originalLabel.AutoSize;
                    newLabel.Location = originalLabel.Location;
                    newLabel.Name = originalLabel.Name;
                    newLabel.Visible = false;
                    newControl = newLabel;
                }
                else if (control is PictureBox originalPictureBox)
                {
                    PictureBox newPictureBox = new PictureBox();
                    newPictureBox.Image = originalPictureBox.Image;
                    newPictureBox.SizeMode = originalPictureBox.SizeMode;
                    newPictureBox.Location = originalPictureBox.Location;
                    newPictureBox.Size = originalPictureBox.Size;
                    newPictureBox.Name = originalPictureBox.Name;
                    newPictureBox.Visible = false;
                    newPictureBox.BackColor = originalPictureBox.BackColor;
                    newControl = newPictureBox;
                }

                else if (control is ArredondamentoBtn originalBtn)
                {
                    ArredondamentoBtn newBtn = new ArredondamentoBtn();
                    newBtn.Image = originalBtn.Image;
                    newBtn.Location = originalBtn.Location;
                    newBtn.Size = originalBtn.Size;
                    newBtn.BackColor = originalBtn.BackColor;
                    newBtn.Name = originalBtn.Name;
                    newBtn.Visible = false;
                    newControl = newBtn;
                }

                if (newControl != null)
                {
                    newCard.Controls.Add(newControl);
                }
            }
            return newCard;
        }

        private void lblTurma_Click(object sender, EventArgs e)
        {
            Turmas_Direcionamento.Focus();
            Turmas_Direcionamento.DroppedDown = true;
        }

        private void ObterCodigoAnoERedirecionar(string nomeSerie)
        {
            try
            {
                using (var tempConnection = new MySqlConnection(connectionString))
                {
                    tempConnection.Open();
                    string query = "SELECT cd_Serie FROM Serie WHERE nm_Serie = @nomeSerie";
                    using (MySqlCommand cmd = new MySqlCommand(query, tempConnection))
                    {
                        cmd.Parameters.AddWithValue("@nomeSerie", nomeSerie);
                        object? result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int cd_Serie = Convert.ToInt32(result);
                            // Dispara o evento com o ID encontrado
                            TurmaSelecionada?.Invoke(this, cd_Serie);
                        }
                        else
                        {
                            MessageBox.Show("Série não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter ID da série: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregarSerie()
        {
            try
            {
                using (var tempConnection = new MySqlConnection(connectionString))
                {
                    tempConnection.Open();

                    string query = "SELECT nm_Serie FROM Serie";
                    using (MySqlCommand cmd = new MySqlCommand(query, tempConnection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        cbAno.BeginUpdate();
                        try
                        {
                            cbAno.Items.Clear();
                            while (reader.Read())
                            {
                                string? curso = reader["nm_Serie"]?.ToString();
                                if (!string.IsNullOrEmpty(curso))
                                {
                                    cbAno.Items.Add(curso);
                                }
                            }
                        }
                        finally
                        {
                            cbAno.EndUpdate();
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro no MySQL: {ex.Message}", "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar série: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAno.SelectedIndex != -1 && cbAno.SelectedItem != null)
            {
                // Atualiza o texto do botão
                lblAno.Text = cbAno.SelectedItem.ToString()!;

                // Altera o ícone do botão para o índice 4
                lblAno.ImageIndex = 4;
            }
            else
            {
                // Volta o texto para o padrão
                lblAno.Text = "  Anos";

                // Volta o ícone para o índice da seta para baixo 
                lblAno.ImageIndex = 3;
            }
            cbAno.Visible = false;

            // Recarrega as notificações com o novo filtro
            CarregarNotificacoes();
        }

        // A função ObterCodigoAnoERedirecionar não é mais necessária para a filtragem de notificação
        // e foi removida do fluxo de cbAno_SelectedIndexChanged.

        private void lblAno_Click(object sender, EventArgs e)
        {
            cbAno.Focus();
            cbAno.DroppedDown = true;
        }

        private void cbAno_Leave(object sender, EventArgs e)
        {
            cbAno.Visible = false;
        }

        private void AtualizarLabelsNotificacoesTurma()
        {
            // SEMANA ATUAL
            string sqlNotificacoesSemana = @"
            SELECT 
                COUNT(*) 
            FROM
                (
                    SELECT 
                        A.cd_Aluno
                    FROM
                        RegistroAtraso RA
                    JOIN
                        Aluno A ON RA.cd_Aluno = A.cd_Aluno
                    WHERE
                        YEARWEEK(RA.data_registro, 1) = YEARWEEK(CURDATE(), 1)
                    GROUP BY
                        A.cd_Aluno
                    HAVING
                        COUNT(RA.cd_Registro) >= 3
                ) AS AlunosNotificados";


            string sqlNotificacoesMes = @"
            SELECT 
                COUNT(*) 
            FROM
                (
                    SELECT 
                        A.cd_Aluno -- Seleciona o ID do aluno
                    FROM
                        RegistroAtraso RA
                    JOIN
                        Aluno A ON RA.cd_Aluno = A.cd_Aluno
                    WHERE
                        YEAR(RA.data_registro) = YEAR(CURDATE()) 
                        AND MONTH(RA.data_registro) = MONTH(CURDATE())
                    GROUP BY
                        A.cd_Aluno
                    HAVING
                        COUNT(RA.cd_Registro) >= 3
                ) AS AlunosNotificados";


            lblNotificacoesSemana.Text = ExecutarScalarQuery(sqlNotificacoesSemana).ToString();
            lblNotificacoesMes.Text = ExecutarScalarQuery(sqlNotificacoesMes).ToString();

        }

        private int ExecutarScalarQuery(string sql)
        {
            int resultado = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    // O parâmetro @cursoId foi removido daqui
                    try
                    {
                        connection.Open();
                        object? result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            resultado = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao executar query: " + ex.Message);
                    }
                }
            }
            return resultado;
        }

        public class NotificacaoEmail
        {
            public MySqlConnection con = new MySqlConnection("server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;");

            public class AlunoAtraso
            {
                public int CodigoAluno { get; set; }
                public string NomeAluno { get; set; }
                public int TotalAtrasos { get; set; }
                public string DatasAtrasosString { get; set; }
                public string EmailAluno { get; set; }
            }



            public void VerificarNotificacoesAtrasosPendentes()
            {
                List<AlunoAtraso> alunosParaNotificar = new List<AlunoAtraso>();

                try
                {
                    con.Open();

                    // SQL REVISADO:
                    // 1. Mantém o HAVING TotalAtrasos = 2 para garantir a contagem exata.
                    // 2. O GROUP_CONCAT é a forma mais confiável de obter as datas.
                    // 3. O filtro NOT IN garante que o e-mail de 2 atrasos não seja reenviado.
                    string query = @"
                        SELECT 
                            RA.cd_Aluno,
                            RA.nm_Aluno,
                            COUNT(RA.cd_Registro) AS TotalAtrasos,
                            GROUP_CONCAT(
                                DATE_FORMAT(RA.data_registro, '%d/%m/%Y')
                                ORDER BY RA.data_registro DESC
                                SEPARATOR '|'
                            ) AS DatasAtrasosString
                        FROM 
                            registroatraso RA
                        WHERE 
                            YEAR(RA.data_registro) = YEAR(CURDATE())
                            AND MONTH(RA.data_registro) = MONTH(CURDATE())
                        GROUP BY 
                            RA.cd_Aluno, RA.nm_Aluno
                        HAVING 
                            TotalAtrasos = 2
                            AND NOT EXISTS (
                                SELECT 1
                                FROM notificacao N
                                WHERE N.cd_Aluno = RA.cd_Aluno
                                AND N.mensagem LIKE '%2 atrasos%'
                            );

                    ";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        alunosParaNotificar.Add(new AlunoAtraso
                        {
                            CodigoAluno = Convert.ToInt32(reader["cd_Aluno"]),
                            NomeAluno = reader["nm_Aluno"].ToString(),
                            EmailAluno = BuscarEmailAluno(Convert.ToInt32(reader["cd_Aluno"])), // Agora correto
                            TotalAtrasos = Convert.ToInt32(reader["TotalAtrasos"]),
                            DatasAtrasosString = reader["DatasAtrasosString"].ToString()
                        });
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao verificar alunos para notificação: " + ex.Message);
                    return;
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

                // 3. Processar e-mails
                foreach (var aluno in alunosParaNotificar)
                {
                    // CORREÇÃO CRÍTICA: Parsing e formatação das datas
                    // 1. Divide a string usando o novo separador '|'
                    var datas = aluno.DatasAtrasosString.Split('|');

                    // 2. Converte as strings de data para DateTime para garantir a validade
                    // Usando CultureInfo.InvariantCulture para o formato dd/MM/yyyy
                    var datasValidas = datas.Select(d =>
                        DateTime.ParseExact(d.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture)
                    ).ToList();

                    // 3. Formata as datas para a mensagem, garantindo que apenas as 2 datas sejam usadas
                    // O ToList() garante que o Select seja executado
                    string datasFormatadas = string.Join(" e ", datasValidas.Select(d => d.ToString("dd/MM/yyyy")));

                    // Lógica da mensagem solicitada pelo usuário
                    string mensagemAtrasos = $"{datasFormatadas}.";

                    // Envia o e-mail
                    EnviarEmail(aluno.NomeAluno, aluno.EmailAluno, mensagemAtrasos);

                    // Marca como enviada (usando a nova tabela de histórico)
                    MarcarComoEnviada(aluno.CodigoAluno, aluno.TotalAtrasos);
                }
            }

            private string BuscarEmailAluno(int cdAluno)
            {
                using (var cx = new MySqlConnection("server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;"))
                {
                    cx.Open();
                    var cmd = new MySqlCommand(
                        "SELECT gmail_aluno FROM aluno WHERE cd_Aluno = @id", cx);
                    cmd.Parameters.AddWithValue("@id", cdAluno);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "";
                }
            }


            // O restante da classe (EnviarEmail e MarcarComoEnviada) permanece o mesmo
            public void EnviarEmail(string nome, string email, string mensagemAtrasos)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("tcchiji@gmail.com", "Sistema Pontualize");
                    mail.To.Add(email);
                    mail.Subject = "Notificação de Atrasos - Pontualize";

                    // Corpo do e-mail em HTML
                    string corpoEmail = $@"
                    <html>
                    <body style='font-family: Arial, sans-serif; color: #333;'>
                        <div style='max-width: 600px; margin: auto; border: 1px solid #e0e0e0; border-radius: 10px; padding: 20px;'>
                           <div style='text-align: center; margin-bottom: 20px;'>
                                <h2 style='color: #2c3e50; margin-top: -2px'>Notificação de atraso</h2>
                            </div>
                            <br>
                            <p>Olá <strong>{nome}</strong>,</p>
                            <p>
                                Este e-mail é um <strong>aviso preventivo</strong> sobre sua pontualidade.
                            </p>

                            <p>
                                Identificamos <strong>2 registros de atraso</strong> durante o mês atual, nas seguintes datas:
                                <strong>{mensagemAtrasos}</strong>
                            </p>

                            <p>
                                Gostaríamos de reforçar que, conforme as normas internas, 
                                <strong>ao atingir 3 atrasos no mesmo mês, uma advertência será automaticamente registrada</strong> 
                                em seu histórico.
                            </p>

                            <p>
                                Recomendamos que fique atento aos horários de entrada para evitar consequências disciplinares.
                            </p>

                            <p>
                                Caso tenha enfrentado alguma dificuldade ou circunstância excepcional, orientamos procurar a coordenação.
                            </p>

                            <div style='text-align: center ;'>
                                <img src='https://raw.githubusercontent.com/Julia-Khristina/TCC/main/src/Dashboard/Dashboard/imgs/LOGO%20AZUL.png' alt='Pontualize Logo' width='130'>
                             </div>

                            <hr style='margin: 0 0;'>
                                <p style='font-size: 10px; color: #888; text-align: center;'>
                                    Esta é uma mensagem automática do sistema Pontualize.<br>
                                    Por favor, não responda este e-mail.
                                </p>
                            

                        </div>
                    </body>
                    </html>";

                    mail.Body = corpoEmail;
                    mail.IsBodyHtml = true;

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("tcchiji@gmail.com", "fmyd uecr rryu rzoi");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao enviar e-mail: " + ex.Message);
                }
            }

            public void MarcarComoEnviada(int codigoAluno, int totalAtrasos)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection("server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;"))
                    {
                        conn.Open(); 
                        string mensagem = $"{totalAtrasos} atrasos registrados no mês.";
                        string sqlInsertNotificacao = @"
                            INSERT INTO notificacao (
                                cd_Aluno, 
                                mensagem, 
                                data_envio
                            ) VALUES (@aluno, @msg, NOW()); SELECT LAST_INSERT_ID(); ";
                        
                        MySqlCommand cmd = new MySqlCommand(sqlInsertNotificacao, conn); 
                        cmd.Parameters.AddWithValue("@aluno", codigoAluno); 
                        cmd.Parameters.AddWithValue("@msg", mensagem); 
                        int cdNotificacao = Convert.ToInt32(cmd.ExecuteScalar()); 
                        
                        // Inserir na tabela NOTIFICACAOENVIADA
                        
                        string sqlInsertEnvio = @"
                            INSERT INTO notificacaoenviada (
                                cd_Notificacao, 
                                data_envio) VALUES (@idNotif, NOW())
                            "; 
                        MySqlCommand cmd2 = new MySqlCommand(sqlInsertEnvio, conn); 
                        cmd2.Parameters.AddWithValue("@idNotif", cdNotificacao); 
                        cmd2.ExecuteNonQuery(); 
                    } 
                } 
                catch (Exception ex) { 
                    MessageBox.Show("Erro ao marcar notificação como enviada: " + ex.Message); 
                } 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NotificacaoEmail notificacao = new NotificacaoEmail();
            notificacao.VerificarNotificacoesAtrasosPendentes();
        }
    }
}