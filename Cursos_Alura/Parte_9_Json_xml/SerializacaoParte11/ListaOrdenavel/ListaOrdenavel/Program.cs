using System;
using System.Collections.Generic;

namespace ListaOrdenavel
{
    internal class Program
    {

        public static IDictionary<string, Aluno> alunos
           = new Dictionary<string, Aluno>();
        static void Main(string[] args)
        {
            ListaDicionario();
            ListaOrdenada();
        }
        static void ListaDicionario()
        {
            Console.WriteLine("-----------Lista de dicionario--------------");
            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5617));
            alunos.Add("RN", new Aluno("Rafael", 17645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            Imprimir();
            //vamos remover: AL
            alunos.Remove("AL");
            //vamos.adicionar: MO
            alunos.Add("MO", new Aluno("Marcelo", 12345));
            Imprimir();
        }
        static void ListaOrdenada()
        {
            //apresentando nova coleção...SortedList
            Console.WriteLine("-----------apresentando nova coleção...SortedList--------------");
            IDictionary<string, Aluno> sorted
                    = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5617));
            sorted.Add("RN", new Aluno("Rafael", 17645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine();
            foreach (var item in sorted)
            {
                Console.WriteLine(item.Value.Nome);
            }
        }
        static void Imprimir()
        {
            //imprimindo...
            Console.WriteLine("------------------------");
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno.Value.Nome);
            }

            Console.WriteLine("------------------------");
        }
    }
}
