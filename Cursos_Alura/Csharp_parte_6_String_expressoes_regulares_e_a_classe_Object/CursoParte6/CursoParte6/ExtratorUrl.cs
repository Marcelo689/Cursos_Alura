using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoParte6
{
    public class ExtratorUrl
    {
        
        public string Url { get; }
        public readonly string _argumentos;
        public ExtratorUrl(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("Argumento url não pode ser nulo ou vazio!");
            }

            Url = url;

            _argumentos = GetValor("?");
        }

        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            int indiceParametroChave = Url.IndexOf(nomeParametro + "=") + nomeParametro.Length + 1;
            string valorParametro = Url.Substring(indiceParametroChave);
            
            int indiceComercial = valorParametro.IndexOf("&");

            if (indiceComercial < 0) return valorParametro;

            valorParametro = valorParametro.Remove(indiceComercial);
            return valorParametro;
        }
    }
}
