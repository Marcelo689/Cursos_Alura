using System;
using System.Threading;
using System.Threading.Tasks;

namespace Parte_1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Task tarefaMae = Task.Factory.StartNew(() => {
                Console.WriteLine("Tarefa-mãe iniciou");
                for (int i = 0; i < 10; i++)
                {
                    int tarefaId = i;
                    Task tarefaFilha = Task.Factory.StartNew((id) => ExecutarFilha(id), tarefaId, TaskCreationOptions.AttachedToParent);
                }
            });

            tarefaMae.Wait();
            Console.WriteLine("Tarefa-mãe terminou.");


        }

        private static void ExecutarFilha(object i)
        {
            Console.WriteLine("Tarefa-filha {0} iniciou.", i);
            Thread.Sleep(1000);
            Console.WriteLine("Tarefa-filha {0} terminou.", i);
        }
    }
}
