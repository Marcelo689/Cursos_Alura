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

                contexto.LogSQLToConsole();

                var filme = new Filme();
                filme.Titulo = "Cassino Royale";
                filme.Duracao = 120;
                filme.AnoLancamento = "2000";
                filme.Classificacao = ClassificacaoIndicativa.MaioresQue14.ParaString();
                filme.IdiomaFalado = contexto.Idiomas.First();
                contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                contexto.Filmes.Add(filme);
                contexto.SaveChanges();

                //var filme = new Filme();
                //filme.Titulo = "Senhor dos Anéis";
                //filme.Duracao = 120;
                //filme.AnoLancamento = "2000";
                //filme.Classificacao = ClassificacaoIndicativa.Livre;
                //filme.IdiomaFalado = contexto.Idiomas.First();
                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                //contexto.Filmes.Add(filme);
                //contexto.SaveChanges();
            }
        }
    }
}
