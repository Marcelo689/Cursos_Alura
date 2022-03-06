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
        private int _agencia;
        private double _saldo;

        public ContaCorrente(int agencia, int numero)
        {
            ContaCorrente.TotalDeContasCriadas++;
            Agencia = agencia;
            Numero = numero;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        private Cliente Titular { get { return _titular; } set { _titular = value; } }
        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia
        {
            get { return _agencia; }
            private set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero { get; }
        public double Saldo { get { return _saldo; } set { _saldo = value; } }
    }
}
