namespace DesignPatterns.HeadFirst.Library.Chapter_6._Command.ControlObjects
{
    public class GarageDoor
    {
        public GarageDoor(string location)
        {
            Location = location;
        }

        public string Location { get; private set; }

        public void Up()
        {
            Console.WriteLine("Garage Door is Open");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is Closed");
        }
    }
}