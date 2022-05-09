using System;

class URI
{

    static void Main(string[] args)
    {
        //Console.ReadKey();
        string texto = CapturaTexto();
        Console.WriteLine(SentecaDancante(texto));
        Console.ReadKey();
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
            else UltimaLetraMaiuscula = !UltimaLetraMaiuscula;

            if (UltimaLetraMaiuscula)
                saida += entrada[i].ToString().ToLower();
            else
                saida += entrada[i].ToString().ToUpper();
        }
        if (saida.Length == 0) return "";
        return saida;
    }

    static string CapturaTexto()
    {
        string texto = "";
        while(texto.Trim().Length < 50)
        {
            texto +=  Console.ReadLine();
        }

        return texto;

    }

}