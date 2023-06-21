using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnaEletronica {
    internal class Candidato {

        public string NumeroLegenda { get; set; }
        public string Nome { get; set; }
        public string Partido { get; set; }

        public Candidato(string numeroLeganda, string nome, string partido) {
            NumeroLegenda = numeroLeganda;
            Nome = nome;
            Partido = partido;
        }

        public Image CarregarFoto(string caminho) {
            return Image.FromFile(caminho);
        }

    }
}
