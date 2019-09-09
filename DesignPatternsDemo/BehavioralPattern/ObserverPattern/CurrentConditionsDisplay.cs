using System;

namespace DesignPatternsDemo.BehavioralPattern.ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;

        private float _humidity;

        private float _pressure;

        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;

            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _temperature = temp;

            _humidity = humidity;

            _pressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: {0} F degrees and {1} humidity and {2} pressure", _temperature,
                _humidity, _pressure);
        }
    }
}