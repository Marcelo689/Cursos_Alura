using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
