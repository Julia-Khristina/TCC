using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using prjTCC;


namespace Dashboard
{
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            Cadastrar form2 = new Cadastrar();
            form2.ShowDialog();
        }
    }
}
