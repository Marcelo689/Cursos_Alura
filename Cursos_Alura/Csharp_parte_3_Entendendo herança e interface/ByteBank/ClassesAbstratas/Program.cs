using ByteBank;
using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadoBonificacao gerenciador = new GerenciadoBonificacao();

            Funcionario pedro = new Designer("111122223356");
            pedro.Nome = "Pedro";

            //Funcionario roberta = new Diretor("999449494949");
            //roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("34392341992194");
            igor.Nome = "Igor";

            Funcionario maria = new Gerente("99435929825434");
            maria.Nome = "Maria";

            Funcionario guilherme = new Desenvolvedor("93289452389528");
            guilherme.Nome = "Guilherme";

            gerenciador.Registrar(pedro);
            //gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(maria); 
            gerenciador.Registrar(guilherme);

            Console.WriteLine("Total de fucionarios = " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine(gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
