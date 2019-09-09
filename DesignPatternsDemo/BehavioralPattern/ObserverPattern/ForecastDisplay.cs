using System;

namespace DesignPatternsDemo.BehavioralPattern.ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _temperature;

        private float _humidity;

        private ISubject _weatherData;

        public ForecastDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;

            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            _humidity = humidity;

            _temperature = temp;
            
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Forecast: {0} degrees and {1} humidity", _temperature, _humidity);
        }
    }
}