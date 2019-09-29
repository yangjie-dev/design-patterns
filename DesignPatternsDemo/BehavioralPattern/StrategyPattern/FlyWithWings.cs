using System;

namespace DesignPatternsDemo.BehavioralPattern.StrategyPattern
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("fly with wings");
        }
    }
}