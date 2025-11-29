using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class frmPromoverAlunos : Form
    {
        private const string CONEXAO_STRING = "datasource=localhost;database=Db_Pontualize;uid=root;pwd=;";

        public frmPromoverAlunos()
        {
            InitializeComponent();

            JustificarRichText(richTextBox1);

            //RichTextBox
            richTextBox1.ReadOnly = true;
            richTextBox1.BorderStyle = BorderStyle.None; // Garante que a borda seja removida
            richTextBox1.TabStop = false;
        }

        private const int EM_SETPARAFORMAT = 1095;
        private const int PFM_ALIGNMENT = 0x00000008;
        private const int PFA_JUSTIFY = 0x0004;

        [StructLayout(LayoutKind.Sequential)]
        private struct PARAFORMAT
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, ref PARAFORMAT lParam);

        private void JustificarRichText(RichTextBox box)
        {
            PARAFORMAT fmt = new PARAFORMAT();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.dwMask = PFM_ALIGNMENT;
            fmt.wAlignment = PFA_JUSTIFY;

            SendMessage(box.Handle, EM_SETPARAFORMAT, IntPtr.Zero, ref fmt);
        }

        // Carrega os cursos na cbm
        private void CarregarCursos()
        {
            try
            {
                string query = "SELECT cd_Curso, nm_Curso FROM Curso";

                using (MySqlConnection conexao = new MySqlConnection(CONEXAO_STRING))
                {
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable tabela = new DataTable();

                    adapter.Fill(tabela);

                    cbmCurso.DisplayMember = "nm_Curso";
                    cbmCurso.ValueMember = "cd_Curso";
                    cbmCurso.DataSource = tabela;
                    cbmCurso.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cursos: " + ex.Message);
            }
        }

        // Carregar séries na cbm
        private void CarregarSeries()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CONEXAO_STRING))
                {
                    conn.Open();
                    string query = "SELECT cd_Serie, nm_Serie FROM Serie";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cbmSerie.DisplayMember = "nm_Serie";
                    cbmSerie.ValueMember = "cd_Serie";
                    cbmSerie.DataSource = dt;
                    cbmSerie.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar séries: " + ex.Message);
            }
        }

        // Carrega os alunos da turma selecionada
        private void CarregarAlunos()
        {
            if (cbmCurso.SelectedIndex != -1 && cbmSerie.SelectedIndex != -1)
            {
                try
                {
                    int idCurso = (int)cbmCurso.SelectedValue;
                    int idSerie = (int)cbmSerie.SelectedValue;

                    string query = @"
                        SELECT 
                            cd_Aluno, 
                            nm_Aluno 
                        FROM 
                            Aluno 
                        WHERE 
                            Curso_Aluno = @idCurso AND Serie_Aluno = @idSerie";

                    using (MySqlConnection conexao = new MySqlConnection(CONEXAO_STRING))
                    {
                        MySqlCommand comando = new MySqlCommand(query, conexao);
                        comando.Parameters.AddWithValue("@idCurso", idCurso);
                        comando.Parameters.AddWithValue("@idSerie", idSerie);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                        DataTable tabela = new DataTable();

                        adapter.Fill(tabela);

                        clbAlunos.DataSource = tabela;
                        clbAlunos.DisplayMember = "nm_Aluno";
                        clbAlunos.ValueMember = "cd_Aluno";

                        clbAlunos.Enabled = true;
                        for (int i = 0; i < clbAlunos.Items.Count; i++)
                        {
                            clbAlunos.SetItemChecked(i, false);
                        }

                        if (tabela.Rows.Count == 0)
                        {
                            MessageBox.Show("Nenhum aluno encontrado para a turma selecionada.");
                            clbAlunos.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
                    clbAlunos.Enabled = false;
                }
            }
            else
            {
                clbAlunos.DataSource = null;
                clbAlunos.Enabled = false;
            }
        }

        private void cbmCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmCurso.SelectedValue != null && cbmCurso.SelectedValue != DBNull.Value)
            {
                CarregarAlunos();
            }
            else
            {
                clbAlunos.DataSource = null;
                clbAlunos.Enabled = false;
            }
        }

        private void cbmSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmSerie.SelectedValue != null && cbmSerie.SelectedValue != DBNull.Value)
            {
                CarregarAlunos();
            }
            else
            {
                clbAlunos.DataSource = null;
                clbAlunos.Enabled = false;
            }
        }

        private void frmPromoverAlunos_Load(object sender, EventArgs e)
        {
            CarregarCursos();
            CarregarSeries();
            clbAlunos.Enabled = false;
        }

        // Lógica de Promoção/Retenção
        private void btn_promover_Click(object sender, EventArgs e)
        {
            if (cbmCurso.SelectedIndex == -1 || cbmSerie.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o Curso e a Série para continuar.");
                return;
            }

            if (clbAlunos.Items.Count == 0)
            {
                MessageBox.Show("Não há alunos para promover nesta turma.");
                return;
            }

            int idCursoAtual = (int)cbmCurso.SelectedValue;
            int idSerieAtual = (int)cbmSerie.SelectedValue;
            int idProximaSerie = idSerieAtual + 1;

            List<int> alunosRetidos = new List<int>();
            foreach (DataRowView item in clbAlunos.CheckedItems)
            {
                alunosRetidos.Add((int)item["cd_Aluno"]);
            }

            List<int> todosAlunosDaTurma = new List<int>();
            foreach (DataRowView item in clbAlunos.Items)
            {
                todosAlunosDaTurma.Add((int)item["cd_Aluno"]);
            }

            List<int> alunosPromovidos = todosAlunosDaTurma.Except(alunosRetidos).ToList();

            using (MySqlConnection conexao = new MySqlConnection(CONEXAO_STRING))
            {
                try
                {
                    conexao.Open();
                    MySqlTransaction transacao = conexao.BeginTransaction();

                    try
                    {
                        if (alunosPromovidos.Count > 0)
                        {
                            // Se a série atual for a última (ex: 3)
                            if (idSerieAtual == 3)
                            {
                                // Alunos promovidos da última série: setar Serie_Aluno e Curso_Aluno para NULL
                                string sqlPromover = @"
                                    UPDATE Aluno 
                                    SET 
                                        Serie_Aluno = NULL, 
                                        Curso_Aluno = NULL
                                    WHERE 
                                        cd_Aluno IN ({0})";

                                string idsPromovidos = string.Join(",", alunosPromovidos);
                                MySqlCommand cmdPromover = new MySqlCommand(string.Format(sqlPromover, idsPromovidos), conexao, transacao);
                                cmdPromover.ExecuteNonQuery();
                            }
                            else // Promover para a próxima série
                            {
                                string sqlPromover = @"
                                    UPDATE Aluno 
                                    SET 
                                        Serie_Aluno = @idProximaSerie 
                                    WHERE 
                                        cd_Aluno IN ({0})";

                                string idsPromovidos = string.Join(",", alunosPromovidos);
                                MySqlCommand cmdPromover = new MySqlCommand(string.Format(sqlPromover, idsPromovidos), conexao, transacao);
                                cmdPromover.Parameters.AddWithValue("@idProximaSerie", idProximaSerie);
                                cmdPromover.ExecuteNonQuery();
                            }
                        }

                        transacao.Commit();
                        MessageBox.Show($"Promoção concluída! {alunosPromovidos.Count} alunos promovidos e {alunosRetidos.Count} alunos retidos.");

                        CarregarAlunos();
                    }
                    catch (Exception ex)
                    {
                        transacao.Rollback();
                        MessageBox.Show("Erro durante a transação de promoção: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão com o banco de dados: " + ex.Message);
                }
            }
        }

        // Botão Voltar
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnLine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void arredondamentoCard2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
