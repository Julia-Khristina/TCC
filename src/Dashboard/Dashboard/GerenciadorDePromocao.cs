using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public partial class GerenciadorDePromocao : Component
    {

        public static class GerenciadorDeEventos
        {
            //Altere o delegate para aceitar argumentos
            public delegate void PromocaoConcluidaHandler(int cursoId, int serieOriginalId);

            // Altere o evento para usar o novo delegate
            public static event PromocaoConcluidaHandler PromocaoConcluida;

            // Altere o método de disparo para passar os IDs
            public static void DispararPromocaoConcluida(int cursoId, int serieOriginalId)
            {
                PromocaoConcluida?.Invoke(cursoId, serieOriginalId);
            }
        }

    }
}
