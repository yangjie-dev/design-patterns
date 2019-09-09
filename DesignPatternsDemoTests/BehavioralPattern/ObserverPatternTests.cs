using DesignPatternsDemo.BehavioralPattern.ObserverPattern;
using Xunit;

namespace DesignPatternsDemoTests.BehavioralPattern
{
    public class ObserverPatternTests
    {
        [Fact]
        public void ShouldObserveUpdate()
        {
            var weatherData = new WeatherData();

            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
        }
    }
}