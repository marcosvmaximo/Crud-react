using System;
using MediatR;
using TesteWeb.Core;
using TesteWeb.Domain.Entities;
using TesteWeb.Domain.Interfaces;

namespace TesteWeb.Application.Queries.Handlers;

public class BuscarPagamentosPorUsuarioQueryHandler : IRequestHandler<BuscarPagamentosPorUsuarioQuery, BaseResult<List<Pagamento>>>
{
    private readonly IUsuarioRepository _repository;

    public BuscarPagamentosPorUsuarioQueryHandler(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<BaseResult<List<Pagamento>>> Handle(BuscarPagamentosPorUsuarioQuery request, CancellationToken cancellationToken)
    {
        var pagamentos = await _repository.ObterPagamentosPorUsuario(request.UsuarioId);

        if (pagamentos == null)
            return new BaseResult<List<Pagamento>>()
            {
                Code = 404,
                Sucess = false,
                Message = "Pagamentos do usuário informado não foram encontrados.",
                Data = null
            };

        return BaseResult<List<Pagamento>>.Ok(pagamentos);
    }
}

