using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsDemo.BehavioralPattern.MediatorPattern
{
    public class ChatRoom
    {
        private readonly List<User> _users;

        public ChatRoom()
        {
            _users = new List<User>();
        }

        public void TransmitMessage(Message message)
        {
            _users.First(user => user.Name.Equals(message.ToUser.Name)).ReceiveMessage(message);
        }

        public void AddUser(User user)
        {
            _users.Add(user);

            user.ChatRoom = this;
        }
    }
}