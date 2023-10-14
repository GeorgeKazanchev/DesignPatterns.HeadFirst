namespace DesignPatterns.HeadFirst.Library.Chapter_2._Observer
{
    public struct WeatherDataDto
    {
        public WeatherDataDto()
        {
            Temperature = 0.0;
            Humidity = 0.0;
            Pressure = 0.0;
        }

        public double Temperature { get; set; }
        
        public double Humidity { get; set; }

        public double Pressure { get; set; }
    }
}