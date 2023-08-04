using System;
using MediatR;
using TesteWeb.Core.Application.Common;
using TesteWeb.Core.Domain;

namespace TesteWeb.Core.Application;

public abstract class Query<T> : Message, IRequest<BaseResult<T>> where T : class
{
    public Query()
    {
    }
}

