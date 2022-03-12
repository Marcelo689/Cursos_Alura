using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ListaObject<T>
    {
        private T[] _items;

        public static int ContadorClasses;

        private int _proximaPosicao;
        public T this[int indice] { get { return GetObjetoNoIndice(indice); } set { _items[indice] = value; } }
        public int Tamanho { get { return _proximaPosicao; } }
        public ListaObject(int tamanhoArray = 5)
        {
            ContadorClasses++;
            _items = new T[tamanhoArray];
            _proximaPosicao = 0;
        }

        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionar item na posição {_proximaPosicao}");
            _items[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(T item)
        {
            int indiceItem = -1;

            for (int i = indiceItem + 1; i < _proximaPosicao; i++)
            {
                if (_items[i].Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }
            _items[indiceItem] = default(T);
            _proximaPosicao--;

            for (int i = indiceItem; i <= _proximaPosicao; i++)
            {
                _items[i] = _items[i + 1];
            }

            _items[_proximaPosicao + 1] = default(T);
        }

        public T GetObjetoNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _items[indice];


        }

        public void AdicionarVarios(params T[] items)
        {
            foreach (T item in items)
            {
                Adicionar(item);
            }
        }
        public void EscreverListaNaTela()
        {

            Console.WriteLine("------------------------------------");
            for (int i = 0; i <= Tamanho; i++)
            {
                T conta = _items[i];
                if (conta == null) continue;

                // Console.WriteLine($"Conta numero {conta.Agencia} {conta.Numero}");
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
            T[] novoArray = new T[novoTamanho];
            Console.WriteLine("Aumentando capacidade da lista!");

            for (int indice = 0; indice < _items.Length; indice++)
            {
                novoArray[indice] = _items[indice];
            }

            _items = novoArray;
        }
    }
}
