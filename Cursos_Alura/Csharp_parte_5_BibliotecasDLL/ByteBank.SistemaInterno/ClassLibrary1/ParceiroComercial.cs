using ByteBank.Modelos;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        public string Senha { get; set; }

        //public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        //{

        //}
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(senha, Senha);
        }
    }
}
