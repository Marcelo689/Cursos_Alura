using System;
using System.Collections.Generic;

namespace Testes
{
    internal class Curso
    {
        private string Titulo { get; set; }
        private string Autor { get; set; }
        private ISet<Aluno> alunos { get; set; }
        private Dictionary<int ,Aluno> matriculaParaAluno { get; set; }
        private int NumeroMatricula { get; set; }
        public ISet<Aula> Aulas { get; set; }

        public Curso(string titulo, string autor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Aulas = new HashSet<Aula>();
            this.alunos = new HashSet<Aluno>();
            this.matriculaParaAluno = new Dictionary<int, Aluno>();
        }
       
        internal void Matricula(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.matriculaParaAluno.Add(aluno.NumeroMatricula, aluno);
        }
        internal void SubstituiMatricula(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.matriculaParaAluno[aluno.NumeroMatricula] = aluno;
        }
        internal Aluno BuscaMatriculado(int numero)
        {
            Aluno result = null;
            this.matriculaParaAluno.TryGetValue(numero, out result);
            return result;
        }
        internal void Adiciona(Aula aula)
        {
            if(aula != null)
                Aulas.Add(aula);
        }
    }
}