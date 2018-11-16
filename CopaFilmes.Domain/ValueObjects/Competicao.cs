using CopaFilmes.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Domain.ValueObjects
{
    public class Competicao
    {
        private IEnumerable<Filme> jogadores;

        public Competicao(IEnumerable<Filme> jogadores)
        {
            this.jogadores = jogadores;
        }

        public List<Filme> Ordenacao(IEnumerable<Filme> adversarios)
        {
            return adversarios.OrderBy(x => x.Titulo).ToList();
        }

        private List<Filme> Jogo(List<Filme> adversarios)
        {
            return adversarios.OrderByDescending(x => x.Nota).ThenBy(x => x.Titulo).ToList();
        }

        public List<Filme> QuartaFinal(List<Filme> adversarios)
        {
            List<Filme> jogo1 = new List<Filme>();
            List<Filme> jogo2 = new List<Filme>();
            List<Filme> jogo3 = new List<Filme>();
            List<Filme> jogo4 = new List<Filme>();
            List<Filme> resultadoFinal = new List<Filme>();

            jogo1.Add(adversarios[0]);
            jogo1.Add(adversarios[7]);
            resultadoFinal.Add(Jogo(jogo1)[0]);

            jogo2.Add(adversarios[1]);
            jogo2.Add(adversarios[6]);
            resultadoFinal.Add(Jogo(jogo2)[0]);

            jogo3.Add(adversarios[2]);
            jogo3.Add(adversarios[5]);
            resultadoFinal.Add(Jogo(jogo3)[0]);

            jogo4.Add(adversarios[3]);
            jogo4.Add(adversarios[4]);
            resultadoFinal.Add(Jogo(jogo4)[0]);

            return resultadoFinal;
        }

        public List<Filme> SemiFinal(List<Filme> adversarios)
        {
            List<Filme> jogo1 = new List<Filme>();
            List<Filme> jogo2 = new List<Filme>();
            List<Filme> resultadoFinal = new List<Filme>();

            jogo1.Add(adversarios[0]);
            jogo1.Add(adversarios[1]);
            resultadoFinal.Add(Jogo(jogo1)[0]);

            jogo2.Add(adversarios[2]);
            jogo2.Add(adversarios[3]);
            resultadoFinal.Add(Jogo(jogo2)[0]);

            return resultadoFinal;
        }

        public List<Filme> Final(List<Filme> adversarios)
        {
            return Jogo(adversarios);
        }
    }
}
