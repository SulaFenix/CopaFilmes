namespace CopaFilmes.Web.Models
{
    public class FilmeViewModel
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public double Nota { get; set; }
        public bool Checked { get; set; }
    }
}