using ByteBank;
using System;
using System.Text.RegularExpressions;

namespace CursoParte6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Digite as funcoes do mao na massa com o numero que deseja
            MaoNaMassa5();


            Console.ReadLine();
        }

        public static void MaoNaMassa1()
        {
            string url = "pagina?argumentos";
            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);
        }
        public static void MaoNaMassa2()
        {
            string url = "pagina?argumentos";
            int indiceInterrogacao = url.IndexOf('?');

            string argumentos = url.Substring(indiceInterrogacao + 1);

            Console.WriteLine(argumentos);

            ExtratorUrl extrator = new ExtratorUrl(url);

            Console.WriteLine(extrator.GetValor("pagina"));
        }
        public static void MaoNaMassa3()
        {
            string url = "www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorUrl extrator = new ExtratorUrl(url);

            extrator.GetValor("moedaOrigem"); // real
            extrator.GetValor("moedaDestino"); // dolar
            extrator.GetValor("valor"); // 1500
            Console.WriteLine(extrator.GetValor("moedaOrigem"));
            Console.WriteLine(extrator.GetValor("moedaDestino"));
            Console.WriteLine(extrator.GetValor("valor"));
            
            //Console.WriteLine(valorParametro);
        }
        public static void MaoNaMassa4()
        {
            string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            string texto = "Meu número é: 2342-3453";

            Match match = Regex.Match(texto, padrao);
            Console.WriteLine(match.Value);


            string padrao1 = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            string padrao2 = "[0-9]{4}[-][0-9]{4}";
            string padrao3 = "[0-9]{4}-[0-9]{4}";
            string padrao4 = "[0-9]{4,5}-[0-9]{4}";
            string padrao5 = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao6 = "[0-9]{4,5}-?[0-9]{4}";
            match = Regex.Match(texto, padrao6);
            Console.WriteLine(match.Value);

        }

        public static void MaoNaMassa5()
        {
            ContaCorrente conta = new ContaCorrente(342, 37652);
            Console.WriteLine(conta.ToString());

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
        }
    }
}
