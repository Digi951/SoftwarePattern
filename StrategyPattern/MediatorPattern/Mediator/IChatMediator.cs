using System;
using MediatorPattern.Colleague;

namespace MediatorPattern.Mediator;

public interface IChatMediator
{
    void SendBroadcast(String message, User selfUser);
    void SendPrivateMessage(String message, User targetUser);
    void AddUder(User user);
}

