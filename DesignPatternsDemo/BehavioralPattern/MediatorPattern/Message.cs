namespace DesignPatternsDemo.BehavioralPattern.MediatorPattern
{
    public class Message
    {
        public Message(string content, User toUser, User fromUser)
        {
            Content = content;
            ToUser = toUser;
            FromUser = fromUser;
        }

        public User FromUser { get; set; }
        
        public User ToUser { get; set; }
        
        public string Content { get; set; }
    }
}