using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public string titular = "Não Mencionado";
        public int agencia = 11111;
        public int numero = 222;
        public double saldo = 1290.12;
        public void Saque(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente");
            }
            else
            {
                saldo -= valor;
            }
        }
    }
}
