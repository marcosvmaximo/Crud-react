using System;
using MediatR;
using TesteWeb.Core.Application;
using TesteWeb.Domain;

namespace TesteWeb.Application.Queries;

public class BuscarTodosUsuariosQuery : Query<List<Usuario>>
{
    public BuscarTodosUsuariosQuery()
    {
    }
}

