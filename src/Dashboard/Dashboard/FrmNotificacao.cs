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


namespace Dashboard
{
    public partial class frmNotificacao : Form
    {
        private readonly int cursoId;
        private string nomeTurmaAtual = string.Empty;
        public frmNotificacao()
        {
            InitializeComponent();

            // 1. Turma Selecionada
            menuPrincipal2.TurmaSelecionada += (sender, novoCursoId) => {
                AbrirNovoFormularioTurma(novoCursoId);
            };

            // 2. Notificação Clicada (MANTENHA APENAS ESTA)
            menuPrincipal2.NotificacaoClicada += (sender, e) => {
                frmNotificacao formNotificacao = new frmNotificacao();
                formNotificacao.Show();
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };

            // 3. Perfil Clicado
            menuPrincipal2.PerfilClicado += (sender, e) => {
                FrmPerfil formPerfil = new FrmPerfil();
                formPerfil.Show();
                this.Hide();
                this.BeginInvoke(new MethodInvoker(this.Close));
            };

            // 4. Sair Clicado
            menuPrincipal2.SairClicado += (sender, e) => {
                Application.Exit();
            };

            // 5. Relatório Clicado
            menuPrincipal2.RelatorioClicado += (sender, e) => {
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

        private void frmNotificacao_Load(object sender, EventArgs e)
        {
            Maximizar_Tela();
            //NOME DAS TURMAS AINDA NÃO APARECE MAS ESTÁ DIRECIONANDO CORRETAMENTE
            //TurmaRedirecionamento.CarregarTurmas(Turmas_Direcionamento);
            //TurmaRedirecionamento.ConfigurarRedirecionamento(Turmas_Direcionamento, lblTurma, this);

        }

        private void Maximizar_Tela()
        {
            this.FormBorderStyle = FormBorderStyle.None;

            // Obtém a área de trabalho do monitor onde a janela está.
            Rectangle workingArea = Screen.FromHandle(this.Handle).WorkingArea;

            // Define a posição e o tamanho do formulário para preencher a área de trabalho.
            this.Location = workingArea.Location;
            this.Size = workingArea.Size;

            this.WindowState = FormWindowState.Normal;
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

        private void VoltarParaDashboard()
        {
            try
            {
                Form? parentForm = this.Owner ?? Application.OpenForms.OfType<frmDashboard_Principal>().FirstOrDefault();

                // Oculta o formulário atual primeiro
                this.Hide();

                if (parentForm != null && !parentForm.IsDisposed)
                {
                    parentForm.Show();
                }
                else
                {
                    // Se o dashboard não foi encontrado ou está fechado, pode ser necessário recriá-lo
                    // ou simplesmente fechar este form. Ajuste conforme a lógica da sua aplicação.
                    // Exemplo: Tentar encontrar e mostrar, ou criar um novo se não existir.
                    var dashboard = Application.OpenForms.OfType<frmDashboard_Principal>().FirstOrDefault();
                    if (dashboard != null)
                    {
                        dashboard.Show();
                    }
                    else
                    {
                        // new frmDashboard_Principal().Show(); // Descomente se quiser criar um novo se não houver
                    }
                }

                // Agenda o fechamento do formulário atual para ocorrer depois
                this.BeginInvoke(new MethodInvoker(this.Close));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao voltar para o dashboard: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Tenta fechar mesmo em caso de erro
                try { this.BeginInvoke(new MethodInvoker(this.Close)); } catch { }
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
