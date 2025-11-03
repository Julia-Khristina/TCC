
using System;

namespace Dashboard
{
    public class NotificacaoAluno
    {
        public string NomeAluno { get; set; }
        public string NomeSerie { get; set; }
        public string NomeCurso { get; set; }
        public int TotalAtrasosMes { get; set; }

        public string Titulo
        {
            get => $"{NomeAluno} - {NomeSerie} de {NomeCurso}";
        }

        public string Descricao
        {
            get => $"O estudante registrou {TotalAtrasosMes} faltas no mês atual.";
        }
    }
}
