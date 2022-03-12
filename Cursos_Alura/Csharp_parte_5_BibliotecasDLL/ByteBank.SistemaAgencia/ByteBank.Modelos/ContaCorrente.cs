using ExcecoesExemplos;
using ExcecoesExemplosParte2;
using System;

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

        public override bool Equals(object obj)
        {
            ContaCorrente contaRecebida = obj as ContaCorrente;
            if (contaRecebida == null) return false;
            return contaRecebida.Numero == this.Numero && contaRecebida.Agencia == this.Agencia;
        }
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade Saldo.
        /// </summary>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que o Saldo. </param>
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
        /// <summary>
        ///  Define um objeto que tem metodos de acoes utilizadas em bancos
        /// </summary>
        /// <param name="agencia"><see cref="Agencia"/> Deve possuir valor maior que zero</param>
        /// <param name="numero"><see cref="Numero"/> Deve possuir valor maior que zero</param>
        /// <exception cref="ArgumentException"></exception>
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

        public override string ToString()
        {
            return $"Número {Numero}, Agência {Agencia}, Saldo {Saldo}";
        }

        
        private Cliente Titular { get { return _titular; } set { _titular = value; } }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get { return _saldo; } set { _saldo = value; } }


    }
}
