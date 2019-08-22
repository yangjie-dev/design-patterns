namespace DesignPatternsDemo.BehavioralPattern.CommandPattern
{
    public class FanHighCommand : ICommand
    {
        private readonly Fan _fan;

        public FanHighCommand(Fan fan)
        {
            _fan = fan;
        }

        private int _prevSpeed;

        public string Execute()
        {
            _prevSpeed = _fan.Speed;

            return _fan.SetHigh();
        }

        public string Undo()
        {
            if (_prevSpeed.Equals(Fan.High))
            {
                _fan.SetHigh();
            }

            if (_prevSpeed.Equals(Fan.Medium))
            {
                _fan.SetMedium();
            }

            if (_prevSpeed.Equals(Fan.Low))
            {
                _fan.SetLow();
            }

            if (_prevSpeed.Equals(Fan.Off))
            {
                _fan.SetOff();
            }

            return "fan set speed error";
        }
    }
}