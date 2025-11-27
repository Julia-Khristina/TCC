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
    public partial class Frm_PromoverAluno : Form
    {
        public Frm_PromoverAluno()
        {
            InitializeComponent();
        }

        private void cmbInsertSerie()
        {
            string conexao = "datasource=localhost;user=root;password=;database=Db_Pontualize;";
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
                string query = "SELECT * FROM Curso";

                MySqlConnection conexao = new MySqlConnection("datasource=localhost;database=Db_Pontualize;uid=root;pwd=;");
                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();

                adapter.Fill(tabela);

                cmbTurma.DisplayMember = "nm_Curso";
                cmbTurma.ValueMember = "cd_Curso";
                cmbTurma.DataSource = tabela;
                cmbTurma.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar séries: " + ex.Message);
            }
        }

        // NOVO MÉTODO: Carrega os alunos com base na Série e no Curso selecionados
        private void cmbInsertAluno()
        {
            // Verifica se tanto a Série quanto o Curso foram selecionados
            if (cmbAno.SelectedValue == null || cmbTurma.SelectedValue == null)
            {
                cbmAlunos.DataSource = null; // Limpa a lista de alunos
                cbmAlunos.Enabled = false;
                return;
            }

            try
            {
                // Obtém os IDs selecionados
                int cdSerie = Convert.ToInt32(cmbAno.SelectedValue);
                int cdCurso = Convert.ToInt32(cmbTurma.SelectedValue);

                // Consulta SQL para buscar alunos que pertencem à Série e ao Curso selecionados
                string query = @"SELECT cd_Aluno, nm_Aluno FROM Aluno WHERE cd_Serie = @cdSerie AND cd_Curso = @cdCurso ORDER BY nm_Aluno";
                string conexao = "datasource=localhost;user=root;password=;database=Db_Pontualize;";
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Adiciona parâmetros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@cdSerie", cdSerie);
                    cmd.Parameters.AddWithValue("@cdCurso", cdCurso);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    // Configura o ComboBox de Alunos
                    cbmAlunos.DisplayMember = "nm_Aluno";
                    cbmAlunos.ValueMember = "cd_Aluno";
                    cbmAlunos.DataSource = tabela;
                    cbmAlunos.SelectedIndex = -1; // Nenhuma opção selecionada

                    // Habilita o ComboBox de alunos se houver dados
                    cbmAlunos.Enabled = tabela.Rows.Count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
                cbmAlunos.DataSource = null;
                cbmAlunos.Enabled = false;
            }
        }

        // NOVO EVENT HANDLER: Chamado quando o Curso (cmbTurma) é alterado
        private void cmbTurma_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTurma.SelectedValue != null && cmbTurma.SelectedIndex != -1)
            {
                cmbInsertAluno();
            }
            else
            {
                cbmAlunos.DataSource = null;
                cbmAlunos.Enabled = false;
            }
        }

        // NOVO EVENT HANDLER: Chamado quando a Série (cmbAno) é alterada
        private void cmbAno_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbAno.SelectedValue != null && cmbAno.SelectedIndex != -1)
            {
                cmbInsertAluno();
            }
            else
            {
                cbmAlunos.DataSource = null;
                cbmAlunos.Enabled = false;
            }
        }
    }
}
