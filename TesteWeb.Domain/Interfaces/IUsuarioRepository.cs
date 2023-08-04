using System;
using TesteWeb.Core.Data;
using TesteWeb.Domain.Entities;

namespace TesteWeb.Domain.Interfaces;

public interface IUsuarioRepository : IRepository<Usuario>
{
    Task<List<Usuario>> ObterListaUsuarios();
    Task<List<Pagamento>> ObterPagamentosPorUsuario(Guid usuarioId);
    Task DeletarPagamento(Guid pagamentoId);
    Task<Usuario> ObterUsuario(Guid usuarioId);
}

