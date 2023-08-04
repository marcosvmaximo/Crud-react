using System;
using TesteWeb.Core.Domain.Interfaces;

namespace TesteWeb.Core.Data;

public interface IRepository<TEntity> where TEntity : IAggregateRoot
{
}

