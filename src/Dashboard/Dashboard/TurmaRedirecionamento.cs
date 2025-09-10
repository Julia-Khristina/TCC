using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dashboard
{
    public static class TurmaRedirecionamento
    {
        private static readonly string connectionString = "Server=localhost;Database=Db_Pontualize;Uid=root;Pwd=;";

        public static void CarregarTurmas(ComboBox comboBox)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT nm_Curso FROM Curso ORDER BY nm_Curso"; // Ordena para facilitar visualização
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBox.BeginUpdate();
                        comboBox.Items.Clear();

                        while (reader.Read())
                        {
                            string curso = reader["nm_Curso"]?.ToString() ?? "";
                            if (!string.IsNullOrWhiteSpace(curso))
                            {
                                comboBox.Items.Add(curso);
                            }
                        }

                        comboBox.EndUpdate();
                        comboBox.Refresh(); // força atualização visual
                    }
                }

                // Se não houver cursos, adiciona uma opção de aviso
                if (comboBox.Items.Count == 0)
                {
                    comboBox.Items.Add("Nenhum curso encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar turmas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ConfigurarRedirecionamento(ComboBox comboBox, Label? lbl = null, Form? currentForm = null)
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndexChanged += (sender, e) =>
            {
                if (comboBox.SelectedIndex != -1 && comboBox.SelectedItem != null)
                {
                    string nomeTurma = comboBox.SelectedItem.ToString()!;

                    // Ignora clique na opção de aviso
                    if (nomeTurma == "Nenhum curso encontrado")
                        return;

                    if (lbl != null) lbl.Visible = false;
                    ObterCodigoCursoERedirecionar(nomeTurma, currentForm, comboBox, lbl);
                }
            };
        }

        private static void ObterCodigoCursoERedirecionar(string nomeTurma, Form? currentForm, ComboBox comboBox, Label? lbl)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT cd_Curso FROM Curso WHERE nm_Curso = @nomeTurma LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nomeTurma", nomeTurma);

                        object? result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int cd_Curso = Convert.ToInt32(result);
                            AbrirFormularioTurma(cd_Curso, currentForm, comboBox, lbl);
                        }
                        else
                        {
                            MessageBox.Show("Curso não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao redirecionar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void AbrirFormularioTurma(int cd_Curso, Form? currentForm, ComboBox comboBox, Label? lbl)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmTurma)
                {
                    form.Close();
                    break;
                }
            }

            frmTurma formTurma = new frmTurma(cd_Curso);
            formTurma.FormClosed += (s, args) =>
            {
                currentForm?.Show();
                if (comboBox != null)
                    comboBox.SelectedIndex = -1;
                if (lbl != null)
                    lbl.Visible = true;
            };

            formTurma.Show();
            currentForm?.Hide();
        }
    }
}
