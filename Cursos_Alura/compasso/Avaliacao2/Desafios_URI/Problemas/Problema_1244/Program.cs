using System;

namespace Problema_1244
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] linhas = new string[n];
            for (int i = 0; i < n; i++)
            {
                linhas[i] = Console.ReadLine();
            }

            foreach (var linha in linhas)
            {
                string linhaSaida = "";
                string maiorPalavra;
                string linhaEntrada = linha;
                while (linhaEntrada.Trim().Length >= 1)
                {
                    maiorPalavra = RetornaMaiorPalavraApenas(linhaEntrada);
                    linhaEntrada = RecortaPalavraDaString(linhaEntrada, maiorPalavra);
                    linhaSaida += maiorPalavra.Trim() + " ";
                }
                Console.WriteLine(linhaSaida.TrimEnd());
            }

            //Console.ReadKey();
        }


        static string RetornaLinhaOrdenada(string linha)
        {
            string linhaSaida = "";
            string maiorPalavra;
            while (linha.Trim().Length >= 1)
            {
                maiorPalavra = RetornaMaiorPalavraApenas(linha);
                linha = RecortaPalavraDaString(linha, maiorPalavra);
                linhaSaida += maiorPalavra.Trim() + " ";
            }
            return linhaSaida.TrimEnd();

        }

        private static string RetornaMaiorPalavraApenas(string linha)
        {
            string[] palavras = linha.Split(' ');
            string maiorPalavra = "";
            int maior = 0;


            for (int i = 0; i < palavras.Length; i++)
            {
                if (palavras[i].Length > maior)
                {
                    maior = palavras[i].Length;
                    maiorPalavra = palavras[i];
                }
            }

            return maiorPalavra;
        }

        static string RecortaPalavraDaString(string linha, string palavra)
        {
            string saida = "";
            int indice = linha.IndexOf(palavra);
            if (indice != -1)
            {
                for (int i = 0; i < linha.Length; i++)
                {
                    if ((i < indice || i > indice + palavra.Length - 1))
                        saida += linha[i];
                }

            }
            return saida.Replace("  ", " ");

        }


    }
}


//using System;
//using System.Text;

//namespace uri1234
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string entrada;
//            StringBuilder saida = new StringBuilder();
//            bool mudar;
//            while ((entrada = Console.ReadLine()) != null)
//            {
//                saida.Clear();
//                mudar = true;
//                foreach (var c in entrada)
//                {
//                    if (!c.Equals(' '))
//                    {
//                        saida.Append(mudar ? char.ToUpper(c) : char.ToLower(c));
//                        mudar = !mudar;
//                    }
//                    else
//                    {
//                        saida.Append(c);
//                    }
//                }
//                Console.WriteLine(saida);
//            }
//        }
//    }
//}