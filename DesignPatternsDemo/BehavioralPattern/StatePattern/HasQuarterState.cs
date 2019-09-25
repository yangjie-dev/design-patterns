using System;

namespace DesignPatternsDemo.BehavioralPattern.StatePattern
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        private readonly Random _random;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
            
            _random = new Random();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert any quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void TurnCrack()
        {
            Console.WriteLine("You turned...");

            var winner = _random.Next(10);

            if (winner.Equals(0) && _gumballMachine.Count > 2)
            {
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            
            _gumballMachine.SetState(_gumballMachine.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed, you need to turn crack to get gumball");
        }
    }
}