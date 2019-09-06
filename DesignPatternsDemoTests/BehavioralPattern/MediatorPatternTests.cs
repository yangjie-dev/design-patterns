using DesignPatternsDemo.BehavioralPattern.MediatorPattern;
using Xunit;

namespace DesignPatternsDemoTests.BehavioralPattern
{
    public class MediatorPatternTests
    {
        [Fact]
        public void ShouldSendMessageByMediatorTransmit()
        {
            var jane = new User("Jane");

            var andrew = new User("Andrew");

            var chatRoom = new ChatRoom();

            chatRoom.AddUser(jane);

            chatRoom.AddUser(andrew);

            jane.SendMessage(new Message("Hello Andrew", andrew, jane));

            andrew.SendMessage(new Message("Hello Jane", jane, andrew));
        }
    }
}