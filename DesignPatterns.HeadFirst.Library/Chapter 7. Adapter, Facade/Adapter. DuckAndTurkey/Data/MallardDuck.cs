namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._DuckAndTurkey.Data
{
    public class MallardDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }

        public void Fly(double distance)
        {
            Console.WriteLine($"I flew {distance} meters!");
        }
    }
}