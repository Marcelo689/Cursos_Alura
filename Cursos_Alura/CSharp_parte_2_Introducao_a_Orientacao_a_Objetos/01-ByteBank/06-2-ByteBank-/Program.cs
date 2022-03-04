using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        private class ContaCorrente
        {
            private Cliente _titular;
            private int _agencia;
            private int _numero;
            private double _saldo;

            private Cliente Titular { get { return _titular; } set {_titular = value; } }
            public int Agencia { get { return _agencia; } set { _agencia = value; } }
            public int Numero { get { return _numero; } set { _numero = value; } }
            public double Saldo { get { return _saldo; } set { _saldo = value; } }
        }
        static void Main(string[] args)
        {
        }
    }

    public class Cliente
    {
        private string _cpf;

        private string _nome;
        private string _profissao;
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string CPF
        {
            get { return _cpf; } 
            set {
                _cpf = value;
            } 
        }

        public string Profissao { get { return _profissao; } set { _profissao = value; } }

    }
}
