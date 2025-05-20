using DPFP;
using DPFP.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        public main()
        {
            InitializeComponent();

        }


        //COLOCAR na Dashboard
        private void reroll_Click(object sender, EventArgs e)
        {
            Cadastrar EnFrm = new Cadastrar();
            EnFrm.OnTemplate += SeuMetodoHandler;
            EnFrm.Show();


        }

        private void SeuMetodoHandler(DPFP.Template template)
        {
            if (template != null)
            {
                MessageBox.Show("Digital cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar a digital.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void verify_Click(object sender, EventArgs e)
        {
            Verificarform verificarForm = new Verificarform();
            verificarForm.Show(); 

        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
