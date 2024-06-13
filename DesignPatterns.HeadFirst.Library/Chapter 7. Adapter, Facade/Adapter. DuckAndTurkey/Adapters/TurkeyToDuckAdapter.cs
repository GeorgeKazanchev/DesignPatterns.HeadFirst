using DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._DuckAndTurkey.Data;

namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._DuckAndTurkey.Adapters
{
    public class TurkeyToDuckAdapter : IDuck
    {
        public TurkeyToDuckAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }

        private readonly ITurkey _turkey;

        public void Quack()
        {
            _turkey.Gobble();
        }

        public void Fly(double distance)
        {
            double turkeyFlyingDistance = distance <= ITurkey.MaxFlyingDistance ? distance : ITurkey.MaxFlyingDistance;
            _turkey.Fly(turkeyFlyingDistance);
        }
    }
}