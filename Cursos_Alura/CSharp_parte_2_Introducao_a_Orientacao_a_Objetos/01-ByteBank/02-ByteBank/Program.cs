using _01_ByteBank;
using System;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Marcelo";
            //conta.saldo = 
            Console.WriteLine(conta.titular);
            Console.WriteLine(conta.saldo);
            Console.ReadLine();
        }
    }
}
