using ExcecoesExemplos;
using ExcecoesExemplosParte2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        private Cliente _titular;
        public int TotalSaquesFalhos { get; private set; }
        public int TotalTransferenciasFalhas { get; private set; }
        public void Depositar(double valor)
        {
            if (valor > 0) Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0) throw new ArgumentException("Valor invalido ", nameof(valor));
            if (valor <= Saldo) Saldo -= valor;
            else // caso valor maior que saldo
            {
                TotalSaquesFalhos++;
                throw new SaldoInsuficienteException(Saldo, valor);
                
            }
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.");
            }

            //Sacar(valor);

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                TotalTransferenciasFalhas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
                //throw new Exception("Operação não realizada.", ex);
            }

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
