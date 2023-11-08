namespace DesignPatterns.HeadFirst.Library.Chapter_3._Decorator.Coffee
{
    public class Decaf : Beverage
    {
        #region Constructors

        public Decaf(Size size)
        {
            Description = "Caffeine Free Coffee";
            Size = size;
        }

        #endregion

        #region Properties

        public override decimal Cost => 1.05m;

        public override string Description { get; }

        #endregion
    }
}