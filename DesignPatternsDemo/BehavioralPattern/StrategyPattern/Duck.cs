using System;

namespace DesignPatternsDemo.BehavioralPattern.StrategyPattern
{
    public abstract class Duck
    {
        private IFlyBehaviour _flyBehaviour;

        private IQuackBehaviour _quackBehaviour;

        public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
        {
            _flyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
        {
            _quackBehaviour = quackBehaviour;
        }

        public void PerformFly()
        {
            _flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            _quackBehaviour.Quack();
        }

        public abstract void Display();    
       
        
        public void Swim()
        {
            Console.WriteLine("swim");
        }
    }
}