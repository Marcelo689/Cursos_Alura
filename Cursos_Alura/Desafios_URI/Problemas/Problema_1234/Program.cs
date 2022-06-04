using System;
using System.Text;

namespace Problema_1234
{
    class Program
    {
        static void RafaelCodigo()
        {

            string entrada;
            StringBuilder saida = new StringBuilder();
            bool mudar;
            while ((entrada = Console.ReadLine()) != null)
            {
                saida.Clear();
                mudar = true;
                foreach (var c in entrada)
                {
                    if (!c.Equals(' '))
                    {
                        saida.Append(mudar ? char.ToUpper(c) : char.ToLower(c));
                        mudar = !mudar;
                    }
                    else
                    {
                        saida.Append(c);
                    }
                }
                Console.WriteLine(saida);
            }

        }



        static void Main(string[] args)
        {
            //RafaelCodigo();
            //if(texto.Length >=1 && texto.Length <= 50)
            SentecaDancante();
        }

        public static void SentecaDancante()
        {
            string entrada = "";
            StringBuilder saida = new StringBuilder();
            bool UltimaLetraMaiuscula = true;
            while ((entrada = Console.ReadLine()) != null)
            {
                saida.Clear();
                for (int i = 0; i < entrada.Length; i++)
                {

                    if (entrada[i] == ' ')
                    {
                        saida.Append(entrada[i]);
                        continue;
                    }
                    if (!char.IsLetter(entrada[i]))
                        continue;
                    else UltimaLetraMaiuscula = !UltimaLetraMaiuscula;

                    if (UltimaLetraMaiuscula)
                        saida.Append(entrada[i].ToString().ToLower());
                    else
                        saida.Append(entrada[i].ToString().ToUpper());

                }

                Console.WriteLine(saida);
            }

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
