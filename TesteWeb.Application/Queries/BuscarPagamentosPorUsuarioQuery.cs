using System;
using TesteWeb.Core.Application;
using TesteWeb.Domain.Entities;

namespace TesteWeb.Application.Queries;

public class BuscarPagamentosPorUsuarioQuery : Query<List<Pagamento>>
{
    public BuscarPagamentosPorUsuarioQuery(Guid usuarioId)
    {
        UsuarioId = usuarioId;
    }

    public BuscarPagamentosPorUsuarioQuery()
    {
    }

    public Guid UsuarioId { get; set; }

}

