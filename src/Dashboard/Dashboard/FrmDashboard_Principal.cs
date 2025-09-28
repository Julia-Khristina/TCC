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
            InitializeApp();
        }

        private void InitializeApp()
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                connection = new MySqlConnection(connectionString);

                // 1. Configura o ComboBox real (que ficará invisível)
                Turmas_Direcionamento.Visible = false; // Garante que ele comece invisível
                Turmas_Direcionamento.DropDownStyle = ComboBoxStyle.DropDownList;

                // 2. Configura o Label falso
                lblFalsoComboBox.AutoSize = false; // Impede que ele se redimensione
                lblFalsoComboBox.Text = "";        // Remove o texto padrão para não ser desenhado

                // 3. Carrega os dados e configura os eventos
                ConfigureEventHandlers();
                CarregarTurmas();
                Turmas_Direcionamento.SelectedIndex = -1; // Garante que nada comece selecionado
                lblFalsoComboBox.Invalidate(); // Força o desenho inicial correto do placeholder
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

            // --- EVENTOS DO NOSSO COMBOBOX FALSO ---
            // Apenas uma linha para cada evento!
            lblFalsoComboBox.Paint += lblFalsoComboBox_Paint;
            lblFalsoComboBox.Click += lblFalsoComboBox_Click;

            // Eventos do ComboBox real (invisível)
            Turmas_Direcionamento.SelectedIndexChanged += Turmas_Direcionamento_SelectedIndexChanged;
            Turmas_Direcionamento.DrawItem += ComboBox_DrawItem_Custom;

            // Evento para fechar o form
            this.FormClosed += Dashboard_Principal_FormClosed;
        }


        private void Turmas_Direcionamento_KeyPress(object? sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void Turmas_Direcionamento_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Se um item foi selecionado...
            if (Turmas_Direcionamento.SelectedIndex != -1 && Turmas_Direcionamento.SelectedItem != null)
            {
                // 1. ATUALIZA o texto do Label falso
                lblFalsoComboBox.Text = Turmas_Direcionamento.SelectedItem.ToString();

                // 2. CHAMA sua lógica para abrir o outro formulário
                ObterCodigoCursoERedirecionar(Turmas_Direcionamento.SelectedItem.ToString()!);
            }
            else
            {
                // Se a seleção for limpa, volta ao texto de placeholder
                lblFalsoComboBox.Text = "Turmas";
            }

            // Manda o Label se redesenhar para mostrar o novo texto
            lblFalsoComboBox.Invalidate();
        }

        // Em frmDashboard_Principal.cs

        private void lblFalsoComboBox_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Label label) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // ... (código de desenhar fundo e borda continua igual) ...
            Color backgroundColor = Color.FromArgb(195, 205, 235);
            Color borderColor = Color.FromArgb(150, 165, 210);
            using (var path = new GraphicsPath())
            {
                int borderRadius = 8;
                Rectangle bounds = new Rectangle(0, 0, label.Width - 1, label.Height - 1);
                path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();

                e.Graphics.FillPath(new SolidBrush(backgroundColor), path);
                e.Graphics.DrawPath(new Pen(borderColor, 1), path);
                label.Region = new Region(path);
            }

            // --- LÓGICA DE DESENHO AJUSTADA PARA O NOVO TAMANHO ---

            // 1. DESENHA O ÍCONE DA SETA (MAIOR E BEM POSICIONADO)
            try
            {
                // Aumentamos o ícone e ajustamos a posição para centralizar
                int iconSize = 16; // Tamanho maior para o ícone
                int padding = 15;  // Espaçamento da borda esquerda

                Rectangle iconRect = new Rectangle(
                    padding,
                    (label.Height - iconSize) / 2, // Centraliza verticalmente
                    iconSize,
                    iconSize
                );

                byte[] iconBytes = Dashboard.Resources.Resource1.seta_turma;
                using (Image arrowIcon = ByteArrayToImage(iconBytes))
                {
                    e.Graphics.DrawImage(arrowIcon, iconRect);
                }
            }
            catch { /* Ignora erro */ }

            // 2. DESENHA O TEXTO (COM MAIS ESPAÇO)
            Color textColor = (Turmas_Direcionamento.SelectedIndex == -1) ? Color.FromArgb(100, 100, 150) : Color.MidnightBlue;
            string textToDraw = (Turmas_Direcionamento.SelectedIndex == -1) ? "Turmas" : Turmas_Direcionamento.Text;

            // A área do texto agora começa depois do ícone + um espaçamento
            int textPadding = 40;
            Rectangle textRect = new Rectangle(textPadding, 0, label.Width - (textPadding + 5), label.Height);

            TextRenderer.DrawText(e.Graphics, textToDraw, label.Font,
                textRect,
                textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }


        private void lblFalsoComboBox_Click(object? sender, EventArgs e)
        {
            // Manda o ComboBox invisível abrir sua lista
            Turmas_Direcionamento.DroppedDown = true;
        }

        private void ComboBox_DrawItem_Custom(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || sender is not ComboBox comboBox) return;

            // Cor de fundo dos itens
            Color backgroundColor = Color.White; // Fundo branco para a lista
            Color itemTextColor = Color.MidnightBlue; // Texto azul escuro

            // Cor de destaque quando o mouse passa por cima ou o item está selecionado
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected ||
                (e.State & DrawItemState.HotLight) == DrawItemState.HotLight)
            {
                backgroundColor = Color.FromArgb(195, 205, 235); // Lilás, igual à caixa principal
            }

            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

            string text = comboBox.Items[e.Index].ToString() ?? "";

            // Adiciona um pequeno preenchimento (padding) à esquerda
            Rectangle textBounds = new Rectangle(e.Bounds.X + 8, e.Bounds.Y, e.Bounds.Width - 8, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, text, comboBox.Font, textBounds, itemTextColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter);

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

        private void frmDashboard_Principal_Load(object sender, EventArgs e)
        {

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

        private void lblTurma_Click(object sender, EventArgs e)
        {
            Turmas_Direcionamento.Focus();
            Turmas_Direcionamento.DroppedDown = true; // Abre a lista de opções
        }
    }
}