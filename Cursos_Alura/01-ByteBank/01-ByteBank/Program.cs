using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaMarcelo = new ContaCorrente()
            {
                titular = "Marcelo",
                agencia = 999,
                numero = 898888,
                saldo = 100.60
            };

            ContaCorrente contaJaeger = new ContaCorrente()
            {
                titular = "Jaeger",
                agencia = 999,
                numero = 898888,
                saldo = 100.60
            };

            Console.WriteLine(contaMarcelo.titular +  "\n" + "Saldo = " + contaMarcelo.saldo);

            Console.ReadLine();           
        }
    }
}
