using System;

namespace DesignPatternsDemo.BehavioralPattern.StatePattern
{
    public class GumballMachine
    {
        public readonly IState SoldOutState;

        public readonly IState SoldState;

        public readonly IState HasQuarterState;

        public readonly IState NoQuarterState;

        public readonly IState WinnerState;

        private IState _state;

        public int Count = 0;

        public GumballMachine(int numberGumballs)
        {
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldOutState = new SoldOutState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            
            Count = numberGumballs;
            
            if (numberGumballs > 0)
            {
                _state = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrack()
        {
            _state.TurnCrack();
            
            _state.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot");

            if (Count != 0)
            {
                Count--;
            }
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetState()
        {
            return _state;
        }
    }
}