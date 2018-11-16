using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CopaFilmes.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly IRepository<Filme> _filmeRepository;

        public FilmeRepository(IRepository<Filme> filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        public Filme GetAno(int anoLancamento)
        {
            return _filmeRepository.Get().FirstOrDefault(x => x.AnoLancamento == anoLancamento);
        }

        public Task<IEnumerable<Filme>> GetAsync()
        {
            return _filmeRepository.GetAll();
        }

        public Task<IEnumerable<Filme>> GetAsync(List<Filme> filmes)
        {
            throw new NotImplementedException();
        }

        public Filme GetId(string id)
        {
            return _filmeRepository.Get().FirstOrDefault(x => x.Id == id);
        }

        public Filme GetTitulo(string titulo)
        {
            return _filmeRepository.Get().FirstOrDefault(x => x.Titulo == titulo);
        }
    }
}
