using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.ValueObjects;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Service
{
    public class FilmeService : IFilmeService
    {
        public IEnumerable<Filme> Jogo(IEnumerable<Filme> jogadores)
        {
            Competicao competicao = new Competicao(jogadores);
            var ordenacao = competicao.Ordenacao(jogadores);
            var quartaFinal = competicao.QuartaFinal(ordenacao);
            var semiFinal = competicao.SemiFinal(quartaFinal);
            var final = competicao.Final(semiFinal);

            return final;
        }
    }
}
