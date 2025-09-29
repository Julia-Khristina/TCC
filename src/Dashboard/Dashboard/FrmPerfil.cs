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
        private readonly int cursoId;
        private string nomeTurmaAtual = string.Empty;
        public FrmPerfil()
        {
            InitializeComponent();

            // 1. Turma Selecionada
            menuPrincipal1.TurmaSelecionada += (sender, novoCursoId) =>
            {
                AbrirNovoFormularioTurma(novoCursoId);
            };

            // 2. Notificação Clicada (MANTENHA APENAS ESTA)
            menuPrincipal1.NotificacaoClicada += (sender, e) =>
            {
                frmNotificacao formNotificacao = new frmNotificacao();
                formNotificacao.Show();
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };

            // 3. Perfil Clicado
            menuPrincipal1.PerfilClicado += (sender, e) =>
            {
                FrmPerfil formPerfil = new FrmPerfil();
                formPerfil.Show();
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };

            // 4. Sair Clicado
            menuPrincipal1.SairClicado += (sender, e) =>
            {
                Application.Exit();
            };

            // 5. Relatório Clicado
            menuPrincipal1.RelatorioClicado += (sender, e) =>
            {
                var dashboard = Application.OpenForms.OfType<frmDashboard_Principal>().FirstOrDefault();
                if (dashboard != null)
                {
                    dashboard.Show();
                }
                else
                {
                    new frmDashboard_Principal().Show();
                }
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };

        }

        private void AbrirNovoFormularioTurma(int novoCursoId)
        {
            Form? ownerForm = this.Owner ?? Application.OpenForms.OfType<frmDashboard_Principal>().FirstOrDefault();
            bool ownerWasOriginallyVisible = ownerForm?.Visible ?? false; // Guarda estado inicial do dashboard

            try
            {
                // 1. Cria a nova instância do formulário da turma
                frmTurma newForm = new frmTurma(novoCursoId);

                // 2. Define o Owner (Dashboard) se ele existir
                if (ownerForm != null && !ownerForm.IsDisposed)
                {
                    newForm.Owner = ownerForm;
                }

                // 3. Garante que o Owner (Dashboard) esteja oculto ANTES de mostrar o novo form
                if (ownerForm != null && ownerForm.Visible)
                {
                    ownerForm.Hide();
                }

                // 4. Mostra o NOVO formulário da turma. Ele deve vir para a frente.
                newForm.Show();

                // 5. Esconde o formulário da turma ANTIGA, logo APÓS mostrar o novo.
                this.Hide();

                // 6. Agenda o fechamento seguro do formulário ANTIGO.
                this.BeginInvoke(new MethodInvoker(this.Close));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar trocar de turma: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Tratamento de erro: Tenta fechar este form com segurança
                try { this.BeginInvoke(new MethodInvoker(this.Close)); } catch { }
                // E tenta restaurar a visibilidade do dashboard se ele estava visível originalmente
                if (ownerForm != null && !ownerForm.IsDisposed && ownerWasOriginallyVisible)
                {
                    ownerForm.Show();
                }
            }
            // Não reexibimos o ownerForm aqui em caso de sucesso, pois a navegação é entre Turmas.
        }


        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            Cadastrar objCadastrar = new Cadastrar();
            objCadastrar.Show();
            this.Hide();
            this.BeginInvoke(new MethodInvoker(this.Close));
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

        private void btnAddAuxiliar_Click(object sender, EventArgs e)
        {

        }
    }
}
