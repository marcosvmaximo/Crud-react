using System;
using TesteWeb.Core.Application;
using TesteWeb.Domain.Entities;

namespace TesteWeb.Application.Commands;

public class ExcluirPagamentoCommand : Command<Pagamento>
{
    public Guid PagamentoId { get; set; }

    public ExcluirPagamentoCommand(Guid pagamentoId)
    {
        PagamentoId = pagamentoId;
    }
}

