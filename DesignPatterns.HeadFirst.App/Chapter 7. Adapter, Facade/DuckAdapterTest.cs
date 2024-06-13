using DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._DuckAndTurkey.Adapters;
using DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._DuckAndTurkey.Data;

namespace DesignPatterns.HeadFirst.App.Chapter_7._Adapter__Facade
{
    public class DuckAdapterTest
    {
        public static void Run()
        {
            IDuck duck = new MallardDuck();
            TestDuck(duck);

            ITurkey turkey = new WildTurkey();
            IDuck adaptedTurkey = new TurkeyToDuckAdapter(turkey);
            TestDuck(adaptedTurkey);
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly(distance: ITurkey.MaxFlyingDistance * 2);
        }
    }
}