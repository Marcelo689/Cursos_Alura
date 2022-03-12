using ByteBank;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoParte7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaoNaMassa5();


            // para o codigo
            Console.ReadLine();
        }

        public static void MaoNaMassa1()
        {
            int[] idades = new int[5];
            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            Console.WriteLine(idades[1]);
            Console.WriteLine(idades[2]);
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                Console.WriteLine($"Valor no índice {indice}: {idade}");
            }

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                acumulador += idades[indice];
            }
            Console.WriteLine(acumulador);
            int media = acumulador / idades.Length;
            Console.WriteLine(media);

            //declarando e populando
            int[] idades1 = new int[] { 15, 28, 35, 50, 28 };
            
        }
        public static void MaoNaMassa2()
        {
            ListaContaCorrente lista = new ListaContaCorrente();

            lista.Adicionar(new ContaCorrente(345, 23462));
            lista.Adicionar(new ContaCorrente(363, 22451));
            lista.Adicionar(new ContaCorrente(735, 23552));
        }
        public static void MaoNaMassa3()
        {
            // Conteudo no projeto parte5 DLL referencia: ByteBank.Modelos 
        }
        public static void MaoNaMassa4()
        {
            ListaContaCorrente lista = new ListaContaCorrente();
            lista.AdicionarVarios(
            new ContaCorrente(100, 40010),
            new ContaCorrente(101, 40011),
            new ContaCorrente(102, 40012),
            new ContaCorrente(103, 40013)
            );
        }
        public static void MaoNaMassa5()
        {
            ListaObject<int>listaDeIdades = new ListaObject<int>();

            // 
            //listaDeIdades.AdicionarVarios(12, 42, 15, "ops, não devia estar aqui");
            listaDeIdades.AdicionarVarios(12, 42, 15);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine(idade);
            }

            ListaObject<int> idades = new ListaObject<int>();

            idades.AdicionarVarios(63, 15, 21, 50);
            idades.Remover(15);

            ListaObject<string> cursos = new ListaObject<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");

            ListaObject<ContaCorrente> contas = new ListaObject<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));
        }
    }
}
