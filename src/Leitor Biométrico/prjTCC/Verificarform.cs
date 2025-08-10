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


namespace prjTCC
{
    public partial class Verificarform : Form, DPFP.Capture.EventHandler
    {

        private Capture Capturador;
        private Template Template;

        public Verificarform()
        {
            InitializeComponent();
            this.FormClosed += Verificar_FormClosed;
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
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (Capturador != null)
            {
                try
                {
                    Capturador.StopCapture();
                    MessageBox.Show("Captura parada com sucesso.");
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
            });

            try
            {
                string conexao = "server=localhost;user=root;password=;database=Db_Pontualize;";
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    // JOIN para pegar os nomes de série e curso
                    string query = @"SELECT A.cd_Aluno, A.nm_Aluno, S.nm_Serie, C.nm_Curso, A.atrasos, B.dados_Biometria
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

                            DateTime horarioLimite = DateTime.Today.AddHours(7).AddMinutes(30);
                            atrasado = horarioEntrada > horarioLimite;

                            break; // Para no primeiro aluno verificado
                        }
                    }

                    reader.Close(); // Fecha o reader após o loop

                    if (encontrado)
                    {
                        // Atualiza atrasos e insere registro de atraso se necessário
                        if (atrasado)
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
                            lblSituacaoValor.Text = atrasado ? "ATRASADO" : "NO HORÁRIO";
                            lblSituacaoValor.ForeColor = atrasado ? Color.Red : Color.Green;
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

        private void pbDedo_Click(object sender, EventArgs e)
        {

        }

        private void Verificarform_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

