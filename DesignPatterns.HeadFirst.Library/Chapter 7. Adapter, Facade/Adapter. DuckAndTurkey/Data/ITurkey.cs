namespace DesignPatterns.HeadFirst.Library.Chapter_7._Adapter__Facade.Adapter._DuckAndTurkey.Data
{
    public interface ITurkey
    {
        public static readonly double MaxFlyingDistance = 10;
        public void Gobble();
        public void Fly(double distance);
    }
}