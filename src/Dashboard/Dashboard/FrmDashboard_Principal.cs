using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using Dashboard.Resources;
using System.Runtime.InteropServices;

namespace Dashboard
{
    public partial class frmDashboard_Principal : Form
    {
        private const int borderRadius = 15;
        private MySqlConnection? connection;
        private readonly string connectionString = "Server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;";
        private System.Windows.Forms.Timer timerAtualizacao; // Timer pra atualizar os cards de atraso

        public frmDashboard_Principal()
        {
            InitializeComponent();

            ConfigureEventHandlers();

            timerAtualizacao = new System.Windows.Forms.Timer();
            timerAtualizacao.Interval = 60000; // 1 min pra atualizar
            timerAtualizacao.Tick += TimerAtualizacao_Tick;
            timerAtualizacao.Start();

            richTextBox1.Text = "Aqui voc� acompanha, em tempo real, os alunos atrasados de cada turma, com relat�rios "
                              + "di�rios, semanais e mensais de forma simples e organizada. O sistema tamb�m utiliza o "
                              + "Power BI para gerar gr�ficos din�micos que deixam a an�lise mais visual e pr�tica, al�m de "
                              + "permitir o download dos relat�rios sempre que precisar.";

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

            // 2. Notifica��o Clicada
            menuPrincipal2.NotificacaoClicada += (sender, e) =>
            {
                frmNotificacao formNotificacao = new frmNotificacao();
                formNotificacao.Show();
                this.Hide(); // Esconde o dashboard para mostrar a notifica��o
            };

            // 3. Perfil Clicado
            menuPrincipal2.PerfilClicado += (sender, e) =>
            {
                FrmPerfil formPerfil = new FrmPerfil();
                formPerfil.Show();
                this.Hide(); // Esconde o dashboard para mostrar o perfil
            };

            // 4. Sair Clicado
            menuPrincipal2.SairClicado += (sender, e) =>
            {
                Application.Exit();
            };

            // 5. Relat�rio Clicado (N�O FAZ NADA, POIS J� EST� NA TELA)
            menuPrincipal2.RelatorioClicado += (sender, e) =>
            {
                // N�o � necess�rio fazer nada aqui. O usu�rio j� est� na tela de relat�rios.
                // Simplesmente ignore o clique.
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

            // Obt�m a �rea de trabalho do monitor onde a janela est�.
            Rectangle workingArea = Screen.FromHandle(this.Handle).WorkingArea;

            // Define a posi��o e o tamanho do formul�rio para preencher a �rea de trabalho.
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

        private void FrmDashboard_Principal_Load(object? sender, EventArgs e)
        {
            AtualizarLabelsAtrasos(); // Atualiza os cards ao abrir
            Maximizar_Tela();
        }


        private void ConfigureEventHandlers()
        {
            const int cardBorderRadius = 15;
            // Eventos de arredondamento dos pain�is
            Painel_Di�rio.Paint += (sender, e) => PaintRoundedBorders(Painel_Di�rio, e, cardBorderRadius);
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

            // Usa o ret�ngulo do cliente para obter as dimens�es corretas.
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

                // Configura o modo de suaviza��o para alta qualidade.
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Define a regi�o do controle para o caminho arredondado.
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

        private void pnConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void arredondamentoBtn6_Click(object sender, EventArgs e)
        {

        }
    }
}
