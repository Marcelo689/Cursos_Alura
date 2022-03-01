using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtribuirVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6");

            int idade = 23;
            int idadeMarcelo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeMarcelo);
            Console.ReadLine();
        }
    }
}
