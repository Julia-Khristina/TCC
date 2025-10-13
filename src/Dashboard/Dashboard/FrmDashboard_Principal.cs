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

            ConfigureEventHandlers();

            timerAtualizacao = new System.Windows.Forms.Timer();
            timerAtualizacao.Interval = 60000; // 1 min pra atualizar
            timerAtualizacao.Tick += TimerAtualizacao_Tick;
            timerAtualizacao.Start();

            richTextBox1.Text = "Aqui você acompanha, em tempo real, os alunos atrasados de cada turma, com relatórios "
                              + "diários, semanais e mensais de forma simples e organizada. O sistema também utiliza o "
                              + "Power BI para gerar gráficos dinâmicos que deixam a análise mais visual e prática, além de "
                              + "permitir o download dos relatórios sempre que precisar.";

            JustifyRichText(richTextBox1);

            this.Load += FrmDashboard_Principal_Load;

            //RichTextBox
            richTextBox1.BackColor = Color.Lavender;
            richTextBox1.ReadOnly = true;
            richTextBox1.BorderStyle = BorderStyle.None; // Garante que a borda seja removida
            richTextBox1.TabStop = false;

            // 1. Turma Selecionada
            menuPrincipal2.TurmaSelecionada += (sender, novoCursoId) =>
            {
                frmTurma formTurma = new frmTurma(novoCursoId);
                formTurma.Show();
                this.Hide(); // Esconde o dashboard para mostrar a turma
            };

            // 2. Notificação Clicada
            menuPrincipal2.NotificacaoClicada += (sender, e) =>
            {
                frmNotificacao formNotificacao = new frmNotificacao();
                formNotificacao.Show();
                this.Hide(); // Esconde o dashboard para mostrar a notificação
            };

            // 4. Sair Clicado
            menuPrincipal2.SairClicado += (sender, e) =>
            {
                Application.Exit();
            };

            // 5. Relatório Clicado 
            menuPrincipal2.RelatorioClicado += (sender, e) =>
            {
                // Não é necessário fazer nada aqui. 
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

        private void AtualizarLabelsAtrasos() // Comando para buscar os atrasos do card
        {
            string sqlDia = "SELECT COUNT(*) FROM RegistroAtraso WHERE data_registro = CURDATE()";
            string sqlSemana = "SELECT COUNT(*) FROM RegistroAtraso WHERE YEARWEEK(data_registro, 1) = YEARWEEK(CURDATE(), 1)";
            string sqlMes = "SELECT COUNT(*) FROM RegistroAtraso WHERE YEAR(data_registro) = YEAR(CURDATE()) AND MONTH(data_registro) = MONTH(CURDATE())";

            lblDiario.Text = GetAtrasos(sqlDia).ToString();
            lblSemanal.Text = GetAtrasos(sqlSemana).ToString();
            label4.Text = GetAtrasos(sqlMes).ToString();
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
                ConfigureEventHandlers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar o aplicativo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetNomeAdministrador()
        {
            string nomeAdmin = "Administrador"; // Valor padrão caso não encontre
            string sql = "SELECT nm_Administrador FROM Administrador LIMIT 1";

            try
            {
                // Usa a mesma connectionString que você já tem
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        object result = cmd.ExecuteScalar(); // ExecuteScalar é perfeito para buscar um único valor

                        // Verifica se o resultado não é nulo ou vazio
                        if (result != null && result != DBNull.Value)
                        {
                            nomeAdmin = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Em caso de erro, mostra uma mensagem e mantém o nome padrão
                MessageBox.Show($"Erro ao buscar o nome do administrador: {ex.Message}", "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return nomeAdmin;
        }


        private void FrmDashboard_Principal_Load(object? sender, EventArgs e)
        {
            AtualizarLabelsAtrasos(); // Atualiza os cards ao abrir
            Maximizar_Tela();
            CarregarDadosDoPerfil();
        }


        private void ConfigureEventHandlers()
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

        public void ShowFormWithOverlay(Form dialogForm)
        {
            // formulário de overlay em tempo de execução
            using (Form overlay = new Form())
            {
                overlay.StartPosition = FormStartPosition.Manual;
                overlay.FormBorderStyle = FormBorderStyle.None;
                overlay.Opacity = 0.60; // 70% de opacidade. Ajuste conforme necessário.
                overlay.BackColor = Color.Black;
                overlay.ShowInTaskbar = false;

                // Garante que o overlay cubra o formulário principal inteiro
                overlay.Location = this.Location;
                overlay.Size = this.Size;

                // Exibe o overlay
                overlay.Show();

                // Define o formulário de diálogo como "dono" do overlay
                dialogForm.Owner = overlay;

                dialogForm.ShowDialog();

                // Quando o dialogForm é fechado, o código continua aqui.
                overlay.Close();
            }
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

        private void JustifyRichText(RichTextBox box)
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
            Cadastrar formCadastrar = new Cadastrar();

            // Esconde o FrmPerfil enquanto o formCadastrar está aberto
            this.Hide();

            // Quando o formCadastrar fechar, reexibe o FrmPerfil
            formCadastrar.FormClosed += (s, args) =>
            {
                this.Show();
            };

            // Mostra o formCadastrar
            formCadastrar.Show();
        }

        private void imgConfig_Click(object sender, EventArgs e)
        {
            // Cria a instância do formulário que você quer mostrar
            using (FrmPerfil formPerfil = new FrmPerfil())
            {
                // Centraliza o formulário na tela
                formPerfil.StartPosition = FormStartPosition.CenterParent;

                // Chama nosso método mágico!
                ShowFormWithOverlay(formPerfil);
            }

            // AtualizarInformacoesDoUsuario();
        }

        private void CarregarDadosDoPerfil()
        {
            // Define valores padrão
            string nomeAdmin = "Administrador";
            Image imagemPerfil = null; // Começa sem imagem

            // SQL para buscar nome e imagem de uma vez
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
                                        // Usar 'new Bitmap(ms)' cria uma cópia independente, evitando erros
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
    }
}
