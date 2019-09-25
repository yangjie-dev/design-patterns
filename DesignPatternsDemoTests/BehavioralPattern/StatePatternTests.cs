using DesignPatternsDemo.BehavioralPattern.StatePattern;
using Xunit;

namespace DesignPatternsDemoTests.BehavioralPattern
{
    public class StatePatternTests
    {
        [Fact]
        public void ShouldCorrectTransferState()
        {
            var gumballMachine = new GumballMachine(10);
            
            Assert.Equal(gumballMachine.GetState().GetType(), typeof(NoQuarterState));
            
            gumballMachine.InsertQuarter();
            
            Assert.Equal(gumballMachine.GetState().GetType(), typeof(HasQuarterState));
            
            gumballMachine.EjectQuarter();
            
            Assert.Equal(gumballMachine.GetState().GetType(), typeof(NoQuarterState));
        }
    }
}