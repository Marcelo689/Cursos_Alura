using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Booleanos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8");

            int idade = 20;
            int quantidadePessoas = 3;

            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Você tem mais que 18 anos");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
               Console.WriteLine("infelizmente voce nao pode entrar");
            }
            Console.ReadLine();
        }
    }
}
