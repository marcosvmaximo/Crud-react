using System;
using MediatR;
using TesteWeb.Core.Application.Common;
using TesteWeb.Core.Domain;

namespace TesteWeb.Core.Application;

public abstract class Command<T> : Message, IRequest<BaseResult<T>> where T : Entity
{
    public Command()
    {
    }
}

