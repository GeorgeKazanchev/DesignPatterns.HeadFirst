namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects
{
    public class CeilingFan
    {
        public CeilingFan(string location)
        {
            Location = location;
            Speed = FanSpeed.Off;
        }

        public string Location { get; private set; }
        public FanSpeed Speed { get; private set; }

        public void On(FanSpeed speed = FanSpeed.Medium)
        {
            Speed = speed;
            Console.WriteLine("Fan is On");
        }

        public void Off()
        {
            Console.WriteLine($"{Location} ceiling fan is off");
        }

        public void SetHighSpeed()
        {
            Speed = FanSpeed.High;
            Console.WriteLine($"{Location} ceiling fan is on high");
        }

        public void SetMediumSpeed()
        {
            Speed = FanSpeed.Medium;
            Console.WriteLine($"{Location} ceiling fan is on medium");
        }

        public void SetLowSpeed()
        {
            Speed = FanSpeed.Low;
            Console.WriteLine($"{Location} ceiling fan is on low");
        }
    }
}