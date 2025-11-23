using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using MySql.Data.MySqlClient;
using System.Windows.Forms; // Necessário para MessageBox e Environment.SpecialFolder

namespace Dashboard
{
    public partial class AdvertenciaPreenchida : Form

    {
        /// <param name="rmAluno">O RM (cd_Aluno) do aluno.</param>
        /// <param name="conexao">A string de conexão com o banco de dados MySql.</param>
        public static void GerarAdvertencia(string rmAluno, string conexao)
        {
            try
            {
                // 1. Conexão e Busca de Dados
                using (var conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                        string query = @"
                        SELECT
                            a.nm_Aluno,
                            s.nm_Serie, 
                            c.nm_Curso, 
                            atrasos 
                        FROM Aluno a 
                        INNER JOIN Serie s on a.Serie_Aluno = s.cd_Serie
                        INNER JOIN Curso c on a.Curso_Aluno = c.cd_Curso
                        WHERE cd_Aluno = @rmAluno
                                            ";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@rmAluno", rmAluno);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var dados = new Dictionary<string, string>
                                {
                                    { "NomeAluno", reader["nm_Aluno"].ToString() },
                                    { "SerieAluno", reader["nm_Serie"].ToString() },
                                    { "CursoAluno", reader["nm_Curso"].ToString() },
                                    { "AtrasosAluno", reader["atrasos"].ToString() },
                                    { "DATA", DateTime.Now.ToString("dd/MM/yyyy")}
                                };

                                string modeloPath = @"C:\Users\Jane Oliveira\Documents\GitHub\TCC\documentos\ModeloAdvertencia\modelo_oficial.docx";

                                string outputDir = @"C:\Users\Jane Oliveira\Documents\GitHub\TCC\documentos\SaídaAdvertencia";

                                string saidaPath = Path.Combine(outputDir, $"Advertencia_{dados["NomeAluno"].Replace(" ", "_")}.docx");

                                if (!File.Exists(modeloPath))
                                {
                                    MessageBox.Show($"ERRO: Arquivo modelo não encontrado em {modeloPath}. Verifique o caminho.", "Erro de Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                File.Copy(modeloPath, saidaPath, true);

                                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(saidaPath, true))
                                {
                                    // Processar o corpo principal do documento
                                    ReplacePlaceholdersInElement(wordDoc.MainDocumentPart.Document.Body, dados);

                                    // Processar cabeçalhos e rodapés 
                                    if (wordDoc.MainDocumentPart.HeaderParts != null)
                                    {
                                        foreach (var headerPart in wordDoc.MainDocumentPart.HeaderParts)
                                        {
                                            ReplacePlaceholdersInElement(headerPart.Header, dados);
                                        }
                                    }

                                    if (wordDoc.MainDocumentPart.FooterParts != null)
                                    {
                                        foreach (var footerPart in wordDoc.MainDocumentPart.FooterParts)
                                        {
                                            ReplacePlaceholdersInElement(footerPart.Footer, dados);
                                        }
                                    }
                                }

                                MessageBox.Show("Advertência gerada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(saidaPath));
                            }
                            else
                            {
                                MessageBox.Show("Aluno não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar advertência: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ReplacePlaceholdersInElement(OpenXmlCompositeElement element, Dictionary<string, string> data)
        {
            foreach (var paragraph in element.Descendants<Paragraph>())
            {
                // Verifica se o parágrafo contém uma imagem. Se sim, pula a substituição para preservar a logo.
                if (ParagraphContainsImage(paragraph))
                {
                    continue;
                }
                SearchAndReplace(paragraph, data);
            }

            foreach (var table in element.Descendants<Table>())
            {
                foreach (var row in table.Descendants<TableRow>())
                {
                    foreach (var cell in row.Descendants<TableCell>())
                    {
                        foreach (var paragraph in cell.Descendants<Paragraph>())
                        {
                            if (ParagraphContainsImage(paragraph))
                            {
                                continue;
                            }
                            SearchAndReplace(paragraph, data);
                        }
                    }
                }
            }
        }

        private static void SearchAndReplace(Paragraph paragraph, Dictionary<string, string> data)
        {
            // Concatena o texto de todos os Runs para procurar o placeholder
            string paragraphText = string.Concat(paragraph.Descendants<Run>().Select(r => r.InnerText));

            foreach (var item in data)
            {
                string placeholder = item.Key;
                string replacement = item.Value;

                if (paragraphText.Contains(placeholder))
                {
                    Run targetRun = paragraph.Descendants<Run>().FirstOrDefault(r => r.InnerText.Contains(placeholder));

                    if (targetRun != null)
                    {
                        // Substitui o texto dentro do Text element do Run
                        Text textElement = targetRun.Descendants<Text>().FirstOrDefault();
                        if (textElement != null)
                        {
                            textElement.Text = textElement.Text.Replace(placeholder, replacement);
                        }
                    }
                }
            }
        }

        /// <param name="paragraph">O parágrafo a ser verificado.</param>
        private static bool ParagraphContainsImage(Paragraph paragraph)
        {
            return paragraph.Descendants<Drawing>().Any();
        }
    }
}
