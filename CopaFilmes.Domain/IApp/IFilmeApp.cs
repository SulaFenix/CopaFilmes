using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Domain.IApp
{
    public interface IFilmeApp
    {
        Filme GetTitul0(string titulo);
        Filme GetId(string id);
        Filme GetAno(int anoLancamento);
        IEnumerable<Filme> GetFilmes();
        IEnumerable<Filme> GetAsync(List<Filme> filmes);
        IEnumerable<Filme> Jogo(IEnumerable<Filme> jogadores);
    }
}
