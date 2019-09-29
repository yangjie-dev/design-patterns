using DesignPatternsDemo.BehavioralPattern.StrategyPattern;
using Xunit;

namespace DesignPatternsDemoTests.BehavioralPattern
{
    public class StrategyPatternTests
    {
        [Fact]
        public void ShouldGetRubberDuckCanSwimButNotFlyAndSqueakQuack()
        {
            var quack = new RubberDuck();
            
            quack.SetFlyBehaviour(new FlyNoWay());
            
            quack.SetQuackBehaviour(new Squeak());
            
            quack.Display();
            
            quack.PerformQuack();
            
            quack.Swim();
            
            quack.Display();
        }
    }
}