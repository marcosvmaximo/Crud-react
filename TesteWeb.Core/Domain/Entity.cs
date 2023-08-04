using System;
namespace TesteWeb.Core.Domain;

public abstract class Entity
{
    public Entity()
    {
        Id = Guid.NewGuid();
        DataCriacao = DateTime.Now;
    }

    public Guid Id { get; set; } // Para settar do arquivo excell
    public DateTime DataCriacao { get; private set; }
}

