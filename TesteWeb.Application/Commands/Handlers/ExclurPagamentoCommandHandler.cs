using System;
using MediatR;
using TesteWeb.Core;
using TesteWeb.Domain.Entities;
using TesteWeb.Domain.Interfaces;

namespace TesteWeb.Application.Commands.Handlers;

public class ExclurPagamentoCommandHandler : IRequestHandler<ExcluirPagamentoCommand, BaseResult<Pagamento>>
{
    private readonly IUsuarioRepository _repository;

    public ExclurPagamentoCommandHandler(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<BaseResult<Pagamento>> Handle(ExcluirPagamentoCommand request, CancellationToken cancellationToken)
    {
        await _repository.DeletarPagamento(request.PagamentoId);

        return BaseResult<Pagamento>.Ok(null);
    }
}

