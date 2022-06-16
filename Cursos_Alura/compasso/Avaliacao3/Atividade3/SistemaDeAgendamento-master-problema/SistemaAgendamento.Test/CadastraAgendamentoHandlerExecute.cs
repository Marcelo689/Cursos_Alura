using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SistemaAgendamento.Core.Commands;
using SistemaAgendamento.Core.Models;
using SistemaAgendamento.Infrastructure;
using SistemaAgendamento.Service.Handlers;
using SistemaAgendamento.Services.Handlers;
using System;
using Xunit;
using DBContext = SistemaAgendamento.Infrastructure.DbContext;

namespace SistemaAgendamento.Test
{
    public class CadastraAgendamentoHandlerExecute
    {
        [Fact]
        public CommandResult AgendamentoValidoIncluirNoBD()
        {
            var comando = new CadastrarAgendamento("teste", new Sala(1,"Marcelo"), DateTime.Now, DateTime.Now);

            var options = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase("DbAgendamentoContext")
                .Options;

            var contexto = new DBContext(options);
            var repo = new RepositorioAgendamento(contexto);
            var handler = new CadastraAgendamentoHandler(contexto);

            handler.Execute(comando);

            var agendamentoModel = new AgendamentoModel(0, comando.Titulo, comando.Sala, DateTime.Now, DateTime.Now,StatusAgendamento.Criada);
            CommandResult resultado = repo.IncluirAgendamento(agendamentoModel);
            return resultado;
            Assert.NotNull(resultado.IsSuccess);
        }

    }
}
