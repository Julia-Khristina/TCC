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

        public frmTurma(int cd_Curso)
        {
            InitializeComponent();
            cursoId = cd_Curso;
            InitializeTurmaForm();
        }

        private void InitializeTurmaForm()
        {
            try
            {
                Turmas_Direcionamento.DropDownStyle = ComboBoxStyle.DropDownList;
                ConfigureEventHandlers();
                LoadInitialData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar o formulário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureEventHandlers()
        {
            // Eventos do botão voltar
            Btn_Voltar.Paint += (sender, e) => PaintButton(Btn_Voltar, e);
            Btn_Voltar.Resize += (sender, e) => Btn_Voltar.Invalidate();
            Btn_Voltar.Click += (sender, e) => VoltarParaDashboard();

            // Eventos dos outros botões 
            btnSolicitarAdvertencia.Paint += (sender, e) => PaintButton(btnSolicitarAdvertencia, e);
            btnSolicitarAdvertencia.Resize += (sender, e) => btnSolicitarAdvertencia.Invalidate();
            btnExportar.Paint += (sender, e) => PaintButton(btnExportar, e);
            btnExportar.Resize += (sender, e) => btnExportar.Invalidate();

            // Eventos de arrendondamento dos painéis
            pnGraficoTurma.Paint += (sender, e) => RoundPanel(pnGraficoTurma, e);
            pnAtrasos_Totais.Paint += (sender, e) => RoundPanel(pnAtrasos_Totais, e);
            pnAtrasos_dia.Paint += (sender, e) => RoundPanel(pnAtrasos_dia, e);
            pnAlunoAtrasos.Paint += (sender, e) => PaintSimplePanel(pnAlunoAtrasos, e);

            // Evento de fechamento do formulário
            this.FormClosed += (sender, e) => CleanupResources();

            // Eventos do ComboBox
            Turmas_Direcionamento.DrawItem += (sender, e) => ComboBox_DrawItem(sender, e);
            Turmas_Direcionamento.SelectedIndexChanged += Turmas_Direcionamento_SelectedIndexChanged;

            // Evento do botão de relatório
            btn_Relatorio_Direcionamento.Click += (sender, e) => VoltarParaDashboard();
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

        private void PaintSimplePanel(Panel? panel, PaintEventArgs e)
        {
            if (panel == null || e == null || panel.IsDisposed) return;

            panel.Region = null;
            e.Graphics.FillRectangle(new SolidBrush(panel.BackColor), panel.ClientRectangle);
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

        private void LoadInitialData()
        {
            CarregarNomeDaTurma();
            CarregarAtrasosDaTurma();
            CarregarTurmasNoComboBox();
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

        private void ConfigureDataGridView()
        {
            tbAtrasoTurma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbAtrasoTurma.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tbAtrasoTurma.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void CarregarTurmasNoComboBox()
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT nm_Curso FROM Curso WHERE cd_Curso != @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", cursoId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Turmas_Direcionamento.BeginUpdate();
                            try
                            {
                                Turmas_Direcionamento.Items.Clear();
                                while (reader.Read())
                                {
                                    string? nomeCurso = reader["nm_Curso"]?.ToString();
                                    if (!string.IsNullOrEmpty(nomeCurso))
                                    {
                                        Turmas_Direcionamento.Items.Add(nomeCurso);
                                    }
                                }

                                if (!string.IsNullOrEmpty(nomeTurmaAtual))
                                {
                                    Turmas_Direcionamento.Items.Insert(0, nomeTurmaAtual);
                                    Turmas_Direcionamento.SelectedIndex = 0;
                                }
                            }
                            finally
                            {
                                Turmas_Direcionamento.EndUpdate();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar turmas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Turmas_Direcionamento_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (Turmas_Direcionamento.SelectedIndex != -1 &&
                Turmas_Direcionamento.SelectedItem != null)
            {
                string nomeTurmaSelecionada = Turmas_Direcionamento.SelectedItem.ToString()!;
                if (nomeTurmaSelecionada != nomeTurmaAtual)
                {
                    ObterCodigoCursoERedirecionar(nomeTurmaSelecionada);
                }
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
            Form? parentForm = this.ParentForm ?? this.Owner ?? Application.OpenForms["frmDashboard_Principal"];
            this.Close();

            frmTurma newForm = new frmTurma(novoCursoId);
            if (parentForm != null)
            {
                newForm.Show(parentForm);
            }
            else
            {
                newForm.Show();
            }
        }

        private void VoltarParaDashboard()
        {
            Form? parentForm = this.ParentForm ?? this.Owner ?? Application.OpenForms["frmDashboard_Principal"];
            this.Close();

            if (parentForm != null)
            {
                parentForm.Show();
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form is frmDashboard_Principal)
                    {
                        form.Show();
                        return;
                    }
                }
                new frmDashboard_Principal().Show();
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
    }
}