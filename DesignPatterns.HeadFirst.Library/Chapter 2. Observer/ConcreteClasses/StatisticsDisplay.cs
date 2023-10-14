using DesignPatterns.HeadFirst.Library.Chapter_2._Observer.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_2._Observer.ConcreteClasses
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        public StatisticsDisplay(IWeatherDataSubject weatherDataSubject)
        {
            WeatherDataSubject = weatherDataSubject;
            WeatherDataSubject.RegisterObserver(this);
        }

        public IWeatherDataSubject WeatherDataSubject { get; private set; }

        public WeatherDataDto MinTemperatureDataDto { get; private set; }

        public WeatherDataDto AvgTemperatureDataDto { get; private set; }

        public WeatherDataDto MaxTemperatureDataDto { get; private set; }

        public void Update(WeatherDataDto currentWeatherData)
        {
            UpdateStatisticsByCurrentWeatherData(currentWeatherData);
            OnUpdated();
        }

        public void OnUpdated()
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = " +
                $"{MinTemperatureDataDto.Temperature}/{AvgTemperatureDataDto.Temperature}/{MaxTemperatureDataDto.Temperature}");
        }

        private void UpdateStatisticsByCurrentWeatherData(WeatherDataDto currentWeatherData)
        {
            MinTemperatureDataDto = currentWeatherData;
            AvgTemperatureDataDto = currentWeatherData;
            MaxTemperatureDataDto = currentWeatherData;
        }
    }
}