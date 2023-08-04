using System;
using TesteWeb.Core.Domain;
using TesteWeb.Core.Domain.Interfaces;
using TesteWeb.Domain.Entities;

namespace TesteWeb.Domain;

public class Usuario : Entity, IAggregateRoot
{
    private readonly List<Pagamento> _pagamentos;

    public Usuario(string nome)
    {
        Nome = nome;
        _pagamentos = new List<Pagamento>();
    }

    public string Nome { get; private set; }
    public IReadOnlyCollection<Pagamento> Pagamentos => _pagamentos;
}

