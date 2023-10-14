using DesignPatterns.HeadFirst.Library.Chapter_2._Observer.ConcreteClasses;
using DesignPatterns.HeadFirst.Library.Chapter_2._Observer;

namespace DesignPatterns.HeadFirst.App.Chapter_2._Observer
{
    public static class WeatherStation
    {
        public static void Run()
        {
            WeatherData weatherDataSubject = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherDataSubject);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherDataSubject);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherDataSubject);

            weatherDataSubject.SetMeasurementsAndDisplayData(new WeatherDataDto { Temperature = 80.0, Humidity = 65.0, Pressure = 30.4 });
            weatherDataSubject.SetMeasurementsAndDisplayData(new WeatherDataDto { Temperature = 82.0, Humidity = 70.0, Pressure = 29.2 });
            weatherDataSubject.SetMeasurementsAndDisplayData(new WeatherDataDto { Temperature = 78.0, Humidity = 90.0, Pressure = 29.2 });
        }

        public static void SetMeasurementsAndDisplayData(this WeatherData weatherDataSubject, WeatherDataDto currentWeatherData)
        {
            weatherDataSubject.SetMeasurements(currentWeatherData);
            Console.WriteLine();
        }
    }
}