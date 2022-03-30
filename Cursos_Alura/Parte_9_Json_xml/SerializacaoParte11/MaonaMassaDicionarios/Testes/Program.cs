using System;

namespace Testes
{
    class Program
    {


        public static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("Dominando as coleções do C#", "Marcelo Oliveira");

            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            foreach (var aula in csharpColecoes.Aulas)
            {
                Console.WriteLine(aula.Titulo);
            }
        }
    }
}
