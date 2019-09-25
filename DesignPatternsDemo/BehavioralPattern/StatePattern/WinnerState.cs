using System;

namespace DesignPatternsDemo.BehavioralPattern.StatePattern
{
    public class WinnerState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Error");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Error");
        }

        public void TurnCrack()
        {
            Console.WriteLine("Error");
        }

        public void Dispense()
        {
            Console.WriteLine("You're a winner! You get two gumballs for your quarter");

            _gumballMachine.ReleaseBall();

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