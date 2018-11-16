using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Service
{
    public interface IFilmeService
    {
        IEnumerable<Filme> Jogo(IEnumerable<Filme> jogadores);
    }
}
