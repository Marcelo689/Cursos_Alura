using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
    public interface IProdutoDao
    {
        void Adicionar(Produto p);
        void Atualizar(Produto p);
        void Remover(Produto p);
        IList<Produto> Produtos();
    }
}
