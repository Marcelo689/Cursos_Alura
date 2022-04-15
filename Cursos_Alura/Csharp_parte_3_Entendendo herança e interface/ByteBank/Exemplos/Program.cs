using Exemplos.Exemplos;
using System;

namespace Exemplos
{
    class Program
    {
        public abstract class Casa
        {
            public abstract void AbrirPorta();
        }
        public interface Carro
        {
            void AbrirPorta();
        }
        public class Exemplo : Casa, Carro
        {
            public override void AbrirPorta()
            {
               
            }
        }
        static void Main(string[] args)
        {
            //BaseA baseA = new BaseA();
            //baseA.numero = 100;
            //Derivada derivada = new Derivada()
            //{
            //    numero = 10,
            //};

            //Console.WriteLine(derivada.numero);
            Console.ReadLine();
        }
    }
}
