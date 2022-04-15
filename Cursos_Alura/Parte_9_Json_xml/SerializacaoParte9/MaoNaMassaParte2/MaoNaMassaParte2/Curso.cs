using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MaoNaMassaParte2
{
    internal class Curso
    {
        private string v1;
        private string v2;

        public Curso(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public ISet<Aluno> Alunos
        {
            get
            {
                return alunos;
            }
        }
       
        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

    }

    public class Aluno
    {
        private string nome;
        private int numeroMatricula;
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }
        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
            set { numeroMatricula = value; }
        }

        internal void Adiciona(Aula aula)
        {

        }
        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }
        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {numeroMatricula}]";
        }
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
            {
                return false;
            }

            return this.nome.Equals(outro.nome);
        }
        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }
}