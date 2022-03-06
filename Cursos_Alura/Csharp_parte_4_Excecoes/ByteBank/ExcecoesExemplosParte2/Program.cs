using ByteBank;
using System;
using System.Diagnostics;

namespace ExcecoesExemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(456, 4578420);
            //    ContaCorrente conta2 = new ContaCorrente(485, 456478);
            //    conta2.Depositar(100);
            //    conta2.Transferir(10000, conta);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Argumento com problema: " + ex.ParamName);
            //    Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");

            //    Console.WriteLine(ex.Message);
            //}
            //catch (SaldoInsuficienteException ex)
            //{
            //    Console.WriteLine(ex.Saldo);
            //    Console.WriteLine(ex.ValorSaque);

            //    Console.WriteLine(ex.StackTrace);

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    Metodo();
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                conta1.Sacar(200);

                //conta1.Transferir(10000, conta2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                if(e.InnerException != null)
                {
                    Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");
                    Console.WriteLine(e.InnerException.Message);
                    Console.WriteLine(e.InnerException.StackTrace);
                }
            }

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
                throw new DivideByZeroException("Tentativa de divisão por zero");
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
