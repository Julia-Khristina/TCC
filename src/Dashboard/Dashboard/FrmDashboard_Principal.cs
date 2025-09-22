using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text;

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
            InitializeApp();

            this.WindowState = FormWindowState.Maximized; // Garante que a janela abra maximizada

            // Adiciona um manipulador para o evento Resize para centralizar os painéis
            this.Resize += frmDashboard_Principal_Resize;
            // Chama o método de redimensionamento uma vez para posicionamento inicial
            frmDashboard_Principal_Resize(this, EventArgs.Empty);

        }

        private void InitializeApp()
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                connection = new MySqlConnection(connectionString);

                Turmas_Direcionamento.DropDownStyle = ComboBoxStyle.DropDownList;
                lblTurma.Visible = true;

                ConfigureEventHandlers();
                CarregarTurmas();
                Turmas_Direcionamento.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar o aplicativo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureEventHandlers()
        {
            // Eventos do botão sair
            Btn_Sair.Paint += (sender, e) => PaintButton(Btn_Sair, e);
            Btn_Sair.Resize += (sender, e) => Btn_Sair.Invalidate();
            Btn_Sair.Click += Btn_Sair_Click;

            // Eventos de arredondamento dos painéis
            Painel_Diário.Paint += (sender, e) => RoundPanel(Painel_Diário, e);
            Painel_Semanal.Paint += (sender, e) => RoundPanel(Painel_Semanal, e);
            Painel_Mensal.Paint += (sender, e) => RoundPanel(Painel_Mensal, e);

            // Eventos da ComboBox
            Turmas_Direcionamento.SelectedIndexChanged += Turmas_Direcionamento_SelectedIndexChanged;
            Turmas_Direcionamento.DrawItem += ComboBox_DrawItem;

            // Evento para fechar o form
            this.FormClosed += Dashboard_Principal_FormClosed;
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

        private void Turmas_Direcionamento_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (Turmas_Direcionamento.SelectedIndex != -1 && Turmas_Direcionamento.SelectedItem != null)
            {
                lblTurma.Visible = false;
                ObterCodigoCursoERedirecionar(Turmas_Direcionamento.SelectedItem.ToString()!);
            }
        }

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
                            AbrirFormularioTurma(cd_Curso);
                        }
                        else
                        {
                            MessageBox.Show("Curso não encontrado no banco de dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show($"Erro ao obter ID da turma: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbrirFormularioTurma(int cd_Curso)
        {
            try
            {
                //fecha se já estiver aberto o formTurma
                foreach (Form form in Application.OpenForms)
                {
                    if (form is frmTurma)
                    {
                        form.Close();
                        break;
                    }
                }

                frmTurma formTurma = new frmTurma(cd_Curso);
                formTurma.FormClosed += (s, args) =>
                {
                    this.Show();
                    Turmas_Direcionamento.SelectedIndex = -1;
                    lblTurma.Visible = true;
                };
                formTurma.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o formulário de turma: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Sair_Click(object? sender, EventArgs e)
        {
            Application.Exit();
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

        private void frmDashboard_Principal_Resize(object sender, EventArgs e)
        {
            // Centraliza o flowLayoutPanelReports horizontalmente
            if (flowLayoutPanelReports.Parent != null)
            {
                int x = (flowLayoutPanelReports.Parent.Width - flowLayoutPanelReports.Width) / 2;
                flowLayoutPanelReports.Location = new Point(x, flowLayoutPanelReports.Location.Y);
            }

            // Centraliza o panelWelcome horizontal e verticalmente dentro do pnConteudo
            if (panelWelcome.Parent != null)
            {
                int x = (panelWelcome.Parent.Width - panelWelcome.Width) / 2;
                int y = (panelWelcome.Parent.Height - panelWelcome.Height) / 2;
                panelWelcome.Location = new Point(x, y);
            }
        }

        private void Turmas_Direcionamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Notificacao_Direcionamento_Click(object sender, EventArgs e)
        {
            frmNotificacao objfrmNotificacao = new frmNotificacao();
            objfrmNotificacao.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_Relatorio_Direcionamento_Click(object sender, EventArgs e)
        {

        }
    }
}

