using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }

        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }
        public Funcionario()
        {
            TotalDeFuncionarios++;
            Console.WriteLine("Construtor vazio iniciado");
        }
        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
            Console.WriteLine("Criando funcionario");
            TotalDeFuncionarios++;
        }

        public Funcionario(string cpf) : this(1500, cpf)
        {
            CPF = cpf;
            TotalDeFuncionarios++;
        }
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();

    }
}
