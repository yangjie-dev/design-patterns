using System;

namespace DesignPatternsDemo.BehavioralPattern.StrategyPattern
{
    public class ReadHeadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("read head duck");
        }
    }
}