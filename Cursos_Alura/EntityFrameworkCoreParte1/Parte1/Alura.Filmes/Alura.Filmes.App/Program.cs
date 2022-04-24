using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeira parte
            //select * from actor
            //using (var contexto = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();

            //    foreach (var ator in contexto.Atores)
            //    {
            //        System.Console.WriteLine(ator);
            //    }
            //}

            // Segunda Parte
            //using(var contexto = new AluraFilmesContexto())
            //{
            //    contexto.LogSQLToConsole();
            //    var ator = new Ator();
            //    ator.PrimeiroNome = "Marcelo";
            //    ator.UltimoNome = "Jaeger";
            //    contexto.Entry(ator).Property("last_update").CurrentValue = DateTime.Now;
            //    contexto.Atores.Add(ator);

            //    contexto.SaveChanges();

            //    var ator1 = contexto.Atores.First();

            //    Console.WriteLine(ator1);
            //    Console.WriteLine(contexto.Entry(ator1).Property("last_update").CurrentValue);

            //    contexto.SaveChanges();
            //}

            // Terceira Parte
            using(var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                var atores = contexto.Atores.OrderByDescending(a => EF.Property<DateTime>(a, "last_update"))
                    .Take(10);

                foreach (var ator in atores)
                {
                    Console.WriteLine(ator.ToString() + "       " + contexto.Entry(ator).Property("last_update").CurrentValue);
                }
            }


            Console.ReadLine();
        }
    }
}
