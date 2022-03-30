using System;
using System.Collections.Generic;

namespace Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            var esperanca = new Filme("string esperanca", 1977);
            Dictionary<int, Filme> filmes = new Dictionary<int, Filme>();
            filmes.Add(34672, esperanca);

            foreach(var filme in filmes)
            {
                Console.WriteLine("Chave = " + filme.Key + " Value = " + filme.Value.Titulo);
            }
            foreach(var filme in filmes.Values)
            {
                Console.WriteLine(filme.Titulo);
            }

            // encontrando valor com a chave passada no dicionario
            Console.WriteLine(filmes[34672].Titulo);

            // verirfica se chave existe
            Console.WriteLine(filmes.ContainsKey(34444));

            // tenta pegar valor da chave
            filmes.TryGetValue(34672, out Filme filme34672);
            Console.WriteLine(filme34672.Ano);
        }
    }
}
