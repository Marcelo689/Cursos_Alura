using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {       //Teste com a cadeia de chamada:
            //Metodo -> TestaDivisao -> Dividir
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (Exception excecao)
            {
                Console.WriteLine("Exceção Tradada 1");
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
            Console.ReadLine();
        }

        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
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
