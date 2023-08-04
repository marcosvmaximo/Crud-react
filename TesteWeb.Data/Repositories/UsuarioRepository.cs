using System;
using TesteWeb.Data.Context;
using TesteWeb.Domain;
using TesteWeb.Domain.Entities;
using TesteWeb.Domain.Interfaces;

namespace TesteWeb.Data.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    public UsuarioRepository()
    {
    }

    public async Task DeletarPagamento(Guid pagamentoId)
    {
        LeitorExcel.DeletarPagamento(pagamentoId);
    }

    public async Task<List<Usuario>> ObterListaUsuarios()
    {
        return LeitorExcel.Usuarios().ToList();
    }

    public async Task<List<Pagamento>> ObterPagamentosPorUsuario(Guid usuarioId)
    {
        return LeitorExcel.Pagamentos(usuarioId).ToList();
    }

    public async Task<Usuario> ObterUsuario(Guid usuarioId)
    {
        return LeitorExcel.Usuarios(usuarioId);

    }
}

