using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{

    public class ContaCorrente
    {
        private Cliente _titular;
        private int _agencia;
        private int _numero;
        private double _saldo;

        public ContaCorrente(int agencia, int numero)
        {
            ContaCorrente.TotalDeContasCriadas++;
            Agencia = agencia;
            Numero  = numero;
        }

        private Cliente Titular { get { return _titular; } set { _titular = value; } }
        public static int TotalDeContasCriadas { get; private set; }

        public int Agencia { get { return _agencia; } 
            set { 
                if(value <= 0)
                {
                    return;
                }
                _agencia = value; 
            }
        }
        public int Numero { get { return _numero; } set { _numero = value; } }
        public double Saldo { get { return _saldo; } set { _saldo = value; } }
    }





}
