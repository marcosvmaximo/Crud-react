using System;
using MediatR;
using TesteWeb.Core;
using TesteWeb.Domain;
using TesteWeb.Domain.Interfaces;

namespace TesteWeb.Application.Queries.Handlers;

public class BuscarTodosUsuariosQueryHandler : IRequestHandler<BuscarTodosUsuariosQuery, BaseResult<List<Usuario>>>
{
    private readonly IUsuarioRepository _repository;

    public BuscarTodosUsuariosQueryHandler(IUsuarioRepository repository)
    {
        _repository = repository;
    }

    public async Task<BaseResult<List<Usuario>>> Handle(BuscarTodosUsuariosQuery request, CancellationToken cancellationToken)
    {
        var usuarios = await _repository.ObterListaUsuarios();

        return BaseResult<List<Usuario>>.Ok(usuarios);
    }
}

