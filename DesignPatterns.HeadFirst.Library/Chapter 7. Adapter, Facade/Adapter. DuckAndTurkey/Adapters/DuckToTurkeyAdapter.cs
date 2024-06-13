using DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._DuckAndTurkey.Data;

namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._DuckAndTurkey.Adapters
{
    public class DuckToTurkeyAdapter : ITurkey
    {
        public DuckToTurkeyAdapter(IDuck duck)
        {
            _duck = duck;
        }

        private readonly IDuck _duck;

        public void Gobble()
        {
            _duck.Quack();
        }

        public void Fly(double distance)
        {
            _duck.Fly(distance);
        }
    }
}