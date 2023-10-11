using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}