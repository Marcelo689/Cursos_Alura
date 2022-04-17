using Alura.CoisasAFazer.Core.Commands;
using Alura.CoisasAFazer.Core.Models;
using Alura.CoisasAFazer.Infrastructure;
using Alura.CoisasAFazer.Services.Handlers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

namespace Alura.CoisasAFazer.Testes
{
    public class CadastraTarefaHandlerExecute
    {
        [Fact]
        public void DadaTarefaComInfoValidasDeveIncluirNoBD()
        {
            //arrange
            var comando = new CadastraTarefa("Estudar Xunit", new Categoria(100, "Estudo"), new DateTime(2019, 12, 31));

            var mock = new Mock<ILogger<CadastraTarefaHandler>>();
            var options = new DbContextOptionsBuilder<DbTarefasContext>()
                .UseInMemoryDatabase("DbTarefasContext")
                .Options;
            var contexto = new DbTarefasContext(options);
            var repo = new RepositorioTarefa(contexto);

            var handler = new CadastraTarefaHandler(repo, mock.Object);

            //act
            handler.Execute(comando); //SUT >> CadastraTarefaHandlerExecute

            //assert
            var tarefa = repo.ObtemTarefas(t => t.Titulo == "Estudar Xunit").FirstOrDefault();
            Assert.NotNull(tarefa);
        }

        [Fact]
        public void QuandoExceptionForLancadaResultadoIsSuccessDeveSerFalse()
        {
            //arrange
            var comando = new CadastraTarefa("Estudar Xunit", new Categoria("Estudo"), new DateTime(2019, 12, 31));

            var mock = new Mock<IRepositorioTarefas>();

            var mockLogger = new Mock<ILogger<CadastraTarefaHandler>>();
            mock.Setup(r => r.IncluirTarefas(It.IsAny<Tarefa[]>()))
                .Throws(new Exception("Houve um erro na inclusão de tarefas"));

            var repo = mock.Object;

            var handler = new CadastraTarefaHandler(repo, mockLogger.Object);

            //act
            CommandResult resultado = handler.Execute(comando);

            //assert
            Assert.False(resultado.IsSuccess);
        }

        [Fact]
        public void DadaTarefaComInfoValidasDeveIncluirNoBD2()
        {
            //arrange
            var comando = new CadastraTarefa("Estudar Xunit", new Categoria(100, "Estudo"), new DateTime(2019, 12, 31));
            CapturarMensagemLog captura = (level, eventid, state, exception, func) =>
            {

            };
            var mock = new Mock<ILogger<CadastraTarefaHandler>>();
            var options = new DbContextOptionsBuilder<DbTarefasContext>()
                .UseInMemoryDatabase("DbTarefasContext")
                .Options;
            var contexto = new DbTarefasContext(options);
            var repo = new RepositorioTarefa(contexto);

            var handler = new CadastraTarefaHandler(repo, mock.Object);

            //act
            handler.Execute(comando); //SUT >> CadastraTarefaHandlerExecute

            //assert
            var tarefa = repo.ObtemTarefas(t => t.Titulo == "Estudar Xunit").FirstOrDefault();
            Assert.NotNull(tarefa);
        }
        [Fact]
        public void QuandoExceptionForLancadaDeveLogarAMensagemDaExcecao()
        {

            var mensagemErroEsperada = "Houve um erro";
            var excecaoEsperada = new Exception(mensagemErroEsperada);
            var comando = new CadastraTarefa("Estudar Xunit", new Categoria("Estudo"), new DateTime(2019, 12, 31));

            var mock = new Mock<IRepositorioTarefas>();

            var mockLogger = new Mock<ILogger<CadastraTarefaHandler>>();
            mock.Setup(r => r.IncluirTarefas(It.IsAny<Tarefa[]>()))
                .Throws(excecaoEsperada);

            var repo = mock.Object;

            var handler = new CadastraTarefaHandler(repo, mockLogger.Object);

            //act
            CommandResult resultado = handler.Execute(comando);

            //assert
            mockLogger.Verify(l => l.Log(
                LogLevel.Error, // nivel do log
                It.IsAny<EventId>(), // identificador do log
                It.IsAny<object>(), //objeto que sera logado
                excecaoEsperada, // excecao que sera logada
                It.IsAny<Func<object, Exception, string>>()// funcao que converte objeto<excecao> string
                ),  
                Times.Once()
                );

        } 
        public void MockLoggerFuncao()
        {

            var mensagemErroEsperada = "Houve um erro";
            var excecaoEsperada = new Exception(mensagemErroEsperada);
            var comando = new CadastraTarefa("Estudar Xunit", new Categoria("Estudo"), new DateTime(2019, 12, 31));
            LogLevel levelCapturado = LogLevel.Error;
            var mensagemCapturada = "";
            var mock = new Mock<IRepositorioTarefas>();
            CapturarMensagemLog captura = (level, eventid, state, exception, func) =>
            {
                levelCapturado = level;
                mensagemCapturada = func(state, exception);
            };
            var mockLogger = new Mock<ILogger<CadastraTarefaHandler>>();
            mockLogger.Setup(r => r.Log(
                LogLevel.Error, // nivel do log
                It.IsAny<EventId>(), // identificador do log
                It.IsAny<object>(), //objeto que sera logado
                excecaoEsperada, // excecao que sera logada
                It.IsAny<Func<object, Exception, string>>()// funcao que converte objeto<excecao> string))
                )).Callback(captura);

            var repo = mock.Object;

           
            var handler = new CadastraTarefaHandler(repo, mockLogger.Object);

            //act
            CommandResult resultado = handler.Execute(comando);

            //assert
            Assert.Equal(LogLevel.Information, levelCapturado);
            Assert.Contains("Persistindo a tarefa...", mensagemCapturada);

        }

        delegate void CapturarMensagemLog(LogLevel level, EventId eventid, object state, Exception exception, Func<object, Exception, string> function);

    }
}
