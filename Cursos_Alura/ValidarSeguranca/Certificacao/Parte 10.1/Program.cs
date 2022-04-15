using System;

namespace Parte_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirHash("olá, mundo!");
            ExibirHash("mundo, olá!");

            ExibirHash("alura cursos online");
            ExibirHash("cursos online alura");

            Console.ReadLine();
        }

        static void ExibirHash(string mensagem)
        {
            //TAREFA: CALCULAR O HASHCODE PARA A MENSAGEM
            Console.WriteLine("Hash para {0} é: {1:X}", mensagem, mensagem.GetHashCode());
        }

    }
}
