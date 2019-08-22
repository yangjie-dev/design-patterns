namespace DesignPatternsDemo.BehavioralPattern.CommandPattern
{
    public class FanOffCommand : ICommand
    {
        private readonly Fan _fan;

        private int _prevSpeed;

        public FanOffCommand(Fan fan)
        {
            _fan = fan;
        }

        public string Execute()
        {
            _prevSpeed = _fan.Speed;

            return _fan.SetOff();
        }

        public string Undo()
        {
            switch (_prevSpeed)
            {
                case Fan.High:
                    return _fan.SetHigh();
                case Fan.Medium:
                    return _fan.SetMedium();
                case Fan.Low:
                    return _fan.SetLow();
                case Fan.Off:
                    return _fan.SetOff();
                default:
                    return "fan set speed error";
            }
        }
    }
}