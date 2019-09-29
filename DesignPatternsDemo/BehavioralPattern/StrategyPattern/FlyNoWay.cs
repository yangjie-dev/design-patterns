using System;

namespace DesignPatternsDemo.BehavioralPattern.StrategyPattern
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("fly no way");
        }
    }
}