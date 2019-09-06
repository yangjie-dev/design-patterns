namespace DesignPatternsDemo.BehavioralPattern.MediatorPattern
{
    public interface IUser
    {
        string Name { get; set; }
        
        ChatRoom ChatRoom { get; set; }
        
        void SendMessage(Message message);

        void ReceiveMessage(Message message);
    }
}