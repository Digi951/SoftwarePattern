using System;
using MediatorPattern.Mediator;

namespace MediatorPattern.Colleague;

public abstract class User
{
    public IChatMediator Mediator { get; set; }
    public String Name { get; set; }

    public User(String name, IChatMediator mediator)
    {
        Mediator = mediator;
        Name = name;
    }

    public abstract void SendBroadcast(String message);
    public abstract void SendPrivateMessage(String message, User targetUser);
    public abstract void ReceiveMessage(String message);
}

