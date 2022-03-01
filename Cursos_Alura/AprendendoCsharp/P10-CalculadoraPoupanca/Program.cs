using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculadoraPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eexecutando projeto 10");

            double valorInvestido = 1000;
            int contador = 1;

            while(contador <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Apos " + contador + " mês(es), você terá R$" + valorInvestido);
                contador++;
            }

            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Apos 1 mês, você terá R$" + valorInvestido);

            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Apos 2 mêses, você terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
