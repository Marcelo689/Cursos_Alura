using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;
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

                //var filme = new Filme();
                //filme.Titulo = "Cassino Royale";
                //filme.Duracao = 120;
                //filme.AnoLancamento = "2000";
                //filme.Classificacao = ClassificacaoIndicativa.MaioresQue14;
                //filme.IdiomaFalado = contexto.Idiomas.First();
                //contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                //contexto.Filmes.Add(filme);
                //contexto.SaveChanges();

                //var filmeInserido = contexto.Filmes.First(f => f.Titulo == "Cassino Royale");
                //Console.WriteLine(filmeInserido);
                //Console.WriteLine(filmeInserido.TextoClassificacao);


                // Parte 2
                //foreach (var cliente in contexto.Clientes)
                //{
                //    Console.WriteLine(cliente);
                //}

                //foreach (var funcionario in contexto.Funcionarios)
                //{
                //    Console.WriteLine(funcionario);
                //}



                //CincoPrimeiros();


                //SqlBruto();


                var categ = "Action"; //36

                var paramCateg = new SqlParameter("category_name", categ);

                var paramTotal = new SqlParameter
                {
                    ParameterName = "@total_actors",
                    Size = 4,
                    Direction = System.Data.ParameterDirection.Output
                };

                contexto.Database
                    .ExecuteSqlCommand("total_actors_from_given_category @categoria, @total OUT", paramCateg, paramTotal);

                System.Console.WriteLine($"O total de atores na categoria {categ} é de .");

              
            }

            
        }
        static void CincoPrimeiros()
        {
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();
                // Pegando os 5 primeiros
                var atoresMaisAtuantes = contexto.Atores
                    .Include(a => a.Filmografia)
                    .OrderByDescending(a => a.Filmografia.Count)
                    .Take(5);
                foreach (var ator in atoresMaisAtuantes)
                {
                    System.Console.WriteLine($"O ator {ator.PrimeiroNome + ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes");
                }



            }
        }
        static void SqlBruto()
        {
            using (var contexto = new AluraFilmesContexto())
            {
                contexto.LogSQLToConsole();

                var sql = @"select a.*
                from actor a
                  inner join
                (select top 5 a.actor_id
                from actor a
                  inner join film_actor fa on fa.actor_id = a.actor_id
                group by a.actor_id
                order by total desc) filmes on filmes.actor_id = a.actor_id";

                var atoresMaisAtuantes = contexto.Atores
                    .FromSql(sql)
                    .Include(a => a.Filmografia);

                foreach (var ator in atoresMaisAtuantes)
                {
                    System.Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes.");
                }
            }
        }
    }
}
