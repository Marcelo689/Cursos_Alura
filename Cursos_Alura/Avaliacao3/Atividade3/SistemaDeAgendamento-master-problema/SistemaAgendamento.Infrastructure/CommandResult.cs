using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento
{
    public class CommandResult
    {
        public CommandResult(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public bool IsSuccess { get; set; }
    }
}
