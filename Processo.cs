using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escalonador
{
    internal class Processo
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Ordem { get; set; }
        public string Descricao { get; set; }
        public string Processador { get; set; }
        public int Tempo { get; set; }
        public int TempoExecutado { get; set; }
        public enum enumEstadoProcesso
        {

            EmExecucao = 1,
            Espera = 2,
            Pronto = 3,
            Encerrado = 4
        }

        public enumEstadoProcesso Estado { get; set; }

        public Processo(int ordem, int tempo, enumEstadoProcesso estado)
        {
            Ordem = ordem;
            Tempo = tempo;
            TempoExecutado = 0;
            Estado = estado;
        }

        public IList<Processo> Processos { get; set; }
    }
}
