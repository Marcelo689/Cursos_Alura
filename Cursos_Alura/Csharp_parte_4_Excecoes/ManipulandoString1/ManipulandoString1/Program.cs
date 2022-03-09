using System;

namespace ManipulandoString1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Parte 1
            //string url = "pagina?argumentos";

            //string retorno = url.Substring(6);

            //Console.WriteLine(retorno);

            //int indiceInterrogacao = url.IndexOf("?") + 1;
            //Console.WriteLine(indiceInterrogacao);

            ////Console.WriteLine(url);
            //string argumentos = url.Substring(indiceInterrogacao);

            //Console.WriteLine(argumentos);

            //////////  //////////////////////
            //Parte 2

            //string url = "pagina?moedaOrigem=real&moedaDestino=dolar";
            //string palavra = "moedaDestino=real";
            //int indice = palavra.IndexOf("real");
            //Console.WriteLine(indice);
            //Console.WriteLine(palavra.Substring(indice));


            //string palavra = "moedaDestino=real";
            //int indice = palavra.IndexOf("moedaDestino");
            //Console.WriteLine(indice);

            //Console.WriteLine("Tamanho da string " + palavra.Length);

            //Console.WriteLine(palavra.Substring(indice));
            //Console.ReadLine();

            //////////////////////////////////////////////////////
            /// Parte 3
            /// 
            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            //ExtratorValorArgumentoUrl extratorDeValores = new ExtratorValorArgumentoUrl(urlParametros);

            //string valor = extratorDeValores.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + valor);
            //string valor1 = extratorDeValores.GetValor("moedaOrigem");
            //Console.WriteLine("Valor de moedaDestino: " + valor1);

            //// Parte 4
            //string testeRemocao = "primeiraParte&parteParRemover";
            //int indiceEComercial = testeRemocao.IndexOf('&');
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial));
            //int indiceEComercial1 = testeRemocao.IndexOf('&');
            //Console.WriteLine(testeRemocao.Remove(indiceEComercial1, 4)); // remove 4 indices apos o indice inicial 

            // Parte 5
            //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            //ExtratorValorArgumentoUrl extratorDeValores = new ExtratorValorArgumentoUrl(urlParametros);

            //string valor = extratorDeValores.GetValor("moedaDestino");
            //Console.WriteLine("Valor de moedaDestino: " + valor);
            //string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            //Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);
            
            /// Parte 6
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorArgumentoUrl extratorDeValores = new ExtratorValorArgumentoUrl(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);
            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);
            Console.WriteLine(extratorDeValores.GetValor("valor"));

            Console.ReadLine();
        }
    }
}
