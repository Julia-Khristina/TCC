using DPFP;
using DPFP.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTCC
{
    delegate void Function();

    public partial class main : Form
    {
        private DPFP.Template Template;

        public main()
        {
            InitializeComponent();
        }

        private void onTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;

                if(Template != null)
                {
                    MessageBox.Show ("O Modelo de impressão está pronto para a verificação da digital");
                }
                else
                {
                    MessageBox.Show("O modelo de impressão digital n está pronto, repita o escaneamento");

                }

            }));  
        }



        private void reroll_Click(object sender, EventArgs e)
        {
            Cadastrar EnFrm = new Cadastrar();
            EnFrm.OnTemplate += this.onTemplate;
            EnFrm.Show();
        }

        private void verify_Click(object sender, EventArgs e)
        {
            Verificar vrFrm = new Verificar();
            vrFrm.verificado(Template);
            vrFrm.Show();
            
        }
    }
}
