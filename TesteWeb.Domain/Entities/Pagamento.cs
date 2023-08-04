using TesteWeb.Core.Domain;
using TesteWeb.Core.Domain.Interfaces;
using TesteWeb.Domain.Enum;

namespace TesteWeb.Domain.Entities;

public class Pagamento : Entity
{
    public Pagamento(ETipoPagamento tipoPagamento, DateTime data, decimal valor, Guid usuarioId)
    {
        TipoPagamento = tipoPagamento;
        Data = data;
        Valor = valor;
        UsuarioId = usuarioId;
    }

    public ETipoPagamento TipoPagamento { get; private set; }
    public DateTime Data { get; private set; }
    public decimal Valor { get; private set; }
    public Guid UsuarioId { get; private set; }
}

