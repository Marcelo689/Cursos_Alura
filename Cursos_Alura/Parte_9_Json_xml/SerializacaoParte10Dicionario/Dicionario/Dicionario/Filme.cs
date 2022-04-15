namespace Dicionario
{
    internal class Filme
    {
        public string Titulo { get; set; }
        public int Ano { get; set; }

        public Filme(string titulo, int ano)
        {
            this.Titulo = titulo;
            this.Ano = ano;
        }
    }
}