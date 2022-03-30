using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedagio pedagio = new Pedagio();
            pedagio.Enfileirar("Fusca");
            pedagio.Enfileirar("Kombi");
            pedagio.Enfileirar("Guincho");
            pedagio.Enfileirar("Picape");
            pedagio.Imprimir();
            
            pedagio.Desinfileirar();
            pedagio.Desinfileirar();
            pedagio.Desinfileirar();
            pedagio.Desinfileirar();


            pedagio.Imprimir();
        }

        class Pedagio
        {
            Queue<string> fila = new Queue<string>();

            public void  Enfileirar(string veiculo)
            {
                Console.WriteLine("-------------------------");
                fila.Enqueue(veiculo);
                Console.WriteLine("Veiculo " + veiculo + " entrou na fila!");
                Console.WriteLine("-------------------------");

            }

            public void Imprimir()
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Veiculos na fila");

                foreach (var veiculoV in fila)
                {
                    Console.WriteLine(veiculoV);
                }

                Console.WriteLine("-------------------------");

            }
            public void Desinfileirar()
            {
                if (fila.Count <= 0) return;
                var proximo = fila.Peek();
                Console.WriteLine("Proximo na fila "+ proximo);
                Console.WriteLine("-------------------------");

                var veiculo = fila.Dequeue();
                Console.WriteLine("Saiu da fila " + veiculo);
                Console.WriteLine("-------------------------");

                fila.TryPeek( out proximo);
                Console.WriteLine("Proximo na fila " + proximo);
                Console.WriteLine("-------------------------");

            }
        }
    }
}
