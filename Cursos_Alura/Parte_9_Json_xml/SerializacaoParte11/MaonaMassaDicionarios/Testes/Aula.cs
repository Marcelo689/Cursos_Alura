namespace Testes
{
    public class Aula
    {
        public string Titulo { get; set;}
        public int Numero { get; set; }

        public Aula(string titulo, int numero)
        {
            this.Titulo = titulo;
            this.Numero = numero;
        }
    }
}