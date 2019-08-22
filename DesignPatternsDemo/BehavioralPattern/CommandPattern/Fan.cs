namespace DesignPatternsDemo.BehavioralPattern.CommandPattern
{
    public class Fan
    {
        public const int High = 3;

        public const int Medium = 2;

        public const int Low = 1;

        public const int Off = 0;

        public int Speed { get; private set; }

        public Fan()
        {
            Speed = Off;
        }

        public string SetHigh()
        {
            Speed = High;

            return "fan high";
        }

        public string SetMedium()
        {
            Speed = Medium;

            return "fan medium";
        }

        public string SetLow()
        {
            Speed = Low;

            return "fan low";
        }

        public string SetOff()
        {
            Speed = Off;

            return "fan off";
        }
    }
}