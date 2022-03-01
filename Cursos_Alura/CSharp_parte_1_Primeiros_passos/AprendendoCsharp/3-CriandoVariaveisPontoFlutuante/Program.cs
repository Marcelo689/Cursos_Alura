using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 criando variaveis ponto flutuante");

            double salario = 1200.70;

            Console.WriteLine(salario);


            double idade = 15 / 2.0;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine(" 5 / 3 = " + idade);

            idade = 5 / 3.0;
            Console.WriteLine(" 5 / 3.0 = " + idade);
            Console.WriteLine("Pressione enter para encerrar o programa");
            Console.ReadLine();
        }
    }
}
