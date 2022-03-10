using ByteBank;
using ByteBank.Funcionarios;
using System;
using System.Text.RegularExpressions;

namespace ManipulandoString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";

            /// Parte 1
            /// 
            //string padrao = "[0-9]{4,5}[-]?[0-9]{4}";
            //string textoDeTeste = "ajgdjgjagsygaugsa 98751-5456 aygsygsygua auyakjskjs";

            //Match resultado = Regex.Match(textoDeTeste, padrao);
            //Console.WriteLine(resultado.Value);

            // Parte 2

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta = new ContaCorrente(12321,12321);

            if (carlos_1.Equals(conta))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }

            Console.ReadLine();

        }
    }
}
