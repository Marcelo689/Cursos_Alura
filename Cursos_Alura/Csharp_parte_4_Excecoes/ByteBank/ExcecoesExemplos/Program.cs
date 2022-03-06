using ByteBank;
using System;

namespace ExcecoesExemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(456, 4578420);
                ContaCorrente conta2 = new ContaCorrente(485, 456478);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                //conta.Transferir(60, conta2);
                conta.Transferir(-10, conta2);
                Console.WriteLine(conta2.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine("Ëxceção de Saldo de saque maior que o contido na conta");
            }

            //Metodo();

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();

        }

        public static int Dividir(int numero, int divisor)
        {
            //ContaCorrente conta = null;
            //Console.WriteLine(conta.Saldo);
            try
            {
                return numero / divisor;
            }
            catch (Exception excecao)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor + "\n " + excecao.Message);
                throw;
            }
        }

        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
