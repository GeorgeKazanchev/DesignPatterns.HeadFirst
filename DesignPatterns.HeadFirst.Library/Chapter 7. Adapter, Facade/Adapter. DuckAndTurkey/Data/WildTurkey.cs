namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._DuckAndTurkey.Data
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble, gobble!");
        }

        public void Fly(double distance)
        {
            Console.WriteLine($"I could fly {distance} meters!");
        }
    }
}