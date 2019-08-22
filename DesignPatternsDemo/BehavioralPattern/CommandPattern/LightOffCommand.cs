namespace DesignPatternsDemo.BehavioralPattern.CommandPattern
{
    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public string Execute()
        {
            return _light.Off();
        }

        public string Undo()
        {
            return _light.On();
        }
    }
}