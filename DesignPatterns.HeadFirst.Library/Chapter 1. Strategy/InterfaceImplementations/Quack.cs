using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations
{
    public class Quack : ISoundBehaviour
    {
        public void MakeSound()
        {
            Console.WriteLine("Quack!");
        }
    }
}