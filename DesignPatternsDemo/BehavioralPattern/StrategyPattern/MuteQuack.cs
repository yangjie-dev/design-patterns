using System;

namespace DesignPatternsDemo.BehavioralPattern.StrategyPattern
{
    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("mute quack");
        }
    }
}