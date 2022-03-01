﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;
            int contadorAno = 1;
            int contadorMes = 1;

            for(contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for(contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("O tempo de investimento foi " + contadorAno + " ano(s) ");
            Console.WriteLine("Ao termino do investimento você terá " + valorInvestido);

            Console.ReadLine();
        }
    }
}