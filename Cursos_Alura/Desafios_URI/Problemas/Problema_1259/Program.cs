using System;
using System.Collections.Generic;
using System.Linq;

namespace Problema_1259
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLinhas = Int32.Parse(Console.ReadLine());
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            int conteudo = 0;
            for (int i=0; i < nLinhas; i++)
            {

                conteudo = Int32.Parse(Console.ReadLine());

                if(conteudo % 2 == 0)
                { /// par
                    pares.Add(conteudo);
                }
                else
                {//impar
                    impares.Add(conteudo);
                }
            }
            pares = pares.OrderBy(x => x).ToList();
            impares = impares.OrderByDescending(x => x).ToList();

            foreach(var par in pares)
            {
                Console.WriteLine(par);
            }
            foreach(var impar in impares)
            {
                Console.WriteLine(impar);
            }

        }
    }
}
