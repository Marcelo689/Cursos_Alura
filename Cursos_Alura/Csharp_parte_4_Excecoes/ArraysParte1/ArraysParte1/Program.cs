using ByteBank;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestandoArray1();
            //TestaArrayContaCorrente();
            UsandoAdicionarLista();
            
            
            

            Console.ReadLine();
            
        }
        public static void UsandoAdicionarLista()
        {
            ListaContaCorrente lista = new ListaContaCorrente();
            ContaCorrente contaDoMarcelo = new ContaCorrente(546, 5674976);
            lista.Adicionar(contaDoMarcelo);
            Console.WriteLine(lista);

            Cliente cli1 = new Cliente();
            cli1.Nome = "Tainá";

            Cliente cli2 = new Cliente();
            cli2.Nome = "Carlos";
            lista.VerificarCapacidade(10);
            object[] referencias = new object[5];
            //Console.WriteLine(referencias[1].Nome);
            // erro pois classe generica de objetos nao possui propriedade nome.

            referencias[0] = cli1;
            referencias[1] = cli2;
            Console.ReadLine();
        }

        public static void TestaArrayContaCorrente()
        {
            int[] exemplo = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(exemplo[0]);
            ContaCorrente[] contas = new ContaCorrente[3]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668),
                new ContaCorrente(874, 7781438),
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

            Console.ReadLine();
        }
        public static void TestandoArray1()
        {
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            int media = 0;
            int acumulador = 0;
            for (int indice = 0 ; indice <= 4; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }
            media = acumulador / idades.Length;
            int idadeNoIndice4 = idades[4];
            Console.WriteLine("Quantidade acumulada = " + acumulador);
            Console.WriteLine("Media " + media);
            Console.WriteLine(idadeNoIndice4);

            int[] nums = idades;

            Console.WriteLine(nums[0]);
            Console.ReadLine();
        }

    }
}
