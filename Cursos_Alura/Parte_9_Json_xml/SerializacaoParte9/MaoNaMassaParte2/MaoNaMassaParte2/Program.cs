using System;
using System.Collections.Generic;

namespace MaoNaMassaParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Colecoes", "Marcelo Oliveira");

            //csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            //csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            //csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));
            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            ISet<Aluno> alunos = new HashSet<Aluno>();

            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach (var aluno in csharpColecoes.Alunos)
            {

            }

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine("Tonini está matriculada? " + csharpColecoes.EstaMatriculado(tonini));
            Console.WriteLine("a1 é equals a Tonini?");
            Console.WriteLine(a1.Equals(tonini));

        }
    }
}
