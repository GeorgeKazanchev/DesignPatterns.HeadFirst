namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command
{
    public class Light
    {
        public Light(string location)
        {
            Location = location;
        }

        public string Location { get; private set; }

        public void On()
        {
            Console.WriteLine("Light is On");
        }

        public void Off()
        {
            Console.WriteLine("Light is Off");
        }
    }
}