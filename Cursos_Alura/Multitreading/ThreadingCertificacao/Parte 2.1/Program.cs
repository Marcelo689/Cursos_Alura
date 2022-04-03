using System;
using System.Threading;

namespace Parte_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirThread(Thread.CurrentThread);

            Thread thread1 = new Thread(Executar);
            thread1.Name = "Thread 1";
            thread1.Start();
            thread1.Join();
            
            Thread thread2 = new Thread(() => Executar());

            thread2.Name = "Thread 2";
            thread2.Start();
            thread2.Join();

            ParameterizedThreadStart ps = new ParameterizedThreadStart((p) => Executar());

            Thread thread3 = new Thread((ps) => Executar());
            thread3.Name = "Thread 3";
            thread3.Start(123);
            thread3.Join();
            // 4 Interrompendo o relogio

            bool relogioFuncionando = true;
            Thread thread4 = new Thread(() => {
                ExibirThread(Thread.CurrentThread);
                while (relogioFuncionando)
                {
                    Console.WriteLine("tic");
                    Thread.Sleep(1000);
                    Console.WriteLine("tac");
                    Thread.Sleep(1000);
                }
            });
            thread4.Name = "Thread 4";
            thread4.Start();
            Console.WriteLine("Tecle algo para interromper.");
            Console.ReadKey();
            relogioFuncionando = false;
            thread4.Join();
            // 5 Sincronizando uma thread


            // 7 usando thread pool

            for (int i = 0; i < 50; i++)
            {
                int estadoI = i;
                ThreadPool.QueueUserWorkItem( (estado) => { ExecutarComParametro(estadoI); });
            }

            Console.ReadLine(); 
        }

        static void ExecutarComParametro(object param)
        {
            ExibirThread(Thread.CurrentThread);
            Console.WriteLine("Início da execução: {0}", param);
            Thread.Sleep(1000);
            Console.WriteLine("Fim da execução: {0}", param);
        }

        private static void Executar()
        {
            Console.WriteLine("Inicio da execucão");
            Thread.Sleep(1000);
            Console.WriteLine("Fim da execucão");

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
