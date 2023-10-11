using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations
{
    public class Squeak : ISoundBehaviour
    {
        public void MakeSound()
        {
            Console.WriteLine("Squeak!");
        }
    }
}