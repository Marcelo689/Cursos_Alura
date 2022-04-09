using System;

namespace Parte_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta =
                new ContaCorrente("1235-7", "José da Silva", 100.0m);

            Console.WriteLine(conta);
            Console.WriteLine();

            //conta.Saldo -= 20;

            Console.WriteLine(conta);
            Console.WriteLine();
            
            //conta.Saldo -= 200;

            Console.WriteLine(conta);
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public class ContaCorrente
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public override string ToString()
        {
            return $"Número C/C: {Numero}\nTitular: {Titular}\nSaldo: {Saldo:C}";
        }

        public ContaCorrente(string numero, string titular, decimal saldoInicial)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if (valor > this.Saldo) throw new ArgumentException("Saldo Insuficiente");

            Saldo -= valor;
        }
    }
}