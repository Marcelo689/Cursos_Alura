using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTabuada
{
    internal class Program
    {
        public static void Tabuada()
        {
            for (int multiplicador = 0; multiplicador < 10; multiplicador++)
            {
                for (int numero = 1; numero < 10; numero++)
                {
                    Console.WriteLine(numero + " X " + multiplicador + " = " + multiplicador * numero);
                }
            }
        }

        static void Main(string[] args)
        {
            Tabuada();
            Multiplos3();
            Console.ReadLine();
        }


        public static void Multiplos3()
        {
            for (int multiplicador = 0; multiplicador < 10; multiplicador++)
            {
                for (int numero = 1; numero < 100; numero += 2)
                {
                    Console.WriteLine(multiplicador + " X " + numero + " = " + multiplicador * numero);
                }
            }

            Console.ReadLine();
        }
    }
}
