using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;


namespace ByteBank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);

            FuncionarioAutenticavel funcionario = null;
            funcionario.Autenticar("sdkkasdk"); 
            
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
