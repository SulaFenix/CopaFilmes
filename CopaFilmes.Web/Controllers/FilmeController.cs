using AutoMapper;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.IApp;
using CopaFilmes.Web.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CopaFilmes.Web.Controllers
{
    public class FilmeController : Controller
    {
        private readonly IFilmeApp _filmeApp;

        public FilmeController(IFilmeApp filmeApp)
        {
            _filmeApp = filmeApp;
        }

        // GET: Filme
        public ActionResult Index()
        {
            ViewData["Titulo"] = "Fase de Seleção";
            ViewData["Subtitulo"] = "Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para prosseguir.";

            var filme = _filmeApp.GetFilmes();

            List<FilmeViewModel> filmeView = new List<FilmeViewModel>();

            foreach (var item in filme)
            {
                filmeView.Add(Mapper.Map<Filme, FilmeViewModel>(item));
            }

            return View(filmeView);
        }

        [HttpPost]
        public ActionResult Resultado(IList<FilmeViewModel> filmeViewModel)
        {
            ViewData["Titulo"] = "Resultado Final";
            ViewData["Subtitulo"] = "Veja o resultado final do Campeonato de filmes de forma simples e rápida.";

             IEnumerable<FilmeViewModel> filmesSelecionados = filmeViewModel.Where(x => x.Checked == true).ToList();

            List<Filme> filme = new List<Filme>();

            foreach (var item in filmesSelecionados)
            {
                filme.Add(Mapper.Map<FilmeViewModel, Filme>(item));
            }

            var teste = _filmeApp.Jogo(filme);
            return View(teste);
        }
    }
}