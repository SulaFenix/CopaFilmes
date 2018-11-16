using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Repositories.Tests.TestData
{
    public class FilmeTestData
    {
        public static List<Filme> Get()
        {
            return new List<Filme>
            {
                new Filme("Titulo 1", 2016, 6, "1"),
                new Filme("Titulo 2", 2000, 9.1, "2"),
                new Filme("Titulo 3", 2010, 9.3, "3")
            };
        }
    }
}
