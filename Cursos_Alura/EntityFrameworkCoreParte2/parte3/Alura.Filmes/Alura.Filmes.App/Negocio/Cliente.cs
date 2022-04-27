using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Negocio
{
    public class Cliente : Pessoa
    {
        public override string ToString()
        {
            return $"Cliente ({Id}): {PrimeiroNome} {UltimoNome} - {Ativo}";
        }
    }
}
