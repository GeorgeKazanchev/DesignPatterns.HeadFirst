using DesignPatterns.HeadFirst.Library.Chapter_2._Observer.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_2._Observer.ConcreteClasses
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        public CurrentConditionsDisplay(IWeatherDataSubject weatherDataSubject)
        {
            WeatherDataSubject = weatherDataSubject;
            WeatherDataSubject.RegisterObserver(this);
        }

        public IWeatherDataSubject WeatherDataSubject { get; private set; }

        public WeatherDataDto CurrentWeatherData { get; private set; }

        public void Update(WeatherDataDto currentWeatherData)
        {
            CurrentWeatherData = currentWeatherData;
            OnUpdated();
        }

        public void OnUpdated()
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {CurrentWeatherData.Temperature} F degrees " +
                $"and humidity {CurrentWeatherData.Humidity} % humidity");
        }
    }
}