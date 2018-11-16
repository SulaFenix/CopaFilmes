using CopaFilmes.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopaFilmes.Domain.IRepositories
{
    public interface IFilmeRepository
    {
        Filme GetTitulo(string titulo);
        Filme GetId(string id);
        Filme GetAno(int anoLancamento);
        Task<IEnumerable<Filme>> GetAsync();
        Task<IEnumerable<Filme>> GetAsync(List<Filme> filmes);
    }
}
