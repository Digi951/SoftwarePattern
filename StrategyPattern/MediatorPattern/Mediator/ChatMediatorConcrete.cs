using System;
using MediatorPattern.Colleague;

namespace MediatorPattern.Mediator
{
    public class ChatMediatorConcrete : IChatMediator
    {
        private List<User> _users;

        public ChatMediatorConcrete()
        {
            _users = new List<User>();
        }

        public void AddUder(User user)
        {
            _users.Add(user);
        }

        public void SendBroadcast(string message, User user)
        {
            foreach (var u in _users)
            {
                if (u != user)
                {
                    u.ReceiveMessage(message);
                }
            }
        }

        public void SendPrivateMessage(string message, User targetUser)
        {
            targetUser.ReceiveMessage(message);
        }
    }
}

