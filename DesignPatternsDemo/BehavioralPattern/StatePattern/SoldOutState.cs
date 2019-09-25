using System;

namespace DesignPatternsDemo.BehavioralPattern.StatePattern
{
    public class SoldOutState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void TurnCrack()
        {
            Console.WriteLine("You turned, the machine is sold out");
        }

        public void Dispense()
        {
            Console.WriteLine("No Gumball dispensed");
        }
    }
}