using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------Parte 1----------------------------
            //ArraysExemplos01();


            //-----------------------Parte 2----------------------------
            //BuscandoRedimensionandoArray02();

            //-----------------------Parte 3----------------------------
            //OrdenandoCopiandoColandoLimpando03();

            //-----------------------Parte 4----------------------------
            MaoNaMassa();

            Console.ReadKey();
        }

        private static void MaoNaMassa()
        {
            Imprimir("                  Mao na Massa");
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            Imprimir(aulas);
            string[] aulasInalterado = aulas.Clone() as string[];
            // aulas[0] = primeiro indice do array
            // aulas.Length = ultimo indice do array 
            
            ImprimirLinhaSeparadora();

            // copia do array inicial
            Imprimir("                  Copia do array inicial começando no indice 1");
            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            ImprimirLinhaSeparadora();

            // procurando indice em que a string se encontra no array de strings
            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));

            ImprimirLinhaSeparadora();
            
            // encontra indice do ultimo encontro no array
            Console.WriteLine("Ultimo encontro no array foi no indice = " + Array.LastIndexOf(aulas, aulaModelando));
            ImprimirLinhaSeparadora();

            Imprimir("                  Invertendo ordem do array");
            // invertendo ordem do array
            Array.Reverse(aulas);
            Imprimir(aulas);
            ImprimirLinhaSeparadora();

            // redimensionando array
            Imprimir("                  Redimensionando array");
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);
            ImprimirLinhaSeparadora();

            // Ordenando array
            Imprimir("                 Ordenando array");
            Array.Sort(aulas);
            Imprimir(aulas);
            ImprimirLinhaSeparadora();

            // Criando uma copia exata do array
            Imprimir("                 Criando copia do array com clone");
            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);
            ImprimirLinhaSeparadora();

            // Limpando array
            Imprimir("                 Apagando indices do array inicial inalterado");
            Array.Clear(aulasInalterado, 1, 2); // Clear( array, apagarApartirDesteIndice, quantidadeDeIndicesASerApagados)
            Imprimir(aulasInalterado);
        }

        public static void ArraysExemplos01()
        {
            string alura = "Alura";
            string meuNome = "Marcelo";
            string meuSobrenome = "Jaeger";

            //Console.WriteLine(alura);
            //Console.WriteLine(meuNome);
            //Console.WriteLine(meuSobrenome);

            //string[] arrayDeStrings = new string[3];
            //arrayDeStrings[0] = alura;
            //arrayDeStrings[1] = meuNome;
            //arrayDeStrings[2] = meuSobrenome;

            string[] arrayDeStrings = { alura, meuNome, meuSobrenome };

            //for(int i = 0; i < arrayDeStrings.Length; i++)
            //{
            //    Console.WriteLine(arrayDeStrings[i]);
            //}

            foreach (string item in arrayDeStrings)
            {
                Console.WriteLine(item);
            }
        }

        public static void BuscandoRedimensionandoArray02()
        {
            var arrayDeStrings = ArrayDeExemplo();
            // inverter ordem do array
            Array.Reverse(arrayDeStrings);
            Imprimir(arrayDeStrings);

            ImprimirLinhaSeparadora();

            //redimensionar array
            Array.Resize(ref arrayDeStrings, 2);
            Imprimir(arrayDeStrings);
        }

        public static void OrdenandoCopiandoColandoLimpando03()
        {

            // Mostrando array antes de modificalo
            Imprimir("                  Mostrando array antes de modificalo");
            ImprimirLinhaSeparadora();
            var array = ArrayDeExemplo();
            Imprimir(array);
            ImprimirLinhaSeparadora();


            // Ordenando array
            Imprimir("                  Ordenando array");
            ImprimirLinhaSeparadora();
            Array.Sort(array);
            Imprimir(array);
            ImprimirLinhaSeparadora();

            // Copiando array
            Imprimir("                  Copiando Array");
            ImprimirLinhaSeparadora();
            int tamanhoArray = 2;
            string[] arrayCopia = new string[tamanhoArray];
            //Array.Copy(array, arrayCopia, tamanhoArray);
            Array.Copy(array, 1, arrayCopia, 0, tamanhoArray);
            Imprimir(arrayCopia);
            ImprimirLinhaSeparadora();

            // Clonando array
            Imprimir("                  Clonando Array");
            ImprimirLinhaSeparadora();
            string[] cloneArray = array.Clone() as string[];
            Imprimir(cloneArray);
            ImprimirLinhaSeparadora();

            // Limpar Array
            Imprimir("                  Limpando Array");
            ImprimirLinhaSeparadora();
            Array.Clear(cloneArray, 1, cloneArray.Length - 1); // apaga da posição 1 em diante
            Imprimir(cloneArray);

            ImprimirLinhaSeparadora();
        }
        public static string [] ArrayDeExemplo()
        {
            string alura = "Alura";
            string meuNome = "Marcelo";
            string meuSobrenome = "Jaeger";

            string[] arrayDeStrings = { alura, meuNome, meuSobrenome };
            return arrayDeStrings;
        }
        public static void ImprimirLinhaSeparadora()
        {
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public static void Imprimir(params string [] array)
        {
            foreach (string item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
