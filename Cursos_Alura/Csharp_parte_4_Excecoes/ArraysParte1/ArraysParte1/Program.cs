using ByteBank;
using ByteBank.Modelos;
using System;

namespace ArraysParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parte 1
            //TestandoArray1();

            //Parte 2
            //TestaArrayContaCorrente();

            //Parte 3
            //UsandoAdicionarLista();

            //Parte 4
            //RemovendoItemsDaLista();

            //Parte 5
            //int[] array = new int[] { 1, 2, 3, 4, 5 };
            //SomarNumeros(array);

            //Parte 6
            //AdicionandoVariasContas();

            // Parte 7
            //PegandoItemNoIndice();

            //Parte 8
            //int[] numeros = new int[] { 2, 3, 45, 5, 5 };
            //Console.WriteLine(SomarVarios(numeros));
            //SomarVarios(1, 2, 3, 5, 56465, 45);

            // PARTE MAO NA MASSA
            // ADICIONANDO VARIOS OBJETOS AO OBJETO DE LISTA DE OBJETOS
            //TestaListaDeContaCorrente();


            MinhaClasse classe = new MinhaClasse();

            MaoNaMassaParte5();

            // PARA O CODIGO

            Console.ReadLine();
            
        }
        public static void MaoNaMassaParte5()
        {
            ListaObject<int> idades = new ListaObject<int>();

            idades.AdicionarVarios(63, 15, 21, 50);
            idades.Remover(15);

            ListaObject<string> cursos = new ListaObject<string>();
            cursos.AdicionarVarios("C# Parte 1", "C# Parte 2", "C# Parte 3");

            ListaObject<ContaCorrente> contas = new ListaObject<ContaCorrente>();
            contas.AdicionarVarios(new ContaCorrente(124, 54354), new ContaCorrente(201, 44354));
        }
        public static void ListaGenerica()
        {
            //Parte 5 : lista generica
            ListaObject<int> listaDeIdades = new ListaObject<int>();
            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);
            //listaDeIdades.Adicionar("um texto qualquer"); erro
        }
        public class MinhaClasse
        {
            public static int ContadorClasses;
            public MinhaClasse()
            {
                ContadorClasses++;
                Console.WriteLine(ContadorClasses);
            }
        }
        public static void TestaListaObject()
        {
            //ListaObject<int> idades = new ListaObject<int>();

        }
        static void TestaListaDeContaCorrente()
        {
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaContaCorrente lista = new ListaContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
        contaDoGui,
        new ContaCorrente(874, 5679787),
        new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {

                //ContaCorrente teste = lista["texto"];

                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }
        public static void PegandoItemNoIndice()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(1111, 5679787),
                new ContaCorrente(2222, 5679754)
            };

            ListaContaCorrente listaContas = new ListaContaCorrente();
            listaContas.AdicionarVarios(contas);

            int indice = 1;
            ContaCorrente conta = listaContas.GetContaCorrenteNoIndice(indice);
            Console.WriteLine("Agencia da conta = " + conta.Agencia + " no indice " + indice);
        }
        public static void AdicionandoVariasContas()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            ListaContaCorrente listaContas = new ListaContaCorrente();
            listaContas.AdicionarVarios(contas);
            listaContas.EscreverListaNaTela();
        }
        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }
        public static void SomarNumeros(int[] numeros)
        {
            for (int i = 0; i < numeros.Length - 1; i += 2)
            {
                int primeiroNumero = numeros[i];
                int segundoNumero = numeros[i + 1];

                int soma = primeiroNumero + segundoNumero;

                Console.WriteLine($"{primeiroNumero}+{segundoNumero} = {soma}");

            }
        }
        public static void RemovendoItemsDaLista()
        {
            ListaContaCorrente lista = new ListaContaCorrente();
            
            ContaCorrente conta1 = new ContaCorrente(11111, 234232);
            ContaCorrente conta2 = new ContaCorrente(22222, 235554232);
            ContaCorrente conta3 = new ContaCorrente(333333, 234232);
            ContaCorrente conta4 = new ContaCorrente(44444, 234232);
            
            lista.Adicionar(conta1);
            lista.Adicionar(conta2);
            lista.Adicionar(conta3);
            lista.Adicionar(conta4);
            
            lista.EscreverListaNaTela();

            lista.Remover(conta2);

            lista.EscreverListaNaTela();

            Console.ReadLine();
        }

        public static void UsandoAdicionarLista()
        {
            ListaContaCorrente lista = new ListaContaCorrente();
            ContaCorrente contaDoMarcelo = new ContaCorrente(546, 5674976);
            lista.Adicionar(contaDoMarcelo);
            Console.WriteLine(lista);

            Cliente cli1 = new Cliente();
            cli1.Nome = "Tainá";

            Cliente cli2 = new Cliente();
            cli2.Nome = "Carlos";
            lista.VerificarCapacidade(10);
            object[] referencias = new object[5];
            //Console.WriteLine(referencias[1].Nome);
            // erro pois classe generica de objetos nao possui propriedade nome.

            referencias[0] = cli1;
            referencias[1] = cli2;
            Console.ReadLine();
        }

        public static void TestaArrayContaCorrente()
        {
            int[] exemplo = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(exemplo[0]);
            ContaCorrente[] contas = new ContaCorrente[3]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668),
                new ContaCorrente(874, 7781438),
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

            Console.ReadLine();
        }
        public static void TestandoArray1()
        {
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            int media = 0;
            int acumulador = 0;
            for (int indice = 0 ; indice <= 4; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }
            media = acumulador / idades.Length;
            int idadeNoIndice4 = idades[4];
            Console.WriteLine("Quantidade acumulada = " + acumulador);
            Console.WriteLine("Media " + media);
            Console.WriteLine(idadeNoIndice4);

            int[] nums = idades;

            Console.WriteLine(nums[0]);
            Console.ReadLine();
        }

    }
}
