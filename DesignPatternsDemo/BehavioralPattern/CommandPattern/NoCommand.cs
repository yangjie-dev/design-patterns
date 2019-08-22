namespace DesignPatternsDemo.BehavioralPattern.CommandPattern
{
    public class NoCommand : ICommand
    {
        public string Execute()
        {
            return null;
        }

        public string Undo()
        {
            return null;
        }
    }
}