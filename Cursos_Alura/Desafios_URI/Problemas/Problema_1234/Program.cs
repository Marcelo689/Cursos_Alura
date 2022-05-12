using System;

namespace Problema_1234
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = Console.ReadLine();
            //if(texto.Length >=1 && texto.Length <= 50)
            Console.WriteLine(SentecaDancante(texto));
        }

        public static string SentecaDancante(string entrada)
        {
            string saida = "";
            bool UltimaLetraMaiuscula = true;
            for (int i = 0; i <= entrada.Length - 1; i++)
            {

                if (entrada[i] == ' ')
                {
                    saida += entrada[i];
                    continue;
                }
                if (!char.IsLetter(entrada[i]))
                    continue;
                else UltimaLetraMaiuscula = !UltimaLetraMaiuscula;

                if (UltimaLetraMaiuscula)
                    saida += entrada[i].ToString().ToLower();
                else
                    saida += entrada[i].ToString().ToUpper();
            }
            return saida;
        }

        //static string RemoveEspacos(string entrada)
        //{
        //    return entrada.Replace(" ", "");
        //}
        //static string CapturaTexto()
        //{
        //    string texto = "";
        //    string essaEntrada = "0";
        //    while (true)
        //    {
        //        int tamanhoAtual = RemoveEspacos(texto).Length;
        //         essaEntrada = Console.ReadLine();
        //        if (essaEntrada == "")
        //            return texto;
        //        if(RemoveEspacos(texto).Length + RemoveEspacos(essaEntrada).Length >= 1000 ) return texto;
        //        texto += essaEntrada;
        //        texto += "\n";
        //    }

        //}

    }
}
