using System;

namespace ByteBank.Modelos
{
    public class ListaContaCorrente
    {
        private ContaCorrente[] _items;
        private int _proximaPosicao; 
        public ListaContaCorrente(int tamanhoArray = 5)
        {
            _items = new ContaCorrente[tamanhoArray];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente conta)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionar item na posição {_proximaPosicao}");
            _items[_proximaPosicao] = conta;
            _proximaPosicao++;
        }

        public void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_items.Length >= tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _items.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];
            Console.WriteLine("Aumentando capacidade da lista!");

            for (int indice = 0; indice < _items.Length; indice++)
            {
                novoArray[indice] = _items[indice];
            }

            _items = novoArray;
        }
    }
}
