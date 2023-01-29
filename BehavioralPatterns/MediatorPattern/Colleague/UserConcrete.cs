using System;
using MediatorPattern.Mediator;

namespace MediatorPattern.Colleague;

public class UserConcrete : User
{
    public UserConcrete(string name, IChatMediator mediator) : base(name, mediator)
    {
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"{Name} hat folgende Nachricht erhalten: \n{message}");
    }

    public override void SendBroadcast(string message)
    {
        Console.WriteLine($"{Name}: {message}");
        Mediator.SendBroadcast(message, this);
    }

    public override void SendPrivateMessage(string message, User targetUser)
    {
        Mediator.SendPrivateMessage(message, targetUser);
    }
}

