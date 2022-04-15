using ExcecoesExemplos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        private Cliente _titular;

        public void Depositar(double valor)
        {
            if (valor > 0) Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0) throw new ArgumentException("Valor invalido ", nameof(valor));
            if (valor <= Saldo) Saldo -= valor;
            else
                throw new SaldoInsuficienteException(Saldo, valor);

        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor <= 0) throw new ArgumentException("Valor de transferencia invalido( igual ou menor que zero)", nameof(valor));
            Sacar(valor);
            contaDestino.Depositar(valor);
        }
        private double _saldo;

        public ContaCorrente(int agencia, int numero)
        {
            string nomeArgumento = string.Empty;
            if (numero <= 0)
                nomeArgumento = nameof(numero);
            else if (agencia <= 0)
                nomeArgumento = nameof(agencia);
            if (numero <= 0 || agencia <= 0)
                throw new ArgumentException("Argumento " + nomeArgumento + " precisa ser maior e diferente de zero");

            ContaCorrente.TotalDeContasCriadas++;
            Agencia = agencia;
            Numero = numero;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        private Cliente Titular { get { return _titular; } set { _titular = value; } }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get { return _saldo; } set { _saldo = value; } }


    }
}
