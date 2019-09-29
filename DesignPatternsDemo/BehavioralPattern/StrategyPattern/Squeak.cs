using System;

namespace DesignPatternsDemo.BehavioralPattern.StrategyPattern
{
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("squeak");
        }
    }
}