using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using System.IO;
using MySql.Data.MySqlClient;
using DPFP.Processing;
using DPFP.Verification;
using System.Drawing.Drawing2D;


namespace prjTCC
{
    public partial class Verificarform : Form, DPFP.Capture.EventHandler
    {

        private Capture Capturador;
        private Template Template;

        private const int borderRadius = 25; // Mesma constante usada no frmLogin
        private bool isMouseOverBtnIniciar = false;
        private bool isMouseOverbtnParar = false;
        private bool isMouseOverbtnMoldura = false;

        public Verificarform()
        {
            InitializeComponent();

            // Configurações do reroll
            btnParar.FlatStyle = FlatStyle.Flat;
            btnParar.FlatAppearance.BorderSize = 0;
            btnParar.BackColor = ColorTranslator.FromHtml("#DDE0E3"); // Cinza claro
            btnParar.ForeColor = ColorTranslator.FromHtml("#212529"); // Texto escuro
            btnParar.Paint += (s, e) => RoundControl(btnParar, e, ref isMouseOverbtnParar);
            btnParar.Resize += (s, e) => btnParar.Invalidate();
            btnParar.MouseEnter += (s, e) => { isMouseOverbtnParar = true; btnParar.Invalidate(); };
            btnParar.MouseLeave += (s, e) => { isMouseOverbtnParar = false; btnParar.Invalidate(); };

            // Configurações do btnMoldura
            btnMoldura.FlatStyle = FlatStyle.Flat;
            btnMoldura.FlatAppearance.BorderSize = 0;
            btnMoldura.BackColor = Color.GhostWhite; // Cinza claro
            btnMoldura.ForeColor = ColorTranslator.FromHtml("#212529"); // Texto escuro
            btnMoldura.Paint += (s, e) => RoundControl(btnMoldura, e, ref isMouseOverbtnMoldura);
            btnMoldura.Resize += (s, e) => btnMoldura.Invalidate();
            btnMoldura.MouseEnter += (s, e) => { isMouseOverbtnMoldura = true; btnMoldura.Invalidate(); };
            btnMoldura.MouseLeave += (s, e) => { isMouseOverbtnMoldura = false; btnMoldura.Invalidate(); };


            // Configurações do verify
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.BackColor = ColorTranslator.FromHtml("#5C6BC0"); // Azul principal
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Paint += (s, e) => RoundControl(btnIniciar, e, ref isMouseOverBtnIniciar);
            btnIniciar.Resize += (s, e) => btnIniciar.Invalidate();
            btnIniciar.MouseEnter += (s, e) => { isMouseOverBtnIniciar = true; btnIniciar.Invalidate(); };
            btnIniciar.MouseLeave += (s, e) => { isMouseOverBtnIniciar = false; btnIniciar.Invalidate(); };

            this.FormClosed += Verificar_FormClosed;
        }

