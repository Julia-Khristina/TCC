using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;
using Dashboard.Resources;

namespace Dashboard
{
    public partial class frmDashboard_Principal : Form
    {
        private const int borderRadius = 15;
        private MySqlConnection? connection;
        private readonly string connectionString = "Server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;";

        public frmDashboard_Principal()
        {
            InitializeComponent();

            // 1. Turma Selecionada
            menuPrincipal2.TurmaSelecionada += (sender, novoCursoId) => {
                frmTurma formTurma = new frmTurma(novoCursoId);
                formTurma.Show();
                this.Hide(); // Esconde o dashboard para mostrar a turma
            };

            // 2. Notificação Clicada
            menuPrincipal2.NotificacaoClicada += (sender, e) => {
                frmNotificacao formNotificacao = new frmNotificacao();
                formNotificacao.Show();
                this.Hide(); // Esconde o dashboard para mostrar a notificação
            };

            // 3. Perfil Clicado
            menuPrincipal2.PerfilClicado += (sender, e) => {
                FrmPerfil formPerfil = new FrmPerfil();
                formPerfil.Show();
                this.Hide(); // Esconde o dashboard para mostrar o perfil
            };

            // 4. Sair Clicado
            menuPrincipal2.SairClicado += (sender, e) => {
                Application.Exit();
            };

            // 5. Relatório Clicado (NÃO FAZ NADA, POIS JÁ ESTÁ NA TELA)
            menuPrincipal2.RelatorioClicado += (sender, e) => {
                // Não é necessário fazer nada aqui. O usuário já está na tela de relatórios.
                // Simplesmente ignore o clique.
            };
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

        private void ConfigureEventHandlers()
        {

            // Eventos de arredondamento dos painéis
            Painel_Diário.Paint += (sender, e) => RoundPanel(Painel_Diário, e);
            Painel_Semanal.Paint += (sender, e) => RoundPanel(Painel_Semanal, e);
            Painel_Mensal.Paint += (sender, e) => RoundPanel(Painel_Mensal, e);

            // Evento para fechar o form
            this.FormClosed += Dashboard_Principal_FormClosed;
        }


        private void Turmas_Direcionamento_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PaintButton(Button? btn, PaintEventArgs e)
        {
            if (btn == null || e == null || btn.IsDisposed) return;

            RoundControl(btn, e);
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle,
                                btn.ForeColor, Color.Transparent,
                                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void RoundPanel(Panel? panel, PaintEventArgs e)
        {
            if (panel == null || e == null || panel.IsDisposed) return;
            RoundControl(panel, e);
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

    }
}