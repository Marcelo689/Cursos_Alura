using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            GravarUsandoEntity();
            //RecuperarProduto();
            //ExcluirProdutos();
            //RecuperarProduto();
            //AtualizarProduto();
            Console.ReadLine();
        }

        private static void AtualizarProduto()
        {
            GravarUsandoEntity();
            RecuperarProdutos();
            
            //Produto p = new Produto();
            //p.Nome = "Harry Potter e a Ordem da Fênix";
            //p.Categoria = "Livros";
            //p.Preco = 19.89;
            
            using (var contexto = new ProdutoDaoEntity())
            {
                Produto produto = contexto.Produtos().First();
                produto.Nome = "Maça";
                contexto.Atualizar(produto);
            }

            RecuperarProdutos();
        }

        private static void ExcluirProdutos()
        {
            using (var repo = new ProdutoDaoEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                foreach (Produto produto in produtos)
                {
                    repo.Remover(produto);
                }
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new ProdutoDaoEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                Console.WriteLine("Foram encontrados {0} produto(s).", repo.Produtos().Count());
                foreach (var produto in produtos)
                {
                    Console.WriteLine(produto.Nome);
                }
            }
        }

        private static void GravarUsandoAdoNet()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.Preco = 19.89;

            using (var contexto = new ProdutoDaoEntity())
            {
                contexto.Adicionar(p);
            }
        }

    }
}
