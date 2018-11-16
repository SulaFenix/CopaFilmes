using CopaFilmes.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CopaFilmes.Domain.Tests.Entities
{
    [TestClass]
    public class FilmeTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Filme_New_Titulo_Em_Branco()
        {
            var filme = new Filme("", 2018, 10, "1");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Filme_New_Titulo_Null()
        {
            var filme = new Filme(null, 2010, 10, "1");
        }
    }
}
