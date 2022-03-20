using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;

namespace Parte_8_List_lambda_linq
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> listaAInserir, params T[] itens)
        {
            foreach (T item in itens)
            {
                listaAInserir.Add(item);
            }
        }
        public static void TesteGenerico()
        {
            List<string> nomes = new List<string>();
            nomes.AdicionarVarios("Marcelo", "Sueli");

            nomes.MostraLista();
        }
        public static void MostraLista<T>(this List<T> listaAInserir, params T[] itens)
        {
            foreach (T item in itens)
            {
                Console.WriteLine(item);
            }
        }


    }
}
