using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_DeclarandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando programa e adicionando variaveis");

            int idade = 32;

            Console.WriteLine( idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);
            
            idade = (10 + 5) * 2;
            Console.WriteLine(idade);

            Console.WriteLine(idade + 3 * 2);
            Console.WriteLine("Pressione enter para sair do programa!");
            Console.ReadLine();
        }
    }
}
