using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Dashboard
{
    public partial class frmTurma : Form
    {
        private const int borderRadius = 15;
        private readonly string connectionString = "Server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;";
        private readonly int cursoId;
        private string nomeTurmaAtual = string.Empty;
        private System.Windows.Forms.Timer timerAtualizacaoTurma;

        public frmTurma(int cd_Curso)
        {
            InitializeComponent();
            ConfigureEventHandlers();

            timerAtualizacaoTurma = new System.Windows.Forms.Timer();
            timerAtualizacaoTurma.Interval = 60000; // Atualiza a cada 1 minuto
            timerAtualizacaoTurma.Tick += TimerAtualizacaoTurma_Tick;
            timerAtualizacaoTurma.Start();


            cursoId = cd_Curso;

            // 1. Turma Selecionada
            menuPrincipal1.TurmaSelecionada += (sender, novoCursoId) =>
            {
                AbrirNovoFormularioTurma(novoCursoId);
            };

            menuPrincipal1.NotificacaoClicada += (sender, e) =>
            {
                frmNotificacao formNotificacao = new frmNotificacao();
                formNotificacao.Show();
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };


            // 3. Perfil Clicado
            menuPrincipal1.PerfilClicado += (sender, e) =>
            {
                FrmPerfil frmPerfil = new FrmPerfil();
                frmPerfil.Show();
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };

            // 4. Sair Clicado
            menuPrincipal1.SairClicado += (sender, e) =>
            {
                Application.Exit();
            };

            // 5. Relatório Clicado
            menuPrincipal1.RelatorioClicado += (sender, e) =>
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

            InitializeTurmaForm();

            // Aplica o evento Paint para os painéis que precisam de bordas arredondadas
            tbAtrasoTurma.CellPainting += new DataGridViewCellPaintingEventHandler(DataGridView_CellPainting);

            // Configura o DataGridView para não ter borda padrão
            tbAtrasoTurma.BorderStyle = BorderStyle.None;
        }


        private void InitializeTurmaForm()
        {
            try
            {
                LoadInitialData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInitialData()
        {
            CarregarNomeDaTurma();
            CarregarAtrasosDaTurma();
            AtualizarLabelsAtrasosTurma();
        }

        private void DataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // desenhar bordas arredondadas para células específicas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);
                // conteúdo personalizado
                // e.Handled = true; // assumir o controle total do desenho da célula
            }
        }

        private void PaintRoundedBorders(Control control, PaintEventArgs e, int borderRadius)
        {
            if (control == null || e == null || control.IsDisposed)
                return;

            // Usa o retângulo do cliente para obter as dimensões corretas.
            Rectangle rect = control.ClientRectangle;

            // Garante que o GraphicsPath seja liberado corretamente.
            using (GraphicsPath path = new GraphicsPath())
            {
                // Adiciona arcos para criar os cantos arredondados.
                int diameter = borderRadius * 2;
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                // Configura o modo de suavização para alta qualidade.
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Define a região do controle para o caminho arredondado.
                control.Region = new Region(path);

                // 1. Preenche o painel com sua cor de fundo.
                using (SolidBrush brush = new SolidBrush(control.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // 2. Desenha uma borda com a cor do PARENTE para suavizar as bordas.
                using (Pen pen = new Pen(control.Parent.BackColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }

            }
        }

        private void ConfigureEventHandlers()
        {
            const int cardBorderRadius = 15;
            // Eventos de arredondamento dos painéis
            pnAtrasos_Totais.Paint += (sender, e) => PaintRoundedBorders(pnAtrasos_Totais, e, cardBorderRadius);
            pnAtrasos_dia.Paint += (sender, e) => PaintRoundedBorders(pnAtrasos_dia, e, cardBorderRadius);
        }

        private void CarregarNomeDaTurma()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT nm_Curso FROM Curso WHERE cd_Curso = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", cursoId);
                        object? result = cmd.ExecuteScalar();
                        nomeTurmaAtual = result?.ToString() ?? "Turma não encontrada";

                        if (lblNmTurma.InvokeRequired)
                        {
                            lblNmTurma.Invoke((MethodInvoker)(() => lblNmTurma.Text = nomeTurmaAtual));
                        }
                        else
                        {
                            lblNmTurma.Text = nomeTurmaAtual;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar nome da turma: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            tbAtrasoTurma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Alinhado à esquerda como no mockup
            tbAtrasoTurma.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tbAtrasoTurma.RowHeadersVisible = false; // Oculta a coluna de cabeçalho de linha
            tbAtrasoTurma.EnableHeadersVisualStyles = false; // Permite customizar o estilo do cabeçalho
            tbAtrasoTurma.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Remove borda do cabeçalho
            tbAtrasoTurma.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Apenas bordas horizontais
            tbAtrasoTurma.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None; // Remove borda inferior da última célula
            tbAtrasoTurma.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            tbAtrasoTurma.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            tbAtrasoTurma.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            // Cores e fontes do cabeçalho da tabela
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            // Cores e fontes das células
            tbAtrasoTurma.DefaultCellStyle.BackColor = Color.White;
            tbAtrasoTurma.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            tbAtrasoTurma.DefaultCellStyle.Font = new Font("Segoe UI", 9F);

            // Estilo da linha selecionada
            tbAtrasoTurma.DefaultCellStyle.SelectionBackColor = Color.FromArgb(168, 230, 207); // Verde suave
            tbAtrasoTurma.DefaultCellStyle.SelectionForeColor = Color.FromArgb(45, 90, 61); // Cor do texto para linha selecionada

            // Remove a borda do DataGridView
            tbAtrasoTurma.BorderStyle = BorderStyle.None;

            // Adiciona padding às células (requer customização ou evento CellPainting)
            // Para um padding visual, você pode ajustar a altura da linha ou usar o evento CellPainting
            tbAtrasoTurma.RowTemplate.Height = 35; // Aumenta a altura da linha para simular padding
        }


        private void CarregarAtrasosDaTurma()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT a.nm_Aluno AS 'Nome do Aluno', 
                                   COUNT(ra.cd_Registro) AS 'Quantidade de Atrasos'
                                   FROM Aluno a
                                   LEFT JOIN RegistroAtraso ra ON a.cd_Aluno = ra.cd_Aluno
                                   WHERE a.Curso_Aluno = @cursoId
                                   GROUP BY a.nm_Aluno
                                   ORDER BY `Quantidade de Atrasos` DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cursoId", cursoId);
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (tbAtrasoTurma.InvokeRequired)
                            {
                                tbAtrasoTurma.Invoke((MethodInvoker)(() =>
                                {
                                    tbAtrasoTurma.DataSource = dt;
                                    ConfigureDataGridView();
                                }));
                            }
                            else
                            {
                                tbAtrasoTurma.DataSource = dt;
                                ConfigureDataGridView();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar atrasos da turma: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ObterCodigoCursoERedirecionar(string nomeTurma)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT cd_Curso FROM Curso WHERE nm_Curso = @nomeTurma";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nomeTurma", nomeTurma);
                        object? result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int novoCursoId = Convert.ToInt32(result);
                            AbrirNovoFormularioTurma(novoCursoId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar turma selecionada: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                VoltarParaDashboard();
            }
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

        private void VoltarParaDashboard()
        {
            try
            {
                Form? parentForm = this.Owner ?? Application.OpenForms.OfType<frmDashboard_Principal>().FirstOrDefault();

                // Oculta o formulário atual primeiro
                this.Hide();

                if (parentForm != null && !parentForm.IsDisposed)
                {
                    parentForm.Show();
                }
                else
                {
                    // Se o dashboard não foi encontrado ou está fechado, pode ser necessário recriá-lo
                    // ou simplesmente fechar este form. Ajuste conforme a lógica da sua aplicação.
                    // Exemplo: Tentar encontrar e mostrar, ou criar um novo se não existir.
                    var dashboard = Application.OpenForms.OfType<frmDashboard_Principal>().FirstOrDefault();
                    if (dashboard != null)
                    {
                        dashboard.Show();
                    }
                    else
                    {
                        // new frmDashboard_Principal().Show(); // Descomente se quiser criar um novo se não houver
                    }
                }

                // Agenda o fechamento do formulário atual para ocorrer depois
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao voltar para o dashboard: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Tenta fechar mesmo em caso de erro
                try { this.BeginInvoke(new MethodInvoker(this.Close)); } catch { }
            }
        }


        private void CleanupResources()
        {
            try
            {
                if (tbAtrasoTurma.DataSource is IDisposable disposable)
                {
                    disposable.Dispose();
                }
            }
            catch { }
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
                    path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                    path.AddArc(control.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                    path.AddArc(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                    path.AddArc(0, control.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                    path.CloseAllFigures();

                    if (!control.IsDisposed && control.IsHandleCreated)
                    {
                        control.Region = new Region(path);
                    }

                    e.Graphics.FillPath(new SolidBrush(control.BackColor), path);
                    e.Graphics.DrawPath(new Pen(control.Parent?.BackColor ?? Color.Transparent, 1), path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro no RoundControl: {ex.Message}");
            }
        }

        private void tbAtrasoTurma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // garante que clicou em uma linha válida
            {
                // Pega o nome do aluno da linha clicada
                string nomeAluno = tbAtrasoTurma.Rows[e.RowIndex].Cells["Nome do Aluno"].Value.ToString();

                // Conexão com banco
                string connStr = "server=localhost;database=Db_Pontualize;uid=root;pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    A.nm_Aluno,
                    A.gmail_aluno,
                    A.telefone_aluno,
                    S.nm_Serie,
                    A.foto_aluno   -- coluna BLOB com a imagem
                FROM Aluno A
                JOIN Serie S ON A.Serie_Aluno = S.cd_Serie
                WHERE A.nm_Aluno = @nome";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeAluno);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblNomeAluno.Text = reader["nm_Aluno"].ToString();
                                lblEmailAluno.Text = reader["gmail_aluno"].ToString();
                                lblTelAluno.Text = reader["telefone_aluno"].ToString();
                                lblAnoAluno.Text = reader["nm_Serie"].ToString();

                                // Verifica se há foto
                                // Supondo que você tenha um MySqlDataReader chamado 'reader'
                                if (reader["foto_aluno"] != DBNull.Value)
                                {
                                    byte[] fotoBytes = (byte[])reader["foto_aluno"];
                                    if (fotoBytes.Length > 0)
                                    {
                                        using (MemoryStream ms = new MemoryStream(fotoBytes))
                                        {
                                            try
                                            {
                                                pictureBoxCarometro.Image = Image.FromStream(ms);
                                            }
                                            catch (ArgumentException)
                                            {
                                                // Se os dados não forem uma imagem válida
                                                pictureBoxCarometro.Image = null; // ou imagem padrão
                                            }
                                        }
                                    }
                                    else
                                    {
                                        pictureBoxCarometro.Image = null;
                                    }
                                }
                                else
                                {
                                    pictureBoxCarometro.Image = null; // não há imagem
                                }

                            }
                            else
                            {
                                MessageBox.Show("Aluno não encontrado no banco.", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Erro ao selecionar a linha desejada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmTurma_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Encontra o dashboard e o mostra novamente
            var dashboard = Application.OpenForms.OfType<frmDashboard_Principal>().FirstOrDefault();
            dashboard?.Show();
        }

        private void frmTurma_Load(object sender, EventArgs e)
        {

        }

        private void pnGraficoTurma_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblNmTurma_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnSolicitarAdvertencia_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Copie e cole estes três métodos na sua classe frmTurma

        private void TimerAtualizacaoTurma_Tick(object sender, EventArgs e)
        {
            AtualizarLabelsAtrasosTurma();
        }

        private void AtualizarLabelsAtrasosTurma()
        {
            // Query para contar atrasos de hoje para a turma específica
            string sqlDia = @"SELECT COUNT(ra.cd_Registro) 
                      FROM RegistroAtraso ra
                      JOIN Aluno a ON ra.cd_Aluno = a.cd_Aluno
                      WHERE ra.data_registro = CURDATE() AND a.Curso_Aluno = @cursoId";

            // Query para contar todos os atrasos da história para a turma específica
            string sqlTotal = @"SELECT COUNT(ra.cd_Registro) 
                        FROM RegistroAtraso ra
                        JOIN Aluno a ON ra.cd_Aluno = a.cd_Aluno
                        WHERE a.Curso_Aluno = @cursoId";

            // IMPORTANTE: Renomeie os labels no seu formulário para corresponderem
            // Supondo que seus labels se chamem 'lblAtrasosDiaValor' e 'lblAtrasosTotaisValor'
            lblDiario.Text = GetAtrasosTurma(sqlDia).ToString();
            label3.Text = GetAtrasosTurma(sqlTotal).ToString();
        }

        private int GetAtrasosTurma(string sql)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@cursoId", this.cursoId);
                    object result = cmd.ExecuteScalar();
                    return result == DBNull.Value ? 0 : Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar atrasos da turma: {ex.Message}");
                return 0;
            }
        }

        private void lblDiario_Click(object sender, EventArgs e)
        {
            // fazer a mesma lógica de carregamento de atrasos para esse
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // fazer a mesma lógica de carregamento de atrasos tbm
        }
    }
}
