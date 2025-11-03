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
using static Peg.Base.PegBaseParser;
using static Dashboard.Notificacao_Dados;

using static Dashboard.NotificacaoAluno;

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


    }
}