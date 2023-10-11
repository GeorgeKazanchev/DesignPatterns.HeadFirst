using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly...");
        }
    }
}