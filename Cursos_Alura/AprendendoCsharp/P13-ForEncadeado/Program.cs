using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
    internal class Program
    {
        public static void PrintaQuadrado()
        {
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {

                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {

                    if (contadorLinha == 0 || contadorLinha == 9)
                        Console.Write("-");
                    else
                    {
                        if (contadorColuna == 0 || contadorColuna == 9)
                            Console.Write("|");
                        else
                            Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void AsteriscoLinhaIncrementaSemBreak()
        {
            Console.WriteLine("Executando projeto 13");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {

                for (int contadorColuna = 0; contadorLinha > contadorColuna; contadorColuna++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }

        public static void AsteriscoLinhaIncrementaBreak()
        {
            Console.WriteLine("Executando projeto 13");

            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {

                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;

                }
                Console.WriteLine();

            }

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            AsteriscoLinhaIncrementaBreak();
            AsteriscoLinhaIncrementaSemBreak();
            PrintaQuadrado();
        }
    }
}
