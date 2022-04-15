using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadoBonificacao gerenciador = new GerenciadoBonificacao();
            SistemaInterno sistema = new SistemaInterno();
            
            //Funcionario marcelo = new Funcionario(1500, "154698965568"); 
            //gerenciador.Registrar(marcelo); // classe abstrata
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Diretor joao = new Diretor(5000, "1112223335");
            joao.AumentarSalario();
            Desenvolvedor marcelo = new Desenvolvedor("20394299429429");
            //marcelo.Senha // não existe pois não herda classe autenticavel
            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "5555";
            sistema.Logar(parceiro, "5555");

            Console.WriteLine("Salario aumentou para " + joao.Salario);
            joao.Senha = "123";
            sistema.Logar(joao, "123");
            Console.WriteLine(joao.Salario);
            joao.AumentarSalario();
            Console.WriteLine(joao.Salario);
            gerenciador.Registrar(joao);
            Console.WriteLine(joao.GetBonificacao());
            Console.WriteLine(gerenciador.GetTotalBonificacao());

            //Console.WriteLine(marcelo.CPF);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            Console.ReadLine();
        }
    }
}
