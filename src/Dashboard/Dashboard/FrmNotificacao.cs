using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmNotificacao : Form
    {
        public frmNotificacao()
        {
            InitializeComponent();
        }

        private void frmNotificacao_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Relatorio_Direcionamento_Click(object sender, EventArgs e)
        {
            frmDashboard_Principal objFrmDashPrinc = new frmDashboard_Principal();
            objFrmDashPrinc.Show();
            this.Close();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            frmDashboard_Principal objFrmDashPrinc = new frmDashboard_Principal();
            objFrmDashPrinc.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmPerfil objfrmPerfil = new FrmPerfil();
            objfrmPerfil.Show();
            this.Close();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            FrmPerfil objfrmPerfil = new FrmPerfil();
            objfrmPerfil.Show();
            this.Close();
        }
    }
}
