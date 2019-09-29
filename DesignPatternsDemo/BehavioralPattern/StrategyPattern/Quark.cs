using System;

namespace DesignPatternsDemo.BehavioralPattern.StrategyPattern
{
    public class Quark : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("quack");
        }
    }
}