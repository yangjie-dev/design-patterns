namespace DesignPatternsDemo.BehavioralPattern.StatePattern
{
    public interface IState
    {
        void InsertQuarter();

        void EjectQuarter();

        void TurnCrack();

        void Dispense();
    }
}