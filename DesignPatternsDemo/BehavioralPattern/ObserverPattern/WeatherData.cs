using System.Collections.Generic;

namespace DesignPatternsDemo.BehavioralPattern.ObserverPattern
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;

        private float _temperature;

        private float _humidity;

        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_temperature, _humidity, _pressure));
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            _humidity = humidity;
            _temperature = temperature;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}