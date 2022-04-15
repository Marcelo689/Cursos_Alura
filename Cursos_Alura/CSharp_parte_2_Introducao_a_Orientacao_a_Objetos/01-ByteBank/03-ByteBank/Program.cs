using _01_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            ContaCorrente conta2 = new ContaCorrente();

            conta.saldo += 230;
            bool retornoSaque = conta.Saque(130);

            Console.WriteLine("Retorno do Saque = " + retornoSaque);
            Console.WriteLine(conta.saldo);

            conta.Depositar(200);
            Console.WriteLine(conta.saldo);

            Console.WriteLine("Saldo conta 2   = " + conta2.saldo);
            bool sucesso = conta.Transferir(140, conta2);
            Console.WriteLine(conta2.saldo);
            Console.WriteLine(sucesso ? "Transferencia efetuada com sucesso " : "Falha na tranferencia");
            Console.ReadLine();
        }
    }
}
