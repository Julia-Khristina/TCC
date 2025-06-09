using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prjTCC
{
    public partial class Cadastrar : captureForm
    {
        public delegate void OnTemplateEventHandler(DPFP.Template template);
        public event OnTemplateEventHandler OnTemplate;
        private DPFP.Processing.Enrollment Enroller;

       
        private void LimparCampos()
        {
            // Limpa campos de texto
            txtNome.Text = "";
            txtRM.Text = "";
            txtEmail.Text = "";
            

            // Limpa combos
            cmbAno.SelectedIndex = -1;
            cmbTurma.SelectedIndex = -1;

            // Limpa variáveis públicas herdadas
            Nome = "";
            RM = "";
            Email = "";
            Ano = "";
            Telefone = "";
            Turma = "";
        }

        public Cadastrar()
        {
            InitializeComponent();
            this.Load += new EventHandler(reroll_Load);
        }

        protected override void init()
        {
            base.init();
            base.Text = "Aluno Cadastrado";
            Enroller = new DPFP.Processing.Enrollment();
            UpdateStatus();
        }

        private void cmbInsertSerie()
        {
            string conexao = "server=localhost;user=root;password=;database=db_pontualize;";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT cd_Serie, nm_Serie FROM Serie";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbAno.DisplayMember = "nm_Serie"; // o que aparece na combo
                    cmbAno.ValueMember = "cd_Serie";   // o valor interno (ID)
                    cmbAno.SelectedIndex = -1; // nenhuma opção selecionada ao iniciar

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    cmbAno.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar séries: " + ex.Message);
                }
            }
        }

        public void cmbInsertCurso()
        {
            try
            {
                string query = "SELECT nm_Curso FROM Curso";

                MySqlConnection conexao = new MySqlConnection("server=localhost;database=db_pontualize;uid=root;pwd=;");
                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();

                adapter.Fill(tabela);

                cmbTurma.DisplayMember = "nm_Curso";  
                cmbTurma.ValueMember = "nm_Curso";     
                cmbTurma.DataSource = tabela;
                cmbTurma.SelectedIndex = -1; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar séries: " + ex.Message);
            }
        }

        protected override void Process(Sample Sample)
        {


            base.Process(Sample);
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);
            if(features != null)
                try
                {
                    MakeReport("A Impressão digital já foi cadastrada");
                    Enroller.AddFeatures(features); 
                }
                finally
                {
                    UpdateStatus(); 

                    switch( Enroller.TemplateStatus) 
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:
                            {
                                int count = 0;

                                OnTemplate?.Invoke(Enroller.Template);



                                MemoryStream fingerprintData = new MemoryStream();
                                Enroller.Template.Serialize(fingerprintData);
                                fingerprintData.Position = 0;
                                BinaryReader br = new BinaryReader(fingerprintData);

                                byte[] bytes = br.ReadBytes((Int32)fingerprintData.Length);

                                try
                                {
                                    string Myconnection = "datasource=localhost;username=root;database=db_pontualize;";
                                    string Query = "SELECT * FROM Aluno WHERE UPPER(nm_Aluno) = '"+Nome.ToUpper()+"'";
                                    MySqlConnection Myconn = new MySqlConnection(Myconnection);
                                    MySqlCommand Mycomand = new MySqlCommand(Query, Myconn);

                                    Myconn.Open();

                                        MySqlDataReader myReader = Mycomand.ExecuteReader();
                                     while (myReader.Read())
                                    {
                                        count = count + 1;
                                    }

                                    MakeReport("Total de usuarios encontrados: " + count);

                                    if(count > 0)
                                    {
                                        MessageBox.Show("Aluno já registrado");
                                        Stop();
                                        Start();
                                        Enroller = new DPFP.Processing.Enrollment(); // Reinicializa o Enroller
                                        UpdateStatus();
                                    }
                                    else
                                    {
                                        try
                                        {
                                            
                                            string Myconnection1 = "datasource=localhost;username=root;database=db_pontualize;";
                                            MySqlConnection Myconn1 = new MySqlConnection(Myconnection1);
                                            Myconn1.Open();
                                            
                                            // 1. Inserir na tabela Biometria
                                            string insertBiometria = "INSERT INTO Biometria (dados_Biometria) VALUES (@digital)";
                                            MySqlCommand cmdBiometria = new MySqlCommand(insertBiometria, Myconn1);
                                            cmdBiometria.Parameters.AddWithValue("@digital", bytes);
                                            cmdBiometria.ExecuteNonQuery();

                                            // 2. Obter o ID gerado
                                            long cdBiometria = cmdBiometria.LastInsertedId;

                                            // Inserir Dados na tabela aluno
                                            string insertAluno = @"INSERT INTO Aluno (cd_Aluno, nm_Aluno, Curso_Aluno, Serie_Aluno, gmail_aluno, cd_Biometria, tel_Aluno)
                                            VALUES (@rm, @nome, @turma, @ano, @email, @cd_biometria, @tel_aluno)";
                                            MySqlCommand cmdAluno = new MySqlCommand(insertAluno, Myconn1);

                                            cmdAluno.Parameters.AddWithValue("@rm", RM);
                                            cmdAluno.Parameters.AddWithValue("@nome", Nome);
                                            cmdAluno.Parameters.AddWithValue("@turma", Turma);
                                            cmdAluno.Parameters.AddWithValue("@ano", Ano); // já convertido para int se necessário
                                            cmdAluno.Parameters.AddWithValue("@email", Email);
                                            cmdAluno.Parameters.AddWithValue("@cd_biometria", cdBiometria);
                                            cmdAluno.Parameters.AddWithValue("@tel_aluno", Telefone);
                                            cmdAluno.ExecuteNonQuery();
                                            Myconn1.Close();
                                           
                                            Stop();
                                        }
                                        catch (Exception ex) 
                                        {
                                            MessageBox.Show("Error: "+ ex.Message);
                                        }

                                        Stop();
                                        Enroller = new DPFP.Processing.Enrollment(); // Reinicializa o Enroller
                                        UpdateStatus();
                                        Start();
                                        LimparCampos();

                                    }
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message);
                                }

                                break;

                            }



                        case DPFP.Processing.Enrollment.Status.Failed:
                            {
                                Enroller.Clear();
                                Stop();
                                UpdateStatus();
                                OnTemplate?.Invoke(null);
                                Start();
                                break;
                            }
                    }
                }
        }

        private void UpdateStatus()
        {
            SetStatus(String.Format("insira : {0}", Enroller.FeaturesNeeded + "Vezes"));
        }

        private void reroll_Load(object sender, EventArgs e)
        {
            cmbInsertSerie();
            cmbInsertCurso();
        }


    }

}
