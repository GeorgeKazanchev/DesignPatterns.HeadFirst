using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Interfaces;

namespace DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations
{
    public class MuteQuack : ISoundBehaviour
    {
        public void MakeSound()
        {
            Console.WriteLine("*The duck is remaining silent*");
        }
    }
}