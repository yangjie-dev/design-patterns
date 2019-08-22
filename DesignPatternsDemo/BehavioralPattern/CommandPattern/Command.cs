namespace DesignPatternsDemo.BehavioralPattern.CommandPattern
{
    public interface ICommand
    {
        string Execute();

        string Undo();
    }
}