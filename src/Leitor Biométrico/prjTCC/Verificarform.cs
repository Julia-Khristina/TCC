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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            try
            {
                string conexao = "server=localhost;user=root;password=;database=db_pontualize;";
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string query = "SELECT A.cd_Aluno, A.nm_Aluno, B.dados_Biometria FROM Aluno A INNER JOIN Biometria B ON A.cd_Biometria = B.cd_Biometria";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    Verification verificador = new Verification();
                    bool encontrado = false;

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
                            string nome = reader["nm_Aluno"].ToString();
                            MessageBox.Show($"Aluno identificado: {nome}");
                            // Aqui você pode chamar o registro de entrada ou atraso
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        MessageBox.Show("Aluno não encontrado!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
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
    }
}

