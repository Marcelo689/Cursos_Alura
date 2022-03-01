using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = Int32.Parse(Console.ReadLine());
            int total = 1;
            for(int i = 1; i <= numero; i++)
            {
                total *=  i;
            }

            if (numero == 0)
                Console.WriteLine(1);
            else
                Console.WriteLine(total);
            
            Console.ReadLine();
        }
    }
}
