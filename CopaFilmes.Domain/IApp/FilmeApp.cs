using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.IRepositories;
using CopaFilmes.Domain.Service;
using System.Collections.Generic;

namespace CopaFilmes.Domain.IApp
{
    public class FilmeApp : IFilmeApp
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IFilmeService _filmeService;

        public FilmeApp(IFilmeRepository filmeRepository, IFilmeService filmeService)
        {
            _filmeRepository = filmeRepository;
            _filmeService = filmeService;
        }

        public Filme GetAno(int anoLancamento)
        {
            return _filmeRepository.GetAno(anoLancamento);
        }

        public IEnumerable<Filme> GetAsync(List<Filme> filmes)
        {
            return _filmeService.Jogo(filmes);
        }

        public IEnumerable<Filme> GetFilmes()
        {
            return _filmeRepository.GetAsync().Result;
        }

        public Filme GetId(string id)
        {
            return _filmeRepository.GetId(id);
        }

        public Filme GetTitul0(string titulo)
        {
            return _filmeRepository.GetTitulo(titulo);
        }

        public IEnumerable<Filme> Jogo(IEnumerable<Filme> jogadores)
        {
            return _filmeService.Jogo(jogadores);
        }
    }
}
