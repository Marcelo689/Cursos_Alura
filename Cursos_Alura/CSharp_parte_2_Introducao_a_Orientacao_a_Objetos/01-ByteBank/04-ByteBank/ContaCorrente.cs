using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    public class ContaCorrente
    {
        public string titularNome;
        public string titularCpf;
        public string titularProfissao;

        public string titular;
        public int agencia;
        public int numero;
        public double saldo = 100;
        public bool Saque(double valor)
        {
            if (valor > this.saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente");
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaReceber)
        {
            if(valor <= this.saldo)
            {
                this.saldo -= valor;
                contaReceber.saldo += valor;
                return true;
            }
            else
            {
                Console.WriteLine("Valor maior que saldo");
                return false;
            }

        }
    }
}
