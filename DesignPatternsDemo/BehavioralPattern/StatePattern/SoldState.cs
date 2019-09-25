using System;

namespace DesignPatternsDemo.BehavioralPattern.StatePattern
{
    public class SoldState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crack");
        }

        public void TurnCrack()
        {
            Console.WriteLine("Turning twice doesn't give you another gumball");
        }

        public void Dispense()
        {
            Console.WriteLine("A gumball comes rolling out the slot ");

            _gumballMachine.ReleaseBall();

            if (_gumballMachine.Count.Equals(0))
            {
                Console.WriteLine("Out of gumballs");

                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }

            else
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
        }
    }
}