namespace DesignPatternsDemo.BehavioralPattern.ObserverPattern
{
    public interface IObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}