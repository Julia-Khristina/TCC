using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class MenuPrincipal : UserControl
    {
        public event EventHandler<int> TurmaSelecionada; // <int> para passar o ID do curso
        public event EventHandler NotificacaoClicada;
        public event EventHandler PerfilClicado;
        public event EventHandler SairClicado;
        public event EventHandler RelatorioClicado;

        private const int borderRadius = 15;
        private MySqlConnection? connection;
        private readonly string connectionString = "Server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;";

        public MenuPrincipal()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeApp();
            }
        }

        private void InitializeApp()
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                connection = new MySqlConnection(connectionString);

                // Configura o ComboBox real
                Turmas_Direcionamento.Visible = false;
                Turmas_Direcionamento.DropDownStyle = ComboBoxStyle.DropDownList;
                // Se você quiser mover o ComboBox para baixo:
                Turmas_Direcionamento.Location = new Point(
                    Turmas_Direcionamento.Location.X,
                    Turmas_Direcionamento.Location.Y + 15
                );


                // Carrega os dados e configura os eventos
                ConfigureEventHandlers();
                CarregarTurmas();
                Turmas_Direcionamento.SelectedIndex = -1; // Garante que nada comece selecionado
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

            btnTurma.Click += btnTurma_Click; // Evento de clique para abrir o ComboBox

            // Eventos do ComboBox real (invisível)
            Turmas_Direcionamento.SelectedIndexChanged += Turmas_Direcionamento_SelectedIndexChanged;
            Turmas_Direcionamento.DrawItem += ComboBox_DrawItem_Custom;
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
                string nomeTurma = Turmas_Direcionamento.SelectedItem.ToString()!;
                btnTurma.Text = nomeTurma;

                // Altera o ícone do botão para o índice 4
                btnTurma.ImageIndex = 4;

                // Chama a lógica para abrir o formulário da turma
                ObterCodigoCursoERedirecionar(nomeTurma);
            }
            else
            {
                // Volta o texto para o padrão
                btnTurma.Text = "  Turmas";

                // Volta o ícone para o índice da seta para baixo 
                btnTurma.ImageIndex = 3;
            }
            Turmas_Direcionamento.Visible = false;
        }

        private void Turmas_Direcionamento_Leave(object sender, EventArgs e)
        {
            Turmas_Direcionamento.Visible = false;
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

        private void Notificacao_Direcionamento_Click(object sender, EventArgs e)
        {
            NotificacaoClicada?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PerfilClicado?.Invoke(this, EventArgs.Empty);
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            PerfilClicado?.Invoke(this, EventArgs.Empty);
        }

        private void lblTurma_Click(object sender, EventArgs e)
        {
            Turmas_Direcionamento.Focus();
            Turmas_Direcionamento.DroppedDown = true; // Abre a lista de opções
        }

        private void Btn_Sair_Click(object? sender, EventArgs e)
        {
            SairClicado?.Invoke(this, EventArgs.Empty);
        }

        private void BTN_Relatorio_Direcionamento_Click(object sender, EventArgs e)
        {
            RelatorioClicado?.Invoke(this, EventArgs.Empty);
        }


    }
}