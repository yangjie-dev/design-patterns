using System;

namespace DesignPatternsDemo.BehavioralPattern.StrategyPattern
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("rubber duck");
        }
    }
}