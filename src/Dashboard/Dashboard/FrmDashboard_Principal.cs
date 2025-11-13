using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using Dashboard.Resources;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using prjTCC;

namespace Dashboard
{
    public partial class frmDashboard_Principal : Form
    {

        //adicionar as váriaveis de controle de conexão
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        private const int borderRadius = 15;
        private MySqlConnection? connection;
        private readonly string connectionString = "Server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;";
        private System.Windows.Forms.Timer timerAtualizacao; // Timer pra atualizar os cards de atraso

        public frmDashboard_Principal()
        {
            InitializeComponent();

            conexao = new MySqlConnection("Server=localhost;Port=3306;Database=Db_Pontualize;User=root");

            ConfiguraEventos();

            timerAtualizacao = new System.Windows.Forms.Timer();
            timerAtualizacao.Interval = 60000; // 1 min pra atualizar
            timerAtualizacao.Tick += TimerAtualizacao_Tick;
            timerAtualizacao.Start();

            richTextBox1.Text = "Aqui você acompanha, em tempo real, os alunos atrasados de cada turma, com relatórios "
                              + "diários, semanais e mensais de forma simples e organizada. O sistema também utiliza o "
                              + "Power BI para gerar gráficos dinâmicos que deixam a análise mais visual e prática, além de "
                              + "permitir o download dos relatórios sempre que precisar.";

            JustificarRichText(richTextBox1);

            this.Load += FrmDashboard_Principal_Load;

            //RichTextBox
            richTextBox1.BackColor = Color.Lavender;
            richTextBox1.ReadOnly = true;
            richTextBox1.BorderStyle = BorderStyle.None; // Garante que a borda seja removida
            richTextBox1.TabStop = false;

            // Turma Selecionada
            menuPrincipal2.TurmaSelecionada += (sender, novoCursoId) =>
            {
                frmTurma formTurma = new frmTurma(novoCursoId);
                formTurma.Show();
                this.Hide(); // Esconde o dashboard para mostrar a turma
            };

            // Notificação Clicada
            menuPrincipal2.NotificacaoClicada += (sender, e) =>
            {
                frmNotificacao formNotificacao = new frmNotificacao();
                formNotificacao.Show();
                this.Hide(); // Esconde o dashboard para mostrar a notificação
            };

            // Sair Clicado
            menuPrincipal2.SairClicado += (sender, e) =>
            {
                Application.Exit();
            };

            // Relatório Clicado 
            menuPrincipal2.RelatorioClicado += (sender, e) =>
            {
                // já está na tela
            };
        }
        private int GetAtrasos(string sql)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    object result = cmd.ExecuteScalar();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar atrasos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

        }

