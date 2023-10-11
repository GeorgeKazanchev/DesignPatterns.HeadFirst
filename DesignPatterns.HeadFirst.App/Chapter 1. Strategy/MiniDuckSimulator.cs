using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.Ducks;
using DesignPatterns.HeadFirst.Library.Chapter_1._Strategy.InterfaceImplementations;

namespace DesignPatterns.HeadFirst.App.Chapter_1
{
    public static class MiniDuckSimulator
    {
        public static void Run()
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformSound();

            Console.WriteLine();
            Duck strangeDuck = new DecoyDuck();
            strangeDuck.PerformFly();
            strangeDuck.SetFlyBehaviour(new JetPoweredFly());
            strangeDuck.PerformFly();
        }
    }
}