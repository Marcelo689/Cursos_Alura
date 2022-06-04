using SistemaAgendamento.Core.Models;
using SistemaAgendamento.Core.Commands;
using SistemaAgendamento.Infrastructure;
using System;
using Microsoft.Extensions.Logging;
using SistemaAgendamento.Service;

namespace SistemaAgendamento.Services.Handlers
{
    public class CadastraAgendamentoHandler
    {
        IRepositorioAgendamento _repo;
        private RepositorioAgendamento repo;

        ILogger<CadastraAgendamentoHandler> _logger;
        public CadastraAgendamentoHandler(DbContext dbContext)
        {
            _repo = new RepositorioAgendamento(dbContext);
        }

        public CadastraAgendamentoHandler(RepositorioAgendamento repo, ILogger<CadastraAgendamentoHandler> logger)
        {
            this.repo = repo;
            _logger = logger;
        }

        public CommandResult Execute(CadastrarAgendamento comando)
        {
            try
            {
                var agendamento = new AgendamentoModel
                (
                    id: 0,
                    titulo: comando.Titulo,
                    sala: comando.Sala,
                    inicio: comando.Inicio,
                    fim: comando.Fim,
                    status: StatusAgendamento.Criada

                );
                repo.IncluirAgendamento(agendamento);

                return new CommandResult(true);

            }
            catch(Exception e)
            {
                _logger.LogError(e, e.Message);
                return new CommandResult(false);
            }
        }
    }
}
