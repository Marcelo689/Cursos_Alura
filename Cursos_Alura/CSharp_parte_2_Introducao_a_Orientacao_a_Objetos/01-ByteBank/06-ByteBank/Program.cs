using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;
    }

    
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double _saldo = 100;

        public double Saldo
        {
            get { return _saldo; }
            set { this._saldo = value; }
        }
        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

        public double ObterSaldo()
        {
            return this._saldo;
        }

        public void DefinirSaldo(double saldo)
        {
            if (saldo > 0)
            {
                this._saldo = saldo;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Depositar(100);
            Cliente cliente = new Cliente();
            conta.titular = cliente;
            conta.titular.nome = "Marcelo";
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.ObterSaldo());

            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
