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
            contaMarcelo.saldo = 200; 
            Console.WriteLine(contaMarcelo.titular +  "\n" + "Saldo = " + contaMarcelo.saldo);

            contaMarcelo.saldo += 100;
            Console.WriteLine(contaMarcelo.saldo);

            contaJaeger.saldo = 50;
            Console.WriteLine(contaJaeger.saldo);

            contaMarcelo.Saque(100);
            Console.WriteLine(contaMarcelo.saldo);
            Console.ReadLine();           
        }
    }
}
