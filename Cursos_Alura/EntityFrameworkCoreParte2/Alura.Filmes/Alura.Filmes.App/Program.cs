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
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();


                //Parte 1
                //var filme = contexto.Filmes.Include(f => f.Atores)
                //    .ThenInclude(fa => fa.Ator).
                //    First();

                //Console.WriteLine(filme);
                //Console.WriteLine("Elenco:");
                //foreach (var ator in filme.Atores)
                //{
                //    var entidade = contexto.Entry(filme);
                //    var filmId = entidade.Property("film_id").CurrentValue;
                //    var actorId = entidade.Property("actor_id").CurrentValue;
                //    var lastUpdate = entidade.Property("last_update").CurrentValue;
                //    Console.WriteLine($"{filmId} - {actorId} : {lastUpdate} ");
                //}

                //Parte 2

                //var filmes = contexto.Filmes.Include(f => f.IdiomaFalado);

                //foreach (var filme in filmes)
                //{
                //    Console.WriteLine(filme);
                //    Console.WriteLine(filme.IdiomaFalado);
                //}


            }


            using (var contexto = new AluraFilmesContexto())
            {

                contexto.LogSQLToConsole();

                var ator1 = new Ator { PrimeiroNome = "Emma", UltimoNome = "Watson" };
                var ator2 = new Ator { PrimeiroNome = "Emma", UltimoNome = "Watson" };
                contexto.Atores.AddRange(ator1, ator2);
                contexto.SaveChanges();

                var emmaWatson = contexto.Atores
                    .Where(a => a.PrimeiroNome == "Emma" && a.UltimoNome == "Watson");
                Console.WriteLine($"Total de atores encontrados: {emmaWatson.Count()}.");
            }
        }
    }
}
