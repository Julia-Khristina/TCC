using MySql.Data.MySqlClient;
using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Xceed.Words.NET;

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

            pnAlunoAtrasos.Paint += PaintPanel;
            pnAlunoAtrasos.BackColor = Color.White;

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
            // --- ESTRUTURA E COMPORTAMENTO ---
            tbAtrasoTurma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbAtrasoTurma.AllowUserToAddRows = false;
            tbAtrasoTurma.AllowUserToDeleteRows = false;
            tbAtrasoTurma.AllowUserToResizeRows = false;
            tbAtrasoTurma.RowHeadersVisible = false; // Essencial para um look limpo
            tbAtrasoTurma.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // --- BORDAS ---
            tbAtrasoTurma.BorderStyle = BorderStyle.None; // Remove a borda externa
            tbAtrasoTurma.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Apenas linhas horizontais
            tbAtrasoTurma.GridColor = Color.FromArgb(233, 236, 239); // Cor cinza bem clara para as linhas

            // --- CABEÇALHO (ORDER NO, CUSTOMER, etc.) ---
            tbAtrasoTurma.EnableHeadersVisualStyles = false; // Permite customização
            tbAtrasoTurma.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Sem borda no cabeçalho
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender; // Fundo branco, igual ao painel
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Cor do texto cinza/azulado
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 10, 10, 10); // Adiciona espaço à esquerda
            tbAtrasoTurma.ColumnHeadersHeight = 70; // Aumenta a altura do cabeçalho


            // --- CÉLULAS (DADOS) ---
            tbAtrasoTurma.DefaultCellStyle.BackColor = Color.Lavender;
            tbAtrasoTurma.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // Cor do texto principal (escuro)
            tbAtrasoTurma.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            tbAtrasoTurma.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            tbAtrasoTurma.DefaultCellStyle.Padding = new Padding(10, 0, 0, 0); // Adiciona espaço à esquerda
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Lavender;


            // --- ESTILO DA LINHA SELECIONADA ---
            tbAtrasoTurma.DefaultCellStyle.SelectionBackColor = Color.Lavender; // Um cinza muito claro
            tbAtrasoTurma.DefaultCellStyle.SelectionForeColor = Color.FromArgb(44, 62, 80); // Mantém a cor do texto

            // --- ALTURA DAS LINHAS ---
            tbAtrasoTurma.RowTemplate.Height = 45; // Aumenta a altura para dar mais "respiro"
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
        private void PaintPanel(object sender, PaintEventArgs e)
        {
            // Define a qualidade do desenho para ser suave (anti-aliasing)
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Pega o controle (o painel) que acionou o evento
            Control panel = sender as Control;
            if (panel == null) return;

            // Define o raio dos cantos arredondados
            int borderRadius = 15;

            // Cria um caminho gráfico com cantos arredondados
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                var rect = new Rectangle(0, 0, panel.Width, panel.Height);
                int diameter = borderRadius * 2;
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                // Define a região do painel para o caminho arredondado
                panel.Region = new Region(path);

                // Desenha uma borda sutil para um acabamento mais suave
                using (var pen = new Pen(Color.FromArgb(224, 224, 224), 1)) // Cor cinza claro
                {
                    e.Graphics.DrawPath(pen, path);
                }
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
                    A.cd_Aluno,
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
                                lblRM.Text = reader["cd_Aluno"].ToString();
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

        private void frmTurma_Load(object sender, EventArgs e)
        {
            Maximizar_Tela();
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
            pn_Atrasos_Dia.Text = GetAtrasosTurma(sqlTotal).ToString();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSolicitarAdvertencia_Click_1(object sender, EventArgs e)
        {
            Xceed.Words.NET.Licenser.LicenseKey = "WDN51-74N8A-JAYFK-24FA";
            string rmAluno = lblRM.Text;
            string conexao = "server=localhost;database=Db_Pontualize;uid=root;pwd=;";

            try
            {
                using (var conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string query = @"
                        SELECT
                            a.nm_Aluno,
                            s.nm_Serie, 
                            c.nm_Curso, 
                            atrasos 

                        FROM Aluno a 
                        INNER JOIN Serie s on a.Serie_Aluno = s.cd_Serie
                        INNER JOIN Curso c on a.Curso_Aluno = c.cd_Curso
                        WHERE cd_Aluno = @rmAluno
                                    ";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rmAluno", rmAluno);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var dados = new Dictionary<string, string>
                                {
                                    { "NomeAluno", reader["nm_Aluno"].ToString() },
                                    { "SerieAluno", reader["nm_Serie"].ToString() },
                                    { "CursoAluno", reader["nm_Curso"].ToString() },
                                    { "AtrasosAluno", reader["atrasos"].ToString() },
                                    { "DATA", DateTime.Now.ToString("dd/MM/yyyy")}
                                };

                                //string modelo = @"C:\Users\Jane Oliveira\Documents\GitHub\TCC\documentos\ModeloAdvertencia\Modelo.docx";
                                //string saida = $@"C:\Users\Jane Oliveira\Documents\GitHub\TCC\documentos\SaídaAdvertencia\Aluno_{reader["nm_Aluno"]}.docx";

                                string modelo = @"C:\Users\Micro\Documents\GitHub\TCC\documentos\ModeloAdvertencia\Modelo.docx";
                                string saida = $@"C:\Users\Micro\Documents\GitHub\TCC\documentos\SaídaAdvertencia\Aluno_{reader["nm_Aluno"]}.docx";

                                Directory.CreateDirectory(Path.GetDirectoryName(saida));
                                File.Copy(modelo, saida, true);
                                using (var doc = DocX.Load(saida))
                                {
                                    foreach (var item in dados)

                                        doc.ReplaceText(item.Key, item.Value);

                                    doc.Save();
                                }
                                MessageBox.Show("Advertência gerada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(saida));
                            }
                            else
                            {
                                MessageBox.Show("Aluno não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar advertência: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn1Ano_Click(object sender, EventArgs e)
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
                                      AND a.Serie_Aluno = 1
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

        private void btn2Ano_Click(object sender, EventArgs e)
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
                                      AND a.Serie_Aluno = 2
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

        private void btn3Ano_Click(object sender, EventArgs e)
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
                                      AND a.Serie_Aluno = 3
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

        private void pnAtrasos_Totais_Paint(object sender, PaintEventArgs e)
        {

        }

        private void arredondamentoBtn1_Click(object sender, EventArgs e)
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

        private void pnConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnAtrasos_dia_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //Ao clicar neste botão, fazer download do relátorio do power bi da turma selecionada.(usar o index para saber qual turma pelo nome)
            //antes de baixar o arquivo, o power bi deve atualizar os dados para que não esteja faltando nenhum registro.
        }
    }
}
