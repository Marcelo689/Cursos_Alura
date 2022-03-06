using ByteBank;
using ExcecoesExemplosParte2;
using System;
using System.Diagnostics;

namespace ExcecoesExemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                // conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                if (e.InnerException != null)
                {
                    Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");
                    Console.WriteLine(e.InnerException.Message);
                    Console.WriteLine(e.InnerException.StackTrace);
                }
            }

            Console.ReadLine();

        }

    }
}
