using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoString1
{
    public class ExtratorValorArgumentoUrl
    {
        public readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorArgumentoUrl(string url)
        {
            if(string.IsNullOrEmpty(url)) throw new ArgumentNullException(nameof(url));

            URL = url.ToUpper();

            int indiceInterrogacao = URL.IndexOf("?");
            _argumentos = URL.Substring(indiceInterrogacao + 1);
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            
            int indiceEComercial = resultado.IndexOf('&');
            string saida = indiceEComercial > -1 ? resultado.Remove(indiceEComercial) : resultado;
            return saida;
        }
    }
}
