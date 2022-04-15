using Alura.CoisasAFazer.Core.Commands;
using Alura.CoisasAFazer.Core.Models;
using Alura.CoisasAFazer.Services.Handlers;
using NUnit.Framework;
using System;

namespace AluraCoisasAFazerTestes
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //arrange 
            var comando = new CadastraTarefa("Estudar Xunit", new Categoria("Estudo"), new DateTime(2019, 12,31));

            //handler

            var repo = new RepositorioFake();
            var handler = new CadastraTarefaHandler(repo);

            //act
            handler.Execute(comando);

            //assert
            var tarefas = repo.ObtemTarefas(t => t.Titulo == "Estudar Xunit");
            Assert.True(true);
        }
    }
}