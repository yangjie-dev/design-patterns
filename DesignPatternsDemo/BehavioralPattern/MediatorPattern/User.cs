using System;

namespace DesignPatternsDemo.BehavioralPattern.MediatorPattern
{
    public class User : IUser
    {
        public string Name { get; set; }
     
        public ChatRoom ChatRoom { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void SendMessage(Message message)
        {
            ChatRoom.TransmitMessage(message);
        }

        public void ReceiveMessage(Message message)
        {
            Console.WriteLine("From {0}: {1}", message.FromUser.Name, message.Content);
        }
    }
}