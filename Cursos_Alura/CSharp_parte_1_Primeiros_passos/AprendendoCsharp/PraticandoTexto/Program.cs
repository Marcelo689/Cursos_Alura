using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char varChar = 'a';
            Console.WriteLine(varChar);

            Console.ReadLine();

            char valor = (char)65;

            Console.WriteLine(valor);

            valor = (char)(valor + 1);
            Console.WriteLine(valor);

            string palavra = "Marcelo";
            Console.WriteLine(palavra);

            palavra = palavra + 2020;

            Console.WriteLine(palavra);


        }
    }
}
