using CopaFilmes.Helpers;

namespace CopaFilmes.Domain.Entities
{
    public class Filme : EntityBase
    {
        public string Titulo { get; private set; }
        public int AnoLancamento { get; private set; }
        public double Nota { get; private set; }

        protected Filme()
        {

        }

        public Filme(string titulo, int ano, double nota, string id)
        {
            SetTitulo(titulo);
            SetAnoLancamento(ano);
            SetNota(nota);
            Id = id;
        }

        public void SetTitulo(string titulo)
        {
            Guard.ForNullOrEmptyDefaultMessage(titulo, "Titulo");
            Titulo = titulo;
        }

        public void SetAnoLancamento(int anoLancamento)
        {
            AnoLancamento = anoLancamento;
        }

        public void SetNota(double nota)
        {
            Nota = nota;
        }
    }
}
