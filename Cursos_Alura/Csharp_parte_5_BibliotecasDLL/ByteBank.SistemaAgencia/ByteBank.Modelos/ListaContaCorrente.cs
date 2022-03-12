using System;

namespace ByteBank.Modelos
{
    public class ListaContaCorrente
    {
        private ContaCorrente[] _items;

        private int _proximaPosicao; 
        public ContaCorrente this [int indice] { get { return GetContaCorrenteNoIndice(indice); } set { _items[indice] = value; } }
        public int Tamanho { get { return _proximaPosicao; } }
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

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for (int i = indiceItem + 1; i < _proximaPosicao; i++)
            {
                if(_items[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            _items[indiceItem] = null;
            _proximaPosicao--;

            for (int i = indiceItem; i <= _proximaPosicao; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[_proximaPosicao + 1] = null;
        }

        public ContaCorrente GetContaCorrenteNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _items[indice];


        }

        public void AdicionarVarios(params ContaCorrente[] contas)
        {
            foreach(ContaCorrente conta in contas)
            {
                Adicionar(conta);
            }
        }
        public void EscreverListaNaTela()
        {

            Console.WriteLine("------------------------------------");
            for (int i = 0; i <= Tamanho; i++)
            {
                ContaCorrente conta = _items[i];
                if (conta == null) continue; 

                Console.WriteLine($"Conta numero {conta.Agencia} {conta.Numero}");
            }

            Console.WriteLine("------------------------------------");
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
