using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;

namespace prjTCC
{
    public partial class Verificar : captureForm
    {
        private DPFP.Template Template;
        private DPFP.Verification.Verification Verificator;



        public void verificado(DPFP.Template template)
        {
            Template = template;
            ShowDialog();

        }

        protected override void Process(Sample Sample)
        {
            try
            {
                string Myconnection = "datasource=localhost;username=root;database=pontualize;";
                string Query = "SELECT * FROM usuarios";
                MySqlConnection Myconn = new MySqlConnection(Myconnection);
                MySqlCommand Mycomand = new MySqlCommand(Query, Myconn);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = Mycomand;
                DataTable dTable = new DataTable();

                MyAdapter.Fill(dTable);

                MySqlDataReader myReader;
                Myconn.Open();
                myReader = Mycomand.ExecuteReader();
                
                foreach(DataRow row in dTable.Rows)
                {
                    byte[] _img_ = (byte[])row["Digital"];
                    MemoryStream ms = new MemoryStream(_img_);

                    DPFP.Template Template = new DPFP.Template();
                    Template.DeSerialize(ms);

                    base.Process(Sample);

                    DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

                    if(features != null)
                    {
                        DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                        Verificator.Verify(features, Template, ref result);
                        UpdateStatus(result.FARAchieved);
                        if(result.Verified) 
                        {
                            MakeReport("Digital Verificada" + row["Nome"].ToString());

                            SetFname(row["Nome"].ToString());
                            SetRM(row["RM"].ToString());
                            SetTurma(row["Turma"].ToString());
                            SetEmail(row["Email"].ToString());
                            SetAno(row["Ano"].ToString());
                            Myconn.Close();
                            break;
                        }
                        else
                        {
                            MakeReport("A digital não foi verificada");
                            Myconn.Close();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void init()
        {
            base.init();
            base.Text = "Verificando Digital";
            Verificator = new DPFP.Verification.Verification();
            UpdateStatus(0);
        }

        private void UpdateStatus(int FAR)
        {
            SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR));
        }

        private void Verificado_Load(object sender, EventArgs e)
        {

        }
    } 
}
