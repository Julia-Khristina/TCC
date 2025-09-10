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
            Cadastrar objCadastrar = new Cadastrar();
            objCadastrar.Show();
            
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

        private void Notificacao_Direcionamento_Click(object sender, EventArgs e)
        {
            frmNotificacao objfrmNotificacao = new frmNotificacao();
            objfrmNotificacao.Show();
            this.Close();
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            //NOME DAS TURMAS AINDA NÃO APARECE MAS ESTÁ DIRECIONANDO CORRETAMENTE
            TurmaRedirecionamento.CarregarTurmas(Turmas_Direcionamento);
            TurmaRedirecionamento.ConfigurarRedirecionamento(Turmas_Direcionamento, lblTurma, this);
        }
    }
}
