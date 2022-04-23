using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var contexto = new LojaContext())
            {
                var cliente = contexto.Clientes.Include(c => c.EnderecoDeEntrega).FirstOrDefault();

                Console.WriteLine(cliente.Nome);

                var produto = contexto.Produtos.Include(p => p.Compras).Where(p => p.Id == 2) as IEnumerable<Produto>;

                contexto.Entry(produto.First()).Collection(p => p.Compras).Query().Where(p => p.Preco > 10).Load();
                foreach (var nomeProduto in produto)
                {
                    Console.WriteLine(nomeProduto.Nome);
                }
            }
            Console.ReadLine();
        }

        private static void ExibeProdutosNaPromocao()
        {
            using (var contexto2 = new LojaContext())
            {
                //var promocao = contexto2.Promocoes.FirstOrDefault();
                //Console.WriteLine("\n Mostrando os produtos na promoção");
                //foreach (var item in promocao.Produtos)
                //{
                //    Console.WriteLine(item.Produto);
                //}

                var promocao = contexto2.Promocoes.Include(p => p.Produtos).ThenInclude(pp => pp.Produto).FirstOrDefault();
            }
        }

        private static void IncluirPromocao()
        {
            using (var contexto = new LojaContext())
            {
                var promocao = new Promocao();
                promocao.Descricao = "Queima total Janeiro";
                promocao.DataInicio = new DateTime(2022, 10, 10);
                promocao.DataTermino = new DateTime(2024, 10, 10);

                var produtos = contexto.Produtos.Where(p => p.Categoria == "Bebidas").ToList();

                foreach (var produto in produtos)
                {
                    promocao.IncluirProduto(produto);
                }

                contexto.Promocoes.Add(promocao);
                ExibeEntries(contexto.ChangeTracker.Entries());
                contexto.SaveChanges();
            }
        }

        static void ExibeEntries(IEnumerable lista)
        {
            foreach (var item in lista)     
            {
                Console.WriteLine(item.ToString());
            }
        }
        private static void UmParaUm()
        {
            var fulano = new Cliente();
            fulano.Nome = "Fulaninho de Tal";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua dos Inválidos",
                Complemento = "sobrado",
                Bairro = "Centro",
                Cidade = "Cidade"
            };

            using (var contexto = new LojaContext())
            {
                //var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();  
                //var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                //loggerFactory.AddProvider(SqlLoggerProvider.Create());

                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }
        }

        private static void MuitosParaMuitos()
        {
            //var paoFrances = new Produto();
            //paoFrances.Nome = "Pão Francês";
            //paoFrances.PrecoUnitario = 10.00;
            //paoFrances.Unidade = "Unidade";
            //paoFrances.Categoria = "Categoria";

            //var compra = new Compra();
            //compra.Quantidade = 6;
            //compra.Produto = paoFrances;
            //compra.Preco = paoFrances.PrecoUnitario * compra.Quantidade;

            //using (var contexto = new LojaContext())
            //{
            //    //var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();  
            //    //var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            //    //loggerFactory.AddProvider(SqlLoggerProvider.Create());

            //    contexto.Compras.Add(compra);
            //    foreach (var item in contexto.ChangeTracker.Entries())
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    contexto.SaveChanges();
            //}

            // Parte 2

            var p1 = new Produto()
            {
                Nome = "Suco de Laranja",
                Categoria = "Bebidas",
                PrecoUnitario = 8.79
            };
            var p2 = new Produto()
            {
                Nome = "Café",
                Categoria = "Bebidas",
                PrecoUnitario = 8.79,
                Unidade = "Gramas"
            };
            var p3 = new Produto()
            {
                Nome = "Macarrão",
                Categoria = "Comidas",
                PrecoUnitario = 8.79
            };


            var promocaoPascoa = new Promocao();
            promocaoPascoa.Descricao = "Pascoa Feliz";
            promocaoPascoa.DataInicio = DateTime.Now;
            promocaoPascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoPascoa.IncluirProduto(p1);
            promocaoPascoa.IncluirProduto(p2);
            promocaoPascoa.IncluirProduto(p3);

            using (var contexto = new LojaContext())
            {
                //var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();  
                //var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                //loggerFactory.AddProvider(SqlLoggerProvider.Create());


                var promocao = contexto.Promocoes.Find(3);
                contexto.Promocoes.Remove(promocao);

                //contexto.Promocoes.Add(promocaoPascoa);
                foreach (var item in contexto.ChangeTracker.Entries())
                {
                    Console.WriteLine(item.ToString());
                }
                contexto.SaveChanges();
            }
            Console.ReadLine();

        }

    }
}
