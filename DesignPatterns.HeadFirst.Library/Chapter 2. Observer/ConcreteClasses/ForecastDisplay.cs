using DesignPatterns.HeadFirst.Library.Chapter_2._Observer.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_2._Observer.ConcreteClasses
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        public ForecastDisplay(IWeatherDataSubject weatherDataSubject)
        {
            WeatherDataSubject = weatherDataSubject;
            WeatherDataSubject.RegisterObserver(this);
        }

        public IWeatherDataSubject WeatherDataSubject { get; private set; }

        public WeatherDataDto WeatherDataForecast { get; private set; }

        public void Update(WeatherDataDto currentWeatherData)
        {
            UpdateForecastByCurrentWeatherData(currentWeatherData);
            OnUpdated();
        }

        public void OnUpdated()
        {
            Display();
        }

        public void Display()
        {
            string forecastMessage;
            if (WeatherDataForecast.Temperature >= 60)
            {
                forecastMessage = "It will be quite warm tomorrow.";
            }
            else if (WeatherDataForecast.Temperature >= 0)
            {
                forecastMessage = "It will be chilly tomorrow.";
            }
            else
            {
                forecastMessage = "It will be too cold tomorrow. Don't forget to put on warm clothes.";
            }

            Console.WriteLine(forecastMessage);
        }

        private void UpdateForecastByCurrentWeatherData(WeatherDataDto currentWeatherData)
        {
            WeatherDataForecast = currentWeatherData;
        }
    }
}