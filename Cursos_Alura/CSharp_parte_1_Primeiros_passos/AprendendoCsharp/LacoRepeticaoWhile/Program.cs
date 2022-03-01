using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoRepeticaoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador = contador + 1;
            }
            Console.ReadLine();
        }
    }
}
