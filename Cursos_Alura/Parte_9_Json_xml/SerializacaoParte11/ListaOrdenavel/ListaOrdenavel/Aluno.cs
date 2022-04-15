namespace ListaOrdenavel
{
    internal class Aluno
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public Aluno(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }
    }
}