using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgorExemploAtividade
{
    public class Classes
    {
        public interface IAutenticavel
        {
            bool Autenticar(string senha);
        }

        public interface IBonificavel
        {
            double GetBonificacao();
        }

        public abstract class PrestadorDeServicos : IBonificavel
        {
            public string CNPJ { get; set; }

            public double GetBonificacao()
            {
                return 2000.0;
            }
        }

        public class Arquiteto : PrestadorDeServicos, IAutenticavel
        {
            public string Senha { get; set; }

            public bool Autenticar(string senha)
            {
                return Senha == senha;
            }
        }
    }
}
