using ByteBank;
using ByteBank.Modelos.Comparadores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parte_8_List_lambda_linq
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //------------Parte 1--------------------

            //Parte1ClasseListDotNet();
            //Parte1_4_Metodos_de_Extensao();
            //MaoNaMassa1();

            //------------Parte 2-------------------- 

            //Parte2_3_Metodos_extensao_genericos();
            //Parte2_4_Verifica_se_nulo(); 
            //MaoNaMassa2();

            //------------Parte 3---------------------

            //Parte3_2_Usando_var(); 
            //Parte3_3_Ordenando_listas();
            //MaoNaMassa3();


            //------------Parte 4---------------------

            //Parte4_2_Interface_IComparable();
            //MaoNaMassa4();

            //------------Parte 5---------------------

            //Parte5_2_Usando_OrderBy();
            //Parte5_3_Expressoes_Lambda();
            //MaoNaMassa5();

            //------------Parte 6---------------------
            //Parte6_2_Usando_Where();
            MaoNaMassa6();


            // Para o Console
            Console.ReadLine();
        }
        public static void Parte1_1_ClasseListDotNet()
        {
            //ListaObject<int> idades = new ListaObject<int>();

            //idades.Adicionar(1);
            //idades.Adicionar(5);
            //idades.Adicionar(14);
            //idades.Adicionar(25);
            //idades.Adicionar(38);
            //idades.Adicionar(61);
            //idades.Remover(5);
            //for (int i = 0; i < idades.Tamanho; i++)
            //{
            //    Console.WriteLine(idades[i]);
            //}

            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.Remove(5);
            idades.AddRange(new[] { 1, 2, 3, 9 });

            ListExtensoes.AdicionarVarios(idades, 1, 5687, 1987, 1567, 987);
            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }


        }
        public static void Parte1_4_Metodos_de_Extensao()
        {
            "Marcelo".EscreverNaTela();
            1.EscreverNaTela();
            ContaCorrente conta = new ContaCorrente(1232, 3235352);
            conta.EscreverNaTela();
        }

        public static void MaoNaMassa1()
        {
            List<int> idades = new List<int>();

            idades.Add(1);
            idades.Add(5);
            idades.Add(14);
            idades.Add(25);
            idades.Add(38);
            idades.Add(61);

            idades.Remove(5);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            //ListExtensoes.AdicionarVarios(idades, 1, 5, 14, 25, 38, 61);

            idades.AdicionarVarios(1, 5, 14, 25, 38, 61);
        }

        public static void Parte2_3_Metodos_extensao_genericos()
        {
            List<string> nomes = new List<string>();
            nomes.AdicionarVarios("Marcelo", "Sueli");
        }
        public static void Parte2_4_Verifica_se_nulo()
        {
            int[] a = new int[] { 0, 1, 2 };
            int[] b = new int[] { 3, 4, 5 };

            //int[] resultado = a.Concatenar(b);
        }
        public static object[] Concatenar(this object[] a, object[] b)
        {
            var resultado = new object[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                resultado[i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                resultado[a.Length + i] = b[i];
            }

            return resultado;
        }

        public static void MaoNaMassa2()
        {
            List<int> idades = new List<int>();
            idades.AdicionarVarios<int>(1, 5, 14, 25, 38, 61);

            List<string> nomes = new List<string>();
            nomes.AdicionarVarios<string>("Adoniran", "Jimi Hendrix");
        }

        public static void Parte3_2_Usando_var()
        {
            ContaCorrente conta = new ContaCorrente(344, 56456556);
            GerenciadoBonificacao gerenciador = new GerenciadoBonificacao();
            List<GerenciadoBonificacao> gerenciadores = new List<GerenciadoBonificacao>();

            // com erros
            //ContaCorrente conta = new T(344, 56456556);
            //List<GerenciadoBonificacao> gerenciadores = new T();

            var contaVar = new ContaCorrente(1232, 123241);

            var nome = "Marcelo";
            var idade = "23";

        }
        public static void Parte3_3_Ordenando_listas()
        {
            //var resultado = SomarVarios(1, 5, 9);
            //var conta = new ContaCorrente(344, 56456556);
            var gerenciador = new GerenciadoBonificacao();
            var gerenciadores = new List<GerenciadoBonificacao>();
            var idades = new List<int>() { 1, 5, 14, 25, 38, 61, 45, 89, 12 };

            idades.AdicionarVarios(99, -1);

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            var nomes = new List<string>();

            nomes.AdicionarVarios("Marcelo", "Guilherme", "Luana");

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            nomes.Sort();

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }


            var contas = new List<ContaCorrente>()
            {
                    new ContaCorrente(341, 57480),
                    new ContaCorrente(342, 45678),
                    new ContaCorrente(340, 48950),
                    new ContaCorrente(290, 18950)
            };

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            //contas.Sort(); erro não pode ser ordenado 

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }
        }
        public static void MaoNaMassa3()
        {
            var nomes = new List<string>()
            {
                "Vinícius",
                "Gisele",
                "Mayra",
                "Vasco"
            };
            nomes.Sort();
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 18950)
            };

            //contas.Sort(); Falha ao comparar dois elementos na matriz

            foreach (var conta in contas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

        }

        public static void Parte4_2_Interface_IComparable()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 1),
                new ContaCorrente(340, 99999),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 18950)
            };

            contas.Sort();

            foreach (var conta in contas)
            {
                Console.WriteLine(conta.Numero);
            }
        }
        public static void Parte4_3_Interface_IComparer()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 1),
                new ContaCorrente(340, 99999),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 18950)
            };

            contas.Sort();

            foreach (var conta in contas)
            {
                Console.WriteLine(conta.Numero);
            }
        }
        public static void MaoNaMassa4()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 1),
                new ContaCorrente(345, 99999),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 18950)
            };
            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var conta in contas)
            {
                Console.WriteLine(conta.Agencia);
            }
        }

        public static void Parte5_2_Usando_OrderBy()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 1),
                new ContaCorrente(345, 99999),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 18950)
            };
            IOrderedEnumerable<ContaCorrente> listaOrdenada = contas.OrderBy(conta => conta.Numero);

            foreach (var conta in listaOrdenada)
            {
                Console.WriteLine(conta.Numero);
            }
        }
        public static void Parte5_3_Expressoes_Lambda()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 57480),
                new ContaCorrente(342, 45678),
                new ContaCorrente(340, 1),
                new ContaCorrente(345, 99999),
                new ContaCorrente(340, 48950),
                new ContaCorrente(290, 18950)
            };
            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta => 5);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine(conta.Numero);

            }

            var contas1 = new List<ContaCorrente>()
            {
                    new ContaCorrente(341, 1),
                    new ContaCorrente(342, 999),
                    null,
                    new ContaCorrente(340, 4),
                    new ContaCorrente(340, 456),
                    new ContaCorrente(340, 10),
                    null,
                    null,
                    new ContaCorrente(290, 123)
            };

            Console.WriteLine("-----------------------------------");

            IOrderedEnumerable<ContaCorrente> contasOrdenadas2 = contas1.OrderBy(
                conta =>
                {
                    if (conta == null) return int.MinValue;
                    return conta.Numero;
                }
            );

            foreach (var conta in contasOrdenadas2)
            {
                if (conta != null) Console.WriteLine(conta.Numero);
                else
                    Console.WriteLine("Conta nula");
            }
        }
        public static void MaoNaMassa5()
        {
            var contas = new List<ContaCorrente>()
            {
                    new ContaCorrente(341, 1),
                    new ContaCorrente(342, 999),
                    null,
                    new ContaCorrente(340, 4),
                    new ContaCorrente(340, 456),
                    new ContaCorrente(340, 10),
                    null,
                    null,
                    new ContaCorrente(290, 123)
            };

            Console.WriteLine("-----------------------------------");

            var contasOrdenadas = contas.OrderBy(
                conta =>
                {
                    if (conta == null) return int.MinValue;
                    return conta.Numero;
                }
            );

            foreach (var conta in contasOrdenadas)
            {
                if (conta != null) Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                else
                    Console.WriteLine("Conta nula");
            }
        }

        public static void Parte6_2_Usando_Where()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(12321,36),
                new ContaCorrente(12321,4),
                new ContaCorrente(12321,5),
                new ContaCorrente(12321,1)
            };

            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

            var listaSemNulo = contas.Where(conta => conta != null);

            foreach (var conta in listaSemNulo)
            {
                Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
            }

        }
        public static void Parte6_3_Linq_e_Enumerable()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(12321,36),
                new ContaCorrente(12321,4),
                new ContaCorrente(12321,5),
                new ContaCorrente(12321,1)
            };
             
            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta => conta != null).
            OrderBy<ContaCorrente, int>(conta => conta.Numero);


        }
        public static void MaoNaMassa6()
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(12321,36),
                null,
                new ContaCorrente(12321,4),
                null,
                new ContaCorrente(12321,5),
                new ContaCorrente(12321,1)
            };

            var contasOrdenadas = contas
            .Where(conta => conta != null)
            .OrderBy(conta => conta.Numero);

            foreach(ContaCorrente conta in contasOrdenadas)
            {
                Console.WriteLine($" Agencia:{conta.Agencia} \n Numero:{conta.Numero}");
            }
        }
        public static void EscreverNaTela(this object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
