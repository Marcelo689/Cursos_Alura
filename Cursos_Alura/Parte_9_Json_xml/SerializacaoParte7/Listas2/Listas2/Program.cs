using System;
using System.Collections.Generic;

namespace Listas2
{
    internal class Program
    {
        //Cronologia Star Wars
        //=========================================
        //Episódio I: A Ameaça Fantasma         1999
        //Episódio II: Ataque dos Clones        2002
        //A Guerra dos Clones                   2003
        //Episódio III: A Vingança dos Sith     2005
        //Rebels                                2014
        //Rogue One                             2016
        //Episódio IV -Uma nova esperança       1977
        //Episódio V -O Império Contra-Ataca    1980
        //Episódio VI -O Retorno de Jedi        1983
        //Episódio VII -O Despertar da Força    2015
        //Episódio VIII: Os Últimos Jedi        2017
        static void Main(string[] args)
        {
            //TAREFA PRINCIPAL
            //=================
            //colocar os filmes abaixo na ordem cronológica
            var esperanca = new Filme("Episódio IV -Uma nova esperança", 1977);
            var imperio = new Filme("Episódio V -O Império Contra-Ataca", 1980);
            var retorno = new Filme("Episódio VI -O Retorno de Jedi", 1983);
            var ameaca = new Filme("Episódio I: A Ameaça Fantasma", 1999);
            var ataque = new Filme("Episódio II: Ataque dos Clones", 2002);
            var guerraClones = new Filme("A Guerra dos Clones", 2003);
            var vinganca = new Filme("Episódio III: A Vingança dos Sith", 2005);
            var rebels = new Filme("Rebels", 2014);
            var despertar = new Filme("Episódio VII -O Despertar da Força", 2015);
            var rogue = new Filme("Rogue One", 2016);
            var ultimo = new Filme("Episódio VIII: Os Últimos Jedi", 2017);

            ///TAREFA: criar uma coleção vazia, que irá crescer aos poucos
            List<Filme> cronologia = new List<Filme>();
            ///TAREFA: checar a capacidade da lista
            ImprimirCapacidade(cronologia);
            ///TAREFA: adicionar o filme "Episódio IV -Uma nova esperança"
            cronologia.Add(esperanca);
            ///TAREFA: checar novamente a capacidade da lista
            ImprimirCapacidade(cronologia);
            ///TAREFA: Adicionar no final: Império Contra Ataca e Retorno de Jedi
            cronologia.AddRange(new List<Filme> { imperio, retorno });
            ImprimirCronologia(cronologia);
            ///TAREFA: Declarar a lista com inicialização simplificada
            cronologia = new List<Filme> { esperanca, imperio, retorno };
            ///TAREFA: checar novamente a capacidade da lista
            ImprimirCapacidade(cronologia);
            ///TAREFA: imprimir a cronologia
            ImprimirCronologia(cronologia);
            ///TAREFA: inserir Ameaça Fantasma no início da cronologia
            cronologia.Insert(0, ameaca);
            ///TAREFA: Inserir na segunda posição: Ataque dos Clones, Guerra dos Clone, Vingança dos Sith
            cronologia.Insert(1, ataque);
            ///TAREFA: checar novamente a capacidade da lista
            ImprimirCapacidade(cronologia);
            ///TAREFA: adicionar Despertar da Força no fim da cronologia
            cronologia.Add(despertar);
            ///TAREFA: inserir Rogue One antes de Uma Nova Esperança
            cronologia.Insert(2, rogue);
            ///TAREFA: adicionar O Último Jedi ao final da cronologia
            cronologia.Add(ultimo);
            ///TAREFA: exibir a cronologia inversa
            cronologia.Reverse();
            ImprimirCronologia(cronologia);
            ///TAREFA: voltar a cronologia à ordem original
            cronologia.Reverse();
            ///TAREFA: obter lista de filmes só com atores (sem rebels e guerra dos clones)
            var filmesComAtores = new List<Filme>(cronologia);
            //ImprimirCronologia(filmesComAtores);
            //filmesComAtores.RemoveAt(1);
            filmesComAtores.Remove(ataque);
            //ImprimirCronologia(filmesComAtores);
            ///TAREFA: obter trilogia original (filmes lançados até 1983)
            var trilogiaOriginal = new List<Filme>(cronologia);
            trilogiaOriginal.RemoveAll((filme) => filme.Ano > 1983);
            ///TAREFA: exibir primeiro filme da cronologia

            ///TAREFA: exibir último filme da cronologia

            ///TAREFA: exibir filmes em ordem alfabética
            ///
            Imprimir(" exibir filmes em ordem alfabética");
            var filmesOrdemAlfabetica = new List<Filme>(cronologia);
            filmesComAtores.Sort();
            ImprimirCronologia(filmesOrdemAlfabetica);
            ///TAREFA: exibir filmes em ordem de lançamento
            ///
            Imprimir(" exibir filmes em ordem de lançamento");
            var filmesOrdemLancamento = new List<Filme>(cronologia);
            filmesOrdemLancamento.Sort((filme1, filme2) => filme1.Ano.CompareTo(filme2.Ano));
            ImprimirCronologia(filmesOrdemLancamento);
            ///TAREFA: exibir filmes da trilogia inicial (posições 4, 5 e 6)
            ///
            Imprimir("exibir filmes da trilogia inicial (posições 4, 5 e 6)");
            var trilogiaInicial = new Filme[3];
            filmesOrdemLancamento.CopyTo(3, trilogiaInicial, 0, 3);
            ImprimirCronologia(trilogiaInicial);
        }
        public static void Imprimir(params string[] itens)
        {
            LinhaSeparadora();
            foreach (var item in itens)
            {
                Console.WriteLine(item);
            }
            LinhaSeparadora();
        }
        public static void ImprimirCronologia(IEnumerable<Filme> lista)
        {
            LinhaSeparadora();
            foreach (var item in lista)
            {
                Console.WriteLine(item.Titulo + ", Ano " + item.Ano);
            }
            LinhaSeparadora();
        }
        public static void LinhaSeparadora()
        {
            Console.WriteLine("-----------------------------------------------------------------");
        }
        public static void ImprimirCapacidade(List<Filme> lista)
        {
            LinhaSeparadora();
            Imprimir("O tamanho atual da lista é = " + lista.Count);
            Imprimir("Capacidade da lista = " + lista.Capacity);
            LinhaSeparadora();
        }
    }

    public class Filme : IComparable
    {
        public Filme(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
        }

        public string Titulo { get; set; }
        public int Ano { get; set; }

        public int CompareTo(object obj)
        {
            Filme esta  = this;
            Filme outra = obj as Filme;

            if(outra == null)
                return 1;
            
            return esta.Titulo.CompareTo(outra.Titulo);
        }
        public override string ToString()
        {
            return $"{Titulo} - {Ano}";
        }

    }


}
