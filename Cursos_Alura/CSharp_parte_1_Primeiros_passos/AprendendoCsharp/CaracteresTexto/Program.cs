using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracteresTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5");
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia";
            string cursosProgramacao = " - .NET" + " - Java" + " - Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);
            Console.ReadLine();
        }
    }
}
