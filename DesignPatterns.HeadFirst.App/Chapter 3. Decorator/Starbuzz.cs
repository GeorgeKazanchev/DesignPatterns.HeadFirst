using DesignPatterns.HeadFirst.Library.Chapter_3._Decorator;
using DesignPatterns.HeadFirst.Library.Chapter_3._Decorator.Coffee;
using DesignPatterns.HeadFirst.Library.Chapter_3._Decorator.Decorators;

namespace DesignPatterns.HeadFirst.App.Chapter_3._Decorator
{
    public static class Starbuzz
    {
        public static void Run()
        {
            Beverage beverage1 = new Espresso(Size.Tall);
            Console.WriteLine(beverage1.ToString());

            Beverage beverage2 = new DarkRoast(Size.Grande);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.ToString());

            Beverage beverage3 = new HouseBlend(Size.Venti);
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.ToString());
        }
    }
}