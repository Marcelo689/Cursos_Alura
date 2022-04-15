namespace Testes
{
    internal class Aluno
    {
        public Aluno(string nomeAluno, int numeroMatricula)
        {
            NomeAluno = nomeAluno;
            NumeroMatricula = numeroMatricula;
        }

        public string NomeAluno { get; set; }
        public int NumeroMatricula { get; set; }
    }
}