        private void RoundControl(Control control, PaintEventArgs e, ref bool isMouseOver)
        {
            if (control == null || e == null || control.IsDisposed || !control.IsHandleCreated)
                return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = new GraphicsPath())
            {
                Rectangle bounds = new Rectangle(0, 0, control.Width - 1, control.Height - 1);
                path.AddArc(bounds.X, bounds.Y, borderRadius, borderRadius, 180, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Y, borderRadius, borderRadius, 270, 90);
                path.AddArc(bounds.Right - borderRadius, bounds.Bottom - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseAllFigures();

                control.Region = new Region(path);

                // Define a cor considerando MouseOver
                Color currentBackColor = control.BackColor;
                if (isMouseOver)
                {
                    if (control == btnParar)
                        currentBackColor = ColorTranslator.FromHtml("#D6D9DC"); // MouseOver cinza
                    
                    else if (control == btnIniciar)
                        currentBackColor = ColorTranslator.FromHtml("#7986CB"); // MouseOver azul mais claro
                }

                e.Graphics.FillPath(new SolidBrush(currentBackColor), path);
                e.Graphics.DrawPath(new Pen(control.Parent?.BackColor ?? Color.Transparent, 1), path);

                if (control is Button btn)
                {
                    TextRenderer.DrawText(
                        e.Graphics,
                        btn.Text,
                        btn.Font,
                        control.ClientRectangle,
                        btn.ForeColor,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }

        private bool VerificarAtrasoDiario(MySqlConnection conn, string cdAluno, DateTime data)
        {
            string select = "SELECT COUNT(*) FROM RegistroAtraso WHERE cd_Aluno = @cd AND data_registro = @data";
            using (MySqlCommand cmd = new MySqlCommand(select, conn))
            {
                cmd.Parameters.AddWithValue("@cd", cdAluno);
                cmd.Parameters.AddWithValue("@data", data.ToString("yyyy-MM-dd"));
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // Retorna true se já houver um registro
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Capturador != null)
            {
                Capturador.StopCapture();
            }
                Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarLeitor();
            MessageBox.Show("Verificação iniciada com sucesso!");
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (Capturador != null)
            {
                try
                {
                    Capturador.StopCapture();
                    MessageBox.Show("Captura parada com sucesso.");

                    this.Invoke((MethodInvoker)delegate {
                        lblNomeValor.Text = "";
                        lblTurmaValor.Text = "";
                        lblCursoValor.Text = "";
                        lblAtrasoValor.Text = "";
                        lblSituacaoValor.Text = "";
                        lblSituacaoValor.ForeColor = Color.Black;
                        pbImagem_Aluno.Image = null;
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao parar captura: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("O leitor não está inicializado.");
            }
        }


        private void IniciarLeitor()
        {
            try
            {
                Capturador = new Capture();
                if (Capturador != null)
                {
                    Capturador.EventHandler = this;
                    Capturador.StartCapture();
                }
                else
                {
                    MessageBox.Show("Erro ao iniciar o leitor biométrico.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao iniciar captura: " + ex.Message);
            }
        }


        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            // Converter sample para FeatureSet
            FeatureSet features = ExtractFeatures(Sample);
            if (features != null)
            {
                VerificarDigital(features);
            }
        }

        private FeatureSet ExtractFeatures(Sample sample)
        {
            FeatureExtraction extractor = new FeatureExtraction();
            CaptureFeedback feedback = CaptureFeedback.None;
            FeatureSet features = new FeatureSet();
            extractor.CreateFeatureSet(sample, DataPurpose.Verification, ref feedback, ref features);

            return (feedback == CaptureFeedback.Good) ? features : null;
        }

        private void VerificarDigital(FeatureSet features)
        {
            // Limpa as labels antes de cada verificação
            this.Invoke((MethodInvoker)delegate {
                lblNomeValor.Text = "";
                lblTurmaValor.Text = "";
                lblCursoValor.Text = "";
                lblAtrasoValor.Text = "";
                lblSituacaoValor.Text = "";
                lblSituacaoValor.ForeColor = Color.Black;
                pbImagem_Aluno.Image = null;
            });

            try
            {
                string conexao = "server=localhost;user=root;password=;database=Db_Pontualize;";
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    // JOIN para pegar os nomes de série e curso
                    string query = @"SELECT A.cd_Aluno, A.nm_Aluno, S.nm_Serie, C.nm_Curso, A.atrasos, B.dados_Biometria, A.foto_aluno
                                     FROM Aluno A
                                     INNER JOIN Biometria B ON A.cd_Biometria = B.cd_Biometria
                                     LEFT JOIN Serie S ON A.Serie_Aluno = S.cd_Serie
                                     LEFT JOIN Curso C ON A.Curso_Aluno = C.cd_Curso";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Verification verificador = new Verification();
                    bool encontrado = false;

                    string cdAluno = "", nome = "", turmaNome = "", cursoNome = "";
                    int atrasos = 0;
                    bool atrasado = false;
                    DateTime horarioEntrada = DateTime.Now;

                    while (reader.Read())
                    {
                        byte[] blob = (byte[])reader["dados_Biometria"];
                        MemoryStream ms = new MemoryStream(blob);
                        Template template = new Template(ms);

                        Verification.Result result = new Verification.Result();
                        verificador.Verify(features, template, ref result);

                        if (result.Verified)
                        {
                            encontrado = true;

                            cdAluno = reader["cd_Aluno"].ToString();
                            nome = reader["nm_Aluno"].ToString();
                            turmaNome = reader["nm_Serie"].ToString();
                            cursoNome = reader["nm_Curso"].ToString();
                            atrasos = reader["atrasos"] != DBNull.Value ? Convert.ToInt32(reader["atrasos"]) : 0;

                            if (reader["foto_aluno"] != DBNull.Value)
                            {
                                byte[] fotoBytes = (byte[])reader["foto_aluno"];
                                if (fotoBytes.Length > 0)
                                {
                                    // 1. Renomeie a variável para evitar o conflito de nome
                                    using (MemoryStream fotoStream = new MemoryStream(fotoBytes))
                                    {
                                        try
                                        {
                                            // 2. Atribua a imagem ao controle correto: pbImagem_Aluno
                                            pbImagem_Aluno.Image = Image.FromStream(fotoStream);
                                        }
                                        catch (ArgumentException)
                                        {
                                            // Se os dados no banco não forem uma imagem válida
                                            pbImagem_Aluno.Image = null; // ou uma imagem padrão de "sem foto"
                                        }
                                    }
                                }
                                else
                                {
                                    pbImagem_Aluno.Image = null;
                                }
                            }
                            else
                            {
                                pbImagem_Aluno.Image = null; // Garante que a imagem anterior seja limpa se o aluno atual não tiver foto
                            }


                            DateTime horarioLimite = DateTime.Today.AddHours(7).AddMinutes(30);
                            atrasado = horarioEntrada > horarioLimite;

                            break; // Para no primeiro aluno verificado
                        }
                    }

                    reader.Close(); // Fecha o reader após o loop

                    if (encontrado)
                    {
                        bool jaRegistrado = false;
                        if (atrasado)
                        {
                            jaRegistrado = VerificarAtrasoDiario(conn, cdAluno, horarioEntrada);
                        }

                        // Atualiza atrasos e insere registro de atraso se necessário
                        if (atrasado && !jaRegistrado)
                        {
                            string update = "UPDATE Aluno SET atrasos = atrasos + 1 WHERE cd_Aluno = @cd";
                            using (MySqlCommand updateCmd = new MySqlCommand(update, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@cd", cdAluno);
                                updateCmd.ExecuteNonQuery();
                            }


                            string insertAtraso = @"INSERT INTO RegistroAtraso (cd_Aluno, nm_Aluno, nm_Serie, nm_Curso, horario_entrada, data_registro)
                                                    VALUES (@cdAluno, @nome, @turma, @curso, @horario, @data)";
                            using (MySqlCommand insertCmd = new MySqlCommand(insertAtraso, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@cdAluno", cdAluno);
                                insertCmd.Parameters.AddWithValue("@nome", nome);
                                insertCmd.Parameters.AddWithValue("@turma", turmaNome);
                                insertCmd.Parameters.AddWithValue("@curso", cursoNome);
                                insertCmd.Parameters.AddWithValue("@horario", horarioEntrada.ToString("HH:mm:ss"));
                                insertCmd.Parameters.AddWithValue("@data", horarioEntrada.ToString("yyyy-MM-dd"));
                                insertCmd.ExecuteNonQuery();
                            }
                        }

                        // Consulta o valor atualizado de atrasos SEMPRE
                        string selectAtrasos = "SELECT atrasos FROM Aluno WHERE cd_Aluno = @cd";
                        using (MySqlCommand selectCmd = new MySqlCommand(selectAtrasos, conn))
                        {
                            selectCmd.Parameters.AddWithValue("@cd", cdAluno);
                            object resultAtrasos = selectCmd.ExecuteScalar();
                            if (resultAtrasos != null && resultAtrasos != DBNull.Value)
                                atrasos = Convert.ToInt32(resultAtrasos);
                        }


                        // Atualiza as labels do formulário
                        this.Invoke((MethodInvoker)delegate {
                            lblNomeValor.Text = nome;
                            lblTurmaValor.Text = turmaNome;
                            lblCursoValor.Text = cursoNome;
                            lblAtrasoValor.Text = atrasos.ToString();
                            if (atrasado)
                            {
                                lblSituacaoValor.Text = jaRegistrado ? "ATRASO JÁ REGISTRADO" : "ATRASADO";
                                lblSituacaoValor.ForeColor = jaRegistrado ? Color.Blue : Color.Red;
                            }
                            else
                            {
                                lblSituacaoValor.Text = "NO HORÁRIO";
                                lblSituacaoValor.ForeColor = Color.Green;
                            }
                        });
                    }
                    else
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            lblNomeValor.Text = "Aluno não encontrado!";
                            lblTurmaValor.Text = "";
                            lblCursoValor.Text = "";
                            lblAtrasoValor.Text = "";
                            lblSituacaoValor.Text = "";
                            pbImagem_Aluno.Image = null;
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate {
                    MessageBox.Show("Erro ao verificar digital: " + ex.Message);
                    lblNomeValor.Text = "";
                    lblTurmaValor.Text = "";
                    lblCursoValor.Text = "";
                    lblAtrasoValor.Text = "";
                    lblSituacaoValor.Text = "";
                });
            }
        }
        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }
        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }
        public void OnFingerPresent(object Capture, string ReaderSerialNumber) { }
        public void OnReaderConnect(object Capture, string ReaderSerialNumber) { }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) { }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback) { }

        private void Verificar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Capturador != null)
            {
                Capturador.StopCapture();
            }
        }
    }
}

