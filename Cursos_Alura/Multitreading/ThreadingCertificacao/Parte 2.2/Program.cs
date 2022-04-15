using System;
using System.Threading;

namespace Parte_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirThread(Thread.CurrentThread);
        }

        static void ExibirThread(Thread t)
        {
            Console.WriteLine("");
            Console.WriteLine("Nome: {0}", t.Name);
            Console.WriteLine("Cultura: {0}", t.CurrentCulture);
            Console.WriteLine("Prioridade: {0}", t.Priority);
            Console.WriteLine("Contexto: {0}", t.ExecutionContext);
            Console.WriteLine("Está em background? {0}", t.IsBackground);
            Console.WriteLine("Está na pool de threads? {0}", t.IsThreadPoolThread);
            Console.WriteLine();

        }
    }
}
