using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms; 

namespace Dashboard
{
    public class Notificacao_Dados
    {
        private readonly string _conexao;

        public Notificacao_Dados(string connStr)
        {
            _conexao = connStr;
        }
        public List<NotificacaoAluno> GetNotificacoesAtrasos(string? nomeCursoFiltro = null, string? nomeSerieFiltro = null)
        {
            List<NotificacaoAluno> notificacoes = new List<NotificacaoAluno>();

            StringBuilder sqlQuery = new StringBuilder(@"
                SELECT
                    A.nm_Aluno,
                    S.nm_Serie,
                    C.nm_Curso,
                    COUNT(RA.cd_Registro) AS total_atrasos_mes
                FROM
                    RegistroAtraso RA
                JOIN
                    Aluno A ON RA.cd_Aluno = A.cd_Aluno
                JOIN
                    Serie S ON A.Serie_Aluno = S.cd_Serie
                JOIN
                    Curso C ON A.Curso_Aluno = C.cd_Curso
                WHERE
                    YEAR(RA.data_registro) = YEAR(CURDATE()) AND MONTH(RA.data_registro) = MONTH(CURDATE())
            ");

            // Adiciona filtros se existirem
            if (!string.IsNullOrEmpty(nomeCursoFiltro))
            {
                sqlQuery.Append(" AND C.nm_Curso = @nomeCursoFiltro");
            }

            if (!string.IsNullOrEmpty(nomeSerieFiltro))
            {
                sqlQuery.Append(" AND S.nm_Serie = @nomeSerieFiltro");
            }

            // Adiciona GROUP BY e HAVING
            sqlQuery.Append(@"
                GROUP BY
                    A.cd_Aluno, A.nm_Aluno, S.nm_Serie, C.nm_Curso
                HAVING
                    COUNT(RA.cd_Registro) >= 3;");

            using (MySqlConnection connection = new MySqlConnection(_conexao))
            {
                using (MySqlCommand command = new MySqlCommand(sqlQuery.ToString(), connection))
                {
                    // Adiciona parâmetros se existirem
                    if (!string.IsNullOrEmpty(nomeCursoFiltro))
                    {
                        command.Parameters.AddWithValue("@nomeCursoFiltro", nomeCursoFiltro);
                    }

                    if (!string.IsNullOrEmpty(nomeSerieFiltro))
                    {
                        command.Parameters.AddWithValue("@nomeSerieFiltro", nomeSerieFiltro);
                    }

                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                notificacoes.Add(new NotificacaoAluno
                                {
                                    NomeAluno = reader.GetString("nm_Aluno"),
                                    NomeSerie = reader.GetString("nm_Serie"),
                                    NomeCurso = reader.GetString("nm_Curso"),
                                    TotalAtrasosMes = reader.GetInt32("total_atrasos_mes")
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Em um ambiente de produção, registre o erro.
                        MessageBox.Show("Erro ao carregar notificações: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return notificacoes;
        }
    }
}
