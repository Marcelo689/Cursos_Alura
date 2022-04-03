using System;
using System.Threading;
using System.Threading.Tasks;

namespace Parte_7._2
{
    class Program
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        static void Main(string[] args)
        {
            Console.WriteLine("Tecle algo para parar o relógio");
            Task contagem = new Task(() => ContagemRegressiva(cancellationTokenSource));
            contagem.Start();
            Console.ReadKey();
            Console.WriteLine();
            cancellationTokenSource.Cancel();
            Console.WriteLine("A contagem foi completada.");
            Console.ReadLine();
        }

        static void ContagemRegressiva(CancellationTokenSource cancellationTokenSource)
        {
            int contador = 7;
            while (contador >= 0 && !cancellationTokenSource.IsCancellationRequested)
            {
                Console.WriteLine("contador: {0}", contador);
                Thread.Sleep(500);
                contador--;
            }
        }

    }
}
