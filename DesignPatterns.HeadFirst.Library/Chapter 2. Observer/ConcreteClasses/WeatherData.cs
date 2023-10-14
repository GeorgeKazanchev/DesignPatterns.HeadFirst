using DesignPatterns.HeadFirst.Library.Chapter_2._Observer.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_2._Observer.ConcreteClasses
{
    public class WeatherData : IWeatherDataSubject
    {
        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        private List<IObserver> observers;
        private WeatherDataDto weatherData;

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                _ = observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            observers.ForEach(o => o.Update(weatherData));
        }

        public void OnMeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(WeatherDataDto weatherData)
        {
            this.weatherData = weatherData;
            OnMeasurementsChanged();
        }
    }
}