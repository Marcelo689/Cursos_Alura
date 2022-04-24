using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
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

                var filmes = contexto.Filmes.Include(f => f.IdiomaFalado);

                foreach (var filme in filmes)
                {
                    Console.WriteLine(filme);
                    Console.WriteLine(filme.IdiomaFalado);
                }

            }
        }
    }
}
