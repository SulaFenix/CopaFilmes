using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Tests.ValueObjects
{
    [TestClass]
    public class CompeticaoTests
    {
        private List<Filme> filmesSelecionados = new List<Filme>();
        private List<Filme> ordenacaoEsperada = new List<Filme>();

        public CompeticaoTests()
        {
            filmesSelecionados.Add(new Filme("Os Incríveis 2", 2018, 8.5, "1"));
            filmesSelecionados.Add(new Filme("Jurassic World: Reino Ameaçado", 2018, 6.7, "2"));
            filmesSelecionados.Add(new Filme("Oito Mulheres e um Segredo", 2018, 6.3, "3"));
            filmesSelecionados.Add(new Filme("Hereditário", 2018, 7.8, "4"));
            filmesSelecionados.Add(new Filme("Vingadores: Guerra Infinita", 2018, 8.8, "5"));
            filmesSelecionados.Add(new Filme("Deadpool 2", 2018, 8.1, "6"));
            filmesSelecionados.Add(new Filme("Han Solo: Uma História Star Wars", 2018, 7.2, "7"));
            filmesSelecionados.Add(new Filme("Thor: Ragnarok", 2017, 7.9, "8"));

            ordenacaoEsperada.Add(new Filme("Deadpool 2", 2018, 8.1, "6"));
            ordenacaoEsperada.Add(new Filme("Han Solo: Uma História Star Wars", 2018, 7.2, "7"));
            ordenacaoEsperada.Add(new Filme("Hereditário", 2018, 7.8, "4"));
            ordenacaoEsperada.Add(new Filme("Jurassic World: Reino Ameaçado", 2018, 6.7, "2"));
            ordenacaoEsperada.Add(new Filme("Oito Mulheres e um Segredo", 2018, 6.3, "3"));
            ordenacaoEsperada.Add(new Filme("Os Incríveis 2", 2018, 8.5, "1"));
            ordenacaoEsperada.Add(new Filme("Thor: Ragnarok", 2017, 7.9, "8"));
            ordenacaoEsperada.Add(new Filme("Vingadores: Guerra Infinita", 2018, 8.8, "5"));
        }

        [TestMethod]
        public void Competicao_Ordenacao_Tem_Que_Ser_Como_Estabelecida()
        {
            var competicao = new Competicao(filmesSelecionados);
            var ordenacao = competicao.Ordenacao(filmesSelecionados);

            Assert.AreEqual(ordenacaoEsperada[0].Titulo, ordenacao[0].Titulo);
            Assert.AreEqual(ordenacaoEsperada[1].Titulo, ordenacao[1].Titulo);
            Assert.AreEqual(ordenacaoEsperada[2].Titulo, ordenacao[2].Titulo);
            Assert.AreEqual(ordenacaoEsperada[3].Titulo, ordenacao[3].Titulo);
            Assert.AreEqual(ordenacaoEsperada[4].Titulo, ordenacao[4].Titulo);
            Assert.AreEqual(ordenacaoEsperada[5].Titulo, ordenacao[5].Titulo);
            Assert.AreEqual(ordenacaoEsperada[6].Titulo, ordenacao[6].Titulo);
            Assert.AreEqual(ordenacaoEsperada[7].Titulo, ordenacao[7].Titulo);
        }

        [TestMethod]
        public void Competicao_Jogo_Quarta_Finais()
        {
            List<Filme> resultadoEsperado = new List<Filme>();
            resultadoEsperado.Add(new Filme("Vingadores: Guerra Infinita", 2018, 8.8, "5"));
            resultadoEsperado.Add(new Filme("Thor: Ragnarok", 2017, 7.9, "8"));
            resultadoEsperado.Add(new Filme("Os Incríveis 2", 2018, 8.5, "1"));
            resultadoEsperado.Add(new Filme("Jurassic World: Reino Ameaçado", 2018, 6.7, "2"));

            var competicao = new Competicao(filmesSelecionados);
            var ordenacao = competicao.Ordenacao(filmesSelecionados);
            var quartaFinal = competicao.QuartaFinal(ordenacao);

            Assert.AreEqual(resultadoEsperado[0].Titulo, quartaFinal[0].Titulo);
            Assert.AreEqual(resultadoEsperado[1].Titulo, quartaFinal[1].Titulo);
            Assert.AreEqual(resultadoEsperado[2].Titulo, quartaFinal[2].Titulo);
            Assert.AreEqual(resultadoEsperado[3].Titulo, quartaFinal[3].Titulo);
        }

        [TestMethod]
        public void Competicao_Jogo_Semi_Final()
        {
            List<Filme> resultadoEsperado = new List<Filme>();
            resultadoEsperado.Add(new Filme("Vingadores: Guerra Infinita", 2018, 8.8, "5"));
            resultadoEsperado.Add(new Filme("Os Incríveis 2", 2018, 8.5, "1"));

            var competicao = new Competicao(filmesSelecionados);
            var ordenacao = competicao.Ordenacao(filmesSelecionados);
            var quartaFinal = competicao.QuartaFinal(ordenacao);
            var semiFinal = competicao.SemiFinal(quartaFinal);

            Assert.AreEqual(resultadoEsperado[0].Titulo, semiFinal[0].Titulo);
            Assert.AreEqual(resultadoEsperado[1].Titulo, semiFinal[1].Titulo);
        }

        [TestMethod]
        public void Competicao_Jogo_Final_Vencedor()
        {
            List<Filme> resultadoEsperado = new List<Filme>();
            resultadoEsperado.Add(new Filme("Vingadores: Guerra Infinita", 2018, 8.8, "5"));

            var competicao = new Competicao(filmesSelecionados);
            var ordenacao = competicao.Ordenacao(filmesSelecionados);
            var quartaFinal = competicao.QuartaFinal(ordenacao);
            var semiFinal = competicao.SemiFinal(quartaFinal);
            var final = competicao.Final(semiFinal);

            Assert.AreEqual(resultadoEsperado[0].Titulo, final[0].Titulo);
        }

        [TestMethod]
        public void Competicao_Jogo_Final_Perdedor()
        {
            List<Filme> resultadoEsperado = new List<Filme>();
            resultadoEsperado.Add(new Filme("Os Incríveis 2", 2018, 8.5, "1"));

            var competicao = new Competicao(filmesSelecionados);
            var ordenacao = competicao.Ordenacao(filmesSelecionados);
            var quartaFinal = competicao.QuartaFinal(ordenacao);
            var semiFinal = competicao.SemiFinal(quartaFinal);
            var final = competicao.Final(semiFinal);

            Assert.AreEqual(resultadoEsperado[0].Titulo, final[1].Titulo);
        }
    }
}
