using System;
namespace TesteWeb.Core.Application.Common;

public abstract class Message
{
    public Guid AggregrateId { get; protected set; }
    public string MessageType { get; protected set; }

    public Message()
    {
        MessageType = GetType().Name;
    }
}

