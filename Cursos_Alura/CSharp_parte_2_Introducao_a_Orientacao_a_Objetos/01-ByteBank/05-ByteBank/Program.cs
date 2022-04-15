using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente()
            {
                nome = "Gabriela",
                cpf =  "1234555555",
                profissao = "Desenvolverdor C#"
            };

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numero = 5634527;

            //gabriela.nome = "Maria";
            Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            ContaCorrente contaMarcelo = new ContaCorrente();
            contaMarcelo.titular = new Cliente();
            contaMarcelo.titular.nome = "Marcelo";
            contaMarcelo.saldo = 500;
            contaMarcelo.agencia = 444444;
            contaMarcelo.numero = 123233;

            ContaCorrente contaNula = new ContaCorrente();
            contaNula.titular = null;

            //Console.WriteLine(contaNula.titular.nome);

            Console.ReadLine();
        }
    }
}
