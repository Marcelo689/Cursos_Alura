using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class Cliente
    {
        private string _cpf;

        private string _nome;
        private string _profissao;
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string CPF
        {
            get { return _cpf; }
            set
            {
                _cpf = value;
            }
        }
        public override bool Equals(object obj)
        {
            Cliente outroCliente = obj as Cliente;

            if (outroCliente == null) return false;

            return CPF == outroCliente.CPF
                            &&
                   Nome == outroCliente.Nome
                            &&
                   Profissao == outroCliente.Profissao;
        }
        public string Profissao { get { return _profissao; } set { _profissao = value; } }
    }
}
