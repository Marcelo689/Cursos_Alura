﻿using ExcecoesExemplosParte2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesExemplos
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque no valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        
        public SaldoInsuficienteException(string mensagem, Exception excecao) : base(mensagem, excecao)
        {

        }
        public SaldoInsuficienteException()
        {
            
        }
    }
}
