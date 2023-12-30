namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects
{
    public class Tv
    {
        public Tv(string location)
        {
            Location = location;
        }

        public string Location { get; private set; }
        public uint Channel { get; private set; }
        public uint Volume { get; private set; }

        public void On()
        {
            Console.WriteLine("Tv is switched on");
        }

        public void Off()
        {
            Console.WriteLine("Tv is switched off");
        }

        public void SetInputChannel(uint channel)
        {
            Channel = channel;
        }

        public void SetVolume(uint volume)
        {
            Volume = volume;
        }
    }
}