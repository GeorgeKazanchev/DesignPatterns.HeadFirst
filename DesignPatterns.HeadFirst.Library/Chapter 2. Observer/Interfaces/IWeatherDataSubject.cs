namespace DesignPatterns.HeadFirst.Library.Chapter_2._Observer.Interfaces
{
    public interface IWeatherDataSubject
    {
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObservers();
    }
}