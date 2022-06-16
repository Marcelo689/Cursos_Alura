using System;
using System.Collections.Generic;
using System.Linq;
using SistemaAgendamento.Core.Models;
using SistemaAgendamento.Service;
using SistemaAgendamento.Service.Handlers;

namespace SistemaAgendamento.Infrastructure
{
    public class RepositorioAgendamento : IRepositorioAgendamento
    {
        DbContext _ctx;

        public RepositorioAgendamento(DbContext dbContext)
        {
            _ctx = dbContext;
        }
        public RepositorioAgendamento()
        {

        }
        public void AtualizarAgendamentos(params AgendamentoModel[] Sala)
        {
            _ctx.Agendamento.UpdateRange(Sala);
            _ctx.SaveChanges();
        }

        public void ExcluirAgendamentos(params AgendamentoModel[] Sala)
        {
            _ctx.Agendamento.RemoveRange(Sala);
            _ctx.SaveChanges();
        }

        public void IncluirAgendamentos(params AgendamentoModel[] Sala)
        {
            _ctx.Agendamento.AddRange(Sala);
            _ctx.SaveChanges();
        }

        public CommandResult IncluirAgendamento(AgendamentoModel Sala)
        {
            _ctx.Agendamento.Add(Sala);
            _ctx.SaveChanges();

            return new CommandResult(true);

        }

        public AgendamentoModel ObtemAgendamentoPorId(int id)
        {
            return _ctx.Agendamento.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<AgendamentoModel> ObtemAgendamentos(Func<AgendamentoModel, bool> filtro)
        {
            return _ctx.Agendamento.Where(filtro);
        }
    }
}
