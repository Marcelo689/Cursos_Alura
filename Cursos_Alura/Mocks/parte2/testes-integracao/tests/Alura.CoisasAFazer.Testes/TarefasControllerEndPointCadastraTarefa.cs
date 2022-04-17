using Alura.CoisasAFazer.Core.Models;
using Alura.CoisasAFazer.Infrastructure;
using Alura.CoisasAFazer.Services.Handlers;
using Alura.CoisasAFazer.WebApp.Controllers;
using Alura.CoisasAFazer.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace Alura.CoisasAFazer.Testes
{
    public class TarefasControllerEndPointCadastraTarefa
    {
        [Fact]
        public void Test()
        {

            var mockLogger = new Mock<ILogger<CadastraTarefaHandler>>();
            var options = new DbContextOptionsBuilder<DbTarefasContext>()
                .UseInMemoryDatabase("DbTarefasContext")
                .Options;
            var contexto = new DbTarefasContext(options);
            contexto.Categorias.Add(new Categoria(20, "Estudo"));
            contexto.SaveChanges();
            var repo = new RepositorioTarefa(contexto);
            
            //arrange
            var controlador = new TarefasController(repo, mockLogger.Object);
            var model = new CadastraTarefaVM();
            model.IdCategoria = 20;
            model.Titulo = "Estudar Xunit";
            model.Prazo = new DateTime(2019,10,10);

            var retorno = controlador.EndpointCadastraTarefa(model);

            Assert.IsType<OkResult>(retorno);
        }
        [Fact]
        public void Teste()
        {
            var mockLogger = new Mock<ILogger<CadastraTarefaHandler>>();
            var mock = new Mock<IRepositorioTarefas>();
            mock.Setup(r => r.ObtemCategoriaPorId(20)).Returns(new Categoria(20, "Estudo"));
            mock.Setup(r => r.IncluirTarefas(It.IsAny<Tarefa[]>())).Throws(new Exception("Houve um erro ao incluir"));
            var repo = mock.Object;
            //arrange
            var controlador = new TarefasController(repo, mockLogger.Object);
            var model = new CadastraTarefaVM();
            model.IdCategoria = 20;
            model.Titulo = "Estudar Xunit";
            model.Prazo = new DateTime(2019, 10, 10);

            var retorno = controlador.EndpointCadastraTarefa(model);

            Assert.IsType<StatusCodeResult>(retorno);
            var statusCodeRetornado = (retorno as StatusCodeResult).StatusCode;
            Assert.Equal(500, statusCodeRetornado);
        }

    }
}
