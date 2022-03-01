using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // int é uma variavel 32 bits
            int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            // long é uma variavel de 64 bits
            long idade = 13000000000000;

            // short é uma variavel 16 bits
            short quantidadeProdutos = 150;

            float altura = 1.80f;
            Console.WriteLine(altura);
            Console.ReadLine();
        }
    }
}