        private string GetTurmaMaisAtrasada(string sqlQuery)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar turma mais atrasada: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "N/A";
            }
        }

        private void AtualizarLabelsAtrasos() // Comando para buscar os atrasos do card
        {
            string sqlDia = "SELECT COUNT(*) FROM RegistroAtraso WHERE data_registro = CURDATE()";
            string sqlSemana = "SELECT COUNT(*) FROM RegistroAtraso WHERE YEARWEEK(data_registro, 1) = YEARWEEK(CURDATE(), 1)";
            string sqlMes = "SELECT COUNT(*) FROM RegistroAtraso WHERE YEAR(data_registro) = YEAR(CURDATE()) AND MONTH(data_registro) = MONTH(CURDATE())";

            lblDiario.Text = GetAtrasos(sqlDia).ToString();
            lblSemanal.Text = GetAtrasos(sqlSemana).ToString();
            lblMensal.Text = GetAtrasos(sqlMes).ToString();

            string sqlTurmaMaisAtrasadaBase = "SELECT CONCAT(RA.nm_Serie, ' ', RA.nm_Curso) AS TurmaCompleta FROM RegistroAtraso RA ";
            string groupByTurma = " GROUP BY TurmaCompleta ORDER BY COUNT(*) DESC LIMIT 1";


            // Atrasos diários 
            string sqlDiaOntem = "SELECT COUNT(*) FROM RegistroAtraso WHERE data_registro = CURDATE() - INTERVAL 1 DAY";
            int atrasosHoje = GetAtrasos(sqlDia);
            int atrasosOntem = GetAtrasos(sqlDiaOntem);
            int diferencaDia = atrasosHoje - atrasosOntem;
            lbl1_CardDiario.Text = (diferencaDia >= 0 ? "↑ " : "↓ ") + Math.Abs(diferencaDia).ToString() + " atrasos em relação a ontem";

            string sqlTurmaMaisAtrasadaDia = sqlTurmaMaisAtrasadaBase + " WHERE RA.data_registro = CURDATE()" + groupByTurma;
            lbl2_CardDiario.Text = "Turma mais atrasada:\n " + GetTurmaMaisAtrasada(sqlTurmaMaisAtrasadaDia);

            // Atrasos semanais 
            string sqlSemanaPassada = "SELECT COUNT(*) FROM RegistroAtraso WHERE YEARWEEK(data_registro, 1) = YEARWEEK(CURDATE() - INTERVAL 7 DAY, 1)";
            int atrasosEstaSemana = GetAtrasos(sqlSemana);
            int atrasosSemanaPassada = GetAtrasos(sqlSemanaPassada);
            int diferencaSemana = atrasosEstaSemana - atrasosSemanaPassada;
            lbl1_CardSemanal.Text = (diferencaSemana >= 0 ? "↑ " : "↓ ") + Math.Abs(diferencaSemana).ToString() + " atrasos em relação à semana passada";

            string sqlTurmaMaisAtrasadaSemana = sqlTurmaMaisAtrasadaBase + " WHERE YEARWEEK(RA.data_registro, 1) = YEARWEEK(CURDATE(), 1)" + groupByTurma;
            lbl2_CardSemanal.Text = "Turma mais atrasada:\n" + GetTurmaMaisAtrasada(sqlTurmaMaisAtrasadaSemana);

            // Atrasos mensais 
            string sqlMesPassado = "SELECT COUNT(*) FROM RegistroAtraso WHERE YEAR(data_registro) = YEAR(CURDATE() - INTERVAL 1 MONTH) AND MONTH(data_registro) = MONTH(CURDATE() - INTERVAL 1 MONTH)";
            int atrasosEsteMes = GetAtrasos(sqlMes);
            int atrasosMesPassado = GetAtrasos(sqlMesPassado);
            int diferencaMes = atrasosEsteMes - atrasosMesPassado;
            lbl1_CardMensal.Text = (diferencaMes >= 0 ? "↑ " : "↓ ") + Math.Abs(diferencaMes).ToString() + " atrasos em relação ao mês passado";

            string sqlTurmaMaisAtrasadaMes = sqlTurmaMaisAtrasadaBase + " WHERE YEAR(RA.data_registro) = YEAR(CURDATE()) AND MONTH(RA.data_registro) = MONTH(CURDATE())" + groupByTurma;
            lbl2_CardMensal.Text = "Turma mais atrasada:\n" + GetTurmaMaisAtrasada(sqlTurmaMaisAtrasadaMes);

            // Notificações
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

            string sqlNotificacaoMesPassado = @"
            SELECT COUNT(*) FROM
            (
                SELECT 
                    A.cd_Aluno
                FROM
                    RegistroAtraso RA
                JOIN
                    Aluno A ON RA.cd_Aluno = A.cd_Aluno
                WHERE
                    YEAR(RA.data_registro) = YEAR(DATE_SUB(CURDATE(), INTERVAL 1 MONTH))
                    AND MONTH(RA.data_registro) = MONTH(DATE_SUB(CURDATE(), INTERVAL 1 MONTH))
                GROUP BY
                    A.cd_Aluno
                HAVING
                    COUNT(RA.cd_Registro) >= 3
            ) AS AlunosNotificados";

            lblNotificacao.Text = ExecutarScalarQuery(sqlNotificacoesMes).ToString();

            // em relação ao mês passado
            int notificacoesMes = GetContagem(sqlNotificacoesMes);
            int notificacoesMesPassado = GetContagem(sqlNotificacaoMesPassado);
            int diferencaMesNot = notificacoesMes - notificacoesMesPassado;

            lbl1_CardNot.Text = (diferencaMesNot >= 0 ? "↑ " : "↓ ") + Math.Abs(diferencaMesNot).ToString() + " em relação ao mês passado";


            string sqlTurmaDestaqueMes = @"
            SELECT CONCAT(a.nm_Serie, ' ', a.nm_Curso) AS turma_completa
            FROM Notificacao n
            JOIN Aluno a ON n.cd_Aluno = a.cd_Aluno
            WHERE YEAR(n.data_notificacao) = YEAR(CURDATE()) 
              AND MONTH(n.data_notificacao) = MONTH(CURDATE())
            GROUP BY turma_completa
            ORDER BY COUNT(n.cd_Notificacao) DESC
            LIMIT 1";

            string turmaDestaque = GetValorString(sqlTurmaDestaqueMes);

            if (string.IsNullOrEmpty(turmaDestaque))
            {
                lbl2_CardNot.Text = "Turma com mais notificações: N/A";
            }
            else
            {
                lbl2_CardNot.Text = "Turma com mais notificações:\n" + turmaDestaque;
            }
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

        public int GetContagem(string query)
        {
            return 0; // Apenas um placeholder
        }

        public string GetValorString(string query)
        {
            return ""; // Apenas um placeholder
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

        private void InitializeApp()
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                connection = new MySqlConnection(connectionString);

                // Carrega os dados e configura os eventos
                ConfiguraEventos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar o aplicativo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDashboard_Principal_Load(object? sender, EventArgs e)
        {
            AtualizarLabelsAtrasos(); // Atualiza os cards ao abrir
            Maximizar_Tela();
            CarregarDadosDoPerfil();
        }


        private void ConfiguraEventos()
        {
            const int cardBorderRadius = 15;
            // Eventos de arredondamento dos painéis
            Painel_Diário.Paint += (sender, e) => PaintRoundedBorders(Painel_Diário, e, cardBorderRadius);
            Painel_Semanal.Paint += (sender, e) => PaintRoundedBorders(Painel_Semanal, e, cardBorderRadius);
            Painel_Mensal.Paint += (sender, e) => PaintRoundedBorders(Painel_Mensal, e, cardBorderRadius);
            Painel_Notificacao.Paint += (sender, e) => PaintRoundedBorders(Painel_Notificacao, e, cardBorderRadius);


            // Evento para fechar o form
            this.FormClosed += Dashboard_Principal_FormClosed;
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

                // Preenche o painel com sua cor de fundo.
                using (SolidBrush brush = new SolidBrush(control.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Desenha uma borda com a cor do PARENTE para suavizar as bordas.
                using (Pen pen = new Pen(control.Parent.BackColor, 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }

            }
        }

        public DialogResult AbrirFormOverlay(Form dialogForm)
        {
            DialogResult result = DialogResult.Cancel;

            using (Form overlay = new Form())
            {
                overlay.StartPosition = FormStartPosition.Manual;
                overlay.FormBorderStyle = FormBorderStyle.None;
                overlay.Opacity = 0.60;
                overlay.BackColor = Color.Black;
                overlay.ShowInTaskbar = false;
                overlay.Owner = this;
                overlay.Location = this.Location;
                overlay.Size = this.Size;

                overlay.Show();

                dialogForm.Owner = overlay;
                dialogForm.StartPosition = FormStartPosition.CenterParent;

                result = dialogForm.ShowDialog();

                overlay.Close();
            }

            return result;
        }




        private void Turmas_Direcionamento_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void ComboBox_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || sender is not ComboBox comboBox) return;

            e.DrawBackground();
            string? text = comboBox.Items[e.Index]?.ToString();
            if (text == null) return;

            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(text, comboBox.Font, brush, e.Bounds, sf);
                }
            }

            e.DrawFocusRectangle();
        }
        private void Dashboard_Principal_FormClosed(object? sender, FormClosedEventArgs e)
        {
            try
            {
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                    connection.Dispose();
                }
            }
            catch { }
        }

        private const int EM_SETPARAFORMAT = 1095;
        private const int PFM_ALIGNMENT = 0x00000008;
        private const int PFA_JUSTIFY = 0x0004;

        [StructLayout(LayoutKind.Sequential)]
        private struct PARAFORMAT
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, ref PARAFORMAT lParam);

        private void JustificarRichText(RichTextBox box)
        {
            PARAFORMAT fmt = new PARAFORMAT();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.dwMask = PFM_ALIGNMENT;
            fmt.wAlignment = PFA_JUSTIFY;

            SendMessage(box.Handle, EM_SETPARAFORMAT, IntPtr.Zero, ref fmt);
        }

        private void TimerAtualizacao_Tick(object sender, EventArgs e)
        {
            AtualizarLabelsAtrasos();
        }
        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            // Cria o form de cadastro
            using (Cadastrar formCadastrar = new Cadastrar())
            {
                formCadastrar.StartPosition = FormStartPosition.CenterParent;

                AbrirFormOverlay(formCadastrar);
            }

        }

        private void imgConfig_Click(object sender, EventArgs e)
        {

            using (FrmPerfil telaPerfil = new FrmPerfil())
            {

                DialogResult resultado = AbrirFormOverlay(telaPerfil);

                if (resultado == DialogResult.OK)
                {
                    CarregarDadosDoPerfil();
                }
            }

        }
        private void CarregarDadosDoPerfil()
        {
            string nomeAdmin = "Administrador";
            Image imagemPerfil = null; // Começa sem imagem

            string sql = "SELECT nm_Administrador, imagem_perfil FROM Administrador LIMIT 1";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Pega o nome
                                if (reader["nm_Administrador"] != DBNull.Value)
                                {
                                    nomeAdmin = reader["nm_Administrador"].ToString();
                                }

                                // Pega a imagem
                                if (reader["imagem_perfil"] != DBNull.Value)
                                {
                                    byte[] imgBytes = (byte[])reader["imagem_perfil"];
                                    if (imgBytes.Length > 0)
                                    {
                                        // Converte os bytes para uma imagem
                                        using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imgBytes))
                                        {
                                            imagemPerfil = new Bitmap(ms);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados do perfil: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Atualiza os controles na tela com os dados encontrados (ou os padrões)
                lblNome.Text = nomeAdmin;
                image_perfil.Image = imagemPerfil; // Assumindo que o nome do seu PictureBox é 'image_perfil'
            }
        }


        private void image_perfil_Click(object sender, EventArgs e)
        {
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

        private void image_perfil_Paint(object sender, PaintEventArgs e)
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

        private void btnCardMeuPerfil_MouseEnter(object sender, EventArgs e)
        {
            btnCardMeuPerfil.BackColor = Color.MidnightBlue;
        }

        private void frmDashboard_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmDashboard_Principal_Activated(object sender, EventArgs e)
        {
            CarregarDadosDoPerfil();
        }

        private void arredondamentoBtn2_Click(object sender, EventArgs e)
        {
            // Envia o usuário para o link no navegador.
            string urlSharePoint = "https://etecspgov-my.sharepoint.com/:u:/r/personal/hillary_medeiros_etec_sp_gov_br/Documents/TCC/Pontualize.pbix?csf=1&web=1&e=OTz6G7";

            try
            {
                // Cria um objeto ProcessStartInfo com a URL
                var psi = new System.Diagnostics.ProcessStartInfo(urlSharePoint)
                {
                    // Define UseShellExecute como true para usar o shell do sistema
                    // e abrir a URL no navegador padrão.
                    UseShellExecute = true
                };

                // Inicia o processo
                System.Diagnostics.Process.Start(psi);

                MessageBox.Show(
                    "O arquivo do Power BI foi aberto no seu navegador (SharePoint).",
                    "Visualização do Relatório",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o navegador: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblMensal_Click(object sender, EventArgs e)
        {

        }
    }
}
