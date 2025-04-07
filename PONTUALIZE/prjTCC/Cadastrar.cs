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

        protected override void init()
        {
            base.init();
            base.Text = "Registro Cadastrado";
            Enroller = new DPFP.Processing.Enrollment();
            UpdateStatus();
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

                                OnTemplate(Enroller.Template);

                                MemoryStream fingerprintData = new MemoryStream();
                                Enroller.Template.Serialize(fingerprintData);
                                fingerprintData.Position = 0;
                                BinaryReader br = new BinaryReader(fingerprintData);

                                byte[] bytes = br.ReadBytes((Int32)fingerprintData.Length);

                                try
                                {
                                    string Myconnection = "datasource=localhost;username=root;database=pontualize;";
                                    string Query = "SELECT * FROM usuarios WHERE UPPER(Nome) = '"+Nome.ToUpper()+"'";
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
                                        MessageBox.Show("Pessoa já registrada");
                                        Stop();
                                        Start();

                                    }
                                    else
                                    {
                                        try
                                        {
                                            string Myconnection1 = "datasource=localhost;username=root;database=pontualize;";
                                            string Query1 = "INSERT INTO usuarios (RM, Nome, Turma, Ano, Email, Digital) " + "VALUES (@rm, @nome, @turma, @ano, @email, @digital)";
                                            MySqlConnection Myconn1 = new MySqlConnection(Myconnection1);
                                            Myconn1.Open();

                                            MySqlCommand Mycomand1 = new MySqlCommand(Query1, Myconn1);
                                            Mycomand1.Parameters.AddWithValue("@rm", RM);
                                            Mycomand1.Parameters.AddWithValue("@nome", Nome);
                                            Mycomand1.Parameters.AddWithValue("@turma", Turma);
                                            Mycomand1.Parameters.AddWithValue("@ano", Ano);
                                            Mycomand1.Parameters.AddWithValue("@email", Email);
                                            Mycomand1.Parameters.AddWithValue("@digital", bytes).DbType = DbType.Binary;
                                            Mycomand1.ExecuteNonQuery();
                                            Myconn1.Close();
                                           
                                            Stop();
                                        }
                                        catch (Exception ex) 
                                        {
                                            MessageBox.Show("Error: "+ ex.Message);
                                        }
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
                                OnTemplate(null);
                                Start();
                                break;
                            }
                    }
                }
        }

        private void UpdateStatus()
        {
            SetStatus(String.Format("Impressão digital precisa: {0}", Enroller.FeaturesNeeded));
        }

        private void reroll_Load(object sender, EventArgs e)
        {

        }
    }

}
