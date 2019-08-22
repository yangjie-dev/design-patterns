namespace DesignPatternsDemo.BehavioralPattern.CommandPattern
{
    public class LightOnCommand : ICommand
    {
        private readonly Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public string Execute()
        {
            return _light.On();
        }

        public string Undo()
        {
            return _light.Off();
        }
    }
}